using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InstanceFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceSingleton()
	{
	}
}
