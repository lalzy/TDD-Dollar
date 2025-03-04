public abstract class Money{    
    public int Amount;

    public bool Equals(Object obj){
        Money money = (Money) obj;
        return Amount == money.Amount 
            && GetType().Equals(money.GetType());
    }

    public static Dollar Dollar(int amount){
        return new Dollar(amount);
    }

    public static Franc Franc(int amount){
        return new Franc(amount);
    }
}