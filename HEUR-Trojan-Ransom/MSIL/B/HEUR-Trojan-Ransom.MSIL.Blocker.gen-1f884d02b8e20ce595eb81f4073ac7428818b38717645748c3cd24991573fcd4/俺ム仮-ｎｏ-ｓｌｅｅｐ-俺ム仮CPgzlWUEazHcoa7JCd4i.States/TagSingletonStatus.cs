using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.States;

internal class TagSingletonStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagSingletonStatus()
	{
		DicWriterConsumer.ListIndexer();
		PostInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInstance()
	{
	}
}
