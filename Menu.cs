using System;

namespace EditorHTML{
  public static class Menu{
    public static void Show(){   
      Console.Clear();
      Console.BackgroundColor = ConsoleColor.Black;
      Console.ForegroundColor = ConsoleColor.DarkRed;
      
      Console.WriteLine("Menu..."); 
      DrawScreen();
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
      Row();
      Colum();
      Row();
    }

  }


}