using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;

namespace PasswordVault2
{
    public class PasswordVault
    {

        string key;
        public string passwordHash;
        string answersHash;
        string encryptedAnswers;
        string plaintextAnswers;
        string passwordEncryptedKey;
        string answersEncryptedKey;
        crypto dataCh, passwordCh, answersCh;
        HashManager hm;
        List<Account> accounts;
        public BindingList<string> accountDescriptions;
        string questions;
        bool authenticated;

        public static int cryptoIterations = 5;
        public static int hashIterations = 57;
        public static string file = "dat0";

        public PasswordVault()
        {
            hm = new HashManager("SHA512",hashIterations);
            authenticated = false;
        }

        public Result createDB(string password, string concatenatedAnswers, string q1, string q2, string q3)
        {
            Result r = new Result();
            try
            {
                plaintextAnswers = null;
                //Get recovery question indexes
                RecoveryQuestions rq = new RecoveryQuestions();
                rq.create();
                int question1 = rq.get_index(q1);
                int question2 = rq.get_index(q2);
                int question3 = rq.get_index(q3);
                TextWriter tw = new StreamWriter(file);
                accounts = new List<Account>();
                accountDescriptions = new BindingList<string>();

                //Generate Key
                key = crypto.GeneratePassword(32, 32);

                //Write Watermark
                tw.WriteLine(@"5bd96c23e5830933b30475720781db2f");

                //Write the password hash
                tw.WriteLine(hm.compute(password, true));

                //Initialize the key encrypter
                passwordCh = new crypto(password, cryptoIterations);

                //Create the encryption key
                passwordEncryptedKey = passwordCh.Encrypt(key);

                //Write the encryption key encrypted by the password
                tw.WriteLine(passwordEncryptedKey);

                //Write the answers hash
                tw.WriteLine(hm.compute(concatenatedAnswers, true));

                //create the crypto handler
                dataCh = new crypto(key, cryptoIterations);

                //Write the answers encrypted by the password
                encryptedAnswers = passwordCh.Encrypt(concatenatedAnswers);
                tw.WriteLine(encryptedAnswers);

                //Initialize the recovery key encrypter
                answersCh = new crypto(concatenatedAnswers, cryptoIterations);

                //Write the question numbers
                questions = question1 + "," + question2 + "," + question3;
                tw.WriteLine(questions);

                //Write the encryption key encrypted by the recovery answers
                answersEncryptedKey = answersCh.Encrypt(key);
                tw.WriteLine(answersEncryptedKey);

                //Close the file
                tw.Close();

                /* r = createRecoveryFile(password, concatenatedAnswers);
                if (!r.success()) return r; */
                r.successful();
            }
            catch (Exception e)
            {
                r.failure("A problem was encountered while creating the database", e);
            }

            return r;
        }

        public Result recoverKey(string answer1, string answer2, string answer3)
        {
            Result r = new Result();
            try
            {
                plaintextAnswers = (answer1 + answer2 + answer3).ToUpper();
                TextReader tr = new StreamReader(file);
                string currentLine,
                       recoveredKey;

                //Check for thumbprint
                currentLine = tr.ReadLine();
                if (currentLine != @"5bd96c23e5830933b30475720781db2f")
                {
                    r.failure("Your Password Vault data file seems to be corrupt");
                    return r;
                }

                //Skip the next 2 lines of the file
                tr.ReadLine(); //Password Hash
                tr.ReadLine(); //key encrypted by password

                //Get recovery password hash & compare to submitted answers
                currentLine = tr.ReadLine();
                if (!hm.verify(plaintextAnswers, currentLine))
                {
                    r.failure("One or more of the answers submitted were incorrect.");
                    return r;
                }

                //Read the Answers encrypted by password
                encryptedAnswers = tr.ReadLine();

                //Get the recovery question numbers
                questions = tr.ReadLine();

                //Initialize the cryptoHanlder
                answersCh = new crypto(plaintextAnswers, cryptoIterations);

                //Get the Recovery-encrypted key
                currentLine = tr.ReadLine();

                //Decrypt the key
                recoveredKey = answersCh.Decrypt(currentLine);

                //Close the file stream
                tr.Close();

                //Return the decrypted key in the result
                r.successful(recoveredKey);
                return r;
            }
            catch (Exception e)
            {
                r.failure("An exception occurred while attempting to recover your password database:", e);
                return r;
            }
        }

        /*public Result reCreate(string recoveredKey, string old_password, string new_password)
        {

            string question1,
                question2,
                question3,
                concatenatedAnswers;

            Result r = new Result();

            try
            {
                //Get the recovery questions
                RecoveryQuestions rq = new RecoveryQuestions();
                rq.create();
                string[] qNums = questions.Split(',');
                question1 = rq.get_text(Convert.ToInt16(qNums[0]));
                question2 = rq.get_text(Convert.ToInt16(qNums[1]));
                question3 = rq.get_text(Convert.ToInt16(qNums[2]));

                //Delete the old database file
                if (!stdlib.DeleteFile(file))
                {
                    r.failure("The file " + file + " could not be deleted");
                    return r;
                }

                //Decrypt the recovery password
                concatenatedAnswers = answersCh.Decrypt(encryptedAnswers);

                //Re-create the database (along with a new CryptoHandler
                createDB(new_password, concatenatedAnswers, question1, question2, question3);

                //Re-encrypt all the accounts with the new CryptoHandler and write them to the database file
                TextWriter tw = File.AppendText(file);
                foreach (Account a in accounts)
                {
                    a.reEncrypt(dataCh);
                    tw.WriteLine(a.get_account());
                }
                r.successful();
            }
            catch (Exception e)
            {
                r.failure("An error occurred during the database recovery", e);
            }

            return r;
        } */

        public Result reWrite()
        {
            Result r = new Result();

            try
            {
                if (!stdlib.DeleteFile(file))
                {
                    r.failure("An error occurred when attempting to replace the database file.");
                    return r;
                }

                //Open the file
                TextWriter tw = new StreamWriter(file);

                //Write the watermark
                tw.WriteLine(@"5bd96c23e5830933b30475720781db2f");

                //Write the password hash
                tw.WriteLine(passwordHash);

                //Write the encrypted key
                tw.WriteLine(passwordEncryptedKey);

                //Write the answers hash
                tw.WriteLine(answersHash);

                //Write the encrypted answers
                tw.WriteLine(encryptedAnswers);

                //Write the question numbers
                tw.WriteLine(questions);

                //Write the key encrypted by answers
                tw.WriteLine(answersEncryptedKey);

                foreach (Account a in accounts)
                {
                    tw.WriteLine(a.get_account());
                }

                //Close the file
                tw.Close();
                r.successful();
                return r;
            }

            catch (Exception e)
            {
                r.failure("An exception occurred while attempting to re-write the database file:", e);
                return r;
            }
        }

        public Result createEntry(string name, string uname, string pwd, string link)
        {
            Result r = new Result();
            try
            {
                Account a = new Account();
                a.create(name, uname, pwd, link, dataCh);
                accounts.Add(a);
                accountDescriptions.Add(a.description);
                r = writeEntry(a.get_account());
                if (!r.success())
                {
                    r.display();
                    return r;
                }
                r.successful();
            }
            catch (Exception e)
            {
                r.failure("An error occurred while creating the entry", e);
            }

            return r;
        }

        private Result writeEntry(string entry)
        {
            Result r = new Result();

            try
            {
                TextWriter tw = File.AppendText(file);
                tw.WriteLine(entry);
                tw.Close();
                r.successful();
                return r;
            }

            catch (Exception e)
            {
                r.failure("An exception occurred while writing the new entry to the database:", e);
                return r;
            }
        }

        public Account readEntry(string entry)
        {
            Account a = new Account();
            a.init(entry, dataCh);
            return a;
        }

        //Remove Entry
        public Result removeEntry(string desc)
        {
            Result r = new Result();

            try
            {
                //Remove the entry from the accounts list.
                r = removeEntryFromList(desc);
                if (!r.success()) return r;

                //Remove the entry from the database file
                r = reWrite();
                if (!r.success()) return r;

                //Remove the entry from the list of account descriptions
                accountDescriptions.Remove(desc);

                r.successful();
                return r;
            }

            catch (Exception e)
            {
                r.failure("An error occurred while removing the entry", e);
            }

            return r;
        }

        private Result removeEntryFromList(string desc)
        {
            Result r = new Result();

            try
            {
                //Remove the entry from the list of accounts
                foreach (Account a in accounts)
                {
                    if (String.Equals(desc, a.description))
                    {
                        accounts.Remove(a);
                        r.successful();
                        return r;
                    }
                }

                r.failure("Entry was not found");
            }

            catch (Exception e)
            {
                r.failure("An error occurred while removing the entry:", e);
            }

            return r;
        }

        //Edit Entry
        public Result editEntry(string old_desc, string newName, string newUsername, string newPassword, string newURL)
        {
            Result r = new Result();

            try
            {
                accountDescriptions.Remove(old_desc);

                foreach (Account a in accounts)
                {
                    if (String.Equals(a.description, old_desc))
                    {
                        a.change(newName, newUsername, newPassword, newURL);
                        accountDescriptions.Add(a.description);
                    }
                }

                reWrite();

                r.successful();
                return r;
            }

            catch (Exception e)
            {
                r.failure("An exception was encountered while attempting to remove the entry.", e);
                return r;
            }
        }

        //Reset Password (Key not available)
        public Result resetPassword(string old_key, string new_password)
        {
            Result r = new Result();
            try
            {
                //Read the existing database using the old password
                r = recoverEntries(old_key);
                if (!r.success())
                    return r;

                //delete the existing database file
                if (!stdlib.DeleteFile(file))
                {
                    r.failure("The existing database file could not be removed.");
                    return r;
                }

                //Create the new encryption handler
                passwordCh = new crypto(new_password, cryptoIterations);

                //Create a new encryption key
                string new_key = crypto.GeneratePassword(32, 32);
                passwordEncryptedKey = passwordCh.Encrypt(new_key);
                answersEncryptedKey = answersCh.Encrypt(new_key);
                crypto new_ch = new crypto(new_key, cryptoIterations);

                //Re-create the main database file
                TextWriter tw = new StreamWriter(file);

                //Write the watermark
                tw.WriteLine(@"5bd96c23e5830933b30475720781db2f");

                //Write the new password hash
                tw.WriteLine(hm.compute(new_password, true));

                //Write the key encrypted by the password
                tw.WriteLine(passwordEncryptedKey);

                //Write the answers hash
                answersHash = hm.compute(plaintextAnswers, true);
                tw.WriteLine(answersHash);

                //Write the answers encrypted by the password
                if (plaintextAnswers != null)
                {
                    encryptedAnswers = passwordCh.Encrypt(plaintextAnswers);
                    plaintextAnswers = null;
                }

                tw.WriteLine(encryptedAnswers);

                //Write the recovery question numbers
                tw.WriteLine(questions);

                //Write the recovery password
                tw.WriteLine(answersEncryptedKey);

                foreach (Account a in accounts)
                {
                    a.reEncrypt(new_ch);
                    tw.WriteLine(a.get_account());
                }

                //Close the StreamWriter
                tw.Close();

                /*re-create the recovery file
                r = createRecoveryFile(new_password, dataCh.Decrypt(recoveryPassword));
                if (!r.success()) return r; */

                //Swap out the cryptoHandler
                key = new_key;
                dataCh = new_ch;

                r.successful();
            }
            catch (Exception e)
            {
                r.failure("An exception was encountered while changing the password", e);
            }
            return r;
        }

        //Reset password (key is already in memory)
        public Result resetPassword(string new_password)
        {
            Result r = new Result();
            try
            {
                //Get the plaintext recovery answers
                string tmpAnswers = get_answers();

                //Generate a new encryption key
                string new_key = crypto.GeneratePassword(32, 32);

                //Calclulate the hash of the new password.
                passwordHash = hm.compute(new_password, true);

                //Re-initialize the password cryptohandler using the new password
                passwordCh = new crypto(new_password, cryptoIterations);

                //Re-encrypt the recovery answers using the new password
                encryptedAnswers = passwordCh.Encrypt(tmpAnswers);

                //Encrypt the new key using the new password
                passwordEncryptedKey = passwordCh.Encrypt(new_key);

                //Encrypt the new key using the recovery answers
                answersEncryptedKey = answersCh.Encrypt(new_key);

                //Re-encrypt all entries using the new key
                crypto new_data_ch = new crypto(new_key, cryptoIterations);
                foreach (Account account in accounts)
                    account.reEncrypt(new_data_ch);

                //Set the new key as the entry encrypter
                dataCh = new_data_ch;

                //Re-write the data file
                return reWrite();
            }
            catch (Exception e)
            {
                r.failure("An exception was encountered while changing the password", e);
            }
            return r;
        }

        private string get_answers()
        {
            string tmpEncryptedAnswers;
            //Obtain the recovery answers from the existing file
            TextReader tr = new StreamReader(file);

            //Skip the first 4 lines
            tr.ReadLine(); tr.ReadLine(); tr.ReadLine(); tr.ReadLine();

            //Get the encrypted answers
            tmpEncryptedAnswers = tr.ReadLine();
            tr.Close();

            //decrypt the encrypted answers and return
            return passwordCh.Decrypt(tmpEncryptedAnswers);
        }

        public Result read(string password)
        {
            string concatenatedAnswers;
            Result r = new Result();
            try
            {
                Account a;

                TextReader tr = new StreamReader(file);

                string currentLine;

                currentLine = tr.ReadLine();

                //Check for watermark to ensure that this is a valid Password database file.
                if (currentLine != @"5bd96c23e5830933b30475720781db2f")
                {
                    r.failure("The file " + file + " is not a valid Password Vault database.");
                    tr.Close();
                    return r;
                }

                //Get passwordHash
                currentLine = tr.ReadLine();

                //If the user is already authenticated
                if (!authenticated)
                {
                    if (!hm.verify(password, currentLine))
                    {
                        r.failure("The password is incorrect");
                        tr.Close();
                        return r;
                    }
                }
                authenticated = true;
                passwordHash = currentLine;

                //initialize the password encryption handler
                passwordCh = new crypto(password, cryptoIterations);

                //Get the key encrypted by the password
                passwordEncryptedKey = tr.ReadLine();

                //Initialize the encryption key
                key = passwordCh.Decrypt(passwordEncryptedKey);

                //Initialize the data encryption handler
                dataCh = new crypto(key, cryptoIterations);

                //Get the hash of the recovery answers
                answersHash = tr.ReadLine();

                //Get the answers encrypted by the key
                encryptedAnswers = tr.ReadLine();
                concatenatedAnswers = passwordCh.Decrypt(encryptedAnswers);

                //Initialize the answers encryption handler
                answersCh = new crypto(concatenatedAnswers, cryptoIterations);

                //get the question numbers
                questions = tr.ReadLine();

                //get the key encrypted by the recovery answers
                answersEncryptedKey = tr.ReadLine();

                //Read entries
                accounts = new List<Account>();
                accountDescriptions = new BindingList<string>();
                while (currentLine != null)
                {
                    currentLine = tr.ReadLine();
                    if (currentLine != null)
                    {
                        a = new Account();
                        a.init(currentLine, dataCh);
                        accounts.Add(a);
                        accountDescriptions.Add(a.description);
                    }
                }

                tr.Close();
                r.successful();
            }
            catch (Exception e)
            {
                r.failure("An error occurred while reading the database", e);
            }
            return r;
        }

        public Result recoverEntries(string key)
        {
            Result r = new Result();
            try
            {
                Account a;

                TextReader tr = new StreamReader(file);

                string currentLine;

                currentLine = tr.ReadLine();

                //Check for watermark to ensure that this is a valid Password database file.
                if (currentLine != @"5bd96c23e5830933b30475720781db2f")
                {
                    r.failure("The file " + file + " is not a valid Password Vault database.");
                    tr.Close();
                    return r;
                }

                //Skip the next 6 lines of the file
                for (int x = 0; x < 6; x++)
                    tr.ReadLine();

                //Initialize encryption object
                crypto tempCh = new crypto(key, cryptoIterations);

                //Read entries
                accounts = new List<Account>();
                accountDescriptions = new BindingList<string>();
                while (currentLine != null)
                {
                    currentLine = tr.ReadLine();
                    if (currentLine != null)
                    {
                        a = new Account();
                        a.init(currentLine, tempCh);
                        accounts.Add(a);
                        accountDescriptions.Add(a.description);
                    }
                }

                tr.Close();
                r.successful();
            }
            catch (Exception e)
            {
                r.failure("An error occurred while reading the database", e);
            }
            return r;
        }

        public string getAccountPassword(string desc)
        {
            foreach (Account a in accounts)
            {
                if (a.description == desc)
                    return a.get_password();
            }

            return null;
        }

        public string getURL(string desc)
        {
            string URL;

            foreach (Account a in accounts)
            {
                if (a.description == desc)
                {
                    URL = a.get_url().ToLower();
                    if ((URL.IndexOf("http://") == -1) & (URL.IndexOf("https://") == -1))
                        URL = "http://" + URL;
                    return URL;
                }
            }

            return null;
        }

        public Account get_account(string desc)
        {
            foreach (Account a in accounts)
            {
                if (String.Equals(a.description, desc))
                    return a;
            }

            return null;
        }

        public Result export(string filename)
        {
            try
            {
                TextWriter tw = new StreamWriter(filename);
                tw.WriteLine("Description,Username,Password,URL");
                foreach (Account a in accounts)
                    tw.WriteLine(a.getAccountForCSV());
                tw.Close();
                return new Result(true, "The export operation was successful.");
            }

            catch (Exception e)
            {
                return new Result(e);
            }
        }

        public Result import(string filename)
        {
            try
            {
                bool fullsuccess = true;
                string[] parts;
                Account a;
                TextReader tr = new StreamReader(filename);
                //skip header row
                tr.ReadLine();

                while (tr.Peek() != -1)
                {
                    parts = tr.ReadLine().Split(',');
                    if (parts.Length != 4)
                        fullsuccess = false;
                    else
                    {
                        a = new Account();
                        a.create(parts[0], parts[1], parts[2], parts[3], dataCh);
                        if (!writeEntry(a.get_account()).success())
                            fullsuccess = false;
                        else
                        {
                            accounts.Add(a);
                            accountDescriptions.Add(a.description);
                        }
                    }
                }

                return new Result(fullsuccess);
            }

            catch (Exception e)
            {
                return new Result(e);
            }
        }
    }

    public class Account
    {
        private crypto ch;
        public string description,
                      fileEntry,
                      name,
                      username,
                      password,
                      url;

        private void set_description()
        {
            description = decrypt(name) + "   (username:" + decrypt(username) + ")";
        }

        public string get_name()
        {
            return decrypt(name);
        }

        public string get_username()
        {
            return decrypt(username);
        }

        public string get_password()
        {
            return decrypt(password);
        }

        public string get_url()
        {
            return decrypt(url);
        }

        public string getAccountForCSV()
        {
            return get_name() + "," + get_username() + "," + get_password() + "," + get_url();
        }

        private string encrypt(string value)
        {
            return ch.Encrypt(value).Replace("|", "[BAR]");
        }

        private string reEncrypt(string value, crypto new_ch)
        {
            return new_ch.Encrypt(decrypt(value)).Replace("|", "[BAR]");
        }

        public void reEncrypt(crypto new_ch)
        {
            name = reEncrypt(name, new_ch);
            username = reEncrypt(username, new_ch);
            password = reEncrypt(password, new_ch);
            url = reEncrypt(url, new_ch);
            ch = new_ch;

            fileEntry = encrypt(name + '|' + username + '|' + password + '|' + url);
        }

        private string decrypt(string value)
        {
            return ch.Decrypt(value.Replace("[BAR]", "|"));
        }
        
        public void change(string newName, string newUsername, string newPassword, string newURL) { 
            name = encrypt(newName);
            username = encrypt(newUsername);
            password = encrypt(newPassword);
            url = encrypt(newURL);

            fileEntry = encrypt(name + '|' + username + '|' + password + '|' + url);
            set_description();
        }

        public void create(string nm, string uid, string pwd, string link, crypto init_ch)
        {
            ch = init_ch;
            name = encrypt(nm);
            username = encrypt(uid);
            url = encrypt(link);
            password = encrypt(pwd);

            fileEntry = encrypt(name + '|' + username + '|' + password + '|' + url);
            set_description();
        }

        public Result init(string entry, crypto init_ch)
        {
            Result r = new Result();
            try
            {
                ch = init_ch;
                string value = decrypt(entry);
                string[] parts = value.Split('|');
                if (parts.Length != 4)
                {
                    r.failure("An invalid entry was encountered when reading the database.");
                    return r;
                }
                name = parts[0];
                username = parts[1];
                password = parts[2];
                url = parts[3];

                fileEntry = entry;
                set_description();

                r.successful();
                return r;
            }
            catch (Exception e)
            {
                r.failure("An exception was encountered when loading an entry from the database:", e);
                return r;
            }

        }

        public string get_account()
        {
            return fileEntry;
        }
    }

    public class Result
    {
        bool result;
        string message;

        public Result() { }

        public Result(bool success)
        {
            result = success;
        }

        public Result(bool success, string messageToShow)
        {
            result = success;
            message = messageToShow;
        }

        public Result(Exception e)
        {
            result = false;
            message = "An Exception was encountered:" + Environment.NewLine + e.ToString();
        }

        public void successful()
        {
            result = true;
            message = "Successful";
        }

        public void successful(string m)
        {
            result = true;
            message = m;
        }

        public void failure(string m)
        {
            result = false;
            message = m;
        }

        public void failure(string m, Exception e)
        {
            result = false;
            if (m == null)
                message = "An error occurred:" + Environment.NewLine + e.ToString();
            else
                message = m + Environment.NewLine + e.ToString();
        }

        public void display()
        {
            MessageBox.Show(message,
                            "Password Vault",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error,
                            MessageBoxDefaultButton.Button1);
        }

        public bool success()
        {
            return result;
        }

        public string get_message()
        {
            return message;
        }
    }
}
