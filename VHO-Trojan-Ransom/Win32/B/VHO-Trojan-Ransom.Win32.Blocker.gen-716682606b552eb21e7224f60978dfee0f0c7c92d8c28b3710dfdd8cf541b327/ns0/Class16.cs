using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using O;

namespace ns0;

internal sealed class Class16
{
	private sealed class Class17
	{
		public static readonly Class17 class17_0;

		internal byte[] byte_0;

		static Class17()
		{
			if (Class14.smethod_2(Class11.smethod_1(71, '?'), new DateTime(635781201242575304L), 977, 912))
			{
				throw new Exception();
			}
			class17_0 = new Class17();
		}

		private Class17()
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Expected O, but got Unknown
			Assembly assembly = (Assembly)(IEvidenceFactory)GForm1.smethod_2(435, 'ƣ');
			Stream manifestResourceStream = assembly.GetManifestResourceStream(smethod_1());
			if (manifestResourceStream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				manifestResourceStream.Read(byte_0, 0, byte_0.Length);
			}
		}

		public string method_0(string string_0, int int_0)
		{
			int num = GClass2.DRV.smethod_1(string_0, 279, 329);
			int num2 = int_0 & 0xFF;
			char[] array = (char[])(Array)string_0.ToCharArray();
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return string.Intern(new string(array));
		}
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (Class14.smethod_2(Class11.smethod_1(266, 'Ų'), new DateTime(635781201243255343L), 1, 64))
		{
			throw new Exception();
		}
		return string.Intern(Class17.class17_0.method_0(string_0, int_0));
	}

	[SpecialName]
	public static string smethod_1()
	{
		return "826305f88e6a4a3e98475d1f5fb0f48c";
	}
}
