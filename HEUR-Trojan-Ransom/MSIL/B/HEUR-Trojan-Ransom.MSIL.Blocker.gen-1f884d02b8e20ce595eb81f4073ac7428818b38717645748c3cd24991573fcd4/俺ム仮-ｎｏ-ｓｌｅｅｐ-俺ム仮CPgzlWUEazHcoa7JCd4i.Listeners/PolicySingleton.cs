using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Listeners;

internal class PolicySingleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PolicySingleton()
	{
		DicWriterConsumer.ListIndexer();
		ResolveConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveConsumer()
	{
	}
}
