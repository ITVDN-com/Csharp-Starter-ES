using System;

namespace BasicTypes
{
    class Program
    {
        static void Main()
        {
            #region TIPO ENTERO

            // 8-bits == 1 byte. ----------------------------------------------------------------------------

            // Entero sin signo. Rango de valores - Desde 0 hasta 255.
            byte a = 0;
            Byte b = 255;

            // Entero con signo. Rango de valores - Desde -128 hasta +127.
            sbyte c = -128;
            SByte d = +127;


            // 16-bits == 2 bytes. -------------------------------------------------------------------------

            // Entero sin signo. Rango de valores -Desde 0 hasta 65535.
            ushort e = 0;
            UInt16 f = 65535;

            // Entero con signo. Rango de valores - Desde -32768 hasta +32767.
            short g = -32768;
            Int16 h = +32767;


            // 32-bits = 4 bytes. ---------------------------------------------------------------------------

            // Entero sin signo. Rango de valores - Desde 0 hasta 4294967295.
            uint i = 0u;
            UInt32 j = 4294967295U;

            // Entero con signo. Rango de valores - Desde -2147483648 hasta +2147483647.
            int k = -2147483648;
            Int32 l = +2147483647;


            // 64-bits = 8 bytes. ---------------------------------------------------------------------------

            // Entero sin signo. Rango de valores - Desde 0 hasta 18446744073709551615.
            ulong m = 0ul;
            UInt64 n = 18446744073709551615UL;

            // Entero con signo. Rango de valores - Desde -9223372036854775808 hasta +9223372036854775807.
            long o = -9223372036854775808L;
            Int64 p = +9223372036854775807L;

            #endregion


            #region TIPO REAL

            // El tipo real es asigando  para el uso de franciones o decimales.

            // 32-bits = 4 bytes. ---------------------------------------------------------------------------

            // real con signo . Rango de valores - Desde +/-1.5 x 10^-45 hasta +/-3.4 x 10^38.
            float q = -0.123456789f;  // el uso del sufijo  f, es siempre necesario, 
            Single r = +1.123456789F; // porque, el compilador integra el numero dado como double.


            // 64-bits = 8 bytes. ---------------------------------------------------------------------------

            // real con signo. Rango de valores - Desde +/-5.0 x 10^-324 hasta +/-1.7 x 10^308.
            double s = -0.123456789d;
            Double t = +1.123456789;

            #endregion


            #region TIPO DECIMAL

            // 128-bits = 16 bytes. -----------------------------------------------------------------------

            // Deciaml con signo. Rango de valores - Desde +/-1.0 x 10^-28 hasta +/-7.9 x 10^28.
            decimal u = -0.12345m;   // el uso del sufijo  m, es siempre necesario, 
            Decimal v = +1.1234567M; // porque, el compilador integra el numero dado como double.

            #endregion


            #region TIPO LOGICO

            // 8-bits == 1 byte. ----------------------------------------------------------------------------

            // Lógica binaria verdad/falsedad.
            bool w = true;
            Boolean x = false;

            #endregion


            #region TIPO SIMBOLICO

            // 16-bits == 2 bytes. -------------------------------------------------------------------------

            // Simbolo en formato  UNICODE(un solo caracter).
            char y = 'a';
            Char z = 'A';

            #endregion


            #region TIPO CADENA 

            //  Simbolo en formato UNICODE.(pero aqui acepta varios codigos)
            string firstString = "hello";
            String secondString = "HELLO";

            #endregion


            // Pausa.
            Console.ReadKey();
        }
    }
}
