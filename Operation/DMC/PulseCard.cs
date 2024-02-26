namespace Operation.DMC
{
    public class PulseCard : DMCBase
    {
        public PulseCard(ushort index):base(index) { }

        public short GetElMode(ushort axis, out LimitSwitchEnable enable, out EffectiveLevel logic, out BrakingMode mode)
        {
            ushort el_enable = 0, el_logic = 0, el_mode = 0;
            var result = LTDMC.dmc_get_el_mode(CardNo, axis, ref el_enable, ref el_logic, ref el_mode);
            enable = (LimitSwitchEnable)el_enable;
            logic = (EffectiveLevel)el_logic;
            mode = (BrakingMode)el_mode;
            return result;
        }

        public short SetElMode(ushort axis, LimitSwitchEnable enable, EffectiveLevel logic, BrakingMode mode) => LTDMC.dmc_set_el_mode(CardNo, axis, (ushort)enable, (ushort)logic, (ushort)mode);

        public short GetHomemode(ushort axis, ref ushort homeDir, ref double vel, ref ushort homeMode, ref ushort count) => LTDMC.dmc_get_homemode(CardNo, axis, ref homeDir, ref vel, ref homeMode, ref count);

        public short SetHomemode(ushort axis, ushort homeDir, double vel, ushort mode, ushort count) => LTDMC.dmc_set_homemode(CardNo, axis, homeDir, vel, mode, count);

        public short HomeMove(ushort axis) => LTDMC.dmc_home_move(CardNo, axis);

        public short GetProfile(ushort axis, ref double minVel, ref double maxVel, ref double tacc, ref double tdec, ref double stopVel) => LTDMC.dmc_get_profile(CardNo, axis, ref minVel, ref maxVel, ref tacc, ref tdec, ref stopVel);

        public short SetProfile(ushort axis, double minVel, double maxVel, double tacc, double tdec, double stopVel) => LTDMC.dmc_set_profile(CardNo, axis, minVel, maxVel, tacc, tdec, stopVel);

        public int GetPosition(ushort axis) => LTDMC.dmc_get_position(CardNo, axis);

        public short SetPosition(ushort axis, int currentPosition) => LTDMC.dmc_set_position(CardNo, axis, currentPosition);

        public short PMove(ushort axis, int dist, ushort posiMode) => LTDMC.dmc_pmove(CardNo, axis, dist, posiMode);

        public short ChangeSpeed(ushort axis, double currVel, double taccdec) => LTDMC.dmc_change_speed(CardNo, axis, currVel, taccdec);

        public short ResetTargetPosition(ushort axis, int dist, ushort posiMode) => LTDMC.dmc_reset_target_position(CardNo, axis, dist, posiMode);

        public short PvtTable(ushort iaxis, uint count, double[] pTime, int[] pPos, double[] pVel) => LTDMC.dmc_PvtTable(CardNo, iaxis, count, pTime, pPos, pVel);

        public short PttTable(ushort iaxis, uint count, double[] pTime, int[] pPos) => LTDMC.dmc_PttTable(CardNo, iaxis, count, pTime, pPos);

        public short PtsTable(ushort iaxis, uint count, double[] pTime, int[] pPos, double[] pPercent) => LTDMC.dmc_PtsTable(CardNo, iaxis, count, pTime, pPos, pPercent);

        public short PvtsTable(ushort iaxis, uint count, double[] times, int[] poses, double velBegin, double velEnd) => LTDMC.dmc_PvtsTable(CardNo, iaxis, count, times, poses, velBegin, velEnd);

        public short PvtMove(ushort axisNum, ushort[] axisList) => LTDMC.dmc_PvtMove(CardNo, axisNum, axisList);

        public short GetHandwheelInmode(ushort axis, ref ushort inmode, ref int multi, ref double vh) => LTDMC.dmc_get_handwheel_inmode(CardNo, axis, ref inmode, ref multi, ref vh);

        public short SetHandwheelInmode(ushort axis, ushort inmode, int multi, double vh) => LTDMC.dmc_set_handwheel_inmode(CardNo, axis, inmode, multi, vh);

        public short GetHandwheelChannel(ref ushort index) => LTDMC.dmc_get_handwheel_channel(CardNo, ref index);

        public short SetHandwheelChannel(ushort index) => LTDMC.dmc_set_handwheel_channel(CardNo, index);

        public short SetHandwheelInmodeExtern(ushort inmode, ushort axisNum, ushort[] axisList, int[] multi) => LTDMC.dmc_set_handwheel_inmode_extern(CardNo, inmode, axisNum, axisList, multi);

        public short GetCounterInmode(ushort axis, ref ushort mode) => LTDMC.dmc_get_counter_inmode(CardNo, axis, ref mode);

        public short SetCounterInmode(ushort axis, ushort mode) => LTDMC.dmc_set_counter_inmode(CardNo, axis, mode);

        public int GetEncoder(ushort axis) => LTDMC.dmc_get_encoder(CardNo, axis);

        public short SetEncoder(ushort axis, int encoderValue) => LTDMC.dmc_set_encoder(CardNo, axis, encoderValue);

        public short CompareGetCurrentPoint(ushort axis, ref int pos) => LTDMC.dmc_compare_get_current_point(CardNo, axis, ref pos);

        public short HcmpGetCurrentState(ushort hcmp, ref int remainedPoints, ref int currentPoint, ref int runnedPoints) => LTDMC.dmc_hcmp_get_current_state(CardNo, hcmp, ref remainedPoints, ref currentPoint, ref runnedPoints);

        public short GetLtcMode(ushort axis, ref ushort ltcLogic, ref ushort ltcMode, ref double filter) => LTDMC.dmc_get_ltc_mode(CardNo, axis, ref ltcLogic, ref ltcMode, ref filter);

        public short SetLtcMode(ushort axis, ushort ltcLogic, ushort ltcMode, double filter) => LTDMC.dmc_set_ltc_mode(CardNo, axis, ltcLogic, ltcMode, filter);

        public short GetLatchMode(ushort axis, ref ushort allEnable, ref ushort latchSource, ref ushort trigerChunnel) => LTDMC.dmc_get_latch_mode(CardNo, axis, ref allEnable, ref latchSource, ref trigerChunnel);

        public short SetLatchMode(ushort axis, ushort allEnable, ushort latchSource, ushort trigerChunnel) => LTDMC.dmc_set_latch_mode(CardNo, axis, allEnable, latchSource, trigerChunnel);

        public int GetLatchValue(ushort axis) => LTDMC.dmc_get_latch_value(CardNo, axis);

        public int GetLatchFlag(ushort axis) => LTDMC.dmc_get_latch_flag(CardNo, axis);

        public int ResetLatchFlag(ushort axis) => LTDMC.dmc_reset_latch_flag(CardNo, axis);

        public short GetLatchStopTime(ushort axis, ref int time) => LTDMC.dmc_get_latch_stop_time(CardNo, axis, ref time);

        public short SetLatchStopTime(ushort axis, int time) => LTDMC.dmc_set_latch_stop_time(CardNo, axis, time);

        public short GSetLtcOutMode(ushort CardNo, ushort axis, ref ushort enable, ref ushort bitNo) => LTDMC.dmc_GetLtcOutMode(CardNo, axis, ref enable, ref bitNo);

        public short SetLtcOutMode(ushort CardNo, ushort axis, ushort enable, ushort bitNo) => LTDMC.dmc_SetLtcOutMode(CardNo, axis, enable, bitNo);

        public short GetHomelatchMode(ushort axis, ref ushort enable, ref ushort logic, ref ushort source) => LTDMC.dmc_get_homelatch_mode(CardNo, axis, ref enable, ref logic, ref source);

        public short SetHomelatchMode(ushort axis, ushort enable, ushort logic, ushort source) => LTDMC.dmc_set_homelatch_mode(CardNo, axis, enable, logic, source);

        public short ResetHomelatchFlag(ushort axis) => LTDMC.dmc_reset_homelatch_flag(CardNo, axis);

        public short GetHomelatchFlag(ushort axis) => LTDMC.dmc_get_homelatch_flag(CardNo, axis);

        public int GetHomelatchValue(ushort axis) => LTDMC.dmc_get_homelatch_value(CardNo, axis);

        public short GetIOMapVirtual(ushort bitNo, ref ushort mapIoType, ref ushort mapIoIndex, ref double filter) => LTDMC.dmc_get_io_map_virtual(CardNo, bitNo, ref mapIoType, ref mapIoIndex, ref filter);

        public short SetIOMapVirtual(ushort bitNo, ushort mapIoType, ushort mapIoIndex, double filter) => LTDMC.dmc_set_io_map_virtual(CardNo, bitNo, mapIoType, mapIoIndex, filter);

        public short ReadInbitVirtual(ushort bitNo) => LTDMC.dmc_read_inbit_virtual(CardNo, bitNo);

        public short NmcGetConnectState(ref ushort nodeNum, ref ushort state) => LTDMC.nmc_get_connect_state(CardNo, ref nodeNum, ref state);

        public short NmcSetConnectState(ushort nodeNum, ushort state, ushort baud) => LTDMC.nmc_set_connect_state(CardNo, nodeNum, state, baud);

        public short NmcReadOutbit(ushort noteID, ushort ioBit, ref ushort ioValue) => LTDMC.nmc_read_outbit(CardNo, noteID, ioBit, ref ioValue);

        public short NmcWriteOutbit(ushort noteID, ushort ioBit, ushort ioValue) => LTDMC.nmc_write_outbit(CardNo, noteID, ioBit, ioValue);

        public short NmcReadInbit(ushort noteID, ushort ioBit, ref ushort ioValue) => LTDMC.nmc_read_inbit(CardNo, noteID, ioBit, ref ioValue);

        public short NmcReadOutport(ushort noteID, ushort portNo, uint ioValue) => LTDMC.nmc_read_outport(CardNo, noteID, portNo, ref ioValue);

        public short NmcWriteOutport(ushort noteID, ushort portNo, uint ioValue) => LTDMC.nmc_write_outport(CardNo, noteID, portNo, ioValue);

        public short NmcReadInport(ushort noteID, ushort portNo, ref uint ioValue) => LTDMC.nmc_read_inport(CardNo, noteID, portNo, ref ioValue);

        public short NmcGetDaMode(ushort noteID, ushort channel, ref ushort mode, uint bufferNums) => LTDMC.nmc_get_da_mode(CardNo, noteID, channel, ref mode, bufferNums);

        public short NmcSetDaMode(ushort noteID, ushort channel, ushort mode, uint bufferNums) => LTDMC.nmc_set_da_mode(CardNo, noteID, channel, mode, bufferNums);

        public short NmcGetAdMode(ushort noteID, ushort channel, ref ushort mode, uint bufferNums) => LTDMC.nmc_get_ad_mode(CardNo, noteID, channel, ref mode, bufferNums);

        public short NmcSetAdMode(ushort noteID, ushort channel, ushort mode, uint bufferNums) => LTDMC.nmc_set_ad_mode(CardNo, noteID, channel, mode, bufferNums);

        public short NmcGetAdInput(ushort noteID, ushort channel, ref double value) => LTDMC.nmc_get_ad_input(CardNo, noteID, channel, ref value);

        public short NmcGetAdOutput(ushort noteID, ushort channel, ref double value) => LTDMC.nmc_get_da_output(CardNo, noteID, channel, ref value);

        public short NmcSetAdOutput(ushort noteID, ushort channel, double value) => LTDMC.nmc_set_da_output(CardNo, noteID, channel, value);
    }
}
