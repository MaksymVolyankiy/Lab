List<int> listint = new List<int> { -3, -6, 7, 12, -2 };
int i = 0, j = listint.Count - 1;
while (i < j)
{
    while (i < j && listint[i] > 0) i++;
    while (i < j && listint[j] < 0) j--;
    if (i < j)
    {
        int temp = listint[i];
        listint[i] = listint[j];
        listint[j] = temp;
        i++;
        j--;
    }
}
foreach (int item in listint)
{
    Console.Write(item + " ");
}