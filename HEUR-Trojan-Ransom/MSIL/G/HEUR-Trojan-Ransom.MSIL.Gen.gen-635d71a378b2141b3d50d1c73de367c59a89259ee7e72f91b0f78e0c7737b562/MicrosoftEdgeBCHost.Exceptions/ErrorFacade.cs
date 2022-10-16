using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ErrorFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorFacade()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralRegistry()
	{
	}
}
