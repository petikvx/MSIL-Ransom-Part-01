using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProcWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		RestartParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartParser()
	{
	}
}
