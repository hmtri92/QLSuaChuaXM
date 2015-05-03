using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DeTai
{
    class EncriptMD5
    {
        public String encript(String value)
        {
            MD5CryptoServiceProvider md5Hash = new MD5CryptoServiceProvider();
            byte[] hashbyte;
            UTF8Encoding encoder = new UTF8Encoding();
            hashbyte = md5Hash.ComputeHash(encoder.GetBytes(value));
            return BitConverter.ToString(hashbyte).Replace("-", "").ToLower();
        }
    }
}
