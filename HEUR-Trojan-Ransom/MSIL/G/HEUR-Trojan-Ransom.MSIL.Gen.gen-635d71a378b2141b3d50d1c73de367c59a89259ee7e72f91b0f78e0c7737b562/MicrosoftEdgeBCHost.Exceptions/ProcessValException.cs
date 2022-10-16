using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProcessValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessValException()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectDic();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectDic()
	{
	}
}
