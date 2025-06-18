package ru.seasids;

import lombok.Data;
import javax.persistence.*;

@Data
@Entity
@Inheritance(strategy = InheritanceType.JOINED)
public abstract class Dish {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String name;
    private int yearFounded;


    public abstract String getType();
}