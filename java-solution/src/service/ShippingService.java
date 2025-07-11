package service;

import interfaces.IShippable;

import java.util.LinkedHashMap;
import java.util.List;
import java.util.Map;

public class ShippingService {
    public static void ship(List<IShippable>items){
        double totalWeight=0.0;
        Map<String,Integer> count=new LinkedHashMap<>();
        Map<String,Double> weight=new LinkedHashMap<>();

        for(IShippable item :items){
            count.put(item.getName(),count.getOrDefault(item.getName(),0)+1);
            weight.put(item.getName(),item.getWeight());
            totalWeight+=item.getWeight();
        }

        System.out.println("** Shipment notice **");

        for (String name :count.keySet()){
            System.out.printf("%-4d %-20s %6.0fg%n",count.get(name),name,weight.get(name));
        }

        System.out.printf("Total package weight %.1fkg%n", totalWeight / 1000);

    }
}
