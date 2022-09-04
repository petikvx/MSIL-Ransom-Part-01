using System;
using System.Reflection;
using System.Security;
using System.Windows.Forms;
using ns1;
using ns2;
using ns4;

namespace ns6;

internal sealed class Class19 : Class18
{
	protected override void vmethod_2(EventArgs1 eventArgs1_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		Form2 form = new Form2(eventArgs1_0);
		((Form)form).ShowDialog();
	}

	protected override void vmethod_0(EventArgs3 eventArgs3_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		Form1 form = new Form1(this, eventArgs3_0);
		((Form)form).ShowDialog();
	}

	protected override void vmethod_1(EventArgs2 eventArgs2_0)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(eventArgs2_0.method_0().ToString(), string.Format("{0} Unexpected Error", "XfZ4HD2gUn3XAw"), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	public static bool smethod_4()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Class18.smethod_0(new Class19());
			return true;
		}
		catch (SecurityException)
		{
			try
			{
				try
				{
					typeof(Application).InvokeMember("EnableVisualStyles", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
				}
				catch (MissingMethodException)
				{
				}
				string string_ = string.Format("{0} cannot initialize itself because some permissions are not granted.\n\nYou probably try to launch {0} in a partial-trust situation. It's usually the case when the application is hosted on a network share.\n\nYou need to run {0} in full-trust, or at least grant it the UnmanagedCode security permission.\n\nTo grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.", "XfZ4HD2gUn3XAw");
				Form2 form = new Form2(new EventArgs1(string_, bool_3: false));
				((Form)form).set_ShowInTaskbar(true);
				((Form)form).ShowDialog();
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString(), string.Format("{0} Unexpected Error", "XfZ4HD2gUn3XAw"), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			return false;
		}
	}
}
