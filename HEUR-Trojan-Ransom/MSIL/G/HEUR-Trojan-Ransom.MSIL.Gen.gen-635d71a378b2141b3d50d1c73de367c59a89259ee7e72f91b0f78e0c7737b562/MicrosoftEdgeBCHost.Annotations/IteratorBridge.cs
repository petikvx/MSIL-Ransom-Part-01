using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IteratorBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorBridge()
	{
		WriterPropertyProducer.ResolveStub();
		CheckResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckResolver()
	{
	}
}
