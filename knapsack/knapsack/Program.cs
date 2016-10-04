using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knapsack
{
    class Program
      {       
             static void knapsack(int n,int W)
        {
            int i,w;
                 int [] v = new int[10];
                 int [] weight= new int[10];
                 int [][] C = new int[10][];

	                       for(  i = 1; i <= n; i++)
		                  
			                C[i][0] = 0;

                           for (i = 1; i <= n; i++)
                           {
                               for (w = 0; w <= W; w++)
                                   if (weight[i] <= w)
                                       if (v[i] + C[i - 1][w - weight[i]] > C[i - 1][w])
                                           C[i][w] = v[i] + C[i - 1][w - weight[i]];
                                       else
                                           C[i][w] = C[i - 1][w];
                                   else
                                       C[i][w] = C[i - 1][w];
                               Console.WriteLine(C[i][w]);
                           }
         }
        static void Main(string[] args)
        { 
             
              
        }
    }
}
