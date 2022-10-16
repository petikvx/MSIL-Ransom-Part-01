using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ReaderGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfacePage()
	{
	}
}
