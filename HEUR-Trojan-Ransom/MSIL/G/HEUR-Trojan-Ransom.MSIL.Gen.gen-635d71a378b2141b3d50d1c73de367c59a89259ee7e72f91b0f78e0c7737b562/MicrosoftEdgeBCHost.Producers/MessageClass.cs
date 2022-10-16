using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MessageClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageClass()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceTokenizer()
	{
	}
}
