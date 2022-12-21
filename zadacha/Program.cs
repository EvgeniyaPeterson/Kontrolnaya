string[] ArrayString = { "Sup", "1234", "ok",
      "World", "Thirsday", "121", "Saturn" };

string[] ArrayStringNew = new string[ArrayString.Length];
int count=0;

for (int i = 0; i < ArrayString.Length - 1; i++)
{       if (ArrayString[i].Length<=3)
        {
          ArrayString[count] = ArrayString[i];
          count++;
        }
}
Array.Resize(ref ArrayString, count);
Console.WriteLine("Всего "+count+" коротких строки");
for (int i = 0; i < ArrayString.Length; i++)
{
    Console.Write("["+ArrayString[i]+"] ");
}
Console.WriteLine();
