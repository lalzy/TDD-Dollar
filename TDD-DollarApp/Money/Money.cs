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

    public static Dollar Dollar(int amount){
        return new Dollar(amount);
    }

    public static Franc Franc(int amount){
        return new Franc(amount);
    }

    public string Currency(){return _currency;}
}