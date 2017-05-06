using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class Log
 {
     const int DEBUG = 4;
     const int INFO = 3;
     const int WARNING = 2;
     const int ERROR = 1;
     const int CRITICAL = 0;

     private string file;
     private int logLevel;

    //Constructor
    public Log(string path, int level)
    {
        file = path;
        logLevel = level;
    }

    public Log(string path, string level)
    {
        file = path;
        set_level(level);
    }

     public string getPath()
     {
         return file;
     }

     public void set_level(int level)
     {
         logLevel = level;
     }

     public void set_level(string lvl)
     {
         switch (lvl.ToUpper().Trim())
         {
             case "CRITICAL":
                 logLevel = CRITICAL;
                 break;
             case "ERROR":
                 logLevel = ERROR;
                 break;
             case "WARNING":
                 logLevel = WARNING;
                 break;
             case "INFO":
                 logLevel = INFO;
                 break;
             case "DEBUG":
                 logLevel = DEBUG;
                 break;
             default:
                 logLevel = ERROR;
                 break;
         }
     }

     public int get_level()
     {
         return logLevel;
     }

     private int get_level(string level)
     {
         switch (level.ToUpper().Trim())
         {
             case "CRITICAL":
                 return CRITICAL;
             case "ERROR":
                 return ERROR;
             case "WARNING":
                 return WARNING;
             case "INFO":
                 return INFO;
             case "DEBUG":
                 return DEBUG;
             default:
                 return ERROR;
         }
     }

     public void WriteSeparator(string message)
     {
         if (File.Exists(file))
         {
             StreamWriter sw = File.AppendText(file);
             WriteSeparator(message, sw);
             sw.Close();
         }
         else
         {
             StreamWriter sw = File.CreateText(file);
             WriteSeparator(message, sw);
             sw.Close();
         }
     }

     private void WriteSeparator(string message, StreamWriter sw)
     {
         DateTime CurrTime = DateTime.Now;
         string time = CurrTime.ToString();
         string bumper = "*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~";
         sw.Write(sw.NewLine);
         sw.WriteLine(bumper);
         sw.WriteLine(message.Replace("[DATE]", time));
         sw.Write(sw.NewLine);
         sw.WriteLine(bumper);
         sw.Write(sw.NewLine);
     }

     public void writeException(string level, Exception e, bool ignoreLogLevel)
     {
         if ((!ignoreLogLevel) || (get_level(level) >= logLevel))
         {
             write(level, "An exception occurred:", ignoreLogLevel);
             string[] lines = Regex.Split(e.ToString(), "\r\n");
             foreach (string line in lines)
                 write("     " + line);
         }
     }

     public void write(string messageType, string message, bool ignoreLogLevel)
     {
         write(get_level(messageType), message, ignoreLogLevel);
     }

     public void write(int messageType, string message, bool ignoreLogLevel)
     {
         if ((logLevel >= messageType) || (ignoreLogLevel))
             Write(messageType, message);
     }

     public void Write(int messageType, string message)
     {
         string messageTypeDefinition;

         switch (messageType)
         {
             case DEBUG:
                 messageTypeDefinition = "<Debug>   ";
                 break;
             case INFO:
                 messageTypeDefinition = "<Info>    ";
                 break;
             case WARNING:
                 messageTypeDefinition = "<Warning> ";
                 break;
             case ERROR:
                 messageTypeDefinition = "<Error>   ";
                 break;
             case CRITICAL:
                 messageTypeDefinition = "<Critical>";
                 break;
             default:
                 messageTypeDefinition = "<Unknown> ";
                 break;
         }

         if (File.Exists(file))
             AppendLog(messageTypeDefinition, message);

         else
             InitializeLog(messageTypeDefinition, message);
     }

     public void write(string message)
     {
         if (File.Exists(file))
             AppendLog("", message);
         else
             InitializeLog("", message);
     }

     public void write(string message, int level)
     {
         if (level >= DEBUG)
         {
             if (File.Exists(file))
                 AppendLogWithoutDate("          ", message);
             else
                 InitializeLogWithoutDate("          ", message);
         }
     }

     private void InitializeLog(string type, string message)
     {
         DateTime CurrTime = DateTime.Now;
         StreamWriter sw = File.CreateText(file);
         sw.WriteLine("{0:R}", CurrTime + " " + type + " - " + message);
         sw.Close();
     }

     private void InitializeLogWithoutDate(string indent, string message)
     {
         StreamWriter sw = File.CreateText(file);
         sw.WriteLine(indent + message);
         sw.Close();
     }

     private void AppendLog(string type, string message)
     {
         DateTime CurrTime = DateTime.Now;
         StreamWriter sw = File.AppendText(file);
         sw.WriteLine("{0:R}", CurrTime + " " + type + " - " + message);
         sw.Close();
     }

     private void AppendLogWithoutDate(string indent, string message)
     {
         StreamWriter sw = File.AppendText(file);
         sw.WriteLine(indent + message);
         sw.Close();
     }
 }
