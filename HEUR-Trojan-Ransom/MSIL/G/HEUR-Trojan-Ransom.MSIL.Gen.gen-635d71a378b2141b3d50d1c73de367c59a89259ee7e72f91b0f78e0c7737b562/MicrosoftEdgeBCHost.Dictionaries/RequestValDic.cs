using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RequestValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralContainer()
	{
	}
}
