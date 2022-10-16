using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ServerFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceMock()
	{
	}
}
