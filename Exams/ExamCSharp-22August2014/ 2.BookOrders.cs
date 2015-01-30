using System;
using System.Collections.Generic;
using System.Linq;

    class Program
        {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<decimal> price = new List<decimal>();
            List<int> boughtBooks = new List<int>();
           
            decimal discount;

            for (int i = 0; i < N; i++)
            {              
                
                    int numOfPackets = int.Parse(Console.ReadLine());
                    int booksPerPacket = int.Parse(Console.ReadLine());
                    decimal priceBook = decimal.Parse(Console.ReadLine());
                    
                    #region DiscountIfs
                   
                    if (numOfPackets>=10 && numOfPackets<=19)
                    {
                        discount = (5m / 100) * priceBook;
                        priceBook = priceBook - discount;
                    } 
                    if (numOfPackets >= 20 && numOfPackets <= 29)
                    {
                        discount = (6 / 100m) * priceBook;
                        priceBook = priceBook - discount;
                    }
                    if (numOfPackets >= 30 && numOfPackets <= 39)
                    {
                        discount = (7 / 100m) * priceBook;
                        priceBook = priceBook - discount;
                    }
                    if (numOfPackets >= 40 && numOfPackets <= 49)
                    {
                        discount = (8 / 100m) * priceBook;
                        priceBook = priceBook - discount;
                    }
                    if (numOfPackets >= 50 && numOfPackets <= 59)
                    {
                        discount = (9 / 100m) * priceBook;
                        priceBook = priceBook - discount;
                    }
                    if (numOfPackets >= 60 && numOfPackets <= 69)
                    {
                        discount = (1 / 10m) * priceBook;
                        priceBook = priceBook - discount;
                    }
                    if (numOfPackets >= 70 && numOfPackets <= 79)
                    {
                        discount = (11 / 100m) * priceBook;
                        priceBook = priceBook - discount;
                    }
                    if (numOfPackets >= 80 && numOfPackets <= 89)
                    {
                        discount = (12/ 100m) * priceBook;
                        priceBook = priceBook - discount;
                    }
                    if (numOfPackets >= 90 && numOfPackets <= 99)
                    {
                        discount = (13 / 100m) * priceBook;
                        priceBook = priceBook - discount;
                    }
                    if (numOfPackets >= 100 && numOfPackets <= 109)
                    {
                        discount = (14 / 100m) * priceBook;
                        priceBook = priceBook - discount;
                    }
                    if (numOfPackets >= 110)
                    {
                        discount = (15 / 100m) * priceBook;
                        priceBook = priceBook - discount;
                    }
                    #endregion

                    decimal priceFinal = numOfPackets * booksPerPacket * priceBook;
                    int books = numOfPackets * booksPerPacket;

                    boughtBooks.Add(books);
                    price.Add(priceFinal);
                
            }
            decimal sumPrice = price.Sum();
            decimal sumBooks = boughtBooks.Sum();
            Console.WriteLine(sumBooks);
            Console.WriteLine("{0:00.00}",sumPrice);
        }
