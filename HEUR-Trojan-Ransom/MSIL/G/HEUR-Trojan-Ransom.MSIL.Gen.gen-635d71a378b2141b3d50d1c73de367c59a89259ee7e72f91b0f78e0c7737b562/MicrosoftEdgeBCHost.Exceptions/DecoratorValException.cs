using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DecoratorValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorValException()
	{
		WriterPropertyProducer.ResolveStub();
		SortAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortAdapter()
	{
	}
}
