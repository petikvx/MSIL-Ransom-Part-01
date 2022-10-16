using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PredicateOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceContext()
	{
	}
}
