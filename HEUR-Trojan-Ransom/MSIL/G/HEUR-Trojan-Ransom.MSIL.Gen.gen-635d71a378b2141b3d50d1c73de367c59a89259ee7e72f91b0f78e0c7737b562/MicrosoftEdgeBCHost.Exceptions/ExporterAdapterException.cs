using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExporterAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralState()
	{
	}
}
