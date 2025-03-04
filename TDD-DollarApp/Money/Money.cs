public class Money{    
    public int Amount;
    protected string _currency;

    public Money(int amount, string currency){
        this._currency = currency;
        this.Amount = amount;
    }

    public bool Equals(Object obj){
        Money money = (Money) obj;
        return Amount == money.Amount 
            && Currency().Equals(money._currency);
    }

    public static Money Dollar(int amount){
        return new Money(amount, "USD");
    }

    public static Money Franc(int amount){
        return new Money(amount, "CHF");
    }

    public Money Times(int multiplier){
        return new Money(Amount * multiplier, _currency);
    }

    public string Currency(){return _currency;}
}