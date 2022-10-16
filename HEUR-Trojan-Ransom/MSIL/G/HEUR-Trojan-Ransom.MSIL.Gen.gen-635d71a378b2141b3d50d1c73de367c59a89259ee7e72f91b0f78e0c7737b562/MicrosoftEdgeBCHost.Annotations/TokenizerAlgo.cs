using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TokenizerAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralMessage()
	{
	}
}
