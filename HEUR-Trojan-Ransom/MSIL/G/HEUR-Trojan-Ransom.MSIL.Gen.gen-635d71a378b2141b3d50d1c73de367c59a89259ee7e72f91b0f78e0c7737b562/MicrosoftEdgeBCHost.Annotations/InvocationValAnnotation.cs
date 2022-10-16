using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InvocationValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceList()
	{
	}
}
