using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timec_lock;
using Timec_lock.DAL;

namespace FormNavPoc.Services
{
    internal static class NavigationService
    {
        static private string connStr = "Data Source=DESKTOP-F6TEN9G;User ID=sa;Password=1234;Connect Timeout=30;Encrypt=False;";
        static private DBContext dBContext = new DBContext(connStr);
        public static void CloseAllForms()
        {
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            foreach (Form item in openForms)
                item.Close();

            //foreach (Form item in Application.OpenForms)
            //    item.Close();
        }
        public static void ShowForm(string formName)
        {
            CloseAllForms();
            Form form = formName switch
            {
                "ClockForm" => new ClockForm(),
                "LoginForm" => new LoginForm(dBContext),
                "PasswordChangeForm" => new PasswordChangeForm(),
                _ => throw new ArgumentException("invalid form name.", nameof(formName))
            };
            form.Show();
        }
    }
}
