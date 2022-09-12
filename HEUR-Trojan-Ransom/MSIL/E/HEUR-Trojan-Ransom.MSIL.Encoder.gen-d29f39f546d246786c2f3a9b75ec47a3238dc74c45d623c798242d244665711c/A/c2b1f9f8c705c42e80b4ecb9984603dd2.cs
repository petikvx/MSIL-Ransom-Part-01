using System;
using System.IO;
using System.Reflection;

namespace A;

internal class c2b1f9f8c705c42e80b4ecb9984603dd2
{
	private static readonly Assembly c1af9f518663e133c2d3838a3c5d5b8ab;

	static c2b1f9f8c705c42e80b4ecb9984603dd2()
	{
		AppDomain.CurrentDomain.ResourceResolve += c0354feb41a98daaec36071dce4e08b95;
		AppDomain.CurrentDomain.AssemblyResolve += cab5c6d4bf53919b85b292c9a28a72cea;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string assemblyString = c640a6e71fa63749a4f02fbb2aaff9e4f(executingAssembly);
		c1af9f518663e133c2d3838a3c5d5b8ab = Assembly.Load(assemblyString);
	}

	internal static void ca1cae331549d9250b7a08eccc61a4a54()
	{
	}

	private static Assembly cab5c6d4bf53919b85b292c9a28a72cea(object ca3353db7d39906fc0420773e6c311dcd, ResolveEventArgs c44f977d788c4f168ab906807551bfce7)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string text = c640a6e71fa63749a4f02fbb2aaff9e4f(executingAssembly);
		if (c44f977d788c4f168ab906807551bfce7.Name.StartsWith(text))
		{
			while (true)
			{
				switch (6)
				{
				case 0:
					break;
				default:
				{
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text);
					byte[] rawAssembly = cc9dfbf4f37872fe06f4c3ae05af251a4.c6bca594a22afe7a66845ccfe2e37d922(97L, manifestResourceStream);
					return Assembly.Load(rawAssembly);
				}
				}
			}
		}
		return null;
	}

	private static string c640a6e71fa63749a4f02fbb2aaff9e4f(Assembly c0bc0f2f4e9ad4e0120feeb1a571038c8)
	{
		string text = c0bc0f2f4e9ad4e0120feeb1a571038c8.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			while (true)
			{
				switch (1)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			text = text.Substring(0, num);
		}
		return c2d249bd1032b4521cc6e7b2214283cf3.ce775d48dedba78815b868ddfefd91c56(text, '&');
	}

	private static Assembly c0354feb41a98daaec36071dce4e08b95(object ca3353db7d39906fc0420773e6c311dcd, ResolveEventArgs c44f977d788c4f168ab906807551bfce7)
	{
		if ((object)c1af9f518663e133c2d3838a3c5d5b8ab != null)
		{
			while (true)
			{
				switch (5)
				{
				case 0:
					break;
				default:
				{
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					string[] manifestResourceNames = c1af9f518663e133c2d3838a3c5d5b8ab.GetManifestResourceNames();
					for (int i = 0; i < (int)(nuint)cb00efdeef0091cd4922c68d40fb28e96.c8d798c339232c1b6b575ebd272b15269(manifestResourceNames); i++)
					{
						string cae378af460ca66e363ba38b380c = manifestResourceNames[i];
						if (c0cb8a234e4b1e12371f831766735a152.ce775d48dedba78815b868ddfefd91c56(cae378af460ca66e363ba38b380c, c44f977d788c4f168ab906807551bfce7.Name))
						{
							while (true)
							{
								switch (6)
								{
								case 0:
									break;
								default:
									return c1af9f518663e133c2d3838a3c5d5b8ab;
								}
							}
						}
					}
					return null;
				}
				}
			}
		}
		return c1af9f518663e133c2d3838a3c5d5b8ab;
	}
}
