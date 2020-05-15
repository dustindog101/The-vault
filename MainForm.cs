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
            lblusr.Text += Internals.grabusername();//label is equal to welcome, so its going to be welcome, +username
            
            
        }
        private static string updateitems(ListView l)
        {
            return  $"Logins Saved: {l.Items.Count}";
        }
        private void GunaButton1_Click(object sender, EventArgs e)
        {
            string pwd = "Click to reveal.";//dont store unencrypted password
            bool valweb = Internals.validatewebsite(txtwebs.Text);//they are both booleans so i could remove these to lower time and increase speed
            bool vallgn = Internals.validateuserandpass(txtlgn.Text);//^
            bool valps = Internals.validateuserandpass(txtpassw.Text);//^^
            if (  valweb ==true)
            {
                if (vallgn == true & valps == true)
                {



                    var items = new ListViewItem(txtwebs.Text);//create a list of items to add essentally
                    items.SubItems.Add(txtlgn.Text);
                    items.SubItems.Add(pwd);
                    items.SubItems.Add(DateTime.Now.ToString("hh:mm:ssss MM/dd/yyyy"));//grab the date and time and add it
                    listView1.Items.Add(items);//add all of the items we created
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
           lbltitleitems.Text= updateitems(listView1);//update every time they click da button
        }
    }
}


