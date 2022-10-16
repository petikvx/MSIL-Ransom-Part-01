using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ItemValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemValDic()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralInterceptor()
	{
	}
}
