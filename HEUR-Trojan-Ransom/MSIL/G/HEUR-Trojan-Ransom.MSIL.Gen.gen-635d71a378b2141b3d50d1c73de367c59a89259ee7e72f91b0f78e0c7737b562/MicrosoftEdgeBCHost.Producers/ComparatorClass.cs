using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ComparatorClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorClass()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfacePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfacePool()
	{
	}
}
