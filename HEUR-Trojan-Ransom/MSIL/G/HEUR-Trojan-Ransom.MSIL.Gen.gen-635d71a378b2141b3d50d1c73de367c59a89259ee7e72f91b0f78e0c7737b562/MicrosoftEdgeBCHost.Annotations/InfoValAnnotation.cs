using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InfoValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PrintInterfaceAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintInterfaceAdvisor()
	{
	}
}
