using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CollectionClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CollectionClass()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceTokenizer()
	{
	}
}
