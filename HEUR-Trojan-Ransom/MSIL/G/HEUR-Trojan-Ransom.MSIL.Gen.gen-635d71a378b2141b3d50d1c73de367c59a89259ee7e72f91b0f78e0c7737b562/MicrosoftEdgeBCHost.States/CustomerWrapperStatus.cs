using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CustomerWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RevertMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertMapping()
	{
	}
}
