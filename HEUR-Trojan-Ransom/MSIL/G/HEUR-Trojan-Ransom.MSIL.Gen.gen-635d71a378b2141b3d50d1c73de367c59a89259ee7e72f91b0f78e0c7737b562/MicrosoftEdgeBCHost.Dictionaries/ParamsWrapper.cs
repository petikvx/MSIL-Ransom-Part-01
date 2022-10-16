using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParamsWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CalcAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcAttribute()
	{
	}
}
