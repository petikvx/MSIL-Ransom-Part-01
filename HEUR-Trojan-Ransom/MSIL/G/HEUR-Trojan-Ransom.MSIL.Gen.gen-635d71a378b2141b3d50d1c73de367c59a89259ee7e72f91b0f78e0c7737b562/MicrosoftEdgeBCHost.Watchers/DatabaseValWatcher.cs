using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DatabaseValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DatabaseValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceConfig()
	{
	}
}
