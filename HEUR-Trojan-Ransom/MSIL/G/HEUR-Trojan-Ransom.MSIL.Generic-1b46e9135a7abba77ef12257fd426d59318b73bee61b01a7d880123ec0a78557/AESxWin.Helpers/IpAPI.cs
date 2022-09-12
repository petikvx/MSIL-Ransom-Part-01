using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using A6yJVNZuoAn9NC1LAS;

namespace AESxWin.Helpers;

public static class IpAPI
{
	private static int CurrentIndex = 0;

	public static Uri[] Urls = new Uri[2]
	{
		new Uri(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2240)),
		new Uri(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2244))
	};

	[MethodImpl(MethodImplOptions.NoInlining)]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetIP_003Ed__2))]
	public static Task<string> GetIP()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		_003CGetIP_003Ed__2 stateMachine = new _003CGetIP_003Ed__2();
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<string>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<string> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return true;
	}

	internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return false;
	}
}
