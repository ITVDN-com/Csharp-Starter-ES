using System;

// Casting – Es una conversión de valores  de una variable de un tipo a valores de otro tipo.

// Conversión explícita  (explicit) y Conversión implícita  (implicit) Conversión de tipos.

namespace Casting
{
    class Program
    {
        static void Main()
        {
            //   ----------------------------------  Variable  ---------------------------------------------

            #region Conversión implícita  (Seguro) Conversion de tipos:

            // Conversión implícita valores tipo - byte en el tipo int. (conversión de un tipo menor a mayor) 
            byte a = 10;     //                                      0000 1010  -  1 Byte
            int b = 0;       //  0000 0000   0000 0000   0000 0000   0000 0000  -  4 Bytes
            b = a;           //  0000 0000   0000 0000   0000 0000   0000 1010  -  4 Bytes              

            Console.WriteLine(b);

            // Conversión implícita valores de tipo - int en tipo  float. (conversion  de tipo entero a real ) 
            int c = 255;
            float d = 0f;
            d = c;

            Console.WriteLine(d);
            
            #endregion

            #region Conversión explícita  (peligroso) conversión de tipos:

            // Conversión explícita  valores de tipo - int en el  byte. 
            // (Conversión de tipo mayor a menor, pasamos a la perdida de la parte )            

            int e = 256;     //  0000 0000   0000 0000   0000 0001   0000 0000  -  4 Bytes
            byte f = 0;      //                                      0000 0000  -  1 Byte
            f = (byte)e;     //                                      0000 0000  -  1 Byte
             //f = e;        //  ERROR.

            Console.WriteLine(f);

            // Conversión explícita  valores de tipo - float en el int.  
            // (conversion del tipo  real a entero, a la perdida del resultado exato т)

            float g = 10.5F;
            int h = 0;
            h = (int)g;
             //h = g;         // ERROR.

            Console.WriteLine(h);
            
            #endregion

            //   ----------------------------------  Constantes  ----------------------------------------------

            #region Casting

            // Conversión implícita  los valores de la constante  de tipo - int en el byte,
            // al inicializar el valor de la variable de la constante,
            // si la constante no supera el valor máximo permitido de la variable.

            const int i = 255;  //  0000 0000   0000 0000   0000 0000   1111 1111  -  4 Bytes
            byte j = 0;         //                                      0000 0000  -  1 Byte
            j = i;              //                                      1111 1111  -  1 Byte

            Console.WriteLine(j);

            // conversión explícita de tipo del valor de la constante - float en el byte, 
            // al inicializar el valor de la variable de la constante,
            // si la constante no supera el valor máximo permitido de la variable.

            const float k = 255;
            byte l = 0;
            l = (byte)k;

            Console.WriteLine(l);


            // Imposible explicita,  explicita  conversion del valor de la constante,
            // al inicializar el valor de la variable de la constante,
            // si la constante no supera el valor máximo permitido de la variable

            const int m = 256;  //  0000 0000   0000 0000   0000 0001   0000 0000  -  4 Bytes
            byte n = 0;         //                                      0000 0000  -  1 Byte
             //n = m;           //  ERROR.
            // n = (byte)m;     //  ERROR.

            Console.WriteLine(n);

            // Imposible  hacer  conversion explicita,implicita conversion de valores enteros de la constante,
            // al inicializar el valor de la variable de la constante,
            // si la constante no supera el valor máximo permitido de la variable.

            const float o = (float)256.5; // Conversión tipo double en el  float
            byte p = 0;
            // p = o;           //  ERROR.
            // p = (byte)o;     //  ERROR.

            Console.WriteLine(p);
            
            #endregion
            
            // Demora.
            Console.ReadKey();
        }
    }
}
