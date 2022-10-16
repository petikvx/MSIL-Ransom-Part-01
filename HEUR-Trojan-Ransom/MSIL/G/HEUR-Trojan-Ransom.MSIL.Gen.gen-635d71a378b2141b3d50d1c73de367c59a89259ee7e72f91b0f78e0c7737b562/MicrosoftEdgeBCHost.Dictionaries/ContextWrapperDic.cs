using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ContextWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		InsertProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertProccesor()
	{
	}
}
