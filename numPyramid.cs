using System;

namespace dotNetCoreConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
           int i;
           int j;
           for(i=0;i<6;i++){
               for(j=6;j>=6-i;j--)
               Console.Write(i);
               Console.WriteLine();
         		}
					}
			}
	}
