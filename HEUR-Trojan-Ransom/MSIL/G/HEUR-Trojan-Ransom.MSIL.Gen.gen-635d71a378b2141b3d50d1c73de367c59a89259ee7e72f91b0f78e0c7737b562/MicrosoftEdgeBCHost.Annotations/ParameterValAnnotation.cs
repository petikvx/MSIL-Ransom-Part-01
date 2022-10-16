using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParameterValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralConnection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralConnection()
	{
	}
}
