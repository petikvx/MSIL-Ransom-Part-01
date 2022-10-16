using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParamRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceServer()
	{
	}
}
