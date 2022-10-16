using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AttrSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralProccesor()
	{
	}
}
