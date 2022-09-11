using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Remoting;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace ns0;

internal sealed class Class1 : ProgressBar
{
	internal enum Enum0
	{
		const_0 = 7000,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8,
		const_9,
		const_10,
		const_11,
		const_12,
		const_13,
		const_14,
		const_15,
		const_16,
		const_17,
		const_18,
		const_19,
		const_20,
		const_21,
		const_22,
		const_23,
		const_24,
		const_25
	}

	public override AnchorStyles AnchorStyles_0
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Anchor();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_Anchor(value);
		}
	}

	public override bool Boolean_0
	{
		get
		{
			return ((Control)this).get_AutoSize();
		}
		set
		{
			((Control)this).set_AutoSize(value);
		}
	}

	public override Point Point_0
	{
		get
		{
			return ((Control)this).get_AutoScrollOffset();
		}
		set
		{
			((Control)this).set_AutoScrollOffset(value);
		}
	}

	public override LayoutEngine LayoutEngine_0 => ((Control)this).get_LayoutEngine();

	public override Color Color_0
	{
		get
		{
			return ((Control)this).get_BackColor();
		}
		set
		{
			((Control)this).set_BackColor(value);
		}
	}

	public override BindingContext BindingContext_0
	{
		get
		{
			return ((Control)this).get_BindingContext();
		}
		set
		{
			((Control)this).set_BindingContext(value);
		}
	}

	protected override bool Boolean_1 => ((Control)this).get_CanRaiseEvents();

	public override ContextMenu ContextMenu_0
	{
		get
		{
			return ((Control)this).get_ContextMenu();
		}
		set
		{
			((Control)this).set_ContextMenu(value);
		}
	}

	public override ContextMenuStrip ContextMenuStrip_0
	{
		get
		{
			return ((Control)this).get_ContextMenuStrip();
		}
		set
		{
			((Control)this).set_ContextMenuStrip(value);
		}
	}

	public override Cursor Cursor_0
	{
		get
		{
			return ((Control)this).get_Cursor();
		}
		set
		{
			((Control)this).set_Cursor(value);
		}
	}

	protected override Cursor Cursor_1 => ((Control)this).get_DefaultCursor();

	protected override Padding Padding_0 => ((Control)this).get_DefaultMargin();

	protected override Size Size_0 => ((Control)this).get_DefaultMaximumSize();

	protected override Size Size_1 => ((Control)this).get_DefaultMinimumSize();

	protected override Padding Padding_1 => ((Control)this).get_DefaultPadding();

	public override Rectangle Rectangle_0 => ((Control)this).get_DisplayRectangle();

	public override DockStyle DockStyle_0
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_Dock();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_Dock(value);
		}
	}

	public override bool Boolean_2 => ((Control)this).get_Focused();

	public override Color Color_1
	{
		get
		{
			return ((Control)this).get_ForeColor();
		}
		set
		{
			((Control)this).set_ForeColor(value);
		}
	}

	public override Size Size_2
	{
		get
		{
			return ((Control)this).get_MaximumSize();
		}
		set
		{
			((Control)this).set_MaximumSize(value);
		}
	}

	public override Size Size_3
	{
		get
		{
			return ((Control)this).get_MinimumSize();
		}
		set
		{
			((Control)this).set_MinimumSize(value);
		}
	}

	public override RightToLeft RightToLeft_0
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_RightToLeft();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_RightToLeft(value);
		}
	}

	protected override bool Boolean_3 => ((Control)this).get_ScaleChildren();

	public override ISite ISite_0
	{
		get
		{
			return ((Control)this).get_Site();
		}
		set
		{
			((Control)this).set_Site(value);
		}
	}

	protected override bool Boolean_4 => ((Control)this).get_ShowKeyboardCues();

	protected override bool Boolean_5 => ((Control)this).get_ShowFocusCues();

	protected override bool Boolean_6 => ((Control)this).get_CanEnableIme();

	protected override ImeMode ImeMode_0
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_ImeModeBase();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_ImeModeBase(value);
		}
	}

	protected override CreateParams CreateParams_0 => ((ProgressBar)this).get_CreateParams();

	public override bool Boolean_7
	{
		get
		{
			return ((ProgressBar)this).get_AllowDrop();
		}
		set
		{
			((ProgressBar)this).set_AllowDrop(value);
		}
	}

	public override Image Image_0
	{
		get
		{
			return ((ProgressBar)this).get_BackgroundImage();
		}
		set
		{
			((ProgressBar)this).set_BackgroundImage(value);
		}
	}

	public override ImageLayout ImageLayout_0
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((ProgressBar)this).get_BackgroundImageLayout();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((ProgressBar)this).set_BackgroundImageLayout(value);
		}
	}

	protected override ImeMode ImeMode_1 => ((ProgressBar)this).get_DefaultImeMode();

	protected override Size Size_4 => ((ProgressBar)this).get_DefaultSize();

	protected override bool Boolean_8
	{
		get
		{
			return ((ProgressBar)this).get_DoubleBuffered();
		}
		set
		{
			((ProgressBar)this).set_DoubleBuffered(value);
		}
	}

	public override Font Font_0
	{
		get
		{
			return ((ProgressBar)this).get_Font();
		}
		set
		{
			((ProgressBar)this).set_Font(value);
		}
	}

	public override bool Boolean_9
	{
		get
		{
			return ((ProgressBar)this).get_RightToLeftLayout();
		}
		set
		{
			((ProgressBar)this).set_RightToLeftLayout(value);
		}
	}

	public override string String_0
	{
		get
		{
			return ((ProgressBar)this).get_Text();
		}
		set
		{
			((ProgressBar)this).set_Text(value);
		}
	}

	internal static byte[] smethod_0()
	{
		return Class10.smethod_0(Class0.smethod_0(), new byte[31]
		{
			194, 96, 26, 22, 51, 187, 47, 131, 174, 58,
			13, 11, 138, 1, 20, 155, 10, 227, 215, 89,
			78, 188, 116, 30, 86, 88, 225, 183, 160, 148,
			133
		});
	}

	public override bool vmethod_0(object object_0)
	{
		return ((object)this).Equals(object_0);
	}

	public override int vmethod_1()
	{
		return ((object)this).GetHashCode();
	}

	public override object vmethod_2()
	{
		return ((MarshalByRefObject)this).InitializeLifetimeService();
	}

	public override ObjRef vmethod_3(Type type_0)
	{
		return ((MarshalByRefObject)this).CreateObjRef(type_0);
	}

	protected override object vmethod_4(Type type_0)
	{
		return ((Component)this).GetService(type_0);
	}

	protected override AccessibleObject vmethod_5(int int_0)
	{
		return ((Control)this).GetAccessibilityObjectById(int_0);
	}

	public override Size vmethod_6(Size size_0)
	{
		return ((Control)this).GetPreferredSize(size_0);
	}

	protected override AccessibleObject vmethod_7()
	{
		return ((Control)this).CreateAccessibilityInstance();
	}

	protected override ControlCollection vmethod_8()
	{
		return ((Control)this).CreateControlsInstance();
	}

	protected override void vmethod_9(ref Message message_0)
	{
		((Control)this).DefWndProc(ref message_0);
	}

	protected override void vmethod_10()
	{
		((Control)this).DestroyHandle();
	}

	protected override void vmethod_11(bool bool_0)
	{
		((Control)this).Dispose(bool_0);
	}

	protected override Rectangle vmethod_12(Rectangle rectangle_0, SizeF sizeF_0, BoundsSpecified boundsSpecified_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return ((Control)this).GetScaledBounds(rectangle_0, sizeF_0, boundsSpecified_0);
	}

	protected override void vmethod_13()
	{
		((Control)this).InitLayout();
	}

	protected override bool vmethod_14(char char_0)
	{
		return ((Control)this).IsInputChar(char_0);
	}

	protected override bool vmethod_15(Keys keys_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((Control)this).IsInputKey(keys_0);
	}

	protected override void vmethod_16(Rectangle rectangle_0)
	{
		((Control)this).NotifyInvalidate(rectangle_0);
	}

	protected override void vmethod_17(EventArgs eventArgs_0)
	{
		((Control)this).OnAutoSizeChanged(eventArgs_0);
	}

	protected override void vmethod_18(EventArgs eventArgs_0)
	{
		((Control)this).OnBackgroundImageChanged(eventArgs_0);
	}

	protected override void vmethod_19(EventArgs eventArgs_0)
	{
		((Control)this).OnBackgroundImageLayoutChanged(eventArgs_0);
	}

	protected override void vmethod_20(EventArgs eventArgs_0)
	{
		((Control)this).OnBindingContextChanged(eventArgs_0);
	}

	protected override void vmethod_21(EventArgs eventArgs_0)
	{
		((Control)this).OnCausesValidationChanged(eventArgs_0);
	}

	protected override void vmethod_22(EventArgs eventArgs_0)
	{
		((Control)this).OnContextMenuChanged(eventArgs_0);
	}

	protected override void vmethod_23(EventArgs eventArgs_0)
	{
		((Control)this).OnContextMenuStripChanged(eventArgs_0);
	}

	protected override void vmethod_24(EventArgs eventArgs_0)
	{
		((Control)this).OnCursorChanged(eventArgs_0);
	}

	protected override void vmethod_25(EventArgs eventArgs_0)
	{
		((Control)this).OnDockChanged(eventArgs_0);
	}

	protected override void vmethod_26(EventArgs eventArgs_0)
	{
		((Control)this).OnEnabledChanged(eventArgs_0);
	}

	protected override void vmethod_27(EventArgs eventArgs_0)
	{
		((Control)this).OnFontChanged(eventArgs_0);
	}

	protected override void vmethod_28(EventArgs eventArgs_0)
	{
		((Control)this).OnRightToLeftChanged(eventArgs_0);
	}

	protected override void vmethod_29(Message message_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).OnNotifyMessage(message_0);
	}

	protected override void vmethod_30(EventArgs eventArgs_0)
	{
		((Control)this).OnParentBackColorChanged(eventArgs_0);
	}

	protected override void vmethod_31(EventArgs eventArgs_0)
	{
		((Control)this).OnParentBackgroundImageChanged(eventArgs_0);
	}

	protected override void vmethod_32(EventArgs eventArgs_0)
	{
		((Control)this).OnParentBindingContextChanged(eventArgs_0);
	}

	protected override void vmethod_33(EventArgs eventArgs_0)
	{
		((Control)this).OnParentCursorChanged(eventArgs_0);
	}

	protected override void vmethod_34(EventArgs eventArgs_0)
	{
		((Control)this).OnParentEnabledChanged(eventArgs_0);
	}

	protected override void vmethod_35(EventArgs eventArgs_0)
	{
		((Control)this).OnParentFontChanged(eventArgs_0);
	}

	protected override void vmethod_36(EventArgs eventArgs_0)
	{
		((Control)this).OnParentForeColorChanged(eventArgs_0);
	}

	protected override void vmethod_37(EventArgs eventArgs_0)
	{
		((Control)this).OnParentRightToLeftChanged(eventArgs_0);
	}

	protected override void vmethod_38(EventArgs eventArgs_0)
	{
		((Control)this).OnParentVisibleChanged(eventArgs_0);
	}

	protected override void vmethod_39(PaintEventArgs paintEventArgs_0)
	{
		((Control)this).OnPrint(paintEventArgs_0);
	}

	protected override void vmethod_40(EventArgs eventArgs_0)
	{
		((Control)this).OnTabIndexChanged(eventArgs_0);
	}

	protected override void vmethod_41(EventArgs eventArgs_0)
	{
		((Control)this).OnTabStopChanged(eventArgs_0);
	}

	protected override void vmethod_42(EventArgs eventArgs_0)
	{
		((Control)this).OnTextChanged(eventArgs_0);
	}

	protected override void vmethod_43(EventArgs eventArgs_0)
	{
		((Control)this).OnVisibleChanged(eventArgs_0);
	}

	protected override void vmethod_44(EventArgs eventArgs_0)
	{
		((Control)this).OnParentChanged(eventArgs_0);
	}

	protected override void vmethod_45(EventArgs eventArgs_0)
	{
		((Control)this).OnClick(eventArgs_0);
	}

	protected override void vmethod_46(EventArgs eventArgs_0)
	{
		((Control)this).OnClientSizeChanged(eventArgs_0);
	}

	protected override void vmethod_47(ControlEventArgs controlEventArgs_0)
	{
		((Control)this).OnControlAdded(controlEventArgs_0);
	}

	protected override void vmethod_48(ControlEventArgs controlEventArgs_0)
	{
		((Control)this).OnControlRemoved(controlEventArgs_0);
	}

	protected override void vmethod_49()
	{
		((Control)this).OnCreateControl();
	}

	protected override void bcWcu660RGPiogQvcN44Mmw9xRXfTKAnyEResHjogcEQWNHcCqUxOWx4e7trdPMYutPE6d8pErJyjYXse6ErekSuaGpoRUp598Y5syxUWkVwvd84jnu92DehIdmQx2ZjmqBqRZzN2ZT5h7i1nhbI(EventArgs eventArgs_0)
	{
		((Control)this).OnLocationChanged(eventArgs_0);
	}

	protected override void vmethod_50(EventArgs eventArgs_0)
	{
		((Control)this).OnDoubleClick(eventArgs_0);
	}

	protected override void vmethod_51(DragEventArgs dragEventArgs_0)
	{
		((Control)this).OnDragEnter(dragEventArgs_0);
	}

	protected override void vmethod_52(DragEventArgs dragEventArgs_0)
	{
		((Control)this).OnDragOver(dragEventArgs_0);
	}

	protected override void vmethod_53(EventArgs eventArgs_0)
	{
		((Control)this).OnDragLeave(eventArgs_0);
	}

	protected override void vmethod_54(DragEventArgs dragEventArgs_0)
	{
		((Control)this).OnDragDrop(dragEventArgs_0);
	}

	protected override void vmethod_55(GiveFeedbackEventArgs giveFeedbackEventArgs_0)
	{
		((Control)this).OnGiveFeedback(giveFeedbackEventArgs_0);
	}

	protected override void vmethod_56(EventArgs eventArgs_0)
	{
		((Control)this).OnEnter(eventArgs_0);
	}

	protected override void vmethod_57(EventArgs eventArgs_0)
	{
		((Control)this).OnGotFocus(eventArgs_0);
	}

	protected override void vmethod_58(HelpEventArgs helpEventArgs_0)
	{
		((Control)this).OnHelpRequested(helpEventArgs_0);
	}

	protected override void vmethod_59(InvalidateEventArgs invalidateEventArgs_0)
	{
		((Control)this).OnInvalidated(invalidateEventArgs_0);
	}

	protected override void vmethod_60(KeyEventArgs keyEventArgs_0)
	{
		((Control)this).OnKeyDown(keyEventArgs_0);
	}

	protected override void vmethod_61(KeyPressEventArgs keyPressEventArgs_0)
	{
		((Control)this).OnKeyPress(keyPressEventArgs_0);
	}

	protected override void vmethod_62(KeyEventArgs keyEventArgs_0)
	{
		((Control)this).OnKeyUp(keyEventArgs_0);
	}

	protected override void vmethod_63(LayoutEventArgs layoutEventArgs_0)
	{
		((Control)this).OnLayout(layoutEventArgs_0);
	}

	protected override void vmethod_64(EventArgs eventArgs_0)
	{
		((Control)this).OnLeave(eventArgs_0);
	}

	protected override void vmethod_65(EventArgs eventArgs_0)
	{
		((Control)this).OnLostFocus(eventArgs_0);
	}

	protected override void vmethod_66(EventArgs eventArgs_0)
	{
		((Control)this).OnMarginChanged(eventArgs_0);
	}

	protected override void vmethod_67(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseDoubleClick(mouseEventArgs_0);
	}

	protected override void vmethod_68(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseClick(mouseEventArgs_0);
	}

	protected override void vmethod_69(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseCaptureChanged(eventArgs_0);
	}

	protected override void vmethod_70(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseDown(mouseEventArgs_0);
	}

	protected override void vmethod_71(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseEnter(eventArgs_0);
	}

	protected override void vmethod_72(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseLeave(eventArgs_0);
	}

	protected override void vmethod_73(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseHover(eventArgs_0);
	}

	protected override void vmethod_74(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseMove(mouseEventArgs_0);
	}

	protected override void vmethod_75(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseUp(mouseEventArgs_0);
	}

	protected override void vmethod_76(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseWheel(mouseEventArgs_0);
	}

	protected override void vmethod_77(EventArgs eventArgs_0)
	{
		((Control)this).OnMove(eventArgs_0);
	}

	protected override void vmethod_78(PaintEventArgs paintEventArgs_0)
	{
		((Control)this).OnPaint(paintEventArgs_0);
	}

	protected override void vmethod_79(EventArgs eventArgs_0)
	{
		((Control)this).OnPaddingChanged(eventArgs_0);
	}

	protected override void vmethod_80(PaintEventArgs paintEventArgs_0)
	{
		((Control)this).OnPaintBackground(paintEventArgs_0);
	}

	protected override void vmethod_81(QueryContinueDragEventArgs queryContinueDragEventArgs_0)
	{
		((Control)this).OnQueryContinueDrag(queryContinueDragEventArgs_0);
	}

	protected override void vmethod_82(EventArgs eventArgs_0)
	{
		((Control)this).OnRegionChanged(eventArgs_0);
	}

	protected override void vmethod_83(EventArgs eventArgs_0)
	{
		((Control)this).OnResize(eventArgs_0);
	}

	protected override void vmethod_84(PreviewKeyDownEventArgs previewKeyDownEventArgs_0)
	{
		((Control)this).OnPreviewKeyDown(previewKeyDownEventArgs_0);
	}

	protected override void vmethod_85(EventArgs eventArgs_0)
	{
		((Control)this).OnSizeChanged(eventArgs_0);
	}

	protected override void vmethod_86(UICuesEventArgs uicuesEventArgs_0)
	{
		((Control)this).OnChangeUICues(uicuesEventArgs_0);
	}

	protected override void vmethod_87(EventArgs eventArgs_0)
	{
		((Control)this).OnStyleChanged(eventArgs_0);
	}

	protected override void vmethod_88(EventArgs eventArgs_0)
	{
		((Control)this).OnSystemColorsChanged(eventArgs_0);
	}

	protected override void vmethod_89(CancelEventArgs cancelEventArgs_0)
	{
		((Control)this).OnValidating(cancelEventArgs_0);
	}

	protected override void vmethod_90(EventArgs eventArgs_0)
	{
		((Control)this).OnValidated(eventArgs_0);
	}

	public override bool vmethod_91(ref Message message_0)
	{
		return ((Control)this).PreProcessMessage(ref message_0);
	}

	protected override bool vmethod_92(ref Message message_0, Keys keys_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return ((Control)this).ProcessCmdKey(ref message_0, keys_0);
	}

	protected override bool vmethod_93(char char_0)
	{
		return ((Control)this).ProcessDialogChar(char_0);
	}

	protected override bool vmethod_94(Keys keys_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((Control)this).ProcessDialogKey(keys_0);
	}

	protected override bool vmethod_95(ref Message message_0)
	{
		return ((Control)this).ProcessKeyEventArgs(ref message_0);
	}

	protected override bool vmethod_96(ref Message message_0)
	{
		return ((Control)this).ProcessKeyMessage(ref message_0);
	}

	protected override bool vmethod_97(ref Message message_0)
	{
		return ((Control)this).ProcessKeyPreview(ref message_0);
	}

	protected override bool vmethod_98(char char_0)
	{
		return ((Control)this).ProcessMnemonic(char_0);
	}

	public override void vmethod_99()
	{
		((Control)this).ResetBackColor();
	}

	public override void vmethod_100()
	{
		((Control)this).ResetCursor();
	}

	public override void vmethod_101()
	{
		((Control)this).ResetFont();
	}

	public override void vmethod_102()
	{
		((Control)this).ResetRightToLeft();
	}

	public override void vmethod_103()
	{
		((Control)this).Refresh();
	}

	public override void vmethod_104()
	{
		((Control)this).ResetText();
	}

	protected override void vmethod_105(SizeF sizeF_0, BoundsSpecified boundsSpecified_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).ScaleControl(sizeF_0, boundsSpecified_0);
	}

	protected override void vmethod_106(float float_0, float float_1)
	{
		((Control)this).ScaleCore(float_0, float_1);
	}

	protected override void vmethod_107(bool bool_0, bool bool_1)
	{
		((Control)this).Select(bool_0, bool_1);
	}

	protected override void vmethod_108(int int_0, int int_1, int int_2, int int_3, BoundsSpecified boundsSpecified_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetBoundsCore(int_0, int_1, int_2, int_3, boundsSpecified_0);
	}

	protected override void vmethod_109(int int_0, int int_1)
	{
		((Control)this).SetClientSizeCore(int_0, int_1);
	}

	protected override Size vmethod_110(Size size_0)
	{
		return ((Control)this).SizeFromClientSize(size_0);
	}

	protected override void vmethod_111(bool bool_0)
	{
		((Control)this).SetVisibleCore(bool_0);
	}

	protected override void vmethod_112(ref Message message_0)
	{
		((Control)this).WndProc(ref message_0);
	}

	protected override void vmethod_113(EventArgs eventArgs_0)
	{
		((Control)this).OnImeModeChanged(eventArgs_0);
	}

	protected override void vmethod_114(EventArgs eventArgs_0)
	{
		((ProgressBar)this).OnBackColorChanged(eventArgs_0);
	}

	protected override void vmethod_115(EventArgs eventArgs_0)
	{
		((ProgressBar)this).OnForeColorChanged(eventArgs_0);
	}

	protected override void vmethod_116()
	{
		((ProgressBar)this).CreateHandle();
	}

	protected override void vmethod_117(EventArgs eventArgs_0)
	{
		((ProgressBar)this).OnHandleCreated(eventArgs_0);
	}

	protected override void vmethod_118(EventArgs eventArgs_0)
	{
		((ProgressBar)this).OnHandleDestroyed(eventArgs_0);
	}

	protected override void vmethod_119(EventArgs eventArgs_0)
	{
		((ProgressBar)this).OnRightToLeftLayoutChanged(eventArgs_0);
	}

	public override void vmethod_120()
	{
		((ProgressBar)this).ResetForeColor();
	}

	public override string vmethod_121()
	{
		return ((ProgressBar)this).ToString();
	}
}
