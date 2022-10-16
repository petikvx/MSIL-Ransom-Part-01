using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InitializerValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InitializerValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceCreator()
	{
	}
}
