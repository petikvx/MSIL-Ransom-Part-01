using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Bridges;

internal class ServiceSingletonBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceSingletonBridge()
	{
		DicWriterConsumer.ListIndexer();
		CloneAdvisableGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneAdvisableGetter()
	{
	}
}
