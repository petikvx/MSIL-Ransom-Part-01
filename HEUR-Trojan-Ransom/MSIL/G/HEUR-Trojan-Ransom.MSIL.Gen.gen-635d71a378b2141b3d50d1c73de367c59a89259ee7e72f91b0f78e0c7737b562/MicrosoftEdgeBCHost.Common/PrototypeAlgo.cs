using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PrototypeAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralDefinition()
	{
	}
}
