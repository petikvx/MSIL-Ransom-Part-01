using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ErrorValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorValDic()
	{
		WriterPropertyProducer.ResolveStub();
		GetLiteralMock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetLiteralMock()
	{
	}
}
