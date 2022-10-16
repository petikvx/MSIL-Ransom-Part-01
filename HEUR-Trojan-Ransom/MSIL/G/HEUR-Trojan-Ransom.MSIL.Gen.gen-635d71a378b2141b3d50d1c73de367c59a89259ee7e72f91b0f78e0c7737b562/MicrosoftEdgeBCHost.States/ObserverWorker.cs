using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ObserverWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverWorker()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeCreator()
	{
	}
}
