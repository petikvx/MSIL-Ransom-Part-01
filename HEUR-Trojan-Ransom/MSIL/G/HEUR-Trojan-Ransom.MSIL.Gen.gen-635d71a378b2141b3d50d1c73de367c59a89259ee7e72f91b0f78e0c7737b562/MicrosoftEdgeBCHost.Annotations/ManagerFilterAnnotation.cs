using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ManagerFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterfaceParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterfaceParameter()
	{
	}
}
