using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InitializerRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceSetter()
	{
	}
}
