using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RefReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefReponse()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralValue()
	{
	}
}
