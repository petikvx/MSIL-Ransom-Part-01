using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CodeWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceValue()
	{
	}
}
