using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ClassBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SetMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetMapper()
	{
	}
}
