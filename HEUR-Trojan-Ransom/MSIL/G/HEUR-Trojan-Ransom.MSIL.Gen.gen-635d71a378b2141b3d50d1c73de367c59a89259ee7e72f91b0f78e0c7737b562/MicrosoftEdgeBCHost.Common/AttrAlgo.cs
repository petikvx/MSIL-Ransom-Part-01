using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AttrAlgo
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrAlgo()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralException()
	{
	}
}
