using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ComparatorDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorDic()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralAnnotation()
	{
	}
}
