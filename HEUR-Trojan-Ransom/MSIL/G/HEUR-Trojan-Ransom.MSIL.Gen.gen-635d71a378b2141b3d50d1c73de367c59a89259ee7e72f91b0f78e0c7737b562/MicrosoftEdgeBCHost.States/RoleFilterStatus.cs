using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RoleFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceItem();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceItem()
	{
	}
}
