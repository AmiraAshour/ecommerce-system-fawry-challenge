import Model.*;
import service.CheckoutService;

import java.time.LocalDate;

public class Main {
    public static void main(String[] args) {
        Customer c=new Customer("Amira",500000);
        Product cheese=new ExpirableShippableProduct("Cheese",100,10, LocalDate.now().plusDays(2),400);
        Product biscuits=new ExpirableShippableProduct("Biscuits",150,5,LocalDate.now().plusDays(3),700);
        Product tv=new ShippableProduct("TV",5000,2,20000);
        Product scratchCart=new Product("Scratch Cart",50,100);

        cart cart =new cart();
        cart.add(cheese,2);
        cart.add(biscuits,1);
        cart.add(scratchCart,1);
        cart.add(tv,1);
        CheckoutService.checkout(c,cart);
    }
}