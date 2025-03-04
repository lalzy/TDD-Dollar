public class Dollar : Money{
    public Dollar(int amount, string currency) : base(amount, currency){}

    public Money Times(int multiplier){
        return Money.Dollar(Amount * multiplier);
    }
    public override string Currency(){
        return _currency;
    }
}