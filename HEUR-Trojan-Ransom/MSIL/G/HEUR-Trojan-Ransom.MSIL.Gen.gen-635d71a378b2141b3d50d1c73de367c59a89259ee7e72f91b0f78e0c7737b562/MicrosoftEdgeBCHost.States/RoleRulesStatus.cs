using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RoleRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfacePrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfacePrinter()
	{
	}
}
