using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConfigFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceRepository()
	{
	}
}
