using System;
using System.Runtime.InteropServices;

namespace Operation.DMC
{
    public abstract class DMCBase
    {
        public uint CardType { get; private set; }

        public ushort CardNo { get; private set; }

        private ushort _currentIndex;

        public ushort CurrentCardIndex
        {
            get
            {
                return _currentIndex;
            }
            set
            {
                if (value >= CardInfos.Length)
                    throw new IndexOutOfRangeException();

                _currentIndex = value;
            }
        }

        public static CardInfo[] CardInfos { get; private set; }

        static DMCBase() => Init();

        public static void Init()
        {
            lock(typeof(DMCBase))
            {
                var cardNun = BoardInit();

                if (0 == cardNun)
                    throw new Exceptions.NoCardException();

                if (0 > cardNun)
                    throw new Exceptions.CardIdConflictException(Math.Abs(cardNun));


                uint[] typeList = new uint[cardNun];
                ushort[] idList = new ushort[cardNun];

                ushort num = Convert.ToUInt16(cardNun);
                GetCardInfList(ref num, typeList, idList);

                CardInfo[] infos = new CardInfo[cardNun];
                for (int i = 0; i < num; i++)
                {
                    infos[i].CardType = typeList[i];
                    infos[i].CardNo = idList[i];
                }
                CardInfos = infos;
            }
        }

        public DMCBase(ushort index)
        {
            if (index >= CardInfos.Length)
                throw new IndexOutOfRangeException();

            CardType = CardInfos[index].CardType;
            CardNo = CardInfos[index].CardNo;
        }

        public static short BoardInit() => LTDMC.dmc_board_init();

        public static short BoardClose() => LTDMC.dmc_board_close();

        public static short GetCardInfList(ref ushort CardNum, uint[] CardTypeList, ushort[] CardIdList) => LTDMC.dmc_get_CardInfList(ref CardNum, CardTypeList, CardIdList);

        public static short SetDebugMode(ushort mode, string fileName) => LTDMC.dmc_set_debug_mode(mode, fileName);

        public static short GetDebugMode(out ushort mode, out string fileName)
        {
            IntPtr fileNamePtr = IntPtr.Zero;
            mode = 0;
            var result = LTDMC.dmc_get_debug_mode(ref mode, fileNamePtr);
            fileName = Marshal.PtrToStringUni(fileNamePtr);
            return result;
        }

        /// <summary>
        /// 硬件复位（适用于所有脉冲/总线卡）
        /// </summary>
        /// <returns>错误代码</returns>
        public static short BoardReset() => LTDMC.dmc_board_reset();

        public static short GetCardLibVersion(ref uint LibVer) => LTDMC.dmc_get_card_lib_version(ref LibVer);

        public short GetCardSoftVersion(ref uint firmID, ref uint subFirmID) => LTDMC.dmc_get_card_soft_version(CardNo, ref firmID, ref subFirmID);

        public short CoolReset() => LTDMC.dmc_cool_reset(CardNo);

        public short CheckDone(ushort axis) => LTDMC.dmc_check_done(CardNo, axis);

        public short GetEmgMode(ushort axis, ref ushort enbale, ref ushort logic) => LTDMC.dmc_get_emg_mode(CardNo, axis, ref enbale, ref logic);

        public short SetEmgMode(ushort axis, ushort enable, ushort logic) => LTDMC.dmc_set_emg_mode(CardNo, axis, enable, logic);

        public short GetSProfile(ushort CardNo, ushort axis, ushort sMode, ref double sPara) => LTDMC.dmc_get_s_profile(CardNo, axis, sMode, ref sPara);

        public short SetSProfile(ushort axis, ushort sMode, double sPara) => LTDMC.dmc_set_s_profile(CardNo, axis, sMode, sPara);

        public short VMove(ushort axis, ushort dir) => LTDMC.dmc_vmove(CardNo, axis, dir);

        public short Stop(ushort axis, ushort stopMode) => LTDMC.dmc_stop(CardNo, axis, stopMode);

        public short HandwheelMove(ushort axis) => LTDMC.dmc_handwheel_move(CardNo, axis);

        public short GetFactorError(ushort axis, ref double factor, ref int error) => LTDMC.dmc_get_factor_error(CardNo, axis, ref factor, ref error);

        public short SetFactorError(ushort axis, double factor, int error) => LTDMC.dmc_set_factor_error(CardNo, axis, factor, error);

        public short CheckSuccessPulse(ushort axis) => LTDMC.dmc_check_success_pulse(CardNo, axis);

        public short CheckSuccessEncoder(ushort axis) => LTDMC.dmc_check_success_encoder(CardNo, axis);

        public short ReadInbit(ushort bitNo) => LTDMC.dmc_read_inbit(CardNo, bitNo);

        public short ReadOutbit(ushort bitNo) => LTDMC.dmc_read_outbit(CardNo, bitNo);

        public short WriteOutbit(ushort bitNo, ushort onOff) => LTDMC.dmc_write_outbit(CardNo, bitNo, onOff);

        public uint ReadInport(ushort portNo) => LTDMC.dmc_read_inport(CardNo, portNo);

        public uint ReadOutport(ushort portNo) => LTDMC.dmc_read_outport(CardNo, portNo);

        public short WriteOutport(ushort portNo, uint outportVal) => LTDMC.dmc_write_outport(CardNo, portNo, outportVal);

        public short ReverseOutbit(ushort bitNo, double reverseTime) => LTDMC.dmc_reverse_outbit(CardNo, bitNo, reverseTime);

        public short GetIOCountMode(ushort bitNo, ref ushort mode, ref double filterTime) => LTDMC.dmc_get_io_count_mode(CardNo, bitNo, ref mode, ref filterTime);

        public short SetIOCountMode(ushort bitNo, ushort mode, double filterTime) => LTDMC.dmc_set_io_count_mode(CardNo, bitNo, mode, filterTime);

        public short GetIOCountValue(ushort bitNo, ref uint countValue) => LTDMC.dmc_get_io_count_value(CardNo, bitNo, ref countValue);

        public short SetIOCountValue(ushort bitNo, uint countValue) => LTDMC.dmc_set_io_count_value(CardNo, bitNo, countValue);

        public short CompareGetConfig(ushort axis, ref ushort enable, ref ushort cmpSource) => LTDMC.dmc_compare_get_config(CardNo, axis, ref enable, ref cmpSource);

        public short CompareSetConfig(ushort axis, ushort enable, ushort cmpSource) => LTDMC.dmc_compare_set_config(CardNo, axis, enable, cmpSource);

        public short CompareClearPoints(ushort axis) => LTDMC.dmc_compare_clear_points(CardNo, axis);

        public short CompareAddPoint(ushort axis, int pos, ushort dir, ushort action, uint actpara) => LTDMC.dmc_compare_add_point(CardNo, axis, pos, dir, action, actpara);

        public short CompareGetPointsRunned(ushort axis, ref int pointNum) => LTDMC.dmc_compare_get_points_runned(CardNo, axis, ref pointNum);

        public short CompareGetPointsRemained(ushort axis, ref int pointNum) => LTDMC.dmc_compare_get_points_remained(CardNo, axis, ref pointNum);

        public short CompareGetConfigExtern(ref ushort enable, ref ushort cmpSource) => LTDMC.dmc_compare_get_config_extern(CardNo, ref enable, ref cmpSource);

        public short CompareSetConfigExtern(ushort enable, ushort cmpSource) => LTDMC.dmc_compare_set_config_extern(CardNo, enable, cmpSource);

        public short CompareClearPointsExtern() => LTDMC.dmc_compare_clear_points_extern(CardNo);

        public short CompareGetCurrentPointExtern(int[] pos) => LTDMC.dmc_compare_get_current_point_extern(CardNo, pos);

        public short CompareAddPointExtern(ushort[] axis, int[] pos, ushort[] dir, ushort action, uint actpara) => LTDMC.dmc_compare_add_point_extern(CardNo, axis, pos, dir, action, actpara);

        public short CompareGetPointsRunnedExtern(ref int pointNum) => LTDMC.dmc_compare_get_points_remained_extern(CardNo, ref pointNum);

        public short CompareGetPointsRemainedExtern(ref int pointNum) => LTDMC.dmc_compare_get_points_remained_extern(CardNo, ref pointNum);

        public short HcmpGetMode(ushort hcmp, ref ushort cmpEnable) => LTDMC.dmc_hcmp_get_mode(CardNo, hcmp, ref cmpEnable);

        public short HcmpSetMode(ushort hcmp, ushort cmpEnable) => LTDMC.dmc_hcmp_set_mode(CardNo, hcmp, cmpEnable);

        public short HcmpGetConfig(ushort hcmp, ref ushort axis, ref ushort cmpSource, ref ushort cmpLogic, ref int time) => LTDMC.dmc_hcmp_get_config(CardNo, hcmp, ref axis, ref cmpSource, ref cmpLogic, ref time);

        public short HcmpSetConfig(ushort hcmp, ushort axis, ushort cmpSource, ushort cmpLogic, int time) => LTDMC.dmc_hcmp_set_config(CardNo, hcmp, axis, cmpSource, cmpLogic, time);

        public short HcmpGetLiner(ushort hcmp, ref int increment, ref int count) => LTDMC.dmc_hcmp_get_liner(CardNo, hcmp, ref increment, ref count);

        public short HcmpSetLiner(ushort hcmp, int increment, int count) => LTDMC.dmc_hcmp_set_liner(CardNo, hcmp, increment, count);

        public short HcmpClearPoints(ushort hcmp) => LTDMC.dmc_hcmp_clear_points(CardNo, hcmp);

        public short HcmpAddPoint(ushort hcmp, int cmpPos) => LTDMC.dmc_hcmp_add_point(CardNo, hcmp, cmpPos);

        public short ReadCmpPin(ushort hcmp) => LTDMC.dmc_read_cmp_pin(CardNo, hcmp);

        public short WriteCmpPin(ushort hcmp, ushort onOff) => LTDMC.dmc_write_cmp_pin(CardNo, hcmp, onOff);

        public short GetAxisIOMap(ushort axis, ushort ioType, ref ushort mapIoType, ref ushort mapIoIndex, ref double filter) => LTDMC.dmc_get_axis_io_map(CardNo, axis, ioType, ref mapIoType, ref mapIoIndex, ref filter);

        public short SetAxisIOMap(ushort axis, ushort ioType, ushort mapIoType, ushort mapIoIndex, double filter) => LTDMC.dmc_set_axis_io_map(CardNo, axis, ioType, mapIoType, mapIoIndex, filter);
    }
}
