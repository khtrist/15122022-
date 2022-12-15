using System;
using System.Reflection.Metadata.Ecma335;

namespace _15_12_2022_eve_verilenler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            



        }






        // TASK 1  ===Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod
        static int Sum(int x, int y)
        {
            return x + y;
        }

        // TASK 2  === Verilmiş ədədin kvadratını qaytaran metod

        static int sum(int x)
        {
            return x * x;



        }

        // TASK 3 ===Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod


        static bool herif(string soz)
        {
            var has = false;
            for (int i = 0; i < soz.Length; i++)
            {
                if (soz[i] == 'a')
                {
                    has = true;
                    break;

                }
                else
                {
                    has = false;
                }
            }
            return has;









            // TASK 4 ===Verilmiş ədədin rəqəmləri cəmini qaytaran metod

            static int SumOfDigits(int n)
            {
                int sum = 0;

                while (n > 0)
                {
                    sum += n % 10;
                    n = (n - n % 10) / 10;
                }

                return sum;

            }

                // TASK 5=== Verilmiş 4 ədədin ortalamasını tapıq qaytaran metod

                static int ededlerintenortasi(int Num1, int Num2, int Num3, int Num4)
                {
                    Console.WriteLine("ededlerin ten ortasi");
                    return (Num1 + Num2 + Num3 + Num4) / 4;



                }

                //TASK 6====Verilmiş ədədin verilmiş qüvvətini tapan metod -
                


                static int Pow(int num, int quvvet)
                {
                    int result = 1;
                    for (int i = 0; i < quvvet; i++)    
                    {
                        result *= num;
                    }
                    return result;
                }



                // TASK 7 ==Verilmiş 3 ədəddən ən böyüyünü tapan metod

                static int FindBiggest(int num1, int num2, int num3)
                {
                    if (num1 > num2)
                    {
                        if (num1 > num3)
                        {
                            return num1;
                        }
                        else
                        {
                            return num3;
                        }
                    }
                    else if (num2 > num3)
                    {
                        return num2;
                    }
                    else
                    {
                        return num3;
                    }


                }


                //TASK 8  //Verilmis ededler siyahisindaki en boyuk ededi tapan metod
                static int FindBiggest(int[] numbers)
                {
                    int max = numbers[0];
                    for (int i = 1; i < numbers.Length; i++)
                    {
                        if (numbers[i] > max)
                        {
                            max = numbers[i];
                        }
                    }

                    return max;
                }


                //TASK 9 - Verilmiş ədədlər siyahısındaki ədədlərin yalnız müsbət olanlarından
                //ibarət yeni bir array qaytaran metod

                static int[] FilterPositive(int[] numbers)
                {
                    int count = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] > 0)
                            count++;

                    }

                    int j = 0;
                    int[] positiveNumbers = new int[count];

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (numbers[i] > 0)
                        {
                            positiveNumbers[j] = numbers[i];
                            j++;
                        }
                    }

                    return positiveNumbers;
                }

                static int FindIndex(string[] arr, string wantedStr)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == wantedStr)
                            return i;
                    }

                    return -1;
                }

                // TASK Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod

                static bool IsDigit(char givenchar)
                {
                    char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                    return (FindIndex(digits, givenchar) != -1);
                }
                
                    


                    // TASK Verilmiş yazıda rəqəm olub olmadığını qaytaran metod

                static bool HasDigit(string word)
                {
                    for (int i = 0; i < word.Length; i++)

                    {
                        if (IsDigit(word[i]))
                            return true;
                    }
                    return false;
                }

                // TASK Verilmiş yazıdaki ilk boşluq olmayan index-i qaytaran metod
                static int findilkbosluqindex(string str)
                {

                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str(i) != ' ')
                        {
                            return i;

                        }
                    }
                    return -1;




                }

                // TASK Verilmiş yazıdaki son boşluq olmayan index-i qaytaran metod

                static int findsonbosluqindex(string ystr)
                {

                    for (int i = ystr.Length-1; i>0; i--)
                    {
                        if (ystr(i) != ' ')
                        {
                            return i;

                        }
                    }
                    return -1;
                }

                //TASK Verilmiş yazını sol tərəfində boşluq olmayan vəziyyətdə qaytaran metod
                static string TrimLeft(string str)
                {
                    var startIndex = findsonbosluqindex(str);
                    string newStr = "";
                    for (int i = startIndex; i < str.Length; i++)
                    {
                        newStr += str[i];
                    }

                    return newStr;
                }

                //TASK Verilmiş yazını sol və sağ tərəflərində boşluq olmayan vəziyyətdə qaytaran metod sonuncu
                static string sagsolbosluq(string str)
                {
                    var startIndex = TrimLeft(str);
                    var newStr = string.Empty;
                    var startIndex = findsonbosluqindex(ystr);
                    var newStr 2 = string.Empty;    
                    // YAZA BILMEDIM BUNU 

                }



            }
        }
