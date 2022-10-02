using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Bridges;

internal class AttributeSingleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeSingleton()
	{
		DicWriterConsumer.ListIndexer();
		DisableSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableSetter()
	{
	}
}
