using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Shared;

internal class WatcherSingleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherSingleton()
	{
		DicWriterConsumer.ListIndexer();
		FillVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillVisitor()
	{
	}
}
