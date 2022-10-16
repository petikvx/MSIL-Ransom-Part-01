using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DicContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicContext()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfacePublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfacePublisher()
	{
	}
}
