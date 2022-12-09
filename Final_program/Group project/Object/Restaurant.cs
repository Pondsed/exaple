using System.Collections.Generic;
using System;
public class Restaurant{
    private int restaurantNumber;
    private string restaurantName;
    private List<FoodMenu>foodmenu;
    public Restaurant(int restaurantNumber,string restaurantName){
        this.restaurantNumber = restaurantNumber;
        this.restaurantName = restaurantName;
        this.foodmenu = new List<FoodMenu>();
    }
    public int GetRestaurantNumber() {
        return this.restaurantNumber;
    }
    public string GetRestaurantName() {
        return this.restaurantName;
    }

    public void ShowFoodMenu() {
        Console.WriteLine("----------------------");
        foreach(FoodMenu foodMenu in this.foodmenu){
            Console.WriteLine("{0} : {1} ",foodMenu.GetFoodNumber(),foodMenu.GetFoodName());
            Console.WriteLine("Normal Price {0} Baht : Special Price {1} Baht ",foodMenu.GetNormalPrice(),foodMenu.GetHighPrice());
        }
    }
    public List<FoodMenu> GetFoodMenuList(){
        return this.foodmenu;
    }
    public void AddFoodMenu(FoodMenu foodmenu){
        this.foodmenu.Add(foodmenu);
    }
}