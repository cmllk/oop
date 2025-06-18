package ru.seasids.dao;

import org.hibernate.Session;
import org.hibernate.Transaction;
import ru.seasids.Dish;

public class InstitutionDAO extends GenericDAO {
    public void save(Dish institution) {
        try (Session session = getSession()) {
            Transaction tx = session.beginTransaction();
            session.save(institution);
            tx.commit();
            System.out.println("Saved with ID: " + institution.getId());
        }
    }

    public void delete(Dish institution) {
        try (Session session = getSession()) {
            Transaction tx = session.beginTransaction();

            institution = (Dish) session.merge(institution);
            session.delete(institution);

            tx.commit();
            System.out.println("Deleted institution with ID: " + institution.getId());
        }
    }
}