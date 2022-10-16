using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FieldValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldValDic()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralProcess()
	{
	}
}
