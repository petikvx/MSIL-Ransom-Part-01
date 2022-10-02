using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Composer;

internal class ProcessSingleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessSingleton()
	{
		DicWriterConsumer.ListIndexer();
		ViewCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewCreator()
	{
	}
}
