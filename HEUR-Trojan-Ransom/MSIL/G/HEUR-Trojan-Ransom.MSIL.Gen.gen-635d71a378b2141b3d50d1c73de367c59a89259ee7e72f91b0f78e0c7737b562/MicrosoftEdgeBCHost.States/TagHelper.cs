using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TagHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagHelper()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveLiteralFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveLiteralFilter()
	{
	}
}
