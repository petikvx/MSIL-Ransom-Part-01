using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Reflection;
using System.Security;
using System.Windows.Forms;

namespace ModuleNameSpace;

internal class MainModuleUI : PSHostUserInterface
{
	private MainModuleRawUI rawUI;

	public ConsoleColor ErrorForegroundColor = ConsoleColor.Red;

	public ConsoleColor ErrorBackgroundColor;

	public ConsoleColor WarningForegroundColor = ConsoleColor.Yellow;

	public ConsoleColor WarningBackgroundColor;

	public ConsoleColor DebugForegroundColor = ConsoleColor.Yellow;

	public ConsoleColor DebugBackgroundColor;

	public ConsoleColor VerboseForegroundColor = ConsoleColor.Yellow;

	public ConsoleColor VerboseBackgroundColor;

	public ConsoleColor ProgressForegroundColor = ConsoleColor.DarkCyan;

	public ConsoleColor ProgressBackgroundColor = ConsoleColor.DarkCyan;

	private string ib_caption;

	private string ib_message;

	public Progress_Form pf;

	public override PSHostRawUserInterface RawUI => (PSHostRawUserInterface)(object)rawUI;

	public MainModuleUI()
	{
		rawUI = new MainModuleRawUI();
	}

	public override Dictionary<string, PSObject> Prompt(string caption, string message, Collection<FieldDescription> descriptions)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_0306: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		if (!string.IsNullOrEmpty(caption) || !string.IsNullOrEmpty(message))
		{
			string text = AppDomain.CurrentDomain.FriendlyName;
			string text2 = "";
			if (!string.IsNullOrEmpty(caption))
			{
				text = caption;
			}
			if (!string.IsNullOrEmpty(message))
			{
				text2 = message;
			}
			MessageBox.Show(text2, text);
		}
		ib_caption = "";
		ib_message = "";
		Dictionary<string, PSObject> dictionary = new Dictionary<string, PSObject>();
		foreach (FieldDescription description in descriptions)
		{
			Type type = null;
			type = ((!string.IsNullOrEmpty(description.get_ParameterAssemblyFullName())) ? Type.GetType(description.get_ParameterAssemblyFullName()) : typeof(string));
			if (type.IsArray)
			{
				Type elementType = type.GetElementType();
				Type type2 = Type.GetType("System.Collections.Generic.List" + '`' + "1");
				type2 = type2.MakeGenericType(elementType);
				ConstructorInfo constructor = type2.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.CreateInstance, null, Type.EmptyTypes, null);
				object target = constructor.Invoke(null);
				int num = 0;
				string text3 = "";
				while (true)
				{
					try
					{
						if (!string.IsNullOrEmpty(description.get_Name()))
						{
							ib_message = $"{description.get_Name()}[{num}]: ";
						}
						text3 = ((PSHostUserInterface)this).ReadLine();
						if (string.IsNullOrEmpty(text3))
						{
							break;
						}
						object obj = Convert.ChangeType(text3, elementType);
						type2.InvokeMember("Add", BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod, null, target, new object[1] { obj });
						goto IL_0186;
					}
					catch (Exception ex)
					{
						throw ex;
					}
					IL_0186:
					num++;
				}
				Array array = (Array)type2.InvokeMember("ToArray", BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod, null, target, null);
				dictionary.Add(description.get_Name(), new PSObject((object)array));
				continue;
			}
			object obj2 = null;
			string text4 = null;
			try
			{
				if (type != typeof(SecureString))
				{
					if (type != typeof(PSCredential))
					{
						if (!string.IsNullOrEmpty(description.get_Name()))
						{
							ib_message = $"{description.get_Name()}: ";
						}
						if (!string.IsNullOrEmpty(description.get_HelpMessage()))
						{
							ib_message += "\n(Type !? for help.)";
						}
						do
						{
							text4 = ((PSHostUserInterface)this).ReadLine();
							if (!(text4 == "!?"))
							{
								if (string.IsNullOrEmpty(text4))
								{
									obj2 = description.get_DefaultValue();
								}
								if (obj2 == null)
								{
									try
									{
										obj2 = Convert.ChangeType(text4, type);
									}
									catch
									{
										((PSHostUserInterface)this).Write("Wrong format, please repeat input: ");
										text4 = "!?";
									}
								}
							}
							else
							{
								((PSHostUserInterface)this).WriteLine(description.get_HelpMessage());
							}
						}
						while (text4 == "!?");
					}
					else
					{
						PSCredential val = ((PSHostUserInterface)this).PromptForCredential("", "", "", "");
						obj2 = val;
					}
				}
				else
				{
					if (!string.IsNullOrEmpty(description.get_Name()))
					{
						ib_message = $"{description.get_Name()}: ";
					}
					SecureString secureString = null;
					secureString = ((PSHostUserInterface)this).ReadLineAsSecureString();
					obj2 = secureString;
				}
				dictionary.Add(description.get_Name(), new PSObject(obj2));
			}
			catch (Exception ex2)
			{
				throw ex2;
			}
		}
		ib_caption = "";
		ib_message = "";
		return dictionary;
	}

	public override int PromptForChoice(string caption, string message, Collection<ChoiceDescription> choices, int defaultChoice)
	{
		int num = Choice_Box.Show(choices, defaultChoice, caption, message);
		if (num == -1)
		{
			num = defaultChoice;
		}
		return num;
	}

	public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName, PSCredentialTypes allowedCredentialTypes, PSCredentialUIOptions options)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		Credential_Form.User_Pwd user_Pwd = Credential_Form.PromptForPassword(caption, message, targetName, userName, allowedCredentialTypes, options);
		if (user_Pwd != null)
		{
			SecureString secureString = new SecureString();
			char[] array = user_Pwd.Password.ToCharArray();
			foreach (char c in array)
			{
				secureString.AppendChar(c);
			}
			return new PSCredential(user_Pwd.User, secureString);
		}
		return null;
	}

	public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName)
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		Credential_Form.User_Pwd user_Pwd = Credential_Form.PromptForPassword(caption, message, targetName, userName, (PSCredentialTypes)3, (PSCredentialUIOptions)1);
		if (user_Pwd != null)
		{
			SecureString secureString = new SecureString();
			char[] array = user_Pwd.Password.ToCharArray();
			foreach (char c in array)
			{
				secureString.AppendChar(c);
			}
			return new PSCredential(user_Pwd.User, secureString);
		}
		return null;
	}

	public override string ReadLine()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		string strVal = "";
		if ((int)Input_Box.Show(ib_caption, ib_message, ref strVal) == 1)
		{
			return strVal;
		}
		return "";
	}

	private SecureString getPassword()
	{
		SecureString secureString = new SecureString();
		while (true)
		{
			ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(intercept: true);
			if (consoleKeyInfo.Key == ConsoleKey.Enter)
			{
				break;
			}
			if (consoleKeyInfo.Key == ConsoleKey.Backspace)
			{
				if (secureString.Length > 0)
				{
					secureString.RemoveAt(secureString.Length - 1);
					Console.Write("\b \b");
				}
			}
			else if (consoleKeyInfo.KeyChar != 0)
			{
				secureString.AppendChar(consoleKeyInfo.KeyChar);
				Console.Write("*");
			}
		}
		Console.WriteLine();
		return secureString;
	}

	public override SecureString ReadLineAsSecureString()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		SecureString secureString = new SecureString();
		string strVal = "";
		if ((int)Input_Box.Show(ib_caption, ib_message, ref strVal, blSecure: true) == 1)
		{
			string text = strVal;
			foreach (char c in text)
			{
				secureString.AppendChar(c);
			}
		}
		return secureString;
	}

	public override void Write(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
	{
	}

	public override void Write(string value)
	{
	}

	public override void WriteDebugLine(string message)
	{
	}

	public override void WriteErrorLine(string value)
	{
	}

	public override void WriteLine()
	{
	}

	public override void WriteLine(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
	{
	}

	public override void WriteLine(string value)
	{
	}

	public override void WriteProgress(long sourceId, ProgressRecord record)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		if (pf == null)
		{
			if ((int)record.get_RecordType() == 1)
			{
				return;
			}
			pf = new Progress_Form(ProgressForegroundColor);
			((Control)pf).Show();
		}
		pf.Update(record);
		if ((int)record.get_RecordType() == 1 && pf.GetCount() == 0)
		{
			pf = null;
		}
	}

	public override void WriteVerboseLine(string message)
	{
	}

	public override void WriteWarningLine(string message)
	{
	}
}
