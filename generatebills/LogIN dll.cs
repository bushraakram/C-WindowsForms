using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Account;


namespace LogIN
{
    public class Class1
    {
        public static bool Verification(string uname, string p)
        {
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
            int v = 0;
            for (int i = 0; i < 10; i++)
            {
                if ((Account.Account.accounts[i, 0] == uname) && (Account.Account.accounts[i, 1] == encryptedPassword))
                {
                    v = 1; break;
                }
                else
                {
                    v = 0;
                }
            }
            if (v == 0) { return false; }
            else
            {
                return true;
            }
        }
    }
}
