using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TokenizerSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		CheckLiteralAlgo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckLiteralAlgo()
	{
	}
}
