public class Dollar{
    public int Amount;

    public Dollar(int amount){
        this.Amount = amount;
    }

    public Dollar Times(int multiplier){
        return new Dollar(Amount * multiplier);
    }

    public bool Equals(Object obj){
        Dollar dollar = (Dollar) obj;
        return Amount == dollar.Amount;
    }
}