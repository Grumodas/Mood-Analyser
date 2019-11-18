using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoryClient
{
    public class MultipleUnknownPhotosEventArgs : EventArgs
    {
        public int HowManyUnknownInaRow { get; set; }

        public MultipleUnknownPhotosEventArgs(int HowManyUnknownsInaRow)
        {
            this.HowManyUnknownInaRow = HowManyUnknownsInaRow;
        }
    }
}
