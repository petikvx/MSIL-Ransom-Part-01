using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace 俺ム仮_0020ｎｏ_3000ｓｌｅｅｐ_3000俺ム仮CPgzlWUEazHcoa7JCd4i.Authentication;

internal class GlobalResolver
{
	internal static ModuleHandle tokenResolver;

	internal static object RevertAdvisableTag;

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeTypeHandle CancelAdvisableReader(int token)
	{
		//Discarded unreachable code: IL_0002
		return tokenResolver.GetRuntimeTypeHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static RuntimeFieldHandle ForgotAdvisableReader(int token)
	{
		//Discarded unreachable code: IL_0002
		return tokenResolver.GetRuntimeFieldHandleFromMetadataToken(token);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public GlobalResolver()
	{
	}//Discarded unreachable code: IL_0002


	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalResolver()
	{
		//Discarded unreachable code: IL_0002
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					break;
				}
				tokenResolver = CollectAdvisableReader(((object[])AddAdvisableReader(CalculateAdvisableReader(typeof(GlobalResolver).TypeHandle).Assembly))[0]);
				num2 = 0;
			}
			while (0 == 0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool EnableAdvisableReader()
	{
		//Discarded unreachable code: IL_0002
		return RevertAdvisableTag == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static GlobalResolver MapAdvisableReader()
	{
		//Discarded unreachable code: IL_0002
		return (GlobalResolver)RevertAdvisableTag;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static Type CalculateAdvisableReader(RuntimeTypeHandle P_0)
	{
		//Discarded unreachable code: IL_0002
		return Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static object AddAdvisableReader(object P_0)
	{
		//Discarded unreachable code: IL_0002
		return ((Assembly)P_0).GetModules();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static ModuleHandle CollectAdvisableReader(object P_0)
	{
		//Discarded unreachable code: IL_0002
		return ((Module)P_0).ModuleHandle;
	}
}
