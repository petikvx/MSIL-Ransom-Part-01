using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ExporterValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterValDic()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralInterceptor()
	{
	}
}
