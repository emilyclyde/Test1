using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ATM_Application.UnitTests
{
  [TestFixture]
  class AccountTest
  {
    Account myMoney = new Account() { Balance = 1000, AccountNumber = 12345 };

    //***********************************************************
    // Check Account Number
    //***********************************************************
    [Test]
    public void CheckAccountNum()
    {
      int x = myMoney.ShowAccountNum();

      Assert.AreEqual(x, 12345);
    }


    //***********************************************************
    // Check Balance
    //***********************************************************
    [Test]
    public void CheckBalance()
    {
      decimal x = myMoney.ShowBalance();

      Assert.AreEqual(x, 1000);
    }


    //***********************************************************
    // Deposit
    //***********************************************************
    [Test]   //input a positive ammont; Balance changes
    public void DepositFunds()
    {
      myMoney.Balance = 1000;
      myMoney.AddToBalance(100);

      //decimal foo = myMoney.Balance;

      Assert.AreEqual(myMoney.Balance, (decimal)1100);
    }

    [Test]   //input a negative ammont; no change to Balance
    public void DepositFundsNeg()
    {

      myMoney.Balance = 1000;
      myMoney.AddToBalance(-100);

      Assert.AreEqual(myMoney.Balance, (decimal)1000);
    }

    //***********************************************************
    // Withdrawl
    //***********************************************************
    [Test] //input a positive ammont with sufficient funds; Balance changes
    public void WithdrawFunds()
    {
      myMoney.Balance = 1000;
      myMoney.SubFromBalance(100);

      Assert.AreEqual((decimal)900, myMoney.Balance);
    }

    [Test] //input a positive ammont with insufficient funds; no change to Balance 
    public void WithdrawFundsInsuffFunds()
    {
      myMoney.Balance = 1000;
      myMoney.SubFromBalance(1200);

      Assert.AreEqual((decimal)1000, myMoney.Balance);
    }

    [Test] //input a negative ammont; no change to Balance 
    public void WithdrawFundsNeg()
    {
      myMoney.Balance = 1000;
      myMoney.SubFromBalance(-100);

      Assert.AreEqual((decimal)1000, myMoney.Balance);
    }


  }
}


