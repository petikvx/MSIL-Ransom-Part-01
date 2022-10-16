using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class DecoratorReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorReponse()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralValue()
	{
	}
}
