using System;
using Newtonsoft.Json;
using System.IO;
namespace The_vault
{
   public class serilize
    {
        public static string serilizeitems(string web, string user, string pwd, string date)
        {
            try
            {

            
            Items newitem = new Items
            {
                website = web, username = user, password = pwd, date = date

        };
            var items = JsonConvert.SerializeObject(newitem, Formatting.Indented);
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



                File.AppendAllText(Internals.directory + @"\accounts" + Environment.UserName + ".data",json);

                
            }
            catch (Exception)
            {
                
               throw;
            }
        }
    }
}
