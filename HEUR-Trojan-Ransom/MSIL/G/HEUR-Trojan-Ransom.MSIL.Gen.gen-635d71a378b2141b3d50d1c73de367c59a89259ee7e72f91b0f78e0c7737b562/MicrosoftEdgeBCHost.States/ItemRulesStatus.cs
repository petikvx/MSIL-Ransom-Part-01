using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ItemRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceParameter()
	{
	}
}
