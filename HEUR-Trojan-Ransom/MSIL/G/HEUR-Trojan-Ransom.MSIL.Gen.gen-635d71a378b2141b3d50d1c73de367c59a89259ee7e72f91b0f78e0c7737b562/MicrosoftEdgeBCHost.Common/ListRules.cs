using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ListRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListRules()
	{
		WriterPropertyProducer.ResolveStub();
		CompareModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareModel()
	{
	}
}
