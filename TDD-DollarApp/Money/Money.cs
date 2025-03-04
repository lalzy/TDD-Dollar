public class Money{    
    public int Amount;

    public bool Equals(Object obj){
        Money money = (Money) obj;
        return Amount == money.Amount 
            && GetType().Equals(money.GetType());
    }
}