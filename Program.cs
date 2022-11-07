
/* Tri avec sentinelle :
* dans la cellule de rang 0 se trouve une sentinelle (Int32.MinValue)
* chargée d'éviter de tester dans la boucle tantque .. faire
* si l'indice j n'est pas inférieur à 1, elle aura une valeur
* inférieure à toute valeur possible de la liste.
*/
int[] array1 = new int[] { 20, 151, 265, 25, 14, 55, 49, 485, 125, 693, 2, 58, 47, 44, 958, 753, 159, 258, 22, 35, 3, 5, 7, 9 };

static void AfficherTable(int[] table)
{
   int n = table.Length - 1;
    for (int i = 1; i <= n; i++)
        System.Console.Write(table[i] + " , ");
    System.Console.WriteLine();
}

static int[] TriParInsertion(int[] arr, int arrSize)
{
    int key = 0;

    for (int i = 2; i < arrSize; i++)
    {
        key = arr[i];
        int j = i-1;

        while (j > 0 && arr[j] > key)
        {
            Console.WriteLine("array J + 1  ==> " + arr[j+1]);
            Console.WriteLine("Array J ==> " + arr[j]);
            arr[j + 1] = arr[j];
            j--;
        }
        arr[j + 1] = key;
    }
    return arr;
}

Console.WriteLine("********************************************************************");
Console.WriteLine("");
AfficherTable(array1);
Console.WriteLine("");

Console.WriteLine("********************************************************************");
Console.WriteLine("");
var arrayTrie = TriParInsertion(arr: array1, arrSize: array1.Count());

AfficherTable(arrayTrie);
Console.WriteLine("");
Console.WriteLine("********************************************************************");
