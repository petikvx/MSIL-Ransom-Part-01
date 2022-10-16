using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SingletonFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveContext()
	{
	}
}
