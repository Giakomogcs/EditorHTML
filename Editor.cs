using System;
using System.Text;

namespace EditorHTML{
  public static class Editor{
    public static void Show(){
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.White;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();

      Console.WriteLine("Modo Editor");
      Console.WriteLine("---------------");
      Start();
    }

    public static void Start(){
      var file = new StringBuilder();

      do{
        file.Append(Console.ReadLine());

        file.Append(Environment.NewLine);
      } while(Console.ReadKey().Key != ConsoleKey.Escape);

      Console.WriteLine("-------------");
      Console.WriteLine(" Deseja salvar o arquivo? (y or n)");

      var decision = Console.ReadLine().ToLower();
      if (decision == "y") {
        Save(file.ToString());
      }

      else if (decision == "n") {
        Menu.Show();
      }

      else{
        Start();
      }
    }

    static void Save(string text){
      Console.Clear();
      Console.WriteLine("Qual o nome do arquivo?");
      var nameFile = Console.ReadLine();
      var path = $@"D:\Dotnet_balta\EditorHTML\files\{nameFile}";

      using(var file = new StreamWriter(path)){
        file.Write(text);
      }

      Console.WriteLine("Arquivo salvo com sucesso!!");
      Console.ReadLine();
      Viewer.Show(text);

      Menu.Show();
    }
  }

}