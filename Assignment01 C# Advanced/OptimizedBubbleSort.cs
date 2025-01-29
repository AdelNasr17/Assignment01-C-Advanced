using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment01C_Advanced.Q01
{
    internal static class OptimizedBubbleSort<T> where T : IComparable<T>
    {
        public static void SWAP( ref T X , ref T Y )
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }


        public static void BubbleSort( T [] array)
        {
            bool Swaped;
            if (array is null) return;
            for ( int i = 0;i < array.Length-1; i++ )
            {
                Swaped = false;
                for ( int j = 0; j < array.Length-1 -i; j++ )
                {
                    if (array[j].CompareTo(array[j+1])>0)
                    {
                        OptimizedBubbleSort<T>.SWAP(ref array[j], ref array[j + 1]);
                        Swaped = true;
                    }
                        
                } 
                if(!Swaped)   
                    break;
            }
        }
    }
}
