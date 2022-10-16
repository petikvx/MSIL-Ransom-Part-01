using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AnnotationFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralError()
	{
	}
}
