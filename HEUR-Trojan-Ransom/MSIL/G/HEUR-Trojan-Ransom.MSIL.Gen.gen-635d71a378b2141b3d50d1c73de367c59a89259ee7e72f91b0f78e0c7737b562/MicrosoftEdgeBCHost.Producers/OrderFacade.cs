using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class OrderFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static OrderFacade()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralPolicy()
	{
	}
}
