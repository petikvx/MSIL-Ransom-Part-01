using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SerializerAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		MoveLiteralResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveLiteralResolver()
	{
	}
}
