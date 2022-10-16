using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CreatorFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceProccesor()
	{
	}
}
