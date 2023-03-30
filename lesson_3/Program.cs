string operand1;
string operand2;


while (true){
    Console.WriteLine("Enter 1st operand");
    operand1 = Console.ReadLine();
    bool op1bool = int.TryParse(operand1, out int op1int);

    if (!op1bool){
        Console.WriteLine("Invalid operand");
        continue;
    } else {break;}
}


while (true){
    Console.WriteLine("Enter 2nd operand");
    operand2 = Console.ReadLine();
    bool op2bool = int.TryParse(operand2, out int op2int);

    if (!op2bool){
        Console.WriteLine("Invalid operand");
        continue;
    } else {break;}
}


int[] op1 = new int[operand1.Length];
int[] op2 = new int[operand2.Length];

for (int a = 0; a < operand1.Length; a++){
    op1[a] = int.Parse(new string(operand1[a], 1));
}

for (int a = 0; a < operand2.Length; a++){
    op2[a] = int.Parse(new string(operand2[a], 1));
}

int[] max_num;
int[] min_num;

if (op1.Length > op2.Length){
    max_num = op1; 
    min_num = op2;
} else {
    max_num = op2; 
    min_num = op1;
}


int[] res = new int[max_num.Length + 1];
int n = 0;


for(int i = 1; i < res.Length; i++){
    if (i > min_num.Length){
    res[^i] = (max_num[^i] + n) % 10;
    n = (max_num[^i] + n) / 10;
    } else {
    res[^i] = (max_num[^i] + min_num[^i] + n) % 10;
    n = (max_num[^i] + min_num[^i] + n) / 10;
    }
 }


Console.WriteLine("");
Console.Write(" ");

foreach (int a in max_num){
    Console.Write(a);
}

Console.WriteLine("");

for (int a = 0; a < (max_num.Length - min_num.Length) + 1; a++){
    Console.Write(" ");
}

foreach (int a in min_num){
    Console.Write(a);
}

Console.WriteLine("");


for (int a = 0; a < max_num.Length + 1; a++){
    Console.Write("-");
}

Console.WriteLine("");

bool num_bef_zero = false;
foreach (int a in res){
    if ((a == 0) && !num_bef_zero){
        Console.Write(" ");
    } else {
    Console.Write(a);
    num_bef_zero = true;
    }
}

Console.WriteLine("   ");