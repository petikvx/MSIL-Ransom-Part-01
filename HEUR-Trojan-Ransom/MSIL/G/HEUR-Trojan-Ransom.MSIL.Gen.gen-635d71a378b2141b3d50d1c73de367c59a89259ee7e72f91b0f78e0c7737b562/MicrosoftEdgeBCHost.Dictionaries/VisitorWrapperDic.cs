using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class VisitorWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		QueryAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryAttr()
	{
	}
}
