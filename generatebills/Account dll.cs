using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    public class Account
    {
        public static string username, password;
        public static string[,] accounts = new string[10, 2];
        public static int session = 0;
        public static void Store(string uname, string p)
        {
            accounts[session, 0] = uname;
            char[] parray = p.ToCharArray();
            int[] parray1 = new int[parray.Length];
            for (int i = 0; i < parray.Length; i++)
            {
                parray1[i] = parray[i];
            }
            string encryptedPassword = "";
            for (int j = 0; j < parray1.Length; j++)
            {
                encryptedPassword += parray1[j];
            }
            accounts[session, 1] = encryptedPassword;
            session++;
        }
    }
}
