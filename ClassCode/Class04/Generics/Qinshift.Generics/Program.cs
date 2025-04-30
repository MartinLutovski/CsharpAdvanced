

using Qinshift.Generics.Helpers;
using Qinshift.Generics.Entities;

NotGenericHelper notGenericHelpers = new();

List<string> names = new List<string>() { "Martin", "Bob", "Spiderman", "Petko" };
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<bool> booleans = new List<bool>() { true, false};
List<Product> products = new List<Product>()
{
    new Product() {Id =1, Name = "Product 1", Decription = "Description 1" },
    new Product() {Id =2, Name = "Product 2", Decription = "Description 2" },

};

List<Order> orders = new List<Order>()
{
    new Order() {Id = 1, Receiver = "Martin", Address = "Street 1"},
    new Order() {Id = 2, Receiver = "Bob", Address = "Street 2"},
    new Order() {Id = 3, Receiver = "Spiderman", Address = "Street 3"},
};

notGenericHelpers.GetInfoForStrings(names);
notGenericHelpers.GoThroughStrings(names);

notGenericHelpers.GetInfoForInts(numbers);
notGenericHelpers.GoTroughInts(numbers);



Console.WriteLine("=============Generic Helper===============");


// If the members of the Generic class are not static then we need to
// create an instance of the class

// GenericListHelper<decimal> stringHelper = new();



GenericListHelper<string>.GetInfoForItems(names);
GenericListHelper<int>.GetInfoForItems(numbers);

GenericListHelper<string>.GoThroughItems(names);
GenericListHelper<int>.GoThroughItems(numbers);

GenericListHelper<bool>.GetInfoForItems(booleans);
GenericListHelper<bool>.GoThroughItems(booleans);

GenericListHelper<Product>.GoThroughItems(products);


Console.WriteLine("=============Generic Db===============");

GenericDb<Product> productsDb = new GenericDb<Product>();
GenericDb<Order> ordersDb = new GenericDb<Order>();

Ge



productsDb.InsertRange(products);
ordersDb.InsertRange(orders);
ordersDb.PrintAll();
productsDb.PrintAll();