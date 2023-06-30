using FirstTask;

Finder finder = new Finder();
int[] numbers = new int[] { 2, 2, 5 };
int target = 4;
int[] reasult = finder.FindIndices(numbers, target);
if(reasult.Length == 2)
    Console.WriteLine($"sum of numbers in index {reasult[0]} and {reasult[1]} equals to {target}");
else 
    Console.WriteLine("There is no Answer");