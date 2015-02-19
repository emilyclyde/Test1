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
Account myMoney = new Account() { Balance = 1000, AccountNumber=12345 };

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
        myMoney.AddToBalance(100);
       
      Assert.AreEqual(1100, myMoney);
    }

    [Test]   //input a negative ammont; no change to Balance
      public void DepositFundsNeg()
      {
          myMoney.AddToBalance(-100);

          Assert.AreEqual(1000, myMoney);
      }

//***********************************************************
// Withdrawl
//***********************************************************
    [Test] //input a positive ammont with sufficient funds; Balance changes
    public void WithdrawFunds()
    {
        myMoney.SubFromBalance(100);

      Assert.AreNotEqual(900, myMoney);
    }

    [Test] //input a positive ammont with insufficient funds; no change to Balance 
    public void WithdrawFundsInsuffFunds()
    {
        myMoney.SubFromBalance(1200);

        Assert.AreEqual(1000, myMoney);
    }

    [Test] //input a negative ammont; no change to Balance 
    public void WithdrawFundsNeg()
    {
        myMoney.SubFromBalance(-100);

        Assert.AreEqual(1000, myMoney);
    }

      
  }
}


