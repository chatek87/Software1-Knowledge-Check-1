using KnowledgeCheck1_Calculator;

Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

var input = Console.ReadLine();
var calculator = new Calculator();

switch (input)
{
    case "1":
        calculator.Add();
        break;

    case "2":
        calculator.Subtract();
        break;

    case "3":
        // Add code here
        calculator.Multiply();
        break;

    case "4":
        calculator.Divide();
        break;
       
    default:
        Console.WriteLine("Unknown input");
        break;
}
