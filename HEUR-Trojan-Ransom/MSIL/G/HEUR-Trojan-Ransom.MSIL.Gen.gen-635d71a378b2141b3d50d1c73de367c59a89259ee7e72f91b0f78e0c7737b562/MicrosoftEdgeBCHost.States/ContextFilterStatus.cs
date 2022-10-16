using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ContextFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceConfig()
	{
	}
}
