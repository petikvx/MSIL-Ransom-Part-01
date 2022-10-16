using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class FacadeValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeValDic()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralConfig()
	{
	}
}
