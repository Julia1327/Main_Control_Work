


string[] strings = {"Hello", "2", "world", ":-)"};
string[] strings_1 = new string[strings.Length];
int outputIndex = 0;

for (int i = 0; i < strings.Length; i++)
{
    if (strings[i].Length <= 3)
    {
        strings_1[outputIndex++] = strings[i];
    }
}

for (int i = 0; i < outputIndex; i++)
{
    Console.WriteLine(strings_1[i]);
}