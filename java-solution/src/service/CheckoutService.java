package service;

import Model.Customer;
import Model.Product;
import interfaces.IExpirable;
import interfaces.IShippable;
import Model.cart;

import java.util.ArrayList;
import java.util.List;
import java.util.Map;

public class CheckoutService {
    private static final double SHIPPING_FEE = 60.0;

    public static void checkout(Customer customer, cart cart) {
        if (cart.isEmpty())
            throw new IllegalArgumentException("Cart is empty");

        double subtotal = 0.0;
        List<IShippable> shipItems = new ArrayList<>();

        for (Map.Entry<Product, Integer> item : cart.getItems().entrySet()) {
            Product product = item.getKey();
            int quantity = item.getValue();

            if (!product.isAvailable(quantity))
                throw new IllegalStateException(product.getName() + " out of stock");

           if (product instanceof IExpirable) {
               IExpirable expirable=(IExpirable) product;
               if (expirable.isExpired())
                   throw new IllegalStateException(product.getName() + " is expired");
           }

            subtotal += product.getPrice() * quantity;
            if (product instanceof IShippable) {
                IShippable s = (IShippable) product;
                for (int i = 0; i < quantity; i++) {
                    shipItems.add(s);
                }
            }
        }

        double shipping = shipItems.isEmpty() ? 0.0 : SHIPPING_FEE;
        double amount = subtotal + shipping;

        if (customer.getBalance() < amount)
            throw new IllegalStateException("Insufficient balance");

        if (!shipItems.isEmpty())
            ShippingService.ship(shipItems);

        customer.deduct(amount);

        for (Map.Entry<Product, Integer> entry : cart.getItems().entrySet()) {
            entry.getKey().reduceQuantity(entry.getValue());
        }

        System.out.println("** Checkout receipt **");
        System.out.printf("%-4s %-20s %10s%n", "Qty", "Product", "Price");
        System.out.println("------------------------------------------------------");

        for (Map.Entry<Product, Integer> entry : cart.getItems().entrySet()) {
            int qty = entry.getValue();
            Product p = entry.getKey();
            System.out.printf("%-4d %-20s %10.2f%n", qty, p.getName(), p.getPrice() * qty);
        }

        System.out.println("----------------------------------------------------------------");
        System.out.printf("%-24s %10.2f%n", "Subtotal", subtotal);
        System.out.printf("%-24s %10.2f%n", "Shipping", shipping);
        System.out.printf("%-24s %10.2f%n", "Amount", amount);

    }
}
