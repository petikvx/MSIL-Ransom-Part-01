using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TokenPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralBase()
	{
	}
}
