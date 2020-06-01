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

        private static string pepper= @"eU2FsdGVkX19PJ6cotDepFOoE15qY0OBMPoCHTLMWPrl1UltITof1KlFFZ6G5d1mhcGBeAXtjU3N2XHFHKChWvaPVXnMPWvbRnDATqz0PbpkwslToBs5YE/WvzsUELCgX21d1678f69f3e3ebc5a7d9454aa57a82e9e7935f15ebff89b28b5f6e09bed07fa388d8e7ecf59c1c2bc92a2678ba16c
53889e7e22ae0cb6aaac469dfd5ff83f025d70fdf57bf980b12f8c509d5c076c3a0de4e9575a9971ccb26ea5ab4ed475
dd02e7e26f459f60ae8b12d5f578a521e9c4da5c644a861bed5fa574bb659ea6f4414c485CFD68C179380BF327B7DDDF28F4C273BEAD743E345B7B10F3E5A093F121A2CA62212C2E70F9E81389F32D5CB9274B
21DB870A4B3E3A743ACB9ABCA8EC9E5CB3270DDE3B9F6067FEC02A0EF7ED7DF11DE3D6748CACD17F570251DA4292B4D8
F18A4AAD6502800683A717248CB5BB38B1FEDC0EF9255BAE90471FC4C69D71B257359CBA22F594D8BDB50C7B15F58879
32454D1B8532638D83DA74A59B482268E0ED9FD0DAA472BA23D2699765D21DEFBAF7C5735D44DAD0A1E7E7F493F6B86A
A68E7AF82CA70CF78283761342ADCD5BF0039F010D7EB2699EDF472193C8DA779356E8F3424A31E180717C85E0EAFF1D
EBE474184BEDC1ABDD702EAB56D78491DBC15336D640A66F73F2BB5486452A049640CE6E5133DB0D92AE505C61A0EE73
E0B583881651AE6C2BBF5ADB3U2FsdGVkX1+ztMA4wP8368gbCSnyrfv7R4D5b3vzNAcoqUEsbhl4jc5M22REhu1X9G1PVn6WvcUdLnCmOW3zLqSgtyLPaZYO0rbrOr/p/d6dxdWbG0qp2WxTe8mM9ziMcmRCg84sUwcyePWEjrbkWenjL+ZkQ7XqKub7Rw2wcgfcysgzQ2JthqcfMvzpfPw6uH9iRh7cuBVAtv/XW+KTvUUSGxjwGf+VhWI2AfiDW2TzET7+MqRNL8WAmRXxc3GaMn92i6xJ3HpytA1s5Zd+jYVBbfqtExrE2Ek+FsN393COww2liJASWi8rnhbSLpsOqd8t3VJhZ5pIE6kggLdUvqwHBpSPLm8/E7uKA0IZzk1m141iRkn/3Vn82yW1rtSn/1r29LFdpLxTF7iCTcmbsBDCTkJq2Gnr+uddSuDBhS00kgmJ0a0Hq7P3akATVvYVZ9ftQett8n1GRQOmHmCmeMpcCKN3+nHNDv7FcRNtu8R9gVP9nPINbAmc1YNLNaYhl4k0X44NdrkgUCqdDEL3nwMsKwLaLXlwmfA+THMahTFzKlE1rkuXrJNd3VaLzhDxFJPMJ+SBgSkOEQwwb6UA0risAELNJ39lFImMjSQJI8+8WXwAY8x663T8oZghTkuL2CGLJCghuWcKhU/egxMH+6foXC+yWhxJsDuF7SjEP9CmLrR1TGErb+N84b/SMZ7q1P98nju+6iIWCRrXvY8vuLdY0/886RdUaypSE4+kzzP84+Em6dbRqcpj9bd6NBhaeeh0eW1xDilOwYHNMvo6zbqtRf7//jL6O+oIJHlaTv8kLGPNVClq5lkHV2VXljRdopxj7vey6/BLUDfmMcPwjUqOp59/yNMS5Rd2z5GTJeXLBxHlQFWBNAoasUX2QZywzdfujHJ7NpBwhPm8Cp1+6oujyUvNmshVFqxmLhFrvrkshyKGYDZ6G+U37rA81vhnaNE42RVWQ54la42CQA0fC0pxJRmwZ1FSA6yEpKzV8BidU6e9w0gIURMVlFIh8SJnfZ/Vz7lDkqOVeAphxp9pTIRl9nOseV9JGtTEGSlAXcT2kXIhbQFvQX/1ASoaEttxOtmRQekQI9bJS0VlfxoSHCx+N5xJAwogY42nkbcYCsizxf1/OEkuST9TkC7DWgmi4LFAXaahajwpL02fkXspFm0UVxIfN61Nusme4EvBDFoYZnsDiz4RovMkkXf0Z/ZOM2MOBIllgpLYGAKvAKvRHMdDYEkNRxRyPSxM5l2zo/rpPiLX2tIxuaXsrj+Lg5ihjPMlGehUbwopo247URUuPu6xEsb1Ka66KNq26XkhaWuj5ZnT7qfvcV+VUm2sg5N22R7yjknVjzlNzYKLkrVWwK3W5QSCXQQ8ZBaxLBlSYWRFasyuuGb1nsHkNWbZZxbQD/DK+9yeb9L0FChPbLvFnYlS7XwOy64HLQwNckbQ1u0hsq81LFGA/hXbjeerG+FVHWVqdMZTto4KUm6H2Hocz5skmsuTp0wrkJBcxTag/gvhuoQUwrKMAa+FVzBbCgY9E4JBY1zlhvOy3M93upaSNw==DBB580C8FBF2DCE7EF9831B13EB6E8AF1ABD9C4B8CF57D3D6A2A7A47817A3920E5B7DA3
B8E929C10EAC10FF202043C90B6CBE9F2F1B797E7C2F149F7772A05B17AF113C494102AA9AB8131F79E96EA430159CA3
1329FB8E2C7C57C17D745C3020A9FF2AB5CBAE8FC2B66DF235E944EB978ECF8F3C6EAAD13CA1B8F2FE1EBE6F0F107400
8756618C8C699481DB6DAF710B4FDE26F9C79E223A7C6C111F602D65584C5B2C5C3B566DCFFCD3F118D07214DBEA8D81d77e582a8e431db390072a74fa
cc77a6d89c01b5a7520a88e60fddab7f6d9463fa6d639f07eb9ae398dfb2331bc73f34c90cb382d6c096399e291c52db
0ccd6324e29cef8b876ddb86db24087840cd126f19d3a4ece86f6eedd853f12a00b1003ac12191f76ea8e2bf1e5d1df0
ca2db59049133095e71dcce29c1a592810f006a3f00210a32ffaec0f8961d4356d2355538a60d082a10efbf4d532ab1d
1d8ff55739371d9e209c56e7759cf8827c1476ab087b7933b9f8e6fcb050d3978e6cd1074772d049623ca99433f0d4b5
a9d7a623bd7c881cf28333f4d2fd9cc33eae23f88e883905d9fbeeb5f1bafcb253a561a3a265dec058e0177ba8bd9160
444c0727e8e4041700b0aba71c770d38faf6733bb67929df46b7ff6f0b88b76b31610b68175e89fad0b4b8f09ffa1299
b9b380c638aad1b85e01fdc95978d9145ce359f148015f2dd02aa49a64a7339960540d7dff206cd03f2c4074cae067b5eab979a9d29770bc58d15b3fb6343b84
a5080936af532819e29b63f092f4d9c3
78abccf2be35adaa277c194533c29641
263f228e129d71ca08e2bebf43b74d73
ccd1f839f297122665f83f532b50e789";//the pepper i should change this every time but ehh
       public static string key = "kYp3s6v9y$B&E)H@McQfTjWmZq4t7w!z";//KEY, change every update
       public static string iv = "s6v9y/B?E(H+MbQe";//THE IV
        public static string directory = AppDomain.CurrentDomain.BaseDirectory + @"Vault";//where data will be stored
        public static string file = AppDomain.CurrentDomain.BaseDirectory + @"Vault\login" + @"\logindata.data";//file locatuin
        public static bool start(string username, string password)
        {
            string u = username;//grab the username
            string p =hash(password, username); //grab the password
            if (File.Exists(file) == true)
            {
                return false;
            }
            else//if the file doesnt exist than created and everything
            {

                Directory.CreateDirectory(directory+@"\login");//create it

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
      
        public static string hash(string inp,string salt)
        {
            SHA256 s = SHA256.Create();//creatae new sha256
            byte[] hashit = Encoding.UTF8.GetBytes(inp + salt + pepper) ;//convert to bytes and add salt+pepper
            string hashed = Convert.ToBase64String(s.ComputeHash(hashit));//HASHHHH
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
