using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class VisitorFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralInstance()
	{
	}
}
