using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace M;

[DesignerGenerated]
public class GForm0 : Form
{
	private ToolStripContainer m_a;

	private ImageList m_a;

	private SplitContainer m_a;

	private TreeView m_a;

	private ListView m_a;

	private StatusStrip m_a;

	private ToolStripStatusLabel m_a;

	private ToolTip m_a;

	private ImageList m_A;

	private ImageList m_b;

	private IContainer m_a;

	internal virtual ToolStripContainer a
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

	internal virtual ImageList a
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

	internal virtual SplitContainer a
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

	internal virtual TreeView a
	{
		get
		{
			return this.m_a;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			TreeViewEventHandler val = new TreeViewEventHandler(a);
			if (this.m_a != null)
			{
				this.m_a.remove_AfterSelect(val);
			}
			this.m_a = value;
			if (this.m_a != null)
			{
				this.m_a.add_AfterSelect(val);
			}
		}
	}

	internal virtual ListView a
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

	internal virtual ImageList A
	{
		get
		{
			return this.m_A;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.m_A = value;
		}
	}

	internal virtual ImageList b
	{
		get
		{
			return this.m_b;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			this.m_b = value;
		}
	}

	public GForm0()
	{
		((Form)this).add_Load((EventHandler)a);
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_051d: Expected O, but got Unknown
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected O, but got Unknown
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm0));
		this.a = new StatusStrip();
		this.a = new ToolStripStatusLabel();
		this.a = new ImageList(this.m_a);
		this.a = new ToolTip(this.m_a);
		this.a = new ToolStripContainer();
		this.a = new SplitContainer();
		this.a = new TreeView();
		this.a = new ListView();
		this.A = new ImageList(this.m_a);
		this.b = new ImageList(this.m_a);
		((Control)this.a).SuspendLayout();
		((Control)this.a.get_BottomToolStripPanel()).SuspendLayout();
		((Control)this.a.get_ContentPanel()).SuspendLayout();
		((Control)this.a).SuspendLayout();
		((Control)this.a.get_Panel1()).SuspendLayout();
		((Control)this.a.get_Panel2()).SuspendLayout();
		((Control)this.a).SuspendLayout();
		((Control)this).SuspendLayout();
		this.a.set_Dock((DockStyle)0);
		((ToolStrip)this.a).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)this.a });
		StatusStrip obj = this.a;
		Point location = new Point(0, 0);
		((Control)obj).set_Location(location);
		((Control)this.a).set_Name(global::C.a("軜ꯞ胠韢郤铦뫨鿪鿬蛮臰", 0));
		StatusStrip obj2 = this.a;
		Size size = new Size(632, 22);
		((Control)obj2).set_Size(size);
		((Control)this.a).set_TabIndex(6);
		((Control)this.a).set_Text(global::C.a("럣鋥觧黩駫鷭ꏯ蛱蛳鿵裷", 7));
		((ToolStripItem)this.a).set_Name(global::C.a("뇤裦蛨蟪뻬鯮菰髲藴ꓶ跸髺觼諾爀伂搄攆氈朊", 8));
		ToolStripStatusLabel obj3 = this.a;
		size = new Size(39, 17);
		((ToolStripItem)obj3).set_Size(size);
		((ToolStripItem)this.a).set_Text(global::C.a("賞闠苢釤鋦髨", 2));
		this.a.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject(global::C.a("뛡難菥跧ꓩ菫諭闯믱駳韵鿷鿹냻韽珿瘁⨃伅攇欉欋欍䌏昑易猕礗眙", 5)));
		this.a.set_TransparentColor(Color.Transparent);
		this.a.get_Images().SetKeyName(0, global::C.a("\ua7e3諥蟧駩觫諭뛯鷱飳鋵鷷裹", 7));
		this.a.get_Images().SetKeyName(1, global::C.a("꿟鋡臣裥껧藩胫諭闯胱", 3));
		((Control)this.a.get_BottomToolStripPanel()).get_Controls().Add((Control)(object)this.a);
		((Control)this.a.get_ContentPanel()).get_Controls().Add((Control)(object)this.a);
		ToolStripContentPanel contentPanel = this.a.get_ContentPanel();
		size = new Size(632, 431);
		((Control)contentPanel).set_Size(size);
		((Control)this.a).set_Dock((DockStyle)5);
		ToolStripContainer obj4 = this.a;
		location = new Point(0, 0);
		((Control)obj4).set_Location(location);
		((Control)this.a).set_Name(global::C.a("諝迟跡裣뗥鳧飩藫黭돯鷱髳苵駷鏹鋻鯽狿", 1));
		ToolStripContainer obj5 = this.a;
		size = new Size(632, 453);
		((Control)obj5).set_Size(size);
		((Control)this.a).set_TabIndex(7);
		((Control)this.a).set_Text(global::C.a("듟跡诣諥믧黩黫蟭胯뇱鯳飵賷鯹闻都旿瀁㔃", 3));
		this.a.set_Dock((DockStyle)5);
		SplitContainer obj6 = this.a;
		location = new Point(0, 0);
		((Control)obj6).set_Location(location);
		((Control)this.a).set_Name(global::C.a("럣雥蓧菩飫귭鿯鳱胳韵釷铹駻賽", 7));
		((Control)this.a.get_Panel1()).get_Controls().Add((Control)(object)this.a);
		((Control)this.a.get_Panel2()).get_Controls().Add((Control)(object)this.a);
		SplitContainer obj7 = this.a;
		size = new Size(632, 431);
		((Control)obj7).set_Size(size);
		this.a.set_SplitterDistance(211);
		((Control)this.a).set_TabIndex(0);
		this.a.set_Text(global::C.a("軜꿞跠諢釤ꓦ蛨藪駬軮飰鷲郴藶죸", 0));
		((Control)this.a).set_Dock((DockStyle)5);
		this.a.set_ImageIndex(0);
		this.a.set_ImageList(this.a);
		TreeView obj8 = this.a;
		location = new Point(0, 0);
		((Control)obj8).set_Location(location);
		((Control)this.a).set_Name(global::C.a("觜귞蓠蛢돤軦賨鳪", 0));
		this.a.set_SelectedImageIndex(1);
		this.a.set_ShowLines(false);
		TreeView obj9 = this.a;
		size = new Size(211, 431);
		((Control)obj9).set_Size(size);
		((Control)this.a).set_TabIndex(0);
		((Control)this.a).set_Dock((DockStyle)5);
		this.a.set_LargeImageList(this.A);
		ListView obj10 = this.a;
		location = new Point(0, 0);
		((Control)obj10).set_Location(location);
		((Control)this.a).set_Name(global::C.a("꿢賤铦鷨뷪蓬諮蛰", 6));
		ListView obj11 = this.a;
		size = new Size(417, 431);
		((Control)obj11).set_Size(size);
		this.a.set_SmallImageList(this.b);
		((Control)this.a).set_TabIndex(0);
		this.a.set_UseCompatibleStateImageBehavior(false);
		this.A.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject(global::C.a("ꧤ軦髨鿪믬蛮铰蓲맴零诸鳺飼뛾氀戂戄戆䔈戊縌笎㼐娒研瘖縘縚东欞匠䘢䐤䨦", 8)));
		this.A.set_TransparentColor(Color.Transparent);
		this.A.get_Images().SetKeyName(0, global::C.a("駝鋟菡铣軥\ud9e7", 1));
		this.A.get_Images().SetKeyName(1, global::C.a("ꓢ韤蛦駨菪\udfec", 6));
		this.A.get_Images().SetKeyName(2, global::C.a("駝鋟菡铣軥\udbe7", 1));
		this.b.set_ImageStream((ImageListStreamer)componentResourceManager.GetObject(global::C.a("鏞裠郢釤뇦胨軪髬볮鳰鋲駴鯶냸雺鳼飾搀伂氄理紈┊䐌戎瀐琒瀔䐖洘椚砜縞䰠", 2)));
		this.b.set_TransparentColor(Color.Transparent);
		this.b.get_Images().SetKeyName(0, global::C.a("髜귞胠鏢跤훦", 0));
		this.b.get_Images().SetKeyName(1, global::C.a("ꋤ闦裨鯪藬\uddee", 8));
		this.b.get_Images().SetKeyName(2, global::C.a("\ua7df郡藣雥胧\ud9e9", 3));
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(632, 453);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)this.a);
		((Control)this).set_Name(global::C.a("엒\udeec쟮\ua8e8ퟪퟤ쏦ꃠ쟢컼웾쫸훺룴\uddf6쿰\ue5f2䘌㬎䠈⌊㜄㬆䰀", 2));
		((Form)this).set_Text(global::C.a("￨\ud8ea췤ꛦ\udde0퇢\ud9fc뻾\uddf8죺쳴쓶\udcf0뻲✌ㄎἈ䀊\u3104䘆⤀\u3102ℜ刞", 8));
		((Control)this.a).ResumeLayout(false);
		((Control)this.a).PerformLayout();
		((Control)this.a.get_BottomToolStripPanel()).ResumeLayout(false);
		((Control)this.a.get_BottomToolStripPanel()).PerformLayout();
		((Control)this.a.get_ContentPanel()).ResumeLayout(false);
		((Control)this.a).ResumeLayout(false);
		((Control)this.a).PerformLayout();
		((Control)this.a.get_Panel1()).ResumeLayout(false);
		((Control)this.a.get_Panel2()).ResumeLayout(false);
		((Control)this.a).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void a(object sender, EventArgs e)
	{
		B();
		A();
	}

	private void A()
	{
		TreeNode val = this.a.get_Nodes().Add(global::C.a("远냞軠韢", 0));
		val.get_Nodes().Add(global::C.a("냣铥跧迩ꗫ髭闯鿱엳", 7));
		val.get_Nodes().Add(global::C.a("럢韤苦賨ꋪ駬諮鳰쇲", 6));
		val.get_Nodes().Add(global::C.a("뇤闦賨軪ꓬ鯮铰黲웴", 8));
	}

	private void b()
	{
		this.a.get_Items().Clear();
		ListViewItem val = this.a.get_Items().Add(global::C.a("\ua8e3迥鯧黩뫫蟭闯藱뷳苵鷷韹췻", 7));
		val.set_ImageKey(global::C.a("ꓢ韤蛦駨菪\udcec", 6));
		val.get_SubItems().AddRange(new string[2]
		{
			global::C.a("鳞軠迢郤諦蟨\ud9ea", 2),
			global::C.a("鳞軠迢郤諦蟨\ud8ea", 2)
		});
		val = this.a.get_Items().Add(global::C.a("껡跣闥鳧볩藫语蟯믱胳鏵闷죹", 5));
		val.set_ImageKey(global::C.a("ꛠ釢蓤韦臨\ud9ea", 4));
		val.get_SubItems().AddRange(new string[2]
		{
			global::C.a("\ua7e3觥蓧鿩臫胭싯", 7),
			global::C.a("ꋠ賢觤鋦蓨藪\udeec", 4)
		});
		val = this.a.get_Items().Add(global::C.a("곟诡韣鋥뻧菩觫駭맯蛱釳鯵쯷", 3));
		val.set_ImageKey(global::C.a("ꋤ闦裨鯪藬\udcee", 8));
		val.get_SubItems().AddRange(new string[2]
		{
			global::C.a("ꏟ跡裣鏥藧蓩\udeeb", 3),
			global::C.a("ꏟ跡裣鏥藧蓩\udfeb", 3)
		});
	}

	private void B()
	{
		a((View)2);
		ColumnHeader val = this.a.get_Columns().Add(global::C.a("ꏟ跡裣鏥藧蓩\uddeb", 3));
		val.set_Width(90);
		a((View)1);
		val.set_Width(100);
		val = this.a.get_Columns().Add(global::C.a("黜냞跠離裤触\udbe8", 0));
		val.set_Width(70);
		val = this.a.get_Columns().Add(global::C.a("黜냞跠離裤触\udae8", 0));
		val.set_Width(70);
	}

	private void A(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void b(object sender, EventArgs e)
	{
	}

	private void B(object sender, EventArgs e)
	{
	}

	private void c()
	{
	}

	private void c(object sender, EventArgs e)
	{
		c();
	}

	private void C(object sender, EventArgs e)
	{
		c();
	}

	private void a(View a)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		this.a.set_View(a);
	}

	private void d(object sender, EventArgs e)
	{
		a((View)3);
	}

	private void D(object sender, EventArgs e)
	{
		a((View)1);
	}

	private void e(object sender, EventArgs e)
	{
		a((View)0);
	}

	private void E(object sender, EventArgs e)
	{
		a((View)2);
	}

	private void f(object sender, EventArgs e)
	{
		a((View)4);
	}

	private void F(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)global::B.a).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter(global::C.a("诞蓠鯢釤쟦꿨苪臬諮苰폲\uddf4\uddf6ퟸ迺藼课⠀缂⼄⤆紈猊礌", 2));
		((CommonDialog)val).ShowDialog((IWin32Window)(object)this);
		((FileDialog)val).get_FileName();
	}

	private void g(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_InitialDirectory(((ServerComputer)global::B.a).get_FileSystem().get_SpecialDirectories().get_MyDocuments());
		((FileDialog)val).set_Filter(global::C.a("뗠蛢鷤鏦짨귪蓬菮铰胲헴\udff6폸헺觼蟾甀⨂礄ⴆ✈缊甌笎", 4));
		((CommonDialog)val).ShowDialog((IWin32Window)(object)this);
		((FileDialog)val).get_FileName();
	}

	private void a(object sender, TreeViewEventArgs e)
	{
		b();
	}
}
