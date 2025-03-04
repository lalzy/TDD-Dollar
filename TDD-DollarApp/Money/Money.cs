public abstract class Money{    
    public int Amount;
    protected string _currency;

    public Money(int amount, string currency){
        this.Amount = amount;
        this._currency = currency;
    }

    public bool Equals(Object obj){
        Money money = (Money) obj;
        return Amount == money.Amount 
            && GetType().Equals(money.GetType());
    }

    public static Dollar Dollar(int amount){
        return new Dollar(amount, "USD");
    }

    public static Franc Franc(int amount){
        return new Franc(amount, "CHF");
    }

    public abstract string Currency();
}