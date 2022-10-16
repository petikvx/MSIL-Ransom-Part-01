using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InterceptorFilterDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterceptorFilterDic()
	{
		WriterPropertyProducer.ResolveStub();
		PublishLiteralDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishLiteralDescriptor()
	{
	}
}
