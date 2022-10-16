using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RegistryRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceDecorator()
	{
	}
}
