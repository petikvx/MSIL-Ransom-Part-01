using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AttrWrapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrWrapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeRef();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeRef()
	{
	}
}
