#include <iostream>
#include <string>
using namespace std;

class Dish {
protected:
    string name;
    double priсe;

public:
    Dish(string n, double p) : name(n), priсe(p) {}

     string podat(int f) {
         if (f == 0) {
             return "Подано в глубокой тарелке.";
         }
         else {
             return "Подано с собой.";
         }
     }

     float kalories(float v) {
         return (v/10)*23000;
     }

    virtual string cook() = 0;

    virtual string pack() = 0;

    virtual ~Dish() {} 
};

class hotDish : public Dish {
private:
    int temperature;
    int time_cook;

public:
    hotDish(string n, double p, int t, int v)
        : Dish(n, p), temperature(t), time_cook(v) {
    }
    virtual ~hotDish() {}
    virtual string cook()  {
        return "Подается при температуре " + std::to_string(temperature)+" °C \n"+"В течение "+ std::to_string(time_cook) + " минут. ";
    }

    virtual string pack( )  {
        return "Упаковано в термоупаковку.";
    }

    string reheat(int r) {
        if (r == 0) { return "требуется."; }
        else { return "не требуется."; }
    }

    string add_garn(int g) {
        string garnir;
        if (g == 0) {
            garnir = "сухарики.";
        }
        else { garnir = "шашлык."; }
            return "К " + name + " добавлен гарнир "+garnir;
        
    }
};

class Dessert : public Dish {
private:
    int level_sladost;
    string type_dessert;

public:
    Dessert(string n, double p, int s, string t)
        : Dish(n, p), level_sladost(s), type_dessert(t) {
    }

    virtual string cook()  {
        return  name + " (" + type_dessert + ") готовится с уровнем сладости "+ std::to_string(level_sladost) + "/10.";
    }

    virtual string pack()  {
         return  "Упаковано в коробку с украшением.";
    }

    string add_topping(int t) {
        if (t == 0) { return "Шоколадный"; }
        else { return"Клубничный"; }
    }

    string freeze(int o) {
        if (o == 0) { return "требуется."; }
        else { return "не требуется."; }
    }
    virtual ~Dessert() {}
};

int main() {
    setlocale(LC_ALL, "Russian");
    cout << "Выберите блюдо: \n 1. Суп \n 2. Стейк из говядины" << endl;
    int bludo;
    cin >> bludo;
    Dish* food;
    if (bludo == 1) {
        food = new hotDish("Суп", 300, 80, 15);
        cout << "Блюдо:  Суп" << endl;
    }
    else {
        food = new hotDish("Стейк из говядины", 300, 80, 20);
        cout << "Блюдо:  Стейк из говядины" << endl;
    }
    cout << "Введите массу горячего блюда(г)" << endl;
    int mas;
    cin >> mas;
    cout <<"Калории: " << food->kalories(mas)<< endl;
    cout<< food->cook()<<endl;
    cout << "Введите в чем подать: \n 1. С собой\n 2. В зале" << endl;
    cin >> bludo;
    if (bludo == 1) { cout << food->podat(1) << endl; 
        cout << food->pack() << endl;
    }
    else { cout << food->podat(0) << endl; 
        cout <<  "Упаковки не требует" << endl;
    }
    cout << "Нужен ли разогрев блюда: \n 1. Да\n 2. Нет" << endl;
    cin >> bludo;
    if (bludo == 1) { cout << "Требует разогрев" << endl; }
    else { cout << "Разогрев " << dynamic_cast<hotDish*>(food)->reheat(1) << endl; }

    cout << "Выберите гарнир \n 1. сухарики\n 2. шашлык" << endl;
    cin >> bludo;
    if (bludo == 1) { cout << dynamic_cast<hotDish*>(food)->add_garn(0) << endl; }
    else { cout << dynamic_cast<hotDish*>(food)->add_garn(1) << endl; }

    delete food;

    cout << endl;

    cout << "Выберите десерт: \n 1. Торт \n 2. Мороженное" << endl;
    cin >> bludo;
    if(bludo==1){ 
        food = new Dessert("Торт", 500, 7, "Шоколадный"); 
        cout << "Блюдо: Торт" << endl;
    }
    else { 
        if(bludo==2){food = new Dessert("Торт", 500, 10, "Клубничный");
        cout << "Блюдо: Торт" << endl;
        }
        else {food = new Dessert("Мороженное", 500, 9, "Шоколадное");
        cout << "Блюдо: Мороженное" << endl;
        }
    }
    cout << "Введите массу десерта(г)" << endl;
    cin >> mas;
    cout << "Калории: " << food->kalories(mas) << endl;
    cout<<food->cook()<<endl;
    cout << "Введите в чем подать: \n 1. С собой\n 2. В зале" << endl;
    cin >> bludo;
    if (bludo == 1) {
        cout << food->podat(1) << endl;
        cout << food->pack() << endl;
    }
    else {
        cout << food->podat(0) << endl;
        cout << "Упаковки не требует" << endl;
    }
    cout << "Выберите топпинг: \n 1. Шоколадный \n 2. Клубничный" << endl;
    cin >> bludo;
    if (bludo == 1) { cout << "Добавлен топпинг:" << dynamic_cast<Dessert*>(food)->add_topping(0) << endl;}
    else { cout << "Добавлен топпинг:" << dynamic_cast<Dessert*>(food)->add_topping(1) << endl; }
    cout << "Нужно ли охлаждение блюда: \n 1. Да\n 2. Нет" << endl;
    cin >> bludo;
    if (bludo == 1) { cout << "Требует охлаждение" << endl; }
    else { cout << "Охлаждение " << dynamic_cast<Dessert*>(food)->freeze(0) << endl; }
    delete food;

    return 0;
}
 