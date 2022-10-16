using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class SchemaBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceError()
	{
	}
}
