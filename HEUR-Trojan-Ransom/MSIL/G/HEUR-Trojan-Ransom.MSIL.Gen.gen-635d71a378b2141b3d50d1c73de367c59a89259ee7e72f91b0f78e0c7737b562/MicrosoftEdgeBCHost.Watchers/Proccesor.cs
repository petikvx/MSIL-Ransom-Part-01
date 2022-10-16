using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class Proccesor
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Proccesor()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeMapping()
	{
	}
}
