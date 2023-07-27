using System;

namespace EditorHTML{
  public static class Menu{
    public static void Show(){   
      // Console.BackgroundColor = ConsoleColor.Black;
      // Console.ForegroundColor = ConsoleColor.DarkRed;
      DrawScreen();
      writeOptions();
    }
    public static void Row(){
      Console.Write("+");

      for(int i=0; i<=30; i++){
        Console.Write("-");
      }

      Console.Write("+");
      Console.Write("\n");
    }

    public static void Colum(){
      for(int lines=0; lines<=10; lines++){
        Console.Write("|");

        for(int i=0; i<=30; i++){
          Console.Write(" ");
        }

        Console.Write("|");
        Console.Write("\n");
      }
    }
    public static void DrawScreen(){
      Console.Clear();
      Row();
      Colum();
      Row();

      //var option = short.Parse(Console.ReadLine());
    }

    public static void writeOptions(){
      Console.SetCursorPosition(3,2);
      Console.WriteLine("Editor HTML");

      Console.SetCursorPosition(3,3);
      Console.WriteLine("----------------");

      Console.SetCursorPosition(3,4);
      Console.WriteLine("Selecione uma opção a baixo:");

      Console.SetCursorPosition(3,6);
      Console.WriteLine("1 - Novo arquivo");

      Console.SetCursorPosition(3,7);
      Console.WriteLine("2 - Abrir");

      Console.SetCursorPosition(3,9);
      Console.WriteLine("0 - Sair");

      Console.SetCursorPosition(7,10);
      Console.Write("Opcão: ");
    }

  }


}