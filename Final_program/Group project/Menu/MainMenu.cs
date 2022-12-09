using System;
using System.Collections.Generic;
class MainMenu{
  private Register registermenu;
  private Login loginmenu;
  private MainMenu2 mainMenu2;
  private List<User> userList;
  public void ShowMainMenu(){
    PrepareListUsersWhenMainScreenIsLoaded();
    ShowMenucontrol();
    }
    public void ShowMenucontrol(){
    Console.WriteLine(userList.Count());
    Console.WriteLine("Welcome to KMUTT Bangkhuntian Canteen");
    Console.WriteLine("1 : Register Menu");
    Console.WriteLine("2 : Login Menu");
    Console.Write("Please input Menu : ");
    int menu = int.Parse(Console.ReadLine());
    if(menu == 2){
        LoginMenu();
    }
    else if(menu == 1){
        RegisterMenu();
        ShowMenucontrol();
    }
  }
  private void PrepareListUsersWhenMainScreenIsLoaded() {
        this.userList = new List<User>();
    }
    private void PrepareMainMenu2() {
        this.mainMenu2 = new MainMenu2();
    }
    
    public void LoginMenu(){
        this.loginmenu = new Login();
        bool verify = this.loginmenu.InputLogin(this.userList);
        ShowLoginIncorrectScreen(verify);
    }
     public void RegisterMenu() {
        this.registermenu = new Register();
        this.userList.Add(this.registermenu.InputRegister(this.userList));
    }
    public void ShowLoginIncorrectScreen(bool verifystatus){
        if(!verifystatus){
            Console.WriteLine("Login Fail Please try again");
            ShowMenucontrol();
        }
    }
    public void PrepareforLogout(List<User> listfromlogout){
        this.userList = listfromlogout;
        ShowMenucontrol();
    }
    }
