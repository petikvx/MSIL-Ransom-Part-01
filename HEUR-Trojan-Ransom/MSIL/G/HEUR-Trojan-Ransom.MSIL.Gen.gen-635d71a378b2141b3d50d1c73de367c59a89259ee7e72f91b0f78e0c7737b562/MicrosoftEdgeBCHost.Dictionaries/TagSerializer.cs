using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TagSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		SelectLiteralImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectLiteralImporter()
	{
	}
}
