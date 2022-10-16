using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ConfigurationExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralGlobal()
	{
	}
}
