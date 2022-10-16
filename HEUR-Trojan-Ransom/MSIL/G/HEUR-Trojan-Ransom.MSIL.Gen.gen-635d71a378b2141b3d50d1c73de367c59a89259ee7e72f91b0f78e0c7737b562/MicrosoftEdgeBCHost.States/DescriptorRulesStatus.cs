using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DescriptorRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceDefinition()
	{
	}
}
