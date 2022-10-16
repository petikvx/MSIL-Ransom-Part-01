using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ComparatorPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralClass()
	{
	}
}
