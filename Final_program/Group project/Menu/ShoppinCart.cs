using System.Collections.Generic;
using System;
public class ShoppingCart {
    private User user;
    private Restaurant restaurant;
    private List<Order> Orderlist;
    private PickUpTime timeadd;
    private CalculatePrice calculator;
    public void OrderlistLoad(){
        this.Orderlist = new List<Order>();
    }
    private void SetupUser(User user) {
        this.user = user;
    }
    private void SetupRestaurant(Restaurant restaurant) {
        this.restaurant = restaurant;
    }
    private void SetupCalculator(){
        this.calculator = new CalculatePrice();
    }
    public void ShowShoppingCartMenu(User user,Restaurant restaurant){
        SetupUser(user);
        SetupRestaurant(restaurant);
        OrderlistLoad();
        SetupCalculator();
        ShowMainShoppingMenu(restaurant);
    }
    public void ShowMainShoppingMenu(Restaurant restaurant){
        Console.Clear();
        string orderstatus = "";
        while(orderstatus != "finish"){
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Input add for Add item to your cart");
            Console.WriteLine("Input delete for delete item from your cart");
            Console.WriteLine("Input finish to finish your order");
            Console.Write("Input : ");
            orderstatus = Console.ReadLine();
            if(orderstatus == "add"){
                AddCartItem(user,restaurant);
            }
            if(orderstatus == "delete"){
                DeleteCartItem(Orderlist);
            }
        }
        Console.Clear();
        Console.WriteLine("Select your time to get your order");
        Console.WriteLine("---------------------------------");
        Timeadd();
        Console.Clear();
        Console.WriteLine("Your order is  : {0}",restaurant.GetRestaurantName());
        Console.WriteLine("---------------------------------");
        foreach(Order order in this.Orderlist){
            Console.WriteLine("{0} X {1} : {2}",order.GetMenuName(),order.GetAmount(),order.GetOrderPrice());
            Console.WriteLine("---------------------------------");
        }
        int Allprice = calculator.CalculateAllprice(Orderlist);
        Console.WriteLine("Total Price : {0} Baht",Allprice);
        if(timeadd.minute < 10){
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Order Time book at : {0}/{1}/{2} time : {3}:0{4} ",timeadd.date,timeadd.month,timeadd.year,timeadd.hour,timeadd.minute);
            Console.WriteLine("---------------------------------");
        }
        if(timeadd.minute >= 10){
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Order Time book at : {0}/{1}/{2} time : {3}:{4} ",timeadd.date,timeadd.month,timeadd.year,timeadd.hour,timeadd.minute);
            Console.WriteLine("---------------------------------");
        }
        bool laststagestatus = false;
        string Input = "";
        while(laststagestatus != true){
            Console.WriteLine("Do you want to Confirm this order ?");
            Console.WriteLine("Input 1 for yes");
            Console.WriteLine("Input 2 for no and go back to edit your order");
            Console.Write("Input : ");
            string input = Console.ReadLine();
            if(input == "1"){
                laststagestatus = true;
                Input = input;
                ShowConfirmOrder(user,Orderlist,timeadd,Allprice);
            }
            else if(input == "2"){
                laststagestatus = true;
                Input = input;
                ShowMainShoppingMenu(restaurant);
            }
            else{
                Console.WriteLine("Please Input Only 1 or 2");
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
            }         
        }
            Console.WriteLine("Going Back to Main Menu");
            Console.WriteLine("Press Enter to Back to Main Menu");
            Console.ReadLine();
    }
    public void AddCartItem(User user,Restaurant restaurant) {
        restaurant.ShowFoodMenu();
                Console.WriteLine("---------------------------------");
                int foodnumber = 0;
                while(foodnumber != 5 && foodnumber != 4 && foodnumber != 3 && foodnumber != 2 && foodnumber != 1){
                    Console.WriteLine("Input Foodnumber of menu and amount");
                    Console.Write("Input Foodnumber : ");
                    int Foodnumber = int.Parse(Console.ReadLine());
                    if(Foodnumber == 1 || Foodnumber == 2|| Foodnumber == 3|| Foodnumber == 4|| Foodnumber == 5){
                        foodnumber = Foodnumber;
                    }
                    if(Foodnumber != 1 && Foodnumber != 2 && Foodnumber != 3 && Foodnumber != 4 && Foodnumber != 5){
                        Console.WriteLine("Please input only 1 - 5");
                    }
                }
                Console.Write("Input amount : ");
                int amount = int.Parse(Console.ReadLine());
                int pricechoice = 0;
                while(pricechoice != 1 && pricechoice != 2){
                    Console.WriteLine("Input 1 for normal price and 2 for high price");
                    Console.Write("Input price choice : ");
                    int Pricechoice = int.Parse(Console.ReadLine());
                    if(Pricechoice == 1 || Pricechoice == 2){
                        pricechoice = Pricechoice;
                    }
                    if(Pricechoice != 1 && Pricechoice != 2){
                        Console.WriteLine("Please input only 1 or 2");
                    }
                }
                string ordername = SetOrdername(foodnumber);
                int price = calculator.CalculateOrderPrice(foodnumber,amount,pricechoice,this.restaurant);
                Order order = new Order(ordername,amount,price);
                this.Orderlist.Add(order);
    }
    public void DeleteCartItem(List<Order> Orderlist) {
        Console.Clear();
        int n = 1;
        foreach(Order order in this.Orderlist){
            Console.WriteLine("Order No. {0} : {1} X {2} : {3}",n,order.GetMenuName(),order.GetAmount(),order.GetOrderPrice());
            Console.WriteLine("---------------------------------");
            n++;
        }
        Console.WriteLine("Select the order to delete by input an order number");
        Console.Write("Input : ");
        int MenunameToDelete = int.Parse(Console.ReadLine());
        Orderlist.RemoveAt(MenunameToDelete - 1);
        Console.WriteLine("Order Update");
        foreach(Order order in this.Orderlist){
            Console.WriteLine("{0} X {1} : {2}",order.GetMenuName(),order.GetAmount(),order.GetOrderPrice());
            Console.WriteLine("---------------------------------");
        }
    }
    public void Timeadd() 
    {
        PickUpTime pickuptime = new PickUpTime(0,"",0,0,0);
        pickuptime.PickupMonth();
        pickuptime.PickupDate();
        pickuptime.PickupYear();
        pickuptime.PickupHour();
        pickuptime.PickupMinute();
        this.timeadd = pickuptime;
    }
    public string SetOrdername(int foodnumber){
        string ordername = "";
        foreach(FoodMenu food in restaurant.GetFoodMenuList()){
            if(foodnumber == food.GetFoodNumber()){
                ordername = food.GetFoodName(); 
            }
        }
        return ordername;
    }
    public void ShowConfirmOrder(User user,List<Order> Orderlist,PickUpTime timebook,int Allprice){
        Console.Clear();
        Console.WriteLine("Your Order Has been sent to the restaurant");
        int n =1;
        foreach(Order order in Orderlist){
            Console.WriteLine("{0} : {1} X {2} : {3} Baht",n,order.GetMenuName(),order.GetAmount(),order.GetOrderPrice());
            Console.WriteLine("---------------------------------");
            n++;
        }
        Console.WriteLine("Total Price : {0} Baht",Allprice);
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Your Order will ready at {0}:{1} {2}/{3}/{4}",timebook.hour,timebook.minute,timebook.date,timebook.month,timebook.year);
        UserOrderHistory userorder = new UserOrderHistory(timebook,Allprice);
        foreach(Order order in Orderlist){
            userorder.AddOrdertoHistory(order);
        }
        user.AddUserLateOrderHistory(userorder);
    }
}