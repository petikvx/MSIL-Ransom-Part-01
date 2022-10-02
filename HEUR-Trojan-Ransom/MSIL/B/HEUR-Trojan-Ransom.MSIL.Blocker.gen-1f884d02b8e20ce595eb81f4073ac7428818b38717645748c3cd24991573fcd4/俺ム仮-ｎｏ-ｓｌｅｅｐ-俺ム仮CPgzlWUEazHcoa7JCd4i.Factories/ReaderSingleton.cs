using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Factories;

internal class ReaderSingleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderSingleton()
	{
		DicWriterConsumer.ListIndexer();
		VerifyClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyClass()
	{
	}
}
