using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InitializerFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceField()
	{
	}
}
