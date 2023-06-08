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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    { 
        dbConnection DataBase = new dbConnection();
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pass_textBox.UseSystemPasswordChar = true;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            var login = login_textBox.Text;
            var password = pass_textBox.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
        }

        private void show_pass_Click(object sender, EventArgs e)
        {
            if (pass_textBox.UseSystemPasswordChar == true)
            {
                pass_textBox.UseSystemPasswordChar = false;
                show_pass.Text = "Скрыть пароль";
            }
            else if (pass_textBox.UseSystemPasswordChar == false)
            {
                pass_textBox.UseSystemPasswordChar = true;
                show_pass.Text = "Показать пароль";
            }
        }
    }
}
