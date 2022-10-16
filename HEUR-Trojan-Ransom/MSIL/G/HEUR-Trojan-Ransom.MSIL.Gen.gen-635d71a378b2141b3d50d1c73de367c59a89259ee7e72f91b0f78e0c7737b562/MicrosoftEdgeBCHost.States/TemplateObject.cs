using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TemplateObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateObject()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptLiteralCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptLiteralCandidate()
	{
	}
}
