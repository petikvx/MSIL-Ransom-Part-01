using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SingletonBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonBridge()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateResolver()
	{
	}
}
