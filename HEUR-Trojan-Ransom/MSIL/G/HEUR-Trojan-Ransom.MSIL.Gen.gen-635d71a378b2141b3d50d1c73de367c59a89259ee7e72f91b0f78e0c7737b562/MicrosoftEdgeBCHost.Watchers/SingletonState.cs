using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SingletonState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonState()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceProperty()
	{
	}
}
