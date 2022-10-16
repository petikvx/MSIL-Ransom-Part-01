using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ComparatorPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralDispatcher()
	{
	}
}
