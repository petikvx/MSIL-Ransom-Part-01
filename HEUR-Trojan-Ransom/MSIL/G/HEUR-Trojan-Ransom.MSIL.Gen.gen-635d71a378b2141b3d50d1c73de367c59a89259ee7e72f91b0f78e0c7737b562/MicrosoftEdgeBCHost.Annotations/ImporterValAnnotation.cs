using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ImporterValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ImporterValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DefineInterfaceThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineInterfaceThread()
	{
	}
}
