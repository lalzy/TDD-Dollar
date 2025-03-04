public class Dollar{
    public int Amount;

    public Dollar(int amount){
        this.Amount = amount;
    }

    public void times(int multiplier){
        this.Amount *= multiplier;
    }
}