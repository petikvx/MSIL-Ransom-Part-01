using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class HelperFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperFilter()
	{
		WriterPropertyProducer.ResolveStub();
		InsertComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertComposer()
	{
	}
}
