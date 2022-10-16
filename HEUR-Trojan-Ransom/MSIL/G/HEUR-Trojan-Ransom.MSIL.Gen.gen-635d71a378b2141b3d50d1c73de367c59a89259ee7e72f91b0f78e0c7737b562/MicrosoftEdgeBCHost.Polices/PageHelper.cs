using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class PageHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageHelper()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralPool()
	{
	}
}
