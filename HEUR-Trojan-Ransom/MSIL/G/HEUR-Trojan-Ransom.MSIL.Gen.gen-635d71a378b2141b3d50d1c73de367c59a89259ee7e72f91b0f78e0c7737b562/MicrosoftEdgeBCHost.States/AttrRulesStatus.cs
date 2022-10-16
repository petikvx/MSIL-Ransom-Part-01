using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttrRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteInterfaceServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteInterfaceServer()
	{
	}
}
