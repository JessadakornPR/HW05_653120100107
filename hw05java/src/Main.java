public class Main {
    public static void main(String[] args) {

        GrandFather gf = new GrandFather();
        GrandFather gf2 = new GrandFather("บุญพา", "76");

        GrandFather.Uncle uncle = new GrandFather.Uncle();
        GrandFather.Uncle uncle2 = new GrandFather.Uncle("บุญชู", "68");

        GrandFather.Father father = new GrandFather.Father();
        GrandFather.Father father2 = new GrandFather.Father("บุญโชค", "56");

        GrandFather.Father.Brother brother = new GrandFather.Father.Brother();
        GrandFather.Father.Brother brother2 = new GrandFather.Father.Brother("บุญใหญ่", "32");

        GrandFather.Father.Brother.Niece niece = new GrandFather.Father.Brother.Niece();
        GrandFather.Father.Brother.Niece niece2 = new GrandFather.Father.Brother.Niece("บุญส่ง", "15");

        GrandFather.Me me = new GrandFather.Me();
        GrandFather.Me me2 = new GrandFather.Me("บุญเพิ่ม", "23");

        GrandFather.Me.MyDog dog = new GrandFather.Me.MyDog();
        GrandFather.Me.MyDog dog2 = new GrandFather.Me.MyDog("บุญทิ้ง", "3");

        System.out.println(gf.infoFamilyGrandFather());
        System.out.println(gf2.infoFamilyGrandFather());

        System.out.println(uncle.infoFamilyUncle());
        System.out.println(uncle2.infoFamilyUncle());

        System.out.println(father.infoFamilyFather());
        System.out.println(father2.infoFamilyFather());

        System.out.println(brother.infoFamilyBrother());
        System.out.println(brother2.infoFamilyBrother());

        System.out.println(niece.infoFamilyNiece());
        System.out.println(niece2.infoFamilyNiece());

        System.out.println(me.infoFamilyMe());
        System.out.println(me2.infoFamilyMe());

        System.out.println(dog.infoFamilyMyDog());
        System.out.println(dog2.infoFamilyMyDog());
    }
}