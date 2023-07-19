int tam = 0;
int[] items;

Console.WriteLine("Qual o tamanho do array?");
tam = int.Parse(Console.ReadLine() ?? throw new Exception("Valor inválido!"));
items = new int[tam];
for (int i = 0; i < tam; i++)
{
    Console.WriteLine($"Insira o valor N°{i + 1}:");
    items[i] = int.Parse(Console.ReadLine() ?? throw new Exception("Valor inválido!"));
}


items.ToList().ForEach(i => Console.WriteLine(i.ToString()));
BubbleSort(ref items, tam);
items.ToList().ForEach(i => Console.WriteLine(i.ToString()));


static void Swap(ref int a, ref int b)
{
    (a, b) = (b, a);
}

static void BubbleSort(ref int[] arrValue, int tam)
{
    if (tam < 1) return;

    for (int i = 0; i < tam; i++)
    {
        if(tam - 1 < i + 1) break;
        if(arrValue[i] > arrValue[i + 1])
            Swap(ref arrValue[i],ref arrValue[i + 1]);
    }

    BubbleSort(ref arrValue, (tam - 1));
}
