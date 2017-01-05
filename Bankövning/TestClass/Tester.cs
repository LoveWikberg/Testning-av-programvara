using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using NUnit.Framework;

namespace TestClass
{
    [TestFixture]
    public class Tester
    {
        [Test]
        public void Debit()
        {
            double account = 20000;
            double input = 1000;
            double expectedOutput = account - input;

            Bank bank = new Bank();
            double actualOutput = bank.Debit(input, account);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void DebitFail()
        {
            double account = 100;
            double input = 1000;

            double expectedOutput = account;

            Bank bank = new Bank();
            double actual = bank.Debit(input, account);

            Assert.AreEqual(expectedOutput, actual);
        }

        #region things
        //[Test]
        //public void Debitdjiwej([Values(1,2,3,4,5,6,7,8)] int input)
        //{
        //    double expectedOutput = Bank.account - input;

        //    Bank bank = new Bank();
        //    double actualOutput = bank.Debit(input);

        //    Assert.AreEqual(expectedOutput, actualOutput);
        //}

        //[Test]
        //public void Debut_1000()
        //{
        //    double account = 20000;
        //    for (int i = 0; i < 1000; i++)
        //    {
        //        double expectedOutput = account - i;
        //        Bank bank = new Bank();
        //        double actual = bank.Debit(i);

        //        Assert.AreEqual(expectedOutput, actual);
        //    }
        //}
        #endregion

        [Test]
        public void Credit()
        {
            double account = 20000;
            double input = 1000;
            double expectedOutput = account + input;

            Bank bank = new Bank();
            double actualOutput = bank.Credit(input, account);

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void MinusCredit()
        {
            double account = 200.55;
            double input = -300.55;
            double expected = account;

            Bank bank = new Bank();
            double actual = bank.Credit(input, account);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Balance()
        {
            double account = 20000;
            Bank bank = new Bank();
            account = bank.Balance(account);

            Console.WriteLine(account);
        }
    }
}
