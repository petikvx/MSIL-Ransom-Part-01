using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ListenerWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceContext()
	{
	}
}
