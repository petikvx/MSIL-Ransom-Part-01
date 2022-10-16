using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DatabaseOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseOrder()
	{
		WriterPropertyProducer.ResolveStub();
		FindConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindConsumer()
	{
	}
}
