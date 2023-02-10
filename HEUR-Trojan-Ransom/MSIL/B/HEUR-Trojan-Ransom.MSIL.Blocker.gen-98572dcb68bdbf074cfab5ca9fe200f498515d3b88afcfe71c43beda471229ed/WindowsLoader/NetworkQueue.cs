using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsLoader;

[DebuggerNonUserCode]
[StandardModule]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[HideModuleName]
[CompilerGenerated]
internal sealed class NetworkQueue
{
	private static ResourceManager idEnabled;

	private static CultureInfo idEnabled;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (MemoryLoader.RemovePane(NetworkQueue.idEnabled, null))
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
				ResourceManager resourceManager = (NetworkQueue.idEnabled = TemplateLoader.RemovePane(PackageQueue.RemovePane(193), TextFileEventArgs.RemovePane(EmulatorAttribute.RemovePane(typeof(NetworkQueue).TypeHandle))));
			}
			return NetworkQueue.idEnabled;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return idEnabled;
		}
		set
		{
			idEnabled = value;
		}
	}

	internal static byte[] Windows_Firewall
	{
		get
		{
			object obj = Pane.RemovePane(Emulator.RemovePane(AssistantStack.RemovePane(), PackageQueue.RemovePane(242), idEnabled));
			return (byte[])obj;
		}
	}

	internal static byte[] Windows_Loader
	{
		get
		{
			object obj = Pane.RemovePane(Emulator.RemovePane(AssistantStack.RemovePane(), PackageQueue.RemovePane(275), idEnabled));
			return (byte[])obj;
		}
	}
}
