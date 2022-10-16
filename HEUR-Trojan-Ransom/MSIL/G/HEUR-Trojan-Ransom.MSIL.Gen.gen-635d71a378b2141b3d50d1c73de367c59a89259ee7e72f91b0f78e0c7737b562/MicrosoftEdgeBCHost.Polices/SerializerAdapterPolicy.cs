using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SerializerAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CollectLiteralParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectLiteralParam()
	{
	}
}
