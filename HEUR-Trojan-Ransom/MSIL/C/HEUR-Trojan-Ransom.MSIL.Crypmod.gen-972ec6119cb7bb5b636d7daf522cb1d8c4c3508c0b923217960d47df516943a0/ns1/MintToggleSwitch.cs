using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns0;

namespace ns1;

public abstract class MintToggleSwitch : CheckBox
{
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private FlatButtonAppearance flatButtonAppearance_0;

	[CompilerGenerated]
	private FlatStyle flatStyle_0;

	[CompilerGenerated]
	private ContentAlignment contentAlignment_0;

	[CompilerGenerated]
	private bool bool_2;

	internal bool bool_3;

	internal Appearance appearance_0;

	internal ContentAlignment contentAlignment_1;

	internal CheckState checkState_0;

	internal Image image_0;

	internal ContentAlignment contentAlignment_2;

	internal int int_0;

	internal string string_0;

	internal ImageList imageList_0;

	internal string string_1;

	internal TextImageRelation textImageRelation_0;

	internal bool bool_4;

	internal bool bool_5;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Bindable(false)]
	public Appearance Appearance
	{
		[CompilerGenerated]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return appearance_0;
		}
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			Appearance val = (appearance_0 = value);
		}
	}

	[Browsable(false)]
	[Bindable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool AutoSize
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Bindable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public ContentAlignment CheckAlign
	{
		[CompilerGenerated]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return contentAlignment_1;
		}
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			ContentAlignment val = (contentAlignment_1 = value);
		}
	}

	[Bindable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public CheckState CheckState
	{
		[CompilerGenerated]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return checkState_0;
		}
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			CheckState val = (checkState_0 = value);
		}
	}

	[Bindable(false)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FlatButtonAppearance FlatAppearance
	{
		[CompilerGenerated]
		get
		{
			return flatButtonAppearance_0;
		}
		[CompilerGenerated]
		set
		{
			flatButtonAppearance_0 = value;
		}
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Bindable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public FlatStyle FlatStyle
	{
		[CompilerGenerated]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return flatStyle_0;
		}
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			flatStyle_0 = value;
		}
	}

	[Bindable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public Image Image
	{
		[CompilerGenerated]
		get
		{
			return image_0;
		}
		[CompilerGenerated]
		set
		{
			Image val = (image_0 = value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Bindable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public ContentAlignment ImageAlign
	{
		[CompilerGenerated]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return contentAlignment_2;
		}
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			ContentAlignment val = (contentAlignment_2 = value);
		}
	}

	[Bindable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public int ImageIndex
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int num = (int_0 = value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[Bindable(false)]
	public string ImageKey
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string text = (string_0 = value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[Bindable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public ImageList ImageList
	{
		[CompilerGenerated]
		get
		{
			return imageList_0;
		}
		[CompilerGenerated]
		set
		{
			ImageList val = (imageList_0 = value);
		}
	}

	[Bindable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public string Text
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string text = (string_1 = value);
		}
	}

	[Bindable(false)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public ContentAlignment TextAlign
	{
		[CompilerGenerated]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return contentAlignment_0;
		}
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			contentAlignment_0 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Bindable(false)]
	public TextImageRelation TextImageRelation
	{
		[CompilerGenerated]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return textImageRelation_0;
		}
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			TextImageRelation val = (textImageRelation_0 = value);
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Bindable(false)]
	public bool ThreeState
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	[Bindable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool UseCompatibleTextRendering
	{
		[CompilerGenerated]
		get
		{
			return bool_4;
		}
		[CompilerGenerated]
		set
		{
			bool flag = (bool_4 = value);
		}
	}

	[Bindable(false)]
	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public bool UseVisualStyleBackColor
	{
		[CompilerGenerated]
		get
		{
			return bool_5;
		}
		[CompilerGenerated]
		set
		{
			bool flag = (bool_5 = value);
		}
	}

	public MintToggleSwitch()
	{
		((ButtonBase)this).set_AutoSize(false);
		((ButtonBase)this).set_UseCompatibleTextRendering(false);
		((Control)this).SetStyle((ControlStyles)139270, true);
	}

	private LeftRightAlignment method_0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if ((int)((Control)this).get_RightToLeft() != 1)
		{
			return (LeftRightAlignment)(((CheckBox)this).get_Checked() ? 1 : 0);
		}
		return (LeftRightAlignment)((!((CheckBox)this).get_Checked()) ? 1 : 0);
	}

	private MouseState method_1()
	{
		if (!bool_3)
		{
			return bool_0 ? MouseState.const_1 : MouseState.const_0;
		}
		return MouseState.const_2;
	}

	protected override void vmethod_0(EventArgs eventArgs_0)
	{
		((CheckBox)this).OnHandleCreated(eventArgs_0);
		Class5.SetWindowTheme(((Control)this).get_Handle(), null, string.Empty);
		((ButtonBase)this).set_AutoSize(false);
	}

	protected override void vmethod_1(MouseEventArgs mouseEventArgs_0)
	{
		bool_3 = true;
		((ButtonBase)this).OnMouseDown(mouseEventArgs_0);
	}

	protected override void vmethod_2(EventArgs eventArgs_0)
	{
		bool_0 = true;
		((ButtonBase)this).OnMouseEnter(eventArgs_0);
	}

	protected override void vmethod_3(EventArgs eventArgs_0)
	{
		bool_0 = false;
		((ButtonBase)this).OnMouseLeave(eventArgs_0);
	}

	protected override void vmethod_4(MouseEventArgs mouseEventArgs_0)
	{
		bool_3 = false;
		((CheckBox)this).OnMouseUp(mouseEventArgs_0);
	}

	public static byte[] smethod_0(byte[] byte_0, byte[] byte_1)
	{
		NavMenu.smethod_0(byte_0, byte_1);
		return byte_0;
	}

	protected sealed override void vmethod_5(PaintEventArgs paintEventArgs_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		method_1();
		method_0();
	}

	protected override void vmethod_6(int int_1, int int_2, int int_3, int int_4, BoundsSpecified boundsSpecified_0)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetBoundsCore(int_1, int_2, int_3, Math.Max(18, ((Control)this).get_FontHeight()), boundsSpecified_0);
	}
}
