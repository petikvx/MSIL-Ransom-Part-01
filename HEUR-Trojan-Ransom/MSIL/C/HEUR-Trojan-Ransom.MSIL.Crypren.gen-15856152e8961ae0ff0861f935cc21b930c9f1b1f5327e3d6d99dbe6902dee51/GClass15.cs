using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ClassInterface(ClassInterfaceType.AutoDispatch)]
[ComVisible(true)]
[Guid("17FF9C92-B8B6-4506-A7BA-8482D9B0AB07")]
public sealed class GClass15
{
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private char char_0;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private DateTime dateTime_0;

	[CompilerGenerated]
	private GClass3 gclass3_0;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private string string_3;

	public string String_0
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		internal set
		{
			string_0 = value;
		}
	}

	public string String_1
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		internal set
		{
			string_1 = value;
		}
	}

	public char Char_0
	{
		[CompilerGenerated]
		get
		{
			return char_0;
		}
		[CompilerGenerated]
		internal set
		{
			char_0 = value;
		}
	}

	public long Int64_0
	{
		[CompilerGenerated]
		get
		{
			return long_0;
		}
		[CompilerGenerated]
		internal set
		{
			long_0 = value;
		}
	}

	public int Int32_0
	{
		get
		{
			return Delegate314.smethod_0(this);
		}
		set
		{
			Delegate315.smethod_0(this, value);
		}
	}

	public DateTime DateTime_0
	{
		[CompilerGenerated]
		get
		{
			return dateTime_0;
		}
		[CompilerGenerated]
		internal set
		{
			dateTime_0 = value;
		}
	}

	public GClass3 GClass3_0
	{
		[CompilerGenerated]
		get
		{
			return gclass3_0;
		}
		[CompilerGenerated]
		internal set
		{
			gclass3_0 = value;
		}
	}

	public string String_2
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		internal set
		{
			string_2 = value;
		}
	}

	public string String_3
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		internal set
		{
			string_3 = value;
		}
	}

	public bool Boolean_0 => char.ToUpper(Delegate316.smethod_0(this), CultureInfo.InvariantCulture) == 'D';

	public bool Boolean_1
	{
		get
		{
			if (Delegate317.smethod_0(this) || 1 == 0)
			{
				return Delegate318.smethod_0(this) == ".";
			}
			return false;
		}
	}

	public bool Boolean_2
	{
		get
		{
			if (Delegate317.smethod_0(this) || 1 == 0)
			{
				return Delegate318.smethod_0(this) == "..";
			}
			return false;
		}
	}

	internal GClass15()
	{
	}

	public override string ToString()
	{
		return Delegate318.smethod_0(this);
	}

	private int method_0()
	{
		if (Delegate319.smethod_0(this) < -2147483648L || Delegate319.smethod_0(this) > 2147483647L)
		{
			throw new OverflowException(string.Format(CultureInfo.CurrentCulture, "Size {0} cannot be represented using 32-bit value", new object[1] { Delegate319.smethod_0(this) }));
		}
		return (int)Delegate319.smethod_0(this);
	}

	private void method_1(int int_0)
	{
		Delegate320.smethod_0(this, int_0);
	}
}
