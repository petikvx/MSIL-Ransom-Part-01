using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PublisherRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherRules()
	{
		WriterPropertyProducer.ResolveStub();
		InsertPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertPrinter()
	{
	}
}
