using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FieldOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceMap()
	{
	}
}
