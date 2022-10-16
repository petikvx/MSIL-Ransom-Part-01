using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConsumerFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerFacade()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralBase()
	{
	}
}
