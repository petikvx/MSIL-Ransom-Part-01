using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProcFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceObject()
	{
	}
}
