using System;
using System.Runtime.InteropServices;
using System.Security;

namespace ns0;

internal sealed class Class3
{
	private struct Struct0
	{
		public uint uint_0;

		public int int_0;

		public int int_1;

		public ushort ushort_0;

		public ushort ushort_1;

		public uint uint_1;

		public uint uint_2;

		public int int_2;

		public int int_3;

		public uint uint_3;

		public uint uint_4;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	private struct Struct1
	{
		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public ushort ushort_0;

		public ushort ushort_1;

		public int int_0;

		public ushort ushort_2;
	}

	private struct Struct2
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public ushort ushort_2;
	}

	private struct Struct3
	{
		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public ushort ushort_0;

		public ushort ushort_1;

		public int int_0;

		public int int_1;
	}

	private sealed class Class4
	{
		private Struct2 struct2_0;

		private Struct3[] struct3_0;

		private byte[][] byte_0;

		public int Int32_0 => struct2_0.ushort_2;

		private Class4()
		{
			struct2_0 = default(Struct2);
		}

		public byte[] method_0(int int_0)
		{
			return byte_0[int_0];
		}

		public byte[] method_1(uint uint_0)
		{
			checked
			{
				int num = Delegate193.smethod_0(Delegate72.smethod_0(typeof(Struct2).TypeHandle)) + Delegate193.smethod_0(Delegate72.smethod_0(typeof(Struct1).TypeHandle)) * Int32_0;
				byte[] array = new byte[num - 1 + 1 - 1 + 1];
				GCHandle gchandle_ = Delegate152.smethod_0(array, GCHandleType.Pinned);
				Delegate207.smethod_0(struct2_0, Delegate166.smethod_0(ref gchandle_), bool_0: false);
				int num2 = Delegate19.smethod_0(struct2_0);
				int num3 = Int32_0 - 1;
				IntPtr intptr_2 = default(IntPtr);
				for (int i = 0; i <= num3; i++)
				{
					Struct1 @struct = default(Struct1);
					Struct0 struct2 = default(Struct0);
					GCHandle gchandle_2 = Delegate152.smethod_0(struct2, GCHandleType.Pinned);
					Delegate221.smethod_0(method_0(i), 0, Delegate166.smethod_0(ref gchandle_2), Delegate193.smethod_0(Delegate72.smethod_0(typeof(Struct0).TypeHandle)));
					Delegate86.smethod_0(ref gchandle_2);
					@struct.byte_0 = struct3_0[i].byte_0;
					@struct.byte_1 = struct3_0[i].byte_1;
					@struct.byte_2 = struct3_0[i].byte_2;
					@struct.byte_3 = struct3_0[i].byte_3;
					@struct.ushort_0 = struct2.ushort_0;
					@struct.ushort_1 = struct2.ushort_1;
					@struct.int_0 = struct3_0[i].int_0;
					@struct.ushort_2 = (ushort)(uint_0 + (ulong)i);
					IntPtr intptr_ = Delegate166.smethod_0(ref gchandle_);
					Delegate45.smethod_0(ref intptr_2, Delegate340.smethod_0(ref intptr_) + num2);
					Delegate207.smethod_0(@struct, intptr_2, bool_0: false);
					num2 += Delegate193.smethod_0(Delegate72.smethod_0(typeof(Struct1).TypeHandle));
				}
				Delegate86.smethod_0(ref gchandle_);
				return array;
			}
		}

		public static Class4 smethod_0(string string_0)
		{
			Class4 @class = new Class4();
			byte[] array = Delegate161.smethod_0(string_0);
			GCHandle gchandle_ = Delegate152.smethod_0(array, GCHandleType.Pinned);
			@class.struct2_0 = (Struct2)Delegate326.smethod_0(Delegate166.smethod_0(ref gchandle_), Delegate72.smethod_0(typeof(Struct2).TypeHandle));
			checked
			{
				@class.struct3_0 = new Struct3[unchecked((int)@class.struct2_0.ushort_2) - 1 + 1 - 1 + 1];
				@class.byte_0 = new byte[unchecked((int)@class.struct2_0.ushort_2) - 1 + 1 - 1 + 1][];
				int num = Delegate19.smethod_0(@class.struct2_0);
				Type type_ = Delegate72.smethod_0(typeof(Struct3).TypeHandle);
				int num2 = Delegate193.smethod_0(type_);
				int num3 = unchecked((int)@class.struct2_0.ushort_2) - 1;
				IntPtr intptr_2 = default(IntPtr);
				for (int i = 0; i <= num3; i++)
				{
					IntPtr intptr_ = Delegate166.smethod_0(ref gchandle_);
					Delegate45.smethod_0(ref intptr_2, Delegate340.smethod_0(ref intptr_) + num);
					Struct3 @struct = (Struct3)Delegate326.smethod_0(intptr_2, type_);
					@class.struct3_0[i] = @struct;
					@class.byte_0[i] = new byte[@struct.int_0 - 1 + 1 - 1 + 1];
					Delegate138.smethod_0(array, @struct.int_1, @class.byte_0[i], 0, @struct.int_0);
					num += num2;
				}
				Delegate86.smethod_0(ref gchandle_);
				return @class;
			}
		}
	}

	[SuppressUnmanagedCodeSecurity]
	private sealed class Class5
	{
		[DllImport("kernel32")]
		public static extern IntPtr BeginUpdateResource(string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0);

		[DllImport("kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool EndUpdateResource(IntPtr intptr_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0);

		[DllImport("kernel32")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool UpdateResource(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, short short_0, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] byte_0, int int_0);

		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "UpdateResource", SetLastError = true)]
		public static extern bool UpdateResource_1(IntPtr intptr_0, string string_0, string string_1, ushort ushort_0, byte[] byte_0, uint uint_0);
	}

	public static uint uint_0;

	public static uint uint_1;

	public static uint uint_2;

	public static uint uint_3;

	public static uint uint_4;

	public static uint uint_5;

	public static uint uint_6;

	public static uint uint_7;

	public static uint uint_8;

	[DllImport("kernel32.dll")]
	public static extern IntPtr LoadLibraryEx(string string_0, IntPtr intptr_0, uint uint_9);

	[DllImport("kernel32.dll")]
	public static extern IntPtr FindResource(IntPtr intptr_0, int int_0, uint uint_9);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr LoadResource(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll")]
	public static extern IntPtr LockResource(IntPtr intptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr BeginUpdateResource(string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool EndUpdateResource(IntPtr intptr_0, bool bool_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint SizeofResource(IntPtr intptr_0, IntPtr intptr_1);

	public static bool smethod_0(string string_0, string string_1)
	{
		return smethod_1(string_0, string_1, 1u, 1u);
	}

	public static bool smethod_1(string string_0, string string_1, uint uint_9, uint uint_10)
	{
		Class4 @class = Class4.smethod_0(string_1);
		IntPtr intptr_ = Class5.BeginUpdateResource(string_0, bool_0: false);
		byte[] array = @class.method_1(uint_10);
		IntPtr intptr_2 = default(IntPtr);
		Delegate274.smethod_0(ref intptr_2, 14);
		IntPtr intptr_3 = default(IntPtr);
		Delegate45.smethod_0(ref intptr_3, uint_9);
		Class5.UpdateResource(intptr_, intptr_2, intptr_3, 0, array, array.Length);
		checked
		{
			int num = @class.Int32_0 - 1;
			for (int i = 0; i <= num; i++)
			{
				byte[] array2 = @class.method_0(i);
				Delegate274.smethod_0(ref intptr_3, 3);
				Delegate45.smethod_0(ref intptr_2, (long)(uint_10 + (ulong)i));
				Class5.UpdateResource(intptr_, intptr_3, intptr_2, 0, array2, array2.Length);
			}
			Class5.EndUpdateResource(intptr_, bool_0: false);
			return true;
		}
	}

	public static bool smethod_2(string string_0, string string_1, string string_2, string string_3)
	{
		byte[] array = Delegate227.smethod_0(Delegate118.smethod_0(), string_3);
		IntPtr intptr_ = BeginUpdateResource(string_0, bool_0: false);
		if (Class5.UpdateResource_1(intptr_, string_1, string_2, 0, array, (uint)array.Length))
		{
			Class5.EndUpdateResource(intptr_, bool_0: false);
			return true;
		}
		return false;
	}

	public static bool smethod_3(string string_0, string string_1, string string_2, byte[] byte_0)
	{
		IntPtr intptr_ = BeginUpdateResource(string_0, bool_0: false);
		if (Class5.UpdateResource_1(intptr_, string_1, string_2, 0, byte_0, (uint)byte_0.Length))
		{
			Class5.EndUpdateResource(intptr_, bool_0: false);
			return true;
		}
		return false;
	}
}
