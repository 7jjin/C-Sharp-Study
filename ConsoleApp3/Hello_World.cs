class Hello_World
{
    static void Main()
    {
        //PrintHello("Hello World");
        //PrintHello("안녕하세요 여러분");
        AA var = new AA();
        var.PrintHello("Hello World");

    }
}

class AA
{
    public void PrintHello (string str)
    {
        Console.WriteLine(str);
    }
}
