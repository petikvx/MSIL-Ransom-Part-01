using System;
using System.Runtime.InteropServices;

namespace OtelRezervasyon_DadasTurizm.DadasDB.Entities;

internal static class Program
{
	public const ushort PCI_6208V = 1;

	public const ushort PCI_6208A = 2;

	public const ushort PCI_6308V = 3;

	public const ushort PCI_6308A = 4;

	public const ushort PCI_7200 = 5;

	public const ushort PCI_7230 = 6;

	public const ushort PCI_7233 = 7;

	public const ushort PCI_7234 = 8;

	public const ushort PCI_7248 = 9;

	public const ushort PCI_7249 = 10;

	public const ushort PCI_7250 = 11;

	public const ushort PCI_7252 = 12;

	public const ushort PCI_7296 = 13;

	public const ushort PCI_7300A_RevA = 14;

	public const ushort PCI_7300A_RevB = 15;

	public const ushort PCI_7432 = 16;

	public const ushort PCI_7433 = 17;

	public const ushort PCI_7434 = 18;

	public const ushort PCI_8554 = 19;

	public const ushort PCI_9111DG = 20;

	public const ushort PCI_9111HR = 21;

	public const ushort PCI_9112 = 22;

	public const ushort PCI_9113 = 23;

	public const ushort PCI_9114DG = 24;

	public const ushort PCI_9114HG = 25;

	public const ushort PCI_9118DG = 26;

	public const ushort PCI_9118HG = 27;

	public const ushort PCI_9118HR = 28;

	public const ushort PCI_9810 = 29;

	public const ushort PCI_9812 = 30;

	public const ushort PCI_7396 = 31;

	public const ushort PCI_9116 = 32;

	public const ushort PCI_7256 = 33;

	public const ushort PCI_7258 = 34;

	public const ushort PCI_7260 = 35;

	public const ushort PCI_7452 = 36;

	public const ushort PCI_7442 = 37;

	public const ushort MAX_CARD = 32;

	public const short NoError = 0;

	public const short ErrorUnknownCardType = -1;

	public const short ErrorInvalidCardNumber = -2;

	public const short ErrorTooManyCardRegistered = -3;

	public const short ErrorCardNotRegistered = -4;

	public const short ErrorFuncNotSupport = -5;

	public const short ErrorInvalidIoChannel = -6;

	public const short ErrorInvalidAdRange = -7;

	public const short ErrorContIoNotAllowed = -8;

	public const short ErrorDiffRangeNotSupport = -9;

	public const short ErrorLastChannelNotZero = -10;

	public const short ErrorChannelNotDescending = -11;

	public const short ErrorChannelNotAscending = -12;

	public const short ErrorOpenDriverFailed = -13;

	public const short ErrorOpenEventFailed = -14;

	public const short ErrorTransferCountTooLarge = -15;

	public const short ErrorNotDoubleBufferMode = -16;

	public const short ErrorInvalidSampleRate = -17;

	public const short ErrorInvalidCounterMode = -18;

	public const short ErrorInvalidCounter = -19;

	public const short ErrorInvalidCounterState = -20;

	public const short ErrorInvalidBinBcdParam = -21;

	public const short ErrorBadCardType = -22;

	public const short ErrorInvalidDaRefVoltage = -23;

	public const short ErrorAdTimeOut = -24;

	public const short ErrorNoAsyncAI = -25;

	public const short ErrorNoAsyncAO = -26;

	public const short ErrorNoAsyncDI = -27;

	public const short ErrorNoAsyncDO = -28;

	public const short ErrorNotInputPort = -29;

	public const short ErrorNotOutputPort = -30;

	public const short ErrorInvalidDioPort = -31;

	public const short ErrorInvalidDioLine = -32;

	public const short ErrorContIoActive = -33;

	public const short ErrorDblBufModeNotAllowed = -34;

	public const short ErrorConfigFailed = -35;

	public const short ErrorInvalidPortDirection = -36;

	public const short ErrorBeginThreadError = -37;

	public const short ErrorInvalidPortWidth = -38;

	public const short ErrorInvalidCtrSource = -39;

	public const short ErrorOpenFile = -40;

	public const short ErrorAllocateMemory = -41;

	public const short ErrorDaVoltageOutOfRange = -42;

	public const short ErrorDaExtRefNotAllowed = -43;

	public const short ErrorDIODataWidthError = -44;

	public const short ErrorTaskCodeError = -45;

	public const short ErrortriggercountError = -46;

	public const short ErrorInvalidTriggerMode = -47;

	public const short ErrorInvalidTriggerType = -48;

	public const short ErrorInvalidCounterValue = -50;

	public const short ErrorInvalidEventHandle = -60;

	public const short ErrorNoMessageAvailable = -61;

	public const short ErrorEventMessgaeNotAdded = -62;

	public const short ErrorConfigIoctl = -201;

	public const short ErrorAsyncSetIoctl = -202;

	public const short ErrorDBSetIoctl = -203;

	public const short ErrorDBHalfReadyIoctl = -204;

	public const short ErrorContOPIoctl = -205;

	public const short ErrorContStatusIoctl = -206;

	public const short ErrorPIOIoctl = -207;

	public const short ErrorDIntSetIoctl = -208;

	public const short ErrorWaitEvtIoctl = -209;

	public const short ErrorOpenEvtIoctl = -210;

	public const short ErrorCOSIntSetIoctl = -211;

	public const short ErrorMemMapIoctl = -212;

	public const short ErrorMemUMapSetIoctl = -213;

	public const short ErrorCTRIoctl = -214;

	public const short ErrorGetResIoctl = -215;

	public const ushort SYNCH_OP = 1;

	public const ushort ASYNCH_OP = 2;

	public const ushort AD_B_10_V = 1;

	public const ushort AD_B_5_V = 2;

	public const ushort AD_B_2_5_V = 3;

	public const ushort AD_B_1_25_V = 4;

	public const ushort AD_B_0_625_V = 5;

	public const ushort AD_B_0_3125_V = 6;

	public const ushort AD_B_0_5_V = 7;

	public const ushort AD_B_0_05_V = 8;

	public const ushort AD_B_0_005_V = 9;

	public const ushort AD_B_1_V = 10;

	public const ushort AD_B_0_1_V = 11;

	public const ushort AD_B_0_01_V = 12;

	public const ushort AD_B_0_001_V = 13;

	public const ushort AD_U_20_V = 14;

	public const ushort AD_U_10_V = 15;

	public const ushort AD_U_5_V = 16;

	public const ushort AD_U_2_5_V = 17;

	public const ushort AD_U_1_25_V = 18;

	public const ushort AD_U_1_V = 19;

	public const ushort AD_U_0_1_V = 20;

	public const ushort AD_U_0_01_V = 21;

	public const ushort AD_U_0_001_V = 22;

	public const ushort TRIG_SOFTWARE = 0;

	public const ushort TRIG_INT_PACER = 1;

	public const ushort TRIG_EXT_STROBE = 2;

	public const ushort TRIG_HANDSHAKE = 3;

	public const ushort TRIG_CLK_10MHZ = 4;

	public const ushort TRIG_CLK_20MHZ = 5;

	public const ushort TRIG_DO_CLK_TIMER_ACK = 6;

	public const ushort TRIG_DO_CLK_10M_ACK = 7;

	public const ushort TRIG_DO_CLK_20M_ACK = 8;

	public const double CLKSRC_EXT_SampRate = 10000.0;

	public const ushort P6208_CURRENT_0_20MA = 0;

	public const ushort P6208_CURRENT_4_20MA = 3;

	public const ushort P6208_CURRENT_5_25MA = 1;

	public const ushort P6308_CURRENT_0_20MA = 0;

	public const ushort P6308_CURRENT_4_20MA = 3;

	public const ushort P6308_CURRENT_5_25MA = 1;

	public const ushort P6308V_AO_CH0_3 = 0;

	public const ushort P6308V_AO_CH4_7 = 1;

	public const ushort P6308V_AO_UNIPOLAR = 0;

	public const ushort P6308V_AO_BIPOLAR = 1;

	public const ushort DI_WAITING = 2;

	public const ushort DI_NOWAITING = 0;

	public const ushort DI_TRIG_RISING = 4;

	public const ushort DI_TRIG_FALLING = 0;

	public const ushort IREQ_RISING = 8;

	public const ushort IREQ_FALLING = 0;

	public const ushort OREQ_ENABLE = 16;

	public const ushort OREQ_DISABLE = 0;

	public const ushort OTRIG_HIGH = 32;

	public const ushort OTRIG_LOW = 0;

	public const ushort INPUT_PORT = 1;

	public const ushort OUTPUT_PORT = 2;

	public const ushort INPUT_LINE = 1;

	public const ushort OUTPUT_LINE = 2;

	public const ushort Channel_P1A = 0;

	public const ushort Channel_P1B = 1;

	public const ushort Channel_P1C = 2;

	public const ushort Channel_P1CL = 3;

	public const ushort Channel_P1CH = 4;

	public const ushort Channel_P1AE = 10;

	public const ushort Channel_P1BE = 11;

	public const ushort Channel_P1CE = 12;

	public const ushort Channel_P2A = 5;

	public const ushort Channel_P2B = 6;

	public const ushort Channel_P2C = 7;

	public const ushort Channel_P2CL = 8;

	public const ushort Channel_P2CH = 9;

	public const ushort Channel_P2AE = 15;

	public const ushort Channel_P2BE = 16;

	public const ushort Channel_P2CE = 17;

	public const ushort Channel_P3A = 10;

	public const ushort Channel_P3B = 11;

	public const ushort Channel_P3C = 12;

	public const ushort Channel_P3CL = 13;

	public const ushort Channel_P3CH = 14;

	public const ushort Channel_P4A = 15;

	public const ushort Channel_P4B = 16;

	public const ushort Channel_P4C = 17;

	public const ushort Channel_P4CL = 18;

	public const ushort Channel_P4CH = 19;

	public const ushort Channel_P5A = 20;

	public const ushort Channel_P5B = 21;

	public const ushort Channel_P5C = 22;

	public const ushort Channel_P5CL = 23;

	public const ushort Channel_P5CH = 24;

	public const ushort Channel_P6A = 25;

	public const ushort Channel_P6B = 26;

	public const ushort Channel_P6C = 27;

	public const ushort Channel_P6CL = 28;

	public const ushort Channel_P6CH = 29;

	public const ushort Channel_P1 = 30;

	public const ushort Channel_P2 = 31;

	public const ushort Channel_P3 = 32;

	public const ushort Channel_P4 = 33;

	public const ushort Channel_P1E = 34;

	public const ushort Channel_P2E = 35;

	public const ushort Channel_P3E = 36;

	public const ushort Channel_P4E = 37;

	public const ushort P7442_CH0 = 0;

	public const ushort P7442_CH1 = 1;

	public const ushort P7442_TTL0 = 2;

	public const ushort P7442_TTL1 = 3;

	public const ushort P7300_WAIT_NO = 0;

	public const ushort P7300_WAIT_TRG = 1;

	public const ushort P7300_WAIT_FIFO = 2;

	public const ushort P7300_WAIT_BOTH = 3;

	public const ushort P7300_TERM_OFF = 0;

	public const ushort P7300_TERM_ON = 1;

	public const ushort P7300_DIREQ_POS = 0;

	public const ushort P7300_DIREQ_NEG = 1;

	public const ushort P7300_DIACK_POS = 0;

	public const ushort P7300_DIACK_NEG = 2;

	public const ushort P7300_DITRIG_POS = 0;

	public const ushort P7300_DITRIG_NEG = 4;

	public const ushort P7300_DOREQ_POS = 0;

	public const ushort P7300_DOREQ_NEG = 8;

	public const ushort P7300_DOACK_POS = 0;

	public const ushort P7300_DOACK_NEG = 16;

	public const ushort P7300_DOTRIG_POS = 0;

	public const ushort P7300_DOTRIG_NEG = 32;

	public const ushort PORT_DI_LOW = 0;

	public const ushort PORT_DI_HIGH = 1;

	public const ushort PORT_DO_LOW = 0;

	public const ushort PORT_DO_HIGH = 1;

	public const ushort P7432R_DO_LED = 1;

	public const ushort P7433R_DO_LED = 0;

	public const ushort P7434R_DO_LED = 2;

	public const ushort P7432R_DI_SLOT = 1;

	public const ushort P7433R_DI_SLOT = 2;

	public const ushort P7434R_DI_SLOT = 0;

	public const short INT1_DISABLE = -1;

	public const short INT1_COS = 0;

	public const short INT1_FP1C0 = 1;

	public const short INT1_RP1C0_FP1C3 = 2;

	public const short INT1_EVENT_COUNTER = 3;

	public const short INT1_EXT_SIGNAL = 1;

	public const short INT1_COUT12 = 1;

	public const short INT1_CH0 = 1;

	public const short INT1_COS0 = 1;

	public const short INT1_COS1 = 2;

	public const short INT1_COS2 = 4;

	public const short INT1_COS3 = 8;

	public const short INT2_DISABLE = -1;

	public const short INT2_COS = 0;

	public const short INT2_FP2C0 = 1;

	public const short INT2_RP2C0_FP2C3 = 2;

	public const short INT2_TIMER_COUNTER = 3;

	public const short INT2_EXT_SIGNAL = 1;

	public const short INT2_CH1 = 2;

	public const short INT2_WDT = 4;

	public const ushort ManualResetIEvt = 16384;

	public const ushort WDT_OVRFLOW_SAFETYOUT = 32768;

	public const ushort ECKN = 0;

	public const ushort COUTN_1 = 1;

	public const ushort CK1 = 2;

	public const ushort COUT10 = 3;

	public const ushort CK1_C8M = 0;

	public const ushort CK1_COUT11 = 1;

	public const ushort DBCLK_COUT11 = 0;

	public const ushort DBCLK_2MHZ = 1;

	public const ushort P9111_INT1_EOC = 0;

	public const ushort P9111_INT1_FIFO_HF = 1;

	public const ushort P9111_INT2_PACER = 0;

	public const ushort P9111_INT2_EXT_TRG = 1;

	public const ushort P9111_CHANNEL_DO = 0;

	public const ushort P9111_CHANNEL_EDO = 1;

	public const ushort P9111_CHANNEL_DI = 0;

	public const ushort P9111_CHANNEL_EDI = 1;

	public const ushort P9111_EDO_INPUT = 1;

	public const ushort P9111_EDO_OUT_EDO = 2;

	public const ushort P9111_EDO_OUT_CHN = 3;

	public const ushort P9111_TRGMOD_SOFT = 0;

	public const ushort P9111_TRGMOD_PRE = 1;

	public const ushort P9111_TRGMOD_POST = 2;

	public const ushort P9111_AO_UNIPOLAR = 0;

	public const ushort P9111_AO_BIPOLAR = 1;

	public const ushort P9118_AI_BiPolar = 0;

	public const ushort P9118_AI_UniPolar = 1;

	public const ushort P9118_AI_SingEnded = 0;

	public const ushort P9118_AI_Differential = 2;

	public const ushort P9118_AI_ExtG = 4;

	public const ushort P9118_AI_ExtTrig = 8;

	public const ushort P9118_AI_DtrgNegative = 0;

	public const ushort P9118_AI_DtrgPositive = 16;

	public const ushort P9118_AI_EtrgNegative = 0;

	public const ushort P9118_AI_EtrgPositive = 32;

	public const ushort P9118_AI_BurstModeEn = 64;

	public const ushort P9118_AI_SampleHold = 128;

	public const ushort P9118_AI_PostTrgEn = 256;

	public const ushort P9118_AI_AboutTrgEn = 512;

	public const ushort P9116_AI_LocalGND = 0;

	public const ushort P9116_AI_UserCMMD = 1;

	public const ushort P9116_AI_SingEnded = 0;

	public const ushort P9116_AI_Differential = 2;

	public const ushort P9116_AI_BiPolar = 0;

	public const ushort P9116_AI_UniPolar = 4;

	public const ushort P9116_TRGMOD_SOFT = 0;

	public const ushort P9116_TRGMOD_POST = 16;

	public const ushort P9116_TRGMOD_DELAY = 32;

	public const ushort P9116_TRGMOD_PRE = 48;

	public const ushort P9116_TRGMOD_MIDL = 64;

	public const ushort P9116_AI_TrgPositive = 0;

	public const ushort P9116_AI_TrgNegative = 128;

	public const ushort P9116_AI_ExtTimeBase = 256;

	public const ushort P9116_AI_IntTimeBase = 0;

	public const ushort P9116_AI_DlyInSamples = 512;

	public const ushort P9116_AI_DlyInTimebase = 0;

	public const ushort P9116_AI_ReTrigEn = 1024;

	public const ushort P9116_AI_MCounterEn = 2048;

	public const ushort P9116_AI_SoftPolling = 0;

	public const ushort P9116_AI_INT = 4096;

	public const ushort P9116_AI_DMA = 8192;

	public const ushort P9812_TRGMOD_SOFT = 0;

	public const ushort P9812_TRGMOD_POST = 1;

	public const ushort P9812_TRGMOD_PRE = 2;

	public const ushort P9812_TRGMOD_DELAY = 3;

	public const ushort P9812_TRGMOD_MIDL = 4;

	public const ushort P9812_AIEvent_Manual = 8;

	public const ushort P9812_TRGSRC_CH0 = 0;

	public const ushort P9812_TRGSRC_CH1 = 8;

	public const ushort P9812_TRGSRC_CH2 = 16;

	public const ushort P9812_TRGSRC_CH3 = 24;

	public const ushort P9812_TRGSRC_EXT_DIG = 32;

	public const ushort P9812_TRGSLP_POS = 0;

	public const ushort P9812_TRGSLP_NEG = 64;

	public const ushort P9812_AD2_GT_PCI = 128;

	public const ushort P9812_AD2_LT_PCI = 0;

	public const ushort P9812_CLKSRC_INT = 0;

	public const ushort P9812_CLKSRC_EXT_SIN = 256;

	public const ushort P9812_CLKSRC_EXT_DIG = 512;

	public const ushort EMGSHDN_OFF = 0;

	public const ushort EMGSHDN_ON = 1;

	public const ushort EMGSHDN_RECOVERY = 2;

	public const ushort HRH_OFF = 0;

	public const ushort HRH_ON = 1;

	public const ushort TOGGLE_OUTPUT = 0;

	public const ushort PROG_ONE_SHOT = 1;

	public const ushort RATE_GENERATOR = 2;

	public const ushort SQ_WAVE_RATE_GENERATOR = 3;

	public const ushort SOFT_TRIG = 4;

	public const ushort HARD_TRIG = 5;

	public const ushort General_Counter = 0;

	public const ushort Pulse_Generation = 1;

	public const ushort GPTC_CLKSRC_EXT = 8;

	public const ushort GPTC_CLKSRC_INT = 0;

	public const ushort GPTC_GATESRC_EXT = 16;

	public const ushort GPTC_GATESRC_INT = 0;

	public const ushort GPTC_UPDOWN_SELECT_EXT = 32;

	public const ushort GPTC_UPDOWN_SELECT_SOFT = 0;

	public const ushort GPTC_UP_CTR = 64;

	public const ushort GPTC_DOWN_CTR = 0;

	public const ushort GPTC_ENABLE = 128;

	public const ushort GPTC_DISABLE = 0;

	public const ushort WDT_DISARM = 0;

	public const ushort WDT_ARM = 1;

	public const ushort WDT_RESTART = 2;

	public const ushort INIT_PTN = 0;

	public const ushort EMGSHDN_PTN = 1;

	public const ushort BIN = 0;

	public const ushort BCD = 1;

	public const ushort INIT_PTN_CH0 = 0;

	public const ushort INIT_PTN_CH1 = 1;

	public const ushort SAFTOUT_PTN_CH0 = 4;

	public const ushort SAFTOUT_PTN_CH1 = 5;

	public const ushort AIEnd = 0;

	public const ushort DIEnd = 0;

	public const ushort DOEnd = 0;

	public const ushort DBEvent = 1;

	public const ushort RegBySlot = 32768;

	[DllImport("PCI-Dask.dll")]
	public static extern short Register_Card(ushort CardType, ushort card_num);

	[DllImport("PCI-Dask.dll")]
	public static extern short Release_Card(ushort CardNumber);

	[DllImport("PCI-Dask.dll")]
	public static extern short GetActualRate(ushort CardNumber, double fSampleRate, out double fActualRate);

	[DllImport("PCI-Dask.dll")]
	public static extern short EMGShutDownControl(ushort CardNumber, byte ctrl);

	[DllImport("PCI-Dask.dll")]
	public static extern short EMGShutDownStatus(ushort CardNumber, out byte sts);

	[DllImport("PCI-Dask.dll")]
	public static extern short HotResetHoldControl(ushort wCardNumber, byte enable);

	[DllImport("PCI-Dask.dll")]
	public static extern short HotResetHoldStatus(ushort wCardNumber, out byte sts);

	[DllImport("PCI-Dask.dll")]
	public static extern short GetInitPattern(ushort CardNumber, byte patID, out uint pattern);

	[DllImport("PCI-Dask.dll")]
	public static extern short SetInitPattern(ushort wCardNumber, byte patID, uint pattern);

	[DllImport("PCI-Dask.dll")]
	public static extern short IdentifyLED_Control(ushort CardNumber, byte ctrl);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_9111_Config(ushort CardNumber, ushort TrigSource, ushort TrgMode, ushort TraceCnt);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_9112_Config(ushort CardNumber, ushort TrigSource);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_9113_Config(ushort CardNumber, ushort TrigSource);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_9114_Config(ushort CardNumber, ushort TrigSource);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_9116_Config(ushort CardNumber, ushort ConfigCtrl, ushort TrigCtrl, ushort PostCnt, ushort MCnt, ushort ReTrgCnt);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_9118_Config(ushort CardNumber, ushort ModeCtrl, ushort FunCtrl, ushort BurstCnt, ushort PostCnt);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_9812_Config(ushort CardNumber, ushort TrgMode, ushort TrgSrc, ushort TrgPol, ushort ClkSel, ushort TrgLevel, ushort PostCnt);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_9812_SetDiv(ushort wCardNumber, uint PacerVal);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_9114_PreTrigConfig(ushort CardNumber, ushort PreTrgEn, ushort TraceCnt);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_9116_CounterInterval(ushort wCardNumber, uint ScanIntrv, uint SampIntrv);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_InitialMemoryAllocated(ushort CardNumber, out uint MemSize);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_ReadChannel(ushort CardNumber, ushort Channel, ushort AdRange, out ushort Value);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_VReadChannel(ushort CardNumber, ushort Channel, ushort AdRange, out double voltage);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_VoltScale(ushort CardNumber, ushort AdRange, ushort reading, out double voltage);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_ContReadChannel(ushort CardNumber, ushort Channel, ushort AdRange, ushort[] Buffer, uint ReadCount, double SampleRate, ushort SyncMode);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_ContReadMultiChannels(ushort CardNumber, ushort NumChans, ushort[] Chans, ushort[] AdRanges, ushort[] Buffer, uint ReadCount, double SampleRate, ushort SyncMode);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_ContScanChannels(ushort CardNumber, ushort Channel, ushort AdRange, ushort[] Buffer, uint ReadCount, double SampleRate, ushort SyncMode);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_ContReadChannelToFile(ushort CardNumber, ushort Channel, ushort AdRange, string FileName, uint ReadCount, double SampleRate, ushort SyncMode);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_ContReadMultiChannelsToFile(ushort CardNumber, ushort NumChans, ushort[] Chans, ushort[] AdRanges, string[] FileName, uint ReadCount, double SampleRate, ushort SyncMode);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_ContScanChannelsToFile(ushort CardNumber, ushort Channel, ushort AdRange, string FileName, uint ReadCount, double SampleRate, ushort SyncMode);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_ContStatus(ushort CardNumber, out ushort Status);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_ContVScale(ushort wCardNumber, ushort adRange, ushort[] readingArray, double[] voltageArray, int count);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_AsyncCheck(ushort CardNumber, out byte Stopped, out uint AccessCnt);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_AsyncClear(ushort CardNumber, out uint AccessCnt);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_AsyncDblBufferHalfReady(ushort CardNumber, out byte HalfReady, out byte StopFlag);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_AsyncDblBufferMode(ushort CardNumber, bool Enable);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_AsyncDblBufferTransfer(ushort CardNumber, ushort[] Buffer);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_AsyncDblBufferOverrun(ushort CardNumber, ushort op, out ushort overrunFlag);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_EventCallBack(ushort CardNumber, ushort mode, ushort EventType, MulticastDelegate callbackAddr);

	[DllImport("PCI-Dask.dll")]
	public static extern short AO_6208A_Config(ushort CardNumber, ushort V2AMode);

	[DllImport("PCI-Dask.dll")]
	public static extern short AO_6308A_Config(ushort CardNumber, ushort V2AMode);

	[DllImport("PCI-Dask.dll")]
	public static extern short AO_6308V_Config(ushort wCardNumber, ushort Channel, ushort wOutputPolarity, double refVoltage);

	[DllImport("PCI-Dask.dll")]
	public static extern short AO_9111_Config(ushort CardNumber, ushort OutputPolarity);

	[DllImport("PCI-Dask.dll")]
	public static extern short AO_9112_Config(ushort CardNumber, ushort Channel, double refVoltage);

	[DllImport("PCI-Dask.dll")]
	public static extern short AO_WriteChannel(ushort CardNumber, ushort Channel, short Value);

	[DllImport("PCI-Dask.dll")]
	public static extern short AO_VWriteChannel(ushort CardNumber, ushort Channel, double Voltage);

	[DllImport("PCI-Dask.dll")]
	public static extern short AO_VoltScale(ushort CardNumber, ushort Channel, double Voltage, out short binValue);

	[DllImport("PCI-Dask.dll")]
	public static extern short AO_SimuWriteChannel(ushort wCardNumber, ushort wGroup, short[] pwBuffer);

	[DllImport("PCI-Dask.dll")]
	public static extern short AO_SimuVWriteChannel(ushort wCardNumber, ushort wGroup, double[] VBuffer);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_7200_Config(ushort CardNumber, ushort TrigSource, ushort ExtTrigEn, ushort TrigPol, ushort I_REQ_Pol);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_7300A_Config(ushort CardNumber, ushort PortWidth, ushort TrigSource, ushort WaitStatus, ushort Terminator, ushort I_REQ_Pol, bool clear_fifo, bool disable_di);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_7300B_Config(ushort CardNumber, ushort PortWidth, ushort TrigSource, ushort WaitStatus, ushort Terminator, ushort I_Cntrl_Pol, bool clear_fifo, bool disable_di);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_InitialMemoryAllocated(ushort CardNumber, out uint DmaSize);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_ReadLine(ushort CardNumber, ushort Port, ushort Line, out ushort State);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_ReadPort(ushort CardNumber, ushort Port, out uint Value);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_ContReadPort(ushort CardNumber, ushort Port, byte[] Buffer, uint ReadCount, double SampleRate, ushort SyncMode);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_ContReadPort(ushort CardNumber, ushort Port, ushort[] Buffer, uint ReadCount, double SampleRate, ushort SyncMode);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_ContReadPort(ushort CardNumber, ushort Port, uint[] Buffer, uint ReadCount, double SampleRate, ushort SyncMode);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_ContReadPortToFile(ushort CardNumber, ushort Port, string FileName, uint ReadCount, double SampleRate, ushort SyncMode);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_ContStatus(ushort CardNumber, out ushort Status);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_AsyncCheck(ushort CardNumber, out byte Stopped, out uint AccessCnt);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_AsyncClear(ushort CardNumber, out uint AccessCnt);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_AsyncDblBufferHalfReady(ushort CardNumber, out byte HalfReady);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_AsyncDblBufferMode(ushort CardNumber, bool Enable);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_AsyncDblBufferTransfer(ushort CardNumber, byte[] Buffer);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_AsyncDblBufferTransfer(ushort CardNumber, short[] Buffer);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_AsyncDblBufferTransfer(ushort CardNumber, uint[] Buffer);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_ContMultiBufferSetup(ushort wCardNumber, byte[] pwBuffer, uint dwReadCount, out ushort BufferId);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_ContMultiBufferSetup(ushort wCardNumber, short[] pwBuffer, uint dwReadCount, out ushort BufferId);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_ContMultiBufferSetup(ushort wCardNumber, uint[] pwBuffer, uint dwReadCount, out ushort BufferId);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_ContMultiBufferStart(ushort wCardNumber, ushort wPort, double fSampleRate);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_AsyncMultiBufferNextReady(ushort CardNumber, out byte bNextReady, out ushort wBufferId);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_AsyncDblBufferOverrun(ushort CardNumber, ushort op, out ushort overrunFlag);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_EventCallBack(ushort CardNumber, short mode, short EventType, MulticastDelegate callbackAddr);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_7200_Config(ushort CardNumber, ushort TrigSource, ushort OutReqEn, ushort OutTrigSig);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_7300A_Config(ushort CardNumber, ushort PortWidth, ushort TrigSource, ushort WaitStatus, ushort Terminator, ushort O_REQ_Pol);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_7300B_Config(ushort CardNumber, ushort PortWidth, ushort TrigSource, ushort WaitStatus, ushort Terminator, ushort O_Cntrl_Pol, uint FifoThreshold);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_InitialMemoryAllocated(ushort CardNumber, out uint MemSize);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_WriteLine(ushort CardNumber, ushort Port, ushort Line, ushort Value);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_WritePort(ushort CardNumber, byte Port, uint Value);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_WritePort(ushort CardNumber, ushort Port, uint Value);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_WritePort(ushort CardNumber, uint Port, uint Value);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_WriteExtTrigLine(ushort CardNumber, ushort Value);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_ReadLine(ushort CardNumber, ushort Port, ushort Line, out ushort Value);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_ReadPort(ushort CardNumber, ushort Port, out uint Value);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_ContWritePort(ushort CardNumber, ushort Port, byte[] Buffer, uint WriteCount, ushort Iterations, double SampleRate, ushort SyncMode);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_ContWritePort(ushort CardNumber, ushort Port, ushort[] Buffer, uint WriteCount, ushort Iterations, double SampleRate, ushort SyncMode);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_ContWritePort(ushort CardNumber, ushort Port, uint[] Buffer, uint WriteCount, ushort Iterations, double SampleRate, ushort SyncMode);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_PGStart(ushort CardNumber, byte[] Buffer, uint WriteCount, double SampleRate);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_PGStart(ushort CardNumber, short[] Buffer, uint WriteCount, double SampleRate);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_PGStart(ushort CardNumber, uint[] Buffer, uint WriteCount, double SampleRate);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_PGStop(ushort CardNumber);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_ContStatus(ushort CardNumber, out ushort Status);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_AsyncCheck(ushort CardNumber, out byte Stopped, out uint AccessCnt);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_AsyncClear(ushort CardNumber, out uint AccessCnt);

	[DllImport("PCI-Dask.dll")]
	public static extern short EDO_9111_Config(ushort CardNumber, ushort EDO_Fun);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_ContMultiBufferSetup(ushort CardNumber, byte[] pwBuffer, uint dwWriteCount, out ushort BufferId);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_ContMultiBufferSetup(ushort CardNumber, short[] pwBuffer, uint dwWriteCount, out ushort BufferId);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_ContMultiBufferSetup(ushort CardNumber, uint[] pwBuffer, uint dwWriteCount, out ushort BufferId);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_AsyncMultiBufferNextReady(ushort CardNumber, out byte bNextReady, out ushort wBufferId);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_ContMultiBufferStart(ushort wCardNumber, ushort wPort, double fSampleRate);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_EventCallBack(ushort CardNumber, short mode, short EventType, MulticastDelegate callbackAddr);

	[DllImport("PCI-Dask.dll")]
	public static extern short DIO_PortConfig(ushort CardNumber, ushort Port, ushort Direction);

	[DllImport("PCI-Dask.dll")]
	public static extern short DIO_LinesConfig(ushort wCardNumber, ushort wPort, ushort wLinesdirmap);

	[DllImport("PCI-Dask.dll")]
	public static extern short DIO_LineConfig(ushort wCardNumber, ushort wPort, ushort wLine, ushort wDirection);

	[DllImport("PCI-Dask.dll")]
	public static extern short DIO_SetDualInterrupt(ushort CardNumber, short Int1Mode, short Int2Mode, long hEvent);

	[DllImport("PCI-Dask.dll")]
	public static extern short DIO_SetCOSInterrupt(ushort CardNumber, ushort Port, ushort ctlA, ushort ctlB, ushort ctlC);

	[DllImport("PCI-Dask.dll")]
	public static extern short DIO_INT1_EventMessage(ushort CardNumber, short Int1Mode, long windowHandle, long message, MulticastDelegate callbackAddr);

	[DllImport("PCI-Dask.dll")]
	public static extern short DIO_INT2_EventMessage(ushort CardNumber, short Int2Mode, long windowHandle, long message, MulticastDelegate callbackAddr);

	[DllImport("PCI-Dask.dll")]
	public static extern short DIO_7300SetInterrupt(ushort CardNumber, short AuxDIEn, short T2En, long hEvent);

	[DllImport("PCI-Dask.dll")]
	public static extern short DIO_AUXDI_EventMessage(ushort CardNumber, short AuxDIEn, long windowHandle, uint message, MulticastDelegate callbackAddr);

	[DllImport("PCI-Dask.dll")]
	public static extern short DIO_T2_EventMessage(ushort CardNumber, short T2En, long windowHandle, uint message, MulticastDelegate callbackAddr);

	[DllImport("PCI-Dask.dll")]
	public static extern short DIO_GetCOSLatchData(ushort wCardNumber, out ushort CosLData);

	[DllImport("PCI-Dask.dll")]
	public static extern short DIO_SetCOSInterrupt32(ushort wCardNumber, byte Port, uint ctl, out long hEvent, bool bManualReset);

	[DllImport("PCI-Dask.dll")]
	public static extern short DIO_GetCOSLatchDataInt32(ushort wCardNumber, byte Port, out uint CosLData);

	[DllImport("PCI-Dask.dll")]
	public static extern short CTR_Setup(ushort CardNumber, ushort Ctr, ushort Mode, uint Count, ushort BinBcd);

	[DllImport("PCI-Dask.dll")]
	public static extern short CTR_Clear(ushort CardNumber, ushort Ctr, ushort State);

	[DllImport("PCI-Dask.dll")]
	public static extern short CTR_Read(ushort CardNumber, ushort Ctr, out uint Value);

	[DllImport("PCI-Dask.dll")]
	public static extern short CTR_Update(ushort CardNumber, ushort Ctr, uint Count);

	[DllImport("PCI-Dask.dll")]
	public static extern short CTR_8554_ClkSrc_Config(ushort CardNumber, ushort Ctr, ushort ClockSource);

	[DllImport("PCI-Dask.dll")]
	public static extern short CTR_8554_CK1_Config(ushort CardNumber, ushort ClockSource);

	[DllImport("PCI-Dask.dll")]
	public static extern short CTR_8554_Debounce_Config(ushort CardNumber, ushort DebounceClock);

	[DllImport("PCI-Dask.dll")]
	public static extern short GCTR_Setup(ushort wCardNumber, ushort wGCtr, ushort wGCtrCtrl, uint dwCount);

	[DllImport("PCI-Dask.dll")]
	public static extern short GCTR_Clear(ushort wCardNumber, ushort wGCtr);

	[DllImport("PCI-Dask.dll")]
	public static extern short GCTR_Read(ushort wCardNumber, ushort wGCtr, out uint pValue);

	[DllImport("PCI-Dask.dll")]
	public static extern short WDT_Setup(ushort CardNumber, ushort wCtr, float ovflowSec, out float actualSec, out long hEvent);

	[DllImport("PCI-Dask.dll")]
	public static extern short WDT_Control(ushort wCardNumber, ushort wCtr, ushort action);

	[DllImport("PCI-Dask.dll")]
	public static extern short WDT_Status(ushort wCardNumber, ushort Ctr, out uint pValue);

	[DllImport("PCI-Dask.dll")]
	public static extern short WDT_Reload(ushort wCardNumber, float ovflowSec, out float actualSec);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_GetEvent(ushort wCardNumber, out long hEvent);

	[DllImport("PCI-Dask.dll")]
	public static extern short AO_GetEvent(ushort wCardNumber, out long hEvent);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_GetEvent(ushort wCardNumber, out long hEvent);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_GetEvent(ushort wCardNumber, out long hEvent);

	[DllImport("PCI-Dask.dll")]
	public static extern short AI_GetView(ushort wCardNumber, uint[] pView);

	[DllImport("PCI-Dask.dll")]
	public static extern short DI_GetView(ushort wCardNumber, uint[] pView);

	[DllImport("PCI-Dask.dll")]
	public static extern short DO_GetView(ushort wCardNumber, uint[] pView);

	[DllImport("PCI-Dask.dll")]
	public static extern short GetCardType(ushort wCardNumber, out ushort cardType);

	[DllImport("PCI-Dask.dll")]
	public static extern short GetCardIndexFromID(ushort wCardNumber, out ushort cardType, out ushort cardIndex);

	[DllImport("PCI-Dask.dll")]
	public static extern short GetBaseAddr(ushort wCardNumber, uint[] BaseAddr, uint[] BaseAddr2);

	[DllImport("PCI-Dask.dll")]
	public static extern short GetLCRAddr(ushort wCardNumber, uint[] LcrAddr);

	[STAThread]
	private static extern void Main();

	private static extern void bufferFunc(byte[] a);
}
