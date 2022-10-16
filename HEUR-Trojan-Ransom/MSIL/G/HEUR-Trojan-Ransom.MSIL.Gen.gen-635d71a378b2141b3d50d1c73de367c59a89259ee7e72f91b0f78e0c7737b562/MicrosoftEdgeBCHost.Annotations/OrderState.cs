using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class OrderState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderState()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceStatus()
	{
	}
}
