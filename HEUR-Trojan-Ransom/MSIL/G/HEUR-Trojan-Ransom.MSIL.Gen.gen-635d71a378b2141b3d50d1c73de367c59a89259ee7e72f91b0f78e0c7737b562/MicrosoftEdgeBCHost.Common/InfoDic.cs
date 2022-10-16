using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InfoDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoDic()
	{
		WriterPropertyProducer.ResolveStub();
		AddLiteralProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddLiteralProcess()
	{
	}
}
