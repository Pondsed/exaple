public class FoodMenu{
   private int foodnumber;
    private string foodname;
    private int normalprice;
    private int highprice;
    public FoodMenu(int foodnumber ,string foodname,int normalprice,int highprice){
        this.foodnumber = foodnumber;
        this.foodname = foodname;
        this.normalprice = normalprice;
        this.highprice = highprice;
    }
     public int GetFoodNumber(){
        return this.foodnumber;
    }
    public string GetFoodName(){
        return this.foodname;
    }
    public int GetNormalPrice(){
        return this.normalprice;
    }
    public int GetHighPrice(){
        return this.highprice;
    }
}