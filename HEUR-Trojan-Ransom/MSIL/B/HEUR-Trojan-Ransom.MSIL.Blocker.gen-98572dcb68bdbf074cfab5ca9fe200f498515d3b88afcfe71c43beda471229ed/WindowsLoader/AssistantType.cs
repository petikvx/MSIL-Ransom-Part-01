using System;
using System.IO;
using System.Reflection;

namespace WindowsLoader;

internal class AssistantType
{
	private static readonly Assembly idEnabled;

	static AssistantType()
	{
		XmlFileManager.RemovePane(AssistantAttribute.RemovePane(), Open);
		ActivityDesigner.RemovePane(AssistantAttribute.RemovePane(), RemovePane);
		Assembly assembly = Window.RemovePane();
		string text = RemovePane(assembly);
		idEnabled = CommandStack.RemovePane(text);
	}

	internal static void RemovePane()
	{
	}

	private static Assembly RemovePane(object idEnabled, ResolveEventArgs nextUri)
	{
		Assembly assembly = Window.RemovePane();
		string nextUri2 = RemovePane(assembly);
		if (FileService.RemovePane(PcitureType.RemovePane(nextUri), nextUri2))
		{
			while (true)
			{
				switch (1)
				{
				case 0:
					break;
				default:
				{
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					Stream nextUri3 = TemplateSite.RemovePane(assembly, nextUri2);
					byte[] array = VectorStack.RemovePane(97L, nextUri3);
					return CommandQueue.RemovePane(array);
				}
				}
			}
		}
		return null;
	}

	private static string RemovePane(Assembly idEnabled)
	{
		string text = StoreTree.RemovePane(idEnabled);
		int num = NetworkEditor.RemovePane(text, ',');
		if (num >= 0)
		{
			while (true)
			{
				switch (4)
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
			text = PathQueue.RemovePane(text, 0, num);
		}
		return TemplateManager.RemovePane(text, '&');
	}

	private static Assembly Open(object idEnabled, ResolveEventArgs nextUri)
	{
		if ((object)AssistantType.idEnabled != null)
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
					string[] array = ConnectionTable.RemovePane(AssistantType.idEnabled);
					foreach (string text in array)
					{
						if (SelectionContext.RemovePane(text, PcitureType.RemovePane(nextUri)))
						{
							while (true)
							{
								switch (2)
								{
								case 0:
									break;
								default:
									return AssistantType.idEnabled;
								}
							}
						}
					}
					while (true)
					{
						switch (5)
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
		return AssistantType.idEnabled;
	}
}
