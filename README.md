# Fawry E-Commerce System (Java)

This is a solution for the **Fawry Quantum Internship Challenge**.  
The project implements a simple e-commerce system using Java and Object-Oriented Design (OOD) principles.

## Features
- Define products with name, price, and quantity
- Support for:
  - Expirable products (e.g., Cheese, Biscuits)
  - Shippable products (e.g., Cheese, TV)
  - Non-shippable products (e.g., Scratch cards)
- Customers can:
  - Add products to cart (with quantity check)
  - Checkout with:
    - Subtotal calculation
    - Shipping fees (if applicable)
    - Balance deduction
- Shipping service prints shipment details for all shippable items
- Handles:
  - Out-of-stock errors
  - Expired products
  - Insufficient balance
  - Empty cart

## Example usage
```java
cart.add(cheese, 2);
cart.add(tv, 3);
cart.add(scratchCard, 1);
checkout(customer, cart);
