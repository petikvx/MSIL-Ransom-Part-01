using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConfigurationFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfacePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfacePool()
	{
	}
}
