using System.Runtime.CompilerServices;
using ns22;

namespace ns13;

internal abstract class Class87
{
	public delegate object Delegate1(byte[] bytes);

	[CompilerGenerated]
	private Class47 class47_0;

	[CompilerGenerated]
	private uint uint_0;

	[CompilerGenerated]
	private uint uint_1;

	public Delegate1 delegate1_0;

	public Class47 Column
	{
		[CompilerGenerated]
		get
		{
			return class47_0;
		}
		[CompilerGenerated]
		set
		{
			class47_0 = value;
		}
	}

	public uint Flags
	{
		[CompilerGenerated]
		get
		{
			return uint_0;
		}
		[CompilerGenerated]
		set
		{
			uint_0 = value;
		}
	}

	public uint ContentType
	{
		[CompilerGenerated]
		get
		{
			return uint_1;
		}
		[CompilerGenerated]
		set
		{
			uint_1 = value;
		}
	}

	public abstract void vmethod_0();
}
