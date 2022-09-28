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
