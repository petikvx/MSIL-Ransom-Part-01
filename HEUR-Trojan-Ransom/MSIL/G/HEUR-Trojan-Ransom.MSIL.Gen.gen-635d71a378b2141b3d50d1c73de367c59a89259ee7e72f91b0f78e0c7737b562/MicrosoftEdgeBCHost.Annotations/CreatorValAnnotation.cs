using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CreatorValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceContainer()
	{
	}
}
