using System.Runtime.CompilerServices;
using ns21;
using ns7;

namespace ns19;

internal abstract class Class58<T, U> : Class56<U> where T : Class38 where U : Class48
{
	[CompilerGenerated]
	private T gparam_0;

	public T Target
	{
		[CompilerGenerated]
		get
		{
			return gparam_0;
		}
		[CompilerGenerated]
		private set
		{
			gparam_0 = value;
		}
	}

	public Class58(T gparam_1)
		: base(gparam_1.Schema.Session)
	{
		Target = gparam_1;
	}
}
