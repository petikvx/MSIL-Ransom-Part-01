using System;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using ns10;
using ns7;
using ns9;

namespace ns5;

internal sealed class Class41 : Class40
{
	protected override void vmethod_2(EventArgs2 eventArgs2_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Form1 form = new Form1(eventArgs2_0);
		try
		{
			((Form)form).ShowDialog();
		}
		finally
		{
			((IDisposable)(object)form)?.Dispose();
		}
	}

	protected override void vmethod_0(EventArgs1 eventArgs1_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Form0 form = new Form0(this, eventArgs1_0);
		try
		{
			((Form)form).ShowDialog();
		}
		finally
		{
			((IDisposable)(object)form)?.Dispose();
		}
	}

	protected override void vmethod_1(EventArgs0 eventArgs0_0)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(eventArgs0_0.method_0().ToString(), string.Format(Class15.smethod_0(954129), Class15.smethod_0(953027)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	public static bool smethod_3()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Class40.smethod_0(new Class41());
			return true;
		}
		catch (SecurityException)
		{
			try
			{
				try
				{
					typeof(Application).InvokeMember(Class15.smethod_0(954158), BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
				}
				catch (MissingMethodException)
				{
				}
				string string_ = string.Format(Class15.smethod_0(954183), Class15.smethod_0(953027));
				Form1 form = new Form1(new EventArgs2(string_, bool_3: false));
				((Form)form).set_ShowInTaskbar(true);
				((Form)form).ShowDialog();
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString(), string.Format(Class15.smethod_0(954129), Class15.smethod_0(953027)), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			return false;
		}
	}
}
