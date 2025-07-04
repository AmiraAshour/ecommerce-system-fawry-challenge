package interfaces;

public interface IProduct {
    String getName();
    double getPrice();
    void reduceQuantity(int amount);
    boolean isAvailable(int amount);
}
