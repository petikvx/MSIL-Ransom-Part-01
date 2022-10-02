using System.Runtime.CompilerServices;
using 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Consumers;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Messages;

internal class PublisherSingletonMessage
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherSingletonMessage()
	{
		DicWriterConsumer.ListIndexer();
		CheckDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckDefinition()
	{
	}
}
