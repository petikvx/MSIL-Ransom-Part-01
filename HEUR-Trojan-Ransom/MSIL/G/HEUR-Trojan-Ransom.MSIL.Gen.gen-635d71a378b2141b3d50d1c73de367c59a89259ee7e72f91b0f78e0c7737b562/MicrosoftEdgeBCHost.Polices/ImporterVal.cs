using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ImporterVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterVal()
	{
		WriterPropertyProducer.ResolveStub();
		RateRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateRequest()
	{
	}
}
