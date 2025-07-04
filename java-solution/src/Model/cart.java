package Model;

import java.util.LinkedHashMap;
import java.util.Map;

public class cart {
    private Map<Product,Integer> items=new LinkedHashMap<>();
    public void add(Product product,int quantity){
        if (!product.isAvailable(quantity))
            throw new IllegalArgumentException("Requested quantity exceeds available stock");
        items.put(product,items.getOrDefault(product,0)+quantity);
    }
    public  Map<Product,Integer> getItems(){
        return items;
    }
    public  boolean isEmpty(){
        return items.isEmpty();
    }
}
