using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ThreadBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		WriteGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteGetter()
	{
	}
}
