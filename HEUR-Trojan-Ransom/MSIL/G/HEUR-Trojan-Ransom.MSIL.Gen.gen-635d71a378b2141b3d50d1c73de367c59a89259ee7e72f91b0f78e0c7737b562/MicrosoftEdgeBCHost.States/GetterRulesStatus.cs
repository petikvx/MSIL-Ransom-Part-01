using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class GetterRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceParameter()
	{
	}
}
