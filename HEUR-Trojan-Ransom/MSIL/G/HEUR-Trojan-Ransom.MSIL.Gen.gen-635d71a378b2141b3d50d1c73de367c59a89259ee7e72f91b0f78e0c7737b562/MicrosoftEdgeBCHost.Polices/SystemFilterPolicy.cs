using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SystemFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SystemFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		NewIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewIndexer()
	{
	}
}
