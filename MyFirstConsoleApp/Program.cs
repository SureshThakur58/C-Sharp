// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Hello Suresh, How are you ?");



// data type examples
// int a = 34;
// float b = 43.5F;
// double c = 35.8D;
// bool isGreat = true;
// char d = 'r';
// string name = "Suresh";
// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(isGreat);
// Console.WriteLine(c);
// Console.WriteLine(d);
// Console.WriteLine(name);

// Type casting 

// There are two types of tye casting.
// 1. Implicit casting
// char to int to long to float to double

// int x = 3;
// double y = x;
// int z = 'y';  // return ascii value of y
// Console.WriteLine(x);
// Console.WriteLine(y);
// Console.WriteLine(z);

// 2. Explicit Casting
// using System.ComponentModel;

// int x = (int) 3.5;
// double x1 = (double) 3.4;
// Console.WriteLine(x);
// Console.WriteLine(x1);

// Type casting functions
// Convert.ToString()
// Convert.ToDouble()
// Convert.ToInt32()
// Convert.ToInt64()



// User inputs
// Console.WriteLine("Enter your name: ");
//  String name = Console.ReadLine();
//  Console.WriteLine("Hello! " + name);

//  Console.WriteLine("Enter your age: ");
//  String age = Console.ReadLine();
//  Console.WriteLine("Your age increased with two: " + (Convert.ToInt32(age) + 2));

// Addition of two number

// Console.WriteLine("Enter the first number:");
// String a = Console.ReadLine();
// Console.WriteLine("Enter the second number:");
// String b = Console.ReadLine();
// Console.WriteLine("The sum of two number is " + (Convert.ToInt32(a) +  Convert.ToInt32(b)));

/* Operators in C#
1. Arithmetic operators
int a = 4;
int b = 2;
Console.WriteLine("The value of a+b is:" + (a + b));
Console.WriteLine("The value of a+b is:" + (a - b));
Console.WriteLine("The value of a+b is:" + (a * b));
Console.WriteLine("The value of a+b is:" + (a / b));
2. Assignment Operators
int a = 4;
int b = 2;
b += 4;
Console.WriteLine(b);
3. Logical Operators
Console.WriteLine(true && true);
Console.WriteLine(true && false);
Console.WriteLine(true || true);
Console.WriteLine(true || false);
Console.WriteLine(false || false);
Console.WriteLine(!true);
4. Comparison Operators
Console.WriteLine(33>45);
Console.WriteLine(4>2);
Console.WriteLine(4 >= 4);
Console.WriteLine(4<2);
*/

// int a = Math.Min(35 , 89);
// double a = Math.Sqrt(4);
// int a = Math.Abs(-35);
// Console.WriteLine(a);


/* String function
String hello = "Hello world";
Console.WriteLine(hello.Length);
Console.WriteLine(hello.ToUpper());

String hello = "Hello world";
Console.WriteLine(hello + " I am your Friend");
Console.WriteLine(string.Concat(hello , " I am your Friend"));

String name = Console.ReadLine();
string candies = Console.ReadLine();
Console.WriteLine($"Your name is {name}. You will get {candies} candies.");
  

  String hello = "Hello world";
 Console.WriteLine(hello[0]);
Console.WriteLine(hello.IndexOf("Hello"));
Console.WriteLine(hello.Substring(5));

*/

// if else
// Console.WriteLine("Enter your age:");
// string ageStr = Console.ReadLine();

// int age = Convert.ToInt32(ageStr);
// if(age > 18){
//   Console.WriteLine("You can drive");
// }
// else{
//   Console.WriteLine("You cannot drive");
// }

// switch
// int age = 20;
// switch (age)
// {
//   case 18:
//     Console.WriteLine("Please wair for an year");
//     break;

//   case 20:
//     Console.WriteLine("You are 20!");
//     break;

//   default:
//       Console.WriteLine("Enjoy!");
//       break;
// }

// Loops in C#
// int i = 0;
// while(i < 5){
//   Console.WriteLine(i);
//   i++;
// }

// int i = 0;
// do{
//   Console.WriteLine(i);
//   i++;
// }
// while(i<5);

// for(int i=0; i<5; i++ ){
//   Console.WriteLine(i);
// }

// break means leave the loop forever
// continue means leave particular iteration of the loop

// for(int i=0; i<5; i++ ){
  
//   Console.WriteLine(i);
//   break;
// }

// for(int i=0; i<5; i++ ){
//   if(i == 0){
//     continue;
//   }
//   Console.WriteLine(i);
// }

// A static function belongs to the class and can be called without creating an object.
// using System;

// class Program
// {
    // static void Greet() 
//     {
//         Console.WriteLine("Hello, World!");
//     }

//     static void Main()
//     {
//         Greet(); // Calling the function
//     }
// }


// using System;
// class Program
// {
//     static int Add(int a, int b)
//     {
//         return a + b;
//     }

//     static void Main()
//     {
//         int result = Add(5, 7); // Calling the function with arguments
//         Console.WriteLine("The sum is: " + result);
//     }
// }




// OOP in C#
// A class is a blueprint for creating objects, which are instances of a class.
// using System;

// class Person
// {
//     // Fields
//     private string name;
//     private int age;

//     // Constructor
//     public Person(string name, int age)
//     {
//         this.name = name;
//         this.age = age;
//     }

//     // Method
//     public void DisplayInfo()
//     {
//         Console.WriteLine($"Name: {name}, Age: {age}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Create an object of the class
//         Person person = new Person("Suresh", 24);
//         person.DisplayInfo();
//     }
// }


// Inheritance
// A derived class inherits members of the base class.
// using System;

// class Animal
// {
//     public void Eat()
//     {
//         Console.WriteLine("This animal eats food.");
//     }
// }

// class Dog : Animal
// {
//     public void Bark()
//     {
//         Console.WriteLine("The dog barks.");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         Dog dog = new Dog();
//         dog.Eat(); // Inherited method
//         dog.Bark();
//     }
// }
