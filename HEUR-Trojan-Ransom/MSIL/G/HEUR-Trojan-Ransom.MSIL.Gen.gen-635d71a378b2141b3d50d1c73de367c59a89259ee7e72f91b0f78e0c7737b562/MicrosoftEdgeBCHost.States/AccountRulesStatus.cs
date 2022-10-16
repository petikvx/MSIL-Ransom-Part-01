using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AccountRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceAdapter()
	{
	}
}
