using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RequestFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceRepository()
	{
	}
}
