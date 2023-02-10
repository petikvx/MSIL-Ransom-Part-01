using System;
using System.Collections;
using System.IO;
using System.Reflection;

namespace WindowsLoader;

internal class ComponentService
{
	private static readonly Hashtable idEnabled = GroupAttribute.RemovePane();

	private static readonly Hashtable nextUri = GroupAttribute.RemovePane();

	internal static void RemovePane()
	{
		string text = "";
		char[] array = DeviceHelper.RemovePane(text);
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (char)(~(uint)array[i]);
		}
		while (true)
		{
			switch (5)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			text = FormContext.RemovePane(array);
			string[] array2 = EditorLayout.RemovePane(text, new string[1] { PackageQueue.RemovePane(592) }, StringSplitOptions.RemoveEmptyEntries);
			if (array2 != null)
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
				if (array2.Length >= 0)
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
					for (int j = 0; j < array2.Length; j += 2)
					{
						if (FileService.RemovePane(array2[j + 1], PackageQueue.RemovePane(597)))
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
							try
							{
								Assembly assembly = Window.RemovePane();
								string text2 = Dialog.RemovePane(NetworkOptions.RemovePane(MemoryEditor.RemovePane(assembly)), array2[j]);
								if (PackageContext.RemovePane(text2))
								{
									continue;
								}
								while (true)
								{
									switch (6)
									{
									case 0:
										continue;
									}
									string[] array3 = ConnectionTable.RemovePane(assembly);
									foreach (string text3 in array3)
									{
										if (!SelectionContext.RemovePane(text3, array2[j + 1]))
										{
											continue;
										}
										while (true)
										{
											switch (7)
											{
											case 0:
												continue;
											}
											break;
										}
										Stream stream = TemplateSite.RemovePane(assembly, text3);
										byte[] array4 = VectorStack.RemovePane(97L, stream);
										FileStream fileStream = ViewStack.RemovePane(text2, FileMode.Create, FileAccess.Write);
										try
										{
											ActivityLoader.RemovePane(fileStream, array4, 0, array4.Length);
										}
										finally
										{
											if (fileStream != null)
											{
												while (true)
												{
													switch (1)
													{
													case 0:
														continue;
													}
													ControlSettings.RemovePane(fileStream);
													break;
												}
											}
										}
										DiskLoader.RemovePane(stream);
									}
									while (true)
									{
										switch (3)
										{
										case 0:
											break;
										default:
											goto end_IL_018f;
										}
										continue;
										end_IL_018f:
										break;
									}
									break;
								}
							}
							catch
							{
							}
						}
						else
						{
							TreeNodeManager.RemovePane(nextUri, array2[j], array2[j + 1]);
						}
					}
					while (true)
					{
						switch (7)
						{
						case 0:
							continue;
						}
						break;
					}
				}
			}
			ActivityDesigner.RemovePane(AssistantAttribute.RemovePane(), RemovePane);
			return;
		}
	}

	private static string RemovePane(byte[] idEnabled, string nextUri, string messageSet, string parentFont)
	{
		nextUri = Dialog.RemovePane(TemplateScope.RemovePane(), nextUri);
		string result = Dialog.RemovePane(nextUri, PaneInfo.RemovePane(messageSet, parentFont));
		if (!PackageContext.RemovePane(result))
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
			EmulatorService.RemovePane(nextUri);
			FileStream fileStream = ViewStack.RemovePane(result, FileMode.Create, FileAccess.Write);
			ActivityLoader.RemovePane(fileStream, idEnabled, 0, idEnabled.Length);
			DiskLoader.RemovePane(fileStream);
		}
		return result;
	}

	private static Assembly RemovePane(object idEnabled, ResolveEventArgs nextUri)
	{
		Hashtable hashtable;
		OptionsInvoker.RemovePane(hashtable = ComponentService.idEnabled);
		try
		{
			Assembly assembly = null;
			string text = PcitureType.RemovePane(nextUri);
			string text2 = string.Empty;
			IEnumerator enumerator = FunctionType.RemovePane(OptionsToken.RemovePane(ComponentService.nextUri));
			try
			{
				while (true)
				{
					if (TextFileCollection.RemovePane(enumerator))
					{
						string text3 = (string)CommandDictionary.RemovePane(enumerator);
						if (!FileService.RemovePane(text3, text))
						{
							continue;
						}
						while (true)
						{
							switch (6)
							{
							case 0:
								continue;
							}
							if (1 == 0)
							{
								/*OpCode not supported: LdMemberToken*/;
							}
							assembly = ServerScope.RemovePane(ComponentService.idEnabled, text3) as Assembly;
							if ((object)assembly != null)
							{
								while (true)
								{
									switch (5)
									{
									case 0:
										break;
									default:
										return assembly;
									}
								}
							}
							text2 = ServerScope.RemovePane(ComponentService.nextUri, text3) as string;
							break;
						}
						break;
					}
					while (true)
					{
						switch (6)
						{
						case 0:
							break;
						default:
							goto end_IL_00aa;
						}
						continue;
						end_IL_00aa:
						break;
					}
					break;
				}
			}
			finally
			{
				if (enumerator is IDisposable disposable)
				{
					while (true)
					{
						switch (6)
						{
						case 0:
							continue;
						}
						ControlSettings.RemovePane(disposable);
						break;
					}
				}
			}
			if (AddinHelper.RemovePane(text2) == 0)
			{
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
			Assembly assembly2 = Window.RemovePane();
			string[] array = ConnectionTable.RemovePane(assembly2);
			foreach (string text4 in array)
			{
				if (!SelectionContext.RemovePane(text4, text2))
				{
					continue;
				}
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					Stream stream = TemplateSite.RemovePane(assembly2, text4);
					byte[] array2 = VectorStack.RemovePane(97L, stream);
					byte[] array3 = null;
					try
					{
						text2 = PaneInfo.RemovePane(text2, PackageQueue.RemovePane(600));
						string[] array4 = ConnectionTable.RemovePane(assembly2);
						foreach (string text5 in array4)
						{
							if (!SelectionContext.RemovePane(text5, text2))
							{
								continue;
							}
							while (true)
							{
								switch (4)
								{
								case 0:
									continue;
								}
								break;
							}
							Stream stream2 = TemplateSite.RemovePane(assembly2, text5);
							array3 = VectorStack.RemovePane(97L, stream2);
						}
						while (true)
						{
							switch (4)
							{
							case 0:
								break;
							default:
								goto end_IL_01b6;
							}
							continue;
							end_IL_01b6:
							break;
						}
					}
					catch (Exception)
					{
					}
					bool flag = false;
					try
					{
						if (array3 == null)
						{
							while (true)
							{
								switch (7)
								{
								case 0:
									continue;
								}
								assembly = CommandQueue.RemovePane(array2);
								break;
							}
						}
						else
						{
							try
							{
								assembly = VectorSerializer.RemovePane(array2, array3);
							}
							catch (Exception)
							{
								assembly = CommandQueue.RemovePane(array2);
							}
						}
					}
					catch (FileLoadException)
					{
						flag = true;
					}
					catch (BadImageFormatException)
					{
						flag = true;
					}
					if (flag)
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
						string messageSet = RemovePane(text);
						string text6 = RemovePane(array2, text2, messageSet, PackageQueue.RemovePane(603));
						if (array3 != null)
						{
							while (true)
							{
								switch (5)
								{
								case 0:
									continue;
								}
								break;
							}
							RemovePane(array2, text2, messageSet, PackageQueue.RemovePane(612));
						}
						assembly = SolutionProvider.RemovePane(text6);
					}
					TreeNodeManager.RemovePane(ComponentService.idEnabled, text, assembly);
					return assembly;
				}
			}
			while (true)
			{
				switch (3)
				{
				case 0:
					continue;
				}
				return null;
			}
		}
		finally
		{
			BuilderList.RemovePane(hashtable);
		}
	}

	private static string RemovePane(string idEnabled)
	{
		int num = NetworkEditor.RemovePane(idEnabled, ',');
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
			idEnabled = PathQueue.RemovePane(idEnabled, 0, num);
		}
		return idEnabled;
	}
}
