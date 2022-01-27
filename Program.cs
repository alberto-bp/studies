
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Workers!");

// BINARY SEARCH
// ArrayAlgos.BinarySearch(int.Parse(args[0]));

int[] unsortedArray = new int[] { 5, 3, 1, 13, 7, 11, 9 };
// int[] sortedArray = new int[] { 1, 3, 5, 7, 9, 11, 13 };
// SELECTION SORT
// ArrayAlgos.SelectionSort(unsortedArray);

// INSERTION SORT
// ArrayAlgos.InsertionSort(sortedArray);

// BUBBLE SORT
// ArrayAlgos.BubbleSort(sortedArray);

// MERGE SORT
// ArrayAlgos.MergeSort(unsortedArray);

// FIBONACCI
// Console.WriteLine(ArrayAlgos.Fibonacci(5));

// Factory
// VehicleFactory factory = new CarFactory();
// var vehicle = factory.GetVehicle();
// vehicle.Drive();
// Console.WriteLine(factory.MilesPerHour());

// Abstract Factory
// ITechFactory factory = new GamingTechFactory();
// var computer = factory.CreateComputer();
// var mouse = factory.CreateMouse();
// computer.DoWork();
// mouse.Click();

// Builder
// var builder = new MansionBuilder();
// var director = new Director(builder);
// director.BuildMansion();
// var mansion = builder.GetResult();

// Decorator
// Clothes outfit = new Shirt();
// outfit = new SweaterDecorator(outfit);
// outfit = new JacketDecorator(outfit);
// outfit.Wear();

// Observer
// var publisher = new StorePublisher();

// var carlos = new StoreSubscriber();
// var alberto = new StoreSubscriber();

// publisher.Subscribe(carlos);
// publisher.Subscribe(alberto);

// var store = new Store(publisher);
// store.ReceiveiPhones(20);

// publisher.Unsubscribe(alberto);
// store.SelliPhones(20);

// LINKED LIST
var linkedList = new LinkedList();
var first = new Node(1);
var second = new Node(2);
var third = new Node(3);

linkedList.Head = first;
linkedList.Head.Next = second;
second.Next = third;

var fourth = new Node(4);
// linkedList.AddToEnd(fourth);
// linkedList.AddToStart(fourth);
linkedList.AddToPosition(fourth, 1);

linkedList.Print();
Console.WriteLine("Before delete");
linkedList.DeleteAt(4);

linkedList.Print();
// Console.WriteLine($"Length: {linkedList.Length();}");