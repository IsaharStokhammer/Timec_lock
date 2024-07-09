using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timec_lock.DAL;

namespace Timec_lock
{
    public partial class LoginForm : Form
    {
        private DBContext _dbContext;
        public LoginForm(DBContext dBContext)
        {
            InitializeComponent();
            _dbContext = dBContext;
            //Demo();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Demo() {
            DataTable dt = _dbContext.MakeQewry("select 1+1 as pini");
            string dtstr = dt.Rows[0]["pini"].ToString();
            MessageBox.Show(dtstr);
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            string username = textBox_Tz.Text;
            string password = textBox_Password.Text;


            this.Close();
            ClockForm C = new ClockForm();
            C.Show();

        }
    }
}
