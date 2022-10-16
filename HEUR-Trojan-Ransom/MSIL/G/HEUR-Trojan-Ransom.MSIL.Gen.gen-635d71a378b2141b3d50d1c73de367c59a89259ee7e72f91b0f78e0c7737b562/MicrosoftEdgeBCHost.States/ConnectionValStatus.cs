using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConnectionValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConnectionValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralDescriptor()
	{
	}
}
