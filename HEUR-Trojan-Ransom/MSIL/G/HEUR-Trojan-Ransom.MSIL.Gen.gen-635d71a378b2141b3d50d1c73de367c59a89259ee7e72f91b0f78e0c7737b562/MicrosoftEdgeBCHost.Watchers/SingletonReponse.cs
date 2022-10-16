using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class SingletonReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonReponse()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareLiteralIssuer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareLiteralIssuer()
	{
	}
}
