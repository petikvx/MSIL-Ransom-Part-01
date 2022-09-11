using System;
using System.Collections;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml.XPath;
using Kennedy.ManagedHooks;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

[StandardModule]
public sealed class peremens
{
	public class ReNameThread
	{
		public object nodReN;

		public object objReN;

		public ReNameThread(TreeNode node, reName neTransARename = null)
		{
			nodReN = node;
			objReN = neTransARename;
		}

		public void transTree()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			peremens.transTree((TreeNode)nodReN, (reName)objReN);
		}
	}

	public class SortByText : IComparer
	{
		public int CompareTo(object first, object second)
		{
			return string.Compare(Conversions.ToString(NewLateBinding.LateGet(first, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToString(NewLateBinding.LateGet(second, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		}

		int IComparer.Compare(object first, object second)
		{
			//ILSpy generated this explicit interface implementation from .override directive in CompareTo
			return this.CompareTo(first, second);
		}
	}

	public class SortByDataGridCell : IComparer
	{
		public int Compare(object first, object second)
		{
			if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(first, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(second, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null), false))
			{
				return -1;
			}
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(first, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(second, (Type)null, "RowIndex", new object[0], (string[])null, (Type[])null, (bool[])null), false))
			{
				return 1;
			}
			if (Operators.ConditionalCompareObjectLess(NewLateBinding.LateGet(first, (Type)null, "ColumnIndex", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(second, (Type)null, "ColumnIndex", new object[0], (string[])null, (Type[])null, (bool[])null), false))
			{
				return -1;
			}
			return 1;
		}
	}

	public class SortByTextMenu : IComparer
	{
		public int CompareTo(object first, object second)
		{
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(first, (Type)null, "DropDownItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false), Operators.CompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(second, (Type)null, "DropDownItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))))
			{
				return 1;
			}
			if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(first, (Type)null, "DropDownItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false), Operators.CompareObjectEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(second, (Type)null, "DropDownItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))))
			{
				return -1;
			}
			return string.Compare(Conversions.ToString(NewLateBinding.LateGet(first, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)), Conversions.ToString(NewLateBinding.LateGet(second, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
		}

		int IComparer.Compare(object first, object second)
		{
			//ILSpy generated this explicit interface implementation from .override directive in CompareTo
			return this.CompareTo(first, second);
		}
	}

	public struct MasterPattern
	{
		public bool withUslovie;

		public string Show;

		public bool IncludeReadOnly;

		public object ownTextBox;

		public string Text;

		public MySplitStruct Bloki;

		public bool estBls;

		public MasterPattern(object ownTextBox, string show = "Propertys", bool IncludeReadOnly = true, bool withUslovie = false)
		{
			this = default(MasterPattern);
			this.ownTextBox = RuntimeHelpers.GetObjectValue(ownTextBox);
			if (ownTextBox != null)
			{
				Text = Conversions.ToString(NewLateBinding.LateGet(ownTextBox, (Type)null, "text", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			Show = show;
			this.IncludeReadOnly = IncludeReadOnly;
			this.withUslovie = withUslovie;
		}

		public void SetBloki(MySplitStruct bloki)
		{
			Bloki = bloki;
			estBls = true;
		}
	}

	public struct ErrString
	{
		public string str;

		public string err;

		public ErrString(string str)
		{
			this = default(ErrString);
			this.str = str;
		}

		public ErrString(string str, string err)
		{
			this = default(ErrString);
			this.str = str;
			this.err = err;
		}
	}

	public class SolvingTree
	{
		public SolvingTree top;

		public SolvingTree[] chld;

		public string oldvalue;

		public string txt;

		public int index;

		public SolvingTree(string txt, int index, SolvingTree[] chld)
		{
			this.txt = txt;
			oldvalue = txt;
			this.index = index;
			this.chld = chld;
		}
	}

	public struct locat
	{
		public int left;

		public int top;

		public object x
		{
			get
			{
				return left;
			}
			set
			{
				left = Conversions.ToInteger(value);
			}
		}

		public object y
		{
			get
			{
				return top;
			}
			set
			{
				top = Conversions.ToInteger(value);
			}
		}
	}

	public class ProjParam
	{
		private Image IconForm;

		private string pname;

		private string ppath;

		private string ipath;

		public void load(string str)
		{
		}
	}

	public class reName
	{
		public string objName;

		public string old_objName;

		public string frmName;

		public string old_frmName;

		public reName(string objName, string frmName, string old_objName, string old_frmName)
		{
			this.objName = objName;
			this.frmName = frmName;
			this.old_objName = old_objName;
			this.old_frmName = old_frmName;
		}

		public object GetNewFormName(string frm)
		{
			if (Operators.CompareString(frm.ToUpper(), old_frmName.ToUpper(), false) == 0)
			{
				return frmName;
			}
			return frm;
		}

		public object GetNewObjName(string obj)
		{
			if (Operators.CompareString(obj.ToUpper(), old_objName.ToUpper(), false) == 0)
			{
				return objName;
			}
			return obj;
		}
	}

	public class ObjsTreesText
	{
		public object[] Objs;

		public string[] Origs;

		public int[] Starts;

		public int[] Lengs;

		public int popravka;

		public ObjsTreesText(object[] MyObs)
		{
			Objs = MyObs;
			checked
			{
				Starts = new int[Objs.Length - 1 + 1];
				Lengs = new int[Objs.Length - 1 + 1];
				Origs = new string[Objs.Length - 1 + 1];
			}
		}
	}

	public enum MouseEvent
	{
		LeftButtonDown = 513,
		LeftButtonUp = 514,
		Move = 512,
		MouseWheel = 522,
		RightButtonDown = 516,
		RightButtonUp = 517
	}

	public enum KeyboardEvents
	{
		KeyDown = 256,
		KeyUp = 257,
		SystemKeyDown = 260,
		SystemKeyUp = 261
	}

	public struct SYSTEMTIME
	{
		public short wYear;

		public short wMonth;

		public short wDayOfWeek;

		public short wDay;

		public short wHour;

		public short wMinute;

		public short wSecond;

		public short wMilliseconds;
	}

	public enum ReturnCodes
	{
		DISP_CHANGE_SUCCESSFUL = 0,
		DISP_CHANGE_BADDUALVIEW = -6,
		DISP_CHANGE_BADFLAGS = -4,
		DISP_CHANGE_BADMODE = -2,
		DISP_CHANGE_BADPARAM = -5,
		DISP_CHANGE_FAILED = -1,
		DISP_CHANGE_NOTUPDATED = -3,
		DISP_CHANGE_RESTART = 1
	}

	public struct DevMode
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string dmDeviceName;

		public short dmSpecVersion;

		public short dmDriverVersion;

		public short dmSize;

		public short dmDriverExtra;

		public int dmFields;

		public int dmPositionX;

		public int dmPositionY;

		public int dmDisplayOrientation;

		public int dmDisplayFixedOutput;

		public short dmColor;

		public short dmDuplex;

		public short dmYResolution;

		public short dmTTOption;

		public short dmCollate;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string dmFormName;

		public short dmLogPixels;

		public short dmBitsPerPel;

		public int dmPelsWidth;

		public int dmPelsHeight;

		public int dmDisplayFlags;

		public int dmDisplayFrequency;

		public int dmICMMethod;

		public int dmICMIntent;

		public int dmMediaType;

		public int dmDitherType;

		public int dmReserved1;

		public int dmReserved2;

		public int dmPanningWidth;

		public int dmPanningHeight;

		public override string ToString()
		{
			return dmPelsWidth + " x " + dmPelsHeight;
		}

		public string[] GetInfoArray()
		{
			return new string[6]
			{
				dmDeviceName,
				dmPelsWidth.ToString(),
				dmPelsHeight.ToString(),
				dmDisplayFrequency.ToString(),
				dmBitsPerPel.ToString(),
				null
			};
		}
	}

	public enum SystemParameters : uint
	{
		NoParameter = 0u,
		SPIF_UPDATEINIFILE = 1u,
		SPIF_SENDWININICHANGE = 2u,
		SPI_GETBEEP = 1u,
		SPI_SETBEEP = 2u,
		SPI_GETMOUSE = 3u,
		SPI_SETMOUSE = 4u,
		SPI_GETBORDER = 5u,
		SPI_SETBORDER = 6u,
		SPI_GETKEYBOARDSPEED = 10u,
		SPI_SETKEYBOARDSPEED = 11u,
		SPI_LANGDRIVER = 12u,
		SPI_ICONHORIZONTALSPACING = 13u,
		SPI_GETSCREENSAVETIMEOUT = 14u,
		SPI_SETSCREENSAVETIMEOUT = 15u,
		SPI_GETSCREENSAVEACTIVE = 16u,
		SPI_SETSCREENSAVEACTIVE = 17u,
		SPI_GETGRIDGRANULARITY = 18u,
		SPI_SETGRIDGRANULARITY = 19u,
		SPI_SETDESKWALLPAPER = 20u,
		SPI_SETDESKPATTERN = 21u,
		SPI_GETKEYBOARDDELAY = 22u,
		SPI_SETKEYBOARDDELAY = 23u,
		SPI_ICONVERTICALSPACING = 24u,
		SPI_GETICONTITLEWRAP = 25u,
		SPI_SETICONTITLEWRAP = 26u,
		SPI_GETMENUDROPALIGNMENT = 27u,
		SPI_SETMENUDROPALIGNMENT = 28u,
		SPI_SETDOUBLECLKWIDTH = 29u,
		SPI_SETDOUBLECLKHEIGHT = 30u,
		SPI_GETICONTITLELOGFONT = 31u,
		SPI_SETDOUBLECLICKTIME = 32u,
		SPI_SETMOUSEBUTTONSWAP = 33u,
		SPI_SETICONTITLELOGFONT = 34u,
		SPI_GETFASTTASKSWITCH = 35u,
		SPI_SETFASTTASKSWITCH = 36u,
		SPI_SETDRAGFULLWINDOWS = 37u,
		SPI_GETDRAGFULLWINDOWS = 38u,
		SPI_GETNONCLIENTMETRICS = 41u,
		SPI_SETNONCLIENTMETRICS = 42u,
		SPI_GETMINIMIZEDMETRICS = 43u,
		SPI_SETMINIMIZEDMETRICS = 44u,
		SPI_GETICONMETRICS = 45u,
		SPI_SETICONMETRICS = 46u,
		SPI_SETWORKAREA = 47u,
		SPI_GETWORKAREA = 48u,
		SPI_SETPENWINDOWS = 49u,
		SPI_GETHIGHCONTRAST = 66u,
		SPI_SETHIGHCONTRAST = 67u,
		SPI_GETKEYBOARDPREF = 68u,
		SPI_SETKEYBOARDPREF = 69u,
		SPI_GETSCREENREADER = 70u,
		SPI_SETSCREENREADER = 71u,
		SPI_GETANIMATION = 72u,
		SPI_SETANIMATION = 73u,
		SPI_GETFONTSMOOTHING = 74u,
		SPI_SETFONTSMOOTHING = 75u,
		SPI_SETDRAGWIDTH = 76u,
		SPI_SETDRAGHEIGHT = 77u,
		SPI_SETHANDHELD = 78u,
		SPI_GETLOWPOWERTIMEOUT = 79u,
		SPI_GETPOWEROFFTIMEOUT = 80u,
		SPI_SETLOWPOWERTIMEOUT = 81u,
		SPI_SETPOWEROFFTIMEOUT = 82u,
		SPI_GETLOWPOWERACTIVE = 83u,
		SPI_GETPOWEROFFACTIVE = 84u,
		SPI_SETLOWPOWERACTIVE = 85u,
		SPI_SETPOWEROFFACTIVE = 86u,
		SPI_SETCURSORS = 87u,
		SPI_SETICONS = 88u,
		SPI_GETDEFAULTINPUTLANG = 89u,
		SPI_SETDEFAULTINPUTLANG = 90u,
		SPI_SETLANGTOGGLE = 91u,
		SPI_GETWINDOWSEXTENSION = 92u,
		SPI_SETMOUSETRAILS = 93u,
		SPI_GETMOUSETRAILS = 94u,
		SPI_SETSCREENSAVERRUNNING = 97u,
		SPI_SCREENSAVERRUNNING = 97u,
		SPI_GETFILTERKEYS = 50u,
		SPI_SETFILTERKEYS = 51u,
		SPI_GETTOGGLEKEYS = 52u,
		SPI_SETTOGGLEKEYS = 53u,
		SPI_GETMOUSEKEYS = 54u,
		SPI_SETMOUSEKEYS = 55u,
		SPI_GETSHOWSOUNDS = 56u,
		SPI_SETSHOWSOUNDS = 57u,
		SPI_GETSTICKYKEYS = 58u,
		SPI_SETSTICKYKEYS = 59u,
		SPI_GETACCESSTIMEOUT = 60u,
		SPI_SETACCESSTIMEOUT = 61u,
		SPI_GETSERIALKEYS = 62u,
		SPI_SETSERIALKEYS = 63u,
		SPI_GETSOUNDSENTRY = 64u,
		SPI_SETSOUNDSENTRY = 65u,
		SPI_GETSNAPTODEFBUTTON = 95u,
		SPI_SETSNAPTODEFBUTTON = 96u,
		SPI_GETMOUSEHOVERWIDTH = 98u,
		SPI_SETMOUSEHOVERWIDTH = 99u,
		SPI_GETMOUSEHOVERHEIGHT = 100u,
		SPI_SETMOUSEHOVERHEIGHT = 101u,
		SPI_GETMOUSEHOVERTIME = 102u,
		SPI_SETMOUSEHOVERTIME = 103u,
		SPI_GETWHEELSCROLLLINES = 104u,
		SPI_SETWHEELSCROLLLINES = 105u,
		SPI_GETMENUSHOWDELAY = 106u,
		SPI_SETMENUSHOWDELAY = 107u,
		SPI_GETSHOWIMEUI = 110u,
		SPI_SETSHOWIMEUI = 111u,
		SPI_GETMOUSESPEED = 112u,
		SPI_SETMOUSESPEED = 113u,
		SPI_GETSCREENSAVERRUNNING = 114u,
		SPI_GETDESKWALLPAPER = 115u,
		SPI_GETACTIVEWINDOWTRACKING = 4096u,
		SPI_SETACTIVEWINDOWTRACKING = 4097u,
		SPI_GETMENUANIMATION = 4098u,
		SPI_SETMENUANIMATION = 4099u,
		SPI_GETCOMBOBOXANIMATION = 4100u,
		SPI_SETCOMBOBOXANIMATION = 4101u,
		SPI_GETLISTBOXSMOOTHSCROLLING = 4102u,
		SPI_SETLISTBOXSMOOTHSCROLLING = 4103u,
		SPI_GETGRADIENTCAPTIONS = 4104u,
		SPI_SETGRADIENTCAPTIONS = 4105u,
		SPI_GETKEYBOARDCUES = 4106u,
		SPI_SETKEYBOARDCUES = 4107u,
		SPI_GETMENUUNDERLINES = 4106u,
		SPI_SETMENUUNDERLINES = 4107u,
		SPI_GETACTIVEWNDTRKZORDER = 4108u,
		SPI_SETACTIVEWNDTRKZORDER = 4109u,
		SPI_GETHOTTRACKING = 4110u,
		SPI_SETHOTTRACKING = 4111u,
		SPI_GETMENUFADE = 4114u,
		SPI_SETMENUFADE = 4115u,
		SPI_GETSELECTIONFADE = 4116u,
		SPI_SETSELECTIONFADE = 4117u,
		SPI_GETTOOLTIPANIMATION = 4118u,
		SPI_SETTOOLTIPANIMATION = 4119u,
		SPI_GETTOOLTIPFADE = 4120u,
		SPI_SETTOOLTIPFADE = 4121u,
		SPI_GETCURSORSHADOW = 4122u,
		SPI_SETCURSORSHADOW = 4123u,
		SPI_GETMOUSESONAR = 4124u,
		SPI_SETMOUSESONAR = 4125u,
		SPI_GETMOUSECLICKLOCK = 4126u,
		SPI_SETMOUSECLICKLOCK = 4127u,
		SPI_GETMOUSEVANISH = 4128u,
		SPI_SETMOUSEVANISH = 4129u,
		SPI_GETFLATMENU = 4130u,
		SPI_SETFLATMENU = 4131u,
		SPI_GETDROPSHADOW = 4132u,
		SPI_SETDROPSHADOW = 4133u,
		SPI_GETBLOCKSENDINPUTRESETS = 4134u,
		SPI_SETBLOCKSENDINPUTRESETS = 4135u,
		SPI_GETUIEFFECTS = 4158u,
		SPI_SETUIEFFECTS = 4159u,
		SPI_GETFOREGROUNDLOCKTIMEOUT = 8192u,
		SPI_SETFOREGROUNDLOCKTIMEOUT = 8193u,
		SPI_GETACTIVEWNDTRKTIMEOUT = 8194u,
		SPI_SETACTIVEWNDTRKTIMEOUT = 8195u,
		SPI_GETFOREGROUNDFLASHCOUNT = 8196u,
		SPI_SETFOREGROUNDFLASHCOUNT = 8197u,
		SPI_GETCARETWIDTH = 8198u,
		SPI_SETCARETWIDTH = 8199u,
		SPI_GETMOUSECLICKLOCKTIME = 8200u,
		SPI_SETMOUSECLICKLOCKTIME = 8201u,
		SPI_GETFONTSMOOTHINGTYPE = 8202u,
		SPI_SETFONTSMOOTHINGTYPE = 8203u,
		SPI_GETFONTSMOOTHINGCONTRAST = 8204u,
		SPI_SETFONTSMOOTHINGCONTRAST = 8205u,
		SPI_GETFOCUSBORDERWIDTH = 8206u,
		SPI_SETFOCUSBORDERWIDTH = 8207u,
		SPI_GETFOCUSBORDERHEIGHT = 8208u,
		SPI_SETFOCUSBORDERHEIGHT = 8209u,
		SPI_GETFONTSMOOTHINGORIENTATION = 8210u,
		SPI_SETFONTSMOOTHINGORIENTATION = 8211u
	}

	public class NativeMethods
	{
		[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 28)]
		internal struct INPUT
		{
			[FieldOffset(0)]
			public InputType dwType;

			[FieldOffset(4)]
			public MOUSEINPUT mi;

			[FieldOffset(4)]
			public KEYBDINPUT ki;

			[FieldOffset(4)]
			public HARDWAREINPUT hi;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct MOUSEINPUT
		{
			public int dx;

			public int dy;

			public int mouseData;

			public MOUSEEVENTF dwFlags;

			public int time;

			public IntPtr dwExtraInfo;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct KEYBDINPUT
		{
			public short wVk;

			public short wScan;

			public KEYEVENTF dwFlags;

			public int time;

			public IntPtr dwExtraInfo;
		}

		[StructLayout(LayoutKind.Sequential, Pack = 1)]
		internal struct HARDWAREINPUT
		{
			public int uMsg;

			public short wParamL;

			public short wParamH;
		}

		internal enum InputType
		{
			Mouse,
			Keyboard,
			Hardware
		}

		[Flags]
		internal enum MOUSEEVENTF
		{
			MOVE = 1,
			LEFTDOWN = 2,
			LEFTUP = 4,
			RIGHTDOWN = 8,
			RIGHTUP = 0x10,
			MIDDLEDOWN = 0x20,
			MIDDLEUP = 0x40,
			XDOWN = 0x80,
			XUP = 0x100,
			VIRTUALDESK = 0x400,
			WHEEL = 0x800,
			ABSOLUTE = 0x8000
		}

		[Flags]
		internal enum KEYEVENTF
		{
			KEYDOWN = 0,
			EXTENDEDKEY = 1,
			KEYUP = 2,
			UNICODE = 4,
			SCANCODE = 8
		}

		[DllImport("user32.dll", SetLastError = true)]
		internal static extern int SendInput(int cInputs, ref INPUT pInputs, int cbSize);
	}

	public delegate void RunProj_NodeStop_delegate(TreeNode node, PropertysSobyt param);

	public delegate void Enableds_delegate(bool rn, bool ps, bool so, bool sin, bool sout);

	public delegate void ProgressSub(object value);

	public delegate void SetNodeText_delegate(TreeNode nod, string txt);

	public delegate object GetVal(string str);

	public static bool isDevelop = true;

	public static bool isHelp;

	public static bool isCompilBest;

	public static bool isRunAlg2Code;

	public static bool IsHttpCompil = false;

	public static string algDomenRu = "http://Algoritm2.ru/";

	public static string algDomenEn = "http://Algorithm2.com/";

	public static string algDomenRuWww = "http://www.Algoritm2.ru/";

	public static string algDomenEnWww = "http://www.Algorithm2.com/";

	public static string buyAlgPath = "index.php#GetMore";

	public static string lessonsAlgPath = "index.php/learn/lessons";

	public static string samplesAlgPath = "index.php/learn/samples";

	public static string answersAlgPath = "index.php/learn/answers";

	public const string AppName = "Algorithm";

	public const string IntroImage = "AlgorithmEn.jpg";

	private const string AlgDirName = "Algorithm 2";

	private const string ProjectsDirName = "Projects";

	private const string SamplesDirName = "Examples";

	private const string PicturesDirName = "Pictures";

	public static string lang_def = "English";

	public static string lang_interface = "English";

	public static string lastVersionUrl = algDomenEn + "api/LastVersionEn.php";

	public static string lastFreeVersionDownloadUrl = algDomenEn + "download/Algoritm2EnLast.exe";

	public static string recieveProjectUrl = algDomenEn + "api/recieveProject.php";

	public static string referral;

	public static string Version = "2.7";

	public static string AppNameWithVersion = "Algorithm " + Version;

	public static string AppPath = AppDomain.CurrentDomain.BaseDirectory;

	public static string UserPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\Algorithm 2\\";

	public static string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Algorithm 2\\";

	public static string ProjectsPath = UserPath + "Projects\\";

	public static string SamplesPathDefault = AppPath + "Projects\\Examples\\";

	public static string SamplesPath = ProjectsPath + "Examples\\";

	public static string DataPath = AppPath + "Data\\";

	public static string LessonsPath = DataPath + "VideoLessons\\";

	public static string lang_name = lang_def;

	public static string lang_name_old = lang_def;

	public static string lang_interface_old = lang_interface;

	public static string ParamFilePathDefault = AppPath + "Parametrs.ini";

	public static string ParamFilePath = AppDataPath + "Parametrs.ini";

	public static string OptionsFilePathDefault = AppPath + "Options.ini";

	public static string OptionsFilePath = AppDataPath + "Options.ini";

	public static string LanguagePath = DataPath + "Languages\\";

	public static string CompilPathDefault = DataPath + "Compil\\";

	public static string CompilPath = AppDataPath + "Compile\\";

	public static string ObjectsPath = DataPath + "Objects\\";

	public static string ObjectFile = ObjectsPath + "Compil.exe";

	public static string DllKenMan = AppPath + "Kennedy.ManagedHooks.dll";

	public static string DllCoreHook = AppPath + "SystemHookCore.dll";

	public static string DllVBScript = AppPath + "Interop.MSScriptControl.dll";

	public static string SkinsPath = DataPath + "Pictures\\";

	public static string OblozhkaPath = SkinsPath + "AlgorithmEn.jpg";

	public static string ProjIpath = "Pictures\\";

	public static string XMLPathChld = "XML Help\\";

	public static string HelpPath = DataPath + "Help";

	public static string Skin = "Simple";

	public static string StartEdu = "Yes";

	public static string StartUved = "Yes";

	public static string PicturesPath = "";

	public static SortedList SkinColors = new SortedList();

	public static SortedList SkinPictures = new SortedList();

	public static SortedList SkinOptions = new SortedList();

	public static SortedList HWCategrsSort = new SortedList();

	public static string ClassAplication = "WindowsApplication1.";

	public static object twoSpace = 6;

	public static object markerX = 6;

	public static object markerY = 6;

	public static int setka = 4;

	public static ArrayList RecentProjcts = new ArrayList();

	public static int iHeight = 14;

	public static object formX = 3;

	public static int formY = 3;

	public static TreeView Tree;

	public static TabControl tab;

	public static ImageList Pictures16 = new ImageList();

	public static ImageList Pictures32 = new ImageList();

	public static string[] PicExten = new string[3] { ".JPG", ".JPEG", ".GIF" };

	public static string MyZnak = "_";

	public static double LiterWidth = 6.9;

	public static string oldLVselect;

	public static TabPage SobytsTab;

	public static TabPage DeistTab;

	public static TabPage ifTab;

	public static TabPage CycleTab;

	public static TabPage CommTab;

	public static string[] DopFuns;

	public static string[] DopFunsSimple;

	public static string[] Operations;

	public static string[] opers;

	public static string[] Usloviya;

	public static string[] uslovs;

	public static string[] othersSimb;

	public static string[] allSimb;

	public static string[] VBKeyWords;

	public static object[] PoleznieObjs;

	public static object[] Prioritets;

	public static int MasterHeight;

	public static int MasterWidth;

	public static int MasterSplit;

	public static int OptionsHeight;

	public static int OptionsWidth;

	public static int MainHeight;

	public static int MainWidth;

	public static int MainX;

	public static int MainY;

	public static string SkippedVersion;

	public static string PayLink;

	public static bool FirstLaunchAfterUpdate;

	public static int BeginProgress = 0;

	public static int AlphaPik = 255;

	public static int AlphaNiz = 50;

	public static int MarkCount = 10;

	public static Color ColObject;

	public static Color ColProperty;

	public static Color ColMethod;

	public static Color ColFunction;

	public static Color ColConsts;

	public static Color ColKovi4ki;

	public static Color ColKode;

	public static Color ColBreakpoint;

	public static Color ColDebugNode;

	public static int maxWhileCount = 10000;

	public static int maxRecurs = 20;

	public static int maxRecentProjs = 15;

	public static string[] ReadOnlyProps;

	public static string[] SobytsNotReadOnly;

	public static string[] ArgTypes;

	public static string[] NoSaveProps;

	public static SortedList Colors = new SortedList();

	public static SortedList InfoObjs = new SortedList();

	public static SortedList InfoElems = new SortedList();

	public static SortedList InfoProps = new SortedList();

	public static SortedList lang = new SortedList();

	public static SortedList langENG = new SortedList();

	public static SortedList langLw = new SortedList();

	public static SortedList langLwENG = new SortedList();

	public static SortedList langINFC = new SortedList();

	public static SortedList langLwINFC = new SortedList();

	public static SortedList langOld = new SortedList();

	public static SortedList langLwOld = new SortedList();

	public static SortedList langINFCOld = new SortedList();

	public static SortedList langLwINFCOld = new SortedList();

	public static string[] MayChangeProps = new string[0];

	public static object[] HelpObjs = new object[1];

	public static object[] HWCategrs2;

	public static TreeNode[] Breaks;

	public static RunProject RunProj;

	public static bool isConsole;

	public static bool isTranslate;

	public static bool fromIzmenenieBylo;

	public static bool tokaSohranil;

	public static Thread runProc;

	public static int timeSleep = 20;

	public static int pauseCount = 5;

	private static RichTextBox tempRich = new RichTextBox();

	public static string SiteAlg;

	public static PictureBox[] helps;

	public static string associateError;

	public static string noSimb;

	public static string PointSimb1 = ",";

	public static string PointSimb2 = ".";

	public static bool perenos;

	public static bool IgnorEr;

	public static string[] ProjEvents;

	public static SortedList Pustishki = new SortedList();

	public static bool bistro_StatusLine = false;

	public static bool bistro_orfo = false;

	public static bool bistro_UnRe = false;

	public static bool bistro_HW = true;

	public static bool bistro_podsvFun = false;

	public static bool bistro_podsvHW = false;

	public static bool bistro_podsvObs = false;

	public static bool bistro_podsvPMs = false;

	public static bool bistro_podsvKov = false;

	public static SortedList Anchors = new SortedList();

	public static SortedList bkImStyles = new SortedList();

	public static SortedList Cursori = new SortedList();

	public static SortedList Docks = new SortedList();

	public static SortedList FlatStyles = new SortedList();

	public static SortedList Fonts = new SortedList();

	public static SortedList Aligns = new SortedList();

	public static SortedList TextImages = new SortedList();

	public static SortedList BorderStyles = new SortedList();

	public static SortedList FixedPanels = new SortedList();

	public static SortedList Orientations = new SortedList();

	public static SortedList Papks = new SortedList();

	public static SortedList Keyz = new SortedList();

	public static SortedList DeskStyle = new SortedList();

	public static SortedList TypeRegistry = new SortedList();

	public static SortedList ScrollBarz = new SortedList();

	public static SortedList TextPositions = new SortedList();

	public static SortedList DisplayStyles = new SortedList();

	public static SortedList TextDirections = new SortedList();

	public static SortedList ReadyStates = new SortedList();

	public static SortedList DocumentEncodings = new SortedList();

	public static SortedList Refreshs = new SortedList();

	public static SortedList FormBorderStyles = new SortedList();

	public static SortedList StartPositions = new SortedList();

	public static SortedList WindowStates = new SortedList();

	public static SortedList Alignments = new SortedList();

	public static SortedList CellBorderStyles = new SortedList();

	public static SortedList EditModes = new SortedList();

	public static SortedList SelectionModes = new SortedList();

	public static SortedList Filters = new SortedList();

	public static SortedList LinkBehaviors = new SortedList();

	public static SortedList MsgStyleButtons = new SortedList();

	public static SortedList MsgStyleTypes = new SortedList();

	public static SortedList BdTypes = new SortedList();

	public static SortedList DateFormats = new SortedList();

	public static SortedList TickStyles = new SortedList();

	public static SortedList FileEncodings = new SortedList();

	public static SortedList SizeModes = new SortedList();

	public static SortedList InputTypes = new SortedList();

	public static SortedList ClientServStates = new SortedList();

	public static SortedList ClientServerTypes = new SortedList();

	public static SortedList ContentTypes = new SortedList();

	public static SortedList HttpMethods = new SortedList();

	public static SortedList StylesProgress = new SortedList();

	public static string[] AllFuncs;

	public static string[] AllHW;

	public static string[] AllHWUp;

	public static string[] HWCategrs;

	public static string[] HWCols;

	public static string[] HWDaNet;

	public static string[] HWKnopkiMishi;

	public static string[] HWPapki;

	public static string[] HWKeys;

	public static string[] HWAnchors;

	public static string[] HWbkImStyles;

	public static string[] HWCursori;

	public static string[] HWDocks;

	public static string[] HWFlatStyles;

	public static string[] HWFonts;

	public static string[] HWAligns;

	public static string[] HWTextImages;

	public static string[] HWBorderStyles;

	public static string[] HWFixedPanels;

	public static string[] HWOrientations;

	public static string[] HWOthers;

	public static string[] HWDeskStyle;

	public static string[] HWDeskResolution;

	public static string[] HWTypeRegistry;

	public static string[] HWScrollBarz;

	public static string[] HWTextPositions;

	public static string[] HWDisplayStyles;

	public static string[] HWTextDirections;

	public static string[] HWReadyStates;

	public static string[] HWDocumentEncodings;

	public static string[] HWRefreshs;

	public static string[] HWFormBorderStyles;

	public static string[] HWStartPositions;

	public static string[] HWWindowStates;

	public static string[] HWAlignments;

	public static string[] HWCellBorderStyles;

	public static string[] HWEditModes;

	public static string[] HWSelectionModes;

	public static string[] HWFilters;

	public static string[] HWLinkBehaviors;

	public static string[] HWMsgStyleButtons;

	public static string[] HWMsgStyleTypes;

	public static string[] HWBdTypes;

	public static string[] HWDateFormats;

	public static string[] HWTickStyles;

	public static string[] HWFileEncodings;

	public static string[] HWSizeModes;

	public static string[] HWInputTypes;

	public static string[] HWClientServStates;

	public static string[] HWClientServerTypes;

	public static string[] HWContentTypes;

	public static string[] HWHttpMethods;

	public static string[] HWStylesProgress;

	private static string xmlp = "";

	public static bool isOpening = false;

	private static TreeNode[] retNs;

	[AccessedThroughProperty("mouseHook")]
	private static object _mouseHook;

	[AccessedThroughProperty("keyboardHook")]
	private static object _keyboardHook;

	public static ArrayList ks = new ArrayList();

	public static ArrayList ms = new ArrayList();

	public static bool shft;

	public static bool ctrl;

	public static bool alt;

	public static bool mleft;

	public static bool mright;

	public static bool mwheel;

	public static bool msX;

	public static bool msY;

	public const int MCI_NOTIFY_SUCCESSFUL = 1;

	public const int MM_MCINOTIFY = 129;

	public const int MCIERR_BASE = 256;

	public const int ENUM_CURRENT_SETTINGS = -1;

	public static RunProj_NodeStop_delegate delegatNodeStop;

	public static Enableds_delegate delegatEnableds;

	public static ProgressSub delegatProgress = ProgressN;

	public static ProgressSub delegatProgressShow = ProgressShow;

	public static ProgressSub delegatProgressHide = ProgressHide;

	public static SetNodeText_delegate delegatSetNodeText = SetTextNode;

	[SpecialName]
	private static Random _0024STATIC_0024GetUIN_002400E_0024rnd;

	[SpecialName]
	private static StaticLocalInitFlag _0024STATIC_0024GetUIN_002400E_0024rnd_0024Init = new StaticLocalInitFlag();

	public static string XMLpath
	{
		get
		{
			if (Operators.CompareString(xmlp, "", false) == 0)
			{
				return LanguagePath + lang_name + "\\" + XMLPathChld;
			}
			return xmlp;
		}
		set
		{
			xmlp = value;
		}
	}

	public static object mouseHook
	{
		get
		{
			return _mouseHook;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_mouseHook = RuntimeHelpers.GetObjectValue(value);
		}
	} = "mouse";


	public static object keyboardHook
	{
		get
		{
			return _keyboardHook;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			_keyboardHook = RuntimeHelpers.GetObjectValue(value);
		}
	} = "key";


	public static void setLangs(bool withOld = true, bool withFolder = true)
	{
		string text = default(string);
		string text2 = default(string);
		string text3 = default(string);
		if (withFolder)
		{
			text = lang_name + "\\";
			text2 = "English\\";
			text3 = lang_interface + "\\";
		}
		lang = Get2List(LanguagePath + text + lang_name + ".lng", "~~");
		langLw = Get2List(LanguagePath + text + lang_name + ".lng", "~~", null, withLCase: true);
		langENG = Get2List(LanguagePath + text2 + "English.lng", "~~");
		langLwENG = Get2List(LanguagePath + text2 + "English.lng", "~~", null, withLCase: true);
		langINFC = Get2List(LanguagePath + text3 + lang_interface + ".lng", "~~");
		langLwINFC = Get2List(LanguagePath + text3 + lang_interface + ".lng", "~~", null, withLCase: true);
		if (withOld)
		{
			lang_name_old = lang_name;
			langOld = lang;
			langLwOld = langLw;
			lang_interface_old = lang_interface;
			langINFCOld = langINFC;
			langLwINFCOld = langLwINFC;
		}
	}

	public static string transInfc(string word)
	{
		string text = lang_name;
		string text2 = lang_name;
		text = lang_name;
		lang_name = lang_interface;
		text2 = lang_name_old;
		lang_name_old = lang_interface_old;
		SortedList sortedList = lang;
		SortedList sortedList2 = langLw;
		SortedList sortedList3 = langOld;
		SortedList sortedList4 = langLwOld;
		langOld = langINFCOld;
		langLwOld = langLwINFCOld;
		lang = langINFC;
		langLw = langLwINFC;
		string result = trans(word);
		lang = sortedList;
		langLw = sortedList2;
		langOld = sortedList3;
		langLwOld = sortedList4;
		lang_name = text;
		lang_name_old = text2;
		return result;
	}

	public static string trans(string word, bool toEng = false, bool fromEng = false, bool onOld = false, bool bezCifr = false)
	{
		object obj = "";
		string text = "";
		word = Strings.Trim(word);
		if (word.IndexOf(MyZnak) == 0)
		{
			text = MyZnak;
			word = word.Substring(1);
		}
		if (bezCifr)
		{
			Regex regex = new Regex("[0-9]+$");
			Match match = regex.Match(word);
			if (match.Success)
			{
				obj = match.Value;
				word = word.Substring(0, match.Index);
			}
		}
		if (Operators.CompareString(word, "", false) == 0)
		{
			return "";
		}
		if ((Operators.CompareString(lang_name, "Russian", false) == 0 && !toEng && !fromEng) & (Operators.CompareString(lang_name_old, lang_name, false) == 0))
		{
			return Conversions.ToString(Operators.ConcatenateObject((object)(text + word), obj));
		}
		int num;
		if (fromEng)
		{
			if ((Operators.CompareString(lang_name, "English", false) == 0) & (Operators.CompareString(lang_name_old, lang_name, false) != 0))
			{
				return Conversions.ToString(Operators.ConcatenateObject((object)(text + word), obj));
			}
			num = langLwENG.GetValueList().IndexOf(Strings.LCase(word));
			if (num == -1)
			{
				return Conversions.ToString(Operators.ConcatenateObject((object)(text + word), obj));
			}
			word = Conversions.ToString(langENG.GetKeyList()[num]);
			if (Operators.CompareString(lang_name, "Russian", false) == 0)
			{
				return Conversions.ToString(Operators.ConcatenateObject((object)(text + word), obj));
			}
		}
		if (onOld)
		{
			num = langLwOld.GetKeyList().IndexOf(Strings.LCase(word));
			if (num != -1)
			{
				word = Conversions.ToString(langOld.GetValueList()[num]);
			}
			return Conversions.ToString(Operators.ConcatenateObject((object)(text + word), obj));
		}
		if (!onOld)
		{
			num = langLwOld.GetValueList().IndexOf(Strings.LCase(word));
			if (num != -1)
			{
				word = Conversions.ToString(langOld.GetKeyList()[num]);
			}
		}
		SortedList sortedList;
		SortedList sortedList2;
		if (!toEng)
		{
			sortedList = lang;
			sortedList2 = langLw;
		}
		else
		{
			sortedList2 = langLwENG;
			sortedList = langENG;
		}
		num = sortedList2.GetKeyList().IndexOf(Strings.LCase(word));
		if (num == -1)
		{
			return Conversions.ToString(Operators.ConcatenateObject((object)(text + word), obj));
		}
		return Conversions.ToString(Operators.ConcatenateObject((object)(text + sortedList.GetValueList()[num]!.ToString()!.Trim()), obj));
	}

	public static void transObjects()
	{
		//IL_16b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1816: Unknown result type (might be due to invalid IL or missing references)
		int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		checked
		{
			for (int i = 0; i <= num; i++)
			{
				object proj = peremens2.proj;
				object[] array = new object[1] { i };
				object[] array2 = array;
				bool[] array3 = new bool[1] { true };
				object obj = NewLateBinding.LateGet(proj, (Type)null, "f", array2, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				int num2 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				for (int j = 0; j <= num2; j++)
				{
					object proj2 = peremens2.proj;
					object[] array4 = new object[1] { i };
					object[] array5 = array4;
					array3 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(proj2, (Type)null, "f", array5, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
					}
					object[] array6 = new object[1] { j };
					object[] array7 = array6;
					bool[] array8 = new bool[1] { true };
					object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "MyObjs", array7, (string[])null, (Type[])null, array8);
					if (array8[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
					}
					object[] array29;
					bool[] array31;
					object[] array26;
					bool[] array28;
					if (NewLateBinding.LateGet(obj3, (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
					{
						object proj3 = peremens2.proj;
						object[] array9 = new object[1] { i };
						object[] array10 = array9;
						bool[] array11 = new bool[1] { true };
						object obj4 = NewLateBinding.LateGet(proj3, (Type)null, "f", array10, (string[])null, (Type[])null, array11);
						if (array11[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(int));
						}
						object[] array12 = new object[1] { j };
						object[] array13 = array12;
						bool[] array14 = new bool[1] { true };
						object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "MyObjs", array13, (string[])null, (Type[])null, array14);
						if (array14[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(int));
						}
						int num3 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
						for (int k = 0; k <= num3; k++)
						{
							object proj4 = peremens2.proj;
							object[] array15 = new object[1] { i };
							object[] array16 = array15;
							bool[] array17 = new bool[1] { true };
							object obj6 = NewLateBinding.LateGet(proj4, (Type)null, "f", array16, (string[])null, (Type[])null, array17);
							if (array17[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(int));
							}
							object[] array18 = new object[1] { j };
							object[] array19 = array18;
							bool[] array20 = new bool[1] { true };
							object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "MyObjs", array19, (string[])null, (Type[])null, array20);
							if (array20[0])
							{
								j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array18[0]), typeof(int));
							}
							object[] array21 = new object[2] { k, null };
							object[] array22 = array21;
							object proj5 = peremens2.proj;
							object[] array23 = new object[1] { i };
							object[] array24 = array23;
							bool[] array25 = new bool[1] { true };
							object obj8 = NewLateBinding.LateGet(proj5, (Type)null, "f", array24, (string[])null, (Type[])null, array25);
							if (array25[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array23[0]), typeof(int));
							}
							array26 = new object[1] { j };
							object[] array27 = array26;
							array28 = new bool[1] { true };
							object obj9 = NewLateBinding.LateGet(obj8, (Type)null, "MyObjs", array27, (string[])null, (Type[])null, array28);
							if (array28[0])
							{
								j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array26[0]), typeof(int));
							}
							array29 = new object[1] { k };
							object[] array30 = array29;
							array31 = new bool[1] { true };
							object obj10 = NewLateBinding.LateGet(obj9, (Type)null, "Propertys", array30, (string[])null, (Type[])null, array31);
							if (array31[0])
							{
								k = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array29[0]), typeof(int));
							}
							array22[1] = sZaglavnoi(trans(Conversions.ToString(obj10)));
							NewLateBinding.LateSetComplex(obj7, (Type)null, "Propertys", array21, (string[])null, (Type[])null, false, true);
						}
					}
					object proj6 = peremens2.proj;
					array29 = new object[1] { i };
					object[] array32 = array29;
					array31 = new bool[1] { true };
					object obj11 = NewLateBinding.LateGet(proj6, (Type)null, "f", array32, (string[])null, (Type[])null, array31);
					if (array31[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array29[0]), typeof(int));
					}
					array26 = new object[1] { j };
					object[] array33 = array26;
					array28 = new bool[1] { true };
					object obj12 = NewLateBinding.LateGet(obj11, (Type)null, "MyObjs", array33, (string[])null, (Type[])null, array28);
					if (array28[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array26[0]), typeof(int));
					}
					if (NewLateBinding.LateGet(obj12, (Type)null, "Methods", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
					{
						object proj7 = peremens2.proj;
						object[] array23 = new object[1] { i };
						object[] array34 = array23;
						bool[] array25 = new bool[1] { true };
						object obj13 = NewLateBinding.LateGet(proj7, (Type)null, "f", array34, (string[])null, (Type[])null, array25);
						if (array25[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array23[0]), typeof(int));
						}
						object[] array18 = new object[1] { j };
						object[] array35 = array18;
						bool[] array20 = new bool[1] { true };
						object obj14 = NewLateBinding.LateGet(obj13, (Type)null, "MyObjs", array35, (string[])null, (Type[])null, array20);
						if (array20[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array18[0]), typeof(int));
						}
						int num4 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj14, (Type)null, "Methods", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
						for (int k = 0; k <= num4; k++)
						{
							object proj8 = peremens2.proj;
							object[] array15 = new object[1] { i };
							object[] array36 = array15;
							bool[] array17 = new bool[1] { true };
							object obj15 = NewLateBinding.LateGet(proj8, (Type)null, "f", array36, (string[])null, (Type[])null, array17);
							if (array17[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(int));
							}
							object[] array12 = new object[1] { j };
							object[] array37 = array12;
							bool[] array14 = new bool[1] { true };
							object obj16 = NewLateBinding.LateGet(obj15, (Type)null, "MyObjs", array37, (string[])null, (Type[])null, array14);
							if (array14[0])
							{
								j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(int));
							}
							array4 = new object[2] { k, null };
							object[] array38 = array4;
							object proj9 = peremens2.proj;
							object[] array9 = new object[1] { i };
							object[] array39 = array9;
							bool[] array11 = new bool[1] { true };
							object obj17 = NewLateBinding.LateGet(proj9, (Type)null, "f", array39, (string[])null, (Type[])null, array11);
							if (array11[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(int));
							}
							array6 = new object[1] { j };
							object[] array40 = array6;
							array8 = new bool[1] { true };
							object obj18 = NewLateBinding.LateGet(obj17, (Type)null, "MyObjs", array40, (string[])null, (Type[])null, array8);
							if (array8[0])
							{
								j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
							}
							array = new object[1] { k };
							object[] array41 = array;
							array3 = new bool[1] { true };
							object obj19 = NewLateBinding.LateGet(obj18, (Type)null, "Methods", array41, (string[])null, (Type[])null, array3);
							if (array3[0])
							{
								k = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
							}
							array38[1] = sZaglavnoi(trans(Conversions.ToString(obj19)));
							NewLateBinding.LateSetComplex(obj16, (Type)null, "Methods", array4, (string[])null, (Type[])null, false, true);
						}
					}
					object proj10 = peremens2.proj;
					array29 = new object[1] { i };
					object[] array42 = array29;
					array31 = new bool[1] { true };
					object obj20 = NewLateBinding.LateGet(proj10, (Type)null, "f", array42, (string[])null, (Type[])null, array31);
					if (array31[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array29[0]), typeof(int));
					}
					array26 = new object[1] { j };
					object[] array43 = array26;
					array28 = new bool[1] { true };
					object obj21 = NewLateBinding.LateGet(obj20, (Type)null, "MyObjs", array43, (string[])null, (Type[])null, array28);
					if (array28[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array26[0]), typeof(int));
					}
					if (NewLateBinding.LateGet(obj21, (Type)null, "Sobyts", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
					{
						object proj11 = peremens2.proj;
						object[] array23 = new object[1] { i };
						object[] array44 = array23;
						bool[] array25 = new bool[1] { true };
						object obj22 = NewLateBinding.LateGet(proj11, (Type)null, "f", array44, (string[])null, (Type[])null, array25);
						if (array25[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array23[0]), typeof(int));
						}
						object[] array18 = new object[1] { j };
						object[] array45 = array18;
						bool[] array20 = new bool[1] { true };
						object obj23 = NewLateBinding.LateGet(obj22, (Type)null, "MyObjs", array45, (string[])null, (Type[])null, array20);
						if (array20[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array18[0]), typeof(int));
						}
						int num5 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj23, (Type)null, "Sobyts", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
						for (int k = 0; k <= num5; k++)
						{
							object proj12 = peremens2.proj;
							object[] array15 = new object[1] { i };
							object[] array46 = array15;
							bool[] array17 = new bool[1] { true };
							object obj24 = NewLateBinding.LateGet(proj12, (Type)null, "f", array46, (string[])null, (Type[])null, array17);
							if (array17[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(int));
							}
							object[] array12 = new object[1] { j };
							object[] array47 = array12;
							bool[] array14 = new bool[1] { true };
							object obj25 = NewLateBinding.LateGet(obj24, (Type)null, "MyObjs", array47, (string[])null, (Type[])null, array14);
							if (array14[0])
							{
								j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(int));
							}
							array4 = new object[2] { k, null };
							object[] array48 = array4;
							object proj13 = peremens2.proj;
							object[] array9 = new object[1] { i };
							object[] array49 = array9;
							bool[] array11 = new bool[1] { true };
							object obj26 = NewLateBinding.LateGet(proj13, (Type)null, "f", array49, (string[])null, (Type[])null, array11);
							if (array11[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(int));
							}
							array6 = new object[1] { j };
							object[] array50 = array6;
							array8 = new bool[1] { true };
							object obj27 = NewLateBinding.LateGet(obj26, (Type)null, "MyObjs", array50, (string[])null, (Type[])null, array8);
							if (array8[0])
							{
								j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
							}
							array = new object[1] { k };
							object[] array51 = array;
							array3 = new bool[1] { true };
							object obj28 = NewLateBinding.LateGet(obj27, (Type)null, "Sobyts", array51, (string[])null, (Type[])null, array3);
							if (array3[0])
							{
								k = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
							}
							array48[1] = sZaglavnoi(trans(Conversions.ToString(obj28)));
							NewLateBinding.LateSetComplex(obj25, (Type)null, "Sobyts", array4, (string[])null, (Type[])null, false, true);
						}
					}
					object proj14 = peremens2.proj;
					array29 = new object[1] { i };
					object[] array52 = array29;
					array31 = new bool[1] { true };
					object obj29 = NewLateBinding.LateGet(proj14, (Type)null, "f", array52, (string[])null, (Type[])null, array31);
					if (array31[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array29[0]), typeof(int));
					}
					array26 = new object[1] { j };
					object[] array53 = array26;
					array28 = new bool[1] { true };
					object obj30 = NewLateBinding.LateGet(obj29, (Type)null, "MyObjs", array53, (string[])null, (Type[])null, array28);
					if (array28[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array26[0]), typeof(int));
					}
					CreatePropertySobytsUp(RuntimeHelpers.GetObjectValue(obj30));
				}
			}
			string[] array54 = new string[5]
			{
				Strings.UCase(trans("Текст")),
				Strings.UCase(trans("Число")),
				Strings.UCase(trans("Рисунок")),
				Strings.UCase(trans("Файл")),
				Strings.UCase(trans("Всплывающее меню"))
			};
			int num6 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2));
			for (int i = 0; i <= num6; i++)
			{
				object proj15 = peremens2.proj;
				object[] array29 = new object[1] { i };
				object[] array55 = array29;
				bool[] array31 = new bool[1] { true };
				object obj31 = NewLateBinding.LateGet(proj15, (Type)null, "f", array55, (string[])null, (Type[])null, array31);
				if (array31[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array29[0]), typeof(int));
				}
				int num7 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj31, (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				for (int j = 0; j <= num7; j++)
				{
					Progress progressForm = peremens2.ProgressForm;
					object obj32 = 10;
					object obj33 = Operators.DivideObject((object)90, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
					object proj16 = peremens2.proj;
					object[] array26 = new object[1] { i };
					object[] array56 = array26;
					bool[] array28 = new bool[1] { true };
					object obj34 = NewLateBinding.LateGet(proj16, (Type)null, "f", array56, (string[])null, (Type[])null, array28);
					if (array28[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array26[0]), typeof(int));
					}
					progressForm.ProgressBarValue = Conversions.ToInteger(Operators.AddObject(Operators.AddObject(obj32, Operators.MultiplyObject(Operators.DivideObject(obj33, NewLateBinding.LateGet(NewLateBinding.LateGet(obj34, (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)j)), Operators.MultiplyObject(Operators.DivideObject((object)90, Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.proj, (Type)null, "f", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)), (object)i)));
					object proj17 = peremens2.proj;
					array29 = new object[1] { i };
					object[] array57 = array29;
					array31 = new bool[1] { true };
					object obj35 = NewLateBinding.LateGet(proj17, (Type)null, "f", array57, (string[])null, (Type[])null, array31);
					if (array31[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array29[0]), typeof(int));
					}
					array26 = new object[1] { j };
					object[] array58 = array26;
					array28 = new bool[1] { true };
					object obj36 = NewLateBinding.LateGet(obj35, (Type)null, "MyObjs", array58, (string[])null, (Type[])null, array28);
					if (array28[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array26[0]), typeof(int));
					}
					if (NewLateBinding.LateGet(obj36, (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
					{
						continue;
					}
					object proj18 = peremens2.proj;
					object[] array23 = new object[1] { i };
					object[] array59 = array23;
					bool[] array25 = new bool[1] { true };
					object obj37 = NewLateBinding.LateGet(proj18, (Type)null, "f", array59, (string[])null, (Type[])null, array25);
					if (array25[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array23[0]), typeof(int));
					}
					object[] array18 = new object[1] { j };
					object[] array60 = array18;
					bool[] array20 = new bool[1] { true };
					object obj38 = NewLateBinding.LateGet(obj37, (Type)null, "MyObjs", array60, (string[])null, (Type[])null, array20);
					if (array20[0])
					{
						j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array18[0]), typeof(int));
					}
					int num8 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj38, (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
					for (int k = 0; k <= num8; k++)
					{
						object proj19 = peremens2.proj;
						object[] array15 = new object[1] { i };
						object[] array61 = array15;
						bool[] array17 = new bool[1] { true };
						object obj39 = NewLateBinding.LateGet(proj19, (Type)null, "f", array61, (string[])null, (Type[])null, array17);
						if (array17[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(int));
						}
						object[] array12 = new object[1] { j };
						object[] array62 = array12;
						bool[] array14 = new bool[1] { true };
						object obj40 = NewLateBinding.LateGet(obj39, (Type)null, "MyObjs", array62, (string[])null, (Type[])null, array14);
						if (array14[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(int));
						}
						object[] array9 = new object[1] { k };
						object[] array63 = array9;
						bool[] array11 = new bool[1] { true };
						object obj41 = NewLateBinding.LateGet(obj40, (Type)null, "Propertys", array63, (string[])null, (Type[])null, array11);
						if (array11[0])
						{
							k = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array9[0]), typeof(int));
						}
						string value = Strings.UCase(Props.GetTypeProperty(Conversions.ToString(obj41)));
						object proj20 = peremens2.proj;
						array29 = new object[1] { i };
						object[] array64 = array29;
						array31 = new bool[1] { true };
						object obj42 = NewLateBinding.LateGet(proj20, (Type)null, "f", array64, (string[])null, (Type[])null, array31);
						if (array31[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array29[0]), typeof(int));
						}
						array26 = new object[1] { j };
						object[] array65 = array26;
						array28 = new bool[1] { true };
						object obj43 = NewLateBinding.LateGet(obj42, (Type)null, "MyObjs", array65, (string[])null, (Type[])null, array28);
						if (array28[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array26[0]), typeof(int));
						}
						array23 = new object[1] { k };
						object[] array66 = array23;
						array25 = new bool[1] { true };
						object obj44 = NewLateBinding.LateGet(obj43, (Type)null, "Propertys", array66, (string[])null, (Type[])null, array25);
						if (array25[0])
						{
							k = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array23[0]), typeof(int));
						}
						string text = Conversions.ToString(obj44);
						object proj21 = peremens2.proj;
						array29 = new object[1] { i };
						object[] array67 = array29;
						array31 = new bool[1] { true };
						object obj45 = NewLateBinding.LateGet(proj21, (Type)null, "f", array67, (string[])null, (Type[])null, array31);
						if (array31[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array29[0]), typeof(int));
						}
						array26 = new object[1] { j };
						object[] array68 = array26;
						array28 = new bool[1] { true };
						object obj46 = NewLateBinding.LateGet(obj45, (Type)null, "MyObjs", array68, (string[])null, (Type[])null, array28);
						if (array28[0])
						{
							j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array26[0]), typeof(int));
						}
						string str = Props.GetProperty(RuntimeHelpers.GetObjectValue(obj46), text).str;
						if (((Array.IndexOf(array54, value) == -1) | (Operators.CompareString(Strings.UCase(trans(str)), Strings.UCase(trans("Никакой")), false) == 0)) & (Array.IndexOf(ReadOnlyProps, Strings.UCase(text)) == -1) & (Array.IndexOf(MayChangeProps, Strings.UCase(text)) == -1))
						{
							object proj22 = peremens2.proj;
							array29 = new object[1] { i };
							object[] array69 = array29;
							array31 = new bool[1] { true };
							object obj47 = NewLateBinding.LateGet(proj22, (Type)null, "f", array69, (string[])null, (Type[])null, array31);
							if (array31[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array29[0]), typeof(int));
							}
							array26 = new object[1] { j };
							object[] array70 = array26;
							array28 = new bool[1] { true };
							object obj48 = NewLateBinding.LateGet(obj47, (Type)null, "MyObjs", array70, (string[])null, (Type[])null, array28);
							if (array28[0])
							{
								j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array26[0]), typeof(int));
							}
							Props.SetProperty(RuntimeHelpers.GetObjectValue(obj48), text, trans(str));
						}
						if ((Operators.CompareString(Strings.UCase(trans(text)), Strings.UCase(trans("Имя")), false) == 0) | (Operators.CompareString(Strings.UCase(trans(text)), Strings.UCase(trans("Всплывающее меню")), false) == 0) | (Operators.CompareString(Strings.UCase(trans(text)), Strings.UCase(trans("Главное меню")), false) == 0))
						{
							object proj23 = peremens2.proj;
							array29 = new object[1] { i };
							object[] array71 = array29;
							array31 = new bool[1] { true };
							object obj49 = NewLateBinding.LateGet(proj23, (Type)null, "f", array71, (string[])null, (Type[])null, array31);
							if (array31[0])
							{
								i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array29[0]), typeof(int));
							}
							array26 = new object[1] { j };
							object[] array72 = array26;
							array28 = new bool[1] { true };
							object obj50 = NewLateBinding.LateGet(obj49, (Type)null, "MyObjs", array72, (string[])null, (Type[])null, array28);
							if (array28[0])
							{
								j = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array26[0]), typeof(int));
							}
							Props.SetProperty(RuntimeHelpers.GetObjectValue(obj50), text, trans(str, toEng: false, fromEng: false, onOld: false, bezCifr: true));
						}
					}
				}
			}
			transTree(Tree.get_Nodes().get_Item(0).get_Parent());
		}
	}

	public static void SetTextNode(TreeNode nod, string str)
	{
		nod.set_Text(str);
	}

	public static void transTree(TreeNode node, reName neTransARename = null)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		object obj = node;
		if (obj == null)
		{
			obj = Tree;
		}
		int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj, (Type)null, "Nodes", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			object obj2 = obj;
			object[] array = new object[1] { i };
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "Nodes", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			string text = transNode((TreeNode)obj3, neTransARename);
			object obj4 = obj;
			object[] array4 = new object[1] { i };
			object[] array5 = array4;
			array3 = new bool[1] { true };
			object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "Nodes", array5, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
			}
			object[] array6;
			bool[] array8;
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(obj5, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)text, false))
			{
				object obj6 = obj;
				array6 = new object[1] { i };
				object[] array7 = array6;
				array8 = new bool[1] { true };
				object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "Nodes", array7, (string[])null, (Type[])null, array8);
				if (array8[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
				}
				NewLateBinding.LateSetComplex(obj7, (Type)null, "Text", new object[1] { text }, (string[])null, (Type[])null, false, true);
			}
			object obj8 = obj;
			array6 = new object[1] { i };
			object[] array9 = array6;
			array8 = new bool[1] { true };
			object obj9 = NewLateBinding.LateGet(obj8, (Type)null, "Nodes", array9, (string[])null, (Type[])null, array8);
			if (array8[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
			}
			transTree((TreeNode)obj9, neTransARename);
		}
	}

	public static string transNode(TreeNode node, reName neTransARename = null)
	{
		string text = Strings.Trim(node.get_Text());
		string text2 = Strings.UCase(text);
		checked
		{
			if (Operators.ConditionalCompareObjectEqual(node.get_Tag(), (object)"If", false))
			{
				if (text2.IndexOf(Strings.UCase(trans("Если", toEng: false, fromEng: false, onOld: true))) == 0)
				{
					text = text.Substring(trans("Если", toEng: false, fromEng: false, onOld: true).Length);
				}
				if (text2.IndexOf(Strings.UCase(trans("Тогда", toEng: false, fromEng: false, onOld: true))) == text2.Length - trans("Тогда", toEng: false, fromEng: false, onOld: true).Length)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Strings.UCase(trans("Если")) + " "), transDeist(Strings.Left(text, text.Length - trans("Тогда", toEng: false, fromEng: false, onOld: true).Length), neTransARename)), (object)" "), (object)Strings.UCase(trans("Тогда"))));
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(node.get_Tag(), (object)"ElseIf", false))
			{
				if (text2.IndexOf(Strings.UCase(trans("ИлиЕсли", toEng: false, fromEng: false, onOld: true))) == 0)
				{
					text = text.Substring(trans("ИлиЕсли", toEng: false, fromEng: false, onOld: true).Length);
				}
				if (text2.IndexOf(Strings.UCase(trans("Тогда", toEng: false, fromEng: false, onOld: true))) == text2.Length - trans("Тогда", toEng: false, fromEng: false, onOld: true).Length)
				{
					text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(Strings.UCase(trans("ИлиЕсли")) + " "), transDeist(Strings.Left(text, text.Length - trans("Тогда", toEng: false, fromEng: false, onOld: true).Length), neTransARename)), (object)" "), (object)Strings.UCase(trans("Тогда"))));
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(node.get_Tag(), (object)"Else", false))
			{
				if (text2.IndexOf(Strings.UCase(trans("В остальных случаях", toEng: false, fromEng: false, onOld: true))) == 0)
				{
					text = trans("В остальных случаях") + text.Substring(trans("В остальных случаях", toEng: false, fromEng: false, onOld: true).Length);
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(node.get_Tag(), (object)"EndIf", false))
			{
				if (text2.IndexOf(Strings.UCase(trans("Конец условия", toEng: false, fromEng: false, onOld: true))) == 0)
				{
					text = trans("Конец условия") + text.Substring(trans("Конец условия", toEng: false, fromEng: false, onOld: true).Length);
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(node.get_Tag(), (object)"While", false))
			{
				if (text2.IndexOf(Strings.UCase(trans("Повторяться пока", toEng: false, fromEng: false, onOld: true))) == 0)
				{
					text = Conversions.ToString(Operators.ConcatenateObject((object)(Strings.UCase(trans("Повторяться пока")) + " "), transDeist(text.Substring(trans("Повторяться пока", toEng: false, fromEng: false, onOld: true).Length), neTransARename)));
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(node.get_Tag(), (object)"EndWhile", false))
			{
				if (text2.IndexOf(Strings.UCase(trans("Конец цикла", toEng: false, fromEng: false, onOld: true))) == 0)
				{
					text = Conversions.ToString(Operators.ConcatenateObject((object)trans("Конец цикла"), transDeist(text.Substring(trans("Конец цикла", toEng: false, fromEng: false, onOld: true).Length), neTransARename)));
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(node.get_Tag(), (object)"Sobyt", false))
			{
				text = sZaglavnoi(trans(node.get_Text()));
			}
			else if (Operators.ConditionalCompareObjectEqual(node.get_Tag(), (object)"Deist", false))
			{
				text = Conversions.ToString(transDeist(node.get_Text(), neTransARename));
			}
			return text;
		}
	}

	public static object transDeist(string txt, reName neTransARename = null)
	{
		string text = "";
		bool flag = false;
		CodeString codeString = new CodeString(txt, "All", withFormating: false);
		MySplitStruct mySplitStruct = codeString.Split("");
		checked
		{
			int num = mySplitStruct.texty.Length - 1;
			int i;
			for (i = 0; i <= num; i++)
			{
				codeString = new CodeString(mySplitStruct.texty[i], "All", withFormating: false);
				MySplitStruct mySplitStruct2 = codeString.Split("naOdnomUrovne", ".");
				if (mySplitStruct2.texty.Length == 3)
				{
					if (Operators.CompareString(trans(mySplitStruct2.texty[1], toEng: false, fromEng: false, onOld: false, bezCifr: true).ToUpper(), MyZnak + trans("Вызвать событие").ToUpper(), false) == 0)
					{
						codeString = new CodeString(mySplitStruct2.texty[2], "All", withFormating: false);
						MySplitStruct mySplitStruct3 = codeString.Split("naOdnomUrovne", "_");
						if (mySplitStruct3.texty.Length == 3)
						{
							if (neTransARename != null)
							{
								if (Operators.CompareString(mySplitStruct3.texty[0], neTransARename.old_frmName, false) == 0)
								{
									mySplitStruct2.texty[2] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(neTransARename.GetNewFormName(mySplitStruct3.texty[0]), (object)mySplitStruct3.splity[0]), neTransARename.GetNewObjName(mySplitStruct3.texty[1])), (object)mySplitStruct3.splity[1]), (object)mySplitStruct3.texty[2]));
								}
							}
							else
							{
								mySplitStruct2.texty[2] = trans(mySplitStruct3.texty[0], toEng: false, fromEng: false, onOld: false, bezCifr: true) + mySplitStruct3.splity[0] + trans(mySplitStruct3.texty[1], toEng: false, fromEng: false, onOld: false, bezCifr: true) + mySplitStruct3.splity[1] + trans(mySplitStruct3.texty[2], toEng: false, fromEng: false, onOld: false, bezCifr: true);
							}
						}
					}
					if (neTransARename != null)
					{
						if ((Operators.CompareString(mySplitStruct2.texty[0], neTransARename.old_frmName, false) == 0) | (Operators.CompareString(mySplitStruct2.texty[0], MyZnak + trans("Полезные объекты"), false) == 0))
						{
							string text2 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(neTransARename.GetNewFormName(mySplitStruct2.texty[0]), (object)mySplitStruct2.splity[0]), neTransARename.GetNewObjName(mySplitStruct2.texty[1])), (object)mySplitStruct2.splity[1]), (object)mySplitStruct2.texty[2]));
							if (Operators.CompareString(mySplitStruct.texty[i], text2, false) != 0)
							{
								mySplitStruct.texty[i] = text2;
								flag = true;
							}
						}
					}
					else
					{
						mySplitStruct.texty[i] = trans(mySplitStruct2.texty[0], toEng: false, fromEng: false, onOld: false, bezCifr: true) + mySplitStruct2.splity[0] + trans(mySplitStruct2.texty[1], toEng: false, fromEng: false, onOld: false, bezCifr: true) + mySplitStruct2.splity[1] + trans(mySplitStruct2.texty[2]);
					}
				}
				else if (mySplitStruct2.texty.Length == 2)
				{
					if (neTransARename != null)
					{
						string text3 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(neTransARename.GetNewFormName(mySplitStruct2.texty[0]), (object)mySplitStruct2.splity[0]), neTransARename.GetNewObjName(mySplitStruct2.texty[1])));
						if (Operators.CompareString(mySplitStruct.texty[i], text3, false) != 0)
						{
							mySplitStruct.texty[i] = text3;
							flag = true;
						}
					}
					else
					{
						mySplitStruct.texty[i] = trans(mySplitStruct2.texty[0], toEng: false, fromEng: false, onOld: false, bezCifr: true) + mySplitStruct2.splity[0] + trans(mySplitStruct2.texty[1], toEng: false, fromEng: false, onOld: false, bezCifr: true);
					}
				}
				else if (neTransARename == null && Operators.CompareString(trans(mySplitStruct.texty[i]).Trim(), mySplitStruct.texty[i].Trim(), false) != 0)
				{
					mySplitStruct.texty[i] = trans(mySplitStruct.texty[i]);
				}
			}
			i = 0;
			if (mySplitStruct.splity != null)
			{
				int num2 = mySplitStruct.splity.Length - 1;
				for (i = 0; i <= num2; i++)
				{
					text = text + mySplitStruct.texty[i] + mySplitStruct.splity[i];
				}
			}
			text += mySplitStruct.texty[i];
		}
		if (neTransARename != null && !flag)
		{
			return txt.Trim();
		}
		return new CodeString(text).Text;
	}

	public static void AssociateMyApp(string sAppName, string sEXE, string sExt, string sIcon = "")
	{
		try
		{
			PropertysOther propertysOther = new PropertysOther(null);
			sEXE += " %1";
			sIcon += ",-1";
			propertysOther.CreateSubKey("HKCU\\Software\\Classes\\" + sExt);
			propertysOther.CreateKey("HKCU\\Software\\Classes\\" + sExt, sAppName, Conversions.ToString(1));
			propertysOther.CreateSubKey("HKCU\\Software\\Classes\\" + sAppName);
			propertysOther.CreateSubKey("HKCU\\Software\\Classes\\" + sAppName + "\\Shell");
			propertysOther.CreateSubKey("HKCU\\Software\\Classes\\" + sAppName + "\\Shell\\Open");
			propertysOther.CreateSubKey("HKCU\\Software\\Classes\\" + sAppName + "\\Shell\\Open\\Command");
			propertysOther.CreateKey("HKCU\\Software\\Classes\\" + sAppName + "\\Shell\\Open\\Command", sEXE, Conversions.ToString(1));
			propertysOther.CreateSubKey("HKCU\\Software\\Classes\\" + sAppName + "\\DefaultIcon");
			propertysOther.CreateKey("HKCU\\Software\\Classes\\" + sAppName + "\\DefaultIcon", sIcon, Conversions.ToString(1));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			associateError = ex2.Message;
			ProjectData.ClearProjectError();
		}
	}

	public static string[] ConvetToStringArray(object[] arr)
	{
		if (arr == null)
		{
			return null;
		}
		checked
		{
			string[] array = new string[arr.Length - 1 + 1];
			int num = arr.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Conversions.ToString(arr[i]);
			}
			return array;
		}
	}

	public static string ToMyDate(DateTime dat)
	{
		return dat.GetDateTimeFormats()[25];
	}

	public static DateTime FromMyDate(string dat)
	{
		if (Versioned.IsNumeric((object)dat))
		{
			return DateTime.FromBinary(Conversions.ToLong(dat));
		}
		if (DateTime.TryParse(dat, null, DateTimeStyles.None, out var result))
		{
			return result;
		}
		return DateTime.MinValue;
	}

	public static FirstDayOfWeek getFirstDayOfWeek()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(lang_name, "Russian", false) == 0)
		{
			return (FirstDayOfWeek)2;
		}
		return (FirstDayOfWeek)1;
	}

	public static string ToMyTimeSpan(int tim)
	{
		string text = TimeSpan.FromMilliseconds(tim).ToString();
		if (text.IndexOf(".") == -1)
		{
			return text + ".00";
		}
		checked
		{
			if (text.IndexOf(".") + 3 <= text.Length - 1)
			{
				return text.Substring(0, text.IndexOf(".") + 3);
			}
			return text.PadRight(text.IndexOf(".") + 3, '0');
		}
	}

	public static TimeSpan FromMyTimeSpan(string tim)
	{
		if (Operators.CompareString(tim, "", false) == 0)
		{
			tim = Conversions.ToString(0);
		}
		if (Versioned.IsNumeric((object)tim))
		{
			return TimeSpan.FromMilliseconds(Conversions.ToDouble(tim));
		}
		if (TimeSpan.TryParse(tim, out var result))
		{
			return result;
		}
		return TimeSpan.MaxValue;
	}

	public static bool ReExist(Array arr, object val)
	{
		if (arr == null)
		{
			return false;
		}
		return Array.IndexOf(arr, RuntimeHelpers.GetObjectValue(val)) != -1;
	}

	public static bool TextBoxAllow(object sender, KeyPressEventArgs e)
	{
		if (Iz.IsTbx(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(sender, (Type)null, "MyObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			if (char.IsControl(e.get_KeyChar()))
			{
				return false;
			}
			Type typeFromHandle = typeof(Strings);
			object[] array = new object[1];
			object[] array2 = array;
			object obj = sender;
			object obj2 = obj;
			object[] array3 = new object[0];
			object[] array4 = array3;
			string[] array5 = null;
			array2[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "props", array4, array5, (Type[])null, (bool[])null), (Type)null, "AllowInput", new object[0], (string[])null, (Type[])null, (bool[])null));
			object[] array6 = array;
			object[] array7 = array6;
			bool[] array8 = new bool[1] { true };
			object obj3 = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array7, (string[])null, (Type[])null, array8);
			if (array8[0])
			{
				NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "props", array3, array5, (Type[])null, (bool[])null), (Type)null, "AllowInput", new object[1] { RuntimeHelpers.GetObjectValue(array6[0]) }, (string[])null, (Type[])null, true, true);
			}
			if (Operators.ConditionalCompareObjectEqual(obj3, (object)Strings.UCase(trans("Только цифры")), false))
			{
				if (!char.IsDigit(e.get_KeyChar()))
				{
					return true;
				}
			}
			else
			{
				Type typeFromHandle2 = typeof(Strings);
				array6 = new object[1];
				object[] array9 = array6;
				obj = sender;
				object obj4 = obj;
				object[] array10 = new object[0];
				object[] array11 = array10;
				array5 = null;
				array9[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "props", array11, array5, (Type[])null, (bool[])null), (Type)null, "AllowInput", new object[0], (string[])null, (Type[])null, (bool[])null));
				array = array6;
				object[] array12 = array;
				array8 = new bool[1] { true };
				object obj5 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array12, (string[])null, (Type[])null, array8);
				if (array8[0])
				{
					NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "props", array10, array5, (Type[])null, (bool[])null), (Type)null, "AllowInput", new object[1] { RuntimeHelpers.GetObjectValue(array[0]) }, (string[])null, (Type[])null, true, true);
				}
				if (Operators.ConditionalCompareObjectEqual(obj5, (object)Strings.UCase(trans("Только буквы")), false))
				{
					if ((char.GetUnicodeCategory(e.get_KeyChar()) != UnicodeCategory.UppercaseLetter) & (char.GetUnicodeCategory(e.get_KeyChar()) != UnicodeCategory.LowercaseLetter))
					{
						return true;
					}
				}
				else
				{
					Type typeFromHandle3 = typeof(Strings);
					array6 = new object[1];
					object[] array13 = array6;
					obj = sender;
					object obj6 = obj;
					array10 = new object[0];
					object[] array14 = array10;
					array5 = null;
					array13[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj6, (Type)null, "props", array14, array5, (Type[])null, (bool[])null), (Type)null, "AllowInput", new object[0], (string[])null, (Type[])null, (bool[])null));
					array = array6;
					object[] array15 = array;
					array8 = new bool[1] { true };
					object obj7 = NewLateBinding.LateGet((object)null, typeFromHandle3, "UCase", array15, (string[])null, (Type[])null, array8);
					if (array8[0])
					{
						NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "props", array10, array5, (Type[])null, (bool[])null), (Type)null, "AllowInput", new object[1] { RuntimeHelpers.GetObjectValue(array[0]) }, (string[])null, (Type[])null, true, true);
					}
					if (Operators.ConditionalCompareObjectEqual(obj7, (object)Strings.UCase(trans("Только буквы и цифры")), false))
					{
						if ((char.GetUnicodeCategory(e.get_KeyChar()) != UnicodeCategory.DecimalDigitNumber) & (char.GetUnicodeCategory(e.get_KeyChar()) != UnicodeCategory.UppercaseLetter) & (char.GetUnicodeCategory(e.get_KeyChar()) != UnicodeCategory.LowercaseLetter))
						{
							return true;
						}
					}
					else
					{
						Type typeFromHandle4 = typeof(Strings);
						array6 = new object[1];
						object[] array16 = array6;
						obj = sender;
						object obj8 = obj;
						array10 = new object[0];
						object[] array17 = array10;
						array5 = null;
						array16[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj8, (Type)null, "props", array17, array5, (Type[])null, (bool[])null), (Type)null, "AllowInput", new object[0], (string[])null, (Type[])null, (bool[])null));
						array = array6;
						object[] array18 = array;
						array8 = new bool[1] { true };
						object obj9 = NewLateBinding.LateGet((object)null, typeFromHandle4, "UCase", array18, (string[])null, (Type[])null, array8);
						if (array8[0])
						{
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "props", array10, array5, (Type[])null, (bool[])null), (Type)null, "AllowInput", new object[1] { RuntimeHelpers.GetObjectValue(array[0]) }, (string[])null, (Type[])null, true, true);
						}
						if (Operators.ConditionalCompareObjectEqual(obj9, (object)Strings.UCase(trans("Только латинские буквы")), false))
						{
							if (!char.IsLetter(e.get_KeyChar()))
							{
								return true;
							}
						}
						else
						{
							Type typeFromHandle5 = typeof(Strings);
							array6 = new object[1];
							object[] array19 = array6;
							obj = sender;
							object obj10 = obj;
							array10 = new object[0];
							object[] array20 = array10;
							array5 = null;
							array19[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj10, (Type)null, "props", array20, array5, (Type[])null, (bool[])null), (Type)null, "AllowInput", new object[0], (string[])null, (Type[])null, (bool[])null));
							array = array6;
							object[] array21 = array;
							array8 = new bool[1] { true };
							object obj11 = NewLateBinding.LateGet((object)null, typeFromHandle5, "UCase", array21, (string[])null, (Type[])null, array8);
							if (array8[0])
							{
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(obj, (Type)null, "props", array10, array5, (Type[])null, (bool[])null), (Type)null, "AllowInput", new object[1] { RuntimeHelpers.GetObjectValue(array[0]) }, (string[])null, (Type[])null, true, true);
							}
							if (Operators.ConditionalCompareObjectEqual(obj11, (object)Strings.UCase(trans("Только латинские буквы и цифры")), false) && !char.IsLetterOrDigit(e.get_KeyChar()))
							{
								return true;
							}
						}
					}
				}
			}
		}
		return false;
	}

	public static string GetUIN()
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		Monitor.Enter(_0024STATIC_0024GetUIN_002400E_0024rnd_0024Init);
		try
		{
			if (_0024STATIC_0024GetUIN_002400E_0024rnd_0024Init.State == 0)
			{
				_0024STATIC_0024GetUIN_002400E_0024rnd_0024Init.State = 2;
				_0024STATIC_0024GetUIN_002400E_0024rnd = new Random();
			}
			else if (_0024STATIC_0024GetUIN_002400E_0024rnd_0024Init.State == 2)
			{
				throw new IncompleteInitialization();
			}
		}
		finally
		{
			_0024STATIC_0024GetUIN_002400E_0024rnd_0024Init.State = 1;
			Monitor.Exit(_0024STATIC_0024GetUIN_002400E_0024rnd_0024Init);
		}
		string text = "";
		int num = 0;
		checked
		{
			do
			{
				int num2 = _0024STATIC_0024GetUIN_002400E_0024rnd.Next(1, 50);
				if (num2 > 25)
				{
					num2 += 7;
				}
				text += Conversions.ToString(Strings.Chr(64 + num2));
				num++;
			}
			while (num <= 9);
			return text;
		}
	}

	public static void ProgressFormShow(string txt, int val = 0)
	{
		((Form)peremens2.ProgressForm).set_TopMost(true);
		peremens2.ProgressForm.ProgressBarValue = val;
		peremens2.ProgressForm.Label1.set_Text(txt);
		((Form)peremens2.ProgressForm).set_TopMost(true);
		((Control)peremens2.ProgressForm).Show();
		((Control)peremens2.ProgressForm).Refresh();
	}

	public static ErrString UbratKovich(string str)
	{
		ErrString result = new ErrString(str);
		if (Operators.CompareString(result.str, "", false) == 0)
		{
			return result;
		}
		checked
		{
			if ((Operators.CompareString(Conversions.ToString(result.str[0]), "\"", false) == 0) & (Operators.CompareString(Conversions.ToString(result.str[result.str.Length - 1]), "\"", false) == 0))
			{
				CodeString codeString = new CodeString(str, "None", withFormating: false);
				if (result.str.Length > 1)
				{
					if (codeString.PropuskKovich(0) != result.str.Length - 1)
					{
						return result;
					}
					result.str = result.str.Substring(1, result.str.Length - 2);
				}
				else if (Operators.CompareString(result.str, "\"", false) == 0)
				{
					result.err = Errors.InvalidKovich();
					return result;
				}
				result.str = result.str.Replace("\"\"", "\"");
			}
			return result;
		}
	}

	public static string CreateKovich(string str)
	{
		if (str == null)
		{
			return str;
		}
		str = str.Replace("\"", "\"\"").Replace(char.ConvertFromUtf32(8220), "\"\"").Replace(char.ConvertFromUtf32(8221), "\"\"");
		return str;
	}

	public static string NikakoiEsli(string str)
	{
		if ((Operators.CompareString(str, "", false) == 0) | (Operators.CompareString(Strings.UCase(str), Strings.UCase(trans("Никакой")), false) == 0))
		{
			return trans("Никакой");
		}
		return str;
	}

	public static string NetTakNet(string str)
	{
		if ((Operators.CompareString(str, "", false) == 0) | (Operators.CompareString(Strings.UCase(str), Strings.UCase(trans("Нет")), false) == 0) | (Operators.CompareString(str, "0", false) == 0))
		{
			return trans("Нет");
		}
		if ((Operators.CompareString(Strings.UCase(str), Strings.UCase(trans("Да")), false) == 0) | (Operators.CompareString(str, "1", false) == 0))
		{
			return trans("Да");
		}
		return trans("Никакой");
	}

	public static bool returnBoolean(string str)
	{
		if ((Operators.CompareString(str, "True", false) == 0) | (Operators.CompareString(str, "False", false) == 0))
		{
			return Conversions.ToBoolean(str);
		}
		if (Operators.CompareString(Strings.UCase(str), Strings.UCase(trans("Да")), false) == 0)
		{
			return true;
		}
		if (Operators.CompareString(Strings.UCase(str), Strings.UCase(trans("Нет")), false) == 0)
		{
			return false;
		}
		bool result = default(bool);
		return result;
	}

	public static ErrString FileExistInArgs(string value, ErrString es)
	{
		string[] args = new string[1] { value };
		return FileExistInArgs(args, 0, es);
	}

	public static ErrString FileExistInArgs(string[] args, int index, ErrString es)
	{
		if (args != null)
		{
			if (args.Length > index)
			{
				string str = UbratKovich(GetMaxPath(args[index])).str;
				if (Operators.CompareString(NikakoiEsli(str), trans("Никакой"), false) == 0)
				{
					return es;
				}
				if (!File.Exists(str) & !Directory.Exists(str))
				{
					es.err = Errors.FilePathNotExist(args[index]);
					return es;
				}
				return es;
			}
			es.err = Errors.FilePathNotExist(args[index]);
			return es;
		}
		es.err = Errors.noArguments("");
		return es;
	}

	public static string NullTakNull(string str)
	{
		if ((Operators.CompareString(str, "", false) == 0) | (Operators.CompareString(str, trans("Никакой"), false) == 0))
		{
			str = "0";
		}
		return str;
	}

	public static string DaOrNet(bool @bool)
	{
		if (@bool)
		{
			return trans("Да");
		}
		return trans("Нет");
	}

	public static bool DaOrNet(string @bool)
	{
		if (Operators.CompareString(@bool, trans("Да"), false) == 0)
		{
			return true;
		}
		return false;
	}

	public static string YesOrNo(bool @bool)
	{
		if (@bool)
		{
			return "Yes";
		}
		return "No";
	}

	public static bool YesOrNo(string @bool)
	{
		if (Operators.CompareString(@bool, "Yes", false) == 0)
		{
			return true;
		}
		return false;
	}

	public static void transMenu(object menu, bool dontRecurs = false)
	{
		int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(menu, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			object[] array = new object[1] { i };
			bool[] array2 = new bool[1] { true };
			object obj = NewLateBinding.LateGet(menu, (Type)null, "Items", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(obj, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false))
			{
				object[] array3 = new object[1] { i };
				bool[] array4 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(menu, (Type)null, "Items", array3, (string[])null, (Type[])null, array4);
				if (array4[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
				}
				object mItem = RuntimeHelpers.GetObjectValue(obj2);
				transMenuRecurs(ref mItem, transInfsOrNot: true, dontRecurs);
				NewLateBinding.LateSetComplex(menu, (Type)null, "Items", new object[2]
				{
					i,
					RuntimeHelpers.GetObjectValue(mItem)
				}, (string[])null, (Type[])null, true, false);
			}
		}
	}

	public static void transMenuRecurs(ref object mItem, bool transInfsOrNot = true, bool dontRecurs = false)
	{
		string value = Regex.Match(Conversions.ToString(NewLateBinding.LateGet(mItem, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)), "[^0-9]*").Value;
		NewLateBinding.LateSet(mItem, (Type)null, "Image", new object[1] { Pictures32.get_Images().get_Item(value) }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(mItem, (Type)null, "ImageTransparentColor", new object[1] { Color.Black }, (string[])null, (Type[])null);
		if (transInfsOrNot)
		{
			NewLateBinding.LateSet(mItem, (Type)null, "ToolTipText", new object[1] { transInfc(Conversions.ToString(NewLateBinding.LateGet(mItem, (Type)null, "ToolTipText", new object[0], (string[])null, (Type[])null, (bool[])null))) }, (string[])null, (Type[])null);
		}
		else
		{
			NewLateBinding.LateSet(mItem, (Type)null, "ToolTipText", new object[1] { trans(Conversions.ToString(NewLateBinding.LateGet(mItem, (Type)null, "ToolTipText", new object[0], (string[])null, (Type[])null, (bool[])null))) }, (string[])null, (Type[])null);
		}
		if (transInfsOrNot)
		{
			NewLateBinding.LateSet(mItem, (Type)null, "Text", new object[1] { transInfc(Conversions.ToString(NewLateBinding.LateGet(mItem, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))) }, (string[])null, (Type[])null);
		}
		else
		{
			NewLateBinding.LateSet(mItem, (Type)null, "Text", new object[1] { trans(Conversions.ToString(NewLateBinding.LateGet(mItem, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))) }, (string[])null, (Type[])null);
		}
		if (NewLateBinding.LateGet(mItem, (Type)null, "owner", new object[0], (string[])null, (Type[])null, (bool[])null) == NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "MenuStrip1", new object[0], (string[])null, (Type[])null, (bool[])null))
		{
			NewLateBinding.LateSet(mItem, (Type)null, "foreColor", new object[1] { RuntimeHelpers.GetObjectValue(SkinColors["MenuColor"]) }, (string[])null, (Type[])null);
		}
		if (!Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(NewLateBinding.LateGet(mItem, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"", false), (object)(!dontRecurs))))
		{
			return;
		}
		int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(mItem, (Type)null, "DropDownItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			object obj = mItem;
			object[] array = new object[1] { i };
			bool[] array2 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "DropDownItems", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			object mItem2 = RuntimeHelpers.GetObjectValue(obj2);
			transMenuRecurs(ref mItem2, transInfsOrNot);
			NewLateBinding.LateSetComplex(obj, (Type)null, "DropDownItems", new object[2]
			{
				i,
				RuntimeHelpers.GetObjectValue(mItem2)
			}, (string[])null, (Type[])null, true, false);
		}
	}

	public static void transPanel(object panel)
	{
		int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(panel, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		int num3 = default(int);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			object[] array = new object[1] { i };
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj = NewLateBinding.LateGet(panel, (Type)null, "Items", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			string text = Regex.Match(Conversions.ToString(NewLateBinding.LateGet(obj, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)), "[^0-9]*").Value;
			object[] array11;
			object[] array6;
			bool[] array13;
			bool[] array8;
			if (text.IndexOf("Panel") >= 2)
			{
				text = text.Replace("Panel", "Menu");
			}
			else
			{
				object[] array4 = new object[1] { i };
				object[] array5 = array4;
				array3 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(panel, (Type)null, "Items", array5, (string[])null, (Type[])null, array3);
				if (array3[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(int));
				}
				if (NewLateBinding.LateGet(obj2, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
				{
					array6 = new object[1] { i };
					object[] array7 = array6;
					array8 = new bool[1] { true };
					object obj3 = NewLateBinding.LateGet(panel, (Type)null, "Items", array7, (string[])null, (Type[])null, array8);
					if (array8[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
					}
					object[] array9 = new object[1];
					object[] array10 = array9;
					SortedList infoObjs = InfoObjs;
					array11 = new object[1] { i };
					object[] array12 = array11;
					array13 = new bool[1] { true };
					object obj4 = NewLateBinding.LateGet(panel, (Type)null, "Items", array12, (string[])null, (Type[])null, array13);
					if (array13[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(int));
					}
					array10[0] = RuntimeHelpers.GetObjectValue(infoObjs[RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj4, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null))]);
					NewLateBinding.LateSetComplex(obj3, (Type)null, "ToolTipText", array9, (string[])null, (Type[])null, false, true);
				}
			}
			array11 = new object[1] { i };
			object[] array14 = array11;
			array13 = new bool[1] { true };
			object obj5 = NewLateBinding.LateGet(panel, (Type)null, "Items", array14, (string[])null, (Type[])null, array13);
			if (array13[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(int));
			}
			NewLateBinding.LateSetComplex(obj5, (Type)null, "Image", new object[1] { Pictures32.get_Images().get_Item(text) }, (string[])null, (Type[])null, false, true);
			array11 = new object[1] { i };
			object[] array15 = array11;
			array13 = new bool[1] { true };
			object obj6 = NewLateBinding.LateGet(panel, (Type)null, "Items", array15, (string[])null, (Type[])null, array13);
			if (array13[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(int));
			}
			NewLateBinding.LateSetComplex(obj6, (Type)null, "ImageTransparentColor", new object[1] { Color.Fuchsia }, (string[])null, (Type[])null, false, true);
			array11 = new object[1] { i };
			object[] array16 = array11;
			array13 = new bool[1] { true };
			object obj7 = NewLateBinding.LateGet(panel, (Type)null, "Items", array16, (string[])null, (Type[])null, array13);
			if (array13[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(int));
			}
			object[] array17 = new object[1];
			object[] array18 = array17;
			array6 = new object[1] { i };
			object[] array19 = array6;
			array8 = new bool[1] { true };
			object obj8 = NewLateBinding.LateGet(panel, (Type)null, "Items", array19, (string[])null, (Type[])null, array8);
			if (array8[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
			}
			array18[0] = transInfc(Conversions.ToString(NewLateBinding.LateGet(obj8, (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
			NewLateBinding.LateSetComplex(obj7, (Type)null, "Text", array17, (string[])null, (Type[])null, false, true);
			array11 = new object[1] { i };
			object[] array20 = array11;
			array13 = new bool[1] { true };
			object obj9 = NewLateBinding.LateGet(panel, (Type)null, "Items", array20, (string[])null, (Type[])null, array13);
			if (array13[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(int));
			}
			NewLateBinding.LateSetComplex(obj9, (Type)null, "foreColor", new object[1] { RuntimeHelpers.GetObjectValue(SkinColors["MenuColor"]) }, (string[])null, (Type[])null, false, true);
			array11 = new object[1] { i };
			object[] array21 = array11;
			array13 = new bool[1] { true };
			object obj10 = NewLateBinding.LateGet(panel, (Type)null, "Items", array21, (string[])null, (Type[])null, array13);
			if (array13[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(int));
			}
			array17 = new object[1];
			object[] array22 = array17;
			array6 = new object[1] { i };
			object[] array23 = array6;
			array8 = new bool[1] { true };
			object obj11 = NewLateBinding.LateGet(panel, (Type)null, "Items", array23, (string[])null, (Type[])null, array8);
			if (array8[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
			}
			array22[0] = transInfc(Conversions.ToString(NewLateBinding.LateGet(obj11, (Type)null, "ToolTipText", new object[0], (string[])null, (Type[])null, (bool[])null)));
			NewLateBinding.LateSetComplex(obj10, (Type)null, "ToolTipText", array17, (string[])null, (Type[])null, false, true);
			SortedList infoObjs2 = InfoObjs;
			array11 = new object[1] { i };
			object[] array24 = array11;
			array13 = new bool[1] { true };
			object obj12 = NewLateBinding.LateGet(panel, (Type)null, "Items", array24, (string[])null, (Type[])null, array13);
			if (array13[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(int));
			}
			bool[] array30;
			if (infoObjs2[RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj12, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))] != null)
			{
				array6 = new object[1] { i };
				object[] array25 = array6;
				string[] array26 = null;
				array8 = new bool[1] { true };
				object obj13 = NewLateBinding.LateGet(panel, (Type)null, "Items", array25, array26, (Type[])null, array8);
				array3 = array8;
				bool[] array27 = array3;
				int num2 = 0;
				if (array27[0])
				{
					num3 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
					i = num3;
				}
				object[] array4 = new object[1];
				object[] array28 = array4;
				object obj14 = NewLateBinding.LateGet(panel, (Type)null, "Items", array6, array26, (Type[])null, new bool[1] { true });
				if (array3[num2])
				{
					i = num3;
				}
				object obj15 = NewLateBinding.LateGet(obj14, (Type)null, "ToolTipText", new object[0], (string[])null, (Type[])null, (bool[])null);
				SortedList infoObjs3 = InfoObjs;
				array = new object[1] { i };
				object[] array29 = array;
				array30 = new bool[1] { true };
				object obj16 = NewLateBinding.LateGet(panel, (Type)null, "Items", array29, (string[])null, (Type[])null, array30);
				if (array30[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				array28[0] = Operators.ConcatenateObject(obj15, Operators.ConcatenateObject((object)". ", infoObjs3[RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj16, (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null))]));
				NewLateBinding.LateSetComplex(obj13, (Type)null, "ToolTipText", array4, (string[])null, (Type[])null, false, true);
			}
			array11 = new object[1] { i };
			object[] array31 = array11;
			array30 = new bool[1] { true };
			object obj17 = NewLateBinding.LateGet(panel, (Type)null, "Items", array31, (string[])null, (Type[])null, array30);
			if (array30[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array11[0]), typeof(int));
			}
			if (Operators.CompareString(obj17.GetType().ToString(), "System.Windows.Forms.ToolStripSplitButton", false) != 0)
			{
				continue;
			}
			array6 = new object[1] { i };
			object[] array32 = array6;
			array13 = new bool[1] { true };
			object obj18 = NewLateBinding.LateGet(panel, (Type)null, "Items", array32, (string[])null, (Type[])null, array13);
			if (array13[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(int));
			}
			if (Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(obj18, (Type)null, "DropDownItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))
			{
				array = new object[1] { i };
				object[] array33 = array;
				array8 = new bool[1] { true };
				object obj19 = NewLateBinding.LateGet(panel, (Type)null, "Items", array33, (string[])null, (Type[])null, array8);
				if (array8[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				transMenu(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(obj19, (Type)null, "DropDown", new object[0], (string[])null, (Type[])null, (bool[])null)));
			}
		}
	}

	public static string[] transArray(string[] ozhidaem, bool FromEng = false)
	{
		checked
		{
			int num = ozhidaem.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				ozhidaem[i] = trans(ozhidaem[i], toEng: false, FromEng);
			}
			return ozhidaem;
		}
	}

	public static void backgroundPanel(object panel)
	{
		int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(panel, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			object[] array = new object[1] { i };
			bool[] array2 = new bool[1] { true };
			object obj = NewLateBinding.LateGet(panel, (Type)null, "Items", array, (string[])null, (Type[])null, array2);
			if (array2[0])
			{
				i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj, (Type)null, "IsOnOverflow", new object[0], (string[])null, (Type[])null, (bool[])null), (object)true, false))
			{
				object[] array3 = new object[1] { i };
				object[] array4 = array3;
				bool[] array5 = new bool[1] { true };
				object obj2 = NewLateBinding.LateGet(panel, (Type)null, "Items", array4, (string[])null, (Type[])null, array5);
				if (array5[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
				}
				NewLateBinding.LateSetComplex(obj2, (Type)null, "BackgroundImage", new object[1] { RuntimeHelpers.GetObjectValue(SkinPictures["Menu"]) }, (string[])null, (Type[])null, false, true);
			}
			else
			{
				object[] array3 = new object[1] { i };
				object[] array6 = array3;
				bool[] array5 = new bool[1] { true };
				object obj3 = NewLateBinding.LateGet(panel, (Type)null, "Items", array6, (string[])null, (Type[])null, array5);
				if (array5[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
				}
				NewLateBinding.LateSetComplex(obj3, (Type)null, "BackgroundImage", new object[1] { null }, (string[])null, (Type[])null, false, true);
			}
		}
	}

	public static void sortPanel(object panel)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		checked
		{
			ToolStripItem[] array = (ToolStripItem[])(object)new ToolStripItem[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(panel, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(panel, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			bool[] array5;
			for (int i = 0; i <= num; i++)
			{
				ToolStripItem[] array2 = array;
				int num2 = i;
				object[] array3 = new object[1] { i };
				object[] array4 = array3;
				array5 = new bool[1] { true };
				object obj = NewLateBinding.LateGet(panel, (Type)null, "Items", array4, (string[])null, (Type[])null, array5);
				if (array5[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
				}
				array2[num2] = (ToolStripItem)obj;
			}
			NewLateBinding.LateCall(NewLateBinding.LateGet(panel, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Array.Sort(array, new SortByText());
			object obj2 = NewLateBinding.LateGet(panel, (Type)null, "Items", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array6 = new object[1] { array };
			object[] array7 = array6;
			array5 = new bool[1] { true };
			NewLateBinding.LateCall(obj2, (Type)null, "AddRange", array7, (string[])null, (Type[])null, array5, true);
			if (array5[0])
			{
				array = (ToolStripItem[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(ToolStripItem[]));
			}
		}
	}

	public static void sortMenu(object mItem)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		checked
		{
			ToolStripItem[] array = (ToolStripItem[])(object)new ToolStripItem[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(mItem, (Type)null, "DropDownItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
			int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(mItem, (Type)null, "DropDownItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			bool[] array5;
			for (int i = 0; i <= num; i++)
			{
				ToolStripItem[] array2 = array;
				int num2 = i;
				object[] array3 = new object[1] { i };
				object[] array4 = array3;
				array5 = new bool[1] { true };
				object obj = NewLateBinding.LateGet(mItem, (Type)null, "DropDownItems", array4, (string[])null, (Type[])null, array5);
				if (array5[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
				}
				array2[num2] = (ToolStripItem)obj;
			}
			NewLateBinding.LateCall(NewLateBinding.LateGet(mItem, (Type)null, "DropDownItems", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Clear", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			Array.Sort(array, new SortByTextMenu());
			object obj2 = NewLateBinding.LateGet(mItem, (Type)null, "DropDownItems", new object[0], (string[])null, (Type[])null, (bool[])null);
			object[] array6 = new object[1] { array };
			object[] array7 = array6;
			array5 = new bool[1] { true };
			NewLateBinding.LateCall(obj2, (Type)null, "AddRange", array7, (string[])null, (Type[])null, array5, true);
			if (array5[0])
			{
				array = (ToolStripItem[])Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(ToolStripItem[]));
			}
		}
	}

	public static string perevesti(string chto, bool SdelatEnterOrSpecsimvol)
	{
		if (chto == null)
		{
			return "";
		}
		if (SdelatEnterOrSpecsimvol)
		{
			return chto.Replace(Conversions.ToString(Strings.Chr(182)), "\r\n").Replace(Strings.Chr(183), '\n');
		}
		return chto.Replace("\r\n", Conversions.ToString(Strings.Chr(182))).Replace('\n', Strings.Chr(183));
	}

	public static string perevesti(string chto, string SdelatVmestoEnter)
	{
		if (chto == null)
		{
			return chto;
		}
		return chto.Replace(Conversions.ToString(Strings.Chr(182)), SdelatVmestoEnter).Replace(Strings.Chr(183), '\n');
	}

	public static void perevesti(ref RichTextBox chto, ref RichTextBox kuda, string[] chtoZamen, string naChtoZamen)
	{
		if ((kuda == null) | (chto == null))
		{
			return;
		}
		if (!tempRich.get_Multiline())
		{
			tempRich.set_Multiline(true);
		}
		tempRich.set_Rtf(chto.get_Rtf());
		checked
		{
			int num = chtoZamen.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				while (true)
				{
					int num2 = tempRich.get_Text().IndexOf(chtoZamen[i]);
					if (num2 == -1)
					{
						break;
					}
					((TextBoxBase)tempRich).set_SelectionStart(num2);
					tempRich.set_SelectionLength(chtoZamen[i].Length);
					tempRich.set_SelectedText(naChtoZamen);
				}
			}
			kuda.set_Rtf(tempRich.get_Rtf());
		}
	}

	public static void CreatePropertySobytsUp(object MyObj)
	{
		if (MyObj == null)
		{
			return;
		}
		int num = 0;
		if (NewLateBinding.LateGet(MyObj, (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
		{
			num = Array.IndexOf((Array)NewLateBinding.LateGet(MyObj, (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null), trans("Имя"));
		}
		if (peremens2.MnFrm != null)
		{
			num = 0;
		}
		if (num == -1)
		{
			num = 0;
		}
		if (NewLateBinding.LateGet(MyObj, (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
		{
			Array.Sort((Array)NewLateBinding.LateGet(MyObj, (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null), num, Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)num)));
		}
		if (NewLateBinding.LateGet(MyObj, (Type)null, "Methods", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
		{
			Array.Sort((Array)NewLateBinding.LateGet(MyObj, (Type)null, "Methods", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		if (NewLateBinding.LateGet(MyObj, (Type)null, "Sobyts", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
		{
			Array.Sort((Array)NewLateBinding.LateGet(MyObj, (Type)null, "Sobyts", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		checked
		{
			string[] array;
			if (NewLateBinding.LateGet(MyObj, (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
			{
				array = new string[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
				int num2 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "Propertys", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
				for (int i = 0; i <= num2; i++)
				{
					string[] array2 = array;
					int num3 = i;
					Type typeFromHandle = typeof(Strings);
					object[] array3 = new object[1];
					object[] array4 = array3;
					object obj = MyObj;
					object obj2 = obj;
					object[] array5 = new object[1] { i };
					object[] array6 = array5;
					bool[] array7 = new bool[1] { true };
					object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "Propertys", array6, (string[])null, (Type[])null, array7);
					if (array7[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(int));
					}
					array4[0] = RuntimeHelpers.GetObjectValue(obj3);
					object[] array8 = array3;
					object[] array9 = array8;
					bool[] array10 = new bool[1] { true };
					object obj4 = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array9, (string[])null, (Type[])null, array10);
					if (array10[0])
					{
						NewLateBinding.LateSetComplex(obj, (Type)null, "Propertys", new object[2]
						{
							i,
							RuntimeHelpers.GetObjectValue(array8[0])
						}, (string[])null, (Type[])null, true, false);
					}
					array2[num3] = Conversions.ToString(obj4);
				}
				NewLateBinding.LateSet(MyObj, (Type)null, "PropertysUp", new object[1] { array }, (string[])null, (Type[])null);
			}
			try
			{
				if (NewLateBinding.LateGet(MyObj, (Type)null, "Methods", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
				{
					array = new string[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "Methods", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
					int num4 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "Methods", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
					for (int i = 0; i <= num4; i++)
					{
						string[] array11 = array;
						int num5 = i;
						Type typeFromHandle2 = typeof(Strings);
						object[] array3 = new object[1];
						object[] array12 = array3;
						object obj = MyObj;
						object obj5 = obj;
						object[] array8 = new object[1] { i };
						object[] array13 = array8;
						bool[] array10 = new bool[1] { true };
						object obj6 = NewLateBinding.LateGet(obj5, (Type)null, "Methods", array13, (string[])null, (Type[])null, array10);
						if (array10[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
						}
						array12[0] = RuntimeHelpers.GetObjectValue(obj6);
						object[] array5 = array3;
						object[] array14 = array5;
						bool[] array7 = new bool[1] { true };
						object obj7 = NewLateBinding.LateGet((object)null, typeFromHandle2, "UCase", array14, (string[])null, (Type[])null, array7);
						if (array7[0])
						{
							NewLateBinding.LateSetComplex(obj, (Type)null, "Methods", new object[2]
							{
								i,
								RuntimeHelpers.GetObjectValue(array5[0])
							}, (string[])null, (Type[])null, true, false);
						}
						array11[num5] = Conversions.ToString(obj7);
					}
					NewLateBinding.LateSet(MyObj, (Type)null, "MethodsUp", new object[1] { array }, (string[])null, (Type[])null);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			if (NewLateBinding.LateGet(MyObj, (Type)null, "Sobyts", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
			{
				return;
			}
			array = new string[Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "Sobyts", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1)) + 1];
			int num6 = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "Sobyts", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
			for (int i = 0; i <= num6; i++)
			{
				string[] array15 = array;
				int num7 = i;
				Type typeFromHandle3 = typeof(Strings);
				object[] array3 = new object[1];
				object[] array16 = array3;
				object obj = MyObj;
				object obj8 = obj;
				object[] array8 = new object[1] { i };
				object[] array17 = array8;
				bool[] array10 = new bool[1] { true };
				object obj9 = NewLateBinding.LateGet(obj8, (Type)null, "Sobyts", array17, (string[])null, (Type[])null, array10);
				if (array10[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
				}
				array16[0] = RuntimeHelpers.GetObjectValue(obj9);
				object[] array5 = array3;
				object[] array18 = array5;
				bool[] array7 = new bool[1] { true };
				object obj10 = NewLateBinding.LateGet((object)null, typeFromHandle3, "UCase", array18, (string[])null, (Type[])null, array7);
				if (array7[0])
				{
					NewLateBinding.LateSetComplex(obj, (Type)null, "Sobyts", new object[2]
					{
						i,
						RuntimeHelpers.GetObjectValue(array5[0])
					}, (string[])null, (Type[])null, true, false);
				}
				array15[num7] = Conversions.ToString(obj10);
			}
			NewLateBinding.LateSet(MyObj, (Type)null, "SobytsUp", new object[1] { array }, (string[])null, (Type[])null);
		}
	}

	public static void ComboBoxWidth(ComboBox combo)
	{
		checked
		{
			int num = combo.get_Items().get_Count() - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i++)
			{
				if ((double)num2 < (double)combo.get_Items().get_Item(i).ToString()!.Length * LiterWidth)
				{
					num2 = (int)Math.Round((double)combo.get_Items().get_Item(i).ToString()!.Length * LiterWidth);
				}
			}
			combo.set_DropDownWidth(num2);
			combo.set_MaxDropDownItems(30);
		}
	}

	public static void ListBoxWidthHeight(ListBox combo)
	{
		checked
		{
			int num = combo.get_Items().get_Count() - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i++)
			{
				if ((double)num2 < (double)combo.get_Items().get_Item(i).ToString()!.Length * LiterWidth)
				{
					num2 = (int)Math.Round((double)combo.get_Items().get_Item(i).ToString()!.Length * LiterWidth);
				}
			}
			if (num2 < 60)
			{
				num2 = 60;
			}
			((Control)combo).set_Width(num2 + 3);
			if (((Control)combo).get_Height() > 10 + combo.get_ItemHeight() * 20)
			{
				((Control)combo).set_Height(10 + combo.get_ItemHeight() * 20);
			}
		}
	}

	public static int GetIndexInCombo(string str, ComboBox combo)
	{
		str = Strings.UCase(Strings.Trim(str));
		checked
		{
			int num = combo.get_Items().get_Count() - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					Type typeFromHandle = typeof(Strings);
					object[] array = new object[1];
					ObjectCollection items = combo.get_Items();
					int num3 = num2;
					array[0] = RuntimeHelpers.GetObjectValue(items.get_Item(num3));
					object[] array2 = array;
					bool[] array3 = new bool[1] { true };
					object obj = NewLateBinding.LateGet((object)null, typeFromHandle, "UCase", array2, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						items.set_Item(num3, RuntimeHelpers.GetObjectValue(array2[0]));
					}
					if (Operators.ConditionalCompareObjectEqual(obj, (object)str, false))
					{
						break;
					}
					num2++;
					continue;
				}
				return -1;
			}
			return num2;
		}
	}

	public static string getStrFromArray(string[] arr, int i1 = 0, int i2 = -1)
	{
		checked
		{
			if (i2 == -1)
			{
				i2 = arr.Length - 1;
			}
			string[] array = new string[i2 - i1 + 1];
			int num = i2 - i1;
			for (int j = 0; j <= num; j++)
			{
				array[j] = arr[i1 + j];
			}
			return Strings.Join(array, "\r\n") + "\r\n";
		}
	}

	public static string GetNuzhPunkt(string punkt, string gde)
	{
		string text = "\r\n" + punkt + "\r\n";
		int num = gde.IndexOf(text);
		if (num == -1)
		{
			text = punkt + "\r\n";
			num = gde.IndexOf(text);
			if (num != 0)
			{
				return null;
			}
		}
		checked
		{
			int num2 = gde.IndexOf("\r\n", num + text.Length - 1) - num - text.Length;
			if (num2 < 0)
			{
				return gde.Substring(num + text.Length);
			}
			return gde.Substring(num + text.Length, num2);
		}
	}

	public static object IsNull(string val1, string val2)
	{
		if ((val1 == null) | string.IsNullOrEmpty(val1.Trim()))
		{
			return val2;
		}
		return val1;
	}

	public static void CreateObjects(string objects, bool withTree, bool isRun, ref Forms[] f, ref TreeView tree, ref TreeNode[] Breaks, ref object proj, bool fromEng = false)
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		checked
		{
			int num = Strings.Trim(objects).IndexOf("Language = ") + "Language = ".Length;
			if ((num == "Language = ".Length) | (num == "Language = ".Length + 1))
			{
				string text = Strings.Trim(objects).Substring(num, Strings.Trim(objects).IndexOf("\r\n") - num);
				if (!isDevelop)
				{
					lang_name = text;
					Props.CreatePoleznie();
					Props.CreateArrays();
				}
				else if (Operators.CompareString(text, lang_name, false) != 0)
				{
					if (!IsHttpCompil)
					{
						lang_name = text;
						setLangs();
						Props.CreatePoleznie();
						Props.CreateArrays();
						Props.CreateConstants();
						Props.CreateHelpWords();
					}
				}
				else
				{
					Props.CreatePoleznie();
					Props.CreateArrays();
				}
				objects = objects.Substring(objects.IndexOf("\r\n") + 2);
			}
			else
			{
				lang_name = lang_def;
				setLangs();
				Props.CreatePoleznie();
				Props.CreateArrays();
				Props.CreateConstants();
				Props.CreateHelpWords();
			}
			isOpening = true;
			string ByRefProjParams = default(string);
			object[] array = (object[])Perevodi.ToObjFromStr(objects, isRun, fromEng, ref ByRefProjParams);
			isOpening = false;
			if (Breaks == null)
			{
				ReDims(ref Breaks);
			}
			if (tree == null)
			{
				tree = new TreeView();
			}
			ReDims(ref f);
			f[f.Length - 1] = new Forms(holostoi: false, polezniy: true);
			object obj = null;
			if (array != null)
			{
				int num2 = array.Length - 1;
				for (int i = 0; i <= num2; i++)
				{
					if (Iz.IsFORM(RuntimeHelpers.GetObjectValue(array[i])))
					{
						if (isRun && obj != null)
						{
							NewLateBinding.LateCall(NewLateBinding.LateGet(obj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RaiseCreate", new object[0], (string[])null, (Type[])null, (bool[])null, true);
						}
						obj = RuntimeHelpers.GetObjectValue(array[i]);
						if (!fromEng)
						{
							ReDims(ref f);
							f[f.Length - 1] = (Forms)array[i];
							ReDims(ref f[f.Length - 1].MyObjs);
							f[f.Length - 1].MyObjs[f[f.Length - 1].MyObjs.Length - 1] = RuntimeHelpers.GetObjectValue(array[i]);
						}
						if (!withTree && tree.get_Nodes().IndexOfKey(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(array[i], (Type)null, "NodeTemp", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null))) == -1)
						{
							TreeNode val = new TreeNode(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(array[i], (Type)null, "NodeTemp", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null)));
							val.set_ImageKey(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(array[i], (Type)null, "NodeTemp", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ImageKey", new object[0], (string[])null, (Type[])null, (bool[])null)));
							val.set_SelectedImageKey(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(array[i], (Type)null, "NodeTemp", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectedImageKey", new object[0], (string[])null, (Type[])null, (bool[])null)));
							val.set_Tag(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(array[i], (Type)null, "NodeTemp", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Tag", new object[0], (string[])null, (Type[])null, (bool[])null)));
							val.set_Name(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(array[i], (Type)null, "NodeTemp", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Name", new object[0], (string[])null, (Type[])null, (bool[])null)));
							tree.get_Nodes().Add(val);
							TreeNodeCollection nodes = tree.get_Nodes().get_Item(tree.get_Nodes().get_Count() - 1).get_Nodes();
							object[] array2 = new object[1];
							object[] array3 = array2;
							int num3 = i;
							array3[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array[num3], (Type)null, "NodeTemp", new object[0], (string[])null, (Type[])null, (bool[])null));
							object[] array4 = array2;
							object[] array5 = array4;
							bool[] array6 = new bool[1] { true };
							NewLateBinding.LateCall((object)nodes, (Type)null, "Add", array5, (string[])null, (Type[])null, array6, true);
							if (array6[0])
							{
								NewLateBinding.LateSetComplex(array[num3], (Type)null, "NodeTemp", new object[1] { RuntimeHelpers.GetObjectValue(array4[0]) }, (string[])null, (Type[])null, true, false);
							}
						}
						if (!isRun)
						{
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(array[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Panel2", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "ContextMenuStrip", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(peremens2.MainForm, (Type)null, "SplitPanelMenu", new object[0], (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null, false, true);
						}
					}
					else
					{
						object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null));
						if (objectValue == null)
						{
							continue;
						}
						if (Array.IndexOf((Array)NewLateBinding.LateGet(objectValue, (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), RuntimeHelpers.GetObjectValue(array[i])) == -1)
						{
							int num3 = i;
							object obj2 = array[num3];
							object[] array7 = new object[0];
							object[] array8 = array7;
							string[] array9 = null;
							object mass = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj2, (Type)null, "GetMyForm", array8, array9, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null));
							ReDimsO(ref mass);
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(array[num3], (Type)null, "GetMyForm", array7, array9, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[1] { RuntimeHelpers.GetObjectValue(mass) }, (string[])null, (Type[])null, true, true);
							NewLateBinding.LateSetComplex(NewLateBinding.LateGet(array[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[2]
							{
								Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(array[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "MyObjs", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1),
								RuntimeHelpers.GetObjectValue(array[i])
							}, (string[])null, (Type[])null, false, true);
						}
						if (!withTree && NewLateBinding.LateGet(array[i], (Type)null, "NodeTemp", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
						{
							object obj3 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(array[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetNode", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "nodes", new object[0], (string[])null, (Type[])null, (bool[])null);
							object[] array4 = new object[1];
							object[] array10 = array4;
							int num3 = i;
							object obj4 = array[num3];
							object[] array7 = new object[0];
							object[] array11 = array7;
							string[] array9 = null;
							array10[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(obj4, (Type)null, "NodeTemp", array11, array9, (Type[])null, (bool[])null), (Type)null, "Text", new object[0], (string[])null, (Type[])null, (bool[])null));
							object[] array2 = array4;
							object[] array12 = array2;
							bool[] array6 = new bool[1] { true };
							object obj5 = NewLateBinding.LateGet(obj3, (Type)null, "IndexOfKey", array12, (string[])null, (Type[])null, array6);
							if (array6[0])
							{
								NewLateBinding.LateSetComplex(NewLateBinding.LateGet(array[num3], (Type)null, "NodeTemp", array7, array9, (Type[])null, (bool[])null), (Type)null, "Text", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, true);
							}
							if (Operators.ConditionalCompareObjectEqual(obj5, (object)(-1), false))
							{
								object obj6 = NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(array[i], (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetNode", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "nodes", new object[0], (string[])null, (Type[])null, (bool[])null);
								object[] array13 = new object[1];
								int num4 = i;
								array13[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(array[num4], (Type)null, "NodeTemp", new object[0], (string[])null, (Type[])null, (bool[])null));
								object[] array14 = array13;
								bool[] array15 = new bool[1] { true };
								NewLateBinding.LateCall(obj6, (Type)null, "add", array14, (string[])null, (Type[])null, array15, true);
								if (array15[0])
								{
									NewLateBinding.LateSetComplex(array[num4], (Type)null, "NodeTemp", new object[1] { RuntimeHelpers.GetObjectValue(array14[0]) }, (string[])null, (Type[])null, true, false);
								}
							}
						}
					}
					NewLateBinding.LateSet(array[i], (Type)null, "NodeTemp", new object[1] { null }, (string[])null, (Type[])null);
					if (!withTree)
					{
						NewLateBinding.LateSet(array[i], (Type)null, "tree", new object[1] { tree }, (string[])null, (Type[])null);
					}
					if (isRun && !Iz.IsFORM(RuntimeHelpers.GetObjectValue(array[i])))
					{
						NewLateBinding.LateCall(NewLateBinding.LateGet(array[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RaiseCreate", new object[0], (string[])null, (Type[])null, (bool[])null, true);
					}
				}
			}
			if (isRun && obj != null)
			{
				NewLateBinding.LateCall(NewLateBinding.LateGet(obj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "RaiseCreate", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
			int num5 = f.Length - 1;
			for (int i = 0; i <= num5; i++)
			{
				f[i].HistoryLevel = new ArrayList();
				f[i].HistoryLevel.AddRange(f[i].MyObjs);
				int num6 = f[i].MyObjs.Length - 1;
				for (int j = 0; j <= num6; j++)
				{
					f[i].HistoryLevel.Remove(RuntimeHelpers.GetObjectValue(f[i].MyObjs[j]));
					if (Operators.ConditionalCompareObjectGreater((object)f[i].HistoryLevel.Count, NewLateBinding.LateGet(f[i].MyObjs[j], (Type)null, "HistoryTemp", new object[0], (string[])null, (Type[])null, (bool[])null), false))
					{
						f[i].HistoryLevel.Insert(Conversions.ToInteger(NewLateBinding.LateGet(f[i].MyObjs[j], (Type)null, "HistoryTemp", new object[0], (string[])null, (Type[])null, (bool[])null)), RuntimeHelpers.GetObjectValue(f[i].MyObjs[j]));
					}
					else
					{
						f[i].HistoryLevel.Add(RuntimeHelpers.GetObjectValue(f[i].MyObjs[j]));
					}
				}
				int num7 = f[i].HistoryLevel.Count - 1;
				for (int j = 0; j <= num7; j++)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(f[i].HistoryLevel[j], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "BringToFront", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			CreateProjParams(ByRefProjParams);
			if (unchecked(isRun && array != null))
			{
				int num8 = array.Length - 1;
				for (int i = 0; i <= num8; i++)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(array[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "load", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
		}
	}

	public static void CreateProjParams(string prParams, bool findIhInCode = false)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected O, but got Unknown
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Expected O, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Expected O, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Expected O, but got Unknown
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e1: Expected O, but got Unknown
		int num = 0;
		checked
		{
			if (findIhInCode)
			{
				string text = "\r\n#ProjectParams\r\n";
				int num2 = prParams.LastIndexOf(text);
				if (num2 == -1)
				{
					return;
				}
				prParams = prParams.Substring(num2 + text.Length);
			}
			RichTextBox val = new RichTextBox();
			val.set_Text(prParams);
			string[] lines = ((TextBoxBase)val).get_Lines();
			if (lines.Length <= 0)
			{
				return;
			}
			if (Operators.CompareString(lines[num], "#Comms", false) == 0)
			{
				num++;
				string text2 = "";
				for (; Operators.CompareString(lines[num], "#EndComms", false) != 0; num++)
				{
					text2 = text2 + lines[num] + "\r\n";
				}
				object proj = peremens2.proj;
				object[] array = new object[3] { null, text2, false };
				object[] array2 = array;
				bool[] array3 = new bool[3] { false, true, false };
				NewLateBinding.LateCall(proj, (Type)null, "PasteTree", array2, (string[])null, (Type[])null, array3, true);
				if (array3[1])
				{
					text2 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[1]), typeof(string));
				}
				num++;
			}
			if (Operators.CompareString(lines[num], "#Breaks", false) == 0)
			{
				for (num++; Operators.CompareString(lines[num], "#EndBreaks", false) != 0; num++)
				{
					ReDims(ref Breaks);
					TreeNode[] breaks = Breaks;
					int num3 = Breaks.Length - 1;
					object proj2 = peremens2.proj;
					object[] array = new object[2];
					object[] array4 = array;
					int num4 = num;
					array4[0] = lines[num4];
					array[1] = Tree;
					object[] array5 = array;
					object[] array6 = array5;
					bool[] array3 = new bool[2] { true, true };
					object obj = NewLateBinding.LateGet(proj2, (Type)null, "GetNodeFromName", array6, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						lines[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(string));
					}
					if (array3[1])
					{
						Tree = (TreeView)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[1]), typeof(TreeView));
					}
					breaks[num3] = (TreeNode)obj;
				}
				num++;
			}
			if (Operators.CompareString(lines[num], "#PoleznieDistance", false) == 0)
			{
				num++;
				int num5 = 0;
				for (; Operators.CompareString(lines[num], "#EndPoleznieDistance", false) != 0; num++)
				{
					object proj3 = peremens2.proj;
					object[] array5 = new object[1] { num5 };
					object[] array7 = array5;
					bool[] array3 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet(proj3, (Type)null, "f", array7, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						num5 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array5[0]), typeof(int));
					}
					if (NewLateBinding.LateGet(obj2, (Type)null, "SplitCont", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
					{
						object proj4 = peremens2.proj;
						object[] array8 = new object[1] { num5 };
						bool[] array9 = new bool[1] { true };
						object obj3 = NewLateBinding.LateGet(proj4, (Type)null, "f", array8, (string[])null, (Type[])null, array9);
						if (array9[0])
						{
							num5 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array8[0]), typeof(int));
						}
						object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "SplitCont", new object[0], (string[])null, (Type[])null, (bool[])null);
						object[] array10 = new object[1];
						object[] array11 = array10;
						object proj5 = peremens2.proj;
						object[] array12 = new object[1] { num5 };
						object[] array13 = array12;
						bool[] array14 = new bool[1] { true };
						object obj5 = NewLateBinding.LateGet(proj5, (Type)null, "f", array13, (string[])null, (Type[])null, array14);
						if (array14[0])
						{
							num5 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array12[0]), typeof(int));
						}
						object obj6 = Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(obj5, (Type)null, "SplitCont", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), (object)lines[num]);
						object proj6 = peremens2.proj;
						object[] array15 = new object[1] { num5 };
						object[] array16 = array15;
						bool[] array17 = new bool[1] { true };
						object obj7 = NewLateBinding.LateGet(proj6, (Type)null, "f", array16, (string[])null, (Type[])null, array17);
						if (array17[0])
						{
							num5 = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(int));
						}
						array11[0] = Operators.AddObject(obj6, NewLateBinding.LateGet(NewLateBinding.LateGet(obj7, (Type)null, "SplitCont", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SplitterWidth", new object[0], (string[])null, (Type[])null, (bool[])null));
						NewLateBinding.LateSetComplex(obj4, (Type)null, "SplitterDistance", array10, (string[])null, (Type[])null, false, true);
					}
					num5++;
				}
				num++;
			}
			if (Operators.CompareString(lines[num], "#Expands", false) == 0)
			{
				for (num++; Operators.CompareString(lines[num], "#EndExpands", false) != 0; num++)
				{
					object proj7 = peremens2.proj;
					object[] array10 = new object[3];
					object[] array18 = array10;
					int num4 = num;
					array18[0] = lines[num4];
					array10[1] = Tree;
					array10[2] = true;
					object[] array15 = array10;
					object[] array19 = array15;
					bool[] array17 = new bool[3] { true, true, false };
					object obj8 = NewLateBinding.LateGet(proj7, (Type)null, "GetNodeFromName", array19, (string[])null, (Type[])null, array17);
					if (array17[0])
					{
						lines[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
					}
					if (array17[1])
					{
						Tree = (TreeView)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[1]), typeof(TreeView));
					}
					TreeNode val2 = (TreeNode)obj8;
					if (val2 == null)
					{
						continue;
					}
					if (val2.get_IsExpanded())
					{
						object proj8 = peremens2.proj;
						array10 = new object[3];
						object[] array20 = array10;
						num4 = num;
						array20[0] = lines[num4];
						array10[1] = val2;
						array10[2] = false;
						array15 = array10;
						object[] array21 = array15;
						array17 = new bool[3] { true, true, false };
						object obj9 = NewLateBinding.LateGet(proj8, (Type)null, "GetNodeFromName", array21, (string[])null, (Type[])null, array17);
						if (array17[0])
						{
							lines[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
						}
						if (array17[1])
						{
							val2 = (TreeNode)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[1]), typeof(TreeNode));
						}
						val2 = (TreeNode)obj9;
					}
					if (val2 != null)
					{
						val2.Expand();
					}
				}
				num++;
			}
			if (Operators.CompareString(lines[num], "#SelNode", false) == 0)
			{
				num++;
				TreeView tree = Tree;
				object proj9 = peremens2.proj;
				object[] array10 = new object[2];
				object[] array22 = array10;
				int num4 = num;
				array22[0] = lines[num4];
				array10[1] = Tree;
				object[] array15 = array10;
				object[] array23 = array15;
				bool[] array17 = new bool[2] { true, true };
				object obj10 = NewLateBinding.LateGet(proj9, (Type)null, "GetNodeFromName", array23, (string[])null, (Type[])null, array17);
				if (array17[0])
				{
					lines[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
				}
				if (array17[1])
				{
					Tree = (TreeView)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[1]), typeof(TreeView));
				}
				tree.set_SelectedNode((TreeNode)obj10);
				num++;
			}
			if (Operators.CompareString(lines[num], "#ActiveForm", false) == 0)
			{
				num++;
				object proj10 = peremens2.proj;
				object[] array24 = new object[1];
				object[] array25 = array24;
				object proj11 = peremens2.proj;
				object[] array10 = new object[1];
				object[] array26 = array10;
				int num4 = num;
				array26[0] = lines[num4];
				object[] array15 = array10;
				object[] array27 = array15;
				bool[] array17 = new bool[1] { true };
				object obj11 = NewLateBinding.LateGet(proj11, (Type)null, "GetMyObjFromUniqName", array27, (string[])null, (Type[])null, array17);
				if (array17[0])
				{
					lines[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
				}
				array25[0] = RuntimeHelpers.GetObjectValue(obj11);
				NewLateBinding.LateSet(proj10, (Type)null, "ActiveForm", array24, (string[])null, (Type[])null);
				num++;
				if (NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
				{
					NewLateBinding.LateSet(peremens2.proj, (Type)null, "ActiveForm", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(peremens2.proj, (Type)null, "f", new object[1] { 0 }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
				}
				if (NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
				{
					NewLateBinding.LateCall(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SelectTab", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				}
			}
			if (Operators.CompareString(lines[num], "#ActiveObj", false) == 0 && NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
			{
				num++;
				object obj12 = NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null);
				object[] array24 = new object[1];
				object[] array28 = array24;
				object proj12 = peremens2.proj;
				object obj13 = proj12;
				object[] array10 = new object[1];
				object[] array29 = array10;
				int num4 = num;
				array29[0] = lines[num4];
				object[] array15 = array10;
				object[] array30 = array15;
				bool[] array17 = new bool[1] { true };
				object obj14 = NewLateBinding.LateGet(obj13, (Type)null, "GetMyObjFromUniqName", array30, (string[])null, (Type[])null, array17);
				if (array17[0])
				{
					lines[num4] = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array15[0]), typeof(string));
				}
				array28[0] = RuntimeHelpers.GetObjectValue(obj14);
				object[] array12 = array24;
				object[] array31 = array12;
				bool[] array14 = new bool[1] { true };
				NewLateBinding.LateCall(obj12, (Type)null, "SetActiveObject", array31, (string[])null, (Type[])null, array14, true);
				if (array14[0])
				{
					NewLateBinding.LateSetComplex(proj12, (Type)null, "GetMyObjFromUniqName", new object[2]
					{
						lines[num4],
						RuntimeHelpers.GetObjectValue(array12[0])
					}, (string[])null, (Type[])null, true, false);
				}
				NewLateBinding.LateCall(NewLateBinding.LateGet(peremens2.proj, (Type)null, "ActiveForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "marker_vis", new object[0], (string[])null, (Type[])null, (bool[])null, true);
				num++;
			}
			if (Operators.CompareString(lines[num], "#ImagePath", false) == 0)
			{
				num++;
				NewLateBinding.LateSet(peremens2.proj, (Type)null, "iPathShort", new object[1] { lines[num] }, (string[])null, (Type[])null);
				NewLateBinding.LateSet(peremens2.proj, (Type)null, "iPath", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(Operators.ConcatenateObject(NewLateBinding.LateGet(peremens2.proj, (Type)null, "pPath", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(peremens2.proj, (Type)null, "iPathShort", new object[0], (string[])null, (Type[])null, (bool[])null)), (Type)null, "Replace", new object[2] { "\\\\", "\\" }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
				num++;
				if (Operators.ConditionalCompareObjectNotEqual(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.proj, (Type)null, "iPath", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Chars", new object[1] { Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.proj, (Type)null, "iPath", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1) }, (string[])null, (Type[])null, (bool[])null), (object)"\\", false))
				{
					object proj12 = peremens2.proj;
					NewLateBinding.LateSet(proj12, (Type)null, "iPath", new object[1] { Operators.ConcatenateObject(NewLateBinding.LateGet(proj12, (Type)null, "iPath", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"\\") }, (string[])null, (Type[])null);
				}
				Papks[Strings.LCase(trans("Рисунки проекта"))] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(peremens2.proj, (Type)null, "iPath", new object[0], (string[])null, (Type[])null, (bool[])null));
			}
			if (Operators.CompareString(lines[num], "#ImageDefName", false) == 0)
			{
				num++;
				NewLateBinding.LateSet(peremens2.proj, (Type)null, "pPicNameDef", new object[1] { lines[num] }, (string[])null, (Type[])null);
				num++;
			}
			if (Operators.CompareString(lines[num], "#pProgressForm", false) == 0)
			{
				num++;
				NewLateBinding.LateSet(peremens2.proj, (Type)null, "pProgressForm", new object[1] { lines[num] }, (string[])null, (Type[])null);
				num++;
			}
			if (Operators.CompareString(lines[num], "#Icon", false) == 0)
			{
				num++;
				NewLateBinding.LateSet(peremens2.proj, (Type)null, "pIcon", new object[1] { lines[num] }, (string[])null, (Type[])null);
				num++;
			}
		}
	}

	public static TreeNode[] GetNodesFromTypeTag(string tag, object root = null, bool isObj = false, bool vnutriRecurs = false)
	{
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		if (root == null)
		{
			root = Tree;
		}
		if (Operators.CompareString(tag, "", false) == 0)
		{
			return (TreeNode[])root;
		}
		if (!vnutriRecurs)
		{
			retNs = null;
		}
		int num = Conversions.ToInteger(Operators.SubtractObject(NewLateBinding.LateGet(NewLateBinding.LateGet(root, (Type)null, "Nodes", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Count", new object[0], (string[])null, (Type[])null, (bool[])null), (object)1));
		checked
		{
			for (int i = 0; i <= num; i++)
			{
				object obj = isObj;
				object obj2 = root;
				object[] array = new object[1] { i };
				bool[] array2 = new bool[1] { true };
				object obj3 = NewLateBinding.LateGet(obj2, (Type)null, "Nodes", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(int));
				}
				object[] array7;
				bool[] array5;
				if (Conversions.ToBoolean(Operators.OrObject(obj, Operators.CompareObjectGreater(NewLateBinding.LateGet(obj3, (Type)null, "level", new object[0], (string[])null, (Type[])null, (bool[])null), (object)0, false))))
				{
					object obj4 = root;
					object[] array3 = new object[1] { i };
					object[] array4 = array3;
					array5 = new bool[1] { true };
					object obj5 = NewLateBinding.LateGet(obj4, (Type)null, "Nodes", array4, (string[])null, (Type[])null, array5);
					if (array5[0])
					{
						i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array3[0]), typeof(int));
					}
					if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(obj5, (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null), (object)tag, false))
					{
						ReDims(ref retNs);
						TreeNode[] array6 = retNs;
						int num2 = retNs.Length - 1;
						object obj6 = root;
						array7 = new object[1] { i };
						object[] array8 = array7;
						array5 = new bool[1] { true };
						object obj7 = NewLateBinding.LateGet(obj6, (Type)null, "Nodes", array8, (string[])null, (Type[])null, array5);
						if (array5[0])
						{
							i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(int));
						}
						array6[num2] = (TreeNode)obj7;
					}
				}
				object obj8 = root;
				array7 = new object[1] { i };
				object[] array9 = array7;
				array5 = new bool[1] { true };
				object obj9 = NewLateBinding.LateGet(obj8, (Type)null, "Nodes", array9, (string[])null, (Type[])null, array5);
				if (array5[0])
				{
					i = (int)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array7[0]), typeof(int));
				}
				GetNodesFromTypeTag(tag, RuntimeHelpers.GetObjectValue(obj9), isObj, vnutriRecurs: true);
			}
			return retNs;
		}
	}

	public static object[] GetMyObjsFromTreeNode(TreeNode node = null, bool includeToo = false)
	{
		if (node == null)
		{
			node = Tree.get_SelectedNode();
		}
		if (node == null)
		{
			return null;
		}
		object[] array = null;
		while (node.get_Level() > 1)
		{
			node = node.get_Parent();
		}
		object[] array4;
		TreeNode val;
		object[] array2;
		bool[] array6;
		if (node.get_Level() == 0)
		{
			object proj = peremens2.proj;
			array2 = new object[1];
			object[] array3 = array2;
			val = node;
			array3[0] = val.get_Text();
			array4 = array2;
			object[] array5 = array4;
			array6 = new bool[1] { true };
			object obj = NewLateBinding.LateGet(proj, (Type)null, "GetMyFormsFromName", array5, (string[])null, (Type[])null, array6);
			if (array6[0])
			{
				val.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array4[0]), typeof(string)));
			}
			return (object[])obj;
		}
		object proj2 = peremens2.proj;
		array4 = new object[1];
		object[] array7 = array4;
		val = node.get_Parent();
		array7[0] = val.get_Text();
		array2 = array4;
		object[] array8 = array2;
		array6 = new bool[1] { true };
		object obj2 = NewLateBinding.LateGet(proj2, (Type)null, "GetMyFormsFromName", array8, (string[])null, (Type[])null, array6);
		if (array6[0])
		{
			val.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string)));
		}
		object[] array9 = (object[])obj2;
		if (array9 == null)
		{
			return new object[1] { node };
		}
		checked
		{
			int num = array9.Length - 1;
			int num3 = default(int);
			for (int i = 0; i <= num; i++)
			{
				object obj3 = array9[i];
				array4 = new object[1];
				object[] array10 = array4;
				val = node;
				array10[0] = val.get_Text();
				array2 = array4;
				object[] array11 = array2;
				array6 = new bool[1] { true };
				object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "GetMyObjsFromName", array11, (string[])null, (Type[])null, array6);
				if (array6[0])
				{
					val.set_Text((string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array2[0]), typeof(string)));
				}
				object[] array12 = (object[])obj4;
				if (array12 != null)
				{
					int num2 = array12.Length - 1;
					for (int j = 0; j <= num2; j++)
					{
						array = (object[])Utils.CopyArray((Array)array, (Array)new object[num3 + 1]);
						array[num3] = RuntimeHelpers.GetObjectValue(array12[j]);
						num3++;
					}
				}
			}
			return array;
		}
	}

	public static double ToDouble(string str)
	{
		object obj = PointSimb1;
		if ((Operators.CompareString(str, "", false) == 0) | (Operators.CompareString(str, "\"\"", false) == 0))
		{
			str = Conversions.ToString(0);
		}
		int num = str.IndexOf(PointSimb1);
		if (num == -1)
		{
			num = str.IndexOf(PointSimb2);
			obj = PointSimb2;
			if (num == -1)
			{
				return Conversions.ToDouble(str);
			}
		}
		string text = "";
		if (str.IndexOf("E") != -1)
		{
			text = str.Substring(str.IndexOf("E"));
			str = Strings.Left(str, str.IndexOf("E"));
		}
		int num2 = checked(str.Length - 1 - num);
		double num3 = Conversions.ToDouble(str.Replace(Conversions.ToString(obj), ""));
		num3 /= Conversions.ToDouble("1" + Strings.StrDup(num2, "0"));
		return Conversions.ToDouble(Conversions.ToString(num3) + text);
	}

	public static double ToDouble()
	{
		return 0.0;
	}

	public static RegistryKey GetRegistryKey(string allPath, ref string name)
	{
		string text = allPath + "\\";
		string text2 = text.Split(new char[1] { '\\' })[0];
		checked
		{
			if (text2.Length >= text.Length - 1)
			{
				text += "\\";
			}
			RegistryKey registryKey;
			if ((Operators.CompareString(text2, "HKEY_CLASSES_ROOT", false) == 0) | (Operators.CompareString(text2, "HKCR", false) == 0))
			{
				registryKey = Registry.ClassesRoot;
			}
			else if ((Operators.CompareString(text2, "HKEY_CURRENT_CONFIG", false) == 0) | (Operators.CompareString(text2, "HKCR", false) == 0))
			{
				registryKey = Registry.CurrentConfig;
			}
			else if ((Operators.CompareString(text2, "HKEY_CURRENT_USER", false) == 0) | (Operators.CompareString(text2, "HKCU", false) == 0))
			{
				registryKey = Registry.CurrentUser;
			}
			else if ((Operators.CompareString(text2, "HKEY_DYNDATA", false) == 0) | (Operators.CompareString(text2, "HKDD", false) == 0))
			{
				registryKey = Registry.DynData;
			}
			else if ((Operators.CompareString(text2, "HKEY_LOCAL_MACHINE", false) == 0) | (Operators.CompareString(text2, "HKLM", false) == 0))
			{
				registryKey = Registry.LocalMachine;
			}
			else if ((Operators.CompareString(text2, "HKEY_PERFORMANCE_DATA", false) == 0) | (Operators.CompareString(text2, "HKPD", false) == 0))
			{
				registryKey = Registry.PerformanceData;
			}
			else
			{
				if (!((Operators.CompareString(text2, "HKEY_USERS", false) == 0) | (Operators.CompareString(text2, "HKU", false) == 0)))
				{
					Errors.MessangeExclamen(Errors.notRegistry(text2));
					return null;
				}
				registryKey = Registry.Users;
			}
			name = text.Substring(text.LastIndexOf("\\") + 1);
			text = text.Substring(text2.Length + 1, text.Length - text2.Length - 1 - name.Length - 1);
			RegistryKey registryKey2 = registryKey.OpenSubKey(text, writable: true);
			if (registryKey2 == null)
			{
				text = allPath;
				name = text.Substring(text.LastIndexOf("\\") + 1);
				int num = text.Length - text2.Length - 1 - name.Length - 1;
				if (num < 0)
				{
					num = 0;
				}
				text = text.Substring(text2.Length + 1, num);
				registryKey2 = registryKey.OpenSubKey(text, writable: true);
				if (registryKey2 == null)
				{
					Errors.MessangeExclamen(Errors.notRegistry(text2 + "\\" + text));
					return null;
				}
			}
			return registryKey2;
		}
	}

	public static void CreateRegistryKey(RegistryKey k, string nam, string value, RegistryValueKind type)
	{
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (type == RegistryValueKind.Binary)
			{
				value = Strings.Trim(value);
				string[] array = value.Split(new char[1] { ' ' });
				if ((array.Length == 0) | (Operators.CompareString(NikakoiEsli(value), trans("Никакой"), false) == 0))
				{
					byte[] value2 = new byte[0];
					k.SetValue(nam, value2, type);
					return;
				}
				checked
				{
					byte[] array2 = new byte[array.Length - 1 + 1];
					int num = array2.Length - 1;
					int num2 = 0;
					while (true)
					{
						if (num2 <= num)
						{
							if (!(Versioned.IsNumeric((object)array[num2]) & (Conversions.ToDouble(array[num2]) < 255.0) & (Conversions.ToDouble(array[num2]) >= 0.0)))
							{
								break;
							}
							array2[num2] = Conversions.ToByte(array[num2]);
							num2++;
							continue;
						}
						k.SetValue(nam, array2, type);
						return;
					}
					Interaction.MsgBox((object)Errors.InvalidFormatRegistry(value, k.ToString()), (MsgBoxStyle)16, (object)null);
				}
			}
			else if (type == RegistryValueKind.DWord || type == RegistryValueKind.QWord)
			{
				if (Operators.CompareString(NikakoiEsli(value), trans("Никакой"), false) == 0)
				{
					value = Conversions.ToString(0);
				}
				if (!Versioned.IsNumeric((object)value))
				{
					Interaction.MsgBox((object)Errors.InvalidFormatRegistry(value, k.ToString()), (MsgBoxStyle)16, (object)null);
				}
				else
				{
					k.SetValue(nam, value, type);
				}
			}
			else
			{
				k.SetValue(nam, value, type);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Errors.MessangeCritic(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	public static object GetContextMenu(object MyObj, string CxtMenuName)
	{
		if (MyObj == null)
		{
			return null;
		}
		object objectValue = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(MyObj, (Type)null, "getmyform", new object[0], (string[])null, (Type[])null, (bool[])null));
		if (objectValue == null)
		{
			return null;
		}
		object objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(MyObj, (Type)null, "proj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "GetMyObjFromUniqName", new object[1] { Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(objectValue, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"."), (object)CxtMenuName) }, (string[])null, (Type[])null, (bool[])null));
		if (Information.IsArray(RuntimeHelpers.GetObjectValue(objectValue2)))
		{
			objectValue2 = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue2, new object[1] { 0 }, (string[])null));
		}
		return objectValue2;
	}

	public static object FindOwnerContextMenu(object mItem)
	{
		if (Iz.IsCM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(mItem, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			return NewLateBinding.LateGet(NewLateBinding.LateGet(mItem, (Type)null, "CnMn", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "SourceControl", new object[0], (string[])null, (Type[])null, (bool[])null);
		}
		while ((NewLateBinding.LateGet(NewLateBinding.LateGet(mItem, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null) != null) & !Iz.IsCM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(mItem, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null))) & !Iz.IsMM(RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(mItem, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null))))
		{
			mItem = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(NewLateBinding.LateGet(mItem, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null));
		}
		if (NewLateBinding.LateGet(NewLateBinding.LateGet(mItem, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null) == null)
		{
			return null;
		}
		return NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(mItem, (Type)null, "myObj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "conteiner", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null);
	}

	public static bool isRUN()
	{
		if (RunProj == null)
		{
			return false;
		}
		if (!RunProj.isRUN)
		{
			return false;
		}
		return true;
	}

	public static bool isRUNorPause()
	{
		if (RunProj == null)
		{
			return false;
		}
		if (!RunProj.isRUN & !RunProj.Pause)
		{
			return false;
		}
		return true;
	}

	public static Uri GetUrlFromString(string str)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		Uri result = null;
		string str2 = str;
		if (Uri.TryCreate(str, UriKind.Absolute, out result))
		{
			return result;
		}
		str = "http://" + str;
		if (Uri.TryCreate(str, UriKind.Absolute, out result))
		{
			return result;
		}
		Interaction.MsgBox((object)Errors.InvalidUrl(str2), (MsgBoxStyle)0, (object)null);
		return null;
	}

	public static string UbratKluchSlova(string type, string str)
	{
		str = Strings.Trim(str);
		if (Operators.CompareString(type, "While", false) == 0)
		{
			string text = Strings.UCase(trans("Повторяться пока")) + " ";
			if (Strings.UCase(str).IndexOf(text) == 0)
			{
				str = str.Substring(text.Length);
			}
		}
		checked
		{
			if (Operators.CompareString(type, "If", false) == 0)
			{
				string text = Strings.UCase(trans("Если")) + " ";
				if (Strings.UCase(str).IndexOf(text) == 0)
				{
					str = str.Substring(text.Length);
				}
				text = " " + Strings.UCase(trans("Тогда"));
				if (Strings.UCase(str).LastIndexOf(Strings.Trim(text)) == 0)
				{
					str = "";
				}
				if (Strings.UCase(str).LastIndexOf(text) != -1 && Strings.UCase(str).LastIndexOf(text) == str.Length - text.Length)
				{
					str = str.Substring(0, str.Length - text.Length);
				}
			}
			if (Operators.CompareString(type, "ElseIf", false) == 0)
			{
				string text = Strings.UCase(trans("ИлиЕсли"));
				if (Strings.UCase(str).IndexOf(text) == 0)
				{
					str = str.Substring(text.Length);
				}
				text = " " + Strings.UCase(trans("Тогда"));
				if (Strings.UCase(str).LastIndexOf(Strings.Trim(text)) == 0)
				{
					str = "";
				}
				if ((Strings.UCase(str).LastIndexOf(text) == str.Length - text.Length) & (str.Length - text.Length != -1))
				{
					str = str.Substring(0, str.Length - text.Length);
				}
			}
			if (Operators.CompareString(type, "Else", false) == 0)
			{
				str = "";
			}
			return Strings.Trim(str);
		}
	}

	public static string SozdatKluchSlova(string type, string str)
	{
		str = Strings.Trim(str);
		switch (type)
		{
		case "If":
			str = Strings.UCase(trans("Если")) + " " + str + " " + Strings.UCase(trans("тогда"));
			break;
		case "ElseIf":
			str = Strings.UCase(trans("ИлиЕсли")) + " " + str + " " + Strings.UCase(trans("тогда"));
			break;
		case "Else":
			str = trans("В остальных случаях");
			break;
		case "EndIf":
			str = trans("Конец условия");
			break;
		case "While":
			str = Strings.UCase(trans("ПОВТОРЯТЬСЯ ПОКА")) + " " + str;
			break;
		case "EndWhile":
			str = trans("Конец цикла");
			break;
		}
		return str;
	}

	public static byte[] toByteArray(string str)
	{
		checked
		{
			byte[] array = new byte[(int)Math.Round((double)str.Length / 3.0 - 1.0) + 1];
			try
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					array[i] = Conversions.ToByte(Conversions.ToString(str[3 * i]) + Conversions.ToString(str[3 * i + 1]) + Conversions.ToString(str[3 * i + 2]));
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				byte[] result = null;
				ProjectData.ClearProjectError();
				return result;
			}
			return array;
		}
	}

	public static string toStrArray(byte[] bts)
	{
		checked
		{
			string[] array = new string[bts.Length - 1 + 1];
			int num = bts.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = string.Format(Conversions.ToString(bts[i]), "00#");
				if (array[i].Length == 1)
				{
					array[i] = "00" + array[i];
				}
				if (array[i].Length == 2)
				{
					array[i] = "0" + array[i];
				}
			}
			return Strings.Join(array, "");
		}
	}

	public static int ChangeFileEncoding(string pPathFolder, string pExtension, SearchOption pDirOption)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(pPathFolder);
		FileInfo[] files = directoryInfo.GetFiles(pExtension, pDirOption);
		int num = default(int);
		foreach (FileInfo fileInfo in files)
		{
			string text = "";
			StreamReader streamReader = new StreamReader(fileInfo.FullName, Encoding.Default, detectEncodingFromByteOrderMarks: true);
			text = streamReader.ReadToEnd();
			Encoding currentEncoding = streamReader.CurrentEncoding;
			streamReader.Close();
			if (Operators.CompareString(currentEncoding.EncodingName, Encoding.UTF8.EncodingName, false) != 0)
			{
				text = File.ReadAllText(fileInfo.FullName, currentEncoding);
				File.WriteAllText(fileInfo.FullName, text, Encoding.UTF8);
				num = checked(num + 1);
			}
		}
		return num;
	}

	public static string sZaglavnoi(string str)
	{
		if (str.Length > 0)
		{
			str = Conversions.ToString(Strings.UCase(str[0])) + str.Substring(1);
		}
		return str;
	}

	public static string ToMyColor(Color col)
	{
		Color color = default(Color);
		if (col == color)
		{
			return null;
		}
		if (col == Color.Transparent)
		{
			return trans("Никакой");
		}
		if (Colors.ContainsValue(col))
		{
			return sZaglavnoi(trans(Conversions.ToString(Colors.GetKey(Colors.IndexOfValue(col)))));
		}
		return Conversions.ToString(col.R) + "; " + Conversions.ToString(col.G) + "; " + Conversions.ToString(col.B) + ";";
	}

	public static int Int(string str)
	{
		if (Operators.CompareString(str, "True", false) == 0)
		{
			return 1;
		}
		if (Operators.CompareString(str, "False", false) == 0)
		{
			return 0;
		}
		return checked((int)Math.Round(Conversion.Val(str)));
	}

	public static Color FromMyColor(string col, bool notError = false)
	{
		if (Operators.CompareString(NikakoiEsli(col), trans("Никакой"), false) == 0)
		{
			return Color.Transparent;
		}
		Color color = default(Color);
		if (Colors.ContainsKey(Strings.LCase(trans(col))))
		{
			object? obj = Colors[Strings.LCase(trans(col))];
			return (obj != null) ? ((Color)obj) : color;
		}
		checked
		{
			if (col.Length > 2 && ((Operators.CompareString(Conversions.ToString(col[0]), "\"", false) == 0) & (Operators.CompareString(Conversions.ToString(col[col.Length - 1]), "\"", false) == 0)))
			{
				col = col.Substring(1, col.Length - 2);
			}
			string[] array = col.Split(new char[1] { ';' });
			if (array.Length == 4)
			{
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					array[i] = Strings.Trim(array[i]);
				}
				try
				{
					return Color.FromArgb(Conversions.ToInteger(array[0]), Conversions.ToInteger(array[1]), Conversions.ToInteger(array[2]));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					if (notError)
					{
						Errors.MessangeInfo(ex2.Message);
						Color result = color;
						ProjectData.ClearProjectError();
						return result;
					}
					ProjectData.ClearProjectError();
				}
			}
			return color;
		}
	}

	public static string copyImage(string fromFile, bool prinuditalno = false)
	{
		if (isOpening)
		{
			return fromFile;
		}
		if (Operators.CompareString(NikakoiEsli(fromFile), trans("Никакой"), false) == 0)
		{
			return trans("Никакой");
		}
		string text = fromFile;
		object[] array = new object[1];
		object proj = peremens2.proj;
		array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(proj, (Type)null, "iPath", new object[0], (string[])null, (Type[])null, (bool[])null));
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		object obj = NewLateBinding.LateGet((object)fromFile, (Type)null, "IndexOf", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(proj, (Type)null, "iPath", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
		}
		if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(obj, (object)(-1), false), (object)prinuditalno)))
		{
			text = GetCorrectFileName(Conversions.ToString(NewLateBinding.LateGet(peremens2.proj, (Type)null, "pPicNameDef", new object[0], (string[])null, (Type[])null, (bool[])null)), fromFile.Substring(fromFile.LastIndexOf(".")), Conversions.ToString(NewLateBinding.LateGet(peremens2.proj, (Type)null, "iPath", new object[0], (string[])null, (Type[])null, (bool[])null)));
			FileInfo fileInfo = new FileInfo(fromFile);
			if ((double)fileInfo.Length / 1024.0 / 1024.0 > 10.0)
			{
				ProgressFormShow(transInfc("Копирование"), 10);
			}
			File.Copy(fromFile, text);
			((Control)peremens2.ProgressForm).Hide();
		}
		return text;
	}

	public static string GetCorrectFileName(string FileNameWithoutExtended, string Extended, string Path)
	{
		if (!Directory.Exists(Path))
		{
			Directory.CreateDirectory(Path);
		}
		int num = default(int);
		string text;
		do
		{
			num = checked(num + 1);
			text = "\\" + FileNameWithoutExtended + Conversions.ToString(num) + Extended;
		}
		while (File.Exists(Path + text));
		return Path + text;
	}

	public static string GetMinPath(string path)
	{
		path = Strings.Trim(path);
		if (Operators.CompareString(NikakoiEsli(path), trans("Никакой"), false) == 0)
		{
			return trans("Никакой");
		}
		string text = path;
		object[] array = new object[1];
		object proj = peremens2.proj;
		array[0] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(proj, (Type)null, "pPath", new object[0], (string[])null, (Type[])null, (bool[])null));
		object[] array2 = array;
		bool[] array3 = new bool[1] { true };
		object obj = NewLateBinding.LateGet((object)text, (Type)null, "IndexOf", array2, (string[])null, (Type[])null, array3);
		if (array3[0])
		{
			NewLateBinding.LateSetComplex(proj, (Type)null, "pPath", new object[1] { RuntimeHelpers.GetObjectValue(array2[0]) }, (string[])null, (Type[])null, true, false);
		}
		if (Operators.ConditionalCompareObjectNotEqual(obj, (object)(-1), false))
		{
			return path.Substring(Conversions.ToInteger(NewLateBinding.LateGet(NewLateBinding.LateGet(peremens2.proj, (Type)null, "pPath", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null)));
		}
		return path;
	}

	public static string GetMaxPath(string path)
	{
		path = Strings.Trim(path);
		if (Operators.CompareString(NikakoiEsli(path), trans("Никакой"), false) == 0)
		{
			return trans("Никакой");
		}
		checked
		{
			bool flag = default(bool);
			if (path.Length > 2 && ((Operators.CompareString(Conversions.ToString(path[0]), "\"", false) == 0) & (Operators.CompareString(Conversions.ToString(path[path.Length - 1]), "\"", false) == 0)))
			{
				flag = true;
				path = path.Substring(1, path.Length - 2);
			}
			if (Operators.CompareString(path, "", false) != 0)
			{
				if (File.Exists(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(peremens2.proj, (Type)null, "pPath", new object[0], (string[])null, (Type[])null, (bool[])null), (object)path))))
				{
					return Conversions.ToString(NewLateBinding.LateGet(Operators.ConcatenateObject(NewLateBinding.LateGet(peremens2.proj, (Type)null, "pPath", new object[0], (string[])null, (Type[])null, (bool[])null), (object)path), (Type)null, "Replace", new object[2] { "\\\\", "\\" }, (string[])null, (Type[])null, (bool[])null));
				}
				if (Directory.Exists(Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(peremens2.proj, (Type)null, "pPath", new object[0], (string[])null, (Type[])null, (bool[])null), (object)path))))
				{
					return Conversions.ToString(NewLateBinding.LateGet(Operators.ConcatenateObject(NewLateBinding.LateGet(peremens2.proj, (Type)null, "pPath", new object[0], (string[])null, (Type[])null, (bool[])null), (object)path), (Type)null, "Replace", new object[2] { "\\\\", "\\" }, (string[])null, (Type[])null, (bool[])null));
				}
			}
			if (path.Length >= 2 && Operators.CompareString(path.Substring(1, 1), ":", false) != 0)
			{
				return Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(peremens2.proj, (Type)null, "pPath", new object[0], (string[])null, (Type[])null, (bool[])null), (object)path));
			}
			if (flag)
			{
				path = "\"" + path + "\"";
			}
			return path;
		}
	}

	public static string GetPathBezSlash(string path)
	{
		path = Strings.Trim(path);
		if (Operators.CompareString(NikakoiEsli(path), trans("Никакой"), false) == 0)
		{
			return trans("Никакой");
		}
		if (path.Length < 2)
		{
			return path;
		}
		checked
		{
			if (((Operators.CompareString(Conversions.ToString(path[path.Length - 1]), "\\", false) == 0) | (Operators.CompareString(Conversions.ToString(path[path.Length - 1]), "/", false) == 0)) & (Operators.CompareString(Conversions.ToString(path[path.Length - 2]), ":", false) != 0))
			{
				path = path.Substring(0, path.Length - 1);
			}
			return path;
		}
	}

	public static void ReDimsO(ref object[] mass, int ifNoth = 0, int ifEstPlus = 0)
	{
		checked
		{
			if (mass == null)
			{
				mass = (object[])Utils.CopyArray((Array)mass, (Array)new object[ifNoth + 1]);
			}
			else
			{
				mass = (object[])Utils.CopyArray((Array)mass, (Array)new object[mass.Length + ifEstPlus + 1]);
			}
		}
	}

	public static void ReDims(ref object[] mass, int ifNoth = 0, int ifEstPlus = 0)
	{
		checked
		{
			if (mass == null)
			{
				mass = (object[])Utils.CopyArray((Array)mass, (Array)new object[ifNoth + 1]);
			}
			else
			{
				mass = (object[])Utils.CopyArray((Array)mass, (Array)new object[mass.Length + ifEstPlus + 1]);
			}
		}
	}

	public static void ReDimsO(ref object mass, int ifNoth = 0, int ifEstPlus = 0)
	{
		checked
		{
			if (mass == null)
			{
				mass = Utils.CopyArray((Array)mass, (Array)new object[ifNoth + 1]);
			}
			else
			{
				mass = Utils.CopyArray((Array)mass, (Array)new object[Conversions.ToInteger(Operators.AddObject(NewLateBinding.LateGet(mass, (Type)null, "Length", new object[0], (string[])null, (Type[])null, (bool[])null), (object)ifEstPlus)) + 1]);
			}
		}
	}

	public static void ReDims(ref DataGridViewRow[] mass, int ifNoth = 0, int ifEstPlus = 0)
	{
		checked
		{
			if (mass == null)
			{
				mass = (DataGridViewRow[])Utils.CopyArray((Array)mass, (Array)new DataGridViewRow[ifNoth + 1]);
			}
			else
			{
				mass = (DataGridViewRow[])Utils.CopyArray((Array)mass, (Array)new DataGridViewRow[mass.Length + ifEstPlus + 1]);
			}
		}
	}

	public static object[] ReDimsFun(object[] mass, int ifNoth = 0, int ifEstPlus = 0)
	{
		object[] array = new object[1];
		checked
		{
			if (mass == null)
			{
				mass = (object[])Utils.CopyArray((Array)mass, (Array)new object[ifNoth + 1]);
				array = mass;
			}
			else
			{
				array = (object[])Utils.CopyArray((Array)array, (Array)new object[mass.Length + ifEstPlus + 1]);
				int num = array.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (mass.Length > i)
					{
						array[i] = RuntimeHelpers.GetObjectValue(mass[i]);
					}
				}
			}
			return array;
		}
	}

	public static void ReDims(ref string[] mass, int ifNoth = 0, int ifEstPlus = 0)
	{
		checked
		{
			if (mass == null)
			{
				mass = (string[])Utils.CopyArray((Array)mass, (Array)new string[ifNoth + 1]);
			}
			else
			{
				mass = (string[])Utils.CopyArray((Array)mass, (Array)new string[mass.Length + ifEstPlus + 1]);
			}
		}
	}

	public static void ReDims(ref int[] mass, int ifNoth = 0, int ifEstPlus = 0)
	{
		checked
		{
			if (mass == null)
			{
				mass = (int[])Utils.CopyArray((Array)mass, (Array)new int[ifNoth + 1]);
			}
			else
			{
				mass = (int[])Utils.CopyArray((Array)mass, (Array)new int[mass.Length + ifEstPlus + 1]);
			}
		}
	}

	public static void ReDims(ref double[] mass, int ifNoth = 0, int ifEstPlus = 0)
	{
		checked
		{
			if (mass == null)
			{
				mass = (double[])Utils.CopyArray((Array)mass, (Array)new double[ifNoth + 1]);
			}
			else
			{
				mass = (double[])Utils.CopyArray((Array)mass, (Array)new double[mass.Length + ifEstPlus + 1]);
			}
		}
	}

	public static void ReDims(ref Point[] mass, int ifNoth = 0, int ifEstPlus = 0)
	{
		checked
		{
			if (mass == null)
			{
				mass = (Point[])Utils.CopyArray((Array)mass, (Array)new Point[ifNoth + 1]);
			}
			else
			{
				mass = (Point[])Utils.CopyArray((Array)mass, (Array)new Point[mass.Length + ifEstPlus + 1]);
			}
		}
	}

	public static void ReDims(ref TreeNode[] mass, int ifNoth = 0, int ifEstPlus = 0)
	{
		checked
		{
			if (mass == null)
			{
				mass = (TreeNode[])Utils.CopyArray((Array)mass, (Array)new TreeNode[ifNoth + 1]);
			}
			else
			{
				mass = (TreeNode[])Utils.CopyArray((Array)mass, (Array)new TreeNode[mass.Length + ifEstPlus + 1]);
			}
		}
	}

	public static void ReDims(ref Forms[] mass, int ifNoth = 0, int ifEstPlus = 0)
	{
		checked
		{
			if (mass == null)
			{
				mass = (Forms[])Utils.CopyArray((Array)mass, (Array)new Forms[ifNoth + 1]);
			}
			else
			{
				mass = (Forms[])Utils.CopyArray((Array)mass, (Array)new Forms[mass.Length + ifEstPlus + 1]);
			}
		}
	}

	public static void ReDims(ref TabPage[] mass, int ifNoth = 0, int ifEstPlus = 0)
	{
		checked
		{
			if (mass == null)
			{
				mass = (TabPage[])Utils.CopyArray((Array)mass, (Array)new TabPage[ifNoth + 1]);
			}
			else
			{
				mass = (TabPage[])Utils.CopyArray((Array)mass, (Array)new TabPage[mass.Length + ifEstPlus + 1]);
			}
		}
	}

	public static void ReDims(ref SolvingTree[] mass, int ifNoth = 0, int ifEstPlus = 0)
	{
		checked
		{
			if (mass == null)
			{
				mass = (SolvingTree[])Utils.CopyArray((Array)mass, (Array)new SolvingTree[ifNoth + 1]);
			}
			else
			{
				mass = (SolvingTree[])Utils.CopyArray((Array)mass, (Array)new SolvingTree[mass.Length + ifEstPlus + 1]);
			}
		}
	}

	public static void ReDims(ref DataGridViewCell[] mass, int ifNoth = 0, int ifEstPlus = 0)
	{
		checked
		{
			if (mass == null)
			{
				mass = (DataGridViewCell[])Utils.CopyArray((Array)mass, (Array)new DataGridViewCell[ifNoth + 1]);
			}
			else
			{
				mass = (DataGridViewCell[])Utils.CopyArray((Array)mass, (Array)new DataGridViewCell[mass.Length + ifEstPlus + 1]);
			}
		}
	}

	public static void DelDims(ref string[] mass, int ind)
	{
		checked
		{
			if (mass == null || !((ind >= 0) & (ind <= mass.Length - 1)))
			{
				return;
			}
			if (mass.Length <= 1)
			{
				mass = null;
				return;
			}
			int num = mass.Length - 2;
			for (int i = ind; i <= num; i++)
			{
				mass[i] = mass[i + 1];
			}
			ReDims(ref mass, 0, -2);
		}
	}

	public static void DelDims(ref SolvingTree[] mass, int ind)
	{
		checked
		{
			if (mass == null || !((ind >= 0) & (ind <= mass.Length - 1)))
			{
				return;
			}
			if (mass.Length <= 1)
			{
				mass = null;
				return;
			}
			int num = mass.Length - 2;
			for (int i = ind; i <= num; i++)
			{
				mass[i] = mass[i + 1];
			}
			ReDims(ref mass, 0, -2);
		}
	}

	public static void DelDims(ref object[] mass, int ind)
	{
		checked
		{
			if (mass == null || !((ind >= 0) & (ind <= mass.Length - 1)))
			{
				return;
			}
			if (mass.Length <= 1)
			{
				mass = null;
				return;
			}
			int num = mass.Length - 2;
			for (int i = ind; i <= num; i++)
			{
				mass[i] = RuntimeHelpers.GetObjectValue(mass[i + 1]);
			}
			mass = ReDimsFun(mass, 0, -2);
		}
	}

	public static object[] DelDimsFun(object[] mass, int ind)
	{
		if (mass == null)
		{
			return null;
		}
		checked
		{
			if ((ind >= 0) & (ind <= mass.Length - 1))
			{
				if (mass.Length <= 1)
				{
					mass = null;
					return null;
				}
				int num = mass.Length - 2;
				for (int i = ind; i <= num; i++)
				{
					mass[i] = RuntimeHelpers.GetObjectValue(mass[i + 1]);
				}
				mass = ReDimsFun(mass, 0, -2);
			}
			return mass;
		}
	}

	public static void DelDims(ref Forms[] mass, int ind)
	{
		checked
		{
			if (mass == null || !((ind >= 0) & (ind <= mass.Length - 1)))
			{
				return;
			}
			if (mass.Length <= 1)
			{
				mass = null;
				return;
			}
			int num = mass.Length - 2;
			for (int i = ind; i <= num; i++)
			{
				mass[i] = mass[i + 1];
			}
			ReDims(ref mass, 0, -2);
		}
	}

	public static void DelDims(ref TreeNode[] mass, int ind)
	{
		checked
		{
			if (mass == null || !((ind >= 0) & (ind <= mass.Length - 1)))
			{
				return;
			}
			if (mass.Length <= 1)
			{
				mass = null;
				return;
			}
			int num = mass.Length - 2;
			for (int i = ind; i <= num; i++)
			{
				mass[i] = mass[i + 1];
			}
			ReDims(ref mass, 0, -2);
		}
	}

	public static void HookRun(object hook)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		if (RunProj == null || !RunProj.isRUN)
		{
			return;
		}
		try
		{
			if (hook == "mouse")
			{
				MouseHook val = new MouseHook();
				val.add_MouseEvent(new MouseEventHandler(mouseHook_MouseEvent));
				mouseHook = val;
				hook = RuntimeHelpers.GetObjectValue(mouseHook);
			}
			else if (hook == "key")
			{
				KeyboardHookExt val2 = new KeyboardHookExt();
				((KeyboardHook)val2).add_KeyboardEvent(new KeyboardEventHandler(keyboardHook_KeyboardEvent));
				val2.add_SystemKeyDown(new KeyboardEventHandlerExt(keyboardHook_SystemKeyDown));
				val2.add_SystemKeyUp(new KeyboardEventHandlerExt(keyboardHook_SystemKeyUp));
				keyboardHook = val2;
				hook = RuntimeHelpers.GetObjectValue(keyboardHook);
			}
			if (Operators.ConditionalCompareObjectEqual(NewLateBinding.LateGet(hook, (Type)null, "IsHooked", new object[0], (string[])null, (Type[])null, (bool[])null), (object)false, false))
			{
				NewLateBinding.LateCall(hook, (Type)null, "InstallHook", new object[0], (string[])null, (Type[])null, (bool[])null, true);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Errors.MessangeCritic(trans("Невозможно перехватить нажатия клавиш"));
			ProjectData.ClearProjectError();
		}
	}

	public static void HookStops()
	{
		if (keyboardHook != "key" && Conversions.ToBoolean(NewLateBinding.LateGet(keyboardHook, (Type)null, "IsHooked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			NewLateBinding.LateCall(keyboardHook, (Type)null, "UninstallHook", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		if (mouseHook != "mouse" && Conversions.ToBoolean(NewLateBinding.LateGet(mouseHook, (Type)null, "IsHooked", new object[0], (string[])null, (Type[])null, (bool[])null)))
		{
			NewLateBinding.LateCall(mouseHook, (Type)null, "UninstallHook", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
	}

	private static void mouseHook_MouseEvent(MouseEvents mEvent, Point point)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		if ((int)mEvent == 522)
		{
			mwheel = true;
		}
		else
		{
			mwheel = false;
		}
		if ((int)mEvent != 512)
		{
			if ((int)mEvent == 513)
			{
				mleft = true;
			}
			else if ((int)mEvent == 514)
			{
				mleft = false;
			}
			else if ((int)mEvent == 516)
			{
				mright = true;
			}
			else if ((int)mEvent == 517)
			{
				mright = false;
			}
		}
	}

	private static void keyboardHook_KeyboardEvent(int kEvent, Keys key)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Invalid comparison between Unknown and I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Invalid comparison between Unknown and I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		switch (kEvent)
		{
		case 256:
			if ((int)key == 65536)
			{
				shft = true;
			}
			else if ((int)key == 262144)
			{
				alt = true;
			}
			else if ((int)key == 131072)
			{
				ctrl = true;
			}
			else if (!ks.Contains(((Enum)key).ToString()))
			{
				ks.Add(((Enum)key).ToString());
			}
			break;
		case 257:
			if ((int)key == 65536)
			{
				shft = false;
			}
			else if ((int)key == 262144)
			{
				alt = false;
			}
			else if ((int)key == 131072)
			{
				ctrl = false;
			}
			else if (ks.Contains(((Enum)key).ToString()))
			{
				ks.Remove(((Enum)key).ToString());
			}
			break;
		}
	}

	private static void keyboardHook_SystemKeyDown(Keys key)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		keyboardHook_KeyboardEvent(256, key);
	}

	private static void keyboardHook_SystemKeyUp(Keys key)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		keyboardHook_KeyboardEvent(257, key);
	}

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	public static extern IntPtr SetForegroundWindow(IntPtr hWnd);

	[DllImport("KERNEL32.DLL", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr BeginUpdateResourceW(string pFileName, bool bDeleteExistingResources);

	[DllImport("KERNEL32.DLL", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool UpdateResourceW(IntPtr hUpdate, uint pType, uint pName, ushort wLanguage, byte[] pData, uint cbData);

	[DllImport("KERNEL32.DLL", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool EndUpdateResourceW(IntPtr hUpdate, bool bDiscard);

	[DllImport("Winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int mciSendStringA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszCommand, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszReturnString, int cchReturn, IntPtr hwndCallback);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	public static extern int EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DevMode lpDevMode);

	[DllImport("user32.dll", CharSet = CharSet.Ansi)]
	public static extern ReturnCodes ChangeDisplaySettings(ref DevMode lpDevMode, int dwFlags);

	[DllImport("user32", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SystemParametersInfo(uint uiAction, int uiParam, StringBuilder pvParam, uint fWinIni);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern long SetSystemTime(ref SYSTEMTIME lpSystemTime);

	public static void DoMouse(object flags, Point newPoint, int wheelCount = 0)
	{
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		NativeMethods.INPUT pInputs = default(NativeMethods.INPUT);
		NativeMethods.MOUSEINPUT mi = default(NativeMethods.MOUSEINPUT);
		pInputs.dwType = NativeMethods.InputType.Mouse;
		pInputs.mi = mi;
		pInputs.mi.dwExtraInfo = IntPtr.Zero;
		checked
		{
			pInputs.mi.dx = (int)Math.Round((double)newPoint.X * (65535.0 / (double)Screen.get_PrimaryScreen().get_Bounds().Width));
			pInputs.mi.dy = (int)Math.Round((double)newPoint.Y * (65535.0 / (double)Screen.get_PrimaryScreen().get_Bounds().Height));
			pInputs.mi.time = 0;
			pInputs.mi.mouseData = wheelCount;
		}
		pInputs.mi.dwFlags = (NativeMethods.MOUSEEVENTF)Conversions.ToInteger(flags);
		int cbSize = Marshal.SizeOf(typeof(NativeMethods.INPUT));
		if (NativeMethods.SendInput(1, ref pInputs, cbSize) == 0)
		{
			Interaction.MsgBox((object)Marshal.GetLastWin32Error(), (MsgBoxStyle)0, (object)null);
		}
	}

	public static void DoKeyBoard(object flags, Keys key)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected I4, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		NativeMethods.INPUT pInputs = default(NativeMethods.INPUT);
		NativeMethods.KEYBDINPUT ki = default(NativeMethods.KEYBDINPUT);
		pInputs.dwType = NativeMethods.InputType.Keyboard;
		pInputs.ki = ki;
		pInputs.ki.wVk = Convert.ToInt16((int)key);
		pInputs.ki.wScan = 0;
		pInputs.ki.time = 0;
		pInputs.ki.dwFlags = (NativeMethods.KEYEVENTF)Conversions.ToInteger(flags);
		pInputs.ki.dwExtraInfo = IntPtr.Zero;
		int cbSize = Marshal.SizeOf(typeof(NativeMethods.INPUT));
		if (NativeMethods.SendInput(1, ref pInputs, cbSize) == 0)
		{
			Interaction.MsgBox((object)Marshal.GetLastWin32Error(), (MsgBoxStyle)0, (object)null);
		}
	}

	public static void ProgressN(object value)
	{
		peremens2.ProgressForm.ProgressBarValue = Conversions.ToInteger(value);
	}

	public static void ProgressShow(object value)
	{
		ProgressFormShow(Conversions.ToString(value));
	}

	public static void ProgressHide(object value)
	{
		((Control)peremens2.ProgressForm).Hide();
	}

	public static SortedList Get2ListInfoProps()
	{
		SortedList sortedList = new SortedList();
		if (!Directory.Exists(XMLpath))
		{
			return sortedList;
		}
		string[] files = Directory.GetFiles(XMLpath + "/PropertiesCommands");
		string[] files2 = Directory.GetFiles(XMLpath + "/Events");
		checked
		{
			files = (string[])Utils.CopyArray((Array)files, (Array)new string[files.Length - 1 + files2.Length + 1]);
			files2.CopyTo(files, files.Length - files2.Length);
			int num = files.Length - 1;
			XPathNavigator xPathNavigator;
			int i;
			for (i = 0; i <= num; i++)
			{
				xPathNavigator = new XPathDocument(files[i]).CreateNavigator();
				xPathNavigator = xPathNavigator.SelectSingleNode("//xml/file/descriptionarticle//text");
				if (xPathNavigator != null)
				{
					string text = Strings.Trim(xPathNavigator.Value.Replace("\r\n", ""));
					while (text.IndexOf("  ") != -1)
					{
						text = text.Replace("  ", " ");
					}
					sortedList.Add(Strings.LCase(trans(Path.GetFileNameWithoutExtension(files[i]), toEng: false, fromEng: true)), text);
				}
			}
			xPathNavigator = new XPathDocument(XMLpath + "/Arguments.xml").CreateNavigator();
			i = 1;
			while (true)
			{
				XPathNavigator xPathNavigator2 = xPathNavigator.SelectSingleNode("//arguments/argument[position()=" + Conversions.ToString(i) + "]");
				if (xPathNavigator2 == null)
				{
					break;
				}
				string text2 = Strings.Trim(xPathNavigator2.Value.Replace("\r\n", ""));
				while (text2.IndexOf("  ") != -1)
				{
					text2 = text2.Replace("  ", " ");
				}
				string key = Strings.LCase(trans(xPathNavigator2.SelectSingleNode("@name")!.Value, toEng: false, fromEng: true));
				if (sortedList.IndexOfKey(key) == -1)
				{
					sortedList.Add(key, text2);
				}
				i++;
			}
			return sortedList;
		}
	}

	public static SortedList Get2ListInfoObjs()
	{
		SortedList sortedList = new SortedList();
		if (!Directory.Exists(XMLpath))
		{
			return sortedList;
		}
		checked
		{
			int num = Pustishki.Count - 1;
			for (int i = 0; i <= num; i++)
			{
				string text = "Objects/" + trans(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Pustishki.GetByIndex(i), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "type", new object[0], (string[])null, (Type[])null, (bool[])null)), toEng: true);
				if (File.Exists(XMLpath + "\\" + text + ".xml"))
				{
					XPathNavigator xPathNavigator = new XPathDocument(XMLpath + "\\" + text + ".xml").CreateNavigator();
					string text2 = Strings.Trim(xPathNavigator.SelectSingleNode("//xml/file/descriptionarticle//text")!.Value.Replace("\r\n", ""));
					while (text2.IndexOf("  ") != -1)
					{
						text2 = text2.Replace("  ", " ");
					}
					sortedList.Add(trans(Conversions.ToString(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Pustishki.GetByIndex(i), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "type", new object[0], (string[])null, (Type[])null, (bool[])null)), toEng: true), Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Pustishki.GetByIndex(i), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "type", new object[0], (string[])null, (Type[])null, (bool[])null), (object)". "), (object)text2));
				}
			}
			return sortedList;
		}
	}

	public static SortedList Get2List(string file, string razdel, GetVal fun = null, bool withLCase = false)
	{
		if (!File.Exists(file))
		{
			return new SortedList();
		}
		return Get2ListFromString(File.OpenText(file).ReadToEnd(), razdel, fun, withLCase);
	}

	public static SortedList Get2ListFromString(string txt, string razdel, GetVal fun = null, bool withLCase = false)
	{
		SortedList sortedList = new SortedList();
		string[] separator = new string[1] { Environment.NewLine.ToString() };
		string[] array = (txt + Environment.NewLine).Split(separator, StringSplitOptions.RemoveEmptyEntries);
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				if (Operators.CompareString(new string(array[i].ToCharArray(0, 1)), "#", false) == 0)
				{
					continue;
				}
				int num2 = array[i].IndexOf(razdel);
				if (num2 == -1)
				{
					continue;
				}
				object obj = array[i].Substring(num2 + razdel.Length);
				if (fun != null)
				{
					obj = RuntimeHelpers.GetObjectValue(fun(Conversions.ToString(obj)));
				}
				if (withLCase)
				{
					string key = Strings.LCase(array[i].Substring(0, num2));
					Type typeFromHandle = typeof(Strings);
					object[] array2 = new object[1] { RuntimeHelpers.GetObjectValue(obj) };
					bool[] array3 = new bool[1] { true };
					object obj2 = NewLateBinding.LateGet((object)null, typeFromHandle, "LCase", array2, (string[])null, (Type[])null, array3);
					if (array3[0])
					{
						obj = RuntimeHelpers.GetObjectValue(array2[0]);
					}
					sortedList.Add(key, RuntimeHelpers.GetObjectValue(obj2));
				}
				else
				{
					sortedList.Add(array[i].Substring(0, num2), RuntimeHelpers.GetObjectValue(obj));
				}
			}
			return sortedList;
		}
	}

	public static string GetUNameObj(object myObj, object forDP = null)
	{
		string text = "";
		if (NewLateBinding.LateGet(myObj, (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
		{
			text = Conversions.ToString(Operators.ConcatenateObject(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "GetMyForm", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null), (object)"."));
		}
		text = Conversions.ToString(Operators.ConcatenateObject((object)text, NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "name", new object[0], (string[])null, (Type[])null, (bool[])null)));
		if (Iz.IsDP(RuntimeHelpers.GetObjectValue(myObj)) && forDP != null && NewLateBinding.LateGet(NewLateBinding.LateGet(forDP, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null) != null)
		{
			text = Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject(Operators.ConcatenateObject((object)"(", NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(forDP, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Parent", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "tag", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)")")));
		}
		return Conversions.ToString(Operators.ConcatenateObject((object)text, Operators.ConcatenateObject(Operators.ConcatenateObject((object)"[", NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(myObj, (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "index", new object[0], (string[])null, (Type[])null, (bool[])null)), (object)"]")));
	}

	public static string GetObjNameFromUName(string nam)
	{
		if (Operators.CompareString(nam, "", false) == 0)
		{
			return "";
		}
		if (nam.IndexOf("(") == -1)
		{
			return nam.Split(new char[1] { '.' })[1].Split(new char[1] { '[' })[0];
		}
		return nam.Split(new char[1] { '.' })[1].Split(new char[1] { '(' })[0];
	}

	public static string GetIndexFromUName(string nam)
	{
		if (Operators.CompareString(nam, "", false) == 0)
		{
			return "";
		}
		return nam.Split(new char[1] { '[' })[1].Split(new char[1] { ']' })[0];
	}

	public static string GetCorrectUName(string uName)
	{
		if ((uName.IndexOf("(") != -1) & (uName.IndexOf(")") != -1))
		{
			return uName.Split(new char[1] { '(' })[0] + uName.Split(new char[1] { ')' })[1];
		}
		return uName;
	}

	public static object[] GetSortTPsByPosition(object[] Objs)
	{
		bool flag = true;
		if (Objs == null)
		{
			return Objs;
		}
		checked
		{
			while (flag)
			{
				flag = false;
				int num = Objs.Length - 2;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(NewLateBinding.LateGet(Objs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), ClassAplication + "TPs", false) == 0)
					{
						int j;
						for (j = i + 1; j < Objs.Length && Operators.CompareString(NewLateBinding.LateGet(Objs[j], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null).GetType().ToString(), ClassAplication + "TPs", false) != 0; j++)
						{
						}
						if (j < Objs.Length && Operators.ConditionalCompareObjectGreater(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Objs[i], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "pos", new object[0], (string[])null, (Type[])null, (bool[])null), NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Objs[j], (Type)null, "obj", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "Props", new object[0], (string[])null, (Type[])null, (bool[])null), (Type)null, "pos", new object[0], (string[])null, (Type[])null, (bool[])null), false))
						{
							object objectValue = RuntimeHelpers.GetObjectValue(Objs[i]);
							Objs[i] = RuntimeHelpers.GetObjectValue(Objs[j]);
							Objs[j] = RuntimeHelpers.GetObjectValue(objectValue);
							flag = true;
						}
					}
				}
			}
			return Objs;
		}
	}

	public static string OutputRun(string type, string[] outps, PropertysSobyt param)
	{
		string text = "";
		if (Operators.CompareString(param.err.err, "", false) != 0)
		{
			text = trans("Произошла ошибка, при выполнении проекта") + ": " + param.err.str + ". " + param.err.err + "\r\n";
		}
		checked
		{
			if (RunProj != null)
			{
				int num = outps.Length - 1;
				int num2 = 0;
				while (true)
				{
					if (num2 <= num)
					{
						outps[num2] = UbratKluchSlova(type, outps[num2]);
						ErrString errString;
						if (RunProj.isPotok)
						{
							RunProj.outString = outps[num2];
							RunProj.outType = type;
							RunProj.outRunString = true;
							if (RunProj == null)
							{
								break;
							}
							while (RunProj.outRunString)
							{
								Application.DoEvents();
								Thread.Sleep(timeSleep);
								if (isRunAlg2Code)
								{
									RunProj.PrervaliPotok();
								}
							}
							errString = RunProj.outResult;
						}
						else
						{
							errString = RunProj.RunString(outps[num2], type, param);
						}
						if (Operators.CompareString(errString.err, "", false) != 0)
						{
							text = text + outps[num2] + " = ???\r\n";
							if (Operators.CompareString(errString.err, "!", false) == 0)
							{
								errString.err = trans("Непредвиденная ошибка");
							}
							text = text + trans("Ошибка в строке") + ": " + errString.str + ". \r\n" + trans("Описание ошибки") + ": " + errString.err + "\r\n\r\n";
						}
						else
						{
							text = text + outps[num2] + " = " + errString.str + "\r\n\r\n";
						}
						num2++;
						continue;
					}
					return text;
				}
			}
			string result = default(string);
			return result;
		}
	}
}
