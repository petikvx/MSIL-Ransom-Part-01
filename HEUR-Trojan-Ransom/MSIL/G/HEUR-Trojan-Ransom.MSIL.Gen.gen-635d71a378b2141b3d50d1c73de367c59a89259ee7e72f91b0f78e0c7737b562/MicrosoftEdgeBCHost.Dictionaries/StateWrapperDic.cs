using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StateWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StateWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatProccesor()
	{
	}
}
