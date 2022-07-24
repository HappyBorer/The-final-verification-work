Console.Clear();

// Methods.
int Input(string invite)
{
    Console.Write(invite);
    return int.Parse(Console.ReadLine());
}
// My code.
int length = Input("Введите размер массива: ");
string[] arrayOfLines = new string[length];

