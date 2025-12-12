class GrandFather:
    def __init__(self, name="Unknown", age="Unknown"):
        self.name = name
        self.age = age

    def infoFamilyGrandFather(self):
        print(f"GrandFather [{self.name}, {self.age} Year]")

    class Uncle:
        def __init__(self, name="Unknown", age="Unknown"):
            self.name = name
            self.age = age

        def infoFamilyUncle(self):
            print(f"Uncle [{self.name}, {self.age} Year]")

    class Father:
        def __init__(self, name="Unknown", age="Unknown"):
            self.name = name
            self.age = age

        def infoFamilyFather(self):
            print(f"Father [{self.name}, {self.age} Year]")

        class Brother:
            def __init__(self, name="Unknown", age="Unknown"):
                self.name = name
                self.age = age

            def infoFamilyBrother(self):
                print(f"Brother [{self.name}, {self.age} Year]")

            class Niece:
                def __init__(self, name="Unknown", age="Unknown"):
                    self.name = name
                    self.age = age

                def infoFamilyNiece(self):
                    print(f"Niece [{self.name}, {self.age} Year]")

    class Me:
        def __init__(self, name="Unknown", age="Unknown"):
            self.name = name
            self.age = age

        def infoFamilyMe(self):
            print(f"Me [{self.name}, {self.age} Year]")

        class MyDog:
            def __init__(self, name="Unknown", age="Unknown"):
                self.name = name
                self.age = age

            def infoFamilyMyDog(self):
                print(f"MyDog [{self.name}, {self.age} Year]")
    

# GrandFather
gf = GrandFather()
gf2 = GrandFather("บุญชู", "79")
gf.infoFamilyGrandFather()
gf2.infoFamilyGrandFather()

# Uncle
uc = GrandFather.Uncle()
uc2 = GrandFather.Uncle("บุญศรี", "55")
uc.infoFamilyUncle()
uc2.infoFamilyUncle()

# Father
f = GrandFather.Father()
f2 = GrandFather.Father("บุญส่ง", "48")
f.infoFamilyFather()
f2.infoFamilyFather()

# Brother
b = GrandFather.Father.Brother()
b2 = GrandFather.Father.Brother("บุญเพิ่ม", "35")
b.infoFamilyBrother()
b2.infoFamilyBrother()

# Niece
n = GrandFather.Father.Brother.Niece()
n2 = GrandFather.Father.Brother.Niece("บุญเสริม", "9")
n.infoFamilyNiece()
n2.infoFamilyNiece()

# Me
m = GrandFather.Me()
m2 = GrandFather.Me("บุญใหญ่", "26")
m.infoFamilyMe()
m2.infoFamilyMe()

# MyDog
d = GrandFather.Me.MyDog()
d2 = GrandFather.Me.MyDog("บุญทิ้ง", "1.5")
d.infoFamilyMyDog()
d2.infoFamilyMyDog()