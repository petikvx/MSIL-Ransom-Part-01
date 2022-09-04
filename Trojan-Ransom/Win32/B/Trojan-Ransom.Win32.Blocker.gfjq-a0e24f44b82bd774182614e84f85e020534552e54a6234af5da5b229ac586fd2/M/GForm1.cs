using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace M;

[DesignerGenerated]
public class GForm1 : Form
{
	private IContainer m_a;

	private ToolTip m_a;

	private ToolStripStatusLabel m_a;

	private StatusStrip m_a;

	private int m_a;

	internal virtual ToolTip a
	{
		get
		{
			return this.m_a;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.m_a = value;
		}
	}

	internal virtual ToolStripStatusLabel a
	{
		get
		{
			return this.m_a;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.m_a = value;
		}
	}

	internal virtual StatusStrip a
	{
		get
		{
			return this.m_a;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.m_a = value;
		}
	}

	public GForm1()
	{
		a();
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && this.m_a != null)
			{
				this.m_a.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	private void a()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		this.m_a = new Container();
		this.a = new StatusStrip();
		this.a = new ToolStripStatusLabel();
		this.a = new ToolTip(this.m_a);
		((Control)this.a).SuspendLayout();
		((Control)this).SuspendLayout();
		((ToolStrip)this.a).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)this.a });
		StatusStrip obj = this.a;
		Point location = new Point(0, 431);
		((Control)obj).set_Location(location);
		((Control)this.a).set_Name(global::C.a("닠韢蓤鏦鳨飪뻬鯮菰髲藴", 4));
		StatusStrip obj2 = this.a;
		Size size = new Size(632, 22);
		((Control)obj2).set_Size(size);
		((Control)this.a).set_TabIndex(7);
		((Control)this.a).set_Text(global::C.a("닠韢蓤鏦鳨飪뻬鯮菰髲藴", 4));
		((ToolStripItem)this.a).set_Name(global::C.a("뛡诣觥蓧맩飫鳭駯英\ua7f3苵駷軹觻跽䳿持昃挅搇", 5));
		ToolStripStatusLabel obj3 = this.a;
		size = new Size(39, 17);
		((ToolStripItem)obj3).set_Size(size);
		((ToolStripItem)this.a).set_Text(global::C.a("距铟菡郣鏥鯧", 1));
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(632, 453);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)this.a);
		((Form)this).set_IsMdiContainer(true);
		((Control)this).set_Name(global::C.a("쇨췪ꓤ쇦고\ufae2냼\udbfe룸\ue8fa듴짶볰쟲⼌㴎Ἀ㤊㤄आ", 8));
		((Form)this).set_Text(global::C.a("쟮쿨ꫪ쏤ꫦ\uf8e0껢\ud9fc뻾\ueaf8뫺쯴뫶연퇲㼌ᤎ㬈㜊\u0b04", 6));
		((Control)this.a).ResumeLayout(false);
		((Control)this.a).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void a(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		Form val = new Form();
		val.set_MdiParent((Form)(object)this);
		checked
		{
			this.m_a++;
			val.set_Text(global::C.a("觝觟賡胣觥鿧쫩", 1) + Conversions.ToString(this.m_a));
			((Control)val).Show();
		}
	}

	private void A(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)global::B.a).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter(global::C.a("듟蟡鳣鋥죧곩藫苭闯臱퓳\udef5틷퓹裻蛽瓿⬁砃Ⰵ☇縉琋稍氏匑砓稕㠗尙甛爝䔟儡УลȧЩثܭ䰯ᠱᨳ\u1c35", 3));
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
		}
	}

	private void b(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)global::B.a).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter(global::C.a("諝藟髡郣웥껧菩胫语華틱\udcf3\udcf5훷軹蓻諽⧿縁⸃⠅簇爉砋爍儏縑砓㘕帗猙瀛笝匟ȡణథا)ԫ刭ᨯ\u1c31ḳ", 1));
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 1)
		{
			((FileDialog)val).get_FileName();
		}
	}

	private void B(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void c(object sender, EventArgs e)
	{
	}

	private void C(object sender, EventArgs e)
	{
	}

	private void d(object sender, EventArgs e)
	{
	}

	private void D(object sender, EventArgs e)
	{
	}

	private void e(object sender, EventArgs e)
	{
	}

	private void E(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)0);
	}

	private void f(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)2);
	}

	private void F(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)1);
	}

	private void g(object sender, EventArgs e)
	{
		((Form)this).LayoutMdi((MdiLayout)3);
	}

	private void G(object sender, EventArgs e)
	{
		Form[] mdiChildren = ((Form)this).get_MdiChildren();
		foreach (Form val in mdiChildren)
		{
			val.Close();
		}
	}
}
