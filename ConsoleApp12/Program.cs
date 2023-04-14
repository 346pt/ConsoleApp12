StreamReader text = new StreamReader(@"C:\Users\Антисептик\Desktop\лаба11(10)");
string[] massiv = text.ReadToEnd().Split('\n');
foreach (var i in massiv)
{
    Console.WriteLine(i);
}
