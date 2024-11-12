object ds = null;

try
{
    Console.WriteLine("Введите номер месяца (1-12):");
    int month = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите число:");
    int day = int.Parse(Console.ReadLine());

    DateTime previousDate = ds.GetPreviousDate(month, day);
    Console.WriteLine($"Предыдущая дата: {previousDate.ToShortDateString()}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
    DataService ds = new();
}
        
