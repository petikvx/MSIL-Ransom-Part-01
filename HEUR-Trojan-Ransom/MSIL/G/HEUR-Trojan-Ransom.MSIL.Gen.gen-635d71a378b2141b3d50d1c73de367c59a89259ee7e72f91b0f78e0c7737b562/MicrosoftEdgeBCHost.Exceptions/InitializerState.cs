using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class InitializerState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerState()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceDispatcher()
	{
	}
}
