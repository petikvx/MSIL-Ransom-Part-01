using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class UtilsOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceThread()
	{
	}
}
