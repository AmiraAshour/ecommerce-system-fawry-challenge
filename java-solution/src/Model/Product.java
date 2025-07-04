package Model;

import interfaces.IProduct;

public class Product implements IProduct {
    protected String name;
    protected double price;
    protected int quantity;
    public  Product (String name ,double price ,int quantity){
        this.name=name;
        this.price=price;
        this.quantity=quantity;
    }
    public String getName(){
        return name;
    }
    public double getPrice(){
        return price;
    }
   public  boolean isAvailable(int amount){
        return quantity>=amount;
   }
    public void reduceQuantity(int amount){
        quantity-=amount;
    }

}
