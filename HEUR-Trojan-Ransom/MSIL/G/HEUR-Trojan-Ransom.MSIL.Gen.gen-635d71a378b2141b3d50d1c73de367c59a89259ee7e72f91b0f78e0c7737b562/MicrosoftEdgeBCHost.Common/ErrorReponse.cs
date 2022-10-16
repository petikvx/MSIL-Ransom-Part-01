using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ErrorReponse
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ErrorReponse()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceProc()
	{
	}
}
