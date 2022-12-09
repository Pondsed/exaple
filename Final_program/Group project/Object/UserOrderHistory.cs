public class UserOrderHistory{
    private List<Order> orderlist;
    private PickUpTime timebook;
    private int TotalPrice;
    public UserOrderHistory(PickUpTime timebook,int TotalPrice){
        this.timebook = timebook;
        this.TotalPrice =TotalPrice;
        this.orderlist = new List<Order>();
    }
    public void GetTimebook(){
        if(timebook.minute < 10){
           Console.WriteLine("Time book : {0}/{1}/{2} {3}:0{4}",timebook.date,timebook.month,timebook.year,timebook.hour,timebook.minute); 
        }
        if(timebook.minute >= 10){
           Console.WriteLine("Time book : {0}/{1}/{2} {3}:{4}",timebook.date,timebook.month,timebook.year,timebook.hour,timebook.minute);
        }
    }
    public int GetTotalPrice(){
        return this.TotalPrice;
    }
    public void AddOrdertoHistory(Order order){
        this.orderlist.Add(order);
    }
    public void ShowOldOrder(){
        int n = 1;
        foreach(Order order in this.orderlist){
            Console.WriteLine("-----------------------");
            Console.WriteLine("{0} : {1} X {2} : {3} Baht",n,order.GetMenuName(),order.GetAmount(),order.GetOrderPrice());
            n++;
        }
    }
}