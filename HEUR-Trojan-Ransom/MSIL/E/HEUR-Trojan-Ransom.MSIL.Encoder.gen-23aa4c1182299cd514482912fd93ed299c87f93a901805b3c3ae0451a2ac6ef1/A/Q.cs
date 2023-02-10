using System;
using System.IO;
using System.Reflection;

namespace A;

internal sealed class Q
{
	private static readonly Assembly m_D;

	static Q()
	{
		AppDomain.CurrentDomain.ResourceResolve += Y;
		AppDomain.CurrentDomain.AssemblyResolve += D;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string assemblyString = D(executingAssembly);
		Q.m_D = Assembly.Load(assemblyString);
	}

	internal static void D()
	{
	}

	private static Assembly D(object P_0, ResolveEventArgs P_1)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string text = D(executingAssembly);
		if (P_1.Name.StartsWith(text))
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
					byte[] rawAssembly = A.D(97L, manifestResourceStream);
					return Assembly.Load(rawAssembly);
				}
				}
			}
		}
		return null;
	}

	private static string D(Assembly P_0)
	{
		string text = P_0.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			while (true)
			{
				switch (6)
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
		return BY.D(text, '&');
	}

	private static Assembly Y(object P_0, ResolveEventArgs P_1)
	{
		if ((object)Q.m_D != null)
		{
			while (true)
			{
				switch (7)
				{
				case 0:
					break;
				default:
				{
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					string[] manifestResourceNames = Q.m_D.GetManifestResourceNames();
					for (int i = 0; i < (int)(nuint)N.D(manifestResourceNames); i++)
					{
						string text = manifestResourceNames[i];
						if (F.D(text, P_1.Name))
						{
							while (true)
							{
								switch (3)
								{
								case 0:
									break;
								default:
									return Q.m_D;
								}
							}
						}
					}
					while (true)
					{
						switch (2)
						{
						case 0:
							break;
						default:
							return null;
						}
					}
				}
				}
			}
		}
		return Q.m_D;
	}
}
