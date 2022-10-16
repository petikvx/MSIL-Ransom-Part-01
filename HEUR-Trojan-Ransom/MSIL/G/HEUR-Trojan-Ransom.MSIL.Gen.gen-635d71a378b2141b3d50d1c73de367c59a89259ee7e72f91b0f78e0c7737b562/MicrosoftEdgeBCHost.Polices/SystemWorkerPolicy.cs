using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SystemWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeInterfaceConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeInterfaceConfig()
	{
	}
}
