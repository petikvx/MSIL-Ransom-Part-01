using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ResolverPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceCreator()
	{
	}
}
