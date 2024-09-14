/*
У масиві всі елементи однотипні (мають однаковий розмір і властивості) і розташовуються в пам’яті один за одним, це дозволяє в будь-який момент часу отримати доступ до будь-якого елемента масиву за його номером (індексом)..
Исходя из этого, считаем индекс=номеру. Хотя часты случаи, когда принято считать индекс=№-1 при №>0".
*/

using System;

public class Lab1
{
static int i_without_init, i_with_init=4321;
const int constint=1234;
static char c_without_init, c_with_init='c';
const char constchar='C';
static int[] i_array={00,11,22,33,/**/0/**/,55,66,77}; 
static short[] s_array=new short[5]{-76,5,32,7,948};
static long[] l_array={1414,245468,2567,78,54,653};
static uint[] u_array={11u,22u,33u,44u,55u};
const double d_in=Math.PI; static double dd=d_in;
const float f_in=(float)d_in; static float ff=f_in;

    public static void Main(string[] args)
    {
        Console.WriteLine ("Var int = "+i_with_init);
        Console.WriteLine ("Const int = "+constint);
        Console.WriteLine ("Var char = "+c_with_init);
        Console.WriteLine ("Const char = "+constchar);
        Console.WriteLine ("[4] in itn array = "+i_array[4]);
        Console.Write ("[1] in short array = "+s_array[1]);
        Console.WriteLine ("; and [3] in short array = "+s_array[3]);
        {
            int i_out=l_array.Length;
            Console.WriteLine ("Long array size = "+i_out);
            i_out=Convert.ToInt32(dd);
            Console.WriteLine ("PI = "+dd+" | as int = "+i_out);
        }
    }
}