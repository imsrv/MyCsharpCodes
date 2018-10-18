using System;

namespace dotNetCoreConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
        int x,j;
            int n=6;
            for(x=0;x<=n;x++){
                for(j=0;j<=x;j++)
                Console.Write(" ");
                for(j=0;j<=n*2-x*2;j++)
                Console.Write("*");
                for(j=0;j<=x*2;j++)
                Console.Write(" ");
                for(j=0;j<=n*2-x*2;j++)
                Console.Write("*");
                for(j=0;j<=x*2;j++)
                Console.Write(" ");
                Console.WriteLine();
            }
            for(x=0;x<=n;x++){
                for(j=0;j<=n-x;j++)
                Console.Write(" ");
                for(j=0;j<=x*2;j++)
                Console.Write("*");
                for(j=0;j<=n*2-x*2;j++)
                Console.Write(" ");
                for(j=0;j<=x*2;j++)
                Console.Write("*");
                for(j=0;j<=n*2-x*2;j++)
                Console.Write(" ");
                Console.WriteLine();
            }
            
    }
}
