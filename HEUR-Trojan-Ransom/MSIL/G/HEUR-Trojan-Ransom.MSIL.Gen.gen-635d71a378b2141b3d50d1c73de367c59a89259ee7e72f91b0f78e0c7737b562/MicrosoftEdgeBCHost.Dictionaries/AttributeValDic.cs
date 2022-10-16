using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AttributeValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralInterceptor()
	{
	}
}
