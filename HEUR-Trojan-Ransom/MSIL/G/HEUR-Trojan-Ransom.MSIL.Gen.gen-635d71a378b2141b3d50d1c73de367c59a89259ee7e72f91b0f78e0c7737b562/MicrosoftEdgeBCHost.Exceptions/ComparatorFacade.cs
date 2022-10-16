using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ComparatorFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorFacade()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralItem()
	{
	}
}
