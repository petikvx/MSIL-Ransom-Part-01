using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProccesorFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceRegistry()
	{
	}
}
