using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DefinitionHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionHelper()
	{
		WriterPropertyProducer.ResolveStub();
		ListLiteralList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListLiteralList()
	{
	}
}
