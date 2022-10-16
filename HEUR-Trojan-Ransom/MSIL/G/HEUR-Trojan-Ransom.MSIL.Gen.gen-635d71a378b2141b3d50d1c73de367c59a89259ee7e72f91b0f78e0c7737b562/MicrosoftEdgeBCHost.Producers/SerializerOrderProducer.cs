using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SerializerOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceContext()
	{
	}
}
