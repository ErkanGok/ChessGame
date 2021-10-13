using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class WhiteBoard : IBoard
    {

        public WhiteBoard() { }

        ~WhiteBoard() { }

        public void ScoreCalculate(string[,] Board)
        {
            #region Değişkenler

            // Not: ~flag değişkenleri ayı satır ve sütun üzerinden tekrar tekrar geçmesini önlemek için
            // Not: State~ değişkenleri tehtid durumunda yer alan taşların sayısını belirlemek için
            // Not: ~Ñumber değişkenleri Tahta da yer alan siyah taşların sayısını belirlemek için puan hesaplamada kullanıldı

            int Yflag = 0;
            int Dflag = 0;
            int Rflag = 0;
            int Lflag = 0;

            int StateP = 0;
            int StateF = 0;
            int StateA = 0;
            int StateV = 0;
            int StateK = 0;
            int StateS = 0;

            int PNumber = 0;
            int FNumber = 0;
            int ANumber = 0;
            int VNumber = 0;
            int KNumber = 0;
            int SNumber = 0;

            #endregion

            #region Tahtada yer alan tehtid durumunda veya serbest durumda olan siyah taşların sayısını bulmak için

            for (int row = 8; row < 20; row++)
            {
                for (int column = 8; column < 20; column++)
                {
                    if (Board[row, column] == "ps")
                    {
                        PNumber++;
                    }
                    else if (Board[row, column] == "fs")
                    {
                        FNumber++;
                    }
                    else if (Board[row, column] == "as")
                    {
                        ANumber++;
                    }
                    else if (Board[row, column] == "vs")
                    {
                        VNumber++;
                    }
                    else if (Board[row, column] == "ks")
                    {
                        KNumber++;
                    }
                    else if (Board[row, column] == "ss")
                    {
                        SNumber++;
                    }
                }
            }
            #endregion

            #region Beyaz At,Beyaz Piyon ve Beyaz Vezirin siyah taşları tehtid ettiği durumların belirlenmesi
            for (int row = 8; row < 20; row++)
            {
                for (int column = 8; column < 20; column++)
                {
                    #region Beyaz At tehtid etme Durumları
                    
                    if (Board[row, column] == "ab" && Board[row - 2, column - 1] == "ps")
                    {
                        StateP++;
                        Board[row - 2, column - 1] = "";

                    }

                    if (Board[row, column] == "ab" && Board[row - 2, column + 1] == "ps")
                    {
                        StateP++;
                        Board[row - 2, column + 1] = "";
                    }

                    if (Board[row, column] == "ab" && Board[row - 1, column - 2] == "ps")
                    {
                        StateP++;
                        Board[row - 1, column - 2] = "";
                    }

                    if (Board[row, column] == "ab" && Board[row + 1, column - 2] == "ps")
                    {
                        StateP++;
                        Board[row + 1, column - 2] = "";
                    }


                    if (Board[row, column] == "ab" && Board[row + 2, column - 1] == "ps")
                    {
                        StateP++;
                        Board[row + 2, column - 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 2, column + 1] == "ps")
                    {
                        StateP++;
                        Board[row + 2, column + 1] = "";
                    }

                    if (Board[row, column] == "ab" && Board[row - 1, column + 2] == "ps")
                    {
                        StateP++;
                        Board[row - 1, column + 2] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 1, column + 2] == "ps")
                    {
                        StateP++;
                        Board[row + 1, column + 2] = "";
                    }

                    //=====================================================

                    if (Board[row, column] == "ab" && Board[row - 2, column - 1] == "as")
                    {
                        StateA++;
                        Board[row - 2, column - 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row - 2, column + 1] == "as")
                    {
                        StateA++;
                        Board[row - 2, column + 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row - 1, column - 2] == "as")
                    {
                        StateA++;
                        Board[row - 1, column - 2] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 1, column - 2] == "as")
                    {
                        StateA++;
                        Board[row + 1, column - 2] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 2, column - 1] == "as")
                    {
                        StateA++;
                        Board[row + 2, column - 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 2, column + 1] == "as")
                    {
                        StateA++;
                        Board[row + 2, column + 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row - 1, column + 2] == "as")
                    {
                        StateA++;
                        Board[row - 1, column + 2] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 1, column + 2] == "as")
                    {
                        StateA++;
                        Board[row + 1, column + 2] = "";
                    }

                    //=====================================================

                    if (Board[row, column] == "ab" && Board[row - 2, column - 1] == "fs")
                    {
                        StateF++;
                        Board[row - 2, column - 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row - 2, column + 1] == "fs")
                    {
                        StateF++;
                        Board[row - 2, column + 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row - 1, column - 2] == "fs")
                    {
                        StateF++;
                        Board[row - 1, column - 2] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 1, column - 2] == "fs")
                    {
                        StateF++;
                        Board[row + 1, column - 2] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 2, column - 1] == "fs")
                    {
                        StateF++;
                        Board[row + 2, column - 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 2, column + 1] == "fs")
                    {
                        StateF++;
                        Board[row + 2, column + 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row - 1, column + 2] == "fs")
                    {
                        StateF++;
                        Board[row - 1, column + 2] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 1, column + 2] == "fs")
                    {
                        StateF++;
                        Board[row + 1, column + 2] = "";
                    }

                    //=====================================================


                    if (Board[row, column] == "ab" && Board[row - 2, column - 1] == "ks")
                    {
                        StateK++;
                        Board[row - 2, column - 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row - 2, column + 1] == "ks")
                    {
                        StateK++;
                        Board[row - 2, column + 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row - 1, column - 2] == "ks")
                    {
                        StateK++;
                        Board[row - 1, column - 2] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 1, column - 2] == "ks")
                    {
                        StateK++;
                        Board[row + 1, column - 2] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 2, column - 1] == "ks")
                    {
                        StateK++;
                        Board[row + 2, column - 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 2, column + 1] == "ks")
                    {
                        StateK++;
                        Board[row + 2, column + 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row - 1, column + 2] == "ks")
                    {
                        StateK++;
                        Board[row - 1, column + 2] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 1, column + 2] == "ks")
                    {
                        StateK++;
                        Board[row + 1, column + 2] = "";
                    }

                    //=====================================================


                    if (Board[row, column] == "ab" && Board[row - 2, column - 1] == "vs")
                    {
                        StateV++;
                        Board[row - 2, column - 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row - 2, column + 1] == "vs")
                    {
                        StateV++;
                        Board[row - 2, column + 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row - 1, column - 2] == "vs")
                    {
                        StateV++;
                        Board[row - 1, column - 2] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 1, column - 2] == "vs")
                    {
                        StateV++;
                        Board[row + 1, column - 2] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 2, column - 1] == "vs")
                    {
                        StateV++;
                        Board[row + 2, column - 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 2, column + 1] == "vs")
                    {
                        StateV++;
                        Board[row + 2, column + 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row - 1, column + 2] == "vs")
                    {
                        StateV++;
                        Board[row - 1, column + 2] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 1, column + 2] == "vs")
                    {
                        StateV++;
                        Board[row + 1, column + 2] = "";
                    }

                    //=====================================================


                    if (Board[row, column] == "ab" && Board[row - 2, column - 1] == "ss")
                    {
                        StateS++;
                        Board[row - 2, column - 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row - 2, column + 1] == "ss")
                    {
                        StateS++;
                        Board[row - 2, column + 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row - 1, column - 2] == "ss")
                    {
                        StateS++;
                        Board[row - 1, column - 2] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 1, column - 2] == "ss")
                    {
                        StateS++;
                        Board[row + 1, column - 2] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 2, column - 1] == "ss")
                    {
                        StateS++;
                        Board[row + 2, column - 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 2, column + 1] == "ss")
                    {
                        StateS++;
                        Board[row + 2, column + 1] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row - 1, column + 2] == "ss")
                    {
                        StateS++;
                        Board[row - 1, column + 2] = "";
                    }
                    if (Board[row, column] == "ab" && Board[row + 1, column + 2] == "ss")
                    {
                        StateS++;
                        Board[row + 1, column + 2] = "";
                    }

                    #endregion

                    #region Beyaz Piyon Tehtid etme Durumları
                    

                    if (Board[row, column] == "pb" && Board[row - 1, column - 1] == "ps")
                    {
                        StateP++;
                        Board[row - 1, column - 1] = "";
                    }

                    if (Board[row, column] == "pb" && Board[row - 1, column + 1] == "ps")
                    {
                        StateP++;
                        Board[row - 1, column + 1] = "";
                    }

                    //=====================================================

                    if (Board[row, column] == "pb" && Board[row - 1, column - 1] == "as")
                    {
                        StateA++;
                        Board[row - 1, column - 1] = "";
                    }

                    if (Board[row, column] == "pb" && Board[row - 1, column + 1] == "as")
                    {
                        StateA++;
                        Board[row - 1, column + 1] = "";
                    }

                    //=====================================================

                    if (Board[row, column] == "pb" && Board[row - 1, column - 1] == "fs")
                    {
                        StateF++;
                        Board[row - 1, column - 1] = "";
                    }

                    if (Board[row, column] == "pb" && Board[row - 1, column + 1] == "fs")
                    {
                        StateF++;
                        Board[row - 1, column + 1] = "";
                    }

                    //=====================================================

                    if (Board[row, column] == "pb" && Board[row - 1, column - 1] == "ks")
                    {
                        StateK++;
                        Board[row - 1, column - 1] = "";
                    }

                    if (Board[row, column] == "pb" && Board[row - 1, column + 1] == "ks")
                    {
                        StateK++;
                        Board[row - 1, column + 1] = "";
                    }

                    //=====================================================

                    if (Board[row, column] == "pb" && Board[row - 1, column - 1] == "vs")
                    {
                        StateV++;
                        Board[row - 1, column - 1] = "";
                    }

                    if (Board[row, column] == "pb" && Board[row - 1, column + 1] == "vs")
                    {
                        StateV++;
                        Board[row - 1, column + 1] = "";
                    }

                    //=====================================================

                    if (Board[row, column] == "pb" && Board[row - 1, column + 1] == "ss")
                    {
                        StateS++;
                        Board[row - 1, column + 1] = "";
                    }
                    if (Board[row, column] == "pb" && Board[row - 1, column + 1] == "ss")
                    {
                        StateS++;
                        Board[row - 1, column + 1] = "";
                    }
                    #endregion

                    #region Beyaz Vezirin tehtid etme durumlarında çapraz durumlarına erişim için columneni bir loop oluşturuldu

                    //Not : t değişkeni cross indisini ifade etmektedir

                    for (int t = 1; t <= 7; t++)
                    {
                        if (Board[row, column] == "vb" && Board[row + t, column] == "ps" && Board[row + t - 1, column] != "pb" && Board[row + t - 1, column] != "fb" && Board[row + t - 1, column] != "ab" && Board[row + t - 1, column] != "vb" && Board[row + t - 1, column] != "kb" && Board[row +  - 1, column] != "sb" && Dflag != 1)
                        {
                            StateP++;
                            Dflag = 1;
                            Board[row + t, column] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row - t + 1, column] == "ps" && Board[row - t + 1, column] != "pb" && Board[row - t + 1, column] != "fb" && Board[row - t + 1, column] != "ab" && Board[row - t + 1, column] != "vb" && Board[row - t + 1, column] != "kb" && Board[row - t + 1, column] != "sb" && Dflag != 1) // dikecolumn picolumnon
                        {
                            StateP++;
                            Dflag = 1;
                            Board[row - t + 1, column] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row, column - t] == "ps" && Board[row, column - t + 1] != "pb" && Board[row, column - t + 1] != "fb" && Board[row, column - t + 1] != "ab" && Board[row, column - t + 1] != "vb" && Board[row, column - t + 1] != "kb" && Board[row, column - t + 1] != "sb" && Yflag != 1)
                        {
                            StateP++;
                            Yflag = 1;
                            Board[row, column - t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row, column + t] == "ps" && Board[row, column + t - 1] != "pb" && Board[row, column + t - 1] != "fb" && Board[row, column + t - 1] != "ab" && Board[row, column + t - 1] != "vb" && Board[row, column + t - 1] != "kb" && Board[row, column + t - 1] != "sb" && Yflag != 1) // columnatacolumn picolumnon
                        {
                            StateP++;
                            Yflag = 1;
                            Board[row, column + t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row + t, column - t] == "ps" && Board[row + t - 1, column - t + 1] != "pb" && Board[row + t - 1, column - t + 1] != "fb" && Board[row + t - 1, column - t + 1] != "ab" && Board[row + t - 1, column - t + 1] != "kb" && Board[row + t - 1, column - t + 1] != "sb" && Board[row + t - 1, column - t + 1] != "ss" && Rflag != 1)
                        {
                            StateP++;
                            Rflag = 1;
                            Board[row + t, column - t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row - t, column + t] == "ps" && Board[row - t + 1, column + t - 1] != "pb" && Board[row - t + 1, column + t - 1] != "fb" && Board[row - t + 1, column + t - 1] != "ab" && Board[row - t + 1, column + t - 1] != "kb" && Board[row - t + 1, column + t - 1] != "sb" && Board[row - t + 1, column + t - 1] != "ss" && Rflag != 1) // sağ çapraz picolumnon
                        {
                            StateP++;
                            Rflag = 1;
                            Board[row - t, column + t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row - t, column - t] == "ps" && Board[row - t + 1, column - t + 1] != "pb" && Board[row - t + 1, column - t + 1] != "fb" && Board[row - t + 1, column - t + 1] != "ab" && Board[row - t + 1, column - t + 1] != "kb" && Board[row - t + 1, column - t + 1] != "sb" && Board[row - t + 1, column - t + 1] != "ss" && Lflag != 1)
                        {
                            StateP++;
                            Lflag = 1;
                            Board[row - t, column - t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row + t, column + t] == "ps" && Board[row + t - 1, column + t - 1] != "pb" && Board[row + t - 1, column + t - 1] != "fb" && Board[row + t - 1, column + t - 1] != "ab" && Board[row + t - 1, column + t - 1] != "kb" && Board[row + t - 1, column + t - 1] != "sb" && Board[row + t - 1, column + t - 1] != "ss" && Lflag != 1) // sol çapraz çapraz picolumnon
                        {
                            StateP++;
                            Lflag = 1;
                            Board[row + t, column + t] = "";
                        }

                        //==========================================================================================================================================================================================================================================================================================================================================================================

                        if (Board[row, column] == "vb" && Board[row - t, column] == "fs" && Board[row - t + 1, column] != "pb" && Board[row - t + 1, column] != "fb" && Board[row - t + 1, column] != "ab" && Board[row - t + 1, column] != "vb" && Board[row - t + 1, column] != "kb" && Board[row - t + 1, column] != "sb" && Dflag != 1)
                        {
                            StateF++;
                            Dflag = 1;
                            Board[row - t, column] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row + t, column] == "fs" && Board[row + t - 1, column] != "pb" && Board[row + t - 1, column] != "fb" && Board[row + t - 1, column] != "ab" && Board[row + t - 1, column] != "vb" && Board[row + t - 1, column] != "kb" && Board[row + t - 1, column] != "sb" && Dflag != 1) // dikecolumn picolumnon
                        {
                            StateF++;
                            Dflag = 1;
                            Board[row + t, column] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row, column - t] == "fs" && Board[row, column - t + 1] != "pb" && Board[row, column - t + 1] != "fb" && Board[row, column - t + 1] != "ab" && Board[row, column - t + 1] != "vb" && Board[row, column - t + 1] != "kb" && Board[row, column - t + 1] != "sb" && Yflag != 1)
                        {
                            StateF++;
                            Yflag = 1;
                            Board[row, column - t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row, column + t] == "fs" && Board[row, column + t - 1] != "pb" && Board[row, column + t - 1] != "fb" && Board[row, column + t - 1] != "ab" && Board[row, column + t - 1] != "vb" && Board[row, column + t - 1] != "kb" && Board[row, column + t - 1] != "sb" && Yflag != 1) // columnatacolumn picolumnon
                        {
                            StateF++;
                            Yflag = 1;
                            Board[row, column + t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row + t, column - t] == "fs" && Board[row + t - 1, column - t + 1] != "pb" && Board[row + t - 1, column - t + 1] != "fb" && Board[row + t - 1, column - t + 1] != "ab" && Board[row + t - 1, column - t + 1] != "vb" && Board[row + t - 1, column - t + 1] != "kb" && Board[row + t - 1, column - t + 1] != "sb" && Rflag != 1)
                        {
                            StateF++;
                            Rflag = 1;
                            Board[row + t, column - t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row - t, column + t] == "fs" && Board[row - t + 1, column + t - 1] != "pb" && Board[row + t - 1, column - t + 1] != "fb" && Board[row + t - 1, column - t + 1] != "ab" && Board[row + t - 1, column - t + 1] != "vb" && Board[row + t - 1, column - t + 1] != "kb" && Board[row + t - 1, column - t + 1] != "sb" && Rflag != 1) // sağ çapraz picolumnon
                        {
                            StateF++;
                            Rflag = 1;
                            Board[row - t, column + t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row + t, column + t] == "fs" && Board[row + t - 1, column + t - 1] != "pb" && Board[row + t - 1, column + t - 1] != "fb" && Board[row + t - 1, column + t - 1] != "ab" && Board[row + t - 1, column + t - 1] != "vb" && Board[row + t - 1, column + t - 1] != "kb" && Board[row + t - 1, column + t - 1] != "sb" && Lflag != 1)
                        {
                            StateF++;
                            Lflag = 1;
                            Board[row + t, column + t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row - t, column - t] == "fs" && Board[row - t + 1, column - t + 1] != "pb" && Board[row - t + 1, column - t + 1] != "fb" && Board[row - t + 1, column - t + 1] != "ab" && Board[row - t + 1, column - t + 1] != "vb" && Board[row - t + 1, column - t + 1] != "kb" && Board[row - t + 1, column - t + 1] != "sb" && Lflag != 1) // sol çapraz çapraz picolumnon
                        {
                            StateF++;
                            Lflag = 1;
                            Board[row - t, column - t] = "";
                        }

                        //==========================================================================================================================================================================================================================================================================================================================================================================

                        if (Board[row, column] == "vb" && Board[row - t, column] == "as" && Board[row - t + 1, column] != "pb" && Board[row - t + 1, column] != "fb" && Board[row - t + 1, column] != "ab" && Board[row - t + 1, column] != "vb" && Board[row - t + 1, column] != "kb" && Board[row - t + 1, column] != "sb" && Dflag != 1)
                        {
                            StateA++;
                            Dflag = 1;
                            Board[row - t, column] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row + t, column] == "as" && Board[row + t - 1, column] != "pb" && Board[row + t - 1, column] != "fb" && Board[row + t - 1, column] != "ab" && Board[row + t - 1, column] != "vb" && Board[row + t - 1, column] != "kb" && Board[row + t - 1, column] != "sb" && Dflag != 1) // dikecolumn picolumnon
                        {
                            StateA++;
                            Dflag = 1;
                            Board[row + t, column] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row, column - t] == "as" && Board[row, column - t + 1] != "pb" && Board[row, column - t + 1] != "fb" && Board[row, column - t + 1] != "ab" && Board[row, column - t + 1] != "vb" && Board[row, column - t + 1] != "kb" && Board[row, column - t + 1] != "sb" && Yflag != 1)
                        {
                            StateA++;
                            Yflag = 1;
                            Board[row, column - t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row, column + t] == "as" && Board[row, column + t - 1] != "pb" && Board[row, column + t - 1] != "fb" && Board[row, column + t - 1] != "ab" && Board[row, column + t - 1] != "vb" && Board[row, column + t - 1] != "kb" && Board[row, column + t - 1] != "sb" && Yflag != 1) // columnatacolumn picolumnon
                        {
                            StateA++;
                            Yflag = 1;
                            Board[row, column + t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row + t, column - t] == "as" && Board[row + t - 1, column - t + 1] != "pb" && Board[row + t - 1, column - t + 1] != "fb" && Board[row + t - 1, column - t + 1] != "ab" && Board[row + t - 1, column - t + 1] != "vb" && Board[row + t - 1, column - t + 1] != "kb" && Board[row + t - 1, column - t + 1] != "sb" && Rflag != 1) // sağ çapraz picolumnon
                        {
                            StateA++;
                            Rflag = 1;
                            Board[row + t, column - t] = "";
                        }

                        if (Board[row, column] == "vb" && Board[row - t, column + t] == "as" && Board[row - t + 1, column + t - 1] != "pb" && Board[row - t + 1, column + t - 1] != "fb" && Board[row - t + 1, column + t - 1] != "ab" && Board[row - t + 1, column + t - 1] != "vb" && Board[row - t + 1, column + t - 1] != "kb" && Board[row - t + 1, column + t - 1] != "sb" && Rflag != 1)
                        {
                            StateA++;
                            Rflag = 1;
                            Board[row - t, column + t] = "";
                        }

                        if (Board[row, column] == "vb" && Board[row + t, column + t] == "as" && Board[row + t - 1, column + t - 1] != "pb" && Board[row + t - 1, column + t - 1] != "fb" && Board[row + t - 1, column + t - 1] != "ab" && Board[row + t - 1, column + t - 1] != "vb" && Board[row + t - 1, column + t - 1] != "kb" && Board[row + t - 1, column + t - 1] != "sb" && Lflag != 1) // sol çapraz çapraz picolumnon
                        {
                            StateA++;
                            Lflag = 1;
                            Board[row + t, column + t] = "";
                        }

                        if (Board[row, column] == "vb" && Board[row - t, column - t] == "as" && Board[row - t + 1, column - t + 1] != "pb" && Board[row - t + 1, column - t + 1] != "fb" && Board[row - t + 1, column - t + 1] != "ab" && Board[row - t + 1, column - t + 1] != "vs" && Board[row - t + 1, column - t + 1] != "ks" && Board[row - t + 1, column - t + 1] != "sb" && Lflag != 1)
                        {
                            StateA++;
                            Lflag = 1;
                            Board[row - t, column - t] = "";
                        }

                        //==========================================================================================================================================================================================================================================================================================================================================================================

                        if (Board[row, column] == "vb" && Board[row - t, column] == "vs" && Board[row - t + 1, column] != "pb" && Board[row - t + 1, column] != "fb" && Board[row - t + 1, column] != "ab" && Board[row - t + 1, column] != "vb" && Board[row - t + 1, column] != "kb" && Board[row - t + 1, column] != "sb" && Dflag != 1)
                        {
                            StateV++;
                            Dflag = 1;
                            Board[row - t, column] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row + t, column] == "vs" && Board[row + t - 1, column] != "pb" && Board[row + t - 1, column] != "fb" && Board[row + t - 1, column] != "ab" && Board[row + t - 1, column] != "vb" && Board[row + t - 1, column] != "kb" && Board[row + t - 1, column] != "sb" && Dflag != 1) // dikecolumn picolumnon
                        {
                            StateV++;
                            Dflag = 1;
                            Board[row + t, column] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row, column - t] == "vs" && Board[row, column - t + 1] != "pb" && Board[row, column - t + 1] != "fb" && Board[row, column - t + 1] != "ab" && Board[row, column - t + 1] != "vb" && Board[row, column - t + 1] != "kb" && Board[row, column - t + 1] != "sb" && Yflag != 1)
                        {
                            StateV++;
                            Yflag = 1;
                            Board[row, column - t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row, column + t] == "vs" && Board[row, column + t - 1] != "pb" && Board[row, column + t - 1] != "fb" && Board[row, column + t - 1] != "ab" && Board[row, column + t - 1] != "vb" && Board[row, column + t - 1] != "kb" && Board[row, column + t - 1] != "sb" && Yflag != 1) // columnatacolumn picolumnon
                        {
                            StateV++;
                            Yflag = 1;
                            Board[row, column + t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row + t, column - t] == "vs" && Board[row + t - 1, column - t + 1] != "pb" && Board[row + t - 1, column - t + 1] != "fb" && Board[row + t - 1, column - t + 1] != "ab" && Board[row + t - 1, column - t + 1] != "vb" && Board[row + t - 1, column - t + 1] != "kb" && Board[row + t - 1, column - t + 1] != "sb" && Rflag != 1)
                        {
                            StateV++;
                            Rflag = 1;
                            Board[row + t, column - t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row - t, column + t] == "vs" && Board[row - t + 1, column + t - 1] != "pb" && Board[row - t + 1, column + t - 1] != "fb" && Board[row - t + 1, column + t - 1] != "ab" && Board[row - t + 1, column + t - 1] != "vb" && Board[row - t + 1, column + t - 1] != "kb" && Board[row - t + 1, column + t - 1] != "sb" && Rflag != 1) // sağ çapraz picolumnon
                        {
                            StateV++;
                            Rflag = 1;
                            Board[row - t, column + t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row + t, column + t] == "vs" && Board[row + t - 1, column + t - 1] != "pb" && Board[row + t - 1, column + t - 1] != "fb" && Board[row + t - 1, column + t - 1] != "ab" && Board[row + t - 1, column + t - 1] != "vb" && Board[row + t - 1, column + t - 1] != "kb" && Board[row + t - 1, column + t - 1] != "sb" && Lflag != 1)
                        {
                            StateV++;
                            Lflag = 1;
                            Board[row + t, column + t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row - t, column - t] == "vs" && Board[row - t + 1, column - t + 1] != "pb" && Board[row - t + 1, column - t + 1] != "fb" && Board[row - t + 1, column - t + 1] != "ab" && Board[row - t + 1, column - t + 1] != "vb" && Board[row - t + 1, column - t + 1] != "kb" && Board[row - t + 1, column - t + 1] != "sb" && Lflag != 1) // sol çapraz çapraz picolumnon
                        {
                            StateV++;
                            Lflag = 1;
                            Board[row - t, column - t] = "";
                        }

                        //==========================================================================================================================================================================================================================================================================================================================================================================

                        if (Board[row, column] == "vb" && Board[row - t, column] == "ks" && Board[row - t + 1, column] != "pb" && Board[row - t + 1, column] != "fb" && Board[row - t + 1, column] != "ab" && Board[row - t + 1, column] != "vb" && Board[row - t + 1, column] != "kb" && Board[row - t + 1, column] != "sb" && Dflag != 1)
                        {
                            StateK++;
                            Dflag = 1;
                            Board[row - t, column] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row + t - 1, column] == "ks" && Board[row + t - 1, column] != "pb" && Board[row + t - 1, column] != "fb" && Board[row + t - 1, column] != "ab" && Board[row + t - 1, column] != "vb" && Board[row + t - 1, column] != "kb" && Board[row + t - 1, column] != "sb" && Dflag != 1) // dikecolumn picolumnon
                        {
                            StateK++;
                            Dflag = 1;
                            Board[row + t - 1, column] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row, column - t] == "ks" && Board[row, column - t + 1] != "pb" && Board[row, column - t + 1] != "fb" && Board[row, column - t + 1] != "ab" && Board[row, column - t + 1] != "vb" && Board[row, column - t + 1] != "kb" && Board[row, column - t + 1] != "sb" && Yflag != 1)
                        {
                            StateK++;
                            Yflag = 1;
                            Board[row, column - t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row, column + t] == "ks" && Board[row, column + t - 1] != "pb" && Board[row, column + t - 1] != "fb" && Board[row, column + t - 1] != "ab" && Board[row, column + t - 1] != "vb" && Board[row, column + t - 1] != "kb" && Board[row, column + t - 1] != "sb" && Yflag != 1) // columnatacolumn picolumnon
                        {
                            StateK++;
                            Yflag = 1;
                            Board[row, column + t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row + t, column - t] == "ks" && Board[row + t - 1, column - t + 1] != "pb" && Board[row + t - 1, column - t + 1] != "fb" && Board[row + t - 1, column - t + 1] != "ab" && Board[row + t - 1, column - t + 1] != "vb" && Board[row + t - 1, column - t + 1] != "kb" && Board[row + t - 1, column - t + 1] != "sb" && Rflag != 1)
                        {
                            StateK++;
                            Rflag = 1;
                            Board[row + t, column - t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row - t, column + t] == "ks" && Board[row - t + 1, column + t - 1] != "pb" && Board[row - t + 1, column + t - 1] != "fb" && Board[row - t + 1, column + t - 1] != "ab" && Board[row - t + 1, column + t - 1] != "vb" && Board[row - t + 1, column + t - 1] != "kb" && Board[row - t + 1, column + t - 1] != "sb" && Rflag != 1) // sağ çapraz picolumnon
                        {
                            StateK++;
                            Rflag = 1;
                            Board[row - t, column + t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row + t, column + t] == "ks" && Board[row + t - 1, column + t - 1] != "pb" && Board[row + t - 1, column + t - 1] != "fb" && Board[row + t - 1, column + t - 1] != "ab" && Board[row + t - 1, column + t - 1] != "vb" && Board[row + t - 1, column + t - 1] != "kb" && Board[row + t - 1, column + t - 1] != "sb" && Lflag != 1)
                        {
                            StateK++;
                            Lflag = 1;
                            Board[row + t, column + t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row - t, column - t] == "ks" && Board[row - t + 1, column - t + 1] != "pb" && Board[row - t + 1, column - t + 1] != "fb" && Board[row - t + 1, column - t + 1] != "ab" && Board[row - t + 1, column - t + 1] != "vb" && Board[row - t + 1, column - t + 1] != "kb" && Board[row - t + 1, column - t + 1] != "sb" && Lflag != 1) // sol çapraz çapraz picolumnon
                        {
                            StateK++;
                            Lflag = 1;
                            Board[row - t, column - t] = "";
                        }

                        //==========================================================================================================================================================================================================================================================================================================================================================================

                        if (Board[row, column] == "vb" && Board[row - t, column] == "ss" && Board[row - t + 1, column] != "pb" && Board[row - t + 1, column] != "fb" && Board[row - t + 1, column] != "ab" && Board[row - t + 1, column] != "vb" && Board[row - t + 1, column] != "kb" && Board[row - t + 1, column] != "sb" && Dflag != 1)
                        {
                            StateS++;
                            Dflag = 1;
                            Board[row - t, column] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row + t, column] == "ss" && Board[row + t - 1, column] != "pb" && Board[row + t - 1, column] != "fb" && Board[row + t - 1, column] != "ab" && Board[row + t - 1, column] != "vb" && Board[row + t - 1, column] != "kb" && Board[row + t - 1, column] != "sb" && Dflag != 1) // dikecolumn picolumnon
                        {
                            StateS++;
                            Dflag = 1;
                            Board[row + t, column] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row, column - t] == "ss" && Board[row, column - t + 1] != "pb" && Board[row, column - t + 1] != "fb" && Board[row, column - t + 1] != "ab" && Board[row, column - t + 1] != "vb" && Board[row, column - t + 1] != "kb" && Board[row, column - t + 1] != "sb" && Yflag != 1)
                        {
                            StateS++;
                            Yflag = 1;
                            Board[row, column - t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row, column + t] == "ss" && Board[row, column + t - 1] != "pb" && Board[row, column + t - 1] != "fb" && Board[row, column + t - 1] != "ab" && Board[row, column + t - 1] != "vb" && Board[row, column + t - 1] != "kb" && Board[row, column + t - 1] != "sb" && Yflag != 1) // columnatacolumn picolumnon
                        {
                            StateS++;
                            Yflag = 1;
                            Board[row, column + t] = "";

                        }
                        if (Board[row, column] == "vb" && Board[row + t, column - t] == "ss" && Board[row + t - 1, column - t + 1] != "pb" && Board[row + t - 1, column - t + 1] != "fb" && Board[row + t - 1, column - t + 1] != "ab" && Board[row + t - 1, column - t + 1] != "vb" && Board[row + t - 1, column - t + 1] != "kb" && Board[row + t - 1, column - t + 1] != "sb" && Rflag != 1)
                        {
                            StateS++;
                            Rflag = 1;
                            Board[row + t, column - t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row - t, column + t] == "ss" && Board[row - t + 1, column + t - 1] != "pb" && Board[row - t + 1, column + t - 1] != "fb" && Board[row - t + 1, column + t - 1] != "ab" && Board[row - t + 1, column + t - 1] != "vb" && Board[row - t + 1, column + t - 1] != "kb" && Board[row - t + 1, column + t - 1] != "sb" && Rflag != 1) // sağ çapraz picolumnon
                        {
                            StateS++;
                            Rflag = 1;
                            Board[row - t, column + t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row + t, column + t] == "ss" && Board[row + t - 1, column + t - 1] != "pb" && Board[row + t - 1, column + t - 1] != "fb" && Board[row + t - 1, column + t - 1] != "ab" && Board[row + t - 1, column + t - 1] != "vb" && Board[row + t - 1, column + t - 1] != "kb" && Board[row + t - 1, column + t - 1] != "sb" && Lflag != 1)
                        {
                            StateS++;
                            Lflag = 1;
                            Board[row + t, column + t] = "";
                        }
                        if (Board[row, column] == "vb" && Board[row - t, column - t] == "ss" && Board[row - t + 1, column - t + 1] != "pb" && Board[row - t + 1, column - t + 1] != "fb" && Board[row - t + 1, column - t + 1] != "ab" && Board[row - t + 1, column - t + 1] != "vb" && Board[row - t + 1, column - t + 1] != "kb" && Board[row - t + 1, column - t + 1] != "ss" && Lflag != 1) // sol çapraz çapraz picolumnon
                        {
                            StateS++;
                            Lflag = 1;
                            Board[row - t, column - t] = "";
                        }

                    }
                    #endregion
                }
            }

            #endregion

            #region Tehtid veya serbest durumda olan siyah taşların Hesaplama ve yazdırma işlemleri

            //Siyahın Puanı hesaplamak için
            double PPoint = (StateP * 0.5) + ((PNumber - StateP) * 1);
            double APoint = (StateA * 1.5) + ((ANumber - StateA) * 3);
            double FPoint = (StateF * 1.5) + ((FNumber - StateF) * 3);
            double KPoint = (StateK * 2.5) + ((KNumber - StateK) * 5);
            double VPoint = (StateV * 4.5) + ((VNumber - StateV) * 9);
            double SPoint = (StateS * 50) + ((SNumber - StateS) * 100);            
            Console.WriteLine("Siyah : {0}" ,PPoint + APoint + FPoint + KPoint + VPoint + SPoint);
            #endregion
        }
    }
}

