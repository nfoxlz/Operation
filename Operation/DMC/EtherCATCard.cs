using System;
using System.Collections.Generic;
using System.Text;

namespace Operation.DMC
{
    public class EtherCATCard : BusCard
    {
        public EtherCATCard(ushort index) : base(index) { }

        public short GetCardVersion(ref uint cardVersion) => LTDMC.dmc_get_card_version(CardNo, ref cardVersion);
    }
}
