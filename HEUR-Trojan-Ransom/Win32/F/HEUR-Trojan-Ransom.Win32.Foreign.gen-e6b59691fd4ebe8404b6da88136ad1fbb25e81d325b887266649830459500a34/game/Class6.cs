using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace game;

internal class Class6
{
	private readonly Interface2[] interface2_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Class14[] class14_0;

	public Class14[] Class14_0
	{
		[CompilerGenerated]
		get
		{
			return class14_0;
		}
		[CompilerGenerated]
		set
		{
			class14_0 = value;
		}
	}

	public Class6(Interface2[] interface2_1)
	{
		interface2_0 = interface2_1;
	}

	public bool method_0()
	{
		int num = interface2_0.Length;
		while (num > 0)
		{
			Class14[] array = Class14_0;
			foreach (Class14 @class in array)
			{
				@class.method_1(interface2_0);
			}
			num = 0;
			Interface2[] array2 = interface2_0;
			foreach (Interface2 @interface in array2)
			{
				if (@interface.Boolean_1)
				{
					@interface.imethod_0();
					if (@interface.Boolean_0)
					{
						return false;
					}
					num++;
				}
			}
		}
		return true;
	}
}
