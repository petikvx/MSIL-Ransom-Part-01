using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

[DesignerGenerated]
public class GForm0 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("\uee5c\uf179\uf47f\ue4bc\uf8b5\uee2b\ue2f3\ue78e\ueacf\uef36")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private ListView listView_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[AccessedThroughProperty("\uee5c\uf179\uf47f\ue4bc\uf8b5\uee2b\ue2f3\ue78e\ueacf\uef37")]
	[CompilerGenerated]
	private BackgroundWorker backgroundWorker_0;

	internal virtual ListView ListView_0
	{
		[CompilerGenerated]
		get
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Expected O, but got Unknown
			return (ListView)Class28.smethod_0(4799197, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4799207, this, value);
		}
	}

	internal virtual BackgroundWorker BackgroundWorker_0
	{
		[CompilerGenerated]
		get
		{
			return (BackgroundWorker)Class28.smethod_0(4798977, this, null);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			Class28.smethod_0(4799019, this, value);
		}
	}

	public GForm0()
	{
		((Form)this).add_Load((EventHandler)GForm0_Load);
		Delegate19.smethod_0(this);
	}

	public void method_0()
	{
		Class28.smethod_0(4808087, this, null);
	}

	public object method_1(string string_0)
	{
		return Class28.smethod_0(4801801, this, string_0);
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		Class28.smethod_0(4802825, this, sender, e);
	}

	public object method_2(int int_0)
	{
		return Class28.smethod_0(4803407, this, int_0);
	}

	public static void smethod_0()
	{
		Class28.smethod_0(4803911, null, null);
	}

	public object method_3()
	{
		return Class28.smethod_0(4804173, this, null);
	}

	private void method_4(object sender, DoWorkEventArgs e)
	{
		Class28.smethod_0(4797471, this, sender, e);
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		Class28.smethod_0(4797501, this, disposing);
	}

	[DebuggerStepThrough]
	private void method_5()
	{
		Class28.smethod_0(4798199, this, null);
	}
}
