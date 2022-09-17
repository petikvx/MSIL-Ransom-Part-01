using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns1;

namespace ns2;

internal sealed class Class3 : ReadOnlyCollectionBase
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	protected internal struct Struct0
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		public Enum0 enum0_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_1;

		public int int_0;

		public int int_1;

		public int int_2;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_2;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_3;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	protected internal struct Struct1
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		public Enum0 enum0_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	protected internal struct Struct2
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public string string_0;

		public byte byte_0;

		public ushort ushort_0;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_1;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_2;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public string string_3;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public string string_4;

		[SpecialName]
		public Enum0 method_0()
		{
			return (Enum0)(byte_0 & 0x7F);
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	protected internal struct Struct3
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public string string_0;

		public byte byte_0;

		public ushort ushort_0;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_1;

		[SpecialName]
		public Enum0 method_0()
		{
			return (Enum0)(ushort_0 & 0x7FFF);
		}
	}

	private readonly string string_0;

	internal static Class3 class3_0;

	public Class2 this[int int_0] => (Class2)base.InnerList[int_0];

	public Class2 this[string string_1]
	{
		get
		{
			if (string.IsNullOrEmpty(string_1))
			{
				return null;
			}
			string_1 = Path.GetFullPath(string_1);
			if (!Class21.smethod_35(string_1))
			{
				return null;
			}
			Class2 @class = null;
			foreach (Class2 inner in base.InnerList)
			{
				if (Class21.smethod_105(inner) && Class21.smethod_23(string_1, inner))
				{
					if (@class == null)
					{
						@class = inner;
					}
					else if (@class.method_2().Length < inner.method_2().Length && (inner.method_3() == Enum0.flag_0 || @class.method_3() != 0))
					{
						@class = inner;
					}
				}
			}
			return @class;
		}
	}

	public Class3()
	{
		string_0 = string.Empty;
		Class21.smethod_98(this, string_0);
	}

	protected void Add(Class2 class2_0)
	{
		base.InnerList.Add(class2_0);
	}

	protected internal void method_0(string string_1, string string_2, Enum0 enum0_0, string string_3)
	{
		base.InnerList.Add(new Class2(string_0, string_1, string_2, enum0_0, string_3));
	}
}
