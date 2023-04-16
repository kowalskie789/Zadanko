using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class MyList<T>
    {
       private T[] data = new T[3];
       private int counter = 0;
        public void InsertData(T x)
        {
            
            if(counter>data.Length-1)
            {

                T[] newData = new T[counter+1];
                for (int i = 0; i < data.Length; i++)
                {
                    newData[i] = data[i];
                }
                data = newData;
            }

            data[counter++] = x;
        }
        public void Print()
        {
            for (int i = 0; i < counter; i++)
            {
            Console.WriteLine(data[i]);
            }
        }
    
    }
}
