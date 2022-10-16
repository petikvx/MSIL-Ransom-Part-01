using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StatusFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceRequest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceRequest()
	{
	}
}
