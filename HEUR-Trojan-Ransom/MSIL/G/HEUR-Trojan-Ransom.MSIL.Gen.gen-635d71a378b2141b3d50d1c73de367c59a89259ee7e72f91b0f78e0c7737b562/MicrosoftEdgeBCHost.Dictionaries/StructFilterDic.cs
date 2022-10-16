using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StructFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralAttribute()
	{
	}
}
