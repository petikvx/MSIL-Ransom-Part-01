using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RoleServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleServer()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralUtils()
	{
	}
}
