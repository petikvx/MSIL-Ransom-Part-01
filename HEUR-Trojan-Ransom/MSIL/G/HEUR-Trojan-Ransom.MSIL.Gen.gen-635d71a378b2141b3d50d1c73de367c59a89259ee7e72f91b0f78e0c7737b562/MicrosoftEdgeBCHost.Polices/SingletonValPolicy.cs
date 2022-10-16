using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SingletonValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceWorker()
	{
	}
}
