using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttributeRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfacePage()
	{
	}
}
