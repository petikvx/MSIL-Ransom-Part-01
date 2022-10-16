using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InstanceRulesStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceRulesStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ManageInterfaceIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageInterfaceIdentifier()
	{
	}
}
