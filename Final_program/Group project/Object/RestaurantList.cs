using System.Collections.Generic;
using System;
public class RestaurantList {
    private List<Restaurant> restaurant;
    public RestaurantList(){
        this.restaurant = new List<Restaurant>();
        Restaurant Patip = new Restaurant(1,"Patip");
        restaurant.Add(Patip);
        Patip.AddFoodMenu(new FoodMenu(1,"Clear Pork Noodle",40,50));
        Patip.AddFoodMenu(new FoodMenu(2,"Clear Chicken Noodle",40,50));
        Patip.AddFoodMenu(new FoodMenu(3,"Tomyam Pork Noodle",40,50));
        Patip.AddFoodMenu(new FoodMenu(4,"Blood Chicken Noodle",40,50));
        Patip.AddFoodMenu(new FoodMenu(5,"Pork Soup",50,60));
        Restaurant YumanMuslimFood = new Restaurant(2,"YumanMuslimFood");
        restaurant.Add(YumanMuslimFood);
        YumanMuslimFood.AddFoodMenu(new FoodMenu(1,"Kao mok kai",40,50));
        YumanMuslimFood.AddFoodMenu(new FoodMenu(2,"Clear Vegetable Soup",35,45));
        YumanMuslimFood.AddFoodMenu(new FoodMenu(3,"Stir fried basil seafood",55,60));
        YumanMuslimFood.AddFoodMenu(new FoodMenu(4,"Fried Chicken",35,45));
        YumanMuslimFood.AddFoodMenu(new FoodMenu(5,"Stir Fried Pakboong",30,40));
        Restaurant PorJaroenpok = new Restaurant(3,"PorJaroenpok");
        restaurant.Add(PorJaroenpok);
        PorJaroenpok.AddFoodMenu(new FoodMenu(1,"Steamed Chicken Rice",40,50));
        PorJaroenpok.AddFoodMenu(new FoodMenu(2,"Fried Chicken Rice",40,50));
        PorJaroenpok.AddFoodMenu(new FoodMenu(3,"Steamed and Fried Chicken Rice",40,50));
        PorJaroenpok.AddFoodMenu(new FoodMenu(4,"Fried Chicken Only",45,55));
        PorJaroenpok.AddFoodMenu(new FoodMenu(5,"Steamed Chicken Only",45,55));
        Restaurant Kaokaeng = new Restaurant(4,"Kaokaeng");
        restaurant.Add(Kaokaeng);
        Kaokaeng.AddFoodMenu(new FoodMenu(1,"Squid curry",40,50));
        Kaokaeng.AddFoodMenu(new FoodMenu(2,"Kaprao Sea food",45,50));
        Kaokaeng.AddFoodMenu(new FoodMenu(3,"Kana mookrob",40,50));
        Kaokaeng.AddFoodMenu(new FoodMenu(4,"Fried Omlet",15,20));
        Kaokaeng.AddFoodMenu(new FoodMenu(5,"Fried Sausage",15,20));
        Restaurant Kaokamoo = new Restaurant(5,"Kaokamoo");
        restaurant.Add(Kaokamoo);
        Kaokamoo.AddFoodMenu(new FoodMenu(1,"Pork foot",50,60));
        Kaokamoo.AddFoodMenu(new FoodMenu(2,"Moo palo rice",50,60));
        Kaokamoo.AddFoodMenu(new FoodMenu(3,"Blood Pork Noodle",40,50));
        Kaokamoo.AddFoodMenu(new FoodMenu(4,"Blood Kaolao soup",50,60));
        Kaokamoo.AddFoodMenu(new FoodMenu(5,"Clear Kaolao soup",50,60));     
    }
    public void ShowRestaurantList(){
        Console.Clear();
        Console.WriteLine("No : Restaurant Name");
        Console.WriteLine("-------------------------------------------");
        foreach(Restaurant restaurants in this.restaurant){
            Console.WriteLine("{0} : {1}",restaurants.GetRestaurantNumber(),restaurants.GetRestaurantName());
            Console.WriteLine("---------------------------------------------");
        }
    }
     public Restaurant GetRestaurant(int restaurantNumber) {
        foreach (Restaurant restaurant in this.restaurant) {
            if (restaurantNumber == restaurant.GetRestaurantNumber()) {
                return restaurant;
            }
        }

        return new Restaurant(0, "Not has this result");
    }
    }
