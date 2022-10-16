using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CustomerFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceRule()
	{
	}
}
