using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InterceptorFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		NewReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewReader()
	{
	}
}
