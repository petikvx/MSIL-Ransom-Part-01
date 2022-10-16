using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SchemaClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaClass()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceStruct()
	{
	}
}
