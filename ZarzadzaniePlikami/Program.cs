Console.Write("Podaj ścieżkę do pliku: ");
string path = @Console.ReadLine();
Console.WriteLine(path);

if (File.Exists(path))
{
    StreamReader streamReader = new StreamReader(path);
    string data = streamReader.ReadToEnd();
    streamReader.Close();
    Console.WriteLine(data);
} else
{
    Console.WriteLine("Plik nie istnieje, podaj treść nowego pliku. END;; aby zakończyć.");
    File.Create(path).Close();
    string input = " ";
    while (!(input == "END;;")) {
        File.AppendAllText(path, $"{input} \n");
        input = Console.ReadLine();
    }
}