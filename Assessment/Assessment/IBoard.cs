using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment
{
   public interface IBoard
    {
        // not: WhiteBoard ve BlackBoard classları için interface oluşturuldu.
        public void ScoreCalculate(string[,] Board);
    }
}
