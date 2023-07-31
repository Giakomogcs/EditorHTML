using System;
using System.Text.RegularExpressions;

namespace EditorHTML{
  public class Viewer {
    public static void Show(string text){
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();

      Console.WriteLine("Modo de Vizualização");
      Console.WriteLine("---------------");
      Replace(text);
      Console.Write("\n");
      Console.WriteLine("---------------");
      Console.ReadKey();
      Menu.Show();
    }

    public static void Open(){
      Console.Clear();
      Console.WriteLine("Qual é o nome do arquivo?");
      string nameFile = Console.ReadLine();
      string path = $@"D:\Dotnet_balta\EditorHTML\files\{nameFile}";

      using(var file = new StreamReader(path)){
        string text = file.ReadToEnd();
        Show(text);
      }

    }

    public static void Replace(string text){
      var strong = new Regex(@"<\s*strong[^>]*>(.*?)<\s*/\s*strong>");
      var words = text.Split(' ');

      for(var i =0; i< words.Length; i++){
        if(strong.IsMatch(words[i])){
          Console.ForegroundColor = ConsoleColor.Gray;

          Console.Write(words[i].Substring(
            words[i].IndexOf('>') + 1,
            (words[i].LastIndexOf('<') - 1) - words[i].IndexOf('>')
          ));

          Console.Write(" ");
        } else {
          Console.ForegroundColor = ConsoleColor.Black;
          Console.Write(words[i]);
          Console.Write(" ");
        }
      }
    }
  }
}