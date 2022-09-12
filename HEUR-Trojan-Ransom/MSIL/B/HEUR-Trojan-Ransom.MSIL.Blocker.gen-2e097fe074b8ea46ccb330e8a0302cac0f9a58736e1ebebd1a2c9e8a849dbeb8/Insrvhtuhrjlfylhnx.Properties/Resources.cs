using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Insrvhtuhrjlfylhnx.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal class Resources
{
	private static ResourceManager _Status;

	private static CultureInfo _Rules;

	internal static Resources ReadDecorator;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (_Status == null)
			{
				_Status = new ResourceManager("Insrvhtuhrjlfylhnx.Properties.Resources", typeof(Resources).Assembly);
			}
			return _Status;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return _Rules;
		}
		set
		{
			_Rules = value;
		}
	}

	internal static byte[] Pacbtcj => (byte[])ResourceManager.GetObject("Pacbtcj", _Rules);

	internal Resources()
	{
	}

	internal static bool AwakeDecorator()
	{
		return ReadDecorator == null;
	}

	internal static Resources NewDecorator()
	{
		return ReadDecorator;
	}
}
