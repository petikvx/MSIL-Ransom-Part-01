using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ServiceFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SetInterfaceObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetInterfaceObserver()
	{
	}
}
