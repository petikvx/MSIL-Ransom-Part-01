using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SetterWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceValue()
	{
	}
}
