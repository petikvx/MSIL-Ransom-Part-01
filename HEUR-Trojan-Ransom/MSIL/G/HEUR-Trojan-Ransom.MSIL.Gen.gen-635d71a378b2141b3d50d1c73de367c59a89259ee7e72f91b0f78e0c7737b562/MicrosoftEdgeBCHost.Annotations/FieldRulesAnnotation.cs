using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FieldRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptDatabase()
	{
	}
}
