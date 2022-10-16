using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ExporterValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterValException()
	{
		WriterPropertyProducer.ResolveStub();
		SortCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortCollection()
	{
	}
}
