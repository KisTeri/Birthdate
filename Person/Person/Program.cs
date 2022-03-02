using Person1;
var Roman = new Person();
{
    var date = new DateTime(1998, 08, 11);
    Console.WriteLine("Roman - " + Roman.GetAge(date));
}
var Ekaterina = new Person();
{
    var date_1 = new DateTime(2004, 01, 14);
    Console.WriteLine("Ekaterina - " + Ekaterina.GetAge(date_1));
}