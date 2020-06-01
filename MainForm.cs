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
        private int id = 0;
        public MainForm()//we completly finished login/encryption/decryption/validation/etc etc i forgot, before i work on the main stuff im going to see what features other password vaults have
        {
            InitializeComponent();
            
           
             MessageBox.Show($"Welcome back, {Internals.grabusername()}!");//display username
            
        }
        private static string updateitems(ListView l)
        {
            return  $"Logins Saved: {l.Items.Count}";
        }
        private void GunaButton1_Click(object sender, EventArgs e)
        {
         //   string pwd = "Click to reveal.";//dont store unencrypted password this is 
            bool valweb = Internals.validatewebsite(txtwebs.Text.ToLower());//they are both booleans so i could remove these to lower time and increase speed
            bool vallgn = Internals.validateuserandpass(txtlgn.Text);//^
            bool valps = Internals.validateuserandpass(txtpassw.Text);//^^
            if (  valweb ==true)
            {
                if (vallgn == true & valps == true)
                {

                    string json = serialize.serilizeitems(id, txtwebs.Text, txtlgn.Text, txtpassw.Text, DateTime.Now.ToString("hh:mm:ssss MM/dd/yyyy"));
                    if (!json.Contains("Error"))
                    {
                        serialize.saveitems(json);
                    }
                    else
                    {
                        MessageBox.Show($"Error uploading credentials to server...please try again...  {json}");
                        Internals.writeerro(json);

                    }

                    try
                    {

                        var items = new ListViewItem(id.ToString());//create a list of items to add essentally
                        items.SubItems.Add(txtwebs.Text);
                        items.SubItems.Add(txtlgn.Text);
                        items.SubItems.Add(txtpassw.Text);
                        items.SubItems.Add(DateTime.Now.ToString("hh:mm:ssss MM/dd/yyyy"));//grab the date and time and add it
                        listView1.Items.Add(items);//add all of the items we created
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");

                    }
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
            id++;
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {

            
            if (listView1.SelectedItems.Count > 0)// some validation
            {
                MessageBox.Show($"The password for {listView1.SelectedItems[0].Text} is {listView1.SelectedItems[0].SubItems[2].Text}");
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"A error appeared:{ex.Message}");
            }
        }

        private void GunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();

            Environment.Exit(0);
        }

        private void Txtpassw_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


