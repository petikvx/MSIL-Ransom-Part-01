using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ExceptionOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralPolicy()
	{
	}
}
