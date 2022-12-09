using System.Collections.Generic;
using System;
public class Register{
    public User InputRegister(List<User> userlist){
        Console.Clear();
        Console.WriteLine("Welcome to Register menu");
        bool registerverify = false;
        int numberforcheck = 0;
        while(registerverify == false){
        string emailUser = InputEmailUser();
        string firstname = InputFirstName();
        string lastname = InputLastName();
        string password = SetupPassword();
        int phonenumber = InputPhonenumber();
        foreach(User user in userlist){
            if(user.GetEmailUser() == emailUser || user.GetPhoneNumber() == phonenumber){
                numberforcheck++;
            }
        }
        if(numberforcheck == 0){
            Console.WriteLine("Your registrarion is success");
            registerverify = true;
            return new User(emailUser,firstname,lastname,password,phonenumber);
        }
        else{
            Console.WriteLine("This Email or Phonenumber has already used for register");
            Console.WriteLine("Please try again");
            Console.WriteLine("Press Enter to register again");
            Console.ReadLine();
            Console.Clear();
            registerverify = false;
            numberforcheck = 0;
            }
        }
       return null;
      } 

    public string InputEmailUser(){
        Console.Write("Input Email : ");
        return Console.ReadLine();
    }
    public string InputFirstName(){
        Console.Write("Input First Name : ");
        return Console.ReadLine();
    }
    public string InputLastName(){
        Console.Write("Input Last name : ");
        return Console.ReadLine();
    }
    public string SetupPassword(){
        Console.Write("Setup Your Password : ");
        return Console.ReadLine();
    }
    public int InputPhonenumber(){
        Console.Write("Input Phone number : ");
        return int.Parse(Console.ReadLine());
    }
}
    