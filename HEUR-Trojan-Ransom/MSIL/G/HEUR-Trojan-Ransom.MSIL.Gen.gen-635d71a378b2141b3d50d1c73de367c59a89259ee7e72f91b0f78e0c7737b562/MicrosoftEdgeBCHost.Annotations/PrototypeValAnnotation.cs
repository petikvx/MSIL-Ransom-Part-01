using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PrototypeValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PrototypeValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceField()
	{
	}
}
