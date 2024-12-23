using System;
using System.Windows.Forms;

namespace TalabatServices
{
    internal static class FormStateMgr
    {
        private static string currentFormName; // Store the name of the current form

        public static void SaveCurrentForm(string formName, string userId, bool isWorker)
        {
            currentFormName = formName;

            // Save to the database
            DBHelper.SaveFormState(userId, isWorker, formName);
        }

        public static string LoadLastForm(string userId, bool isWorker)
        {
            // Retrieve the last form name from the database
            return DBHelper.GetLastFormState(userId, isWorker);
        }

        public static void SwitchToForm(Form currentForm, Form newForm, string userId, bool isWorker)
        {
            SaveCurrentForm(newForm.Name, userId, isWorker);

            // Close the current form and show the new form
            currentForm.Hide();
            newForm.Show();
        }
    }
}

