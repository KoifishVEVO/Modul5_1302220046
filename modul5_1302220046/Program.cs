// See https://aka.ms/new-console-template for more information
using System.Numerics;


    class Penjumlahan
{
    public static T JumlahTigaAngka<T>(T x, T y, T z) where T : IAdditionOperators<T, T, T>
    {

        return x + y + z;



    }

    static void Main(string[] args)
    {
        Console.WriteLine(JumlahTigaAngka<int>(13, 2, 22));
        SimpleDataBase<string> data = new SimpleDataBase<string>();

        data.AddNewData("12");
        data.AddNewData("34");
        data.AddNewData("56");
        data.PrintAllData();
    }
}


class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }
    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }
    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data "+(i+1)+" berisi "+storedData[i] +" yang disimpan pada waktu UTC: "+ inputDates[i]);
        }
    }
}