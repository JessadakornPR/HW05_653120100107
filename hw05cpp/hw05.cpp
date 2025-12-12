#include <iostream>
using namespace std;

class GrandFather {
public:
    string name;
    string age;

    GrandFather(string n, string a) : name(n), age(a) {}
    GrandFather() : GrandFather("บุญ1", "80") {}

    string infoFamilyGrandFather() {
        return "ชื่อของปู่ : " + name + ", อายุ : " + age;
    }

    class Uncle {
    public:
        string name;
        string age;

        Uncle(string n, string a) : name(n), age(a) {}
        Uncle() : Uncle("บุญ2", "69") {}

        string infoFamilyUncle() {
            return "ชื่อลุง : " + name + ", อายุ : " + age;
        }
    };

    class Father {
    public:
        string name;
        string age;

        Father(string n, string a) : name(n), age(a) {}
        Father() : Father("บุญ3", "54") {}

        string infoFamilyFather() {
            return "ชื่อพ่อ : " + name + ", อายุ : " + age;
        }

        class Brother {
        public:
            string name;
            string age;

            Brother(string n, string a) : name(n), age(a) {}
            Brother() : Brother("บุญ4", "30") {}

            string infoFamilyBrother() {
                return "ชื่อพี่ : " + name + ", อายุ : " + age;
            }

            class Niece {
            public:
                string name;
                string age;

                Niece(string n, string a) : name(n), age(a) {}
                Niece() : Niece("บุญ5", "18") {}

                string infoFamilyNiece() {
                    return "ชื่อหลาน : " + name + ", อายุ : " + age;
                }
            };
        };
    };

    class Me {
    public:
        string name;
        string age;

        Me(string n, string a) : name(n), age(a) {}
        Me() : Me("บุญ6", "20") {}

        string infoFamilyMe() {
            return "ชื่อฉัน : " + name + ", อายุ : " + age;
        }

        class MyDog {
        public:
            string name;
            string age;

            MyDog(string n, string a) : name(n), age(a) {}
            MyDog() : MyDog("บุญ7", "1") {}

            string infoFamilyMyDog() {
                return "ชื่อสุนัข : " + name + ", อายุ : " + age;
            }
        };
    };
};

int main() {
    GrandFather gf;
    GrandFather gf2("บุญพา", "76");

    GrandFather::Uncle uncle;
    GrandFather::Uncle uncle2("บุญชู", "68");

    GrandFather::Father father;
    GrandFather::Father father2("บุญโชค", "56");

    GrandFather::Father::Brother brother;
    GrandFather::Father::Brother brother2("บุญใหญ่", "32");

    GrandFather::Father::Brother::Niece niece;
    GrandFather::Father::Brother::Niece niece2("บุญส่ง", "15");

    GrandFather::Me me;
    GrandFather::Me me2("บุญเพิ่ม", "23");

    GrandFather::Me::MyDog myDog;
    GrandFather::Me::MyDog myDog2("บุญทิ้ง", "3");

    cout << gf.infoFamilyGrandFather() << endl;
    cout << gf2.infoFamilyGrandFather() << endl;

    cout << uncle.infoFamilyUncle() << endl;
    cout << uncle2.infoFamilyUncle() << endl;

    cout << father.infoFamilyFather() << endl;
    cout << father2.infoFamilyFather() << endl;

    cout << brother.infoFamilyBrother() << endl;
    cout << brother2.infoFamilyBrother() << endl;

    cout << niece.infoFamilyNiece() << endl;
    cout << niece2.infoFamilyNiece() << endl;

    cout << me.infoFamilyMe() << endl;
    cout << me2.infoFamilyMe() << endl;

    cout << myDog.infoFamilyMyDog() << endl;
    cout << myDog2.infoFamilyMyDog() << endl;

    return 0;
}