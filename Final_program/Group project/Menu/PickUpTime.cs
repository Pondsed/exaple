public class PickUpTime{
    public int date;
    public string month;
    public int year;
    public int hour;
    public int minute;
    public PickUpTime(int date,string month,int year,int hour,int minute){
        this.date = date;
        this.month = month;
        this.year = year;
        this.hour = hour;
        this.minute = minute;
    }
    public void PickupDate(){
        if(this.month == "January" || this.month == "March" || this.month == "May" || this.month == "July" & this.month == "August" || this.month == "October" || this.month == "December"){
            Console.WriteLine("Select Date by input 1-31 : ");
            Console.Write("Select Date : ");
            int input = int.Parse(Console.ReadLine());
            if(input >= 1 && input <= 31){
                this.date = input;
            }
            else{
                Console.WriteLine("Please input only 1 - 31");
                PickupDate();
            }
        }
        if(this.month == "February"){
            Console.WriteLine("Select Date by input 1-28 : ");
            Console.Write("Select Date : ");
            int input = int.Parse(Console.ReadLine());
            if(input >= 1 && input <= 28){
                this.date = input;
            }
            else{
                Console.WriteLine("Please input only 1 - 28");
                PickupDate();
            }
        }
        if(this.month == "April" || this.month == "June" || this.month == "September" || this.month == "November"){
            Console.WriteLine("Select Date by input 1-30 : ");
            Console.Write("Select Date : ");
            int input = int.Parse(Console.ReadLine());
            if(input >= 1 && input <= 30){
                this.date = input;
            }
            else{
                Console.WriteLine("Please input only 1 - 30");
                PickupDate();
            }
        }
    }
    public void PickupMonth(){
        Console.WriteLine("Select month by input 1-12 :");
        Console.Write("Select Month :");
        int n = int.Parse(Console.ReadLine());
        switch(n){
            case 1:
            this.month = "January";
            break;
            case 2:
            this.month = "February";
            break;
            case 3:
            this.month = "March";
            break;
            case 4:
            this.month = "April";
            break;
            case 5:
            this.month = "May";
            break;
            case 6:
            this.month = "June";
            break;
            case 7:
            this.month = "July";
            break;
            case 8:
            this.month = "August";
            break;
            case 9:
            this.month = "September";
            break;
            case 10:
            this.month = "October";
            break;
            case 11:
            this.month = "November";
            break;
            case 12:
            this.month = "December";
            break;
            default:
            Console.WriteLine("Please input Only 1-12");
            PickupMonth();
            break;
        }
    }
    public void PickupYear(){
        int n = 0;
        while(n < 2565){
            Console.WriteLine("Input Year = 2565 or more than");
        Console.Write("Year : ");
        int N = int.Parse(Console.ReadLine());
            if(N >= 2565){
                n = N;
            }
            if(N < 2565){
                Console.WriteLine("Please input only 2565 or more than");
            }
        }
        this.year = n;
    }
    public void PickupHour(){
        Console.Write("Hour : ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0){
            Console.WriteLine("Please input only 1-24");
            PickupHour();
        }
        if(n > 0){
            int Hour = n  % 24;
            this.hour = Hour; 
        }
    }
    public void PickupMinute(){
        Console.Write("Minute : ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0){
            Console.WriteLine("Please input only 1-60");
            PickupMinute();
        }
        if(n > 0){
            int Minute = n  % 60;
            this.minute = Minute;
        }
    }
}