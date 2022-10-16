using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SingletonWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfacePublisher()
	{
	}
}
