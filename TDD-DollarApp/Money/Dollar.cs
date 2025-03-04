public class Dollar : Money{
    public Dollar(int amount, string currency = "USD") : base(amount, currency){
        this._currency = currency;
    }

    public Money Times(int multiplier){
        return new Money(Amount * multiplier, _currency);
    }
}