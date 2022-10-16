using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SingletonPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		NewInterfaceInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewInterfaceInvocation()
	{
	}
}
