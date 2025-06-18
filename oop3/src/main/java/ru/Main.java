package ru;

import org.hibernate.Session;
import ru.seasids.dao.GenericDAO;
import ru.seasids.dao.InstitutionDAO;
import ru.seasids.Hot;
import ru.seasids.Dessert;
import ru.seasids.Faculty;

import java.util.Scanner;

public class Main {
    private static final Scanner scanner = new Scanner(System.in);
    private static final InstitutionDAO dao = new InstitutionDAO();

    public static void main(String[] args) {
        try {
            boolean running = true;
            while (running) {
                printMenu();
                int choice = scanner.nextInt();
                scanner.nextLine(); // Очистка буфера

                switch (choice) {
                    case 1 -> addNewDessert();
                    case 2 -> updateDessert();
                    case 3 -> deleteDessert();
                    case 4 -> additionalActions();
                    case 5 -> running = false;
                    default -> System.out.println("Неверный выбор");
                }
            }
        } finally {
            GenericDAO.shutdown();
        }
    }

    private static void printMenu() {
        System.out.println("\n Управление блюдами ");
        System.out.println("1. Добавить новое блюдо");
        System.out.println("2. Изменить существующее");
        System.out.println("3. Удалить блюдо");
        System.out.println("4. Дополнительные действия");
        System.out.println("5. Выход");
        System.out.print("Выберите действие: ");
    }

    private static void addNewDessert() {
        System.out.println("\nВыберите тип:");
        System.out.println("1. Горячее блюдо");
        System.out.println("2. Дессерт");
        int type = scanner.nextInt();
        scanner.nextLine();

        System.out.print("Введите название: ");
        String name = scanner.nextLine();

        System.out.print("Введите цену: ");
        int year = scanner.nextInt();
        scanner.nextLine();

        if (type == 1) {
            Hot hot = new Hot();
            hot.setName(name);
            hot.setYearFounded(year);

            // Ввод предметов
            System.out.println("Введите гарнир (для завершения введите 'end'):");
            while (true) {
                System.out.print("Гарнир: ");
                String subject = scanner.nextLine();
                if (subject.equalsIgnoreCase("end")) {
                    break;
                }
                hot.getSubjects().add(subject);
            }

            System.out.print("Введите количество блюда в гр.: ");
            int classes = scanner.nextInt();
            scanner.nextLine();
            hot.setWeight(classes);

            dao.save(hot);
            System.out.println("Горячее блюдо успешно добавлено! ID: " + hot.getId());
        } else {
            Dessert dessert = new Dessert();
            dessert.setName(name);
            dessert.setYearFounded(year);

            System.out.println("Введите тип и топпинг дессерта (для завершения введите 'end'):");
            while (true) {
                System.out.print("Топпинг: ");
                String facultyName = scanner.nextLine();
                if (facultyName.equalsIgnoreCase("end")) {
                    break;
                }
                System.out.print("t подачи: ");
                String deanName = scanner.nextLine();
                dessert.addFaculty(facultyName, deanName);
            }

            dao.save(dessert);
            System.out.println("Дессерт успешно добавлен! ID: " + dessert.getId());
        }
    }

    private static void updateDessert() {
        System.out.println("\nВыберите тип для изменения:");
        System.out.println("1. Горячее блюдо");
        System.out.println("2. Дессерт");
        int type = scanner.nextInt();
        scanner.nextLine();

        System.out.print("Введите ID блюда: ");
        Long id = scanner.nextLong();
        scanner.nextLine();

        try (Session session = GenericDAO.getSessionFactory().openSession()) {
            if (type == 1) {
                Hot hot = session.get(Hot.class, id);
                if (hot != null) {
                    updatehot(hot, session);
                } else {
                    System.out.println("Блюдо с ID " + id + " не найдено");
                }
            } else {
                Dessert dessert = session.get(Dessert.class, id);
                if (dessert != null) {
                    updatedesert(dessert, session);
                } else {
                    System.out.println("Дессерт с ID " + id + " не найден");
                }
            }
        }
    }

    private static void updatehot(Hot hot, Session session) {
        System.out.println("\nТекущие данные:");
        System.out.println("Название: " + hot.getName());
        System.out.println("Цена: " + hot.getYearFounded());
        System.out.println("Гараниры: " + String.join(", ", hot.getSubjects()));
        System.out.println("Вес в гр.: " + hot.getWeight());

        System.out.print("\nНовое название (Enter - оставить прежнее): ");
        String name = scanner.nextLine();
        if (!name.isEmpty()) hot.setName(name);

        System.out.print("Новая цена (0 - оставить прежней): ");
        int year = scanner.nextInt();
        scanner.nextLine();
        if (year != 0) hot.setYearFounded(year);

        // Обновление предметов
        System.out.println("Текущие гарниры: " + String.join(", ", hot.getSubjects()));
        System.out.println("1. Добавить гарнир");
        System.out.println("2. Удалить гарнир");
        System.out.println("3. Пропустить");
        System.out.print("Выберите действие: ");
        int subjectAction = scanner.nextInt();
        scanner.nextLine();

        switch (subjectAction) {
            case 1:
                System.out.print("Введите новый гарнир: ");
                String newSubject = scanner.nextLine();
                hot.getSubjects().add(newSubject);
                break;
            case 2:
                System.out.print("Введите гарнир для удаления: ");
                String subjectToRemove = scanner.nextLine();
                hot.getSubjects().remove(subjectToRemove);
                break;
        }

        System.out.print("Новый вес (0 - оставить прежнее): ");
        int classes = scanner.nextInt();
        scanner.nextLine();
        if (classes != 0) hot.setWeight(classes);

        session.beginTransaction();
        session.update(hot);
        session.getTransaction().commit();
        System.out.println("Данные горячего блюда обновлены!");
    }

    private static void updatedesert(Dessert dessert, Session session) {
        System.out.println("\nТекущие данные:");
        System.out.println("Название: " + dessert.getName());
        System.out.println("Цена: " + dessert.getYearFounded());
        System.out.println("Топпинг:");
        for (Faculty faculty : dessert.getFaculties()) {
            System.out.printf("- %s (t подачи: %s)%n", faculty.getName(), faculty.getDeanName());
        }

        System.out.print("\nНовое название (Enter - оставить прежнее): ");
        String name = scanner.nextLine();
        if (!name.isEmpty()) dessert.setName(name);

        System.out.print("Новая цена (0 - оставить прежний): ");
        int year = scanner.nextInt();
        scanner.nextLine();
        if (year != 0) dessert.setYearFounded(year);

        // Обновление факультетов
        System.out.println("\nУправление Десертами:");
        System.out.println("1. Добавить топпинг");
        System.out.println("2. Удалить топпинг");
        System.out.println("3. Изменить t");
        System.out.println("4. Пропустить");
        System.out.print("Выберите действие: ");
        int facultyAction = scanner.nextInt();
        scanner.nextLine();

        switch (facultyAction) {
            case 1:
                System.out.print("Название нового топпинга: ");
                String newFaculty = scanner.nextLine();
                System.out.print("t подачи: ");
                String newDean = scanner.nextLine();
                dessert.addFaculty(newFaculty, newDean);
                break;
            case 2:
                System.out.print("Введите название топпнига для удаления: ");
                String facultyToRemove = scanner.nextLine();
                dessert.getFaculties().removeIf(f -> f.getName().equals(facultyToRemove));
                break;
            case 3:
                System.out.print("Введите название топпинга: ");
                String facultyName = scanner.nextLine();
                System.out.print("Новая t подачи: ");
                String deanName = scanner.nextLine();
                dessert.getFaculties().stream()
                        .filter(f -> f.getName().equals(facultyName))
                        .findFirst()
                        .ifPresent(f -> f.setDeanName(deanName));
                break;
        }

        session.beginTransaction();
        session.update(dessert);
        session.getTransaction().commit();
        System.out.println("Данные Дессерта обновлены!");
    }

    private static void deleteDessert() {
        System.out.println("\nВыберите тип для удаления:");
        System.out.println("1. Блюдо");
        System.out.println("2. Дессерт");
        int type = scanner.nextInt();
        scanner.nextLine();

        System.out.print("Введите ID блюда: ");
        Long id = scanner.nextLong();
        scanner.nextLine();

        try (Session session = GenericDAO.getSessionFactory().openSession()) {
            if (type == 1) {
                Hot hot = session.get(Hot.class, id);
                if (hot != null) {
                    session.beginTransaction();
                    session.delete(hot);
                    session.getTransaction().commit();
                    System.out.println("Блюдо успешно удалено!");
                } else {
                    System.out.println("Горячее блюдо с ID " + id + " не найдено");
                }
            } else {
                Dessert dessert = session.get(Dessert.class, id);
                if (dessert != null) {
                    session.beginTransaction();
                    session.delete(dessert); //
                    session.getTransaction().commit();
                    System.out.println("Дессерт успешно удален!");
                } else {
                    System.out.println("Дессерт с ID " + id + " не найден");
                }
            }
        }
    }



    private static void additionalActions() {
        System.out.println("\nВыберите тип заведения:");
        System.out.println("1. Горячее блюдо");
        System.out.println("2. Дессерт");
        int type = scanner.nextInt();
        scanner.nextLine();

        System.out.print("Введите ID блюда: ");
        Long id = scanner.nextLong();
        scanner.nextLine();

        try (Session session = GenericDAO.getSessionFactory().openSession()) {
            if (type == 1) {
                Hot hot = session.get(Hot.class, id);
                if (hot != null) {
                    hotActions(hot);
                } else {
                    System.out.println("Горячее блюдо с ID " + id + " не найдена");
                }
            } else {
                Dessert dessert = session.get(Dessert.class, id);
                if (dessert != null) {
                    dessertActions(dessert);
                } else {
                    System.out.println("Дессерт с ID " + id + " не найден");
                }
            }
        }
    }

    private static void hotActions(Hot hot) {
        System.out.println("\n=== Дополнительные действия для горячего блюда ===");
        System.out.println("1. Показать гарниры");
        System.out.println("2. Показать информацию (кратко)");
        System.out.println("3. Показать информацию (подробно)");
        System.out.print("Выберите действие: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                hot.printSchedule();
                break;
            case 2:
                hot.printInfo(false);
                break;
            case 3:
                hot.printInfo(true);
                break;
            default:
                System.out.println("Неверный выбор");
        }
    }

    private static void dessertActions(Dessert dessert) {
        System.out.println("\n=== Дополнительные действия для дессерта ===");
        System.out.println("1. Охладить");
        System.out.println("2. Показать информацию (кратко)");
        System.out.println("3. Показать информацию (подробно)");
        System.out.print("Выберите действие: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        switch (choice) {
            case 1:
                dessert.conductConference();
                break;
            case 2:
                dessert.printInfo(false);
                break;
            case 3:
                System.out.println("\n" + dessert.toString());
                break;
            default:
                System.out.println("Неверный выбор");
        }
    }
}