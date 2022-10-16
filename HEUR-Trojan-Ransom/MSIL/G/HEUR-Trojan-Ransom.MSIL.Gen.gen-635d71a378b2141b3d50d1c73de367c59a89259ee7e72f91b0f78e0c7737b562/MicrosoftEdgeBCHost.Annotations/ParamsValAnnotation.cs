using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParamsValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceStub()
	{
	}
}
