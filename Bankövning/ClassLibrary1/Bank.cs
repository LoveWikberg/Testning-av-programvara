using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Bank
    {


        public double Debit(double input, double account)
        {
            account -= input;
            if (account < 0)
            {
                account += input;
            }

            #region stuff
            //if (account < 0)
            //    throw new Exception("No Balance");
            //else
            //{
            //    account -= input;
            //    if (account < 0)
            //    {
            //        account += input;
            //        throw new Exception("You only have " + account + " SEK on your account");
            //    }
            //}
            #endregion

            return account;
        }

        public double Credit(double input, double account)
        {
            if (input < 0)
                return account;
            else
            {
                account += input;
                return account;
            }
        }

        public double Balance(double account)
        {
            return account;
        }
    }
}
