Console.WriteLine("Enter 1st operand");
string op1str = Console.ReadLine();
bool op1bool = float.TryParse(op1str, out float operand1);

if (!op1bool){
    Console.WriteLine("Invalid operand");
}


Console.WriteLine("Enter 2nd operand");
string op2str = Console.ReadLine();
bool op2bool = float.TryParse(op2str, out float operand2);

if (!op2bool){
    Console.WriteLine("Invalid operand");
}



Console.WriteLine("Enter operation");
string operation = Console.ReadLine();
if (operation == "+"){
    Console.WriteLine($"{operand1} + {operand2} = " + (operand1 + operand2));
} else if (operation == "-"){
    Console.WriteLine($"{operand1} - {operand2} = " + (operand1 - operand2));
} else if (operation == "*"){
    Console.WriteLine($"{operand1} * {operand2} = " + (operand1 * operand2));
} else if (operation == "/" && operand2 != 0){
    Console.WriteLine(operand1 / operand2);
} else {
    Console.WriteLine("Invalid operation");
}