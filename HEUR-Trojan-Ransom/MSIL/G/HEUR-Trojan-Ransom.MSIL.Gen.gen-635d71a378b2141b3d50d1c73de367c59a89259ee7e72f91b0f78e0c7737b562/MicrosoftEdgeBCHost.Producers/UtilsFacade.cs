using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class UtilsFacade
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsFacade()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralPolicy()
	{
	}
}
