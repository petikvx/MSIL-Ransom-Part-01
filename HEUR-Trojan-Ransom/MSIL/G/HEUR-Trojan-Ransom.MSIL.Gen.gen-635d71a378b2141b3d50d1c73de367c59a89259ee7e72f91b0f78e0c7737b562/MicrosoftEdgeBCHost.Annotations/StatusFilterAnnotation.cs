using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StatusFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceParser()
	{
	}
}
