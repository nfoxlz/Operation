using System;
using System.Collections.Generic;
using System.Text;

namespace Operation.DMC
{
    public sealed class PulseCard3000 : PulseCard
    {
        public PulseCard3000(ushort index) : base(index) { }

        public short GetCardVersion(ref uint cardVersion) => LTDMC.dmc_get_card_version(CardNo, ref cardVersion);

        public short SetVectorProfileMulticoor(ushort crd, double minVel, double maxVel, double tacc, double tdec, double stopVel)
            => LTDMC.dmc_set_vector_profile_multicoor(CardNo, crd, minVel, maxVel, tacc, tdec, stopVel);

        public short LineMulticoor(ushort crd, ushort axisNum, ushort[] axisList, int[] distList, ushort posiMode) => LTDMC.dmc_line_multicoor(CardNo, crd, axisNum, axisList, distList, posiMode);

        public short ArcMoveMulticoor(ushort crd, ushort[] axisList, int[] targetPos, int[] cenPos, ushort arcDir, ushort posiMode) => LTDMC.dmc_arc_move_multicoor(CardNo, crd, axisList, targetPos, cenPos, arcDir, posiMode);

        public short GetDecStopTime(ushort axis, ref double stopTime) => LTDMC.dmc_get_dec_stop_time(CardNo, axis, ref stopTime);

        public short SetDecStopTime(ushort axis, double stopTime) => LTDMC.dmc_set_dec_stop_time(CardNo, axis, stopTime);

        public int GetLatchFlagExtern(ushort axis) => LTDMC.dmc_get_latch_flag_extern(CardNo, axis);

        public int GetLatchValueExtern(ushort axis, ushort index) => LTDMC.dmc_get_latch_value_extern(CardNo, axis, index);
    }
}
