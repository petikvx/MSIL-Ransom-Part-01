using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ProcessGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceStrategy()
	{
	}
}
