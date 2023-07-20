using System;
using DataAccessLayerSignUp.Entities;
using DataAccessLayerSignUp.Operation;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtFirstN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstN_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtFirstN.Text == "enter your first name")
            {
                txtFirstN.Clear();
            }
        }

        private void txtLastN_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtLastN.Text == "enter your last name")
            {
                txtLastN.Clear();
            }
        }

        private void txtUsernam_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtUsernam.Text == "enter your username")
            {
                txtUsernam.Clear();
            }
        }

        private void txtPasswor_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPasswor.Text == "enter your password")
            {
                txtPasswor.Clear();
                txtPasswor.PasswordChar = '*';
            }
        }

        private void txtConfirmPasswor_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtConfirmPasswor.Text == "confirm your password")
            {
                txtConfirmPasswor.Clear();
                txtConfirmPasswor.PasswordChar = '*';
            }
        }

        private void txtEmailAddress_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEmailAddress.Text == "enter email address")
            {
                txtEmailAddress.Clear();
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            EntitiesSignUp entities = new EntitiesSignUp();
            OperationSignUp operation = new OperationSignUp();

            entities.FirstName = txtFirstN.Text;
            entities.LastName = txtLastN.Text;
            entities.Username = txtUsernam.Text;
            entities.Password = txtPasswor.Text;
            entities.ConfirmPassword = txtConfirmPasswor.Text;
            entities.Email = txtEmailAddress.Text;
            entities.Gender = lblGender.Text;

            if (maleRadioButton.Checked)
            {
                entities.Gender = "Male";
            }
            else
                entities.Gender = "Female";

            int flag = operation.SignUp(entities);
            if (flag > 0)
            {
                MessageBox.Show("Iserted Success!");
            }
            else
            {
                MessageBox.Show("not inserted");
            }
        }
    }
}
