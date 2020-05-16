using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace The_vault
{
    public static class Internals
    {
       public static string key = "kYp3s6v9y$B&E)H@McQfTjWmZq4t7w!z";//KEY, change every update
       public static string iv = "s6v9y/B?E(H+MbQe";//THE IV
        public static string directory = AppDomain.CurrentDomain.BaseDirectory + @"Vault\login";//where data will be stored
        public static string file = AppDomain.CurrentDomain.BaseDirectory + @"Vault\login" + @"\data.txt";//file locatuin
        public static bool start(string username, string password)
        {
            string u = username;//grab the username
            string p = password;//grab the password
            if (File.Exists(file) == true)
            {
                
                return false;
            }
            else//if the file doesnt exist than created and everything
            {

                Directory.CreateDirectory(directory);//create it

                try
                {


                    byte[] converted = Encoding.ASCII.GetBytes($"{u}:{p}");//convert the user/pwd(string) into bytes so that it can be encrypted
                    byte[]enc = encryptdata(converted, key, iv);
                    Savetofile(file, enc);//save the encrypted text to a file.
                }

                catch (Exception )
                {
                    return false;
                }
                return true;
            }
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
