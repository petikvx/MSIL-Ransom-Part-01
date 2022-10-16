using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RequestDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestDic()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterLiteralRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterLiteralRepository()
	{
	}
}
