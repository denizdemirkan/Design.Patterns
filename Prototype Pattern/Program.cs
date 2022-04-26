using Prototype_Pattern;

House house1 = new House();
Customer customer1 = new Customer()
{
    Address = "Edirne",
    Name = "Deniz",
    HouseHold = house1,
    ID = 1
};
customer1.HouseHold.ID = 1;

Customer customer2 = (Customer)customer1.Clone();
customer2.Name = "Gülsüm";

Console.WriteLine(customer1.Name);
Console.WriteLine(customer2.Name);

Console.WriteLine("*****");

Console.WriteLine(customer1.HouseHold.ID);
Console.WriteLine(customer1.HouseHold.ID);

// NOT! Sorun, dependency olan referans tip veriler ortaklaşa kullanılır. O nedenle Shallow Clone yani Sığı Klonlama
// olarak adlandırılır