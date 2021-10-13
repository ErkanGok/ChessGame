using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
    public class BlackBoard : IBoard
    {

        public BlackBoard() { }

        ~BlackBoard() { }

        public void ScoreCalculate(string[,] Board)
        {

            #region Değişkenler

            // Not: ~flag değişkenleri ayı satır ve sütun üzerinden tekrar tekrar geçmesini önlemek için
            // Not: State~ değişkenleri tehtid durumunda yer alan taşların sayısını belirlemek için
            // Not: ~Ñumber değişkenleri Tahta da yer alan beyaz taşların sayısını belirlemek için puan hesaplamada kullanıldı

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

            #region Tahtada yer alan tehtid durumunda veya serbest durumda olan beyaz taşların sayısını bulmak için

            for (int row = 8; row < 20; row++)
            {
                for (int column = 8; column < 20; column++)
                {
                    if (Board[row, column] == "pb")
                    {
                        PNumber++;
                    }
                    else if (Board[row, column] == "fb")
                    {
                        FNumber++;
                    }
                    else if (Board[row, column] == "ab")
                    {
                        ANumber++;
                    }
                    else if (Board[row, column] == "vb")
                    {
                        VNumber++;
                    }
                    else if (Board[row, column] == "kb")
                    {
                        KNumber++;
                    }
                    else if (Board[row, column] == "sb")
                    {
                        SNumber++;
                    }
                }
            }
            #endregion

            #region Siyah At,Siyah Piyon ve Siyah Vezirin beyaz taşları tehtid ettiği durumların belirlenmesi

            for (int row = 8; row < 20; row++)
            {
                for (int column = 8; column < 20; column++)
                {
                    #region Siyah At tehtid etme Durumları
                    if (Board[row, column] == "as" && Board[row + 2, column + 1] == "pb")
                    {
                        StateP++;
                        Board[row + 2, column + 1] = "";
                    }

                    if (Board[row, column] == "as" && Board[row + 2, column - 1] == "pb")
                    {
                        StateP++;
                        Board[row + 2, column - 1] = "";
                    }

                    if (Board[row, column] == "as" && Board[row + 1, column + 2] == "pb")
                    {
                        StateP++;
                        Board[row + 1, column + 2] = "";
                    }

                    if (Board[row, column] == "as" && Board[row - 1, column + 2] == "pb")
                    {
                        StateP++;
                        Board[row - 1, column + 2] = "";
                    }


                    if (Board[row, column] == "as" && Board[row - 2, column + 1] == "pb")
                    {
                        StateP++;
                        Board[row - 2, column + 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 2, column - 1] == "pb")
                    {
                        StateP++;
                        Board[row - 2, column - 1] = "";
                    }

                    if (Board[row, column] == "as" && Board[row + 1, column - 2] == "pb")
                    {
                        StateP++;
                        Board[row + 1, column - 2] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 1, column - 2] == "pb")
                    {
                        StateP++;
                        Board[row - 1, column - 2] = "";
                    }

                    //=====================================================

                    if (Board[row, column] == "as" && Board[row + 2, column + 1] == "ab")
                    {
                        StateA++;
                        Board[row + 2, column + 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row + 2, column - 1] == "ab")
                    {
                        StateA++;
                        Board[row + 2, column - 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row + 1, column + 2] == "ab")
                    {
                        StateA++;
                        Board[row + 1, column + 2] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 1, column + 2] == "ab")
                    {
                        StateA++;
                        Board[row - 1, column + 2] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 2, column + 1] == "ab")
                    {
                        StateA++;
                        Board[row - 2, column + 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 2, column - 1] == "ab")
                    {
                        StateA++;
                        Board[row - 2, column - 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row + 1, column - 2] == "ab")
                    {
                        StateA++;
                        Board[row + 1, column - 2] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 1, column - 2] == "ab")
                    {
                        StateA++;
                        Board[row - 1, column - 2] = "";
                    }

                    //=====================================================

                    if (Board[row, column] == "as" && Board[row + 2, column + 1] == "fb")
                    {
                        StateF++;
                        Board[row + 2, column + 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row + 2, column - 1] == "fb")
                    {
                        StateF++;
                        Board[row + 2, column - 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row + 1, column + 2] == "fb")
                    {
                        StateF++;
                        Board[row + 1, column + 2] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 1, column + 2] == "fb")
                    {
                        StateF++;
                        Board[row - 1, column + 2] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 2, column + 1] == "fb")
                    {
                        StateF++;
                        Board[row - 2, column + 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 2, column - 1] == "fb")
                    {
                        StateF++;
                        Board[row - 2, column - 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row + 1, column - 2] == "fb")
                    {
                        StateF++;
                        Board[row + 1, column - 2] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 1, column - 2] == "fb")
                    {
                        StateF++;
                        Board[row - 1, column - 2] = "";
                    }

                    //=====================================================


                    if (Board[row, column] == "as" && Board[row + 2, column + 1] == "kb")
                    {
                        StateK++;
                        Board[row + 2, column + 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row + 2, column - 1] == "kb")
                    {
                        StateK++;
                        Board[row + 2, column - 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row + 1, column + 2] == "kb")
                    {
                        StateK++;
                        Board[row + 1, column + 2] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 1, column + 2] == "kb")
                    {
                        StateK++;
                        Board[row - 1, column + 2] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 2, column + 1] == "kb")
                    {
                        StateK++;
                        Board[row - 2, column + 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 2, column - 1] == "kb")
                    {
                        StateK++;
                        Board[row - 2, column - 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row + 1, column - 2] == "kb")
                    {
                        StateK++;
                        Board[row + 1, column - 2] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 1, column - 2] == "kb")
                    {
                        StateK++;
                        Board[row - 1, column - 2] = "";
                    }

                    //=====================================================


                    if (Board[row, column] == "as" && Board[row + 2, column + 1] == "vb")
                    {
                        StateV++;
                        Board[row + 2, column + 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row + 2, column - 1] == "vb")
                    {
                        StateV++;
                        Board[row + 2, column - 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row + 1, column + 2] == "vb")
                    {
                        StateV++;
                        Board[row + 1, column + 2] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 1, column + 2] == "vb")
                    {
                        StateV++;
                        Board[row - 1, column + 2] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 2, column + 1] == "vb")
                    {
                        StateV++;
                        Board[row - 2, column + 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 2, column - 1] == "vb")
                    {
                        StateV++;
                        Board[row - 2, column - 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row + 1, column - 2] == "vb")
                    {
                        StateV++;
                        Board[row + 1, column - 2] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 1, column - 2] == "vb")
                    {
                        StateV++;
                        Board[row - 1, column - 2] = "";
                    }

                    //=====================================================


                    if (Board[row, column] == "as" && Board[row + 2, column + 1] == "sb")
                    {
                        StateS++;
                        Board[row + 2, column + 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row + 2, column - 1] == "sb")
                    {
                        StateS++;
                        Board[row + 2, column - 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row + 1, column + 2] == "sb")
                    {
                        StateS++;
                        Board[row + 1, column + 2] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 1, column + 2] == "sb")
                    {
                        StateS++;
                        Board[row - 1, column + 2] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 2, column + 1] == "sb")
                    {
                        StateS++;
                        Board[row - 2, column + 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 2, column - 1] == "sb")
                    {
                        StateS++;
                        Board[row - 2, column - 1] = "";
                    }
                    if (Board[row, column] == "as" && Board[row + 1, column - 2] == "sb")
                    {
                        StateS++;
                        Board[row + 1, column - 2] = "";
                    }
                    if (Board[row, column] == "as" && Board[row - 1, column - 2] == "sb")
                    {
                        StateS++;
                        Board[row - 1, column - 2] = "";
                    }

                    #endregion

                    #region Siyah Piyon Tehtid etme Durumları

                    if (Board[row, column] == "ps" && Board[row + 1, column + 1] == "pb")
                    {
                        StateP++;
                        Board[row + 1, column + 1] = "";
                    }

                    if (Board[row, column] == "ps" && Board[row + 1, column - 1] == "pb")
                    {
                        StateP++;
                        Board[row + 1, column - 1] = "";
                    }

                    //=====================================================

                    if (Board[row, column] == "ps" && Board[row + 1, column + 1] == "ab")
                    {
                        StateA++;
                        Board[row + 1, column + 1] = "";
                    }

                    if (Board[row, column] == "ps" && Board[row + 1, column - 1] == "ab")
                    {
                        StateA++;
                        Board[row + 1, column - 1] = "";
                    }

                    //=====================================================

                    if (Board[row, column] == "ps" && Board[row + 1, column + 1] == "fb")
                    {
                        StateF++;
                        Board[row + 1, column + 1] = "";
                    }

                    if (Board[row, column] == "ps" && Board[row + 1, column - 1] == "fb")
                    {
                        StateF++;
                        Board[row + 1, column - 1] = "";
                    }

                    //=====================================================

                    if (Board[row, column] == "ps" && Board[row + 1, column + 1] == "kb")
                    {
                        StateK++;
                        Board[row + 1, column + 1] = "";
                    }

                    if (Board[row, column] == "ps" && Board[row + 1, column - 1] == "kb")
                    {
                        StateK++;
                        Board[row + 1, column - 1] = "";
                    }

                    //=====================================================

                    if (Board[row, column] == "ps" && Board[row + 1, column + 1] == "vb")
                    {
                        StateV++;
                        Board[row + 1, column + 1] = "";
                    }

                    if (Board[row, column] == "ps" && Board[row + 1, column - 1] == "vb")
                    {
                        StateV++;
                        Board[row + 1, column - 1] = "";
                    }

                    //=====================================================

                    if (Board[row, column] == "ps" && Board[row + 1, column + 1] == "sb")
                    {
                        StateS++;
                        Board[row + 1, column + 1] = "";
                    }
                    if (Board[row, column] == "ps" && Board[row + 1, column - 1] == "sb")
                    {
                        StateS++;
                        Board[row + 1, column - 1] = "";
                    }

                    #endregion

                    #region Siyah Vezirin tehtid etme durumlarında çapraz durumlarına erişim için columneni bir loop oluşturuldu

                    //Not : t değişkeni cross indisini ifade etmektedir

                    for (int t = 1; t <= 7; t++)
                    {
                        if (Board[row, column] == "vs" && Board[row + t, column] == "pb" && Board[row + t - 1, column] != "ps" && Board[row + t - 1, column] != "fs" && Board[row + t - 1, column] != "as" && Board[row + t - 1, column] != "vs" && Board[row + t - 1, column] != "ks" && Board[row + t - 1, column] != "ss" && Dflag != 1) {
                            StateP++;
                            Dflag = 1;
                            Board[row + t, column] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row - t + 1, column] == "pb" && Board[row - t + 1, column] != "ps" && Board[row - t + 1, column] != "fs" && Board[row - t + 1, column] != "as" && Board[row - t + 1, column] != "vs" && Board[row - t + 1, column] != "ks" && Board[row - t + 1, column] != "ss" && Dflag != 1) // dikecolumn picolumnon
                        {
                            StateP++;
                            Dflag = 1;
                            Board[row - t + 1, column] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row, column - t] == "pb" && Board[row, column - t+1] != "ps" && Board[row, column - t+1] != "fs" && Board[row, column - t+1] != "as" && Board[row, column - t+1] != "vs" && Board[row, column - t+1] != "ks" && Board[row, column - t+1] != "ss" && Yflag != 1)
                        {
                            StateP++;
                            Yflag = 1;
                            Board[row, column - t] = "";
                        }
                        if  (Board[row, column] == "vs" && Board[row, column + t] == "pb" && Board[row, column + t-1] != "ps" && Board[row, column + t-1] != "fs" && Board[row, column + t-1] != "as" && Board[row, column + t-1] != "vs" && Board[row, column + t-1] != "ks" && Board[row, column + t-1] != "ss" && Yflag != 1) // columnatacolumn picolumnon
                        {
                            StateP++;
                            Yflag = 1;
                            Board[row, column + t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row + t, column - t] == "pb" && Board[row + t-1, column - t+1] != "ps" && Board[row + t-1, column - t+1] != "fs" && Board[row + t-1, column - t+1] != "as" && Board[row + t-1, column - t+1] != "vs" && Board[row + t-1, column - t+1] != "ks" && Board[row + t-1, column - t+1] != "ss" && Rflag != 1) {
                            StateP++;
                            Rflag = 1;
                            Board[row + t, column - t] = "";
                        }
                         if (Board[row, column] == "vs" && Board[row - t, column + t] == "pb" && Board[row - t+1, column + t-1] != "ps" && Board[row - t+1, column + t-1] != "fs" && Board[row - t+1, column + t-1] != "as" && Board[row - t+1, column + t-1] != "vs" && Board[row - t+1, column + t-1] != "ks" && Board[row - t+1, column + t-1] != "ss" && Rflag != 1) // sağ çapraz picolumnon
                        {
                            StateP++;
                            Rflag = 1;
                            Board[row - t, column + t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row - t, column - t] == "pb" && Board[row - t+1, column - t+1] != "ps" && Board[row - t+1, column - t+1] != "fs" && Board[row - t+1, column - t+1] != "as" && Board[row - t+1, column - t+1] != "vs" && Board[row - t+1, column - t+1] != "ks" && Board[row - t+1, column - t+1] != "ss" && Lflag != 1)
                        {
                            StateP++;
                            Lflag = 1;
                            Board[row - t, column - t] = "";
                        }
                         if ( Board[row, column] == "vs" && Board[row + t, column + t] == "pb" && Board[row + t-1, column + t-1] != "ps" && Board[row + t-1, column + t-1] != "fs" && Board[row + t-1, column + t-1] != "as" && Board[row + t-1, column + t-1] != "vs" && Board[row + t-1, column + t-1] != "ks" && Board[row + t-1, column + t-1] != "ss" && Lflag != 1) // sol çapraz çapraz picolumnon
                        {
                            StateP++;
                            Lflag = 1;
                            Board[row + t, column + t] = "";
                        }

                        //==========================================================================================================================================================================================================================================================================================================================================================================

                        if (Board[row, column] == "vs" && Board[row - t, column] == "fb" && Board[row - t+1, column] != "ps" && Board[row - t+1, column] != "fs" && Board[row - t+1, column] != "as" && Board[row - t+1, column] != "vs" && Board[row - t+1, column] != "ks" && Board[row - t+1, column] != "ss" && Dflag != 1) {
                            StateF++;
                            Dflag = 1;
                            Board[row - t, column] = "";
                        }
                         if( Board[row, column] == "vs" && Board[row + t, column] == "fb" && Board[row + t-1, column] != "ps" && Board[row + t-1, column] != "fs" && Board[row + t-1, column] != "as" && Board[row + t-1, column] != "vs" && Board[row + t-1, column] != "ks" && Board[row + t-1, column] != "ss" && Dflag != 1) // dikecolumn picolumnon
                        {
                            StateF++;
                            Dflag = 1;
                            Board[row + t, column] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row, column - t] == "fb" && Board[row, column - t+1] != "ps" && Board[row, column - t+1] != "fs" && Board[row, column - t+1] != "as" && Board[row, column - t+1] != "vs" && Board[row, column - t+1] != "ks" && Board[row, column - t+1] != "ss" && Yflag != 1)
                        {
                            StateF++;
                            Yflag = 1;
                            Board[row, column - t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row, column + t] == "fb" && Board[row, column + t-1] != "ps" && Board[row, column + t-1] != "fs" && Board[row, column + t-1] != "as" && Board[row, column + t-1] != "vs" && Board[row, column + t-1] != "ks" && Board[row, column + t-1] != "ss" && Yflag != 1) // columnatacolumn picolumnon
                        {
                            StateF++;
                            Yflag = 1;
                            Board[row, column + t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row + t, column - t] == "fb" && Board[row + t-1, column - t+1] != "ps" && Board[row + t-1, column - t+1] != "fs" && Board[row + t-1, column - t+1] != "as" && Board[row + t-1, column - t+1] != "vs" && Board[row + t-1, column - t+1] != "ks" && Board[row + t-1, column - t+1] != "ss" && Rflag != 1)
                        {
                            StateF++;
                            Rflag = 1;
                            Board[row + t, column - t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row - t, column + t] == "fb" && Board[row - t+1, column + t-1] != "ps" && Board[row + t-1, column - t+1] != "fs" && Board[row + t-1, column - t+1] != "as" && Board[row + t-1, column - t+1] != "vs" && Board[row + t-1, column - t+1] != "ks" && Board[row + t-1, column - t+1] != "ss" && Rflag != 1) // sağ çapraz picolumnon
                        {
                            StateF++;
                            Rflag = 1;
                            Board[row - t, column + t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row + t, column + t] == "fb" && Board[row + t-1, column + t-1] != "ps" && Board[row + t-1, column + t-1] != "fs" && Board[row + t-1, column + t-1] != "as" && Board[row + t-1, column + t-1] != "vs" && Board[row + t-1, column + t-1] != "ks" && Board[row + t-1, column + t-1] != "ss" && Lflag != 1)
                        {
                            StateF++;
                            Lflag = 1;
                            Board[row + t, column + t] = "";
                        }
                         if (Board[row, column] == "vs" && Board[row - t, column - t] == "fb" && Board[row - t+1, column - t+1] != "ps" && Board[row - t+1, column - t+1] != "fs" && Board[row - t+1, column - t+1] != "as" && Board[row - t+1, column - t+1] != "vs" && Board[row - t+1, column - t+1] != "ks" && Board[row - t+1, column - t+1] != "ss" && Lflag != 1) // sol çapraz çapraz picolumnon
                        {
                            StateF++;
                            Lflag = 1;
                            Board[row - t, column - t] = "";
                        }

                        //==========================================================================================================================================================================================================================================================================================================================================================================

                        if (Board[row, column] == "vs" && Board[row - t, column] == "ab" && Board[row - t+1, column] != "ps" && Board[row - t+1, column] != "fs" && Board[row - t+1, column] != "as" && Board[row - t+1, column] != "vs" && Board[row - t+1, column] != "ks" && Board[row - t+1, column] != "ss" && Dflag != 1) 
                        {
                            StateA++;
                            Dflag = 1;
                            Board[row - t, column] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row + t, column] == "ab" && Board[row + t-1, column] != "ps" && Board[row + t-1, column] != "fs" && Board[row + t-1, column] != "as" && Board[row + t-1, column] != "vs" && Board[row + t-1, column] != "ks" && Board[row + t-1, column] != "ss" && Dflag != 1) // dikecolumn picolumnon
                        {
                            StateA++;
                            Dflag = 1;
                            Board[row + t, column] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row, column - t] == "ab" && Board[row, column - t+1] != "ps" && Board[row, column - t+1] != "fs" && Board[row, column - t+1] != "as" && Board[row, column - t+1] != "vs" && Board[row, column - t+1] != "ks" && Board[row, column - t+1] != "ss" && Yflag != 1)
                        {
                            StateA++;
                            Yflag = 1;
                            Board[row, column - t] = "";
                        }
                         if (Board[row, column] == "vs" && Board[row, column + t] == "ab" && Board[row, column + t-1] != "ps" && Board[row, column + t-1] != "fs" && Board[row, column + t-1] != "as" && Board[row, column + t-1] != "vs" && Board[row, column + t-1] != "ks" && Board[row, column + t-1] != "ss" && Yflag != 1) // columnatacolumn picolumnon
                        {
                            StateA++;
                            Yflag = 1;
                            Board[row, column + t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row + t, column - t] == "ab" && Board[row + t-1, column - t+1] != "ps" && Board[row + t-1, column - t+1] != "fs" && Board[row + t-1, column - t+1] != "as" && Board[row + t-1, column - t+1] != "vs" && Board[row + t-1, column - t+1] != "ks" && Board[row + t-1, column - t+1] != "ss" && Rflag != 1) // sağ çapraz picolumnon
                        {
                            StateA++;
                            Rflag = 1;
                            Board[row + t, column - t] = "";
                        }

                        if (Board[row, column] == "vs" && Board[row - t, column + t] == "ab" && Board[row - t + 1, column + t - 1] != "ps" && Board[row - t + 1, column + t - 1] != "fs" && Board[row - t + 1, column + t - 1] != "as" && Board[row - t + 1, column + t - 1] != "vs" && Board[row - t + 1, column + t - 1] != "ks" && Board[row - t + 1, column + t - 1] != "ss" && Rflag != 1)
                        {
                            StateA++;
                            Rflag = 1;
                            Board[row - t, column + t] = "";
                        }

                        if (Board[row, column] == "vs" && Board[row + t, column + t] == "ab" && Board[row + t-1, column + t-1] != "ps" && Board[row + t-1, column + t-1] != "fs" && Board[row + t-1, column + t-1] != "as" && Board[row + t-1, column + t-1] != "vs" && Board[row + t-1, column + t-1] != "ks" && Board[row + t-1, column + t-1] != "ss" && Lflag != 1) // sol çapraz çapraz picolumnon
                        {
                            Console.WriteLine("at tehtid edildi1");
                            Lflag = 1;
                            Board[row + t, column + t] = "";
                        }

                        if (Board[row, column] == "vs" && Board[row - t, column - t] == "ab" && Board[row - t + 1, column - t + 1] != "ps" && Board[row - t + 1, column - t + 1] != "fs" && Board[row - t + 1, column - t + 1] != "as" && Board[row - t + 1, column - t + 1] != "vs" && Board[row - t + 1, column - t + 1] != "ks" && Board[row - t + 1, column - t + 1] != "ss" && Lflag != 1)
                        {
                            Console.WriteLine("at tehtid edildi2");
                            Lflag = 1;
                            Board[row - t, column - t] = "";
                        }

                        //==========================================================================================================================================================================================================================================================================================================================================================================

                        if (Board[row, column] == "vs" && Board[row - t, column] == "vb" && Board[row - t+1, column] != "ps" && Board[row - t+1, column] != "fs" && Board[row - t+1, column] != "as" && Board[row - t+1, column] != "vs" && Board[row - t+1, column] != "ks" && Board[row - t+1, column] != "ss" && Dflag != 1)
                        {
                            StateV++;
                            Dflag = 1;
                            Board[row - t, column] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row + t, column] == "vb" && Board[row + t-1, column] != "ps" && Board[row + t-1, column] != "fs" && Board[row + t-1, column] != "as" && Board[row + t-1, column] != "vs" && Board[row + t-1, column] != "ks" && Board[row + t-1, column] != "ss" && Dflag != 1) // dikecolumn picolumnon
                        {
                            StateV++;
                            Dflag = 1;
                            Board[row + t, column] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row, column - t] == "vb" && Board[row, column - t+1] != "ps" && Board[row, column - t+1] != "fs" && Board[row, column - t+1] != "as" && Board[row, column - t+1] != "vs" && Board[row, column - t+1] != "ks" && Board[row, column - t+1] != "ss" && Yflag != 1)
                        {
                            StateV++;
                            Yflag = 1;
                            Board[row, column - t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row, column + t] == "vb" && Board[row, column + t-1] != "ps" && Board[row, column + t-1] != "fs" && Board[row, column + t-1] != "as" && Board[row, column + t-1] != "vs" && Board[row, column + t-1] != "ks" && Board[row, column + t-1] != "ss" && Yflag != 1) // columnatacolumn picolumnon
                        {
                            StateV++;
                            Yflag = 1;
                            Board[row, column + t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row + t, column - t] == "vb" && Board[row + t-1, column - t+1] != "ps" && Board[row + t-1, column - t+1] != "fs" && Board[row + t-1, column - t+1] != "as" && Board[row + t-1, column - t+1] != "vs" && Board[row + t-1, column - t+1] != "ks" && Board[row + t-1, column - t+1] != "ss" && Rflag != 1)
                        {
                            StateV++;
                            Rflag = 1;
                            Board[row + t, column - t] = "";
                        }
                         if (Board[row, column] == "vs" && Board[row - t, column + t] == "vb" && Board[row - t+1, column + t-1] != "ps" && Board[row - t+1, column + t-1] != "fs" && Board[row - t+1, column + t-1] != "as" && Board[row - t+1, column + t-1] != "vs" && Board[row - t+1, column + t-1] != "ks" && Board[row - t+1, column + t-1] != "ss" && Rflag != 1) // sağ çapraz picolumnon
                        {
                            StateV++;
                            Rflag = 1;
                            Board[row - t, column + t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row + t, column + t] == "vb" && Board[row + t-1, column + t-1] != "ps" && Board[row + t-1, column + t-1] != "fs" && Board[row + t-1, column + t-1] != "as" && Board[row + t-1, column + t-1] != "vs" && Board[row + t-1, column + t-1] != "ks" && Board[row + t-1, column + t-1] != "ss" && Lflag != 1)
                        {
                            StateV++;
                            Lflag = 1;
                            Board[row + t, column + t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row - t, column - t] == "vb" && Board[row - t+1, column - t+1] != "ps" && Board[row - t+1, column - t+1] != "fs" && Board[row - t+1, column - t+1] != "as" && Board[row - t+1, column - t+1] != "vs" && Board[row - t+1, column - t+1] != "ks" && Board[row - t+1, column - t+1] != "ss" && Lflag != 1) // sol çapraz çapraz picolumnon
                        {
                            StateV++;
                            Lflag = 1;
                            Board[row - t, column - t] = "";
                        }

                        //==========================================================================================================================================================================================================================================================================================================================================================================

                        if (Board[row, column] == "vs" && Board[row - t, column] == "kb" && Board[row - t+1, column] != "ps" && Board[row - t+1, column] != "fs" && Board[row - t+1, column] != "as" && Board[row - t+1, column] != "vs" && Board[row - t+1, column] != "ks" && Board[row - t+1, column] != "ss" && Dflag != 1)
                        {
                            StateK++;
                            Dflag = 1;
                            Board[row - t, column] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row + t-1, column] == "kb" && Board[row + t-1, column] != "ps" && Board[row + t-1, column] != "fs" && Board[row + t-1, column] != "as" && Board[row + t-1, column] != "vs" && Board[row + t-1, column] != "ks" && Board[row + t-1, column] != "ss" && Dflag != 1) // dikecolumn picolumnon
                        {
                            StateK++;
                            Dflag = 1;
                            Board[row + t - 1, column] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row, column - t] == "kb" && Board[row, column - t+1] != "ps" && Board[row, column - t+1] != "fs" && Board[row, column - t+1] != "as" && Board[row, column - t+1] != "vs" && Board[row, column - t+1] != "ks" && Board[row, column - t+1] != "ss" && Yflag != 1)
                        {
                            StateK++;
                            Yflag = 1;
                            Board[row, column - t] = "";
                        }
                        if  (Board[row, column] == "vs" && Board[row, column + t] == "kb" && Board[row, column + t-1] != "ps" && Board[row, column + t-1] != "fs" && Board[row, column + t-1] != "as" && Board[row, column + t-1] != "vs" && Board[row, column + t-1] != "ks" && Board[row, column + t-1] != "ss" && Yflag != 1) // columnatacolumn picolumnon
                        {
                            StateK++;
                            Yflag = 1;
                            Board[row, column + t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row + t, column - t] == "kb" && Board[row + t-1, column - t+1] != "ps" && Board[row + t-1, column - t+1] != "fs" && Board[row + t-1, column - t+1] != "as" && Board[row + t-1, column - t+1] != "vs" && Board[row + t-1, column - t+1] != "ks" && Board[row + t-1, column - t+1] != "ss" && Rflag != 1)
                        {
                            StateK++;
                            Rflag = 1;
                            Board[row + t, column - t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row - t, column + t] == "kb" && Board[row - t+1, column + t-1] != "ps" && Board[row - t+1, column + t-1] != "fs" && Board[row - t+1, column + t-1] != "as" && Board[row - t+1, column + t-1] != "vs" && Board[row - t+1, column + t-1] != "ks" && Board[row - t+1, column + t-1] != "ss" && Rflag != 1) // sağ çapraz picolumnon
                        {
                            StateK++;
                            Rflag = 1;
                            Board[row - t, column + t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row + t, column + t] == "kb" && Board[row + t-1, column + t-1] != "ps" && Board[row + t-1, column + t-1] != "fs" && Board[row + t-1, column + t-1] != "as" && Board[row + t-1, column + t-1] != "vs" && Board[row + t-1, column + t-1] != "ks" && Board[row + t-1, column + t-1] != "ss" && Lflag != 1)
                        {
                            StateK++;
                            Lflag = 1;
                            Board[row + t, column + t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row - t, column - t] == "kb" && Board[row - t+1, column - t+1] != "ps" && Board[row - t+1, column - t+1] != "fs" && Board[row - t+1, column - t+1] != "as" && Board[row - t+1, column - t+1] != "vs" && Board[row - t+1, column - t+1] != "ks" && Board[row - t+1, column - t+1] != "ss" && Lflag != 1) // sol çapraz çapraz picolumnon
                        {
                            StateK++;
                            Lflag = 1;
                            Board[row - t, column - t] = "";
                        }

                        //==========================================================================================================================================================================================================================================================================================================================================================================

                        if (Board[row, column] == "vs" && Board[row - t, column] == "sb" && Board[row - t+1, column] != "ps" && Board[row - t+1, column] != "fs" && Board[row - t+1, column] != "as" && Board[row - t+1, column] != "vs" && Board[row - t+1, column] != "ks" && Board[row - t+1, column] != "ss" && Dflag != 1)
                        {
                            StateS++;
                            Dflag = 1;
                            Board[row - t, column] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row + t, column] == "sb" && Board[row + t-1, column] != "ps" && Board[row + t-1, column] != "fs" && Board[row + t-1, column] != "as" && Board[row + t-1, column] != "vs" && Board[row + t-1, column] != "ks" && Board[row + t-1, column] != "ss" && Dflag != 1) // dikecolumn picolumnon
                        {
                            StateS++;
                            Dflag = 1;
                            Board[row + t, column] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row, column - t] == "sb" && Board[row, column - t+1] != "ps" && Board[row, column - t+1] != "fs" && Board[row, column - t+1] != "as" && Board[row, column - t+1] != "vs" && Board[row, column - t+1] != "ks" && Board[row, column - t+1] != "ss" && Yflag != 1)
                        {
                            StateS++;
                            Yflag = 1;
                            Board[row, column - t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row, column + t] == "sb" && Board[row, column + t-1] != "ps" && Board[row, column + t-1] != "fs" && Board[row, column + t-1] != "as" && Board[row, column + t-1] != "vs" && Board[row, column + t-1] != "ks" && Board[row, column + t-1] != "ss" && Yflag != 1) // columnatacolumn picolumnon
                        {
                            StateS++;
                            Yflag = 1;
                            Board[row, column + t] = "";

                        }
                        if (Board[row, column] == "vs" && Board[row + t, column - t] == "sb" && Board[row + t-1, column - t+1] != "ps" && Board[row + t-1, column - t+1] != "fs" && Board[row + t-1, column - t+1] != "as" && Board[row + t-1, column - t+1] != "vs" && Board[row + t-1, column - t+1] != "ks" && Board[row + t-1, column - t+1] != "ss" && Rflag != 1)
                        {
                            StateS++;
                            Rflag = 1;
                            Board[row + t, column - t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row - t, column + t] == "sb" && Board[row - t+1, column + t-1] != "ps" && Board[row - t+1, column + t-1] != "fs" && Board[row - t+1, column + t-1] != "as" && Board[row - t+1, column + t-1] != "vs" && Board[row - t+1, column + t-1] != "ks" && Board[row - t+1, column + t-1] != "ss" && Rflag != 1) // sağ çapraz picolumnon
                        {
                            StateS++;
                            Rflag = 1;
                            Board[row - t, column + t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row + t, column + t] == "sb" && Board[row + t-1, column + t-1] != "ps" && Board[row + t-1, column + t-1] != "fs" && Board[row + t-1, column + t-1] != "as" && Board[row + t-1, column + t-1] != "vs" && Board[row + t-1, column + t-1] != "ks" && Board[row + t-1, column + t-1] != "ss" && Lflag != 1)
                        {
                            StateS++;
                            Lflag = 1;
                            Board[row + t, column + t] = "";
                        }
                        if (Board[row, column] == "vs" && Board[row - t, column - t] == "sb" && Board[row - t+1, column - t+1] != "ps" && Board[row - t+1, column - t+1] != "fs" && Board[row - t+1, column - t+1] != "as" && Board[row - t+1, column - t+1] != "vs" && Board[row - t+1, column - t+1] != "ks" && Board[row - t+1, column - t+1] != "ss" && Lflag != 1) // sol çapraz çapraz picolumnon
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
            //beyazın puanı hesaplamak için
            double PPoint = (StateP * 0.5) + ((PNumber - StateP) * 1);
            double APoint = (StateA * 1.5) + ((ANumber - StateA) * 3);
            double FPoint = (StateF * 1.5) + ((FNumber - StateF) * 3);
            double KPoint = (StateK * 2.5) + ((KNumber - StateK) * 5);
            double VPoint = (StateV * 4.5) + ((VNumber - StateV) * 9);
            double SPoint = (StateS * 50) + ((SNumber - StateS) * 100);           
            Console.WriteLine("Beyaz : {0}" , PPoint + APoint + FPoint + KPoint + VPoint + SPoint);
            #endregion

        }

    }
}
