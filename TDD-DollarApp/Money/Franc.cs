public class Franc : Money{
    public Franc(int amount, string currency) :base(amount, currency){}

    public Money Times(int multiplier){
        return Money.Franc(Amount * multiplier);
    }

    public override string Currency(){
        return _currency;
    }

}