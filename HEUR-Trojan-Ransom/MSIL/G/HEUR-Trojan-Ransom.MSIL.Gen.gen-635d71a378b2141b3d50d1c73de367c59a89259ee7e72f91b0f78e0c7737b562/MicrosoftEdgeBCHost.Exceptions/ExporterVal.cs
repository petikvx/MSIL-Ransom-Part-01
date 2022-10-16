using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExporterVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterVal()
	{
		WriterPropertyProducer.ResolveStub();
		CountRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountRepository()
	{
	}
}
