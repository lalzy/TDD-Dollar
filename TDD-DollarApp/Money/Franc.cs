public class Franc : Money{
    public Franc(int amount){
        this.Amount = amount;
    }

    public Money Times(int multiplier){
        return new Franc(Amount * multiplier);
    }

}