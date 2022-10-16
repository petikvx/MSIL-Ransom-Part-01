using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ComposerSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralImporter()
	{
	}
}
