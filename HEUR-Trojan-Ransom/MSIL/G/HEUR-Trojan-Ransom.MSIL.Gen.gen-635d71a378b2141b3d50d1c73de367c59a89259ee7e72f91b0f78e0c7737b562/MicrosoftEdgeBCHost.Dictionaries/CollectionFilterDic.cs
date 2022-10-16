using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CollectionFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralManager();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralManager()
	{
	}
}
