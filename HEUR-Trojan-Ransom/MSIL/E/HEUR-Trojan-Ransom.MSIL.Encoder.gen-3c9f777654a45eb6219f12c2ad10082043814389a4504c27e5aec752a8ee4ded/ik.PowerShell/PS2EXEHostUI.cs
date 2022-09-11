using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Reflection;
using System.Security;

namespace ik.PowerShell;

internal class PS2EXEHostUI : PSHostUserInterface
{
	private PS2EXEHostRawUI rawUI;

	public ConsoleColor ErrorForegroundColor = ConsoleColor.Red;

	public ConsoleColor ErrorBackgroundColor;

	public ConsoleColor WarningForegroundColor = ConsoleColor.Yellow;

	public ConsoleColor WarningBackgroundColor;

	public ConsoleColor DebugForegroundColor = ConsoleColor.Yellow;

	public ConsoleColor DebugBackgroundColor;

	public ConsoleColor VerboseForegroundColor = ConsoleColor.Yellow;

	public ConsoleColor VerboseBackgroundColor;

	public ConsoleColor ProgressForegroundColor = ConsoleColor.Yellow;

	public ConsoleColor ProgressBackgroundColor = ConsoleColor.DarkCyan;

	public override PSHostRawUserInterface RawUI => (PSHostRawUserInterface)(object)rawUI;

	public PS2EXEHostUI()
	{
		rawUI = new PS2EXEHostRawUI();
		((PSHostRawUserInterface)rawUI).set_ForegroundColor(Console.ForegroundColor);
		((PSHostRawUserInterface)rawUI).set_BackgroundColor(Console.BackgroundColor);
	}

	public override Dictionary<string, PSObject> Prompt(string caption, string message, Collection<FieldDescription> descriptions)
	{
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		if (!string.IsNullOrEmpty(caption))
		{
			((PSHostUserInterface)this).WriteLine(caption);
		}
		if (!string.IsNullOrEmpty(message))
		{
			((PSHostUserInterface)this).WriteLine(message);
		}
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
				string text = "";
				while (true)
				{
					try
					{
						if (!string.IsNullOrEmpty(description.get_Name()))
						{
							((PSHostUserInterface)this).Write($"{description.get_Name()}[{num}]: ");
						}
						text = ((PSHostUserInterface)this).ReadLine();
						if (string.IsNullOrEmpty(text))
						{
							break;
						}
						object obj = Convert.ChangeType(text, elementType);
						type2.InvokeMember("Add", BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod, null, target, new object[1] { obj });
						goto IL_0149;
					}
					catch (Exception ex)
					{
						throw ex;
					}
					IL_0149:
					num++;
				}
				Array array = (Array)type2.InvokeMember("ToArray", BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod, null, target, null);
				dictionary.Add(description.get_Name(), new PSObject((object)array));
				continue;
			}
			object obj2 = null;
			string text2 = null;
			try
			{
				if ((object)type != typeof(SecureString))
				{
					if ((object)type != typeof(PSCredential))
					{
						if (!string.IsNullOrEmpty(description.get_Name()))
						{
							((PSHostUserInterface)this).Write(description.get_Name());
						}
						if (!string.IsNullOrEmpty(description.get_HelpMessage()))
						{
							((PSHostUserInterface)this).Write(" (Type !? for help.)");
						}
						if (!string.IsNullOrEmpty(description.get_Name()) || !string.IsNullOrEmpty(description.get_HelpMessage()))
						{
							((PSHostUserInterface)this).Write(": ");
						}
						do
						{
							text2 = ((PSHostUserInterface)this).ReadLine();
							if (!(text2 == "!?"))
							{
								if (string.IsNullOrEmpty(text2))
								{
									obj2 = description.get_DefaultValue();
								}
								if (obj2 == null)
								{
									try
									{
										obj2 = Convert.ChangeType(text2, type);
									}
									catch
									{
										((PSHostUserInterface)this).Write("Wrong format, please repeat input: ");
										text2 = "!?";
									}
								}
							}
							else
							{
								((PSHostUserInterface)this).WriteLine(description.get_HelpMessage());
							}
						}
						while (text2 == "!?");
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
						((PSHostUserInterface)this).Write($"{description.get_Name()}: ");
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
		return dictionary;
	}

	public override int PromptForChoice(string caption, string message, Collection<ChoiceDescription> choices, int defaultChoice)
	{
		if (!string.IsNullOrEmpty(caption))
		{
			((PSHostUserInterface)this).WriteLine(caption);
		}
		((PSHostUserInterface)this).WriteLine(message);
		int num = 0;
		SortedList<string, int> sortedList = new SortedList<string, int>();
		foreach (ChoiceDescription choice in choices)
		{
			string text = choice.get_Label().Substring(0, 1);
			string arg = choice.get_Label();
			int num2 = choice.get_Label().IndexOf('&');
			if (num2 > -1)
			{
				text = choice.get_Label().Substring(num2 + 1, 1).ToUpper();
				arg = ((num2 <= 0) ? choice.get_Label().Substring(1) : (choice.get_Label().Substring(0, num2) + choice.get_Label().Substring(num2 + 1)));
			}
			sortedList.Add(text.ToLower(), num);
			if (num > 0)
			{
				((PSHostUserInterface)this).Write("  ");
			}
			if (num == defaultChoice)
			{
				((PSHostUserInterface)this).Write(ConsoleColor.Yellow, Console.BackgroundColor, $"[{text}] {arg}");
				if (!string.IsNullOrEmpty(choice.get_HelpMessage()))
				{
					((PSHostUserInterface)this).Write(ConsoleColor.Gray, Console.BackgroundColor, $" ({choice.get_HelpMessage()})");
				}
			}
			else
			{
				((PSHostUserInterface)this).Write(ConsoleColor.Gray, Console.BackgroundColor, $"[{text}] {arg}");
				if (!string.IsNullOrEmpty(choice.get_HelpMessage()))
				{
					((PSHostUserInterface)this).Write(ConsoleColor.Gray, Console.BackgroundColor, $" ({choice.get_HelpMessage()})");
				}
			}
			num++;
		}
		((PSHostUserInterface)this).Write(": ");
		try
		{
			string text2;
			do
			{
				text2 = Console.ReadLine()!.ToLower();
				if (sortedList.ContainsKey(text2))
				{
					return sortedList[text2];
				}
			}
			while (!string.IsNullOrEmpty(text2));
			return defaultChoice;
		}
		catch
		{
			return defaultChoice;
		}
	}

	public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName, PSCredentialTypes allowedCredentialTypes, PSCredentialUIOptions options)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		if (!string.IsNullOrEmpty(caption))
		{
			((PSHostUserInterface)this).WriteLine(caption);
		}
		((PSHostUserInterface)this).WriteLine(message);
		string text;
		if (!string.IsNullOrEmpty(userName) && (options & 3) != 0)
		{
			((PSHostUserInterface)this).Write("User name: ");
			if (!string.IsNullOrEmpty(targetName))
			{
				((PSHostUserInterface)this).Write(targetName + "\\");
			}
			((PSHostUserInterface)this).WriteLine(userName);
			text = userName;
		}
		else
		{
			((PSHostUserInterface)this).Write("User name: ");
			text = ((PSHostUserInterface)this).ReadLine();
		}
		SecureString secureString = null;
		((PSHostUserInterface)this).Write("Password: ");
		secureString = ((PSHostUserInterface)this).ReadLineAsSecureString();
		if (string.IsNullOrEmpty(text))
		{
			text = "<NOUSER>";
		}
		if (!string.IsNullOrEmpty(targetName) && text.IndexOf('\\') < 0)
		{
			text = targetName + "\\" + text;
		}
		return new PSCredential(text, secureString);
	}

	public override PSCredential PromptForCredential(string caption, string message, string userName, string targetName)
	{
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		if (!string.IsNullOrEmpty(caption))
		{
			((PSHostUserInterface)this).WriteLine(caption);
		}
		((PSHostUserInterface)this).WriteLine(message);
		string text;
		if (string.IsNullOrEmpty(userName))
		{
			((PSHostUserInterface)this).Write("User name: ");
			text = ((PSHostUserInterface)this).ReadLine();
		}
		else
		{
			((PSHostUserInterface)this).Write("User name: ");
			if (!string.IsNullOrEmpty(targetName))
			{
				((PSHostUserInterface)this).Write(targetName + "\\");
			}
			((PSHostUserInterface)this).WriteLine(userName);
			text = userName;
		}
		SecureString secureString = null;
		((PSHostUserInterface)this).Write("Password: ");
		secureString = ((PSHostUserInterface)this).ReadLineAsSecureString();
		if (string.IsNullOrEmpty(text))
		{
			text = "<NOUSER>";
		}
		if (!string.IsNullOrEmpty(targetName) && text.IndexOf('\\') < 0)
		{
			text = targetName + "\\" + text;
		}
		return new PSCredential(text, secureString);
	}

	public override string ReadLine()
	{
		return Console.ReadLine();
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
			else
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
		SecureString secureString = new SecureString();
		return getPassword();
	}

	public override void Write(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
	{
		ConsoleColor foregroundColor2 = Console.ForegroundColor;
		ConsoleColor backgroundColor2 = Console.BackgroundColor;
		Console.ForegroundColor = foregroundColor;
		Console.BackgroundColor = backgroundColor;
		Console.Write(value);
		Console.ForegroundColor = foregroundColor2;
		Console.BackgroundColor = backgroundColor2;
	}

	public override void Write(string value)
	{
		Console.Write(value);
	}

	public override void WriteDebugLine(string message)
	{
		WriteLineInternal(DebugForegroundColor, DebugBackgroundColor, $"DEBUG: {message}");
	}

	public override void WriteErrorLine(string value)
	{
		if (ConsoleInfo.IsErrorRedirected())
		{
			Console.Error.WriteLine($"ERROR: {value}");
		}
		else
		{
			WriteLineInternal(ErrorForegroundColor, ErrorBackgroundColor, $"ERROR: {value}");
		}
	}

	public override void WriteLine()
	{
		Console.WriteLine();
	}

	public override void WriteLine(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
	{
		ConsoleColor foregroundColor2 = Console.ForegroundColor;
		ConsoleColor backgroundColor2 = Console.BackgroundColor;
		Console.ForegroundColor = foregroundColor;
		Console.BackgroundColor = backgroundColor;
		Console.WriteLine(value);
		Console.ForegroundColor = foregroundColor2;
		Console.BackgroundColor = backgroundColor2;
	}

	private void WriteLineInternal(ConsoleColor foregroundColor, ConsoleColor backgroundColor, string value)
	{
		ConsoleColor foregroundColor2 = Console.ForegroundColor;
		ConsoleColor backgroundColor2 = Console.BackgroundColor;
		Console.ForegroundColor = foregroundColor;
		Console.BackgroundColor = backgroundColor;
		Console.WriteLine(value);
		Console.ForegroundColor = foregroundColor2;
		Console.BackgroundColor = backgroundColor2;
	}

	public override void WriteLine(string value)
	{
		Console.WriteLine(value);
	}

	public override void WriteProgress(long sourceId, ProgressRecord record)
	{
	}

	public override void WriteVerboseLine(string message)
	{
		((PSHostUserInterface)this).WriteLine(VerboseForegroundColor, VerboseBackgroundColor, $"VERBOSE: {message}");
	}

	public override void WriteWarningLine(string message)
	{
		WriteLineInternal(WarningForegroundColor, WarningBackgroundColor, $"WARNING: {message}");
	}
}
