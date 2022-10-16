using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ItemRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemRules()
	{
		WriterPropertyProducer.ResolveStub();
		PrintParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintParameter()
	{
	}
}
