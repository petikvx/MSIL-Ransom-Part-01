using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Authentication;

internal class SingletonService
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonService()
	{
		DicWriterConsumer.ListIndexer();
		ForgotStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotStrategy()
	{
	}
}
