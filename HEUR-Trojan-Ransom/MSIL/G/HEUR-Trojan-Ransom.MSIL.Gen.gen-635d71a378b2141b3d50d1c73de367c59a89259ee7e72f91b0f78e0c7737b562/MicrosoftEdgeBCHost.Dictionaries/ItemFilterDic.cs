using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ItemFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralProperty()
	{
	}
}
