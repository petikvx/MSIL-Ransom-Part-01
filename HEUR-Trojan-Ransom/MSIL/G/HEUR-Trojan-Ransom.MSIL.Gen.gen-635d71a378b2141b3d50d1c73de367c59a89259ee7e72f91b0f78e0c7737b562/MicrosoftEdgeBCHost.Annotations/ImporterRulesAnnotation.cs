using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ImporterRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CheckDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckDatabase()
	{
	}
}
