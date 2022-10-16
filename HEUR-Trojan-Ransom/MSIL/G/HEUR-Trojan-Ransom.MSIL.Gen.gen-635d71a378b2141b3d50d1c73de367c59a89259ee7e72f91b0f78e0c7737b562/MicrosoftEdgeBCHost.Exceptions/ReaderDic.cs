using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ReaderDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralToken()
	{
	}
}
