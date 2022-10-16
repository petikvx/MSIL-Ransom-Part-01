using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AdapterContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterContext()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeInterfaceWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeInterfaceWatcher()
	{
	}
}
