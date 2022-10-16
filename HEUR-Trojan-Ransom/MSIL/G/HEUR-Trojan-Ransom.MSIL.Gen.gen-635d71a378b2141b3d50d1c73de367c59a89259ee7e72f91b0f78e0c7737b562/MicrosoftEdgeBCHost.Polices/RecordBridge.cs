using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RecordBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordBridge()
	{
		WriterPropertyProducer.ResolveStub();
		CollectGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectGlobal()
	{
	}
}
