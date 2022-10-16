using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ParserSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyLiteralImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyLiteralImporter()
	{
	}
}
