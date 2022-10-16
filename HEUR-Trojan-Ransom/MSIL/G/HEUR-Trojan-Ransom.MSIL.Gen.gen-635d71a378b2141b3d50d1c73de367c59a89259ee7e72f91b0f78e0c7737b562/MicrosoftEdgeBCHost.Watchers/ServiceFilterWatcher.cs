using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ServiceFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ResetSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetSerializer()
	{
	}
}
