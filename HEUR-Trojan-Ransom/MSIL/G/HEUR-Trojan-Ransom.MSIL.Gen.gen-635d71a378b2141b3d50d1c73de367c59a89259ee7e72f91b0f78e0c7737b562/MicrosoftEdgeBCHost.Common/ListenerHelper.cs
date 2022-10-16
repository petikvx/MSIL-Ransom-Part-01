using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ListenerHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerHelper()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralList()
	{
	}
}
