using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SchemaBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
