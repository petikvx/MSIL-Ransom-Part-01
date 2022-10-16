using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class TokenizerOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceUtils()
	{
	}
}
