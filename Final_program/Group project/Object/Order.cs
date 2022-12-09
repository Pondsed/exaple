public class Order{
    private string MenuName;
    private int amount;
    private int OrderPrice;
    public Order(string MenuName,int amount,int OrderPrice){
        this.MenuName = MenuName;
        this.amount = amount;
        this.OrderPrice = OrderPrice;
    }
    public string GetMenuName(){
        return this.MenuName;
    }
    public int GetAmount(){
        return this.amount;
    }
    public int GetOrderPrice(){
        return this.OrderPrice;
    }
    public void SetMenuName(string MenuInput){
        this.MenuName = MenuInput;
    }
    public void SetAmount(int AmountInput){
        this.amount = AmountInput;
    }
}