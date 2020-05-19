using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace The_vault
{
    public class getitems
    {
    }
   public class serialize
    {
        
        public static string serilizeitems(int id,string web, string user, string pwd, string date)
        {
            try
            {//i copied the code from internals and edited so i dont have tim eto remove the comments and recomment
                byte[] converted1 = Encoding.ASCII.GetBytes(web);//convert the user/pwd(string) into bytes so that it can be encrypted
                byte[] web1 = Internals.encryptdata(converted1, Internals.key, Internals.iv);
                string web1str = Encoding.ASCII.GetString(web1);//convert the byte array back to string so that i can serilizw

                byte[] converted2 = Encoding.ASCII.GetBytes(user);//convert the user/pwd(string) into bytes so that it can be encrypted
                byte[] user1 = Internals.encryptdata(converted2, Internals.key, Internals.iv);
                string user1str = Encoding.ASCII.GetString(user1);//convert the byte array back to string so that i can serilizw
                byte[] converted3 = Encoding.ASCII.GetBytes(pwd);//convert the user/pwd(string) into bytes so that it can be encrypted
                byte[] pwd1 = Internals.encryptdata(converted3, Internals.key, Internals.iv);
                string pwd1str = Encoding.ASCII.GetString(pwd1);//convert the byte array back to string so that i can serilizw
                byte[] converted4 = Encoding.ASCII.GetBytes(date);//convert the user/pwd(string) into bytes so that it can be encrypted
                byte[] date1 = Internals.encryptdata(converted4, Internals.key, Internals.iv);
                string date1str = Encoding.ASCII.GetString(date1);//convert the byte array back to string so that i can serilizw
                // poopie
                Items items = new Items//new item item
            {
               ID=id, website = web1str, username = user1str, password = pwd1str, date = date1str

        };
            return JsonConvert.SerializeObject(new[]{ items},Formatting.Indented);
            }
            catch (Exception ex)
            {
                return "Error: "+ex.Message;
                //poop
            }
            
        }
        public static string deserialize(string JSON)
        {
            List<Items> poop = JsonConvert.DeserializeObject<List<Items>>(JSON);
            Items items = poop[0];
            string i = items.ID.ToString();
            string w = items.website;
            string u = items.username;
            string p = items.password;
            return $"{poop}";
        }
        public static void saveitems(string json)
        {
            try
            {



                File.AppendAllText(Internals.directory + @"\accounts" + Environment.UserName + ".data",$"{json}{Environment.NewLine}");

                
            }
            catch (Exception)
            {
                
               throw;
            }
        }
    }
    public class deserialize
    {
        public static string  poopie(string input)
        {

            var serializer = new JsonSerializer();

            using (var sw = new StreamReader(input))
            using (var reader = new JsonTextReader(sw))
            {
                return serializer.Deserialize(reader).ToString();
            }
        }

    }
}
