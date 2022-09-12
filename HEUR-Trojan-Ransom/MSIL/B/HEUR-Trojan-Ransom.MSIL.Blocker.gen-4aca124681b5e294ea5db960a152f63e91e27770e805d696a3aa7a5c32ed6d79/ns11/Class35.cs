using System;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns1;
using ns10;
using ns3;
using ns8;

namespace ns11;

internal sealed class Class35 : Class34
{
	[NonSerialized]
	internal static GetString getString_1;

	protected override void vmethod_2(EventArgs3 eventArgs3_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Form2 form = new Form2(eventArgs3_0);
		try
		{
			((Form)form).ShowDialog();
		}
		finally
		{
			((IDisposable)(object)form)?.Dispose();
		}
	}

	protected override void vmethod_0(EventArgs2 eventArgs2_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Form1 form = new Form1(this, eventArgs2_0);
		try
		{
			((Form)form).ShowDialog();
		}
		finally
		{
			((IDisposable)(object)form)?.Dispose();
		}
	}

	protected override void vmethod_1(EventArgs1 eventArgs1_0)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(eventArgs1_0.method_0().ToString(), string.Format(getString_1(107386037), getString_1(107397118)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	public static bool smethod_3()
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Class34.smethod_0(new Class35());
			return true;
		}
		catch (SecurityException)
		{
			try
			{
				try
				{
					typeof(Application).InvokeMember(getString_1(107386008), BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
				}
				catch (MissingMethodException)
				{
				}
				string string_ = string.Format(getString_1(107386015), getString_1(107397118));
				Form2 form = new Form2(new EventArgs3(string_, bool_3: false));
				((Form)form).set_ShowInTaskbar(true);
				((Form)form).ShowDialog();
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString(), string.Format(getString_1(107386037), getString_1(107397118)), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			return false;
		}
	}

	static Class35()
	{
		Strings.CreateGetStringDelegate(typeof(Class35));
	}
}
