using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MappingDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingDic()
	{
		WriterPropertyProducer.ResolveStub();
		CancelLiteralCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CancelLiteralCallback()
	{
	}
}
