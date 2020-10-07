using System;

namespace metodo
{
    class Program
    {
        public static void Main()
        {
           
             string str, T;
             int linha, corf, corc, col;
          do { // abre do
              cls();
              print("teste do metodo Print",15,0,0,0);            
              print("entre string :",15,0,0,1); 
              str = Console.ReadLine();

              print("entre cor caracter",2,0,0,2);
               corc = Convert.ToInt16(Console.ReadLine());
                print("entre cor de fundo",2,0,0,3);
               corf = Convert.ToInt16(Console.ReadLine());
              print("entre linha",8,0,0,4);
               linha = Convert.ToInt16(Console.ReadLine());
              print("entre coluna",6,0,0,5);
               col = Convert.ToInt16(Console.ReadLine());
               cls();
               print(str,corc,corf,col,linha);
               print("linha ",5,0,0,0);
               Console.Write(linha);
               print("coluna ",5,0,0,1);
               Console.Write(col);

               Console.Write("\n\n(S)air?:");           
               T = Console.ReadLine().ToUpper();
             }// fecha do

            while(T != "S");
            cls();
        }// fecha main   
        
          static void cls()
          {
          Console.Clear();
          }// fecha cls
          static void print(String S, int COR_Caracter,int COR_Fundo, int X,int Y)
          {
           ConsoleColor CorC = (ConsoleColor)COR_Caracter;
           ConsoleColor CorF = (ConsoleColor)COR_Fundo;
           Console.ForegroundColor = CorC;
           Console.BackgroundColor = CorF;
            Console.SetCursorPosition(X, Y);
            Console.Write(S);
            Console.ResetColor();
          }//fecha print
    }//fecha class
}//name_space


