using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ObjectWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralAttribute();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralAttribute()
	{
	}
}
