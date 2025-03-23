using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsülleme
{
    internal class Emlak
    {
        private string semt;
        private int odayısı;
        private int katno;
        private int alan;

        public string Semt { get => semt; set => semt = value.ToUpper(); } //büyük harfli çevirme
        public int Odayısı { get => odayısı; set => odayısı = Math.Abs(value); }
        public int Katno { get => katno; set => katno = Math.Abs(value); }
        public int Alan { get => alan; set => alan = Math.Abs(value); }
    }
}
