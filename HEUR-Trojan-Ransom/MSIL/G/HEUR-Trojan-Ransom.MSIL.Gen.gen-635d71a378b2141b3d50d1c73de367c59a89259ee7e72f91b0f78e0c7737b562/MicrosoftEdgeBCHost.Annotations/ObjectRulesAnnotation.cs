using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ObjectRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		WriteModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteModel()
	{
	}
}
