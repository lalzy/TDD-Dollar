using System.ComponentModel;

namespace TDD_DollarApp.tests;

public class UnitTest1
{
    [Fact]
    public void TestDollarMultiplication()
    {
        Money five = Money.Dollar(5);
        Assert.Equivalent(Money.Dollar(10), five.Times(2));
        Assert.Equivalent(Money.Dollar(15), five.Times(3));
    }

    [Fact]
    public void TestEquality(){
        Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
        Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
        Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
    }
    [Fact]
    public void TestFrancMultiplication()
    {
        Money five = Money.Franc(5);
        Assert.Equivalent(Money.Franc(10), five.Times(2));
        Assert.Equivalent(Money.Franc(15), five.Times(3));
    }

    [Fact]
    public void TestCurrency(){
        Assert.Equal("USD", Money.Dollar(1).Currency());
        Assert.Equal("CHF", Money.Franc(1).Currency());
    }

    [Fact]
    public void TestSimpleAddition(){
        Money five = Money.Dollar(5);
        Expression sum = five.Plus(five);
        Bank bank = new Bank(); 
        Money reduced = bank.reduce(sum, "usd");
        Assert.Equivalent(Money.Dollar(10), reduced);
    }
}