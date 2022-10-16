using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DicValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceInterpreter()
	{
	}
}
