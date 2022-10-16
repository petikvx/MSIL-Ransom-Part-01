using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AnnotationWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		LoginAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginAttr()
	{
	}
}
