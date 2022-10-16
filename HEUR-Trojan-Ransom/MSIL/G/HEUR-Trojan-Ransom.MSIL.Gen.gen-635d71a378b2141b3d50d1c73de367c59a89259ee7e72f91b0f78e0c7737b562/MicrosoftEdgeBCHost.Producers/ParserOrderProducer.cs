using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ParserOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceTokenizer()
	{
	}
}
