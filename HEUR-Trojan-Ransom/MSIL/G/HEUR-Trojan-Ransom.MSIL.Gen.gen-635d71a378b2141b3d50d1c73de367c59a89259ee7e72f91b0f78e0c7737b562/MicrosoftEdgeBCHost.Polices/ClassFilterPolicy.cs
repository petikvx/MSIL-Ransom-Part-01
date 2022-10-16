using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ClassFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		DisableGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableGetter()
	{
	}
}
