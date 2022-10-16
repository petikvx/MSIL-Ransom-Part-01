using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RefRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefRules()
	{
		WriterPropertyProducer.ResolveStub();
		AssetParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetParams()
	{
	}
}
