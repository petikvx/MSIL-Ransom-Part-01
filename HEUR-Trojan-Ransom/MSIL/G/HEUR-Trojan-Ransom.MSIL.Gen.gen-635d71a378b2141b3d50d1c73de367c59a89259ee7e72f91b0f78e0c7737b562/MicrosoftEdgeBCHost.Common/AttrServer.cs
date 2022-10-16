using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AttrServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrServer()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralFacade()
	{
	}
}
