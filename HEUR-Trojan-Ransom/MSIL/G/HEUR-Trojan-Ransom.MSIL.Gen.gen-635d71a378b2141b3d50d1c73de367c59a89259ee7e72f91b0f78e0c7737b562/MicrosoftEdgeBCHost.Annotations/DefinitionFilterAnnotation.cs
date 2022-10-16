using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DefinitionFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfaceAttr()
	{
	}
}
