using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_27._02._2023
{
    #region ex4
    class Stack<T> {
        static public List<T> mas = new List<T>();

        public T Push(T num) {
            
            return default;
        }
        public T Pop() {
            mas.RemoveAt(mas.Count());
            return default;
        }
    }

    #endregion



    internal class Program
    {
        #region ex1
        /*public static T Max<T>(T a, T b, T c) where T : IComparable<T> {
            if(a.CompareTo(b) > 0 && a.CompareTo(c) > 0) {
                return a;
            }
            else if(b.CompareTo(a) > 0 && b.CompareTo(c) > 0) {
                return b;
            }
            return c;
        }*/
        #endregion

        #region ex2
        /*public static T Min<T>(T a, T b, T c) where T: IComparable<T> { 
            if(a.CompareTo(b) < 0 && a.CompareTo(c) < 0) {
                return a;
            }
            else if(b.CompareTo(a) < 0 && b.CompareTo(c) < 0) {
                return b;
            }
            return c;
        }*/
        #endregion

        #region ex3
        /*public static T Massive<T>(T[]mas) where T : struct, IComparable<T> {
            T sum = default(T);
            foreach (T a in mas) {
                sum = (dynamic)sum + a;
            }
            return sum;
        }*/
        #endregion

        static void Main(string[] args)
        {
            /*int num = Min(12, 56, 34);
            Console.WriteLine(num);*/

            /*int[] mas = new int[] { 1, 2, 3, 4, 5 };
            int sum = Massive(mas);
            Console.WriteLine(sum);*/


       


        }
    }
}
