using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FAQU
{
    public partial class Auth : Form
    {
        DataBase data = new DataBase();
        public Auth()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable data = new DataTable();

            string userLogin = loginField.Text;
            string userPass = passField.Text;

            string querystring = $"select ...";
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            passField.PasswordChar = '*';
            passField.MaxLength = 50;
            loginField.MaxLength = 50;
        }
    }
}
