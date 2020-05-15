using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace The_vault
{
    public partial class Login : Form
    {
        public static bool log = false;/// <summary>
        /// this will be true if the user is logged in
        /// </summary>
        public Login()
        {
            InitializeComponent();
            
        }
        private void GunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();//exit when exit button is clicked
        }
        private void GunaButton1_Click(object sender, EventArgs e)
        {



            if (Internals.validate(txtuser.Text) && Internals.validate(txtpass.Text))//make sure usertext and passtext is valid // i shouldve validated in internals but its too late now
            {

                if (Internals.start(txtuser.Text, txtpass.Text) == true)//register user/pass
                {
                    MessageBox.Show("Registered!");
                    this.Hide();//hide form
                    MainForm frm = new MainForm();//create new form main
                    frm.Show();//show it

                }
                else
                {
                    MessageBox.Show($"Welcome back, {Internals.grabusername()}!", "Welcome!");
                    this.Hide();
                    MainForm frm = new MainForm();//just in case if there is an erro
                    frm.Show();
                }
            }
            else
            {
                MessageBox.Show("Username & password must be at least 5 charcters");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
           

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
           
        }
    }

    
}

