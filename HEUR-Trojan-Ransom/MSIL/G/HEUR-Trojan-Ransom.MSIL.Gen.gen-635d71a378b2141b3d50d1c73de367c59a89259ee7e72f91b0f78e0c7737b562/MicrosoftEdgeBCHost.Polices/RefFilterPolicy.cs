using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RefFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CreateWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateWatcher()
	{
	}
}
