using System;

namespace Lab1_Bayarschonok
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            bool c1, a1 = true, b1 = false;
            Console.WriteLine("bool");


            //Binary Operators

            //Console.WriteLine(a1+b1); // Error. Also for others operators "-", "/", "*", "%"
            //Console.WriteLine(a1 % b1); // Error. 
            //Console.WriteLine(a1++); // Error. Also for others operators "--"

            // Logical operators

            Console.WriteLine(c1 = a1 == b1);
            Console.WriteLine(c1 = a1 & b1);
            Console.WriteLine(c1 = a1 && b1);
            Console.WriteLine(c1 = a1 | b1);
            Console.WriteLine(c1 = a1 || b1);
            Console.WriteLine(c1 = a1 ^ b1);
            Console.WriteLine(c1 = a1 != b1);
            Console.WriteLine(c1 = a1 > b1);
            Console.WriteLine(c1 = a1 < b1);
            Console.WriteLine(c1 = a1 >= b1);
            Console.WriteLine(c1 = a1 >> b1);
            Console.WriteLine(c1 = a1 << b1);

            //ternary operator
            Console.WriteLine(c1 = a1 == b1 ? a1 : b1);



            byte c2, a2 = 220, b2 = 100;
            
            //c2 = a2+b2; //  byte to int32
            //Console.WriteLine(c2);

            //Binary Operators

            Console.WriteLine(c2 = a2 + b2);
            Console.WriteLine( c2 = a2 - b2); // cannot implicitly convert type int to byte also for other binary operators
            Console.WriteLine(a2 * b2);
            Console.WriteLine(a2 / b2);
            Console.WriteLine(a2 % b2); 

            // Logical operators
            
            Console.WriteLine(c2 = a2 ^ b2); // logical operators also cannot implicitly convert type int to byte also for other  operators
            Console.WriteLine(c2 = a2 & b2);
            Console.WriteLine(c2 = a2 | b2);
            Console.WriteLine(c2 = a2 && b2);
            Console.WriteLine(c2 = a2 == b2);
            Console.WriteLine(c2 = a2 != b2);
            Console.WriteLine(c2 = a2 > b2);
            Console.WriteLine(c2 = a2 >> b2);
            Console.WriteLine(c2 = a2 >= b2);


            //Unary operation
            Console.WriteLine(c2 = ++a2);
            Console.WriteLine(a2++);
            Console.WriteLine(--a2);
            Console.WriteLine(a2--);

            //ternary operator
            c2 = a2 == b2 ? a2 : a2;
            Console.WriteLine(c2);




            sbyte c3, a3 = 5, b3 = 10;

            //Binary Operators

            Console.WriteLine(c3 = a3 + b3);
            Console.WriteLine(c3 = a3 - b3); // cannot implicitly convert type sbyte to int also for other binary operators
            Console.WriteLine(c3 = a3 * b3);
            Console.WriteLine(a3 / b3);
            Console.WriteLine(a3 % b3);

            // Logical operators

            Console.WriteLine(c3 = a3 ^ b3); // logical operators also cannot implicitly convert type int to sbyte also for other logical operators
            Console.WriteLine(c3 = a3 & b3);
            Console.WriteLine(c3 = a3 && b3);
            Console.WriteLine(c3 = a3 | b3);
            Console.WriteLine(c3 = a3 || b3);
            Console.WriteLine(c3 = a3 > b3);
            Console.WriteLine(c3 = a3 >> b3);
            Console.WriteLine(c3 = a3 == b3);
            Console.WriteLine(c3 = a3 != b3);


            //Unary operation
            Console.WriteLine(c3 = ++a3);
            Console.WriteLine(a3++);
            Console.WriteLine(--a3);
            Console.WriteLine(a3--);

            //ternary operator
            c3 = a3 == b3 ? a3 : b3;
            Console.WriteLine(c3);

            
            short c4, a4 = 5, b4 = 10;

            //Binary Operators

            Console.WriteLine(c4 = a4 + b4);
            Console.WriteLine(c4 = a4 - b4); // cannot implicitly convert type int to short also for other binary operators
            Console.WriteLine(c4 = a4 * b4);
            Console.WriteLine(c4 = a4 / b4);
            Console.WriteLine(c4 = a4 % b4);

            // Logical operators

            Console.WriteLine(c4 = a4 ^ b4); // logical operators also cannot implicitly convert type int to short also for other logical operators
            Console.WriteLine(c4 = a4 & b4);
            Console.WriteLine(c4 = a4 && b4);
            Console.WriteLine(c4 = a4 | b4);
            Console.WriteLine(c4 = a4 || b4);
            Console.WriteLine(c4 = a4 == b4);
            Console.WriteLine(c4 = a4 != b4);
            Console.WriteLine(c4 = a4 > b4);
            Console.WriteLine(c4 = a4 >> b4);
            Console.WriteLine(c4 = a4 >= b4);


            //Unary operation
            Console.WriteLine(c4 = ++a4);
            Console.WriteLine(a4++);
            Console.WriteLine(--a4);
            Console.WriteLine(a4--);

            //ternary operator
            c4 = a4 == b4 ? a4 : b4;
            Console.WriteLine(c4);


            ushort c5, a5 = 5, b5 = 10;

            //Binary Operators

            Console.WriteLine(c5 = a5 + b5);
            Console.WriteLine(c5 = a5 - b5); // cannot implicitly convert type int to short also for other binary operators
            Console.WriteLine(a5 * b5);
            Console.WriteLine(a5 / b5);
            Console.WriteLine(a5 % b5);

            // Logical operators

            Console.WriteLine(c5 = a5 ^ b5);
            Console.WriteLine(c5 = a5 & b5);
            Console.WriteLine(c5 = a5 && b5);
            Console.WriteLine(c5 = a5 == b5); // logical operators also cannot implicitly convert type bool to ushort also for other logical operators
            Console.WriteLine(c5 = a5 != b5);
            Console.WriteLine(c5 = a5 | b5);
            Console.WriteLine(c5 = a5 || b5);
            Console.WriteLine(c5 = a5 >> b5);
            Console.WriteLine(c5 = a5 > b5);
            Console.WriteLine(c5 = a5 >= b5);

            //Unary operation
            Console.WriteLine(c5 = ++a5);
            Console.WriteLine(a5++);
            Console.WriteLine(--a5);
            Console.WriteLine(a5--);

            //ternary operator
            c5 = a5 == b5 ? a5 : b5;
            Console.WriteLine(c5);



            int c7, a7 = 5, b7 = 10;

            //Binary Operators

            Console.WriteLine(c7 = a7 + b7);
            Console.WriteLine(c7 = a7 - b7); // cannot implicitly convert type int to short also for other binary operators
            Console.WriteLine(a7 * b7);
            Console.WriteLine(a7 / b7);
            Console.WriteLine(a7 % b7);

            // Logical operators

            Console.WriteLine(c7 = a7 ^ b7); 
            Console.WriteLine(c7 = a7 & b7);
            Console.WriteLine(c7 = a7 | b7);
            Console.WriteLine(c7 = a7 > b7);
            Console.WriteLine(c7 = a7 << b7);
            Console.WriteLine(c7 = a7 >= b7);
            Console.WriteLine(c7 = a7 && b7);
            Console.WriteLine(c7 = a7 || b7);
            Console.WriteLine(c7 = a7 == b7); // logical operators also cannot implicitly convert type bool to int also for other logical operators
            Console.WriteLine(c7 = a7 != b7);

            //Unary operation
            Console.WriteLine(c7 = ++a7);
            Console.WriteLine(a7++);
            Console.WriteLine(--a7);
            Console.WriteLine(a7--);

            //ternary operator
            c7 = a7 == b7 ? a7 : b7;
            Console.WriteLine(c7);



            uint c8, a8 = 5, b8 = 10;

            //Binary Operators

            Console.WriteLine(c8 = a8 + b8);
            Console.WriteLine(c8 = a8 - b8); 
            Console.WriteLine(a8 * b8);
            Console.WriteLine(a8 / b8);
            Console.WriteLine(a8 % b8);

            // Logical operators

            Console.WriteLine(c8 = a8 ^ b8);
            Console.WriteLine(c8 = a8 & b8);
            Console.WriteLine(c8 = a8 | b8);
            Console.WriteLine(c8 = a8 > b8);
            Console.WriteLine(c8 = a8 << b8);
            Console.WriteLine(c8 = a8 >= b8);
            Console.WriteLine(c8 = a8 || b8);
            Console.WriteLine(c8 = a8 && b8);
            Console.WriteLine(c8 = a8 == b8); // logical operators also cannot implicitly convert type bool to int also for other logical operators
            Console.WriteLine(c8 = a8 != b8);

            //Unary operation
            Console.WriteLine(c8 = ++a8);
            Console.WriteLine(a8++);
            Console.WriteLine(--a8);
            Console.WriteLine(a8--);

            //ternary operator
            c8 = a8 == b8 ? a8 : b8;
            Console.WriteLine(c8);




            long c9, a9 = 5, b9 = 10;

            //Binary Operators

            Console.WriteLine(c9 = a9 + b9);
            Console.WriteLine(c9 = 9 - b9);
            Console.WriteLine(a9 * b9);
            Console.WriteLine(a9 / b9);
            Console.WriteLine(a9 % b9);

            // Logical operators

            Console.WriteLine(c9 = a9 ^ b9);
            Console.WriteLine(c9 = a9 & b9);
            Console.WriteLine(c9 = a9 | b9);
            Console.WriteLine(c9 = a9 || b9);
            Console.WriteLine(c9 = a9 && b9);
            Console.WriteLine(c9 = a9 == b9); // logical operators  cannot implicitly convert type bool to long also for other logical operators
            Console.WriteLine(c9 = a9 != b9);
            Console.WriteLine(c9 = a9 > b9);
            Console.WriteLine(c9 = a9 >> b9);
            Console.WriteLine(c9 = a9 >= b9);


            //Unary operation
            Console.WriteLine(c9 = ++a9);
            Console.WriteLine(a9++);
            Console.WriteLine(--a9);
            Console.WriteLine(a9--);

            //ternary operator
            c9 = a9 == b9 ? a9 : b9;
            Console.WriteLine(c9);

            ulong c10, a10 = 10, b10 = 5;

            //Binary Operators

            Console.WriteLine(c10 = a10 + b10);
            Console.WriteLine(c10 = a10 - b10);
            Console.WriteLine(a10 * b10);
            Console.WriteLine(a10 / b10);
            Console.WriteLine(a10 % b10);

            // Logical operators

            Console.WriteLine(c10 = a10 ^ b10);
            Console.WriteLine(c10 = a10 & b10);
            Console.WriteLine(c10 = a10 | b10);
            Console.WriteLine(c10 = a10 > b10);
            Console.WriteLine(c10 = a10 < b10);
            Console.WriteLine(c10 = a10 << b10);
            Console.WriteLine(c10 = a10 || b10);
            Console.WriteLine(c10 = a10 && b10);
            Console.WriteLine(c10 = a10 == b10); // logical operators  cannot implicitly convert type bool to long also for other logical operators
            Console.WriteLine(c10 = a10 != b10);

            //Unary operation
            Console.WriteLine(c10 = ++a10);
            Console.WriteLine(a10++);
            Console.WriteLine(--a10);
            Console.WriteLine(a10--);

            //ternary operator
            c10 = a10 == b10 ? a10 : b10;
            Console.WriteLine(c10);



            double c11, a11 = 5.5, b11 = 10.5;

            //Binary Operators

            Console.WriteLine(c11 = a11 + b11);
            Console.WriteLine(c11 = a11 - b11);
            Console.WriteLine(a11 * b11);
            Console.WriteLine(a11 / b11);
            Console.WriteLine(a11 % b11);

            // Logical operators

            Console.WriteLine(c11 = a11 ^ b11);
            Console.WriteLine(c11 = a11 & b11);
            Console.WriteLine(c11 = a11 | b11);
            Console.WriteLine(c11 = a11 || b11);
            Console.WriteLine(c11 = a11 && b11);
            Console.WriteLine(c11 = a11 == b11); // logical operators  cannot implicitly convert type bool to double also for other logical operators
            Console.WriteLine(c11 = a11 != b11);
            Console.WriteLine(c11 = a11 >= b11);
            Console.WriteLine(c11 = a11 >> b11);
            Console.WriteLine(c11 = a11 > b11);


            //Unary operation
            Console.WriteLine(c11 = ++a11);
            Console.WriteLine(a11++);
            Console.WriteLine(--a11);
            Console.WriteLine(a11--);

            //ternary operator
            c11 = a11 == b11 ? a11 : b11;
            Console.WriteLine(c11);



            float c12, a12 = 5, b12 = 10;

            //Binary Operators

            Console.WriteLine(c12 = a12 + b12);
            Console.WriteLine(c12 = a12 - b12);
            Console.WriteLine(a12 * b12);
            Console.WriteLine(a12 / b12);
            Console.WriteLine(a12 % b12);

            // Logical operators

            Console.WriteLine(c12 = a12 ^ b12);
            Console.WriteLine(c12 = a12 & b12);
            Console.WriteLine(c12 = a12 | b12);
            Console.WriteLine(c12 = a12 || b12);
            Console.WriteLine(c12 = a12 && b12);
            Console.WriteLine(c12 = a12 == b12); // logical operators  cannot implicitly convert type bool to double also for other logical operators
            Console.WriteLine(c12 = a12 != b12);
            Console.WriteLine(c12 = a12 > b12);
            Console.WriteLine(c12 = a12 >> b12);
            Console.WriteLine(c12 = a12 >= b12);



            //Unary operation
            Console.WriteLine(c12 = ++a12);
            Console.WriteLine(a12++);
            Console.WriteLine(--a12);
            Console.WriteLine(a12--);

            //ternary operator
            c12 = a12 == b12 ? a12 : b12;
            Console.WriteLine(c12);


            char c13, a13 = 'A', b13 = '2';
            Console.WriteLine("_____________________________________");
            Console.WriteLine("char");

            //Binary Operators 

            Console.WriteLine(c13 = a13 + b13);
            Console.WriteLine(c13 = a13 - b13);
            Console.WriteLine(c13 = a13 / b13);
            Console.WriteLine(c13 = a13 * b13);
            Console.WriteLine(c13 = a13 % b13);

            // Logical operators

            Console.WriteLine(c13 = a13 ^ b13);
            Console.WriteLine(c13 = a13 & b13);
            Console.WriteLine(c13 = a13 | b13);
            Console.WriteLine(c13 = a13 || b13);
            Console.WriteLine(c13 = a13 && b13);
            Console.WriteLine(c13 = a13 == b13); // logical operators  cannot implicitly convert type bool to char also for other logical operators
            Console.WriteLine(c13 = a13 != b13);
            Console.WriteLine(c13 = a13 > b13);
            Console.WriteLine(c13 = a13 >= b13);
            Console.WriteLine(c13 = a13 >> b13);


            //Unary operation
            Console.WriteLine();
            Console.WriteLine(c13 = ++a13);
            Console.WriteLine(a13++);
            Console.WriteLine(--a13);
            Console.WriteLine(a13--);

            //ternary operator
            c13 = a13 == b13 ? a13 : b13;
            Console.WriteLine(c13);



            Console.WriteLine("The end");
        }
    }
}