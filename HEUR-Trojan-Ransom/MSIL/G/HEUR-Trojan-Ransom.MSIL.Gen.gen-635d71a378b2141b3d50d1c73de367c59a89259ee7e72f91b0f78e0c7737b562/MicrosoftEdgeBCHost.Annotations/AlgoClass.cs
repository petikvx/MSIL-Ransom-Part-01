using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AlgoClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoClass()
	{
		WriterPropertyProducer.ResolveStub();
		EnableInterfaceSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableInterfaceSerializer()
	{
	}
}
