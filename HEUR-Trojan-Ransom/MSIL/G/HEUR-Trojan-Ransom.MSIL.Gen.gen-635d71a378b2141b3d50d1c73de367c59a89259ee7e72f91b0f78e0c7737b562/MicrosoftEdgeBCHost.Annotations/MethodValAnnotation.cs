using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MethodValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralConnection()
	{
	}
}
