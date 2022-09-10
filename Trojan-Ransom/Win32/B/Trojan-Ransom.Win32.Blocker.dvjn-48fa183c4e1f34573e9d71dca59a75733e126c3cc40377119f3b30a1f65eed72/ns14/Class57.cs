using System;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using ns10;
using ns12;

namespace ns14;

internal class Class57 : Class56
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
			((IDisposable)form)?.Dispose();
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
			((IDisposable)form)?.Dispose();
		}
	}

	protected override void vmethod_1(EventArgs0 eventArgs0_0)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(eventArgs0_0.exception_0.ToString(), string.Format(Class32.smethod_0(8154), Class32.smethod_0(759)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	public static bool smethod_0()
	{
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Class12.smethod_156((Class56)new Class57());
			return true;
		}
		catch (SecurityException)
		{
			try
			{
				try
				{
					typeof(Application).InvokeMember(Class32.smethod_0(8183), BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
				}
				catch (MissingMethodException)
				{
				}
				string securityMessage = string.Format(Class32.smethod_0(8208), Class32.smethod_0(759));
				Form1 form = new Form1(new EventArgs2(securityMessage, canContinue: false));
				((Form)form).set_ShowInTaskbar(true);
				((Form)form).ShowDialog();
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString(), string.Format(Class32.smethod_0(8154), Class32.smethod_0(759)), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			return false;
		}
	}

	internal static bool g6VPeqRr6XIdsVNKxFO()
	{
		return true;
	}

	internal static bool XWKVWlRihCpogyebhkZ()
	{
		return false;
	}
}
