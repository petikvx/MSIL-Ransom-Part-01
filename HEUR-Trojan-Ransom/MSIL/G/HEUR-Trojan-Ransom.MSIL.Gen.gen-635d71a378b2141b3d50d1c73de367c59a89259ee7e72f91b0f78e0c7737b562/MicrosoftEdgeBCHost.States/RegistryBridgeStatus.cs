using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RegistryBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ReadSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadSchema()
	{
	}
}
