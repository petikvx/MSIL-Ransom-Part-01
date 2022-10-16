using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PropertyBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectExporter()
	{
	}
}
