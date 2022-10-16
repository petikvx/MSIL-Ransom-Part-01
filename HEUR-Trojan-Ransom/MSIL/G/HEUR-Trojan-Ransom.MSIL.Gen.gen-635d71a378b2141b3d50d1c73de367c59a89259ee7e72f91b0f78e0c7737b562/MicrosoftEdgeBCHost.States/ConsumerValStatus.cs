using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConsumerValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralStatus()
	{
	}
}
