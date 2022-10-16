using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ResolverWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RunEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunEvent()
	{
	}
}
