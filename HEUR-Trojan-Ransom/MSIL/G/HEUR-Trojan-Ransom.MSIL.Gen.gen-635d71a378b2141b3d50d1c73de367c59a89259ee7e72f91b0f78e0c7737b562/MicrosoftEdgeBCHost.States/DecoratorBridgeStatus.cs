using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DecoratorBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteAdvisor()
	{
	}
}
