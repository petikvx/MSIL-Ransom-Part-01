using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ItemValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralConfig()
	{
	}
}
