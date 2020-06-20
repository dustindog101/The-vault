using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace The_vault
{
    public static class Internals
    {

        private static string pepper= Properties.Settings.Default.Pepper;//the pepper i should change this every time but ehh
       public static string key = Properties.Settings.Default.Pepper;//KEY, change every update
       public static string iv = Properties.Settings.Default.Pepper;//THE IV
        public static string directory = AppDomain.CurrentDomain.BaseDirectory + @"Vault";//where data will be stored
        public static string file = AppDomain.CurrentDomain.BaseDirectory + @"Vault\login" + @"\logindata.data";//file locatuin
        public static bool start(string username, string password)
        { 
            var prop = Properties.Settings.Default;
            Random rnd = new Random();
            string s = generategoodrandom(rnd.Next(100));
            string u = username;//grab the username
            string p =hash(password, s); //grab the password
            prop.Reset();
            prop.Key = "";
            prop.InitializationVector = "";
            prop.Pepper = "";
            pepper = prop.Pepper;
            key = prop.Key;
            prop.Key = generategoodrandom(32);
            prop.InitializationVector = generategoodrandom(16);
            prop.Pepper = generategoodrandom(rnd.Next(10000));
            pepper = prop.Pepper;
            key = prop.Key;
            iv = prop.InitializationVector;
            prop.Save();
            if (File.Exists(file) == true)
            {
                return false;
            }
            else//if the file doesnt exist than created and everything
            {

                Directory.CreateDirectory(directory+@"\login");//create it

                try
                {
                    byte[] converted = Encoding.ASCII.GetBytes($"{u}:{p}:{s}");//convert the user/pwd(string) into bytes so that it can be encrypted
                    byte[] enc = encryptdata(converted, key, iv);
                    Savetofile(file, enc);//save the encrypted text to a file.
                }

                catch (Exception )
                {
                    return false;
                }
                return true;
            }
        }
        public static void initialize()
        {
            var abc = Properties.Settings.Default;

            pepper = abc.Pepper;
            key = abc.Key;
            iv = abc.InitializationVector;
            abc.Save();
        }
        public static string generategoodrandom(int length)
        {
            SHA512CryptoServiceProvider c = new SHA512CryptoServiceProvider();
            var rnd = new Random();


            string abcc = "";
            for (int i = 0; i < rnd.Next(80, 10999); i++)
            {
                byte[] cool = Encoding.ASCII.GetBytes(rnd.Next(0, int.MaxValue).ToString());
                System.Threading.Thread.Sleep(5);
                abcc += Convert.ToBase64String(c.ComputeHash(cool));
            }
            return abcc.Replace("=", "").Substring(0, length);

        }//im unsure why the program isnt starting
        public static string hash(string inp,string salt)
        {
            
            SHA512 s = SHA512.Create();//creatae new sha512
            byte[] hashit = Encoding.UTF8.GetBytes(inp + salt + pepper) ;//convert to bytes and add salt+pepper
            string hashed = null;
            for (int i = 0; i < 2; i++)
            {
                hashed += Convert.ToBase64String(s.ComputeHash(hashit));//HASHHHH
            }
            return hashed;
        }
        public static bool  validateuserandpass(string inp)
        {
            if (inp.Length >= 4)//make sure the input is greator than 4
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool validatewebsite(string inp)
        {
            if (inp.Length > 9)
            {


                if (inp.ToLower().Contains("http://") || inp.Contains("https://"))//make sure the site is http or https if not than its not even a site lol
                {
                    if (inp.Contains("."))//this is for domains for example (.)com or (.)tech see
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
        public static bool checklogin()
        {
            try
            {
                if(File.Exists(file) == true)//check if the file where the login exists
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ){
                return false;
            }
        }
        public static string grabusername()
        {
            // byte[] converted = Encoding.ASCII.GetBytes(inp);
            byte[] p = File.ReadAllBytes(Internals.file);

            
            
            string username = Encoding.ASCII.GetString(decryptdata(p,key,iv));//cibvert the byte to a string
            string[] user = username.Split(':');//split the decrypted string into two parts
            return user[0];
        }
        public static string grabpassword()
        {
            // byte[] converted = Encoding.ASCII.GetBytes(inp);
            byte[] p = File.ReadAllBytes(Internals.file);



            string username = Encoding.ASCII.GetString(decryptdata(p, key, iv));//cibvert the byte to a string
            string[] user = username.Split(':');//split the decrypted string into two parts
            return user[1];
        }
        public static string grabsalt()
        {
            // byte[] converted = Encoding.ASCII.GetBytes(inp);
            byte[] p = File.ReadAllBytes(Internals.file);



            string username = Encoding.ASCII.GetString(decryptdata(p, key, iv));//cibvert the byte to a string
            string[] user = username.Split(':');//split the decrypted string into two parts
            return user[2];
        }
        public static bool validate(string inp)//simple input validation just to make sure the user and or pass is sorta secure
        {

            if (inp !="")//check if box is equal to nothing
            {
                if (inp.Length >= 5)//make sure its greator tahn 5
                {
                    return true;//its good
                }
                else
                {
                    return false;//its bad
                }
                
            }
            else
            {
                return false;//its bad
            }

        }

        public static void writeerro(string input)
        {

            if (!Directory.Exists(directory + @"\errors"))
            {
                Directory.CreateDirectory(directory + @"\errors");

            }
            File.AppendAllText( directory+@"\errors\errors.data", $"{DateTime.Now.ToString("hh:mm:ssss MM/dd/yyyy")} |  {input}\n---------------\n");
        }
        private static void Savetofile(string location, byte[] input)
        {
            try
            {


                /*      using (var SW = new StreamWriter(location))
                      {
                          SW.WriteLine(input);
                          SW.Close();
                      }
                      */
                File.WriteAllBytes(location, input);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static byte[] encryptdata(byte[] bytearraytoencrypt, string key, string iv)//make it byte just in case we need to encrypt a file :shrug:
        {
            try
            {

                using (var dataencrypt = new AesCryptoServiceProvider())
                { //Block size : Gets or sets the block size, in bits, of the cryptographic operation.  
                    dataencrypt.BlockSize = 128;
                    //KeySize: Gets or sets the size, in bits, of the secret key  
                    dataencrypt.KeySize = 128;
                    //Key: Gets or sets the symmetric key that is used for encryption and decryption.  
                    dataencrypt.Key = System.Text.Encoding.UTF8.GetBytes(key);
                    //IV : Gets or sets the initialization vector (IV) for the symmetric algorithm  
                    dataencrypt.IV = System.Text.Encoding.UTF8.GetBytes(iv);
                    //Padding: Gets or sets the padding mode used in the symmetric algorithm  
                    dataencrypt.Padding = PaddingMode.PKCS7;
                    //Mode: Gets or sets the mode for operation of the symmetric algorithm  
                    dataencrypt.Mode = CipherMode.CBC;
                    //Creates a symmetric AES encryptor object using the current key and initialization vector (IV).  
                    ICryptoTransform crypto1 = dataencrypt.CreateEncryptor(dataencrypt.Key, dataencrypt.IV);
                    //TransformFinalBlock is a special function for transforming the last block or a partial block in the stream.   
                    //It returns a new array that contains the remaining transformed bytes. A new array is returned, because the amount of   
                    //information returned at the end might be larger than a single block when padding is added.  
                    byte[] encrypteddata = crypto1.TransformFinalBlock(bytearraytoencrypt, 0, bytearraytoencrypt.Length);
                    crypto1.Dispose();
                    //return the encrypted data  
                    return encrypteddata;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        public static byte[] decryptdata(byte[] bytearraytodecrypt, string key, string iv)
        {//do i even have to explain??

            using (var keydecrypt = new AesCryptoServiceProvider())
            {
                keydecrypt.BlockSize = 128;
                keydecrypt.KeySize = 128;
                keydecrypt.Key = System.Text.Encoding.UTF8.GetBytes(key);
                keydecrypt.IV = System.Text.Encoding.UTF8.GetBytes(iv);
                keydecrypt.Padding = PaddingMode.PKCS7;
                keydecrypt.Mode = CipherMode.CBC;
                ICryptoTransform crypto1 = keydecrypt.CreateDecryptor(keydecrypt.Key, keydecrypt.IV);

                byte[] returnbytearray = crypto1.TransformFinalBlock(bytearraytodecrypt, 0, bytearraytodecrypt.Length);
                crypto1.Dispose();
                return returnbytearray;
            }
        }
    }
}
