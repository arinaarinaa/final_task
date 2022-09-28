string [] ArrayCreation()
{
    
    Console.WriteLine("Введите слова или символы через запятую - ");
    char [] separators = new char[] {' ', ',', '-'};
    string [] massive = Array.ConvertAll(Console.ReadLine().Split(separators),Convert.ToString);
    Console.WriteLine();
    Console.WriteLine("Ваш массив - ");
    Console.Write(string.Join("| ", massive));
    Console.WriteLine();
    return massive;
}
string [] massive = ArrayCreation();
string [] newmassive = new string[massive.Length];
void ArrayEditing(string [] massive, string [] newmassive)
{
    int n = 0;
    for(int i = 0; i<massive.Length; i++)
    {
        if(massive[i].Length <=3)
        {
            newmassive[n] = massive[i];
            n++;
        }
    }
}