using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class PasswordQualityChecker
{
    const string upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    const string lower = "abcdefghijklmnopqrstuvwxyz";
    const string digits = "0123456789";
    const string special = "~!@#$%^&*()-=[]\\;',./`_+{}|:\"<>? ";

    public bool hasUpper;
    public bool hasLower;
    public bool hasDigit;
    public bool hasSpecial;
    public bool hasAtLeast8Chars;
    public bool isAcceptable;

    public PasswordQualityChecker()
    {
    }

    public void check(string password)
    {
        hasUpper = false;
        hasLower = false;
        hasDigit = false;
        hasSpecial = false;
        hasAtLeast8Chars = false;
        isAcceptable = false;

        if (password == "")
        {
            hasUpper = false;
            hasLower = false;
            hasDigit = false;
            hasSpecial = false;
            isAcceptable = false;
        }
        else
        {
            hasAtLeast8Chars = (password.Length >= 8);
            char[] elements = password.ToCharArray();

            foreach (char element in elements)
            {
                if (!hasUpper) hasUpper = upper.Contains(element);
                if (!hasLower) hasLower = lower.Contains(element);
                if (!hasDigit) hasDigit = digits.Contains(element);
                if (!hasSpecial) hasSpecial = special.Contains(element);
            }

            isAcceptable = hasAtLeast8Chars & hasUpper & hasLower & hasDigit & hasSpecial;
        }
    }
}
