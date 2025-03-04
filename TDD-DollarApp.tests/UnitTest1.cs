namespace TDD_DollarApp.tests;

public class UnitTest1
{
    [Fact]
    public void testMultiplication()
    {
        Dollar five = new Dollar(5);
        five.times(2);
        Assert.Equal(10, five.Amount);
    }
}