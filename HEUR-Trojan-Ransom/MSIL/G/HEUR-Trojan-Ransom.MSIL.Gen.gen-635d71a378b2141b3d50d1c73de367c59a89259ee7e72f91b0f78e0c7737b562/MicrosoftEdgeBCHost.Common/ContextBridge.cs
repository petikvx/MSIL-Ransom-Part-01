using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ContextBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextBridge()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeExporter()
	{
	}
}
