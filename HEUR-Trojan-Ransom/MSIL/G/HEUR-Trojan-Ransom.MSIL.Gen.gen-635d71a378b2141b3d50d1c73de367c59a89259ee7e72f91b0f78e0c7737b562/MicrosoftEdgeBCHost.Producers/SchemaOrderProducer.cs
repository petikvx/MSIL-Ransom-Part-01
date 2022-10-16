using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SchemaOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceThread()
	{
	}
}
