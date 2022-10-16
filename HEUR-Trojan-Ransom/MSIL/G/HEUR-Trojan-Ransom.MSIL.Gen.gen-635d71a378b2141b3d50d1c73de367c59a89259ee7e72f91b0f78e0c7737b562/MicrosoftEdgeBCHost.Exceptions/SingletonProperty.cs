using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SingletonProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonProperty()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceState()
	{
	}
}
