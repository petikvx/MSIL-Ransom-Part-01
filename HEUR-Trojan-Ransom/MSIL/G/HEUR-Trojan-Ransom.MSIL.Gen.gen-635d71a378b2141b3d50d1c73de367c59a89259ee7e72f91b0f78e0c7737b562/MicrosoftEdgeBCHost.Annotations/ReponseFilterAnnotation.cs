using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ReponseFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReponseFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceError()
	{
	}
}
