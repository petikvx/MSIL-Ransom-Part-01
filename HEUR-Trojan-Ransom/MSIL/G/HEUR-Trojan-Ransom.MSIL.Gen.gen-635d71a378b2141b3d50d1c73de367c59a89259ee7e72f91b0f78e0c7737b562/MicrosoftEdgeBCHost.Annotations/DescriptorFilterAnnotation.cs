using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DescriptorFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		WriteInterfaceParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteInterfaceParam()
	{
	}
}
