using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TagRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceVal()
	{
	}
}
