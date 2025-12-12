using System;

class GrandFather
{
    public string Name;
    public string Age;

    public GrandFather(string name, string age)
    {
        Name = name;
        Age = age;
    }

    public GrandFather() : this("บุญ1", "80") { }

    public string InfoFamilyGrandFather()
    {
        return $"ชื่อของปู่ : {Name}, อายุ : {Age}";
    }

    // ───────── Uncle ─────────
    public class Uncle
    {
        public string Name;
        public string Age;

        public Uncle(string name, string age)
        {
            Name = name;
            Age = age;
        }

        public Uncle() : this("บุญ2", "69") { }

        public string InfoFamilyUncle()
        {
            return $"ชื่อลุง : {Name}, อายุ : {Age}";
        }
    }

    // ───────── Father ─────────
    public class Father
    {
        public string Name;
        public string Age;

        public Father(string name, string age)
        {
            Name = name;
            Age = age;
        }

        public Father() : this("บุญ3", "54") { }

        public string InfoFamilyFather()
        {
            return $"ชื่อพ่อ : {Name}, อายุ : {Age}";
        }

        // ───────── Brother ─────────
        public class Brother
        {
            public string Name;
            public string Age;

            public Brother(string name, string age)
            {
                Name = name;
                Age = age;
            }

            public Brother() : this("บุญ4", "30") { }

            public string InfoFamilyBrother()
            {
                return $"ชื่อพี่ : {Name}, อายุ : {Age}";
            }

            // ───────── Niece ─────────
            public class Niece
            {
                public string Name;
                public string Age;

                public Niece(string name, string age)
                {
                    Name = name;
                    Age = age;
                }

                public Niece() : this("บุญ5", "18") { }

                public string InfoFamilyNiece()
                {
                    return $"ชื่อหลาน : {Name}, อายุ : {Age}";
                }
            }
        }
    }

    // ───────── Me ─────────
    public class Me
    {
        public string Name;
        public string Age;

        public Me(string name, string age)
        {
            Name = name;
            Age = age;
        }

        public Me() : this("บุญ6", "20") { }

        public string InfoFamilyMe()
        {
            return $"ชื่อฉัน : {Name}, อายุ : {Age}";
        }

        // ───────── MyDog ─────────
        public class MyDog
        {
            public string Name;
            public string Age;

            public MyDog(string name, string age)
            {
                Name = name;
                Age = age;
            }

            public MyDog() : this("บุญ7", "1") { }

            public string InfoFamilyMyDog()
            {
                return $"ชื่อสุนัข : {Name}, อายุ : {Age}";
            }
        }
    }
}