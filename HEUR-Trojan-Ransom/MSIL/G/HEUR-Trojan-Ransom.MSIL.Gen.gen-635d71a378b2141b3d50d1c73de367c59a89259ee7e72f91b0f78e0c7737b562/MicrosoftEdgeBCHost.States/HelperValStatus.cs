using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class HelperValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectLiteralBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectLiteralBridge()
	{
	}
}
