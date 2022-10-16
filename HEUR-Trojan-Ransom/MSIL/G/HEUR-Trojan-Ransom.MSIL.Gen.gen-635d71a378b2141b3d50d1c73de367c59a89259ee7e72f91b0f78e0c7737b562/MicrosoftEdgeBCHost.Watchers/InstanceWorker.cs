using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InstanceWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceWorker()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeAccount()
	{
	}
}
