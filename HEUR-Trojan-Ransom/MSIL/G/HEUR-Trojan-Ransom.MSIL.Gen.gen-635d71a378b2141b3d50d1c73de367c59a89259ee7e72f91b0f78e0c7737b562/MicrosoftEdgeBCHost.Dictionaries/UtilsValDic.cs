using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class UtilsValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsValDic()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralSchema()
	{
	}
}
