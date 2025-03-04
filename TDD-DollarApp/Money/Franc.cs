public class Franc : Money{
    public Franc(int amount){
        this.Amount = amount;
    }

    public Franc Times(int multiplier){
        return new Franc(Amount * multiplier);
    }

}