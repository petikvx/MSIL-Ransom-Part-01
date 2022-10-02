using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Attributes;

internal class SingletonAttributeAttribute
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonAttributeAttribute()
	{
		DicWriterConsumer.ListIndexer();
		QueryAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryAdvisor()
	{
	}
}
