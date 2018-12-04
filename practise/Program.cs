using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practise
{
    class Program
    {

        public static int[] sort(int[]a,int[]b)
        {
            int [] third = new int[a.Length + b.Length];
            int i=0, j = 0;
            for(int z=0;z<third.Length; z++)
            {
                if(a.Length <= i) third[z] = b[j++];
                else if (b.Length <= j) third[z] = b[i++];
                else if (a[i] >= b[j]) third[z] = b[j++];
                else   third[z] = b[i++];


            }
            return third;

        }
        public static int[] merge(int[] x)
        {
            
            int leng = x.Length;
            int[] arr1 = new int[(leng / 2)];
            int[] arr2 = new int[(leng / 2)];
            if (leng <= 1) return x;
            else
            {
               
                for (int i = 0; i < leng/2; i++) arr1[i] = x[i];

                for (int j = 0; j < leng/2; j++) arr2[j] = x[leng/2+j];

                Console.WriteLine("asad");

            }
            return sort(merge(arr1), merge(arr2));
        }

        static void Main(string[] args)
        {
            int numberOfItemsInArray;
            numberOfItemsInArray = int.Parse(Console.ReadLine());

            int[] asad = new int[numberOfItemsInArray];
            for (int i = 0; i < asad.Length; i++)
            {
                asad[i] = int.Parse(Console.ReadLine());
            }

            int xy = 1;
            
            asad = merge(asad);
            for (int i = 0; i < asad.Length; i++)
            {
                Console.WriteLine(asad[i]);
            }

            Console.ReadKey();
        }
    }
}
