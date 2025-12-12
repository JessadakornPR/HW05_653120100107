class Program
{
    static void Main(string[] args)
    {
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

        Console.WriteLine(gf.InfoFamilyGrandFather());
        Console.WriteLine(gf2.InfoFamilyGrandFather());

        Console.WriteLine(uncle.InfoFamilyUncle());
        Console.WriteLine(uncle2.InfoFamilyUncle());

        Console.WriteLine(father.InfoFamilyFather());
        Console.WriteLine(father2.InfoFamilyFather());

        Console.WriteLine(brother.InfoFamilyBrother());
        Console.WriteLine(brother2.InfoFamilyBrother());

        Console.WriteLine(niece.InfoFamilyNiece());
        Console.WriteLine(niece2.InfoFamilyNiece());

        Console.WriteLine(me.InfoFamilyMe());
        Console.WriteLine(me2.InfoFamilyMe());

        Console.WriteLine(dog.InfoFamilyMyDog());
        Console.WriteLine(dog2.InfoFamilyMyDog());
    }
}