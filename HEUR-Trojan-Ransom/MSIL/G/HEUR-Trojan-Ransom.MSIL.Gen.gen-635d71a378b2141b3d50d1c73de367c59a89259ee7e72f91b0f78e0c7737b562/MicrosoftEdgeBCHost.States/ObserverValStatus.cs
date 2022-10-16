using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ObserverValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralConfiguration()
	{
	}
}
