using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MessageOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralRegistry()
	{
	}
}
