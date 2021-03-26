using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Pnoticias.BLL
{
    public class Criptografia
    {
        public string RetornaMD5(string texto)
        {
            UnicodeEncoding UE = new UnicodeEncoding();

            MD5 md5 = new MD5CryptoServiceProvider();
            //


            SHA1 sha1 = new SHA1CryptoServiceProvider();

            string textoCriptografado = "";

            byte[] HashValue, BytesTexto;

            BytesTexto = UE.GetBytes(texto);

            HashValue = md5.ComputeHash(BytesTexto);

            foreach (byte b in HashValue)
            {
                textoCriptografado += String.Format("{0:x2}", b);

            }

            return textoCriptografado;

        }
    }
}
