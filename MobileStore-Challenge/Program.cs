using MobileStore.models;

internal class Program
{
    private static void Main()
    {
        Iphone myIphone = new Iphone("555", "iphone 1.0v", "123", 128);

        myIphone.InstalarAplicativo("Github");
    }
}