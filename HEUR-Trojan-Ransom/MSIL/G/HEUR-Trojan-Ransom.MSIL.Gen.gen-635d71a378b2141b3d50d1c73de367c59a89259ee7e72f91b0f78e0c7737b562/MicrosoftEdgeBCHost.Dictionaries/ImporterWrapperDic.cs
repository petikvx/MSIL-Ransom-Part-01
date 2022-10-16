using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ImporterWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatProperty()
	{
	}
}
