using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ItemHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemHelper()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralReg()
	{
	}
}
