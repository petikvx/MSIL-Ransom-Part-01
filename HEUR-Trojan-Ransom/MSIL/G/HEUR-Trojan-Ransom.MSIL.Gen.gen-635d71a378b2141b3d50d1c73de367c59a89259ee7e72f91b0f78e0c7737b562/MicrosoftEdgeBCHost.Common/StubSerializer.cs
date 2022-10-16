using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class StubSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralIdentifier()
	{
	}
}
