using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TemplateHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateHelper()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralObserver()
	{
	}
}
