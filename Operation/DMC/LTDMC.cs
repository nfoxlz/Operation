using System;
using System.Runtime.InteropServices;

namespace Operation.DMC //命名空间根据应用程序修改
{
    public delegate uint DMC3K5K_OPERATE(IntPtr operate_data);
    internal partial class LTDMC
    {
        //设置和读取打印模式（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_debug_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_debug_mode(ushort mode, string FileName);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_debug_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_debug_mode(ref ushort mode, IntPtr FileName);
        //---------------------   板卡初始和配置函数  ----------------------
        //初始化控制卡（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_board_init", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_board_init();
        //硬件复位（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_board_reset", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_board_reset();
        //关闭控制卡（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_board_close", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_board_close();
        //控制卡热复位（适用于EtherCAT、RTEX总线卡）  
        [DllImport("LTDMC.dll")]
        public static extern short dmc_soft_reset(ushort CardNo);
        //控制卡冷复位（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_cool_reset(ushort CardNo);
        //控制卡初始复位（适用于EtherCAT总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_original_reset", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_original_reset(ushort CardNo);
        //读取控制卡信息列表（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_CardInfList", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_CardInfList(ref ushort CardNum, uint[] CardTypeList, ushort[] CardIdList);
        //读取发布版本号（适用于DMC3000/DMC5X10系列脉冲卡、EtherCAT总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_card_version", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_card_version(ushort CardNo, ref uint CardVersion);
        //读取控制卡硬件的固件版本（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_card_soft_version", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_card_soft_version(ushort CardNo, ref uint FirmID, ref uint SubFirmID);
        //读取控制卡动态库版本（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_card_lib_version", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_card_lib_version(ref uint LibVer);
        //读取发布版本号（适用于DMC3000/DMC5X10系列脉冲卡、EtherCAT总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_release_version", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_release_version(ushort ConnectNo, byte[] ReleaseVersion);
        //读取指定卡轴数（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_total_axes", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_total_axes(ushort CardNo, ref uint TotalAxis);
        //获取本地IO点数（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_total_ionum", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_total_ionum(ushort CardNo, ref ushort TotalIn, ref ushort TotalOut);
        //获取本地ADDA输入输出数（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_total_adcnum", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_total_adcnum(ushort CardNo, ref ushort TotalIn, ref ushort TotalOut);
        //读取指定卡插补坐标系数（保留）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_total_liners", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_total_liners(ushort CardNo, ref uint TotalLiner);
        //定制类（保留）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_board_init_onecard", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_board_init_onecard(ushort CardNo);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_board_close_onecard", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_board_close_onecard(ushort CardNo);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_board_reset_onecard", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_board_reset_onecard(ushort CardNo);

        //密码函数（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_write_sn", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_write_sn(ushort CardNo, string new_sn);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_check_sn", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_check_sn(ushort CardNo, string check_sn);
        //登入sn20191101（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_enter_password_ex(ushort CardNo, string str_pass);

        //---------------------运动模块脉冲模式------------------
        //脉冲模式（适用于所有脉冲卡）	
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_pulse_outmode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_pulse_outmode(ushort CardNo, ushort axis, ushort outmode);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_pulse_outmode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_pulse_outmode(ushort CardNo, ushort axis, ref ushort outmode);
        //脉冲当量（适用于EtherCAT总线卡、RTEX总线卡、DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_equiv", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_equiv(ushort CardNo, ushort axis, ref double equiv);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_equiv", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_equiv(ushort CardNo, ushort axis, double equiv);
        //反向间隙(脉冲)（适用于DMC5000系列脉冲卡）	
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_backlash_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_backlash_unit(ushort CardNo, ushort axis, double backlash);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_backlash_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_backlash_unit(ushort CardNo, ushort axis, ref double backlash);

        //通用文件下载
        [DllImport("LTDMC.dll", EntryPoint = "dmc_download_file", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_download_file(ushort CardNo, string pfilename, byte[] pfilenameinControl, ushort filetype);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_upload_file", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_upload_file(ushort CardNo, string pfilename, byte[] pfilenameinControl, ushort filetype);
        //下载内存文件 总线卡（适用于EtherCAT总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_download_memfile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_download_memfile(ushort CardNo, byte[] pbuffer, uint buffsize, byte[] pfilenameinControl, ushort filetype);
        //上传内存文件（适用于EtherCAT总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_upload_memfile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_upload_memfile(ushort CardNo, byte[] pbuffer, uint buffsize, byte[] pfilenameinControl, ref uint puifilesize, ushort filetype);
        //文件进度（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_progress(ushort CardNo, ref float process);
        //下载参数文件（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_download_configfile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_download_configfile(ushort CardNo, string FileName);
        //下载固件文件（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_download_firmware", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_download_firmware(ushort CardNo, string FileName);

        //----------------------限位异常设置-------------------------------	
        //设置读取软限位参数（适用于E3032总线卡、R3032总线卡、DMC3000/5000/5X10系列脉冲卡）	
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_softlimit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_softlimit(ushort CardNo, ushort axis, ushort enable, ushort source_sel, ushort SL_action, int N_limit, int P_limit);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_softlimit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_softlimit(ushort CardNo, ushort axis, ref ushort enable, ref ushort source_sel, ref ushort SL_action, ref int N_limit, ref int P_limit);
        //设置读取软限位参数unit（适用于DMC5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_softlimit_unit(ushort CardNo, ushort axis, ushort enable, ushort source_sel, ushort SL_action, double N_limit, double P_limit);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_softlimit_unit(ushort CardNo, ushort axis, ref ushort enable, ref ushort source_sel, ref ushort SL_action, ref double N_limit, ref double P_limit);
        //设置读取EL信号（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_el_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_el_mode(ushort CardNo, ushort axis, ushort el_enable, ushort el_logic, ushort el_mode);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_el_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_el_mode(ushort CardNo, ushort axis, ref ushort el_enable, ref ushort el_logic, ref ushort el_mode);
        //设置读取EMG信号（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_emg_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_emg_mode(ushort CardNo, ushort axis, ushort enable, ushort emg_logic);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_emg_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_emg_mode(ushort CardNo, ushort axis, ref ushort enbale, ref ushort emg_logic);
        //外部减速停止信号及减速停止时间设置，毫秒为单位（保留）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_dstp_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_dstp_mode(ushort CardNo, ushort axis, ushort enable, ushort logic, uint time);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_dstp_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_dstp_mode(ushort CardNo, ushort axis, ref ushort enable, ref ushort logic, ref uint time);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_dstp_time", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_dstp_time(ushort CardNo, ushort axis, uint time);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_dstp_time", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_dstp_time(ushort CardNo, ushort axis, ref uint time);
        //外部减速停止信号及减速停止时间设置，秒为单位（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_io_dstp_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_io_dstp_mode(ushort CardNo, ushort axis, ushort enable, ushort logic);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_io_dstp_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_io_dstp_mode(ushort CardNo, ushort axis, ref ushort enable, ref ushort logic);
        //点位运动减速停止时间设置读取（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_dec_stop_time", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_dec_stop_time(ushort CardNo, ushort axis, double stop_time);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_dec_stop_time", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_dec_stop_time(ushort CardNo, ushort axis, ref double stop_time);
        //插补减速停止信号和减速时间设置（适用于DMC5X10系列脉冲卡、EthreCAT总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_vector_dec_stop_time(ushort CardNo, ushort Crd, double stop_time);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_vector_dec_stop_time(ushort CardNo, ushort Crd, ref double stop_time);
        //IO减速停止距离（适用于DMC3000、DMC5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_dec_stop_dist(ushort CardNo, ushort axis, int dist);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_dec_stop_dist(ushort CardNo, ushort axis, ref int dist);
        //IO减速停止，支持pmove/vmove运动（适用于DMC3000、DMC5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_io_exactstop(ushort CardNo, ushort axis, ushort ioNum, ushort[] ioList, ushort enable, ushort valid_logic, ushort action, ushort move_dir);
        //设置通用输入口的一位减速停止IO口（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_io_dstp_bitno(ushort CardNo, ushort axis, ushort bitno, double filter);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_io_dstp_bitno(ushort CardNo, ushort axis, ref ushort bitno, ref double filter);

        //---------------------------单轴运动----------------------
        //设定读取速度曲线参数	（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_profile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_profile(ushort CardNo, ushort axis, double Min_Vel, double Max_Vel, double Tacc, double Tdec, double stop_vel);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_profile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_profile(ushort CardNo, ushort axis, ref double Min_Vel, ref double Max_Vel, ref double Tacc, ref double Tdec, ref double stop_vel);
        //速度设置(脉冲当量)（适用于EtherCAT总线卡、RTEX总线卡、DMC5000/5X10系列脉冲卡）	
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_profile_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_profile_unit(ushort CardNo, ushort Axis, double Min_Vel, double Max_Vel, double Tacc, double Tdec, double Stop_Vel);   //单轴速度参数
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_profile_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_profile_unit(ushort CardNo, ushort Axis, ref double Min_Vel, ref double Max_Vel, ref double Tacc, ref double Tdec, ref double Stop_Vel);
        //速度曲线设置，加速度值表示(脉冲)（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_acc_profile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_acc_profile(ushort CardNo, ushort axis, double Min_Vel, double Max_Vel, double Tacc, double Tdec, double stop_vel);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_acc_profile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_acc_profile(ushort CardNo, ushort axis, ref double Min_Vel, ref double Max_Vel, ref double Tacc, ref double Tdec, ref double stop_vel);
        //速度曲线设置，加速度值表示(当量)（适用于EtherCAT总线卡、RTEX总线卡、DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_profile_unit_acc", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_profile_unit_acc(ushort CardNo, ushort Axis, double Min_Vel, double Max_Vel, double Tacc, double Tdec, double Stop_Vel);   //单轴速度参数
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_profile_unit_acc", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_profile_unit_acc(ushort CardNo, ushort Axis, ref double Min_Vel, ref double Max_Vel, ref double Tacc, ref double Tdec, ref double Stop_Vel);
        //设置读取平滑速度曲线参数（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_s_profile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_s_profile(ushort CardNo, ushort axis, ushort s_mode, double s_para);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_s_profile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_s_profile(ushort CardNo, ushort axis, ushort s_mode, ref double s_para);
        //点位运动(脉冲)（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_pmove", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_pmove(ushort CardNo, ushort axis, int Dist, ushort posi_mode);
        //点位运动(当量)（适用于EtherCAT总线卡、RTEX总线卡、DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_pmove_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_pmove_unit(ushort CardNo, ushort axis, double Dist, ushort posi_mode);
        //指定轴做定长位移运动 同时发送速度和S时间(脉冲)（适用于DMC5X10系列脉冲卡）	
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pmove_extern(ushort CardNo, ushort axis, double dist, double Min_Vel, double Max_Vel, double Tacc, double Tdec, double stop_Vel, double s_para, ushort posi_mode);
        //在线变位(脉冲)，运动中改变目标位置（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_reset_target_position", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_reset_target_position(ushort CardNo, ushort axis, int dist, ushort posi_mode);
        //变速变位(当量)（适用于EtherCAT总线卡、RTEX总线卡、DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_reset_target_position_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_reset_target_position_unit(ushort CardNo, ushort Axis, double New_Pos);
        //在线变速(脉冲)，运动中改变指定轴的当前运动速度（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_change_speed", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_change_speed(ushort CardNo, ushort axis, double Curr_Vel, double Taccdec);
        //在线变速(当量)，运动中改变指定轴的当前运动速度（适用于EtherCAT总线卡、RTEX总线卡、DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_change_speed_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_change_speed_unit(ushort CardNo, ushort Axis, double New_Vel, double Taccdec);
        //无论运动与否强行改变目标位置（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_update_target_position", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_update_target_position(ushort CardNo, ushort axis, int dist, ushort posi_mode);
        //强行变位扩展（适用于DMC5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_update_target_position_extern(ushort CardNo, ushort axis, double mid_pos, double aim_pos, double vel, ushort posi_mode);
        //在线变速(当量)，运动中改变指定轴的当前运动速度（适用于EtherCAT总线卡、RTEX总线卡、DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_update_target_position_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_update_target_position_unit(ushort CardNo, ushort Axis, double New_Pos);
        //---------------------JOG运动--------------------
        //单轴连续速度运动（适用于所有脉冲/总线卡）	
        [DllImport("LTDMC.dll", EntryPoint = "dmc_vmove", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_vmove(ushort CardNo, ushort axis, ushort dir);

        //---------------------插补运动--------------------
        //插补速度设置(脉冲)（适用于DMC3000系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_vector_profile_multicoor", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_vector_profile_multicoor(ushort CardNo, ushort Crd, double Min_Vel, double Max_Vel, double Tacc, double Tdec, double Stop_Vel);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_vector_profile_multicoor", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_vector_profile_multicoor(ushort CardNo, ushort Crd, ref double Min_Vel, ref double Max_Vel, ref double Taccdec, ref double Tdec, ref double Stop_Vel);
        //设置读取平滑速度曲线参数（适用于DMC3000系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_vector_s_profile_multicoor(ushort CardNo, ushort Crd, ushort s_mode, double s_para);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_vector_s_profile_multicoor(ushort CardNo, ushort Crd, ushort s_mode, ref double s_para);
        //插补速度参数(当量)（适用于EtherCAT总线卡、RTEX总线卡、DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_vector_profile_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_vector_profile_unit(ushort CardNo, ushort Crd, double Min_Vel, double Max_Vel, double Tacc, double Tdec, double Stop_Vel);   //单段插补速度参数
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_vector_profile_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_vector_profile_unit(ushort CardNo, ushort Crd, ref double Min_Vel, ref double Max_Vel, ref double Tacc, ref double Tdec, ref double Stop_Vel);
        //设置平滑速度曲线参数（适用于EtherCAT总线卡、RTEX总线卡、DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_vector_s_profile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_vector_s_profile(ushort CardNo, ushort Crd, ushort s_mode, double s_para);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_vector_s_profile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_vector_s_profile(ushort CardNo, ushort Crd, ushort s_mode, ref double s_para);
        //直线插补运动（适用于DMC3000系列脉冲卡）	
        [DllImport("LTDMC.dll", EntryPoint = "dmc_line_multicoor", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_line_multicoor(ushort CardNo, ushort crd, ushort axisNum, ushort[] axisList, int[] DistList, ushort posi_mode);
        //圆弧插补运动（适用于DMC3000系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_arc_move_multicoor", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_arc_move_multicoor(ushort CardNo, ushort crd, ushort[] AxisList, int[] Target_Pos, int[] Cen_Pos, ushort Arc_Dir, ushort posi_mode);
        //直线插补(当量)（适用于EtherCAT总线卡、RTEX总线卡、DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_line_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_line_unit(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] Target_Pos, ushort posi_mode);    //单段直线
        //圆心圆弧插补(当量)（适用于EtherCAT总线卡、RTEX总线卡、DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_arc_move_center_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_arc_move_center_unit(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] Target_Pos, double[] Cen_Pos, ushort Arc_Dir, int Circle, ushort posi_mode);     //圆心终点式圆弧/螺旋线/渐开线
        //半径圆弧插补(当量)（适用于EtherCAT总线卡、RTEX总线卡、DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_arc_move_radius_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_arc_move_radius_unit(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] Target_Pos, double Arc_Radius, ushort Arc_Dir, int Circle, ushort posi_mode);    //半径终点式圆弧/螺旋线
        //三点圆弧插补(当量)（适用于EtherCAT总线卡、RTEX总线卡、DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_arc_move_3points_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_arc_move_3points_unit(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] Target_Pos, double[] Mid_Pos, int Circle, ushort posi_mode);     //三点式圆弧/螺旋线
        //矩形插补(当量)（适用于EtherCAT总线卡、RTEX总线卡、DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_rectangle_move_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_rectangle_move_unit(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] TargetPos, double[] MaskPos, int Count, ushort rect_mode, ushort posi_mode);     //矩形区域插补，单段插补指令

        //----------------------PVT运动---------------------------
        //PVT运动旧版 （适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_PvtTable", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_PvtTable(ushort CardNo, ushort iaxis, uint count, double[] pTime, int[] pPos, double[] pVel);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_PtsTable", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_PtsTable(ushort CardNo, ushort iaxis, uint count, double[] pTime, int[] pPos, double[] pPercent);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_PvtsTable", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_PvtsTable(ushort CardNo, ushort iaxis, uint count, double[] pTime, int[] pPos, double velBegin, double velEnd);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_PttTable", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_PttTable(ushort CardNo, ushort iaxis, uint count, double[] pTime, int[] pPos);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_PvtMove", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_PvtMove(ushort CardNo, ushort AxisNum, ushort[] AxisList);
        //PVT缓冲区添加
        [DllImport("LTDMC.dll")]
        public static extern short dmc_PttTable_add(ushort CardNo, ushort iaxis, ushort count, double[] pTime, long[] pPos);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_PtsTable_add(ushort CardNo, ushort iaxis, ushort count, double[] pTime, long[] pPos, double[] pPercent);
        //读取pvt剩余空间
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pvt_get_remain_space(ushort CardNo, ushort iaxis);
        //PVT运动 总线卡新规划，适用于EtherCAT总线卡
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pvt_table_unit(ushort CardNo, ushort iaxis, uint count, double[] pTime, double[] pPos, double[] pVel);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pts_table_unit(ushort CardNo, ushort iaxis, uint count, double[] pTime, double[] pPos, double[] pPercent);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pvts_table_unit(ushort CardNo, ushort iaxis, uint count, double[] pTime, double[] pPos, double velBegin, double velEnd);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_ptt_table_unit(ushort CardNo, ushort iaxis, uint count, double[] pTime, double[] pPos);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pvt_move(ushort CardNo, ushort AxisNum, ushort[] AxisList);
        //其它类（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_SetGearProfile(ushort CardNo, ushort axis, ushort MasterType, ushort MasterIndex, int MasterEven, int SlaveEven, uint MasterSlope);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_GetGearProfile(ushort CardNo, ushort axis, ref ushort MasterType, ref ushort MasterIndex, ref uint MasterEven, ref uint SlaveEven, ref uint MasterSlope);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_GearMove(ushort CardNo, ushort AxisNum, ushort[] AxisList);

        //--------------------回零运动---------------------
        //设置读取HOME信号（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_home_pin_logic", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_home_pin_logic(ushort CardNo, ushort axis, ushort org_logic, double filter);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_home_pin_logic", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_home_pin_logic(ushort CardNo, ushort axis, ref ushort org_logic, ref double filter);
        //设定读取指定轴的回原点模式（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_homemode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_homemode(ushort CardNo, ushort axis, ushort home_dir, double vel, ushort mode, ushort EZ_count);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_homemode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_homemode(ushort CardNo, ushort axis, ref ushort home_dir, ref double vel, ref ushort home_mode, ref ushort EZ_count);
        //设置回零遇限位是否反找（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_home_el_return(ushort CardNo, ushort axis, ushort enable);
        //读取参数遇限位反找使能（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_home_el_return(ushort CardNo, ushort axis, ref ushort enable);
        //启动回零（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_home_move", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_home_move(ushort CardNo, ushort axis);
        //设置读取回零速度参数（适用于Rtex总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_home_profile_unit(ushort CardNo, ushort axis, double Low_Vel, double High_Vel, double Tacc, double Tdec);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_home_profile_unit(ushort CardNo, ushort axis, ref double Low_Vel, ref double High_Vel, ref double Tacc, ref double Tdec);
        //读取回零执行状态（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_home_result(ushort CardNo, ushort axis, ref ushort state);
        //设置读取回零偏移量及清零模式（适用于DMC5X10脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_home_position_unit(ushort CardNo, ushort axis, ushort enable, double position);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_home_position_unit(ushort CardNo, ushort axis, ref ushort enable, ref double position);
        //（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_el_home(ushort CardNo, ushort axis, ushort mode);
        //回零偏移模式函数（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_home_shift_param(ushort CardNo, ushort axis, ushort pos_clear_mode, double ShiftValue);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_home_shift_param(ushort CardNo, ushort axis, ref ushort pos_clear_mode, ref double ShiftValue);
        //设置回零偏移量及偏移模式（适用于DMC3000系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_home_position(ushort CardNo, ushort axis, ushort enable, double position);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_home_position(ushort CardNo, ushort axis, ref ushort enable, ref double position);
        //设置回零限位距离（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_home_soft_limit(ushort CardNo, ushort Axis, int N_limit, int P_limit);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_home_soft_limit(ushort CardNo, ushort Axis, ref int N_limit, ref int P_limit);

        //--------------------原点锁存-------------------
        //设置读取EZ锁存模式（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_homelatch_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_homelatch_mode(ushort CardNo, ushort axis, ushort enable, ushort logic, ushort source);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_homelatch_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_homelatch_mode(ushort CardNo, ushort axis, ref ushort enable, ref ushort logic, ref ushort source);
        //读取原点锁存标志（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_homelatch_flag", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_homelatch_flag(ushort CardNo, ushort axis);
        //清除原点锁存标志（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_reset_homelatch_flag", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_reset_homelatch_flag(ushort CardNo, ushort axis);
        //读取原点锁存值（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_homelatch_value", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int dmc_get_homelatch_value(ushort CardNo, ushort axis);
        //读取原点锁存值（unit）（适用于DMC5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_homelatch_value_unit(ushort CardNo, ushort axis, ref double pos);

        //--------------------EZ锁存-------------------
        //设置读取EZ锁存模式（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_ezlatch_mode(ushort CardNo, ushort axis, ushort enable, ushort logic, ushort source);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_ezlatch_mode(ushort CardNo, ushort axis, ref ushort enable, ref ushort logic, ref ushort source);
        //读取EZ锁存标志（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_ezlatch_flag(ushort CardNo, ushort axis);
        //清除EZ锁存标志（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_reset_ezlatch_flag(ushort CardNo, ushort axis);
        //读取EZ锁存值（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern int dmc_get_ezlatch_value(ushort CardNo, ushort axis);
        //读取EZ锁存值（unit）（适用于DMC5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_ezlatch_value_unit(ushort CardNo, ushort axis, ref double pos);

        //--------------------手轮运动---------------------	
        //设置读取手轮通道（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_handwheel_channel", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_handwheel_channel(ushort CardNo, ushort index);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_handwheel_channel", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_handwheel_channel(ushort CardNo, ref ushort index);
        //设置读取单轴手轮脉冲信号的工作方式（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_handwheel_inmode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_handwheel_inmode(ushort CardNo, ushort axis, ushort inmode, int multi, double vh);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_handwheel_inmode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_handwheel_inmode(ushort CardNo, ushort axis, ref ushort inmode, ref int multi, ref double vh);
        //设置读取单轴手轮脉冲信号的工作方式，浮点型倍率（适用于DMC5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_handwheel_inmode_decimals", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_handwheel_inmode_decimals(ushort CardNo, ushort axis, ushort inmode, double multi, double vh);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_handwheel_inmode_decimals", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_handwheel_inmode_decimals(ushort CardNo, ushort axis, ref ushort inmode, ref double multi, ref double vh);
        //设置读取多轴手轮脉冲信号的工作方式（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_handwheel_inmode_extern", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_handwheel_inmode_extern(ushort CardNo, ushort inmode, ushort AxisNum, ushort[] AxisList, int[] multi);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_handwheel_inmode_extern", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_handwheel_inmode_extern(ushort CardNo, ref ushort inmode, ref ushort AxisNum, ushort[] AxisList, int[] multi);
        //设置读取单轴手轮脉冲信号的工作方式，浮点型倍率（适用于DMC5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_handwheel_inmode_extern_decimals(ushort CardNo, ushort inmode, ushort AxisNum, ushort[] AxisList, double[] multi);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_handwheel_inmode_extern_decimals(ushort CardNo, ref ushort inmode, ref ushort AxisNum, ushort[] AxisList, double[] multi);
        //启动手轮运动（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_handwheel_move", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_handwheel_move(ushort CardNo, ushort axis);
        //手轮运动 新增总线的手轮模式  (保留)
        [DllImport("LTDMC.dll")]
        public static extern short dmc_handwheel_set_axislist(ushort CardNo, ushort AxisSelIndex, ushort AxisNum, ushort[] AxisList);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_handwheel_get_axislist(ushort CardNo, ushort AxisSelIndex, ref ushort AxisNum, ushort[] AxisList);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_handwheel_set_ratiolist(ushort CardNo, ushort AxisSelIndex, ushort StartRatioIndex, ushort RatioSelNum, double[] RatioList);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_handwheel_get_ratiolist(ushort CardNo, ushort AxisSelIndex, ushort StartRatioIndex, ushort RatioSelNum, double[] RatioList);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_handwheel_set_mode(ushort CardNo, ushort InMode, ushort IfHardEnable);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_handwheel_get_mode(ushort CardNo, ref ushort InMode, ref ushort IfHardEnable);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_handwheel_set_index(ushort CardNo, ushort AxisSelIndex, ushort RatioSelIndex);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_handwheel_get_index(ushort CardNo, ref ushort AxisSelIndex, ref ushort RatioSelIndex);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_handwheel_stop(ushort CardNo);

        //-------------------------高速锁存-------------------
        //设置读取指定轴的LTC信号（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_ltc_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_ltc_mode(ushort CardNo, ushort axis, ushort ltc_logic, ushort ltc_mode, double filter);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_ltc_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_ltc_mode(ushort CardNo, ushort axis, ref ushort ltc_logic, ref ushort ltc_mode, ref double filter);
        //设置读到锁存方式（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_latch_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_latch_mode(ushort CardNo, ushort axis, ushort all_enable, ushort latch_source, ushort triger_chunnel);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_latch_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_latch_mode(ushort CardNo, ushort axis, ref ushort all_enable, ref ushort latch_source, ref ushort triger_chunnel);
        //读取编码器锁存器的值（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_latch_value", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int dmc_get_latch_value(ushort CardNo, ushort axis);
        //读取编码器锁存器的值unit（适用于DMC5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_latch_value_unit(ushort CardNo, ushort axis, ref double pos_by_mm);
        //读取锁存器标志（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_latch_flag", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_latch_flag(ushort CardNo, ushort axis);
        //复位锁存器标志（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_reset_latch_flag", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_reset_latch_flag(ushort CardNo, ushort axis);
        //按索引取值（适用DMC3000系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_latch_value_extern", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int dmc_get_latch_value_extern(ushort CardNo, ushort axis, ushort Index);
        //高速锁存（预留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_latch_value_extern_unit(ushort CardNo, ushort axis, ushort index, ref double pos_by_mm);//按索引取值读取 
        //读取锁存个数（适用DMC3000系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_latch_flag_extern", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_latch_flag_extern(ushort CardNo, ushort axis);
        //设置读取LTC反相输出（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_SetLtcOutMode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_SetLtcOutMode(ushort CardNo, ushort axis, ushort enable, ushort bitno);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_GetLtcOutMode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_GetLtcOutMode(ushort CardNo, ushort axis, ref ushort enable, ref ushort bitno);
        //LTC端口触发延时急停时间 单位us（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_latch_stop_time", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_latch_stop_time(ushort CardNo, ushort axis, int time);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_latch_stop_time", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_latch_stop_time(ushort CardNo, ushort axis, ref int time);
        //设置/回读LTC端口触发延时急停轴配置（适用于EtherCAT总线系列卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_latch_stop_axis(ushort CardNo, ushort latch, ushort num, ushort[] axislist);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_latch_stop_axis(ushort CardNo, ushort latch, ref ushort num, ushort[] axislist);

        //----------------------高速锁存 总线卡---------------------------
        //配置锁存器：锁存模式0-单次锁存，1-连续锁存；锁存边沿0-下降沿，1-上升沿，2-双边沿；滤波时间，单位us（适用于所有总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_ltc_set_mode(ushort CardNo, ushort latch, ushort ltc_mode, ushort ltc_logic, double filter);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_ltc_get_mode(ushort CardNo, ushort latch, ref ushort ltc_mode, ref ushort ltc_logic, ref double filter);
        //配置锁存源：0-指令位置，1-编码器反馈位置（适用于所有总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_ltc_set_source(ushort CardNo, ushort latch, ushort axis, ushort ltc_source);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_ltc_get_source(ushort CardNo, ushort latch, ushort axis, ref ushort ltc_source);
        //复位锁存器（适用于所有总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_ltc_reset(ushort CardNo, ushort latch);
        //读取锁存个数（适用于所有总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_ltc_get_number(ushort CardNo, ushort latch, ushort axis, ref int number);
        //读取锁存值（适用于所有总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_ltc_get_value_unit(ushort CardNo, ushort latch, ushort axis, ref double value);

        //-----------------------软锁存 所有卡---------------------------------
        //配置锁存器：锁存模式0-单次锁存，1-连续锁存；锁存边沿0-下降沿，1-上升沿，2-双边沿；滤波时间，单位us（适用于DMC5X10/3000系列脉冲卡、总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_softltc_set_mode(ushort ConnectNo, ushort latch, ushort ltc_enable, ushort ltc_mode, ushort ltc_inbit, ushort ltc_logic, double filter);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_softltc_get_mode(ushort ConnectNo, ushort latch, ref ushort ltc_enable, ref ushort ltc_mode, ref ushort ltc_inbit, ref ushort ltc_logic, ref double filter);
        //配置锁存源：0-指令位置，1-编码器反馈位置（适用于DMC5X10/3000系列脉冲卡、总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_softltc_set_source(ushort ConnectNo, ushort latch, ushort axis, ushort ltc_source);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_softltc_get_source(ushort ConnectNo, ushort latch, ushort axis, ref ushort ltc_source);
        //复位锁存器（适用于DMC5X10/3000系列脉冲卡、总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_softltc_reset(ushort ConnectNo, ushort latch);
        //读取锁存个数（适用于DMC5X10/3000系列脉冲卡、总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_softltc_get_number(ushort ConnectNo, ushort latch, ushort axis, ref int number);
        //读取锁存值（适用于DMC5X10系列脉冲卡、所有总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_softltc_get_value_unit(ushort ConnectNo, ushort latch, ushort axis, ref double value);

        //----------------------单轴低速位置比较-----------------------	
        //配置读取比较器（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_compare_set_config", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_compare_set_config(ushort CardNo, ushort axis, ushort enable, ushort cmp_source);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_compare_get_config", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_compare_get_config(ushort CardNo, ushort axis, ref ushort enable, ref ushort cmp_source);
        //清除所有比较点（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_compare_clear_points", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_compare_clear_points(ushort CardNo, ushort axis);
        //添加比较点（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_compare_add_point", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_compare_add_point(ushort CardNo, ushort axis, int pos, ushort dir, ushort action, uint actpara);
        //添加比较点（适用于所有DMC5X10脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_compare_add_point_unit(ushort CardNo, ushort cmp, double pos, ushort dir, ushort action, uint actpara);
        //添加比较点（适用于E3032/R3032）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_compare_add_point_cycle(ushort CardNo, ushort cmp, int pos, ushort dir, uint bitno, uint cycle, ushort level);
        //添加比较点unit（适用于E5032）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_compare_add_point_cycle_unit(ushort CardNo, ushort cmp, double pos, ushort dir, uint bitno, uint cycle, ushort level);
        //读取当前比较点（适用于所有脉冲卡、Rtex总线卡、E3032卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_compare_get_current_point", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_compare_get_current_point(ushort CardNo, ushort axis, ref int pos);
        //读取当前比较点（适用于DMC5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_compare_get_current_point_unit(ushort CardNo, ushort cmp, ref double pos);
        //查询已经比较过的点（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_compare_get_points_runned", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_compare_get_points_runned(ushort CardNo, ushort axis, ref int pointNum);
        //查询可以加入的比较点数量（适用于所有脉冲/总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_compare_get_points_remained", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_compare_get_points_remained(ushort CardNo, ushort axis, ref int pointNum);

        //-------------------二维低速位置比较-----------------------
        //配置读取比较器（适用于所有脉冲卡、EtherCAT总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_compare_set_config_extern", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_compare_set_config_extern(ushort CardNo, ushort enable, ushort cmp_source);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_compare_get_config_extern", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_compare_get_config_extern(ushort CardNo, ref ushort enable, ref ushort cmp_source);
        //清除所有比较点（适用于所有脉冲卡、EtherCAT总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_compare_clear_points_extern", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_compare_clear_points_extern(ushort CardNo);
        //添加两轴位置比较点（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_compare_add_point_extern", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_compare_add_point_extern(ushort CardNo, ushort[] axis, int[] pos, ushort[] dir, ushort action, uint actpara);
        //读取当前比较点（适用于所有脉冲卡、EtherCAT总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_compare_get_current_point_extern", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_compare_get_current_point_extern(ushort CardNo, int[] pos);
        //读取当前比较点unit（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_compare_get_current_point_extern_unit(ushort CardNo, double[] pos);
        //添加两轴位置比较点（适用于DMC5X10脉冲卡）      
        [DllImport("LTDMC.dll")]
        public static extern short dmc_compare_add_point_extern_unit(ushort CardNo, ushort[] axis, double[] pos, ushort[] dir, ushort action, uint actpara);
        //添加二维低速位置比较点（适用于EtherCAT总线系列卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_compare_add_point_cycle_2d(ushort CardNo, ushort[] axis, double[] pos, ushort[] dir, uint bitno, uint cycle, ushort level);
        //查询已经比较过的点（适用于所有脉冲卡、EtherCAT总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_compare_get_points_runned_extern", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_compare_get_points_runned_extern(ushort CardNo, ref int pointNum);
        //查询可以加入的比较点数量（适用于所有脉冲卡、EtherCAT总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_compare_get_points_remained_extern", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_compare_get_points_remained_extern(ushort CardNo, ref int pointNum);
        //多组位置比较（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_compare_set_config_multi(ushort CardNo, ushort queue, ushort enable, ushort axis, ushort cmp_source);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_compare_get_config_multi(ushort CardNo, ushort queue, ref ushort enable, ref ushort axis, ref ushort cmp_source);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_compare_add_point_multi(ushort CardNo, ushort cmp, int pos, ushort dir, ushort action, uint actpara, double times);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_compare_add_point_multi_unit(ushort CardNo, ushort cmp, double pos, ushort dir, ushort action, uint actpara, double times);//添加比较点 增强

        //----------- 单轴高速位置比较-----------------------        
        //设置读取高速比较模式（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_hcmp_set_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_hcmp_set_mode(ushort CardNo, ushort hcmp, ushort cmp_enable);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_hcmp_get_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_hcmp_get_mode(ushort CardNo, ushort hcmp, ref ushort cmp_enable);
        //设置高速比较参数（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_hcmp_set_config", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_hcmp_set_config(ushort CardNo, ushort hcmp, ushort axis, ushort cmp_source, ushort cmp_logic, int time);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_hcmp_get_config", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_hcmp_get_config(ushort CardNo, ushort hcmp, ref ushort axis, ref ushort cmp_source, ref ushort cmp_logic, ref int time);
        //高速比较模式扩展（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_set_config_extern(ushort CardNo, ushort hcmp, ushort axis, ushort cmp_source, ushort cmp_logic, ushort cmp_mode, int dist, int time);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_get_config_extern(ushort CardNo, ushort hcmp, ref ushort axis, ref ushort cmp_source, ref ushort cmp_logic, ref ushort cmp_mode, ref int dist, ref int time);
        //添加比较点（适用于所有脉冲卡、E3032总线卡、R3032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_hcmp_add_point", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_hcmp_add_point(ushort CardNo, ushort hcmp, int cmp_pos);
        //添加比较点unit（适用于DMC5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_add_point_unit(ushort CardNo, ushort hcmp, double cmp_pos);
        //设置读取线性模式参数（适用于所有脉冲卡、E3032总线卡、R3032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_hcmp_set_liner", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_hcmp_set_liner(ushort CardNo, ushort hcmp, int Increment, int Count);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_hcmp_get_liner", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_hcmp_get_liner(ushort CardNo, ushort hcmp, ref int Increment, ref int Count);
        //设置线性模式参数（适用于DMC5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_set_liner_unit(ushort CardNo, ushort hcmp, double Increment, int Count);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_get_liner_unit(ushort CardNo, ushort hcmp, ref double Increment, ref int Count);
        //读取高速比较状态（适用于所有脉冲卡、E3032总线卡、R3032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_hcmp_get_current_state", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_hcmp_get_current_state(ushort CardNo, ushort hcmp, ref int remained_points, ref int current_point, ref int runned_points);
        //读取高速比较状态（适用于DMC5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_get_current_state_unit(ushort CardNo, ushort hcmp, ref int remained_points, ref double current_point, ref int runned_points); //读取高速比较状态
        //清除比较点（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_hcmp_clear_points", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_hcmp_clear_points(ushort CardNo, ushort hcmp);
        //读取指定CMP端口的电平（保留）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_read_cmp_pin", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_read_cmp_pin(ushort CardNo, ushort hcmp);
        //控制cmp端口输出（保留）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_write_cmp_pin", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_write_cmp_pin(ushort CardNo, ushort hcmp, ushort on_off);
        //1、	启用缓存方式添加比较位置：（适用于DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_fifo_set_mode(ushort CardNo, ushort hcmp, ushort fifo_mode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_fifo_get_mode(ushort CardNo, ushort hcmp, ref ushort fifo_mode);
        //2、	读取剩余缓存状态，上位机通过此函数判断是否继续添加比较位置（适用于DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_fifo_get_state(ushort CardNo, ushort hcmp, ref long remained_points);
        //3、	按数组的方式批量添加比较位置（适用于DMC5000系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_fifo_add_point_unit(ushort CardNo, ushort hcmp, ushort num, double[] cmp_pos);
        //4、	清除比较位置,也会把FPGA的位置同步清除掉（适用于DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_fifo_clear_points(ushort CardNo, ushort hcmp);
        //添加大数据，会堵塞一段时间，指导数据添加完成（适用于DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_fifo_add_table(ushort CardNo, ushort hcmp, ushort num, double[] cmp_pos);
        //一维高速比较，队列模式添加的比较点关联运动方向，添加少量数据（适用于DMC5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_fifo_add_point_dir_unit(ushort CardNo, ushort hcmp, ushort num, double[] cmp_pos, uint dir);
        //一维高速比较，队列模式添加的比较点关联运动方向，添加大量数据（适用于DMC5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_fifo_add_table_dir(ushort CardNo, ushort hcmp, ushort num, double[] cmp_pos, uint dir);
        //----------- 二维高速位置比较-----------------------        
        //设置读取高速比较使能（适用于所有脉冲卡、EtherCAT总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_2d_set_enable(ushort CardNo, ushort hcmp, ushort cmp_enable);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_2d_get_enable(ushort CardNo, ushort hcmp, ref ushort cmp_enable);
        //配置读取二维高速比较器（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_2d_set_config(ushort CardNo, ushort hcmp, ushort cmp_mode, ushort x_axis, ushort x_cmp_source, ushort y_axis, ushort y_cmp_source, int error, ushort cmp_logic, int time, ushort pwm_enable, double duty, int freq, ushort port_sel, ushort pwm_number);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_2d_get_config(ushort CardNo, ushort hcmp, ref ushort cmp_mode, ref ushort x_axis, ref ushort x_cmp_source, ref ushort y_axis, ref ushort y_cmp_source, ref int error, ref ushort cmp_logic, ref int time, ref ushort pwm_enable, ref double duty, ref int freq, ref ushort port_sel, ref ushort pwm_number);
        //配置读取二维高速比较器（适用于DMC5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_2d_set_config_unit(ushort CardNo, ushort hcmp, ushort cmp_mode, ushort x_axis, ushort x_cmp_source, double x_cmp_error, ushort y_axis, ushort y_cmp_source, double y_cmp_error, ushort cmp_logic, int time);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_2d_get_config_unit(ushort CardNo, ushort hcmp, ref ushort cmp_mode, ref ushort x_axis, ref ushort x_cmp_source, ref double x_cmp_error, ref ushort y_axis, ref ushort y_cmp_source, ref double y_cmp_error, ref ushort cmp_logic, ref int time);
        //添加二维高速位置比较点（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_2d_add_point(ushort CardNo, ushort hcmp, int x_cmp_pos, int y_cmp_pos);
        //添加二维高速位置比较点unit（适用于DMC5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_2d_add_point_unit(ushort CardNo, ushort hcmp, double x_cmp_pos, double y_cmp_pos, ushort cmp_outbit);
        //读取二维高速比较参数（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_2d_get_current_state(ushort CardNo, ushort hcmp, ref int remained_points, ref int x_current_point, ref int y_current_point, ref int runned_points, ref ushort current_state);
        //读取二维高速比较参数（适用于DMC5X10系列脉冲卡、EtherCAT总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_2d_get_current_state_unit(ushort CardNo, ushort hcmp, ref int remained_points, ref double x_current_point, ref double y_current_point, ref int runned_points, ref ushort current_state, ref ushort current_outbit);
        //清除二维高速位置比较点（适用于所有脉冲卡、EtherCAT总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_2d_clear_points(ushort CardNo, ushort hcmp);
        //强制二维高速比较输出（适用于所有脉冲卡、EtherCAT总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_2d_force_output(ushort CardNo, ushort hcmp, ushort cmp_outbit);
        //配置读取二维比较PWM输出模式（适用于DMC5X10系列脉冲卡、EtherCAT总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_2d_set_pwmoutput(ushort CardNo, ushort hcmp, ushort pwm_enable, double duty, double freq, ushort pwm_number);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_2d_get_pwmoutput(ushort CardNo, ushort hcmp, ref ushort pwm_enable, ref double duty, ref double freq, ref ushort pwm_number);

        //------------------------通用IO-----------------------
        //读取输入口的状态（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_read_inbit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_read_inbit(ushort CardNo, ushort bitno);
        //设置输出口的状态（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_write_outbit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_write_outbit(ushort CardNo, ushort bitno, ushort on_off);
        //读取输出口的状态（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_read_outbit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_read_outbit(ushort CardNo, ushort bitno);
        //读取输入端口的值（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_read_inport", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern uint dmc_read_inport(ushort CardNo, ushort portno);
        //读取输出端口的值（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_read_outport", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern uint dmc_read_outport(ushort CardNo, ushort portno);
        //设置所有输出端口的值（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_write_outport", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_write_outport(ushort CardNo, ushort portno, uint outport_val);
        //设置通用输出端口的值（保留）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_write_outport_16X", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_write_outport_16X(ushort CardNo, ushort portno, uint outport_val);
        //---------------------------通用IO带返回值检测----------------------
        //读取输入口的状态（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_read_inbit_ex(ushort CardNo, ushort bitno, ref ushort state);
        //读取输出口的状态（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_read_outbit_ex(ushort CardNo, ushort bitno, ref ushort state);
        //读取输入端口的值（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_read_inport_ex(ushort CardNo, ushort portno, ref uint state);
        //读取输出端口的值（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_read_outport_ex(ushort CardNo, ushort portno, ref uint state);

        //设置读取虚拟IO映射关系（适用于所有脉冲卡） 
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_io_map_virtual", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_io_map_virtual(ushort CardNo, ushort bitno, ushort MapIoType, ushort MapIoIndex, double Filter);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_io_map_virtual", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_io_map_virtual(ushort CardNo, ushort bitno, ref ushort MapIoType, ref ushort MapIoIndex, ref double Filter);
        //读取虚拟输入口的状态（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_read_inbit_virtual", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_read_inbit_virtual(ushort CardNo, ushort bitno);
        //IO延时翻转（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_reverse_outbit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_reverse_outbit(ushort CardNo, ushort bitno, double reverse_time);
        //设置读取IO计数模式（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_io_count_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_io_count_mode(ushort CardNo, ushort bitno, ushort mode, double filter_time);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_io_count_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_io_count_mode(ushort CardNo, ushort bitno, ref ushort mode, ref double filter_time);
        //设置IO计数值（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_io_count_value", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_io_count_value(ushort CardNo, ushort bitno, uint CountValue);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_io_count_value", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_io_count_value(ushort CardNo, ushort bitno, ref uint CountValue);

        //-----------------------专用IO 脉冲卡专用-------------------------
        //设置读取轴IO映射关系（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_axis_io_map", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_axis_io_map(ushort CardNo, ushort Axis, ushort IoType, ushort MapIoType, ushort MapIoIndex, double Filter);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_axis_io_map", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_axis_io_map(ushort CardNo, ushort Axis, ushort IoType, ref ushort MapIoType, ref ushort MapIoIndex, ref double Filter);
        //设置所有专用IO滤波时间（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_special_input_filter", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_special_input_filter(ushort CardNo, double Filter);
        // 回原点减速信号配置，(DMC3410专用)
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_sd_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_sd_mode(ushort CardNo, ushort axis, ushort sd_logic, ushort sd_mode);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_sd_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_sd_mode(ushort CardNo, ushort axis, ref ushort sd_logic, ref ushort sd_mode);
        //设置读取INP信号（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_inp_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_inp_mode(ushort CardNo, ushort axis, ushort enable, ushort inp_logic);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_inp_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_inp_mode(ushort CardNo, ushort axis, ref ushort enable, ref ushort inp_logic);
        //设置读取RDY信号（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_rdy_mode(ushort CardNo, ushort axis, ushort enable, ushort rdy_logic);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_rdy_mode(ushort CardNo, ushort axis, ref ushort enable, ref ushort rdy_logic);
        //设置读取ERC信号（保留）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_erc_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_erc_mode(ushort CardNo, ushort axis, ushort enable, ushort erc_logic, ushort erc_width, ushort erc_off_time);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_erc_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_erc_mode(ushort CardNo, ushort axis, ref ushort enable, ref ushort erc_logic, ref ushort erc_width, ref ushort erc_off_time);
        //设置读取ALM信号（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_alm_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_alm_mode(ushort CardNo, ushort axis, ushort enable, ushort alm_logic, ushort alm_action);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_alm_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_alm_mode(ushort CardNo, ushort axis, ref ushort enable, ref ushort alm_logic, ref ushort alm_action);
        //设置读取EZ信号（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_ez_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_ez_mode(ushort CardNo, ushort axis, ushort ez_logic, ushort ez_mode, double filter);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_ez_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_ez_mode(ushort CardNo, ushort axis, ref ushort ez_logic, ref ushort ez_mode, ref double filter);
        //输出读取SEVON信号（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_write_sevon_pin", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_write_sevon_pin(ushort CardNo, ushort axis, ushort on_off);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_read_sevon_pin", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_read_sevon_pin(ushort CardNo, ushort axis);
        //控制ERC信号输出（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_write_erc_pin", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_write_erc_pin(ushort CardNo, ushort axis, ushort sel);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_read_erc_pin", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_read_erc_pin(ushort CardNo, ushort axis);
        //读取RDY状态（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_read_rdy_pin", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_read_rdy_pin(ushort CardNo, ushort axis);
        //输出伺服复位信号（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_write_sevrst_pin(ushort CardNo, ushort axis, ushort on_off);
        //读伺服复位信号（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_read_sevrst_pin(ushort CardNo, ushort axis);

        //---------------------编码器 脉冲卡---------------------
        //设定读取编码器的计数方式（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_counter_inmode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_counter_inmode(ushort CardNo, ushort axis, ushort mode);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_counter_inmode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_counter_inmode(ushort CardNo, ushort axis, ref ushort mode);
        //编码器值（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_encoder", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int dmc_get_encoder(ushort CardNo, ushort axis);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_encoder", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_encoder(ushort CardNo, ushort axis, int encoder_value);
        //编码器值(当量)（适用于DMC5000/5X10系列脉冲卡、所有总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_encoder_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_encoder_unit(ushort CardNo, ushort axis, double pos);     //当前反馈位置
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_encoder_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_encoder_unit(ushort CardNo, ushort axis, ref double pos);
        //---------------------辅助编码器 总线卡---------------------
        //手轮编码器（备用，同dmc_set_extra_encoder）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_handwheel_encoder(ushort CardNo, ushort channel, int pos);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_handwheel_encoder(ushort CardNo, ushort channel, ref int pos);
        //设置辅助编码模式（适用于所有总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_extra_encoder_mode(ushort CardNo, ushort channel, ushort inmode, ushort multi);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_extra_encoder_mode(ushort CardNo, ushort channel, ref ushort inmode, ref ushort multi);
        //设置辅助编码器值（适用于所有总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_extra_encoder(ushort CardNo, ushort channel, int pos);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_extra_encoder(ushort CardNo, ushort channel, ref int pos);
        //---------------------位置计数控制---------------------
        //当前位置(当量)（适用于DMC5000/5X10系列脉冲卡、所有总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_position_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_position_unit(ushort CardNo, ushort axis, double pos);   //当前指令位置
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_position_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_position_unit(ushort CardNo, ushort axis, ref double pos);
        //当前位置(脉冲)（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_position", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int dmc_get_position(ushort CardNo, ushort axis);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_position", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_position(ushort CardNo, ushort axis, int current_position);
        //--------------------运动状态----------------------	
        //读取指定轴的当前速度（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_read_current_speed", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern double dmc_read_current_speed(ushort CardNo, ushort axis);
        //读取当前速度(当量)（适用于DMC5000/5X10系列脉冲卡、所有总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_read_current_speed_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_read_current_speed_unit(ushort CardNo, ushort Axis, ref double current_speed);   //轴当前运行速度
        //读取当前卡的插补速度（适用于DMC5X10系列脉冲卡、所有总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_read_vector_speed_unit(ushort CardNo, ushort Crd, ref double current_speed);	//读取当前卡的插补速度
        //读取指定轴的目标位置（适用于所有脉冲卡、R3032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_target_position", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int dmc_get_target_position(ushort CardNo, ushort axis);
        //读取指定轴的目标位置(当量)（适用于DMC5X10系列脉冲卡、所有EtherCAT总线系列卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_target_position_unit(ushort CardNo, ushort axis, ref double pos);
        //读取指定轴的运动状态（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_check_done", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_check_done(ushort CardNo, ushort axis);
        //读取指定轴的运动状态（适用于所有卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_check_done_ex(ushort CardNo, ushort axis, ref ushort state);
        //插补运动状态（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_check_done_multicoor", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_check_done_multicoor(ushort CardNo, ushort crd);
        //读取指定轴有关运动信号的状态（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_axis_io_status", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern uint dmc_axis_io_status(ushort CardNo, ushort axis);
        //读取指定轴有关运动信号的状态（适用于所有卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_axis_io_status_ex(ushort CardNo, ushort axis, ref uint state);
        //单轴停止（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_stop", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_stop(ushort CardNo, ushort axis, ushort stop_mode);
        //停止插补器（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_stop_multicoor", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_stop_multicoor(ushort CardNo, ushort crd, ushort stop_mode);
        //紧急停止所有轴（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_emg_stop", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_emg_stop(ushort CardNo);
        //脉冲卡指令 主卡与接线盒通讯状态（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_LinkState", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_LinkState(ushort CardNo, ref ushort State);
        //读取指定轴的运动模式（适用于DMC5000/5X10系列脉冲卡、所有总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_axis_run_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_axis_run_mode(ushort CardNo, ushort axis, ref ushort run_mode);
        //读取轴停止原因（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_stop_reason", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_stop_reason(ushort CardNo, ushort axis, ref int StopReason);
        //清除轴停止原因（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_clear_stop_reason", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_clear_stop_reason(ushort CardNo, ushort axis);
        //trace功能（内部使用函数）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_trace", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_trace(ushort CardNo, ushort axis, ushort enable);   //trace功能
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_trace", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_trace(ushort CardNo, ushort axis, ref ushort enable);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_read_trace_data", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_read_trace_data(ushort CardNo, ushort axis, ushort data_option, ref int ReceiveSize, double[] time, double[] data, ref int remain_num);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_trace_start(ushort CardNo, ushort AxisNum, ushort[] AxisList);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_trace_stop(ushort CardNo);

        //弧长计算（备用）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_calculate_arclength_center", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_calculate_arclength_center(double[] start_pos, double[] target_pos, double[] cen_pos, ushort arc_dir, double circle, ref double ArcLength);      //计算圆心圆弧弧长
        [DllImport("LTDMC.dll", EntryPoint = "dmc_calculate_arclength_3point", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_calculate_arclength_3point(double[] start_pos, double[] mid_pos, double[] target_pos, double circle, ref double ArcLength);      //计算三点圆弧弧长
        [DllImport("LTDMC.dll", EntryPoint = "dmc_calculate_arclength_radius", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_calculate_arclength_radius(double[] start_pos, double[] target_pos, double arc_radius, ushort arc_dir, double circle, ref double ArcLength);     //计算半径圆弧弧长

        //--------------------CAN-IO扩展----------------------	
        //CAN-IO扩展，旧接口函数（保留）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_can_state", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_can_state(ushort CardNo, ushort NodeNum, ushort state, ushort Baud);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_can_state", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_can_state(ushort CardNo, ref ushort NodeNum, ref ushort state);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_write_can_outbit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_write_can_outbit(ushort CardNo, ushort Node, ushort bitno, ushort on_off);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_read_can_outbit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_read_can_outbit(ushort CardNo, ushort Node, ushort bitno);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_read_can_inbit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_read_can_inbit(ushort CardNo, ushort Node, ushort bitno);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_write_can_outport", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_write_can_outport(ushort CardNo, ushort Node, ushort PortNo, uint outport_val);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_read_can_outport", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern uint dmc_read_can_outport(ushort CardNo, ushort Node, ushort PortNo);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_read_can_inport", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern uint dmc_read_can_inport(ushort CardNo, ushort Node, ushort PortNo);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_can_errcode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_can_errcode(ushort CardNo, ref ushort Errcode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_can_errcode_extern(ushort CardNo, ref ushort Errcode, ref ushort msg_losed, ref ushort emg_msg_num, ref ushort lostHeartB, ref ushort EmgMsg);
        //设置CAN io输出（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_write_outbit(ushort CardNo, ushort NodeID, ushort IoBit, ushort IoValue);
        //读取CAN io输出（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_outbit(ushort CardNo, ushort NodeID, ushort IoBit, ref ushort IoValue);
        //读取CAN io输入（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_inbit(ushort CardNo, ushort NodeID, ushort IoBit, ref ushort IoValue);
        //设置CAN io输出32位（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_write_outport(ushort CardNo, ushort NodeID, ushort PortNo, uint IoValue);
        //读取CAN io输出32位（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_outport(ushort CardNo, ushort NodeID, ushort PortNo, ref uint IoValue);
        //读取CAN io输入32位（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_inport(ushort CardNo, ushort NodeID, ushort PortNo, ref uint IoValue);
        //---------------------------CAN IO带返回值检测----------------------
        //设置CAN io输出（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_write_outbit_ex(ushort CardNo, ushort NoteID, ushort IoBit, ushort IoValue, ref ushort state);
        //读取CAN io输出（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_outbit_ex(ushort CardNo, ushort NoteID, ushort IoBit, ref ushort IoValue, ref ushort state);
        //读取CAN io输入（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_inbit_ex(ushort CardNo, ushort NoteID, ushort IoBit, ref ushort IoValue, ref ushort state);
        //设置CAN io输出32位（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_write_outport_ex(ushort CardNo, ushort NoteID, ushort portno, uint outport_val, ref ushort state);
        //读取CAN io输出32位（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_outport_ex(ushort CardNo, ushort NoteID, ushort portno, ref uint outport_val, ref ushort state);
        //读取CAN io输入32位（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_inport_ex(ushort CardNo, ushort NoteID, ushort portno, ref uint inport_val, ref ushort state);
        //---------------------------CAN ADDA----------------------
        //CAN ADDA指令 设置DA参数 （适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_da_output(ushort CardNo, ushort NoteID, ushort channel, double Value);
        //读取CAN DA参数（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_da_output(ushort CardNo, ushort NoteID, ushort channel, ref double Value);
        //读取CAN AD参数（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_ad_input(ushort CardNo, ushort NoteID, ushort channel, ref double Value);
        //配置CAN AD模式（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_ad_mode(ushort CardNo, ushort NoteID, ushort channel, ushort mode, uint buffer_nums);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_ad_mode(ushort CardNo, ushort NoteID, ushort channel, ref ushort mode, uint buffer_nums);
        //配置CAN DA模式（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_da_mode(ushort CardNo, ushort NoteID, ushort channel, ushort mode, uint buffer_nums);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_da_mode(ushort CardNo, ushort NoteID, ushort channel, ref ushort mode, uint buffer_nums);
        //CAN参数写入flash（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_write_to_flash(ushort CardNo, ushort PortNum, ushort NodeNum);
        //CAN总线链接（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_connect_state(ushort CardNo, ushort NodeNum, ushort state, ushort baud);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_connect_state(ushort CardNo, ref ushort NodeNum, ref ushort state);
        //---------------------------CAN ADDA带返回值检测----------------------
        //设置CAN DA参数（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_da_output_ex(ushort CardNo, ushort NoteID, ushort channel, double Value, ref ushort state);
        //读取CAN DA参数（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_da_output_ex(ushort CardNo, ushort NoteID, ushort channel, ref double Value, ref ushort state);
        //读取CAN AD参数（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_ad_input_ex(ushort CardNo, ushort NoteID, ushort channel, ref double Value, ref ushort state);
        //配置CAN AD模式（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_ad_mode_ex(ushort CardNo, ushort NoteID, ushort channel, ushort mode, uint buffer_nums, ref ushort state);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_ad_mode_ex(ushort CardNo, ushort NoteID, ushort channel, ref ushort mode, uint buffer_nums, ref ushort state);
        //配置CAN DA模式（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_da_mode_ex(ushort CardNo, ushort NoteID, ushort channel, ushort mode, uint buffer_nums, ref ushort state);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_da_mode_ex(ushort CardNo, ushort NoteID, ushort channel, ref ushort mode, uint buffer_nums, ref ushort state);
        //参数写入flash（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_write_to_flash_ex(ushort CardNo, ushort PortNum, ushort NodeNum, ref ushort state);

        //--------------------连续插补函数----------------------	
        //打开连续缓存区（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_open_list", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_open_list(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList);
        //关闭连续缓存区（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_close_list", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_close_list(ushort CardNo, ushort Crd);
        //复位连续缓存区（预留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_reset_list(ushort CardNo, ushort Crd);
        //连续插补中停止（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_stop_list", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_stop_list(ushort CardNo, ushort Crd, ushort stop_mode);
        //连续插补中暂停（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_pause_list", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_pause_list(ushort CardNo, ushort Crd);
        //开始连续插补（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_start_list", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_start_list(ushort CardNo, ushort Crd);
        //检测连续插补运动状态：0-运行，1-暂停，2-正常停止（DMC5X10不支持），3-未启动，4-空闲（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_get_run_state", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_get_run_state(ushort CardNo, ushort Crd);
        //检测连续插补运动状态：0-运行，1-停止（预留）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_check_done", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_check_done(ushort CardNo, ushort Crd);
        //查连续插补剩余缓存数（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_remain_space", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int dmc_conti_remain_space(ushort CardNo, ushort Crd);
        //读取当前连续插补段的标号（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_read_current_mark", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern int dmc_conti_read_current_mark(ushort CardNo, ushort Crd);
        //blend拐角过度模式（适用于DMC5000系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_set_blend", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_set_blend(ushort CardNo, ushort Crd, ushort enable);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_get_blend", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_get_blend(ushort CardNo, ushort Crd, ref ushort enable);
        //设置每段速度比例  缓冲区指令（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_set_override", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_set_override(ushort CardNo, ushort Crd, double Percent);
        //设置插补中动态变速（适用于DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_change_speed_ratio", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_change_speed_ratio(ushort CardNo, ushort Crd, double Percent);
        //小线段前瞻（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_set_lookahead_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_set_lookahead_mode(ushort CardNo, ushort Crd, ushort enable, int LookaheadSegments, double PathError, double LookaheadAcc);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_get_lookahead_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_get_lookahead_mode(ushort CardNo, ushort Crd, ref ushort enable, ref int LookaheadSegments, ref double PathError, ref double LookaheadAcc);
        //--------------------连续插补IO功能----------------------
        //等待IO输入（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_wait_input", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_wait_input(ushort CardNo, ushort Crd, ushort bitno, ushort on_off, double TimeOut, int mark);
        //相对于轨迹起点IO滞后输出（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_delay_outbit_to_start", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_delay_outbit_to_start(ushort CardNo, ushort Crd, ushort bitno, ushort on_off, double delay_value, ushort delay_mode, double ReverseTime);
        //相对于轨迹终点IO滞后输出（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_delay_outbit_to_stop", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_delay_outbit_to_stop(ushort CardNo, ushort Crd, ushort bitno, ushort on_off, double delay_time, double ReverseTime);
        //相对于轨迹终点IO提前输出（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_ahead_outbit_to_stop", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_ahead_outbit_to_stop(ushort CardNo, ushort Crd, ushort bitno, ushort on_off, double ahead_value, ushort ahead_mode, double ReverseTime);
        //连续插补精确位置CMP输出（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_accurate_outbit_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_accurate_outbit_unit(ushort CardNo, ushort Crd, ushort cmp_no, ushort on_off, ushort map_axis, double abs_pos, ushort pos_source, double ReverseTime);
        //连续插补立即IO输出（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_write_outbit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_write_outbit(ushort CardNo, ushort Crd, ushort bitno, ushort on_off, double ReverseTime);
        //清除段内未执行完的IO（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_clear_io_action", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_clear_io_action(ushort CardNo, ushort Crd, uint IoMask);
        //连续插补暂停及异常时IO输出状态（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_set_pause_output", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_set_pause_output(ushort CardNo, ushort Crd, ushort action, int mask, int state);     //暂停时IO输出 action 0, 不工作；1， 暂停时输出io_state; 2 暂停时输出io_state, 继续运行时首先恢复原来的io; 3,在2的基础上，停止时也生效。
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_get_pause_output", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_get_pause_output(ushort CardNo, ushort Crd, ref ushort action, ref int mask, ref int state);
        //延时指令（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_delay", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_delay(ushort CardNo, ushort Crd, double delay_time, int mark);     //添加延时指令
        //IO输出延时翻转（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_reverse_outbit(ushort CardNo, ushort Crd, ushort bitno, double reverse_time);
        //IO延时输出（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_delay_outbit(ushort CardNo, ushort Crd, ushort bitno, ushort on_off, double delay_time);
        //连续插补单轴运动（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_pmove_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_pmove_unit(ushort CardNo, ushort Crd, ushort Axis, double dist, ushort posi_mode, ushort mode, int mark); //连续插补中控制指定外轴运动
        //连续插补直线插补（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_line_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_line_unit(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] Target_Pos, ushort posi_mode, int mark); //连续插补直线
        //连续插补圆心圆弧插补（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_arc_move_center_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_arc_move_center_unit(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] Target_Pos, double[] Cen_Pos, ushort Arc_Dir, int Circle, ushort posi_mode, int mark);
        //连续插补半径圆弧插补（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_arc_move_radius_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_arc_move_radius_unit(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] Target_Pos, double Arc_Radius, ushort Arc_Dir, int Circle, ushort posi_mode, int mark);
        //连续插补3点圆弧插补（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_arc_move_3points_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_arc_move_3points_unit(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] Target_Pos, double[] Mid_Pos, int Circle, ushort posi_mode, int mark);
        //连续插补矩形插补（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_rectangle_move_unit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_rectangle_move_unit(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] TargetPos, double[] MaskPos, int Count, ushort rect_mode, ushort posi_mode, int mark);
        //设置螺旋线插补运动模式（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_set_involute_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_set_involute_mode(ushort CardNo, ushort Crd, ushort mode);      //设置螺旋线是否封闭
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_get_involute_mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_get_involute_mode(ushort CardNo, ushort Crd, ref ushort mode);   //读取螺旋线是否封闭设置
        //（备用）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_line_unit_extern(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] Target_Pos, double[] Cen_Pos, ushort posi_mode, int mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_arc_move_center_unit_extern(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] Target_Pos, double[] Cen_Pos, double Arc_Radius, ushort posi_mode, int mark);
        //设置读取龙门跟随模式（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_gear_follow_profile(ushort CardNo, ushort axis, ushort enable, ushort master_axis, double ratio);//双Z轴
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_gear_follow_profile(ushort CardNo, ushort axis, ref ushort enable, ref ushort master_axis, ref double ratio);

        //--------------------PWM控制----------------------
        //PWM控制（备用）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_pwm_pin(ushort CardNo, ushort portno, ushort ON_OFF, double dfreqency, double dduty);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_pwm_pin(ushort CardNo, ushort portno, ref ushort ON_OFF, ref double dfreqency, ref double dduty);
        //设置读取PWM使能（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_pwm_enable", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_pwm_enable(ushort CardNo, ushort enable);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_pwm_enable", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_pwm_enable(ushort CardNo, ref ushort enable);
        //设置读取PWM立即输出（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_pwm_output", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_pwm_output(ushort CardNo, ushort pwm_no, double fDuty, double fFre);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_pwm_output", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_pwm_output(ushort CardNo, ushort pwm_no, ref double fDuty, ref double fFre);
        //连续插补PWM输出（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_set_pwm_output", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_set_pwm_output(ushort CardNo, ushort Crd, ushort pwm_no, double fDuty, double fFre);
        //高速PWM功能（备用）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_pwm_enable_extern(ushort CardNo, ushort channel, ushort enable);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_pwm_enable_extern(ushort CardNo, ushort channel, ref ushort enable);
        //设置PWM开关对应的占空比（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_pwm_onoff_duty", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_pwm_onoff_duty(ushort CardNo, ushort PwmNo, double fOnDuty, double fOffDuty);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_pwm_onoff_duty", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_pwm_onoff_duty(ushort CardNo, ushort PwmNo, ref double fOnDuty, ref double fOffDuty);
        //连续插补PWM速度跟随（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_set_pwm_follow_speed", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_set_pwm_follow_speed(ushort CardNo, ushort Crd, ushort pwm_no, ushort mode, double MaxVel, double MaxValue, double OutValue);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_get_pwm_follow_speed", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_get_pwm_follow_speed(ushort CardNo, ushort Crd, ushort pwm_no, ref ushort mode, ref double MaxVel, ref double MaxValue, ref double OutValue);
        //连续插补相对轨迹起点PWM滞后输出（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_delay_pwm_to_start", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_delay_pwm_to_start(ushort CardNo, ushort Crd, ushort pwmno, ushort on_off, double delay_value, ushort delay_mode, double ReverseTime);
        //连续插补相对轨迹终点PWM提前输出（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_ahead_pwm_to_stop", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_ahead_pwm_to_stop(ushort CardNo, ushort Crd, ushort pwmno, ushort on_off, double ahead_value, ushort ahead_mode, double ReverseTime);
        //连续插补PWM立即输出（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_write_pwm", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_write_pwm(ushort CardNo, ushort Crd, ushort pwmno, ushort on_off, double ReverseTime);

        //--------------------ADDA输出----------------------
        //控制卡接线盒DA输出，设置DA输出使能（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_da_enable", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_da_enable(ushort CardNo, ushort enable);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_da_enable", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_da_enable(ushort CardNo, ref ushort enable);
        //设置DA输出（适用于所有脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_da_output", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_da_output(ushort CardNo, ushort channel, double Vout);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_da_output", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_da_output(ushort CardNo, ushort channel, ref double Vout);
        //控制卡接线盒AD输入，读取AD输入（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_ad_input(ushort CardNo, ushort channel, ref double Vout);
        //设置连续DA使能（适用于DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_set_da_output(ushort CardNo, ushort Crd, ushort channel, double Vout);
        //设置连续DA使能（适用于DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_set_da_enable", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_set_da_enable(ushort CardNo, ushort Crd, ushort enable, ushort channel, int mark);
        //编码器da跟随（预留）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_encoder_da_follow_enable", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_encoder_da_follow_enable(ushort CardNo, ushort axis, ushort enable);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_encoder_da_follow_enable", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_encoder_da_follow_enable(ushort CardNo, ushort axis, ref ushort enable);
        //连续插补DA速度跟随（适用于DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_set_da_follow_speed", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_set_da_follow_speed(ushort CardNo, ushort Crd, ushort da_no, double MaxVel, double MaxValue, double acc_offset, double dec_offset, double acc_dist, double dec_dist);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_conti_get_da_follow_speed", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_conti_get_da_follow_speed(ushort CardNo, ushort Crd, ushort da_no, ref double MaxVel, ref double MaxValue, ref double acc_offset, ref double dec_offset, ref double acc_dist, ref double dec_dist);

        //小圆限速使能（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_arc_limit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_arc_limit(ushort CardNo, ushort Crd, ushort Enable, double MaxCenAcc, double MaxArcError);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_arc_limit", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_arc_limit(ushort CardNo, ushort Crd, ref ushort Enable, ref double MaxCenAcc, ref double MaxArcError);
        //（预留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_IoFilter(ushort CardNo, ushort bitno, double filter);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_IoFilter(ushort CardNo, ushort bitno, ref double filter);
        //螺距补偿（旧指令，不使用）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_lsc_index_value(ushort CardNo, ushort axis, ushort IndexID, int IndexValue);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_lsc_index_value(ushort CardNo, ushort axis, ushort IndexID, ref int IndexValue);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_lsc_config(ushort CardNo, ushort axis, ushort Origin, uint Interal, uint NegIndex, uint PosIndex, double Ratio);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_lsc_config(ushort CardNo, ushort axis, ref ushort Origin, ref uint Interal, ref uint NegIndex, ref uint PosIndex, ref double Ratio);
        //看门狗旧指令，不使用
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_watchdog(ushort CardNo, ushort enable, uint time);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_call_watchdog(ushort CardNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_read_diagnoseData(ushort CardNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_set_cmd_end(ushort CardNo, ushort Crd, ushort enable);
        //区域软限位（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_zone_limit_config(ushort CardNo, ushort[] axis, ushort[] Source, int x_pos_p, int x_pos_n, int y_pos_p, int y_pos_n, ushort action_para);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_zone_limit_config(ushort CardNo, ushort[] axis, ushort[] Source, ref int x_pos_p, ref int x_pos_n, ref int y_pos_p, ref int y_pos_n, ref ushort action_para);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_zone_limit_enable(ushort CardNo, ushort enable);
        //轴互锁功能（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_interlock_config(ushort CardNo, ushort[] axis, ushort[] Source, int delta_pos, ushort action_para);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_interlock_config(ushort CardNo, ushort[] axis, ushort[] Source, ref int delta_pos, ref ushort action_para);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_interlock_enable(ushort CardNo, ushort enable);
        //龙门模式的误差保护（适用于DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_grant_error_protect(ushort CardNo, ushort axis, ushort enable, uint dstp_error, uint emg_error);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_grant_error_protect(ushort CardNo, ushort axis, ref ushort enable, ref uint dstp_error, ref uint emg_error);
        //龙门模式的误差保护当量函数（适用于DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_grant_error_protect_unit(ushort CardNo, ushort axis, ushort enable, double dstp_error, double emg_error);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_grant_error_protect_unit(ushort CardNo, ushort axis, ref ushort enable, ref double dstp_error, ref double emg_error);

        //物件分拣功能 （分拣固件专用）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_camerablow_config(ushort CardNo, ushort camerablow_en, int cameraPos, ushort piece_num, int piece_distance, ushort axis_sel, int latch_distance_min);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_camerablow_config(ushort CardNo, ref ushort camerablow_en, ref int cameraPos, ref ushort piece_num, ref int piece_distance, ref ushort axis_sel, ref int latch_distance_min);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_clear_camerablow_errorcode(ushort CardNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_camerablow_errorcode(ushort CardNo, ref ushort errorcode);
        //配置通用输入（0~15）做为轴的限位信号（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_io_limit_config(ushort CardNo, ushort portno, ushort enable, ushort axis_sel, ushort el_mode, ushort el_logic);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_io_limit_config(ushort CardNo, ushort portno, ref ushort enable, ref ushort axis_sel, ref ushort el_mode, ref ushort el_logic);
        //手轮滤波参数（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_handwheel_filter(ushort CardNo, ushort axis, double filter_factor);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_handwheel_filter(ushort CardNo, ushort axis, ref double filter_factor);
        //读取坐标系各轴的当前规划坐标（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_get_interp_map(ushort CardNo, ushort Crd, ref ushort AxisNum, ushort[] AxisList, double[] pPosList);
        //坐标系错误代码 （保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_get_crd_errcode(ushort CardNo, ushort Crd, ref ushort errcode);
        //保留
        [DllImport("LTDMC.dll")]
        public static extern short dmc_line_unit_follow(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] Dist, ushort posi_mode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_line_unit_follow(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] pPosList, ushort posi_mode, int mark);
        //连续插补缓冲区DA操作（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_set_da_action(ushort CardNo, ushort Crd, ushort mode, ushort portno, double dvalue);
        //读编码器速度（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_read_encoder_speed(ushort CardNo, ushort Axis, ref double current_speed);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_axis_follow_line_enable(ushort CardNo, ushort Crd, ushort enable_flag);
        //插补轴脉冲补偿（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_interp_compensation(ushort CardNo, ushort axis, double dvalue, double time);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_interp_compensation(ushort CardNo, ushort axis, ref double dvalue, ref double time);
        //读取相对于起点的距离（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_distance_to_start(ushort CardNo, ushort Crd, ref double distance_x, ref double distance_y, int imark);
        //设置标志位 表示是否开始计算相对起点（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_start_distance_flag(ushort CardNo, ushort Crd, ushort flag);

        //刀向跟随（适用于DMC5000/5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_gear_unit(ushort CardNo, ushort Crd, ushort axis, double dist, ushort follow_mode, int imark);
        //轨迹拟合使能设置（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_path_fitting_enable(ushort CardNo, ushort Crd, ushort enable);
        //--------------------螺距补偿----------------------
        //螺距补偿功能(新)（适用于所有脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_enable_leadscrew_comp(ushort CardNo, ushort axis, ushort enable);
        //配置逻辑补偿参数（脉冲）（适用于所有脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_leadscrew_comp_config(ushort CardNo, ushort axis, ushort n, int startpos, int lenpos, int[] pCompPos, int[] pCompNeg);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_leadscrew_comp_config(ushort CardNo, ushort axis, ref ushort n, ref int startpos, ref int lenpos, int[] pCompPos, int[] pCompNeg);
        //配置逻辑补偿参数（当量）（适用于DMC5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_leadscrew_comp_config_unit(ushort CardNo, ushort axis, ushort n, double startpos, double lenpos, double[] pCompPos, double[] pCompNeg);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_leadscrew_comp_config_unit(ushort CardNo, ushort axis, ref ushort n, ref double startpos, ref double lenpos, double[] pCompPos, double[] pCompNeg);
        //螺距补偿前的脉冲位置，编码器位置//20191025（适用于DMC3000系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_position_ex(ushort CardNo, ushort axis, ref double pos);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_encoder_ex(ushort CardNo, ushort axis, ref double pos);
        //螺距补偿前的脉冲位置，编码器位置 当量（适用于DMC5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_position_ex_unit(ushort CardNo, ushort axis, ref double pos);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_encoder_ex_unit(ushort CardNo, ushort axis, ref double pos);

        //指定轴做定长位移运动 按固定曲线运动（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_t_pmove_extern(ushort CardNo, ushort axis, double MidPos, double TargetPos, double Min_Vel, double Max_Vel, double stop_Vel, double acc, double dec, ushort posi_mode);
        //
        [DllImport("LTDMC.dll")]
        public static extern short dmc_t_pmove_extern_unit(ushort CardNo, ushort axis, double MidPos, double TargetPos, double Min_Vel, double Max_Vel, double stop_Vel, double acc, double dec, ushort posi_mode);
        //设置脉冲计数值和编码器反馈值之间差值的报警阀值（适用于DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_pulse_encoder_count_error(ushort CardNo, ushort axis, ushort error);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_pulse_encoder_count_error(ushort CardNo, ushort axis, ref ushort error);
        //检查脉冲计数值和编码器反馈值之间差值是否超过报警阀值（适用于DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_check_pulse_encoder_count_error(ushort CardNo, ushort axis, ref int pulse_position, ref int enc_position);
        //设置/回读脉冲计数值和编码器反馈值之间差值的报警阈值unit（适用于DMC5X10脉冲卡、EtherCAT总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_pulse_encoder_count_error_unit(ushort CardNo, ushort axis, double error);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_pulse_encoder_count_error_unit(ushort CardNo, ushort axis, ref double error);
        //检查脉冲计数值和编码器反馈值之间差值是否超过报警阈值unit（适用于DMC5X10脉冲卡、EtherCAT总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_check_pulse_encoder_count_error_unit(ushort CardNo, ushort axis, ref double pulse_position, ref double enc_position);
        //使能和设置跟踪编码器误差不在范围内时轴的停止模式（适用于DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_encoder_count_error_action_config(ushort CardNo, ushort enable, ushort stopmode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_encoder_count_error_action_config(ushort CardNo, ref ushort enable, ref ushort stopmode);

        //新物件分拣功能 分拣固件专用
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_close(ushort CardNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_start(ushort CardNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_set_init_config(ushort CardNo, ushort cameraCount, int[] pCameraPos, ushort[] pCamIONo, uint cameraTime, ushort cameraTrigLevel, ushort blowCount, int[] pBlowPos, ushort[] pBlowIONo, uint blowTime, ushort blowTrigLevel, ushort axis, ushort dir, ushort checkMode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_set_camera_trig_count(ushort CardNo, ushort cameraNum, uint cameraTrigCnt);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_get_camera_trig_count(ushort CardNo, ushort cameraNum, ref uint pCameraTrigCnt, ushort count);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_set_blow_trig_count(ushort CardNo, ushort blowNum, uint blowTrigCnt);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_get_blow_trig_count(ushort CardNo, ushort blowNum, ref uint pBlowTrigCnt, ushort count);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_get_camera_config(ushort CardNo, ushort index, ref int pos, ref uint trigTime, ref ushort ioNo, ref ushort trigLevel);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_get_blow_config(ushort CardNo, ushort index, ref int pos, ref uint trigTime, ref ushort ioNo, ref ushort trigLevel);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_get_blow_status(ushort CardNo, ref int trigCntAll, ref ushort trigMore, ref ushort trigLess);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_trig_blow(ushort CardNo, ushort blowNum);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_set_blow_enable(ushort CardNo, ushort blowNum, ushort enable);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_set_piece_config(ushort CardNo, uint maxWidth, uint minWidth, uint minDistance, uint minTimeIntervel);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_get_piece_status(ushort CardNo, ref uint pieceFind, ref uint piecePassCam, ref uint dist2next, ref uint pieceWidth);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_set_cam_trig_phase(ushort CardNo, ushort blowNo, double coef);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_set_blow_trig_phase(ushort CardNo, ushort blowNo, double coef);

        //内部使用（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_sevon_enable(ushort CardNo, ushort axis, ushort on_off);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_sevon_enable(ushort CardNo, ushort axis);

        //连续编码器da跟随（适用于DMC5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_set_encoder_da_follow_enable(ushort CardNo, ushort Crd, ushort axis, ushort enable);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_get_encoder_da_follow_enable(ushort CardNo, ushort Crd, ref ushort axis, ref ushort enable);
        //设置位置误差带（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_set_factor_error", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_set_factor_error(ushort CardNo, ushort axis, double factor, int error);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_get_factor_error", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_get_factor_error(ushort CardNo, ushort axis, ref double factor, ref int error);
        //设置/回读位置误差带unit（适用于DMC5X10脉冲卡、EtherCAT总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_factor_error_unit(ushort CardNo, ushort axis, double factor, double error);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_factor_error_unit(ushort CardNo, ushort axis, ref double factor, ref double error);
        //保留
        [DllImport("LTDMC.dll")]
        public static extern short dmc_check_done_pos(ushort CardNo, ushort axis, ushort posi_mode);
        //保留
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_factor(ushort CardNo, ushort axis, double factor);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_error(ushort CardNo, ushort axis, int error);
        //检测指令到位（适用于所有脉冲卡、总线卡）
        [DllImport("LTDMC.dll", EntryPoint = "dmc_check_success_pulse", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_check_success_pulse(ushort CardNo, ushort axis);
        [DllImport("LTDMC.dll", EntryPoint = "dmc_check_success_encoder", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short dmc_check_success_encoder(ushort CardNo, ushort axis);

        //IO及编码器计数功能（保留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_io_count_profile(ushort CardNo, ushort chan, ushort bitno, ushort mode, double filter, double count_value, ushort[] axis_list, ushort axis_num, ushort stop_mode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_io_count_profile(ushort CardNo, ushort chan, ref ushort bitno, ref ushort mode, ref double filter, ref double count_value, ushort[] axis_list, ref ushort axis_num, ref ushort stop_mode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_io_count_enable(ushort CardNo, ushort chan, ushort ifenable);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_clear_io_count(ushort CardNo, ushort chan);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_io_count_value_extern(ushort CardNo, ushort chan, ref int current_value);
        //保留
        [DllImport("LTDMC.dll")]
        public static extern short dmc_change_speed_extend(ushort CardNo, ushort axis, double Curr_Vel, double Taccdec, ushort pin_num, ushort trig_mode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_follow_vector_speed_move(ushort CardNo, ushort axis, ushort Follow_AxisNum, ushort[] Follow_AxisList, double ratio);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_line_unit_extend(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] pPosList, ushort posi_mode, double Extend_Len, ushort enable, int mark); //连续插补直线

        //总线参数
        [DllImport("LTDMC.dll", EntryPoint = "nmc_download_configfile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short nmc_download_configfile(ushort CardNo, ushort PortNum, string FileName);//总线ENI配置文件
        [DllImport("LTDMC.dll", EntryPoint = "nmc_download_mapfile", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short nmc_download_mapfile(ushort CardNo, string FileName);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_upload_configfile(ushort CardNo, ushort PortNum, string FileName);
        [DllImport("LTDMC.dll", EntryPoint = "nmc_set_manager_para", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short nmc_set_manager_para(ushort CardNo, ushort PortNum, int baudrate, ushort ManagerID);
        [DllImport("LTDMC.dll", EntryPoint = "nmc_get_manager_para", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short nmc_get_manager_para(ushort CardNo, ushort PortNum, ref uint baudrate, ref ushort ManagerID);
        [DllImport("LTDMC.dll", EntryPoint = "nmc_set_manager_od", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short nmc_set_manager_od(ushort CardNo, ushort PortNum, ushort index, ushort subindex, ushort valuelength, uint value);
        [DllImport("LTDMC.dll", EntryPoint = "nmc_get_manager_od", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short nmc_get_manager_od(ushort CardNo, ushort PortNum, ushort index, ushort subindex, ushort valuelength, ref uint value);

        [DllImport("LTDMC.dll", EntryPoint = "nmc_get_total_axes", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short nmc_get_total_axes(ushort CardNo, ref uint TotalAxis);
        [DllImport("LTDMC.dll", EntryPoint = "nmc_get_total_ionum", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short nmc_get_total_ionum(ushort CardNo, ref ushort TotalIn, ref ushort TotalOut);
        [DllImport("LTDMC.dll", EntryPoint = "nmc_get_LostHeartbeat_Nodes", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short nmc_get_LostHeartbeat_Nodes(ushort CardNo, ushort PortNum, ushort[] NodeID, ref ushort NodeNum);
        [DllImport("LTDMC.dll", EntryPoint = "nmc_get_EmergeneyMessege_Nodes", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short nmc_get_EmergeneyMessege_Nodes(ushort CardNo, ushort PortNum, uint[] NodeMsg, ref ushort MsgNum);
        [DllImport("LTDMC.dll", EntryPoint = "nmc_SendNmtCommand", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short nmc_SendNmtCommand(ushort CardNo, ushort PortNum, ushort NodeID, ushort NmtCommand);
        [DllImport("LTDMC.dll", EntryPoint = "nmc_syn_move", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern short nmc_syn_move(ushort CardNo, ushort AxisNum, ushort[] AxisList, int[] Position, ushort[] PosiMode);
        //
        [DllImport("LTDMC.dll")]
        public static extern short nmc_syn_move_unit(ushort CardNo, ushort AxisNum, ushort[] AxisList, double[] Position, ushort[] PosiMode);
        //总线多轴同步运动
        [DllImport("LTDMC.dll")]
        public static extern short nmc_sync_pmove_unit(ushort CardNo, ushort AxisNum, ushort[] AxisList, double[] Dist, ushort[] PosiMode);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_sync_vmove_unit(ushort CardNo, ushort AxisNum, ushort[] AxisList, ushort[] Dir);
        //设置主站参数
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_master_para(ushort CardNo, ushort PortNum, ushort Baudrate, uint NodeCnt, ushort MasterId);
        //读取主站参数
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_master_para(ushort CardNo, ushort PortNum, ref ushort Baudrate, ref uint NodeCnt, ref ushort MasterId);
        //获取总线ADDA输入输出口数
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_total_adcnum(ushort CardNo, ref ushort TotalIn, ref ushort TotalOut);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_controller_workmode(ushort CardNo, ushort controller_mode);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_controller_workmode(ushort CardNo, ref ushort controller_mode);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_cycletime(ushort CardNo, ushort FieldbusType, int CycleTime);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_cycletime(ushort CardNo, ushort FieldbusType, ref int CycleTime);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_node_od(ushort CardNo, ushort PortNum, ushort nodenum, ushort index, ushort subindex, ushort valuelength, ref int value);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_node_od(ushort CardNo, ushort PortNum, ushort nodenum, ushort index, ushort subindex, ushort valuelength, int value);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_reset_to_factory(ushort CardNo, ushort PortNum, ushort NodeNum);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_alarm_clear(ushort CardNo, ushort PortNum, ushort nodenum);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_slave_nodes(ushort CardNo, ushort PortNum, ushort BaudRate, ref ushort NodeId, ref ushort NodeNum);

        //轴状态机
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_axis_state_machine(ushort CardNo, ushort axis, ref ushort Axis_StateMachine);
        //获取轴状态字
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_axis_statusword(ushort CardNo, ushort axis, ref int statusword);
        //获取轴配置控制模式，返回值（6回零模式，8csp模式）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_axis_setting_contrlmode(ushort CardNo, ushort axis, ref int contrlmode);
        //设置总线轴控制字
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_axis_contrlword(ushort CardNo, ushort axis, int contrlword);
        //获取总线轴控制字
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_axis_contrlword(ushort CardNo, ushort axis, ref int contrlword);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_axis_type(ushort CardNo, ushort axis, ref ushort Axis_Type);
        //获取总线时间量，平均时间，最大时间，执行周期数
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_consume_time_fieldbus(ushort CardNo, ushort Fieldbustype, ref uint Average_time, ref uint Max_time, ref ulong Cycles);
        //清除时间量
        [DllImport("LTDMC.dll")]
        public static extern short nmc_clear_consume_time_fieldbus(ushort CardNo, ushort Fieldbustype);
        //总线单轴使能函数 255表示全使能
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_axis_enable(ushort CardNo, ushort axis);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_axis_disable(ushort CardNo, ushort axis);
        // 获取轴的从站信息
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_axis_node_address(ushort CardNo, ushort axis, ref ushort SlaveAddr, ref ushort Sub_SlaveAddr);
        //获取总线轴数
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_total_slaves(ushort CardNo, ushort PortNum, ref ushort TotalSlaves);
        [DllImport("LTDMC.dll")]
        //总线回原点函数
        public static extern short nmc_set_home_profile(ushort CardNo, ushort axis, ushort home_mode, double Low_Vel, double High_Vel, double Tacc, double Tdec, double offsetpos);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_home_profile(ushort CardNo, ushort axis, ref ushort home_mode, ref double Low_Vel, ref double High_Vel, ref double Tacc, ref double Tdec, ref double offsetpos);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_home_move(ushort CardNo, ushort axis);
        //
        [DllImport("LTDMC.dll")]
        public static extern short nmc_start_scan_ethercat(ushort CardNo, ushort AddressID);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_stop_scan_ethercat(ushort CardNo, ushort AddressID);
        //设置轴的运行模式 1为pp模式，6为回零模式，8为csp模式
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_axis_run_mode(ushort CardNo, ushort axis, ushort run_mode);
        //清除端口报警
        [DllImport("LTDMC.dll")]
        public static extern short nmc_clear_alarm_fieldbus(ushort CardNo, ushort PortNum);
        //停止ethercat总线,返回0表示成功，其他参数表示不成功
        [DllImport("LTDMC.dll")]
        public static extern short nmc_stop_etc(ushort CardNo, ref ushort ETCState);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_axis_contrlmode(ushort CardNo, ushort Axis, ref int Contrlmode);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_axis_io_in(ushort CardNo, ushort axis);

        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_axis_io_out(ushort CardNo, ushort axis, uint iostate);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_axis_io_out(ushort CardNo, ushort axis);
        // 获取总线端口错误码
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_errcode(ushort CardNo, ushort channel, ref ushort errcode);
        // 清除总线端口错误码
        [DllImport("LTDMC.dll")]
        public static extern short nmc_clear_errcode(ushort CardNo, ushort channel);
        // 获取总线轴错误码
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_axis_errcode(ushort CardNo, ushort axis, ref ushort Errcode);
        // 清除总线轴错误码
        [DllImport("LTDMC.dll")]
        public static extern short nmc_clear_axis_errcode(ushort CardNo, ushort axis);

        //RTEX卡添加函数
        [DllImport("LTDMC.dll")]
        public static extern short nmc_start_connect(ushort CardNo, ushort chan, ref ushort info, ref ushort len);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_vendor_info(ushort CardNo, ushort axis, byte[] info, ref ushort len);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_slave_type_info(ushort CardNo, ushort axis, byte[] info, ref ushort len);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_slave_name_info(ushort CardNo, ushort axis, byte[] info, ref ushort len);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_slave_version_info(ushort CardNo, ushort axis, byte[] info, ref ushort len);

        [DllImport("LTDMC.dll")]
        public static extern short nmc_write_parameter(ushort CardNo, ushort axis, ushort index, ushort subindex, uint para_data);
        /**************************************************************
        *功能说明：RTEX驱动器写EEPROM操作
        **************************************************************/
        [DllImport("LTDMC.dll")]
        public static extern short nmc_write_slave_eeprom(ushort CardNo, ushort axis);

        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_parameter(ushort CardNo, ushort axis, ushort index, ushort subindex, ref uint para_data);
        /**************************************************************
         * *index:rtex驱动器的参数分类
         * *subindex:rtex驱动器在index类别下的参数编号
         * *para_data:读出的参数值
         * **************************************************************/
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_parameter_attributes(ushort CardNo, ushort axis, ushort index, ushort subindex, ref uint para_data);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_cmdcycletime(ushort CardNo, ushort PortNum, uint cmdtime);
        //设置RTEX总线周期比(us)
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_cmdcycletime(ushort CardNo, ushort PortNum, ref uint cmdtime);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_config_atuo_log(ushort CardNo, ushort ifenable, ushort dir, ushort byte_index, ushort mask, ushort condition, uint counter);

        //扩展PDO
        [DllImport("LTDMC.dll")]
        public static extern short nmc_write_rxpdo_extra(ushort CardNo, ushort PortNum, ushort address, ushort DataLen, int Value);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_rxpdo_extra(ushort CardNo, ushort PortNum, ushort address, ushort DataLen, ref int Value);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_txpdo_extra(ushort CardNo, ushort PortNum, ushort address, ushort DataLen, ref int Value);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_write_rxpdo_extra_uint(ushort CardNo, ushort PortNum, ushort address, ushort DataLen, uint Value);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_rxpdo_extra_uint(ushort CardNo, ushort PortNum, ushort address, ushort DataLen, ref uint Value);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_txpdo_extra_uint(ushort CardNo, ushort PortNum, ushort address, ushort DataLen, ref uint Value);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_log_state(ushort CardNo, ushort chan, ref uint state);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_driver_reset(ushort CardNo, ushort axis);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_offset_pos(ushort CardNo, ushort axis, double offset_pos);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_offset_pos(ushort CardNo, ushort axis, ref double offset_pos);
        //清除rtex绝对值编码器的多圈值
        [DllImport("LTDMC.dll")]
        public static extern short nmc_clear_abs_driver_multi_cycle(ushort CardNo, ushort axis);
        //---------------------------EtherCAT IO扩展模块操作指令----------------------
        //设置io输出32位总线扩展
        [DllImport("LTDMC.dll")]
        public static extern short nmc_write_outport_extern(ushort CardNo, ushort Channel, ushort NoteID, ushort portno, uint outport_val);
        //读取io输出32位总线扩展
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_outport_extern(ushort CardNo, ushort Channel, ushort NoteID, ushort portno, ref uint outport_val);
        //读取io输入32位总线扩展
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_inport_extern(ushort CardNo, ushort Channel, ushort NoteID, ushort portno, ref uint inport_val);
        //设置io输出
        [DllImport("LTDMC.dll")]
        public static extern short nmc_write_outbit_extern(ushort CardNo, ushort Channel, ushort NoteID, ushort IoBit, ushort IoValue);
        //读取io输出
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_outbit_extern(ushort CardNo, ushort Channel, ushort NoteID, ushort IoBit, ref ushort IoValue);
        //读取io输入
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_inbit_extern(ushort CardNo, ushort Channel, ushort NoteID, ushort IoBit, ref ushort IoValue);

        //返回最近错误码
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_current_fieldbus_state_info(ushort CardNo, ushort Channel, ref ushort Axis, ref ushort ErrorType, ref ushort SlaveAddr, ref uint ErrorFieldbusCode);
        // 返回历史错误码
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_detail_fieldbus_state_info(ushort CardNo, ushort Channel, uint ReadErrorNum, ref uint TotalNum, ref uint ActualNum, ushort[] Axis, ushort[] ErrorType, ushort[] SlaveAddr, uint[] ErrorFieldbusCode);
        //启动采集
        [DllImport("LTDMC.dll")]
        public static extern short nmc_start_pdo_trace(ushort CardNo, ushort Channel, ushort SlaveAddr, ushort Index_Num, uint Trace_Len, ushort[] Index, ushort[] Sub_Index);
        //获取采集参数
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_pdo_trace(ushort CardNo, ushort Channel, ushort SlaveAddr, ref ushort Index_Num, ref uint Trace_Len, ushort[] Index, ushort[] Sub_Index);
        //设置触发采集参数
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_pdo_trace_trig_para(ushort CardNo, ushort Channel, ushort SlaveAddr, ushort Trig_Index, ushort Trig_Sub_Index, int Trig_Value, ushort Trig_Mode);
        //获取触发采集参数
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_pdo_trace_trig_para(ushort CardNo, ushort Channel, ushort SlaveAddr, ref ushort Trig_Index, ref ushort Trig_Sub_Index, ref int Trig_Value, ref ushort Trig_Mode);
        //采集清除
        [DllImport("LTDMC.dll")]
        public static extern short nmc_clear_pdo_trace_data(ushort CardNo, ushort Channel, ushort SlaveAddr);
        //采集停止
        [DllImport("LTDMC.dll")]
        public static extern short nmc_stop_pdo_trace(ushort CardNo, ushort Channel, ushort SlaveAddr);
        //采集数据读取
        [DllImport("LTDMC.dll")]
        public static extern short nmc_read_pdo_trace_data(ushort CardNo, ushort Channel, ushort SlaveAddr, uint StartAddr, uint Readlen, ref uint ActReadlen, byte[] Data);
        //已采集个数
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_pdo_trace_num(ushort CardNo, ushort Channel, ushort SlaveAddr, ref uint Data_num, ref uint Size_of_each_bag);
        //采集状态
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_pdo_trace_state(ushort CardNo, ushort Channel, ushort SlaveAddr, ref ushort Trace_state);
        //总线专用
        [DllImport("LTDMC.dll")]
        public static extern short nmc_reset_canopen(ushort CardNo);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_reset_rtex(ushort CardNo);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_reset_etc(ushort CardNo);
        //总线错误处理配置
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_fieldbus_error_switch(ushort CardNo, ushort channel, ushort data);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_fieldbus_error_switch(ushort CardNo, ushort channel, ref ushort data);

        ////配置CST切换到CSP后，由于驱动器不能及时同步主站目标位置，延时时间内主站继续同步驱动器实际位置，已取消该功能
        //[DllImport("LTDMC.dll")]
        //public static extern short nmc_torque_set_delay_cycle(ushort CardNo, ushort axis, int delay_cycle);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_torque_move(ushort CardNo, ushort axis, int Torque, ushort PosLimitValid, double PosLimitValue, ushort PosMode);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_change_torque(ushort CardNo, ushort axis, int Torque);
        //读取转矩大小
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_torque(ushort CardNo, ushort axis, ref int Torque);
        //modbus函数
        [DllImport("LTDMC.dll")]
        public static extern short dmc_modbus_active_COM1(ushort id, string COMID, int speed, int bits, int check, int stop);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_modbus_active_COM2(ushort id, string COMID, int speed, int bits, int check, int stop);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_modbus_active_ETH(ushort id, ushort port);

        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_modbus_0x(ushort CardNo, ushort start, ushort inum, byte[] pdata);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_modbus_0x(ushort CardNo, ushort start, ushort inum, byte[] pdata);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_modbus_4x(ushort CardNo, ushort start, ushort inum, ushort[] pdata);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_modbus_4x(ushort CardNo, ushort start, ushort inum, ushort[] pdata);

        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_modbus_4x_float(ushort CardNo, ushort start, ushort inum, float[] pdata);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_modbus_4x_float(ushort CardNo, ushort start, ushort inum, float[] pdata);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_modbus_4x_int(ushort CardNo, ushort start, ushort inum, int[] pdata);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_modbus_4x_int(ushort CardNo, ushort start, ushort inum, int[] pdata);
        //保留
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_line_io_union(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] pPosList, ushort posi_mode, ushort bitno, ushort on_off, double io_value, ushort io_mode, ushort MapAxis, ushort pos_source, double ReverseTime, long mark);
        //设置编码器方向（适用于DMC3000系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_encoder_dir(ushort CardNo, ushort axis, ushort dir);

        //圆弧区域软限位（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_arc_zone_limit_config(ushort CardNo, ushort[] AxisList, ushort AxisNum, double[] Center, double Radius, ushort Source, ushort StopMode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_arc_zone_limit_config(ushort CardNo, ushort[] AxisList, ref ushort AxisNum, double[] Center, ref double Radius, ref ushort Source, ref ushort StopMode);
        //圆形区域软限位unit（适用于DMC5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_arc_zone_limit_config_unit(ushort CardNo, ushort[] AxisList, ushort AxisNum, double[] Center, double Radius, ushort Source, ushort StopMode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_arc_zone_limit_config_unit(ushort CardNo, ushort[] AxisList, ref ushort AxisNum, double[] Center, ref double Radius, ref ushort Source, ref ushort StopMode);
        //查询相应轴的状态（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_arc_zone_limit_axis_status(ushort CardNo, ushort axis);
        //圆形限位使能（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_arc_zone_limit_enable(ushort CardNo, ushort enable);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_arc_zone_limit_enable(ushort CardNo, ref ushort enable);

        //控制卡接线盒断线后是否初始化输出电平
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_output_status_repower(ushort CardNo, ushort enable);
        //旧接口（软启动），不使用
        [DllImport("LTDMC.dll")]
        public static extern short dmc_t_pmove_extern_softlanding(ushort CardNo, ushort axis, double MidPos, double TargetPos, double start_Vel, double Max_Vel, double stop_Vel, uint delay_ms, double Max_Vel2, double stop_vel2, double acc_time, double dec_time, ushort posi_mode);
        //保留
        [DllImport("LTDMC.dll")]
        public static extern short dmc_compare_add_point_XD(ushort CardNo, ushort cmp, long pos, ushort dir, ushort action, uint actpara, long startPos);//硒电定制比较函数

        //---------------------------ORG输入触发在线变速变位----------------------
        //配置ORG输入触发在线变速变位（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pmove_change_pos_speed_config(ushort CardNo, ushort axis, double tar_vel, double tar_rel_pos, ushort trig_mode, ushort source);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_pmove_change_pos_speed_config(ushort CardNo, ushort axis, ref double tar_vel, ref double tar_rel_pos, ref ushort trig_mode, ref ushort source);
        //ORG输入触发在线变速变位使能（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pmove_change_pos_speed_enable(ushort CardNo, ushort axis, ushort enable);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_pmove_change_pos_speed_enable(ushort CardNo, ushort axis, ref ushort enable);
        //读取ORG输入触发在线变速变位的状态  trig_num 触发次数，trig_pos 触发位置（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_pmove_change_pos_speed_state(ushort CardNo, ushort axis, ref ushort trig_num, double[] trig_pos);
        //IO变速变位，配置io输入口（适用于EtherCAT总线系列卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pmove_change_pos_speed_inbit(ushort CardNo, ushort axis, ushort inbit, ushort enable);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_pmove_change_pos_speed_inbit(ushort CardNo, ushort axis, ref ushort inbit, ref ushort enable);
        //保留
        [DllImport("LTDMC.dll")]
        public static extern short dmc_compare_add_point_extend(ushort CardNo, ushort axis, long pos, ushort dir, ushort action, ushort para_num, ref uint actpara, uint compare_time);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_cmd_position(ushort CardNo, ushort axis, ref double pos);
        //逻辑采样配置（内部使用）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_logic_analyzer_config(ushort CardNo, ushort channel, uint SampleFre, uint SampleDepth, ushort SampleMode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_start_logic_analyzer(ushort CardNo, ushort channel, ushort enable);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_logic_analyzer_counter(ushort CardNo, ushort channel, ref uint counter);
        //20190923修改kg定制函数接口（客户定制）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_read_inbit_append(ushort CardNo, ushort bitno);//读取输入口的状态
        [DllImport("LTDMC.dll")]
        public static extern short dmc_write_outbit_append(ushort CardNo, ushort bitno, ushort on_off);//设置输出口的状态
        [DllImport("LTDMC.dll")]
        public static extern short dmc_read_outbit_append(ushort CardNo, ushort bitno);//读取输出口的状态
        [DllImport("LTDMC.dll")]
        public static extern uint dmc_read_inport_append(ushort CardNo, ushort portno);//读取输入端口的值
        [DllImport("LTDMC.dll")]
        public static extern uint dmc_read_outport_append(ushort CardNo, ushort portno);//读取输出端口的值
        [DllImport("LTDMC.dll")]
        public static extern short dmc_write_outport_append(ushort CardNo, ushort portno, uint port_value);//设置所有输出端口的值

        //---------------------------椭圆插补及切向跟随----------------------
        // 设置坐标系切向跟随（适用于DMC5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_tangent_follow(ushort CardNo, ushort Crd, ushort axis, ushort follow_curve, ushort rotate_dir, double degree_equivalent);
        // 获取指定坐标系切向跟随参数（适用于DMC5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_tangent_follow_param(ushort CardNo, ushort Crd, ref ushort axis, ref ushort follow_curve, ref ushort rotate_dir, ref double degree_equivalent);
        // 取消坐标系跟随（适用于DMC5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_disable_follow_move(ushort CardNo, ushort Crd);
        // 椭圆插补（适用于DMC5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_ellipse_move(ushort CardNo, ushort Crd, ushort axisNum, ushort[] Axis_List, double[] Target_Pos, double[] Cen_Pos, double A_Axis_Len, double B_Axis_Len, ushort Dir, ushort Pos_Mode);

        //---------------------------看门狗功能----------------------
        //设置看门口触发响应事件（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_watchdog_action_event(ushort CardNo, ushort event_mask);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_watchdog_action_event(ushort CardNo, ref ushort event_mask);
        //使能看门口保护机制（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_watchdog_enable(ushort CardNo, double timer_period, ushort enable);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_watchdog_enable(ushort CardNo, ref double timer_period, ref ushort enable);
        //复位看门狗定时器（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_reset_watchdog_timer(ushort CardNo);

        //io定制功能（定制类）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_io_check_control(ushort CardNo, ushort sensor_in_no, ushort check_mode, ushort A_out_no, ushort B_out_no, ushort C_out_no, ushort output_mode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_io_check_control(ushort CardNo, ref ushort sensor_in_no, ref ushort check_mode, ref ushort A_out_no, ref ushort B_out_no, ref ushort C_out_no, ref ushort output_mode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_stop_io_check_control(ushort CardNo);

        //设置限位反找偏移距离（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_el_ret_deviation(ushort CardNo, ushort axis, ushort enable, double deviation);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_el_ret_deviation(ushort CardNo, ushort axis, ref ushort enable, ref double deviation);

        //两轴位置叠加，高速比较功能（测试使用）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_set_config_overlap(ushort CardNo, ushort hcmp, ushort axis, ushort cmp_source, ushort cmp_logic, int time, ushort axis_num, ushort aux_axis, ushort aux_source);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_hcmp_get_config_overlap(ushort CardNo, ushort hcmp, ref ushort axis, ref ushort cmp_source, ref ushort cmp_logic, ref int time, ref ushort axis_num, ref ushort aux_axis, ref ushort aux_source);

        //启动或者关闭RTCP功能,后续添加

        //螺旋插补(测试使用，DMC5000/5X10系列脉冲卡、E5032总线卡)
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_helix_move_unit(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AixsList, double[] StartPos, double[] TargetPos, ushort Arc_Dir, int Circle, ushort mode, int mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_helix_move_unit(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] StartPos, double[] TargetPos, ushort Arc_Dir, int Circle, ushort mode);

        //PDO缓存20190715（内部使用）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pdo_buffer_enter(ushort CardNo, ushort axis);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pdo_buffer_stop(ushort CardNo, ushort axis);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pdo_buffer_clear(ushort CardNo, ushort axis);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pdo_buffer_run_state(ushort CardNo, ushort axis, ref int RunState, ref int Remain, ref int NotRunned, ref int Runned);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pdo_buffer_add_data(ushort CardNo, ushort axis, int size, int[] data_table);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pdo_buffer_start_multi(ushort CardNo, ushort AxisNum, ushort[] AxisList, ushort[] ResultList);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pdo_buffer_pause_multi(ushort CardNo, ushort AxisNum, ushort[] AxisList, ushort[] ResultList);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_pdo_buffer_stop_multi(ushort CardNo, ushort AxisNum, ushort[] AxisList, ushort[] ResultList);
        //[DllImport("LTDMC.dll")]
        //public static extern short dmc_pdo_buffer_add_data_multi(UInt16 CardNo, UInt16 AxisNum, UInt16[] AxisList, int size, int[][] data_table);
        //保留
        [DllImport("LTDMC.dll")]
        public static extern short dmc_calculate_arccenter_3point(double[] start_pos, double[] mid_pos, double[] target_pos, double[] cen_pos);

        //---------------------指令缓存门型运动------------------
        //指令缓存门型运动（适用于DMC3000/5000系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_set_muti_profile_unit(ushort card, ushort group, ushort axis_num, ushort[] axis_list, double[] start_vel, double[] max_vel, double[] tacc, double[] tdec, double[] stop_vel);//两轴速度设置
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_set_profile_unit(ushort card, ushort group, ushort axis, double start_vel, double max_vel, double tacc, double tdec, double stop_vel);//单轴速度设置
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_sigaxis_moveseg_data(ushort card, ushort group, ushort axis, double Target_pos, ushort process_mode, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_sigaxis_move_twoseg_data(ushort card, ushort group, ushort axis, double Target_pos, double second_pos, double second_vel, double second_endvel, ushort process_mode, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_mutiaxis_moveseg_data(ushort card, ushort group, ushort axisnum, ushort[] axis_list, double[] Target_pos, ushort process_mode, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_mutiaxis_move_twoseg_data(ushort card, ushort group, ushort axisnum, ushort[] axis_list, double[] Target_pos, double[] second_pos, double[] second_vel, double[] second_endvel, ushort process_mode, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_ioTrig_movseg_data(ushort card, ushort group, ushort axisNum, ushort[] axisList, double[] Target_pos, ushort process_mode, ushort trigINbit, ushort trigINstate, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_mutiposTrig_movseg_data(ushort card, ushort group, ushort axis, double Target_pos, ushort process_mode, ushort trigaxisNum, ushort[] trigAxisList, double[] trigPos, ushort[] trigPosType, ushort[] trigMode, uint mark);//位置触发移动
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_mutiposTrig_mov_twoseg_data(ushort card, ushort group, ushort axis, double Target_pos, double softland_pos, double softland_vel, double softland_endvel, ushort process_mode, ushort trigAxisNum, ushort[] trigAxisList, double[] trigPos, ushort[] trigPosType, ushort[] trigMode, uint mark);//多轴位置触发移动
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_upseg_data(ushort card, ushort group, ushort axis, double Target_pos, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_up_twoseg_data(ushort card, ushort group, ushort axis, double Target_pos, double second_pos, double second_vel, double second_endvel, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_ioPosTrig_movseg_data(ushort card, ushort group, ushort axisNum, ushort[] axisList, double[] Target_pos, ushort process_mode, ushort trigAxis, double trigPos, ushort trigPosType, ushort trigMode, ushort TrigINNum, ushort[] trigINList, ushort[] trigINstate, uint mark);//位置+io触发移动
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_ioPosTrig_mov_twoseg_data(ushort card, ushort group, ushort axisNum, ushort[] axisList, double[] Target_pos, double[] second_pos, double[] second_vel, double[] second_endvel, ushort process_mode, ushort trigAxis, double trigPos, ushort trigPosType, ushort trigMode, ushort TrigINNum, ushort[] trigINList, ushort[] trigINstate, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_posTrig_movseg_data(ushort card, ushort group, ushort axisNum, ushort[] axisList, double[] Target_pos, ushort process_mode, ushort trigAxis, double trigPos, ushort trigPosType, ushort trigMode, uint mark);//位置触发移动
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_posTrig_mov_twoseg_data(ushort card, ushort group, ushort axisNum, ushort[] axisList, double[] Target_pos, double[] second_pos, double[] second_vel, double[] second_endvel, ushort process_mode, ushort trigAxis, double trigPos, ushort trigPosType, ushort trigMode, uint mark);//位置触发移动
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_ioPosTrig_down_seg_data(ushort card, ushort group, ushort axis, double safePos, double Target_pos, ushort trigAxisNum, ushort[] trigAxisList, double[] trigPos, ushort[] trigPosType, ushort[] trigMode, ushort trigIN, ushort trigINstate, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_ioPosTrig_down_twoseg_data(ushort card, ushort group, ushort axis, double safePos, double Target_pos, double second_pos, double second_vel, double second_endvel, ushort trigAxisNum, ushort[] trigAxisList, double[] trigPos, ushort[] trigPosType, ushort[] trigMode, ushort trigIN, ushort trigINstate, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_posTrig_down_seg_data(ushort card, ushort group, ushort axis, double safePos, double Target_pos, ushort trigAxisNum, ushort[] trigAxisList, double[] trigPos, ushort[] trigPosType, ushort[] trigMode, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_posTrig_down_twoseg_data(ushort card, ushort group, ushort axis, double safePos, double Target_pos, double second_pos, double second_vel, double second_endvel, ushort trigAxisNum, ushort[] trigAxisList, double[] trigPos, ushort[] trigPosType, ushort[] trigMode, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_posTrig_down_seg_cmd_data(ushort card, ushort group, ushort axis, double safePos, double Target_pos, ushort trigAxisNum, ushort[] trigAxisList, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_posTrig_down_twoseg_cmd_data(ushort card, ushort group, ushort axis, double safePos, double Target_pos, double second_pos, double second_vel, double second_endvel, ushort trigAxisNum, ushort[] trigAxisList, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_mutiposTrig_singledown_seg_data(ushort card, ushort group, ushort axis, double safePos, double Target_pos, ushort process_mode, ushort trigAxisNum, ushort[] trigAxisList, double[] trigPos, ushort[] trigPosType, ushort[] trigMode, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_add_mutiposTrig_mutidown_seg_data(ushort card, ushort group, ushort axisnum, ushort[] axis_list, double[] safePos, double[] Target_pos, ushort process_mode, ushort trigAxisNum, ushort[] trigAxisList, double[] trigPos, ushort[] trigPosType, ushort[] trigMode, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_posTrig_outbit(ushort card, ushort group, ushort bitno, ushort on_off, ushort ahead_axis, double ahead_value, ushort ahead_PosType, ushort ahead_Mode, uint mark);//位置触发IO输出
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_mutiposTrig_outbit(ushort card, ushort group, ushort bitno, ushort on_off, ushort process_mode, ushort trigaxisNum, ushort[] trigAxisList, double[] trigPos, ushort[] trigPosType, ushort[] trigMode, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_immediate_write_outbit(ushort card, ushort group, ushort bitno, ushort on_off, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_wait_input(ushort card, ushort group, ushort bitno, ushort on_off, double time_out, uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_delay_time(ushort card, ushort group, double delay_time, uint mark);//延时指令
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_get_run_state(ushort card, ushort group, ref ushort state, ref ushort enable, ref uint stop_reason, ref ushort trig_phase, ref uint mark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_open_list(ushort card, ushort group, ushort axis_num, ushort[] axis_list);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_close_list(ushort card, ushort group);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_start_list(ushort card, ushort group);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_stop_list(ushort card, ushort group, ushort stopMode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_pause_list(ushort card, ushort group, ushort stopMode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_set_encoder_error_allow(ushort card, ushort group, double allow_error);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_m_get_encoder_error_allow(ushort card, ushort group, ref double allow_error);

        //读取所有AD输入（适用于DMC5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_ad_input_all(ushort CardNo, ref double Vout);
        //连续插补暂停后使用pmove（适用于DMC5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_pmove_unit_pausemode(ushort CardNo, ushort axis, double TargetPos, double Min_Vel, double Max_Vel, double stop_Vel, double acc, double dec, double smooth_time, ushort posi_mode);
        //连续插补暂停使用pmove后，回到暂停位置（适用于DMC5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_return_pausemode(ushort CardNo, ushort Crd, ushort axis);
        //检验接线盒是否支持通讯校验（适用于DMC3000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_check_if_crc_support(ushort CardNo);

        //轴碰撞检测功能接口 （适用于DMC3000系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_axis_conflict_config(ushort CardNo, ushort[] axis_list, ushort[] axis_depart_dir, double home_dist, double conflict_dist, ushort stop_mode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_axis_conflict_config(ushort CardNo, ushort[] axis_list, ushort[] axis_depart_dir, ref double home_dist, ref double conflict_dist, ref ushort stop_mode);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_axis_conflict_config_en(ushort CardNo, ushort enable);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_axis_conflict_config_en(ushort CardNo, ref ushort enable);

        //物件分拣加通道,分拣固件专用
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_close_ex(ushort CardNo, ushort sortModuleNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_start_ex(ushort CardNo, ushort sortModuleNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_set_init_config_ex(ushort CardNo, ushort cameraCount, int[] pCameraPos, ushort[] pCamIONo, uint cameraTime, ushort cameraTrigLevel, ushort blowCount, int[] pBlowPos, ushort[] pBlowIONo, uint blowTime, ushort blowTrigLevel, ushort axis, ushort dir, ushort checkMode, ushort sortModuleNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_set_camera_trig_count_ex(ushort CardNo, ushort cameraNum, uint cameraTrigCnt, ushort sortModuleNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_get_camera_trig_count_ex(ushort CardNo, ushort cameraNum, ref uint pCameraTrigCnt, ushort count, ushort sortModuleNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_set_blow_trig_count_ex(ushort CardNo, ushort blowNum, uint blowTrigCnt, ushort sortModuleNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_get_blow_trig_count_ex(ushort CardNo, ushort blowNum, ref uint pBlowTrigCnt, ushort count, ushort sortModuleNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_get_camera_config_ex(ushort CardNo, ushort index, ref int pos, ref uint trigTime, ref ushort ioNo, ref ushort trigLevel, ushort sortModuleNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_get_blow_config_ex(ushort CardNo, ushort index, ref int pos, ref uint trigTime, ref ushort ioNo, ref ushort trigLevel, ushort sortModuleNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_get_blow_status_ex(ushort CardNo, ref uint trigCntAll, ref ushort trigMore, ref ushort trigLess, ushort sortModuleNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_trig_blow_ex(ushort CardNo, ushort blowNum, ushort sortModuleNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_set_blow_enable_ex(ushort CardNo, ushort blowNum, ushort enable, ushort sortModuleNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_set_piece_config_ex(ushort CardNo, uint maxWidth, uint minWidth, uint minDistance, uint minTimeIntervel, ushort sortModuleNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_get_piece_status_ex(ushort CardNo, ref uint pieceFind, ref uint piecePassCam, ref uint dist2next, ref uint pieceWidth, ushort sortModuleNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_set_cam_trig_phase_ex(ushort CardNo, ushort blowNo, double coef, ushort sortModuleNo);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_sorting_set_blow_trig_phase_ex(ushort CardNo, ushort blowNo, double coef, ushort sortModuleNo);
        //获取分拣指令数量函数
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_sortdev_blow_cmd_cnt(ushort CardNo, ushort blowDevNum, ref long cnt);
        //获取未处理指令数量函数函数
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_sortdev_blow_cmderr_cnt(ushort CardNo, ushort blowDevNum, ref long errCnt);
        //分拣队列状态
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_sortqueue_status(ushort CardNo, ref long curSorQueueLen, ref long passCamWithNoCmd);

        // 椭圆连续插补（适用于DMC5X10系列脉冲卡、E5032总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_ellipse_move_unit(ushort CardNo, ushort Crd, ushort AxisNum, ushort[] AxisList, double[] Target_Pos, double[] Cen_Pos, double A_Axis_Len, double B_Axis_Len, ushort Dir, ushort Pos_Mode, long mark);
        //获取轴状态函数（预留）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_axis_status_advance(ushort CardNo, ushort axis_no, ushort motion_no, ref ushort axis_plan_state, ref uint ErrPlulseCnt, ref ushort fpga_busy);
        //连续插补vmove（DMC5000系列卡受限使用）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_vmove_unit(ushort CardNo, ushort Crd, ushort axis, double vel, double acc, ushort dir, int imark);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_conti_vmove_stop(ushort CardNo, ushort Crd, ushort axis, double dec, int imark);

        //---------------------读写掉电保持区------------------//
        //写入字符数据到断电保持区（DMC3000/5000系列卡受限使用）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_persistent_reg_byte(ushort CardNo, uint start, uint inum, byte[] pdata);
        //从断电保持区读取写入的字符（DMC3000/5000系列卡受限使用）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_persistent_reg_byte(ushort CardNo, uint start, uint inum, byte[] pdata);
        //写入浮点型数据到断电保持区（DMC3000/5000系列卡受限使用）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_persistent_reg_float(ushort CardNo, uint start, uint inum, float[] pdata);
        //从断电保持区读取写入的浮点型数据（DMC3000/5000系列卡受限使用）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_persistent_reg_float(ushort CardNo, uint start, uint inum, float[] pdata);
        //写入整型数据到断电保持区（DMC3000/5000系列卡受限使用）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_persistent_reg_int(ushort CardNo, uint start, uint inum, int[] pdata);
        //从断电保持区读取写入的整型数据（DMC3000/5000系列卡受限使用）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_persistent_reg_int(ushort CardNo, uint start, uint inum, int[] pdata);
        //----------------------------------------------------//

        //EtherCAT总线复位IO模块输出保持开关设置202001（适用于所有EtherCAT总线卡）
        [DllImport("LTDMC.dll")]
        public static extern short nmc_set_slave_output_retain(ushort CardNo, ushort Enable);
        [DllImport("LTDMC.dll")]
        public static extern short nmc_get_slave_output_retain(ushort CardNo, ref ushort Enable);

        //轴参数配置写flash，实现断电保存急停信号配置（适用于DMC3000系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_persistent_param_config(ushort CardNo, ushort axis, uint item);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_persistent_param_config(ushort CardNo, ushort axis, ref uint item);

        //读取运行时是启动正常固件还是备份固件（适用于DMC3000/5000/5X10系列脉冲卡）
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_firmware_boot_type(ushort CardNo, ref ushort boot_type);

        /**************************中断功能 （适用于DMC5X10系列脉冲卡）************************/
        //开启控制卡中断功能
        [DllImport("LTDMC.dll")]
        public static extern uint dmc_int_enable(ushort CardNo, DMC3K5K_OPERATE funcIntHandler, IntPtr operate_data);
        //禁止控制卡的中断
        [DllImport("LTDMC.dll")]
        public static extern uint dmc_int_disable(ushort CardNo);
        //设置/读取指定控制卡中断通道使能
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_intmode_enable(ushort Cardno, ushort Intno, ushort Enable);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_intmode_enable(ushort Cardno, ushort Intno, ref ushort Status);
        //设置/读取指定控制卡中断配置
        [DllImport("LTDMC.dll")]
        public static extern short dmc_set_intmode_config(ushort Cardno, ushort Intno, ushort IntItem, ushort IntIndex, ushort IntSubIndex, ushort Logic);
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_intmode_config(ushort Cardno, ushort Intno, ref ushort IntItem, ref ushort IntIndex, ref ushort IntSubIndex, ref ushort Logic);
        //读取指定控制卡中断通道的中断状态
        [DllImport("LTDMC.dll")]
        public static extern short dmc_get_int_status(ushort Cardno, ref uint IntStatus);
        //复位指定控制卡输入口的中断
        [DllImport("LTDMC.dll")]
        public static extern short dmc_reset_int_status(ushort Cardno, ushort Intno);
        /**************************************************************************************/
    }
}
