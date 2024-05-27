using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertHandler
{
    internal class Handle
    {

        private static string TryAgain()
        {
            Console.WriteLine("Try again");
            return Console.ReadLine() + "";
        }

        public static int Int32(string input)
        {
            int result = 0;
            while (true)
            {
                try
                {
                    result = Convert.ToInt32(input);
                    break;
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Number too high");
                    input = TryAgain();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format");
                    input = TryAgain();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex);
                    input = TryAgain();
                }
            }
            return result;
        }

        public static long Int64(string input)
        {
            long result = 0;
            while (true)
            {
                try
                {
                    result = Convert.ToInt64(input);
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number too high");
                    input = TryAgain();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format");
                    input = TryAgain();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    input = TryAgain();
                }
            }
            return result;
        }

        public static short Int16(string input)
        {
            short result = 0;
            while (true)
            {
                try
                {
                    result = Convert.ToInt16(input);
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number too high");
                    input = TryAgain();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format");
                    input = TryAgain();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    input = TryAgain();
                }
            }
            return result;
        }

        public static double Double(string input)
        {
            double result = 0;
            while (true)
            {
                try
                {
                    result = Convert.ToDouble(input);
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number too high");
                    input = TryAgain();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format");
                    input = TryAgain();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    input = TryAgain();
                }
            }
            return result;
        }
    }
}
