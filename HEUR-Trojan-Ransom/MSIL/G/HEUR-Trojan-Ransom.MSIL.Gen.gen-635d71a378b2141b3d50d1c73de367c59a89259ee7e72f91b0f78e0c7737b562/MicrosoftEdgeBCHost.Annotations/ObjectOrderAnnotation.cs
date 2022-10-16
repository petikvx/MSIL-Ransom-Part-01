using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ObjectOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AssetLiteralFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AssetLiteralFilter()
	{
	}
}
