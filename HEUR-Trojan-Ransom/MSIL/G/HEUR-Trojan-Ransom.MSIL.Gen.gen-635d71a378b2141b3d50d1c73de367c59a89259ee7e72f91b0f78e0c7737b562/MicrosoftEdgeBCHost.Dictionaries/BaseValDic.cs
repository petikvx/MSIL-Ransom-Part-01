using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class BaseValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralInfo()
	{
	}
}
