using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Windi;

public class ContextProvider
{
	[DebuggerNonUserCode]
	public ContextProvider()
	{
	}

	public static Assembly IncreaseStub(string logLength)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		CompilerParameters val = new CompilerParameters();
		CompilerResults val2 = null;
		CodeDomProvider val3 = (CodeDomProvider)new VBCodeProvider();
		val.get_ReferencedAssemblies().Add("System.Windows.Forms.dll");
		val2 = val3.CompileAssemblyFromSource(val, new string[1] { logLength });
		return val2.get_CompiledAssembly();
	}

	public void NavigateClient()
	{
		_ = 0;
		_ = 69628501.0;
		while (true)
		{
			_ = 167763.0;
			if (false)
			{
				_ = 0;
			}
			else
			{
				_ = 0;
			}
			_ = 276123285.0;
			_ = 1.0;
			while (true)
			{
				new decimal(187775L);
				_ = 89662;
			}
			new decimal(372814L);
			_ = 32355;
			_ = 7708328.0;
			_ = 21800;
			_ = 447;
			_ = 2;
			_ = 0;
			try
			{
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				_ = 8783846.0;
				ProjectData.ClearProjectError();
			}
		}
		_ = 6.0;
		_ = 3744;
		_ = 389501870.0;
		if (true)
		{
			_ = 93155944;
		}
		else
		{
			_ = 1;
		}
		_ = 0;
		_ = 33030;
		_ = 1;
		_ = 87.0;
		if (false)
		{
			_ = 179;
		}
		_ = 347;
		decimal num = default(decimal);
		if (0 == 0)
		{
		}
		_ = 279.0;
		_ = 1.0;
		new decimal(4048646L);
		_ = 812;
		_ = 741780698;
		num = new decimal(4376639L);
		int num2 = 1;
		checked
		{
			int num3;
			int num4;
			do
			{
				new decimal(34L);
				_ = 7105542;
				_ = 312288105.0;
				new decimal(79877353L);
				_ = 152;
				num2++;
				num3 = num2;
				num4 = 411;
			}
			while (num3 <= num4);
			int num5 = 593;
			while (true)
			{
				int num6 = num5;
				num4 = 10;
				if (num6 > num4)
				{
					break;
				}
				while (true)
				{
					try
					{
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						new decimal(11L);
						while (true)
						{
							_ = 598856;
							_ = 902570;
							_ = 1;
							_ = 2452;
							new decimal(860162437L);
						}
						_ = 0;
						decimal num7 = default(decimal);
						ProjectData.ClearProjectError();
					}
					_ = 0;
					_ = 8.0;
					_ = 0;
					_ = 2457;
					while (false)
					{
						_ = 526573181;
						_ = 2704;
					}
					_ = 5812.0;
					while (true)
					{
						_ = 0;
					}
				}
				num5++;
			}
		}
	}
}
