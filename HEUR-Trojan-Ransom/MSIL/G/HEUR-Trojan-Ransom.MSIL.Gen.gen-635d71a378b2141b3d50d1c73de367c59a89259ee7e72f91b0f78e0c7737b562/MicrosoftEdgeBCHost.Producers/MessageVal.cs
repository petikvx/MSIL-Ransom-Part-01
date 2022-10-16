using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MessageVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageVal()
	{
		WriterPropertyProducer.ResolveStub();
		InsertUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertUtils()
	{
	}
}
