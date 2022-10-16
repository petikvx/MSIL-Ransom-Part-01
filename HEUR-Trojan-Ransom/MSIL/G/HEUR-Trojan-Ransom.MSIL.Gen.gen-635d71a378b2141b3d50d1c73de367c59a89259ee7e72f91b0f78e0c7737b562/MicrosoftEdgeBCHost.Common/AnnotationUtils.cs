using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AnnotationUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationUtils()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceAttr();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceAttr()
	{
	}
}
