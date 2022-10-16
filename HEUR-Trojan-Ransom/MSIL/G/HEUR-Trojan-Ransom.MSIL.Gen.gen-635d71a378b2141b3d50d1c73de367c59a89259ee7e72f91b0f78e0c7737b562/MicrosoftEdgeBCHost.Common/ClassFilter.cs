using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ClassFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassFilter()
	{
		WriterPropertyProducer.ResolveStub();
		SelectTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectTemplate()
	{
	}
}
