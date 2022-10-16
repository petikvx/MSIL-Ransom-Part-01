using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ConfigExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveLiteralExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveLiteralExporter()
	{
	}
}
