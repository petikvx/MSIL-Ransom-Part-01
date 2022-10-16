using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConfigWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralAdvisor()
	{
	}
}
