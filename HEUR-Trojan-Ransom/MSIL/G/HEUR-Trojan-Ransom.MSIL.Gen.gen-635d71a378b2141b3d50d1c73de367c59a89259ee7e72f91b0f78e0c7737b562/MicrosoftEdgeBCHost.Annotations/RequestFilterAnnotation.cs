using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RequestFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterfaceGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterfaceGlobal()
	{
	}
}
