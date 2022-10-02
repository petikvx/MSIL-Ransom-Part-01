using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Factories;

internal class ThreadSingleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadSingleton()
	{
		DicWriterConsumer.ListIndexer();
		RemoveClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveClass()
	{
	}
}
