using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RulesOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralAccount();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralAccount()
	{
	}
}
