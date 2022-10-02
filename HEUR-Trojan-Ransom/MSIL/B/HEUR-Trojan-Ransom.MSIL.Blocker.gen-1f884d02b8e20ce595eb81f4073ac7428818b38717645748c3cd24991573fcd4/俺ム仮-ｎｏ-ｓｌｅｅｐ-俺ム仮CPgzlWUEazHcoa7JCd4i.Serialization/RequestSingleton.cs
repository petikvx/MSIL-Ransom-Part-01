using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Serialization;

internal class RequestSingleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestSingleton()
	{
		DicWriterConsumer.ListIndexer();
		PrepareField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareField()
	{
	}
}
