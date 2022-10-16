using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AttrRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrRules()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatPrinter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatPrinter()
	{
	}
}
