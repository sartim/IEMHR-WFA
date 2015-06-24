using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IEMHR_WFA.Forms.Account
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string dbCon = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:/Visual Studio Projects/IEMHR-WFA/IEMHR-WFA/App_Data/IEMHR_DB.mdf;Integrated Security=True";
                SqlConnection myCon = new SqlConnection(dbCon);
                SqlCommand cmd = new SqlCommand("SELECT * FROM IEMHR_DB.AspNetUsers WHERE UserName='" + this.txtUserName.Text + "' and PasswordHash='" + txtPassword.Text + "' ; ", myCon);

                SqlDataReader myReader;
                myCon.Open();
                myReader = cmd.ExecuteReader();

                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("User name and Password is correct ..Access Granted");
                    this.Hide();
                    MainFrm mainForm = new MainFrm();
                    mainForm.ShowDialog();
                }
                else if (count > 1)
                {
                    MessageBox.Show("Duplicate User Name and Password ...Access Denied");
                }
                else
                    MessageBox.Show("User Name and Password is Not Correct ..Please Try Again");
                myCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "The user name field is required");
            }
            if (!e.Cancel) { errorProvider1.SetError(txtUserName, ""); }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            e.Cancel = false;
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "The password field is required");
            }
            if (!e.Cancel) { errorProvider1.SetError(txtPassword, ""); }
        }
    }
}
