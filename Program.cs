// See https://aka.ms/new-console-template for more information
Console.WriteLine("Digite a quantide de valores: ");

int NumValores = int.Parse(Console.ReadLine());
double[] Valores = new double[NumValores];

//Console.WriteLine(NumValores);
int i = 0;
double SomaValores = 0;

while(i < NumValores) {
    Console.WriteLine("Digite o valor "+ (i+1) +":");
    Valores[i] = double.Parse(Console.ReadLine());
    
    SomaValores = SomaValores + Valores[i];
    i = i+1;
}

Console.WriteLine("Sua média é:");
Console.WriteLine(SomaValores/NumValores);
