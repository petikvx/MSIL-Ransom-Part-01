using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ObjectValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralComposer()
	{
	}
}
