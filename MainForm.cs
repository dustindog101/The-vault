using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace The_vault
{
    public partial class MainForm : Form
    {


        public MainForm()//we completly finished login/encryption/decryption/validation/etc etc i forgot, before i work on the main stuff im going to see what features other password vaults have
        {
            InitializeComponent();
            lblusr.Text += Internals.grabusername();//
            
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          
        }
        private static string updateitems(ListView l)
        {
            return  $"Logins Saved: {l.Items.Count}";
        }
        private void GunaButton1_Click(object sender, EventArgs e)
        {
            
            bool valweb = Internals.validatewebsite(txtwebs.Text);
            bool vallgn = Internals.validateuserandpass(txtlgn.Text);
            bool valps = Internals.validateuserandpass(txtpassw.Text);
            if (  valweb ==true)
            {
                if (vallgn == true & valps == true)
                {



                    var items = new ListViewItem(txtwebs.Text);
                    items.SubItems.Add(txtlgn.Text);
                    items.SubItems.Add(txtpassw.Text);
                    items.SubItems.Add(DateTime.Now.ToString("hh:mm:ssss MM/dd/yyyy"));
                    listView1.Items.Add(items);
                }
                else
                {
                    MessageBox.Show("You must enter a valid login/password!");
                }
            }
            else
            {
                MessageBox.Show("You must enter a valid website!");
            }
           lbltitleitems.Text= updateitems(listView1);
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://cybershare.tech/");
        }
    }
}


