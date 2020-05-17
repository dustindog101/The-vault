using System;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace The_vault
{
   public class serilize
    {
        public static string serilizeitems(int id,string web, string user, string pwd, string date)
        {
            try
            {//i copied the code from internals and edited so i dont have tim eto remove the comments and recomment
                byte[] converted1 = Encoding.ASCII.GetBytes(web);//convert the user/pwd(string) into bytes so that it can be encrypted
                string web1 = Internals.encryptdata(converted1, Internals.key, Internals.iv);

                byte[] converted2 = Encoding.ASCII.GetBytes(user);//convert the user/pwd(string) into bytes so that it can be encrypted
                string user1 = Internals.encryptdata(converted2, Internals.key, Internals.iv);
                byte[] converted3 = Encoding.ASCII.GetBytes(pwd);//convert the user/pwd(string) into bytes so that it can be encrypted
                string pwd1 = Internals.encryptdata(converted3, Internals.key, Internals.iv);
                byte[] converted4 = Encoding.ASCII.GetBytes(date);//convert the user/pwd(string) into bytes so that it can be encrypted
                string date1 = Internals.encryptdata(converted4, Internals.key, Internals.iv);
                
                Items newitem = new Items//new item item
            {
                ID=id,website = web1, username = user1, password = pwd1, date = date1

        };
            var items = JsonConvert.SerializeObject(newitem, Formatting.Indented);//serilize
                return items;
            }
            catch (Exception ex)
            {
                return "Error: "+ex.Message;
                
            }
            
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
}
