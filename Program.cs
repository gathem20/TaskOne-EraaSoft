




// // int[] nums = [10 , 20, 30];
// // System.Console.WriteLine(nums[0]);
// // System.Console.WriteLine(nums[1]);
// // System.Console.WriteLine(nums[2]);
// // nums[0] = 45;
// // System.Console.WriteLine(nums[0] );

// // List is dynamic array
// List<int> hello =new List<int>();

// hello.Add(50);
// hello.Add(10);
// hello.Add(90);
// hello.Add(560);
// hello.Add(560);
// hello.Add(560);
// hello.Add(560);
// hello.Add(560);
// hello.Add(560);

// System.Console.WriteLine(hello.Count);
// System.Console.WriteLine(hello.Capacity);
// hello.TrimExcess();
// System.Console.WriteLine(hello.Count);
// System.Console.WriteLine(hello.Capacity);
// hello.Add(560);
// System.Console.WriteLine(hello.Count);

// System.Console.WriteLine(hello.Capacity);
// ///////////////////////////////////////////

System.Console.WriteLine("Welcome To Umbrella Carpet Cleaning");
System.Console.WriteLine("------------------");
int PriceSmall = 25;
System.Console.WriteLine($"Price Per Small ${PriceSmall}");
System.Console.WriteLine("------------------");
int PriceLarge = 35;
System.Console.WriteLine($"Price Per Large ${PriceLarge}");
double Tax= 6.0;
int valid = 30;
System.Console.WriteLine("-------------------");

System.Console.WriteLine("Enter Your Carpet Small");
int SmallCarpet = Convert.ToInt32(Console.ReadLine());
double TaxSmall = Tax * PriceSmall * SmallCarpet / 100 ; 
int TotalSmall = PriceSmall * SmallCarpet ;
Console.WriteLine($"Number Of Small Carpet {SmallCarpet}");

System.Console.WriteLine("------------------");

System.Console.WriteLine("Enter Your Carpet Large");
int LargeCarpet = Convert.ToInt32(Console.ReadLine());
int TotalLarge = PriceLarge * LargeCarpet ;
double TaxLarge = Tax * PriceLarge * LargeCarpet / 100 ; 
double TotalTax = TaxLarge + TaxSmall ;

int TotalOfCarpet = TotalLarge + TotalSmall;
double TotalCost = TotalLarge + TotalSmall + TotalTax;


Console.WriteLine($"Number Of Large Carpet {LargeCarpet}");


System.Console.WriteLine($"Total Cost Of Carpet ${TotalOfCarpet}");
System.Console.WriteLine($"Total Tax ${TotalTax}");
System.Console.WriteLine($"Total estimate ${TotalCost}");


System.Console.WriteLine($"Total Cost For Your Carpet is ${TotalOfCarpet} And Tax ${TotalTax} Soo Total Price is ${TotalCost}");
System.Console.WriteLine($"this estimate is Valid for {valid} days");

