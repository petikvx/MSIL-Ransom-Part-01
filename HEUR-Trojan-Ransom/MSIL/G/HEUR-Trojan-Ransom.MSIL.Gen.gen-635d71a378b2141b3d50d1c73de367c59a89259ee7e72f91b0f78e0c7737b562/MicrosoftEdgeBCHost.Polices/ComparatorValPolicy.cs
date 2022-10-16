using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ComparatorValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectList()
	{
	}
}
