using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParamsBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		FillFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillFilter()
	{
	}
}
