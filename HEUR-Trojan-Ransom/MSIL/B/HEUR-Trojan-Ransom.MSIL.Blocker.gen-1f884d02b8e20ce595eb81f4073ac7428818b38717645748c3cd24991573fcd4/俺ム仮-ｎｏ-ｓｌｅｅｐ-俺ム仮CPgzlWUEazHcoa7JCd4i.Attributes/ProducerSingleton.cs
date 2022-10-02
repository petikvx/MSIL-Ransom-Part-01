using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Attributes;

internal class ProducerSingleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerSingleton()
	{
		DicWriterConsumer.ListIndexer();
		CalculateInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInvocation()
	{
	}
}
