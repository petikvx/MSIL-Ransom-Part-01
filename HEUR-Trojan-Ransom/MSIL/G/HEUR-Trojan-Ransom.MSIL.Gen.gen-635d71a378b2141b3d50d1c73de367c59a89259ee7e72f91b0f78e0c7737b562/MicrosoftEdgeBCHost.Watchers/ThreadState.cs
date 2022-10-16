using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ThreadState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadState()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateInterfacePrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateInterfacePrinter()
	{
	}
}
