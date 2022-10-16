using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RoleOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceDefinition()
	{
	}
}
