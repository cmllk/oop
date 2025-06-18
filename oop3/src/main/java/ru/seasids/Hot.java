package ru.seasids;

import lombok.Data;
import javax.persistence.*;

import java.util.ArrayList;
import java.util.List;

@Data
@Entity
@Table(name = "hots")
@PrimaryKeyJoinColumn(name = "id")
public class Hot extends Dish {

    @ElementCollection
    @CollectionTable(name = "hot_subjects", joinColumns = @JoinColumn(name = "hot_id"))
    @Column(name = "garnir")

    private List<String> subjects = new ArrayList<>();
    @Column(name = "weight")
    private int weight;

    @Override
    public String getType() {
        return "hot";
    }

    // Уникальный метод для школы
    public void printSchedule() {
        System.out.println("Гарниры для горячего блюда: '" + getName() + "':");
        System.out.println("1. Рис");
        System.out.println("2. Булгур");
        System.out.println("3. Кус-Кус");
    }

    // Перегруженный метод
    public void printInfo(boolean detailed) {
        if (detailed) {
            System.out.println("Подробная информация о блюде:");
            System.out.println("Гарниры: " + String.join(", ", subjects));
            System.out.println("Кол-во блюда.: " + weight);
        } else {
            System.out.println("Горячее блюдо: " + getName());
        }
    }
}
