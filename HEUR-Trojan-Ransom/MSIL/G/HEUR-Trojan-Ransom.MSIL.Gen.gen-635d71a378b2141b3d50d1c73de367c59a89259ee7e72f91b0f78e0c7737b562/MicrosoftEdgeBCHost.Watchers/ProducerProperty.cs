using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProducerProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProducerProperty()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceDic()
	{
	}
}
