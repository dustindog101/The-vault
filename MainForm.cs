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
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using Microsoft.VisualBasic;

namespace The_vault
{
    public partial class MainForm : Form
    {
        private int id = 0;
        private string pas = "";
        public MainForm()//we completly finished login/encryption/decryption/validation/etc etc i forgot, before i work on the main stuff im going to see what features other password vaults have
        {
            InitializeComponent();
            
           
             MessageBox.Show($"Welcome back, {Internals.grabusername()}!");//display username
            if (File.Exists(@"Vault\accounts\accounts.csv"))
            {
                readcsv();
                id = listView1.Items.Count;
            }
            else
            {
                Directory.CreateDirectory(@"Vault\accounts");;
            }
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

                    //  string json = serialize.serilizeitems(id, txtwebs.Text, txtlgn.Text, txtpassw.Text, DateTime.Now.ToString("hh:mm:ssss MM/dd/yyyy"));

                    writecsv();//
                    try
                    {

                        var items = new ListViewItem(id.ToString());//create a list of items to add essentally
                        items.SubItems.Add(txtwebs.Text);//add wevsute to listbox
                        items.SubItems.Add(txtlgn.Text);//add login to listvbox
                        items.SubItems.Add(txtpassw.Text);//add pass
                        items.SubItems.Add(DateTime.Now.ToString("hh:mm:ssss MM/dd/yyyy"));//grab the date and time and add it
                        listView1.Items.Add(items);//add all of the items we created
                        
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                        Internals.writeerro(ex.Message);

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
                    if (MessageBox.Show("Would you like to delte this value?","",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        listView1.SelectedItems[0].Remove();
                    }
                    else
                    {
                        MessageBox.Show("Okay!");
                    }
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
            Application.Exit();
            Environment.Exit(0);
        }
        public  void readcsv()
        {

            using (var reader = new StreamReader(@"Vault\accounts\accounts.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Items>().ToList();
                foreach (var person in records)
                {
                    var items = new ListViewItem(person.ID.ToString());//create a list of items to add essentally
                    items.SubItems.Add(Encoding.ASCII.GetString(Internals.decryptdata(Convert.FromBase64String(person.website), Internals.key, Internals.iv)));
                    items.SubItems.Add(Encoding.ASCII.GetString(Internals.decryptdata(Convert.FromBase64String(person.username), Internals.key, Internals.iv)));
                    items.SubItems.Add(Encoding.ASCII.GetString(Internals.decryptdata(Convert.FromBase64String(person.password),Internals.key,Internals.iv)));
                    items.SubItems.Add(Encoding.ASCII.GetString(Internals.decryptdata(Convert.FromBase64String(person.date), Internals.key, Internals.iv)));//grab the date and time and add it
                    listView1.Items.Add(items);//add all of the items we created
                }
            }

        }
        public void SaveCSV()
        {
            CsvConfiguration csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                HasHeaderRecord = !File.Exists(@"Vault\accounts\accounts.csv")
            };

            var records = new List<Items> { };
        /*   foreach  (ListViewItem listViewItem in listView1.Items)
            {
                records.Add(new Items { ID = id, website = _Web, username = _Usr, password = _Pass, date = _Date });//im lazy ill finsih later
            }
          */ 
            using (FileStream fileStream = new FileStream(@"Vault\accounts\accounts.csv", FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
            {
                using (var writer = new StreamWriter(fileStream))
                using (var csv = new CsvWriter(writer, csvConfig))
                {
                    csv.WriteRecords(records);
                }
            }
        }
        public void writecsv()
        {
            try
            {
                //convert all these values to bytes so that i can encrypt it later
                byte[] _web = Encoding.ASCII.GetBytes(txtwebs.Text);
                byte[] _usr = Encoding.ASCII.GetBytes(txtlgn.Text);
                byte[] _lgn = Encoding.ASCII.GetBytes(txtpassw.Text);
                byte[] _date = Encoding.ASCII.GetBytes(DateTime.Now.ToString("hh:mm:ssss MM/dd/yyyy"));

                //encyrpt the bytes

                String _Web = Convert.ToBase64String(Internals.encryptdata(_web, Internals.key, Internals.iv));
                String _Usr = Convert.ToBase64String(Internals.encryptdata(_usr, Internals.key, Internals.iv));
                String _Pass = Convert.ToBase64String(Internals.encryptdata(_lgn, Internals.key, Internals.iv));
                String _Date = Convert.ToBase64String(Internals.encryptdata(_date, Internals.key, Internals.iv));
                
                CsvConfiguration csvConfig = new CsvConfiguration(CultureInfo.CurrentCulture)
                {
                    HasHeaderRecord = !File.Exists(@"Vault\accounts\accounts.csv")
                };

                var records = new List<Items> { };
                records.Add(new Items { ID = id, website = _Web, username = _Usr, password = _Pass, date = _Date });
                using (FileStream fileStream = new FileStream(@"Vault\accounts\accounts.csv", FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                {
                    using (var writer = new StreamWriter(fileStream))
                    using (var csv = new CsvWriter(writer, csvConfig))
                    {
                        csv.WriteRecords(records);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error! Please check error lo!");
                Internals.writeerro(ex.Message);
            }
        }
        private void Txtpassw_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sur you want to nuke the applacation?\n This will delete all traces of your logins and login data!","",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                File.Delete(@"Vault\accounts\accounts.csv");
                Directory.Delete(@"Vault");
                MessageBox.Show("Done... restarting applacation");
                //im going to workout
                Application.ExitThread();
                Environment.Exit(0);
            }
        }
    }
}


