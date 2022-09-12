using System;
using System.IO;
using System.Reflection;

namespace ExciteRAN;

internal class AddinSerializer
{
	private static readonly Assembly windowPosition;

	static AddinSerializer()
	{
		AppDomain.CurrentDomain.ResourceResolve += EnableForm;
		AppDomain.CurrentDomain.AssemblyResolve += RegisterNode;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string assemblyString = SortCommand(executingAssembly);
		windowPosition = Assembly.Load(assemblyString);
	}

	internal static void CheckContext()
	{
	}

	private static Assembly RegisterNode(object windowPosition, ResolveEventArgs parentLog)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string text = SortCommand(executingAssembly);
		if (parentLog.Name.StartsWith(text))
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
					byte[] rawAssembly = StreamTree.SaveFile(97L, manifestResourceStream);
					return Assembly.Load(rawAssembly);
				}
				}
			}
		}
		return null;
	}

	private static string SortCommand(Assembly windowPosition)
	{
		string text = windowPosition.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			while (true)
			{
				switch (7)
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
		return SymbolHelper.CleanAssistant(text, '&');
	}

	private static Assembly EnableForm(object windowPosition, ResolveEventArgs parentLog)
	{
		if ((object)AddinSerializer.windowPosition != null)
		{
			while (true)
			{
				switch (2)
				{
				case 0:
					break;
				default:
				{
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					string[] manifestResourceNames = AddinSerializer.windowPosition.GetManifestResourceNames();
					for (int i = 0; i < (int)(nuint)GroupSet.CleanAssistant(manifestResourceNames); i++)
					{
						string text = manifestResourceNames[i];
						if (PackageTable.CleanAssistant(text, parentLog.Name))
						{
							while (true)
							{
								switch (4)
								{
								case 0:
									break;
								default:
									return AddinSerializer.windowPosition;
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
		return AddinSerializer.windowPosition;
	}
}
