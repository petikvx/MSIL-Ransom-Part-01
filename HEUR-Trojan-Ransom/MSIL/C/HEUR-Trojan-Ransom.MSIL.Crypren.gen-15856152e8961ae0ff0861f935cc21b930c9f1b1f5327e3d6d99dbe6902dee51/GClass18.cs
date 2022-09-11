using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComVisible(true)]
[Guid("6CED4579-0DF2-4E46-93E9-18780546B421")]
[ClassInterface(ClassInterfaceType.AutoDispatch)]
public sealed class GClass18
{
	[CompilerGenerated]
	private GEnum12 genum12_0;

	private int int_0;

	public GEnum12 GEnum12_0
	{
		[CompilerGenerated]
		get
		{
			return genum12_0;
		}
		[CompilerGenerated]
		set
		{
			genum12_0 = value;
		}
	}

	public int Int32_0
	{
		get
		{
			return Delegate544.smethod_0(this);
		}
		set
		{
			Delegate545.smethod_0(this, value);
		}
	}

	public GClass18()
	{
		Delegate546.smethod_0(this, GEnum12.const_0);
		int_0 = 100;
	}

	public override string ToString()
	{
		return Delegate547.smethod_0(this) switch
		{
			GEnum12.const_0 => "default", 
			GEnum12.const_1 => "on", 
			GEnum12.const_2 => "off", 
			GEnum12.const_3 => Delegate548.smethod_0(this).ToString(CultureInfo.InvariantCulture), 
			_ => "unknown", 
		};
	}

	private int method_0()
	{
		if (Delegate547.smethod_0(this) != GEnum12.const_3)
		{
			throw new InvalidOperationException("Threshold is undefined when state is not Smart");
		}
		return int_0;
	}

	private void method_1(int int_1)
	{
		if (int_0 != int_1)
		{
			if (int_1 <= 0)
			{
				throw new ArgumentOutOfRangeException("threshold", "Threshold must be positive");
			}
			Delegate546.smethod_0(this, GEnum12.const_3);
			int_0 = int_1;
		}
	}
}
