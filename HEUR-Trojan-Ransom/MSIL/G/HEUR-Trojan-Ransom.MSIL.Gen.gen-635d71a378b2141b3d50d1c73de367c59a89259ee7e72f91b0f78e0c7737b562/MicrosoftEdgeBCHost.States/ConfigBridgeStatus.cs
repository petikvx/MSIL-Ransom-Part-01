using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConfigBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeSchema()
	{
	}
}
