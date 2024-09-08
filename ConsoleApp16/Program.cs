using ConsoleApp16;

Console.WriteLine("Please Enter how numbers of list ?");
int count;
try
{
    count = Convert.ToInt32(Console.ReadLine());
}
catch
{
    Console.WriteLine("Please Enter how numbers of list ?(Just Numbers)");
    count = Convert.ToInt32(Console.ReadLine());
}

Person[][] people = new Person[count][];

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Enter how Number of  student of list {i + 1} : ");
    int count1;
    try
    {
        count1 = Convert.ToInt32(Console.ReadLine());
        people[i] = new Person[count1];
    }
    catch
    {
        Console.WriteLine($"Enter how Number of student of list {i + 1} (Just Numbers) : ");
        count1 = Convert.ToInt32(Console.ReadLine());
        people[i] = new Person[count1];
    }
    for (int j = 0; j < count1; j++)
    {
        Console.WriteLine($"please Enter FullName of student {j + 1} of List {i + 1} :");
        string fullName = Console.ReadLine();
        if (string.IsNullOrEmpty(fullName))
        {
            Console.WriteLine($"please Enter FullName of student {j + 1} of List {i + 1} ( Enter just Name ) :");
            fullName = Console.ReadLine();
        }
        Console.WriteLine($"Enter average of student {j + 1} of list {i + 1} : ");
        int average;

        try
        {
            average = Convert.ToInt32(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine($"Enter average of student {j + 1} of list {i + 1} (Just Numbers) : ");
            average = Convert.ToInt32(Console.ReadLine());
        }
        people[i][j] = new(fullName, average);
    }

}

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"List {i + 1} ");
    foreach (var item in people[i])
    {
        Console.WriteLine($"Name = {item.FullName} , Average = {item.Average}");
    }

}

Console.ReadKey();