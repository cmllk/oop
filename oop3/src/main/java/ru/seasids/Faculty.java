package ru.seasids;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.persistence.Embeddable;
import java.io.Serializable;

@Data
@NoArgsConstructor
@AllArgsConstructor
@Embeddable
public class Faculty implements Serializable {
//   @Column(name = "temperature")
    private String name;
    private String deanName;
}
