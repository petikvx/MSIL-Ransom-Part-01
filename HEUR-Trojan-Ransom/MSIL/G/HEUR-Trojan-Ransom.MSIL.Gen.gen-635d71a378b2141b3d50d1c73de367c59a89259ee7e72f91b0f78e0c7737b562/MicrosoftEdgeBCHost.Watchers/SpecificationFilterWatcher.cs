using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SpecificationFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PublishAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishAccount()
	{
	}
}
