using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DispatcherClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherClass()
	{
		WriterPropertyProducer.ResolveStub();
		QueryInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryInterfaceObserver()
	{
	}
}
