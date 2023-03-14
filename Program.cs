/*Faça um programa para ler um arquivo contendo nomes de pessoas (um nome por
linha), armazenando-os em uma lista. Depois, ordenar os dados dessa lista e mostra-los
ordenadamente na tela. Nota: o caminho do arquivo pode ser informado "hardcode".*/

string patch = @"C:\Users\198802\Desktop\COISAS\Learn\Learn\Exercicio_POO_21_IComparable\list.txt";
try
{
    using (StreamReader stream = File.OpenText(patch))
    {
        List<string> list = new List<string>();
        while (!stream.EndOfStream)
        {
            list.Add(stream.ReadLine());
        }
        list.Sort();
        foreach (string line in list)
        {
            Console.WriteLine(line);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("Error");
    Console.WriteLine(e.Message);
}