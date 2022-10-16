using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InvocationFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralAttribute()
	{
	}
}
