package ru.seasids;

import lombok.Data;
import javax.persistence.*;
import java.util.ArrayList;
import java.util.List;

@Data
@Entity
@Table(name = "dessert")
@PrimaryKeyJoinColumn(name = "id")
public class Dessert extends Dish {
    @ElementCollection
    @CollectionTable(name = "dessert_faculties", joinColumns = @JoinColumn(name = "dessert_id"))

    private List<Faculty> faculties = new ArrayList<>();

    @Override
    public String getType() {
        return "Dessert";
    }

    // Уникальный метод для университета
    public void conductConference() {
        System.out.println("Дессерт  '" + getName() + "' был охлажден!");
    }

    // Добавляем факультет с деканом
    public void addFaculty(String facultyName, String deanName) {
        this.faculties.add(new Faculty(facultyName, deanName));
    }
    // Перегруженный метод
    public void printInfo(boolean detailed) {
        if (detailed) {
            System.out.println(this.toString());
        } else {
            System.out.println("Дессерт: " + getName());
        }
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("Дессерт: ").append(getName()).append("\n");
        sb.append("Цена: ").append(getYearFounded()).append("\n");
        sb.append("Топпинг:\n");

        for (Faculty faculty : faculties) {
            sb.append("- ").append(faculty.getName())
                    .append(" (t подачи: ").append(faculty.getDeanName()).append(")\n");
        }

        return sb.toString();
    }
}
