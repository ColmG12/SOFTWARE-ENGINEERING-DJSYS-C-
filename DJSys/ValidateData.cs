using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DJSys
{
    class ValidateData
    {
        //sep validation
        public static bool isBlank(String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return false;
            }

            return true;
        }

        //Reference - fellow student Ian O'Regan helped me with apostrophe problem in names
        public static string apostChecker(string text)
        {
            string newText = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '\'')
                {
                    newText += text[i] + "\'";
                }
                else
                    newText += text[i];
            }
            return newText;
        }

        public static bool containsNumbers(String str)
        {
            if (str.Any(c => Char.IsNumber(c)))
            {
                return false;
            }

            return true;
        }

        public static bool containsSpaces(String str)
        {
            if (str.Contains(" "))
            {
                return false;
            }

            return true;
        }

        public static bool isValidDate(DateTime dob)
        {
            if (dob > DateTime.Now.AddYears(-18))
            {
                
                return false;
            }

            return true;
        }

        public static bool isValidDate2(DateTime dob)
        {
            if (dob > DateTime.Now)
            {
               
                return false;
            }

            return true;
        }

        public static bool isValidDate3(DateTime dob)
        {
            if (dob < DateTime.Now)
            {

                return false;
            }

            return true;
        }

        public static bool isNoticeDate(DateTime eventDate)
        {
            if (eventDate > DateTime.Now.AddDays(+28))
            {

                return false;
            }

            return true;
        }

        public static bool isValidDate28(DateTime eventDate)
        {
            if (eventDate > DateTime.Now.AddDays(+14) && eventDate < DateTime.Now.AddDays(+28))
            {

                return false;
            }

            return true;
        }

        public static bool isValidDate14(DateTime eventDate)
        {
            if (eventDate > DateTime.Now.AddDays(+7) && eventDate < DateTime.Now.AddDays(+14))
            {

                return false;
            }

            return true;
        }

        public static bool isValidDate7(DateTime eventDate)
        {
            if (eventDate < DateTime.Now.AddDays(+7))
            {

                return false;
            }

            return true;
        }

        public static bool isValidEmail(String mail)
        {
            if (!Regex.IsMatch(mail, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase))
            {
                //MessageBox.Show("Email must be valid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        //References for eircode regex https://regex101.com/r/bA5qN8/1 and https://stackoverflow.com/questions/33391412/validation-for-irish-eircode

        public static bool isValidEircode(String eircode)
        {
            if (!Regex.IsMatch(eircode, @"\A(?:([AC-FHKNPRTV-Y]\d{2}|D6W)[0-9AC-FHKNPRTV-Y]{4})\Z", RegexOptions.IgnoreCase))
            {
                //MessageBox.Show("Eircode must be valid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

     }
}


