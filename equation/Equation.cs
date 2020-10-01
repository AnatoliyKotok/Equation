using System;
using System.Collections.Generic;
using System.Text;

namespace equation_
{
    class LEquation
    {
        int a;



        public int Root { get => -B / a; }
        public int A
        {
            get => a;


            set
            {
                if (value == 0)
                {

                    throw new Exception("a is a bad value");
                }
                else
                {
                    a = value;
                }
            }
        }

        public int B { get; set; }

        public static LEquation Parse(string str)
        {

            string[] arrStr = str.Split(" \t".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            if (arrStr.Length != 2)
            {
                throw new Exception("bad quantuti coef");
            }

            if (!int.TryParse(arrStr[0], out int a))
            {
                throw new Exception("Not parse first coef");
            }
            if (!int.TryParse(arrStr[1], out int b))
            {
                throw new Exception("Not parse second coef");
            }

            return new LEquation(a, b);

        }
        public LEquation(int a, int b)
        {
            this.A = a;
            this.B = b;

        }

        public override string ToString()
        {
            return $"Coeficient A {A} : Coeficient : {B} ";
        }

    }
}

