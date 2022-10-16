using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RecordClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordClass()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfacePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfacePool()
	{
	}
}
