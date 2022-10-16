using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MapperSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralDic()
	{
	}
}
