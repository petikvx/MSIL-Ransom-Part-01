using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DefinitionUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceMapper()
	{
	}
}
