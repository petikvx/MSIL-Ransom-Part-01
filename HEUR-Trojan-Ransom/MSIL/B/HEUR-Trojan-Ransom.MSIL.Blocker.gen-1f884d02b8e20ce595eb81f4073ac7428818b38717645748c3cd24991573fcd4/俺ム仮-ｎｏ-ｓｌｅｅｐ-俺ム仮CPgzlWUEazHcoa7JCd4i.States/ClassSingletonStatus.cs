using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.States;

internal class ClassSingletonStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassSingletonStatus()
	{
		DicWriterConsumer.ListIndexer();
		DeleteContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteContainer()
	{
	}
}
