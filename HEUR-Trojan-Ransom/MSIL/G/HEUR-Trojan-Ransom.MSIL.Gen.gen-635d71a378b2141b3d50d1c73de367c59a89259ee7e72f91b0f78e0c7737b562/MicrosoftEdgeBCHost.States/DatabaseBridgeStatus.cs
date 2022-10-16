using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DatabaseBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InsertSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertSystem()
	{
	}
}
