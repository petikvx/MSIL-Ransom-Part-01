using System;
using System.IO;
using System.Reflection;

namespace ExciteRAN;

internal sealed class GroupScope
{
	private static readonly Assembly lastHandler;

	static GroupScope()
	{
		FunctionList.SaveNetwork(DriveResolver.SaveNetwork(), OrderPane);
		DeploymentDictionary.SaveNetwork(DriveResolver.SaveNetwork(), ResolveMenuItem);
		Assembly assembly = TreeNodeList.SaveNetwork();
		string text = ChangeEditor(assembly);
		lastHandler = ToolbarToken.SaveNetwork(text);
	}

	internal static void SaveNetwork()
	{
	}

	private static Assembly ResolveMenuItem(object P_0, ResolveEventArgs P_1)
	{
		Assembly assembly = TreeNodeList.SaveNetwork();
		string text = ChangeEditor(assembly);
		if (StreamQueue.SaveNetwork(TreeNodeEditor.SaveNetwork(P_1), text))
		{
			while (true)
			{
				switch (3)
				{
				case 0:
					break;
				default:
				{
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					Stream stream = ServerSet.SaveNetwork(assembly, text);
					byte[] array = PcitureStack.InsertProcess(97L, stream);
					return VectorStream.SaveNetwork(array);
				}
				}
			}
		}
		return null;
	}

	private static string ChangeEditor(Assembly P_0)
	{
		string text = ImageInvoker.SaveNetwork(P_0);
		int num = PageAttribute.SaveNetwork(text, ',');
		if (num >= 0)
		{
			while (true)
			{
				switch (2)
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
			text = DirectoryList.SaveNetwork(text, 0, num);
		}
		return DeploymentSet.SaveNetwork(text, '&');
	}

	private static Assembly OrderPane(object P_0, ResolveEventArgs P_1)
	{
		if ((object)lastHandler != null)
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
					string[] array = NodeFactory.SaveNetwork(lastHandler);
					for (int i = 0; i < (int)(nuint)ComponentService.ResolveFile(array); i++)
					{
						string text = array[i];
						if (XmlFileInvoker.SaveNetwork(text, TreeNodeEditor.SaveNetwork(P_1)))
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									break;
								default:
									return lastHandler;
								}
							}
						}
					}
					while (true)
					{
						switch (3)
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
		return lastHandler;
	}
}
