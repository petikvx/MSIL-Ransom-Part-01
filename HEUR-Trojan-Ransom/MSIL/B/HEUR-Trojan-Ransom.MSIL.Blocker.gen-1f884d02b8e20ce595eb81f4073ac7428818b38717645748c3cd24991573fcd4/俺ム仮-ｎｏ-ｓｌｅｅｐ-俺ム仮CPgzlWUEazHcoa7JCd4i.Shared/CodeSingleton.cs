using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Shared;

internal class CodeSingleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeSingleton()
	{
		DicWriterConsumer.ListIndexer();
		RunHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunHelper()
	{
	}
}
