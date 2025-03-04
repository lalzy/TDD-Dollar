namespace TDD_DollarApp.tests;

public class UnitTest1
{
    [Fact]
    public void TestDollarMultiplication()
    {
        Dollar five = Money.Dollar(5);
        Assert.Equivalent(Money.Dollar(10), five.Times(2));
        Assert.Equivalent(Money.Dollar(15), five.Times(3));
    }

    [Fact]
    public void TestEquality(){
        Assert.True(Money.Dollar(5).Equals(Money.Dollar(5)));
        Assert.False(Money.Dollar(5).Equals(Money.Dollar(6)));
        Assert.True(Money.Franc(5).Equals(new Franc(5)));
        Assert.False(Money.Franc(5).Equals(new Franc(6)));
        Assert.False(Money.Franc(5).Equals(Money.Dollar(5)));
    }
    [Fact]
    public void TestFrancMultiplication()
    {
        Franc five = Money.Franc(5);
        Assert.Equivalent(Money.Franc(10), five.Times(2));
        Assert.Equivalent(Money.Franc(15), five.Times(3));
    }
}