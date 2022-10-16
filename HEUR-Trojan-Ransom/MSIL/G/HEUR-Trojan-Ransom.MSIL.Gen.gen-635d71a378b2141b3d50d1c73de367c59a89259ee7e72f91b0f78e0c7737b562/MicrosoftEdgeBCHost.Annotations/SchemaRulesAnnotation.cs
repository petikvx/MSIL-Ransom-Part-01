using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SchemaRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeHelper()
	{
	}
}
