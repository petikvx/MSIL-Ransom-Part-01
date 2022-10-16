using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TemplateReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateReponse()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralValue()
	{
	}
}
