using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MapperBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterCreator()
	{
	}
}
