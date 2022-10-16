using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DispatcherFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DispatcherFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceDatabase()
	{
	}
}
