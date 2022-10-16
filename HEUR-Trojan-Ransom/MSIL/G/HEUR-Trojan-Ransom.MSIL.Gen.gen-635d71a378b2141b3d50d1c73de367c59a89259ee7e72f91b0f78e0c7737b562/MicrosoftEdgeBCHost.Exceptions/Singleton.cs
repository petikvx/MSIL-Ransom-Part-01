using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class Singleton
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Singleton()
	{
		WriterPropertyProducer.ResolveStub();
		NewGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewGetter()
	{
	}
}
