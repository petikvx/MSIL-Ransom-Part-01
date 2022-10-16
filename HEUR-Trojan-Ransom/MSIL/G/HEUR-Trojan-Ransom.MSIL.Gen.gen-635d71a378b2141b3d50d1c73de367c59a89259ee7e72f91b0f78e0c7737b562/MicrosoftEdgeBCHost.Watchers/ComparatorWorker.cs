using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ComparatorWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorWorker()
	{
		WriterPropertyProducer.ResolveStub();
		CloneAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneAccount()
	{
	}
}
