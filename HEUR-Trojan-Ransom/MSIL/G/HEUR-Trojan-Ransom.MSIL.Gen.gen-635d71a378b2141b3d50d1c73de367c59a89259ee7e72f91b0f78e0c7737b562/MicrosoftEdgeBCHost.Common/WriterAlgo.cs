using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class WriterAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralDefinition()
	{
	}
}
