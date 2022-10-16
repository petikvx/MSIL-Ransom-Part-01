using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ParamExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralMap()
	{
	}
}
