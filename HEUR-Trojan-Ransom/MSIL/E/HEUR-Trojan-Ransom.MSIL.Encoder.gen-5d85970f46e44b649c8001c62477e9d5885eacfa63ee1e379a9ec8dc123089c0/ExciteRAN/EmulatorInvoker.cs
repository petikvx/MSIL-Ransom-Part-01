using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ExciteRAN;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal sealed class EmulatorInvoker
{
	private static ResourceManager lastHandler;

	private static CultureInfo urlHeader;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (lastHandler == MemoryToken.lastHandler)
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
				ResourceManager resourceManager = (lastHandler = ProcessContext.SaveNetwork(SymbolStream.SaveNetwork(278), GroupLayout.SaveNetwork(DialogCollection.SaveNetwork(EditorDictionary.ResolveFile()))));
			}
			return lastHandler;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return urlHeader;
		}
		set
		{
			urlHeader = value;
		}
	}

	internal static Bitmap EXCITEran
	{
		get
		{
			object obj = MethodDesigner.SaveNetwork(QueueHelper.SaveNetwork(), SymbolStream.SaveNetwork(329), urlHeader);
			return AssistantOptions.ResolveFile(obj);
		}
	}

	internal EmulatorInvoker()
	{
	}
}
