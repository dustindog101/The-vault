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
using System.Diagnostics;

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
          
            Debug.WriteLine("login started");
            if (Internals.checklogin() ==false)
            {
                Properties.Settings.Default.Reset();
                gunaLabel3.Text = "Register";
            }
            else
            {
                Internals.initialize();
            }

        }
        private void GunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();

            Environment.Exit(0);
        }
        private void GunaButton1_Click(object sender, EventArgs e)
        {
            if (Internals.checklogin() == true)
            {
                login();


            }
            else
            {
                register();
            }

          
        }

        private void login()
        {

            if (Internals.validate(txtuser.Text) && Internals.validate(txtpass.Text))//make sure usertext and passtext is valid // i shouldve validated in internals but its too late now
            {
                if (txtuser.Text == Internals.grabusername()&& Internals.hash(txtpass.Text,Internals.grabsalt()) == Internals.grabpassword())
                {
                    MessageBox.Show("Logged in!");
                    this.Hide();//hide form
                    MainForm frm = new MainForm();//create new form main
                    frm.Show();//show it
                }
                else
                {
                    MessageBox.Show("Please check your username/password!", "Invalid login credentials");
                }
            }
            else
            {
                MessageBox.Show("Please check your username/password!", "Invalid login credentials");
            }
        }

      private void register()
        {

            if (Internals.validate(txtuser.Text) && Internals.validate(txtpass.Text))//make sure usertext and passtext is valid // i shouldve validated in internals but its too late now
            {
                gunaLabel4.Text = "Registering... This may take a while";
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

       

    }

    
}

