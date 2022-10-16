using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RoleBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InsertSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertSetter()
	{
	}
}
