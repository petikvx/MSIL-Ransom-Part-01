using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SingletonWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonWorker()
	{
		WriterPropertyProducer.ResolveStub();
		PushCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushCreator()
	{
	}
}
