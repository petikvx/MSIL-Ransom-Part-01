using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TokenRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		AssetInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetInterfaceProccesor()
	{
	}
}
