using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConfigWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfaceParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfaceParams()
	{
	}
}
