# Fawry E-Commerce System (Java + C# Solutions)

This repository contains solutions for the **Fawry Quantum Internship Challenge** implemented in both **Java** and **C#** using Object-Oriented Design (OOD), **SOLID principles**, and design patterns (Factory, Strategy, Decorator).

---

## 📌 Challenge Summary
Design and implement an e-commerce system with the following requirements:
- Products have name, price, and quantity.
- Some products may expire (e.g., Cheese, Biscuits), while others do not (e.g., TV, Mobile).
- Some products require shipping (e.g., Cheese, TV) and provide weight; others do not (e.g., Mobile scratch cards).
- Customers can:
  - Add products to cart with specific quantity (not exceeding stock).
  - Checkout: 
    - Print order subtotal
    - Calculate shipping fees
    - Print paid amount and remaining balance
    - Handle errors (empty cart, insufficient balance, out-of-stock or expired products)
    - Send shippable items to a shipping service.

---

## 🗂 Project Structure
```
ecommerce-system-fawry-challenge
├── java-solution
│ ├── src
│ │ ├── model
│ │ ├── interfaces
│ │ ├── service
│ │ └── EcommerceMain.java
│ └── README.md
├── csharp-solution
│ ├── Program.cs
│ ├── Models/
│ └── Services/
└── README.md
```
---

## 🚀 Technologies
- **Java 17+**
- **C# (.NET 8)**

---

## 🧠 SOLID Principles + Design Patterns
- **Single Responsibility Principle**: Each class has one responsibility.
- **Open/Closed Principle**: Extend functionality without modifying existing code.
- **Liskov Substitution Principle**: Decorators and interfaces replace base types seamlessly.
- **Interface Segregation Principle**: Small, focused interfaces (IShippable, IExpirable, etc.)
- **Dependency Inversion Principle**: Checkout depends on abstractions (e.g., ShippingStrategy).
- **Design Patterns Used**:  
  - *Factory*: For product creation  
  - *Strategy*: For shipping calculation  
  - *Decorator*: For adding expiration or shipping behavior dynamically  

---

## ⚡ How to Run

### Java
```bash
cd java-solution/src
javac model/*.java interfaces/*.java service/*.java EcommerceMain.java
java EcommerceMain

### C#
cd csharp-solution
dotnet run

💡 Example Output

** Shipment notice **
2    Cheese               400g
1    Biscuits             700g
Total package weight 1.1kg

** Checkout receipt **
Qty  Product              Price     
-------------------------------------------
2    Cheese               200.00
1    Biscuits             150.00
1    Scratch Card          50.00
-------------------------------------------
Subtotal                   400.00
Shipping                    30.00
Amount                      430.00
Balance                     570.00

 ###Notes
✅ The code is designed for easy extension (e.g., adding new shipping methods or product types).
✅ All business rules from the challenge are covered, including edge cases.
