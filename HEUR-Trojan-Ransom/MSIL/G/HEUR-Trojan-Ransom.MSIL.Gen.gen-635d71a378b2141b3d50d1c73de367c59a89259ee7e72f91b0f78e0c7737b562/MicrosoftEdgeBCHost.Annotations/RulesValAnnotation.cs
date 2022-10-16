using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RulesValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterfaceExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterfaceExpression()
	{
	}
}
