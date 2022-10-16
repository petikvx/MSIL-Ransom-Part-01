using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TemplateValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralAuthentication()
	{
	}
}
