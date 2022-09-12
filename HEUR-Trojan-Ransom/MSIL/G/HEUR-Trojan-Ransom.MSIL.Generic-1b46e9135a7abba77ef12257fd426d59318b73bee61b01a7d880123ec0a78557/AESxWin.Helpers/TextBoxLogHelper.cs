using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using A6yJVNZuoAn9NC1LAS;

namespace AESxWin.Helpers;

public static class TextBoxLogHelper
{
	private static TextBox LogViewer
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get;
		[MethodImpl(MethodImplOptions.NoInlining)]
		set;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SetLogViewer(this Form form, TextBox textbox)
	{
		//Discarded unreachable code: IL_0005, IL_006f
		//IL_0006: Incompatible stack heights: 0 vs 1
		int num = 3;
		if (false)
		{
			goto IL_0016;
		}
		goto IL_0078;
		IL_0078:
		int num2 = num;
		goto IL_007c;
		IL_007c:
		switch (num2)
		{
		case 3:
			break;
		default:
			goto IL_0044;
		case 0:
		case 1:
			goto IL_0064;
		case 5:
			return;
		}
		goto IL_0016;
		IL_0016:
		bool flag = textbox == null;
		_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
		if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
		{
			num = 0;
			if (_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				goto IL_0064;
			}
			goto IL_0078;
		}
		num2 = 4;
		goto IL_007c;
		IL_0064:
		if (!flag)
		{
			LogViewer = textbox;
			num = 5;
			goto IL_0078;
		}
		goto IL_0044;
		IL_0044:
		throw new NullReferenceException(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2372));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Log(string message)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		AppendMessage(FormatMessage(string.Empty, message, null));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Log(string level, string message)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		AppendMessage(FormatMessage(level, message, null));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Log(string level, string message, Exception exception)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		AppendMessage(FormatMessage(level, message, exception));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Log(this Form form, string message)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		AppendMessage(FormatMessage(string.Empty, message, null));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Log(this Form form, string level, string message)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		AppendMessage(FormatMessage(level, message, null));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void Log(this Form form, string level, string message, Exception exception)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		AppendMessage(FormatMessage(level, message, exception));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void AppendMessage(string message)
	{
		//Discarded unreachable code: IL_0005, IL_0093
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0123: Incompatible stack heights: 0 vs 1
		int num = 9;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		bool flag = default(bool);
		bool invokeRequired = default(bool);
		while (true)
		{
			int num3;
			int num2;
			switch (num)
			{
			case 9:
				_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
				num3 = 11;
				goto IL_0098;
			case 1:
				((TextBoxBase)LogViewer).ScrollToCaret();
				num2 = 12;
				if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
				{
					break;
				}
				goto case 8;
			case 8:
				throw new NullReferenceException(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2376));
			case 3:
			case 10:
				if (!flag)
				{
					invokeRequired = ((Control)LogViewer).get_InvokeRequired();
				}
				else
				{
					num2 = 8;
					if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
					{
						break;
					}
				}
				goto case 5;
			case 5:
			case 7:
			{
				if (invokeRequired)
				{
					goto case 4;
				}
				TextBox logViewer = LogViewer;
				((Control)logViewer).set_Text(((Control)logViewer).get_Text() + _003C_003Ec__DisplayClass11_.message);
				num3 = 2;
				goto IL_0098;
			}
			default:
				num3 = 4;
				goto IL_0098;
			case 0:
				return;
			case 6:
				flag = LogViewer == null;
				_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
				if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
				{
					num2 = 7;
					if (0 == 0)
					{
						break;
					}
					goto case 3;
				}
				num2 = 10;
				break;
			case 11:
				_003C_003Ec__DisplayClass11_.message = message;
				num2 = 6;
				if (0 == 0)
				{
					break;
				}
				goto case 2;
			case 2:
				((TextBoxBase)LogViewer).set_SelectionStart(((Control)LogViewer).get_Text().Length);
				num3 = 1;
				goto IL_0098;
			case 4:
				((Control)LogViewer).Invoke((Delegate)new Action(_003C_003Ec__DisplayClass11_._003CAppendMessage_003Eb__0));
				num3 = 0;
				goto IL_0098;
			case 12:
				return;
				IL_0098:
				num2 = num3;
				break;
			}
			num = num2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string FormatMessage(string level, string message, Exception exception)
	{
		//Discarded unreachable code: IL_0005, IL_009c
		//IL_0006: Incompatible stack heights: 0 vs 1
		_ = 0;
		int num;
		if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
		{
			num = 2;
			if (false)
			{
				goto IL_0022;
			}
			goto IL_00a5;
		}
		int num2 = 5;
		goto IL_00a9;
		IL_0022:
		string result = string.Format(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2388), DateTime.Now, level.ToUpper(), message, exception);
		int num3 = 6;
		goto IL_00a1;
		IL_00da:
		num3 = 3;
		goto IL_00a1;
		IL_00a9:
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 4:
				break;
			case 0:
			case 2:
				flag = !string.IsNullOrEmpty(level);
				goto case 1;
			case 3:
				level = S7EI44sMaZQ92MiG6X.pA2PN5iOW(2380) + level + S7EI44sMaZQ92MiG6X.pA2PN5iOW(2384);
				break;
			default:
				num2 = 4;
				continue;
			case 1:
			case 5:
				if (!flag)
				{
					break;
				}
				goto IL_00da;
			case 6:
				return result;
			}
			break;
		}
		goto IL_0022;
		IL_00a1:
		num = num3;
		goto IL_00a5;
		IL_00a5:
		num2 = num;
		goto IL_00a9;
	}

	internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return true;
	}

	internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return false;
	}
}
