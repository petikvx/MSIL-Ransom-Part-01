using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BaseFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceSystem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceSystem()
	{
	}
}
