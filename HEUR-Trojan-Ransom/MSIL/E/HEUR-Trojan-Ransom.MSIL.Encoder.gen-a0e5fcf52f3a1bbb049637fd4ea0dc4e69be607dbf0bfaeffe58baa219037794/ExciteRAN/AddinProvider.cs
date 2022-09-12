using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ExciteRAN;

[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[CompilerGenerated]
internal class AddinProvider
{
	private static ResourceManager windowPosition;

	private static CultureInfo parentLog;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (windowPosition == AspectSerializer.windowPosition)
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
				ResourceManager resourceManager = (windowPosition = new ResourceManager(PluginDictionary.CheckContext(1), Type.GetTypeFromHandle(AddinLayout.CleanAssistant()).Assembly));
			}
			return windowPosition;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return parentLog;
		}
		set
		{
			parentLog = value;
		}
	}

	internal static Bitmap EXCITEran
	{
		get
		{
			object @object = ResourceManager.GetObject(PluginDictionary.CheckContext(48), parentLog);
			return NodeToken.CleanAssistant(@object);
		}
	}

	internal AddinProvider()
	{
	}
}
