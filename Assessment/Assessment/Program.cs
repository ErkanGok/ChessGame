using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Assessment
{
    class Program
    {


        static void Main(string[] args)
        {
            
            #region Dosyadan Okuma İşlemleri

            // Uyarı : bu kısım okuma yapılacak dosyaların bulunduğu dizine göre düzenlenmesi gerekmektedir !!!!!

            String input1 = File.ReadAllText(@"C:\Users\Erkan\Desktop\Assessment\Assessment\board1.txt");
            String input2 = File.ReadAllText(@"C:\Users\Erkan\Desktop\Assessment\Assessment\board2.txt");
            String input3 = File.ReadAllText(@"C:\Users\Erkan\Desktop\Assessment\Assessment\board3.txt");
            #endregion

            #region Değişkenler Her input değeri için satır ve sutün değerleri
            int row1 = 8, column1 = 8;
            int row2 = 8, column2 = 8;

            int row3 = 8, column3 = 8;
            int row4 = 8, column4 = 8;

            int row5 = 8, column5 = 8;
            int row6 = 8, column6 = 8;

            string[,] resultW1 = new string[20, 20];
            string[,] resultB1 = new string[20, 20];

            string[,] resultW2 = new string[20, 20];
            string[,] resultB2 = new string[20, 20];

            string[,] resultW3 = new string[20, 20];
            string[,] resultB3 = new string[20, 20];
            #endregion

            #region board1.txt dosyası için multiple arrayin içerisini doldurma işlemi
            foreach (var row in input1.Split('\n'))
            {
                column1 = 8;
                foreach (var col in row.Trim().Split(' '))
                {
                    resultW1[row1, column1] = col.Trim();
                    column1++;
                }
                row1++;
            }

            foreach (var row in input1.Split('\n'))
            {
                column2 = 8;
                foreach (var col in row.Trim().Split(' '))
                {
                    resultB1[row2, column2] = col.Trim();
                    column2++;
                }
                row2++;
            }
            #endregion


            #region board2.txt dosyası için multiple arrayin içerisini doldurma işlemi
            foreach (var row in input2.Split('\n'))
            {
                column3 = 8;
                foreach (var col in row.Trim().Split(' '))
                {
                    resultW2[row3, column3] = col.Trim();
                    column3++;
                }
                row3++;
            }

            foreach (var row in input2.Split('\n'))
            {
                column4 = 8;
                foreach (var col in row.Trim().Split(' '))
                {
                    resultB2[row4, column4] = col.Trim();
                    column4++;
                }
                row4++;
            }
            #endregion


            #region board3.txt dosyası için multiple arrayin içerisini doldurma işlemi
            foreach (var row in input3.Split('\n'))
            {
                column5 = 8;
                foreach (var col in row.Trim().Split(' '))
                {
                    resultW3[row5, column5] = col.Trim();
                    column5++;
                }
                row5++;
            }

            foreach (var row in input3.Split('\n'))
            {
                column6 = 8;
                foreach (var col in row.Trim().Split(' '))
                {
                    resultB3[row6, column6] = col.Trim();
                    column6++;
                }
                row6++;
            }

            #endregion            


            Console.WriteLine("=====SONUÇLAR=====" + "\n");

            #region board1.txt için nesne oluşturma ve sonucu ekrana yazma işlemleri 

            //not: beyaz için ayrı siyah için ayrı sonuçlar tablolar oluşturularak hesaplama yapılmaktadır

            Console.WriteLine("board1.txt");
            WhiteBoard whiteBoard1 = new WhiteBoard();
            whiteBoard1.ScoreCalculate(resultW1);
            BlackBoard blackBoard1 = new BlackBoard();
            blackBoard1.ScoreCalculate(resultB1);
            Console.WriteLine("\n");

            #endregion

            #region board2.txt için nesne oluşturma ve sonucu ekrana yazma işlemleri 

            //not: beyaz için ayrı siyah için ayrı sonuçlar tablolar oluşturularak hesaplama yapılmaktadır

            Console.WriteLine("board2.txt");
            WhiteBoard whiteBoard2 = new WhiteBoard();
            whiteBoard2.ScoreCalculate(resultW2);
            BlackBoard blackBoard2 = new BlackBoard();
            blackBoard2.ScoreCalculate(resultB2);
            Console.WriteLine("\n");

            #endregion

            #region board3.txt için nesne oluşturma ve sonucu ekrana yazma işlemleri 

            //not: beyaz için ayrı siyah için ayrı sonuçlar tablolar oluşturularak hesaplama yapılmaktadır

            Console.WriteLine("board3.txt");
            WhiteBoard whiteBoard3 = new WhiteBoard();
            whiteBoard3.ScoreCalculate(resultW3);
            BlackBoard blackBoard3 = new BlackBoard();
            blackBoard3.ScoreCalculate(resultB3);
            Console.WriteLine("\n");

            #endregion

        }
    }
}