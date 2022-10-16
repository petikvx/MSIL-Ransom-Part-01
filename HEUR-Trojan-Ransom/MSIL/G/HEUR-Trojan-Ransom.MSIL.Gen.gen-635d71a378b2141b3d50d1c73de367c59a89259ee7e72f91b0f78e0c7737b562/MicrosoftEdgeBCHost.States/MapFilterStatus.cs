using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MapFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceSingleton()
	{
	}
}
