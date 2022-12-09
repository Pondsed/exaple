public class User {
    private string emailUser;
    private string firstname;
    private string lastname;
    private string password;
    private int phonenumber;
    private List<UserOrderHistory> userOrderHistory;
    public User(string emailUser,string firstname,string lastname,string password,int phonenumber){
        this.emailUser = emailUser;
        this.firstname = firstname;
        this.lastname = lastname;
        this.password = password;
        this.phonenumber = phonenumber;
        this.userOrderHistory = new List<UserOrderHistory>();
    }
    public string GetEmailUser(){
        return this.emailUser;
    }
    public string GetFirstname(){
        return this.firstname;
    }
    public string GetLastname(){
        return this.lastname;
    }
    public string GetPassword(){
        return this.password;
    }
    public int GetPhoneNumber(){
        return this.phonenumber;
    }
    public void AddUserLateOrderHistory(UserOrderHistory UserOrder){
        this.userOrderHistory.Add(UserOrder);
    }
    public void ShowUserOrderHistory(){
        foreach(UserOrderHistory UserOrder in this.userOrderHistory){
          UserOrder.ShowOldOrder();
          Console.WriteLine("Total Price : {0}",UserOrder.GetTotalPrice());
          UserOrder.GetTimebook();
          Console.WriteLine("---------------------");
        }
    }
    

}