namespace Operation.DMC
{
    public class PulseCard5000 : PulseCard
    {
        public PulseCard5000(ushort index) : base(index) { }

        public short GetCardVersion(ref uint cardVersion) => LTDMC.dmc_get_card_version(CardNo, ref cardVersion);

        public short GetProfileUnit(ushort axis, ref double minVel, ref double maxVel, ref double tacc, ref double tdec, ref double stopVel) => LTDMC.dmc_get_profile_unit(CardNo, axis, ref minVel, ref maxVel, ref tacc, ref tdec, ref stopVel);

        public short SetProfileUnit(ushort axis, double minVel, double maxVel, double tacc, double tdec, double stopVel) => LTDMC.dmc_set_profile_unit(CardNo, axis, minVel, maxVel, tacc, tdec, stopVel);

        public short GetPositionUnit(ushort axis, ref double pos) => LTDMC.dmc_get_position_unit(CardNo, axis, ref pos);

        public short SetPositionUnit(ushort axis, double pos) => LTDMC.dmc_set_position_unit(CardNo, axis, pos);

        public short ChangeSpeedUnit(ushort axis, double newVel, double taccdec) => LTDMC.dmc_change_speed_unit(CardNo, axis, newVel, taccdec);

        public short ResetTargetPositionUnit(ushort axis, double newPos) => LTDMC.dmc_reset_target_position_unit(CardNo, axis, newPos);

        public short PMoveUnit(ushort axis, double dist, ushort posiMode) => LTDMC.dmc_pmove_unit(CardNo, axis, dist, posiMode);

        public short SetVectorProfileUnit(ushort CardNo, ushort crd, double minVel, double maxVel, double tacc, double tdec, double stopVel) => LTDMC.dmc_set_vector_profile_unit(CardNo, crd, minVel, maxVel, tacc, tdec, stopVel);

        public short ArcMoveCenterUnit(ushort crd, ushort axisNum, ushort[] axisList, double[] targetPos, double[] cenPos, ushort arcDir, int circle, ushort posiMode)
            => LTDMC.dmc_arc_move_center_unit(CardNo, crd, axisNum, axisList, targetPos, cenPos, arcDir, circle, posiMode);

        public short GetDecStopTime(ushort axis, ref double stopTime) => LTDMC.dmc_get_dec_stop_time(CardNo, axis, ref stopTime);

        public short SetDecStopTime(ushort axis, double stopTime) => LTDMC.dmc_set_dec_stop_time(CardNo, axis, stopTime);

        public short GetEncoderUnit(ushort axis, ref double pos) => LTDMC.dmc_get_encoder_unit(CardNo, axis, ref pos);

        public short SetEncoderUnit(ushort axis, double pos) => LTDMC.dmc_set_encoder_unit(CardNo, axis, pos);

        public short GetFactorErrorUnit(ushort axis, ref double factor, ref double error) => LTDMC.dmc_get_factor_error_unit(CardNo, axis, ref factor, ref error);

        public short SetFactorErrorUnit(ushort axis, double factor, double error) => LTDMC.dmc_set_factor_error_unit(CardNo, axis, factor, error);
    }
}
