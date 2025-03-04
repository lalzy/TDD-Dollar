public class Franc : Money{
    public Franc(int amount, string currency = "CHF") : base(amount, currency){
        this._currency = currency;
    }

    public Money Times(int multiplier){
        return new Money(Amount * multiplier, _currency);
    }
}