using System;

namespace Lab_exe
{
    public static class MyCalc
    {
        public static double Add(double op1,double op2)
         {
            return op1+op2;
         }
         public static double Sub(double op1,double op2)
         {
            return op1-op2;
         }
         public static double Mul(double op1,double op2)
         {
            return op1*op2;
         }
         public static double Div(double op1,double op2)
         {
         return op1/op2;
         }
         public static double Pow(double op1,double op2)
         {
            double op3=op1;
             for (double i=1; i<op2; i++)
            {
                op3=op3*op1;
            }
            return op3;
         }
    }
}
