// See https://aka.ms/new-console-template for more information
using Linq.Core;

List<int> intList = Numbers.GetNumbers();

// Method Syntax
IEnumerable<int> filteredData = intList.Where(num => num > 0);

foreach (var number in filteredData)
{
    Console.WriteLine(number);
}

var OddNumbersWithIndexPosition = intList
    .Select((num, index) => new { Numbers = num, IndexPosition = index})
    .Where(x => x.Numbers % 2 != 0)
    .Select(data => new { Number = data.Numbers, IndexPosition = data.IndexPosition });

foreach (var item in OddNumbersWithIndexPosition)
{
    Console.WriteLine($"IndexPosition : {item.IndexPosition} , Value: {item.Number}");
}    