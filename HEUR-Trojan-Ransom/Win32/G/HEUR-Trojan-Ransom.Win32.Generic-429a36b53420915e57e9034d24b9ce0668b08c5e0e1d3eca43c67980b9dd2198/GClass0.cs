using System;
using System.Windows.Forms;

public class GClass0
{
	public string string_0 = string.Empty;

	public string method_0(Keys keys_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Expected I4, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Invalid comparison between I4 and Unknown
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Invalid comparison between I4 and Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_0379: Invalid comparison between I4 and Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Invalid comparison between I4 and Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Invalid comparison between I4 and Unknown
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0455: Invalid comparison between I4 and Unknown
		//IL_0468: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Invalid comparison between I4 and Unknown
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Invalid comparison between I4 and Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Invalid comparison between I4 and Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Invalid comparison between I4 and Unknown
		//IL_04c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Invalid comparison between I4 and Unknown
		//IL_04e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Invalid comparison between I4 and Unknown
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Invalid comparison between I4 and Unknown
		//IL_051b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0520: Invalid comparison between I4 and Unknown
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Invalid comparison between I4 and Unknown
		//IL_0756: Unknown result type (might be due to invalid IL or missing references)
		//IL_0773: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Invalid comparison between I4 and Unknown
		//IL_078b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Invalid comparison between I4 and Unknown
		//IL_07a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a8: Invalid comparison between I4 and Unknown
		//IL_07bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Invalid comparison between I4 and Unknown
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Invalid comparison between I4 and Unknown
		//IL_07eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f0: Invalid comparison between I4 and Unknown
		//IL_0803: Unknown result type (might be due to invalid IL or missing references)
		//IL_0808: Invalid comparison between I4 and Unknown
		switch ((int)keys_0)
		{
		case 219:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				string_0 = "`";
				return "";
			}
			string_0 = "\u00b4";
			return "";
		case 220:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return "}";
			}
			return "]";
		case 221:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return "{";
			}
			return "[";
		case 222:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				string_0 = "^";
				return "";
			}
			string_0 = "~";
			return "";
		case 226:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return "|";
			}
			return "\\";
		case 8:
			return "[BackSpace]";
		case 9:
			return "[Tab]";
		case 12:
			return "[Clear]";
		case 13:
			return "[Enter]";
		case 16:
			return "";
		case 17:
			return "";
		case 19:
			return "[Pause]";
		case 20:
			return "";
		case 27:
			return "[Esc]";
		case 32:
			return " ";
		case 33:
			return "[PageUp]";
		case 34:
			return "[PageDown]";
		case 35:
			return "[End]";
		case 36:
			return "[Home]";
		case 37:
			return "[ArrowLeft]";
		case 38:
			return "[ArrowUp]";
		case 39:
			return "[ArrowRight]";
		case 40:
			return "[ArrowDown]";
		case 44:
			return "[PrintScreen]";
		case 45:
			return "[Insert]";
		case 46:
			return "[Delete]";
		case 48:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return ")";
			}
			return "0";
		case 49:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return "!";
			}
			return "1";
		case 50:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return "@";
			}
			return "2";
		case 51:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return "#";
			}
			return "3";
		case 52:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return "$";
			}
			return "4";
		case 53:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return "%";
			}
			return "5";
		case 54:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				string_0 = "\u00a8";
				return "";
			}
			return "6";
		case 55:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return "&";
			}
			return "7";
		case 56:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return "*";
			}
			return "8";
		case 57:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return "(";
			}
			return "9";
		case 65:
			return method_1("a");
		case 66:
			return method_1("b");
		case 67:
			return method_1("c");
		case 68:
			return method_1("d");
		case 69:
			return method_1("e");
		case 70:
			return method_1("f");
		case 71:
			return method_1("g");
		case 72:
			return method_1("h");
		case 73:
			return method_1("i");
		case 74:
			return method_1("j");
		case 75:
			return method_1("k");
		case 76:
			return method_1("l");
		case 77:
			return method_1("m");
		case 78:
			return method_1("n");
		case 79:
			return method_1("o");
		case 80:
			return method_1("p");
		case 81:
			return method_1("q");
		case 82:
			return method_1("r");
		case 83:
			return method_1("s");
		case 84:
			return method_1("t");
		case 85:
			return method_1("u");
		case 86:
			return method_1("v");
		case 87:
			return method_1("w");
		case 88:
			return method_1("x");
		case 89:
			return method_1("y");
		case 90:
			return method_1("z");
		case 91:
			return "[Win]";
		case 92:
			return "[Win]";
		case 93:
			return "[Apps]";
		case 96:
			return "0";
		case 97:
			return "1";
		case 98:
			return "2";
		case 99:
			return "3";
		case 100:
			return "4";
		case 101:
			return "5";
		case 102:
			return "6";
		case 103:
			return "7";
		case 104:
			return "8";
		case 105:
			return "9";
		case 106:
			return "*";
		case 107:
			return "+";
		case 109:
			return "-";
		case 110:
			return ",";
		case 111:
			return "/";
		case 112:
			return "[F1]";
		case 113:
			return "[F2]";
		case 114:
			return "[F3]";
		case 115:
			return "[F4]";
		case 116:
			return "[F5]";
		case 117:
			return "[F6]";
		case 118:
			return "[F7]";
		case 119:
			return "[F8]";
		case 120:
			return "[F9]";
		case 121:
			return "[F10]";
		case 122:
			return "[F11]";
		case 123:
			return "[F12]";
		case 144:
			return "[NumLock]";
		case 145:
			return "[ScrollLock]";
		case 160:
			return "";
		case 161:
			return "";
		case 162:
			return "";
		case 163:
			return "";
		default:
			return ((object)keys_0).ToString();
		case 186:
			return method_1("ç");
		case 187:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return "+";
			}
			return "=";
		case 188:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return "<";
			}
			return ",";
		case 189:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return "_";
			}
			return "-";
		case 190:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return ">";
			}
			return ".";
		case 191:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return ":";
			}
			return ";";
		case 192:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return "\"";
			}
			return "'";
		case 193:
			if (65536 == (int)Control.get_ModifierKeys())
			{
				return "?";
			}
			return "/";
		case 194:
			return ".";
		}
	}

	private string method_1(string string_1)
	{
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Invalid comparison between I4 and Unknown
		switch (string_1)
		{
		default:
			if (!string.IsNullOrEmpty(string_0.Trim()))
			{
				string_1 = string_0 + string_1;
				string_0 = string.Empty;
			}
			else
			{
				string_0 = string.Empty;
			}
			break;
		case "a":
		case "e":
		case "i":
		case "o":
		case "u":
			switch (string_1)
			{
			case "u":
				if (string_0 == "^")
				{
					string_1 = "û";
				}
				else if (string_0 == "\u00b4")
				{
					string_1 = "ú";
				}
				else if (string_0 == "`")
				{
					string_1 = "ù";
				}
				else if (string_0 == "\u00a8")
				{
					string_1 = "ü";
				}
				string_0 = "";
				break;
			case "o":
				if (string_0 == "^")
				{
					string_1 = "ô";
				}
				else if (string_0 == "\u00b4")
				{
					string_1 = "ó";
				}
				else if (string_0 == "`")
				{
					string_1 = "ò";
				}
				else if (string_0 == "\u00a8")
				{
					string_1 = "ö";
				}
				else if (string_0 == "~")
				{
					string_1 = "õ";
				}
				string_0 = "";
				break;
			case "i":
				if (string_0 == "^")
				{
					string_1 = "î";
				}
				else if (string_0 == "\u00b4")
				{
					string_1 = "í";
				}
				else if (string_0 == "`")
				{
					string_1 = "ì";
				}
				else if (string_0 == "\u00a8")
				{
					string_1 = "ï";
				}
				string_0 = "";
				break;
			case "e":
				if (string_0 == "^")
				{
					string_1 = "ê";
				}
				else if (string_0 == "\u00b4")
				{
					string_1 = "é";
				}
				else if (string_0 == "`")
				{
					string_1 = "è";
				}
				else if (string_0 == "\u00a8")
				{
					string_1 = "ë";
				}
				string_0 = "";
				break;
			case "a":
				if (string_0 == "^")
				{
					string_1 = "â";
				}
				else if (string_0 == "\u00b4")
				{
					string_1 = "á";
				}
				else if (string_0 == "`")
				{
					string_1 = "à";
				}
				else if (string_0 == "\u00a8")
				{
					string_1 = "ä";
				}
				else if (string_0 == "~")
				{
					string_1 = "ã";
				}
				string_0 = "";
				break;
			}
			break;
		}
		if (65536 != (int)Control.get_ModifierKeys() && !Console.CapsLock)
		{
			return string_1.ToLower();
		}
		return string_1.ToUpper();
	}
}
