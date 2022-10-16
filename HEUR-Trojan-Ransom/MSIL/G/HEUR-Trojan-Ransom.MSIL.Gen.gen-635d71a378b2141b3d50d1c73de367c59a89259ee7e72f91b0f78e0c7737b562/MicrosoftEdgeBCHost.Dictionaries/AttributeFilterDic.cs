using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AttributeFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralProxy()
	{
	}
}
