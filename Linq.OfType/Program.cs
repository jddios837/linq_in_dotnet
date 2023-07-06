// See https://aka.ms/new-console-template for more information

List<object> dataSource = new List<object>()
{
    "Tom", "Mary", 50, "Prince", "Jack", 10, 20, 30, 40, "James"
};

List<int> intData = dataSource.OfType<int>().ToList();

foreach (int number in intData)
{
    Console.WriteLine(number + " ");
}

Console.WriteLine("\n Numbers Greater Than 30 \n");

List<int> intDataFilter = dataSource.OfType<int>().Where(n => n > 30).ToList();
foreach (int i in intDataFilter)
{
    Console.WriteLine(i + " ");
}

Console.WriteLine("\n String Data \n");

List<string> stringData = dataSource.OfType<string>().ToList();

foreach (string st in stringData)
{
    Console.WriteLine(st + " ");
}