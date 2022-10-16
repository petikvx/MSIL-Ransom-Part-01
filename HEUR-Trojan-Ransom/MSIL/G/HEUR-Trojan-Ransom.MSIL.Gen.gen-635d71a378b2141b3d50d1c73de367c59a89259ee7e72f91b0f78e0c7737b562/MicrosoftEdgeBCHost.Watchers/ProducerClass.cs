using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProducerClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerClass()
	{
		WriterPropertyProducer.ResolveStub();
		InsertInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertInterfaceStruct()
	{
	}
}
