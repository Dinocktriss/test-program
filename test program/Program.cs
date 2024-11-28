using System;
using InspectorLib;

class Program
{
    static void Main(string[] args)
    {
        FunctionInsp insp = new FunctionInsp();

        // Тесты методов
        Console.WriteLine(insp.GetInspector()); // Васильев Василий Иванович
        Console.WriteLine(insp.GetCarInspection()); // Автоинспекция г. Чита

        Console.WriteLine(insp.SetInspector("Иванов И.И.")); // True
        Console.WriteLine(insp.GetInspector()); // Иванов И.И.

        Console.WriteLine(insp.GenerateNumber(1234, 'A', 75)); // A1234_75

        var workers = insp.GetWorker();
        workers.ForEach(worker => Console.WriteLine(worker));

        insp.AddWorker("Сидоров С.С.");
        workers = insp.GetWorker();
        workers.ForEach(worker => Console.WriteLine(worker));
    }
}
