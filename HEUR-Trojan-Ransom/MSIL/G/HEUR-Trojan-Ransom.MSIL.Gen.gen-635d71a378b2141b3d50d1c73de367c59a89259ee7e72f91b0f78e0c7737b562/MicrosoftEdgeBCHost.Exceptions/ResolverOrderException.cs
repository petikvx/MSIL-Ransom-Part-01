using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ResolverOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceDispatcher()
	{
	}
}
