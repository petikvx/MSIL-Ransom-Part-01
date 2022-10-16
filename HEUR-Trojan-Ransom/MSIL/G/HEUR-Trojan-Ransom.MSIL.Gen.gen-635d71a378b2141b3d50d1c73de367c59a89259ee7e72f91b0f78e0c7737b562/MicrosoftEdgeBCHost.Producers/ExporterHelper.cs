using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ExporterHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterHelper()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralReg()
	{
	}
}
