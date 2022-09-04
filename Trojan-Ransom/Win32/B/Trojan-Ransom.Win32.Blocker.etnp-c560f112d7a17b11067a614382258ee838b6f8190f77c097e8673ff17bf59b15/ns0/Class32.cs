using System;
using System.Reflection;
using System.Security;
using System.Windows.Forms;

namespace ns0;

internal sealed class Class32 : Class31
{
	protected override void vmethod_2(EventArgs2 CO_)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		if (8 == 0)
		{
			return;
		}
		Form1 form = new Form1(CO_);
		try
		{
			do
			{
				((Form)form).ShowDialog();
			}
			while (2 == 0);
		}
		finally
		{
			if (5 == 0 || false || form != null)
			{
				((IDisposable)(object)form).Dispose();
			}
		}
	}

	protected override void vmethod_0(EventArgs1 CO_)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		if (4 == 0)
		{
			return;
		}
		Form0 form = new Form0(this, CO_);
		Form0 form2 = default(Form0);
		if (0 == 0)
		{
			form2 = form;
		}
		try
		{
			do
			{
				((Form)form2).ShowDialog();
			}
			while (false);
		}
		finally
		{
			if ((false || form2 != null) && 6u != 0)
			{
				((IDisposable)(object)form2).Dispose();
			}
		}
	}

	protected override void vmethod_1(EventArgs0 CO_)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show(CO_.method_0().ToString(), string.Format(Class5.smethod_0(84254), Class5.smethod_0(81401)), (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	public static bool smethod_3()
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			while (true)
			{
				Class31.smethod_0(new Class32());
				while (true)
				{
					bool result;
					if (uint.MaxValue != 0)
					{
						result = true;
					}
					if (false)
					{
						break;
					}
					if (0 == 0)
					{
						return result;
					}
				}
			}
		}
		catch (SecurityException)
		{
			try
			{
				try
				{
					typeof(Application).InvokeMember(Class5.smethod_0(84283), BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
				}
				catch (MissingMethodException)
				{
				}
				while (true)
				{
					string cO_ = string.Format(Class5.smethod_0(84308), Class5.smethod_0(81401));
					if (0 == 0)
					{
						Form1 form = new Form1(new EventArgs2(cO_, CO_: false));
						if (0 == 0)
						{
							((Form)form).set_ShowInTaskbar(true);
							if (0 == 0)
							{
								((Form)form).ShowDialog();
								break;
							}
							continue;
						}
						break;
					}
					break;
				}
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.ToString(), string.Format(Class5.smethod_0(84254), Class5.smethod_0(81401)), (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
			return false;
		}
	}
}
