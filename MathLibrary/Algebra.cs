using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class Algebra
    {
        public static string QuadraticEquation(double a, double b, double c)
        {
            if (a != 0)
            {
                double Disc = b*b - 4 * a * c;
                if (Disc < 0)
                {
                    string noRoots = "No roots!";
                    return noRoots;
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(Disc)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(Disc)) / (2 * a);
                    string res = x1.ToString() + x2.ToString();
                    return res;
                }
            }
            else
            {
                string noRes = "This is not a quadratic equation";
                return noRes;
            }
        }
        //Linear Equation Root
        public static double LinearEquation(double a, double b, double c)
        {
            double k = c - b;
            k *= a;
            return k;
        }
        //Array Sum
        public static double RowSum(double[] arr)
        {
            double resArr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                resArr = resArr + arr[i];
            }
            return resArr;
        }
        //Series mean
        public static double RowAgg(double[] arr)
        {
            double resArr = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                resArr = resArr / arr.Length;
            }
            return resArr;
        }
        //Maximum row value
        public static double RowmAX(double[] arr)
        {
            double res = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
               if(res < arr[i])
                {
                    res = arr[i];
                }
            }
            return res;
        }
    }
}
