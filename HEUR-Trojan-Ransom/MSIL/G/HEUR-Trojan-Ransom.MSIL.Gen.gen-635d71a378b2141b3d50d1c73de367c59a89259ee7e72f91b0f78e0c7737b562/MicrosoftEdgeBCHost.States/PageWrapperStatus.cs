using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PageWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateEvent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateEvent()
	{
	}
}
