using System.Collections.Generic;
using System;
public class MainMenu2{
    private User user;
    private RestaurantList restaurantList;
    private List<Order> orderList;
    private ShoppingCart shoppingcart;
    public void ShowUserMenuController(User user,List<User>userlist) {
        Console.Clear();
        SetupUser(user);
        SetupOrderlist();
        PrepareShoppingcart();
        ShowUserMenu(userlist);
    }
    public void ShowUserMenu(List<User> userlist){
        Console.WriteLine("Welcome {0}.",this.user.GetFirstname());
        Console.WriteLine("*********************************");
        Console.WriteLine("Please Select the Menu");
        Console.WriteLine("Type 1 to choose Select Restaurant");
        Console.WriteLine("Type 2 to See Order history");
        Console.WriteLine("Type 3 to Log out");
        Console.Write("Input : ");
        int input = int.Parse(Console.ReadLine());
        if(input == 1){
            Selectrestaurant(userlist);
        }
        if(input == 2){
            SelectFromYourHistory(userlist);
        }
        if(input == 3){
            Logout(userlist);
        }
    }
    private void SetupUser(User user) {
        this.user = (User)user;
    }
    public void SetupOrderlist(){
        this.orderList = new List<Order>();
    }
    public void PrepareShoppingcart(){
        this.shoppingcart = new ShoppingCart();
    }
    public void Selectrestaurant(List<User> userlist){
        this.restaurantList = new RestaurantList();
        restaurantList.ShowRestaurantList();
        Console.WriteLine("Please Select the Restaurant by input 1-5");
        Console.Write("input : ");
        int input = int.Parse(Console.ReadLine());
        Restaurant restaurant = restaurantList.GetRestaurant(input);
        restaurant.ShowFoodMenu();
        Console.WriteLine("Do you want to go back?");
        Console.WriteLine("Type yes = Yes");
        Console.WriteLine("Type anything = No");
        Console.Write("input : ");
        string DecideInput = Console.ReadLine();
        if(DecideInput == "yes" ){
            Selectrestaurant(userlist);
        }
        if(DecideInput !="yes"){
            this.shoppingcart.ShowShoppingCartMenu(user,restaurant);
        }
        ShowUserMenuController(user,userlist);
    }
    public void Logout(List<User> userlist){
        MainMenu mainMenu = new MainMenu();
        Console.Clear();
        mainMenu.PrepareforLogout(userlist);
    }
    public void SelectFromYourHistory(List<User> userlist){
        user.ShowUserOrderHistory();
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Back to Main menu ");
        Console.ReadLine();
        Console.Clear();
        ShowUserMenuController(user,userlist);
    }
    }
