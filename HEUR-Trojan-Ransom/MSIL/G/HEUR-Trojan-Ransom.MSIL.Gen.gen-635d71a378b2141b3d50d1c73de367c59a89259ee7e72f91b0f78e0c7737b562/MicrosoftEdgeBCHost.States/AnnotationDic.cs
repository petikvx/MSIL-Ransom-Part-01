using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AnnotationDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationDic()
	{
		WriterPropertyProducer.ResolveStub();
		DefineLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineLiteralInfo()
	{
	}
}
