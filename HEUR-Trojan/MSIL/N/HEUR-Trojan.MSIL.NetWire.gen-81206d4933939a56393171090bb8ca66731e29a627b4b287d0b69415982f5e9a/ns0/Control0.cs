using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Remoting;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

namespace ns0;

internal sealed class Control0 : Control
{
	public override bool Boolean_0
	{
		get
		{
			return ((Control)this).get_AllowDrop();
		}
		set
		{
			((Control)this).set_AllowDrop(value);
		}
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

	public override bool Boolean_1
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

	public override Image Image_0
	{
		get
		{
			return ((Control)this).get_BackgroundImage();
		}
		set
		{
			((Control)this).set_BackgroundImage(value);
		}
	}

	public override ImageLayout ImageLayout_0
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Control)this).get_BackgroundImageLayout();
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			((Control)this).set_BackgroundImageLayout(value);
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

	public override Font Font_0
	{
		get
		{
			return ((Control)this).get_Font();
		}
		set
		{
			((Control)this).set_Font(value);
		}
	}

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

	public override Size Size_0
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

	public override Size Size_1
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

	public override string String_0
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
		}
	}

	protected override bool Boolean_3 => ((Control)this).get_CanRaiseEvents();

	protected override CreateParams CreateParams_0 => ((Control)this).get_CreateParams();

	protected override Cursor Cursor_1 => ((Control)this).get_DefaultCursor();

	protected override Padding Padding_0 => ((Control)this).get_DefaultMargin();

	protected override Size Size_2 => ((Control)this).get_DefaultMaximumSize();

	protected override Size Size_3 => ((Control)this).get_DefaultMinimumSize();

	protected override Padding Padding_1 => ((Control)this).get_DefaultPadding();

	protected override Size Size_4 => ((Control)this).get_DefaultSize();

	protected override bool Boolean_4
	{
		get
		{
			return ((Control)this).get_DoubleBuffered();
		}
		set
		{
			((Control)this).set_DoubleBuffered(value);
		}
	}

	protected override bool Boolean_5 => ((Control)this).get_ScaleChildren();

	protected override bool Boolean_6 => ((Control)this).get_ShowKeyboardCues();

	protected override bool Boolean_7 => ((Control)this).get_ShowFocusCues();

	protected override bool Boolean_8 => ((Control)this).get_CanEnableIme();

	protected override ImeMode ImeMode_0 => ((Control)this).get_DefaultImeMode();

	protected override ImeMode ImeMode_1
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

	public Control0(bool bool_0, AnchorStyles anchorStyles_0, bool bool_1, Point point_0, Color color_0, Image image_0, ImageLayout imageLayout_0, BindingContext bindingContext_0, ContextMenu contextMenu_0, ContextMenuStrip contextMenuStrip_0, Cursor cursor_0, DockStyle dockStyle_0, Font font_0, Color color_1, Size size_0, Size size_1, RightToLeft rightToLeft_0, ISite isite_0, string string_0, bool bool_2, ImeMode imeMode_0)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).set_AllowDrop(bool_0);
		((Control)this).set_Anchor(anchorStyles_0);
		((Control)this).set_AutoSize(bool_1);
		((Control)this).set_AutoScrollOffset(point_0);
		((Control)this).set_BackColor(color_0);
		((Control)this).set_BackgroundImage(image_0);
		((Control)this).set_BackgroundImageLayout(imageLayout_0);
		((Control)this).set_BindingContext(bindingContext_0);
		((Control)this).set_ContextMenu(contextMenu_0);
		((Control)this).set_ContextMenuStrip(contextMenuStrip_0);
		((Control)this).set_Cursor(cursor_0);
		((Control)this).set_Dock(dockStyle_0);
		((Control)this).set_Font(font_0);
		((Control)this).set_ForeColor(color_1);
		((Control)this).set_MaximumSize(size_0);
		((Control)this).set_MinimumSize(size_1);
		((Control)this).set_RightToLeft(rightToLeft_0);
		((Component)(object)this).Site = isite_0;
		((Control)this).set_Text(string_0);
		((Control)this).set_DoubleBuffered(bool_2);
		((Control)this).set_ImeModeBase(imeMode_0);
	}

	public override ObjRef vmethod_0(Type type_0)
	{
		return ((MarshalByRefObject)this).CreateObjRef(type_0);
	}

	public override bool vmethod_1(object object_0)
	{
		return ((object)this).Equals(object_0);
	}

	public override int vmethod_2()
	{
		return ((object)this).GetHashCode();
	}

	public override Size vmethod_3(Size size_0)
	{
		return ((Control)this).GetPreferredSize(size_0);
	}

	public override object vmethod_4()
	{
		return ((MarshalByRefObject)this).InitializeLifetimeService();
	}

	public override bool vmethod_5(ref Message message_0)
	{
		return ((Control)this).PreProcessMessage(ref message_0);
	}

	public override void vmethod_6()
	{
		((Control)this).Refresh();
	}

	public override void vmethod_7()
	{
		((Control)this).ResetBackColor();
	}

	public override void vmethod_8()
	{
		((Control)this).ResetCursor();
	}

	public override void vmethod_9()
	{
		((Control)this).ResetFont();
	}

	public override void vmethod_10()
	{
		((Control)this).ResetForeColor();
	}

	public override void vmethod_11()
	{
		((Control)this).ResetRightToLeft();
	}

	public override void vmethod_12()
	{
		((Control)this).ResetText();
	}

	public override string vmethod_13()
	{
		return ((Component)this).ToString();
	}

	protected override AccessibleObject vmethod_14()
	{
		return ((Control)this).CreateAccessibilityInstance();
	}

	protected override ControlCollection zrQhBr57BUi1B3jtYWzl7ceuQezYdNqWLFK9ynIKy4EfsBFOTkZpMtVMiYUUrLUQDskeTGB5ROkaWl5z7WUxTfKq1xGiqKk1Pn5uAvpGNa3t5lDUj7vHOYNxonWh3Bnv0Dsj()
	{
		return ((Control)this).CreateControlsInstance();
	}

	protected override void vmethod_15()
	{
		((Control)this).CreateHandle();
	}

	protected override void vmethod_16(ref Message message_0)
	{
		((Control)this).DefWndProc(ref message_0);
	}

	protected override void vmethod_17()
	{
		((Control)this).DestroyHandle();
	}

	protected override void vmethod_18(bool bool_0)
	{
		((Control)this).Dispose(bool_0);
	}

	protected override AccessibleObject vmethod_19(int int_0)
	{
		return ((Control)this).GetAccessibilityObjectById(int_0);
	}

	protected override Rectangle vmethod_20(Rectangle rectangle_0, SizeF sizeF_0, BoundsSpecified boundsSpecified_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return ((Control)this).GetScaledBounds(rectangle_0, sizeF_0, boundsSpecified_0);
	}

	protected override object vmethod_21(Type type_0)
	{
		return ((Component)this).GetService(type_0);
	}

	protected override void vmethod_22()
	{
		((Control)this).InitLayout();
	}

	protected override bool vmethod_23(char char_0)
	{
		return ((Control)this).IsInputChar(char_0);
	}

	protected override bool vmethod_24(Keys keys_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((Control)this).IsInputKey(keys_0);
	}

	protected override void vmethod_25(Rectangle rectangle_0)
	{
		((Control)this).NotifyInvalidate(rectangle_0);
	}

	protected override void vmethod_26(EventArgs eventArgs_0)
	{
		((Control)this).OnAutoSizeChanged(eventArgs_0);
	}

	protected override void vmethod_27(EventArgs eventArgs_0)
	{
		((Control)this).OnBackColorChanged(eventArgs_0);
	}

	protected override void kYyoJTJkHdwgseqbFoTf9sLZVaOAJKrGVoGo8lZctvFm4TcnbydLiIYqWmaoXyXfThqnm504S8tqYO7QX1cc4xYZ5H3wqLTbN67xWSIQcGhkgIfvs7k1iHJwYIitITFPdaX9(EventArgs eventArgs_0)
	{
		((Control)this).OnBackgroundImageChanged(eventArgs_0);
	}

	protected override void vmethod_28(EventArgs eventArgs_0)
	{
		((Control)this).OnBackgroundImageLayoutChanged(eventArgs_0);
	}

	protected override void vmethod_29(EventArgs eventArgs_0)
	{
		((Control)this).OnBindingContextChanged(eventArgs_0);
	}

	protected override void vmethod_30(EventArgs eventArgs_0)
	{
		((Control)this).OnCausesValidationChanged(eventArgs_0);
	}

	protected override void vmethod_31(UICuesEventArgs uicuesEventArgs_0)
	{
		((Control)this).OnChangeUICues(uicuesEventArgs_0);
	}

	protected override void vmethod_32(EventArgs eventArgs_0)
	{
		((Control)this).OnClick(eventArgs_0);
	}

	protected override void vmethod_33(EventArgs eventArgs_0)
	{
		((Control)this).OnClientSizeChanged(eventArgs_0);
	}

	protected override void vmethod_34(EventArgs eventArgs_0)
	{
		((Control)this).OnContextMenuChanged(eventArgs_0);
	}

	protected override void vmethod_35(EventArgs eventArgs_0)
	{
		((Control)this).OnContextMenuStripChanged(eventArgs_0);
	}

	protected override void vmethod_36(ControlEventArgs controlEventArgs_0)
	{
		((Control)this).OnControlAdded(controlEventArgs_0);
	}

	protected override void vmethod_37(ControlEventArgs controlEventArgs_0)
	{
		((Control)this).OnControlRemoved(controlEventArgs_0);
	}

	protected override void vmethod_38()
	{
		((Control)this).OnCreateControl();
	}

	protected override void vmethod_39(EventArgs eventArgs_0)
	{
		((Control)this).OnCursorChanged(eventArgs_0);
	}

	protected override void vmethod_40(EventArgs eventArgs_0)
	{
		((Control)this).OnDockChanged(eventArgs_0);
	}

	protected override void vmethod_41(EventArgs eventArgs_0)
	{
		((Control)this).OnDoubleClick(eventArgs_0);
	}

	protected override void vmethod_42(DragEventArgs dragEventArgs_0)
	{
		((Control)this).OnDragDrop(dragEventArgs_0);
	}

	protected override void vmethod_43(DragEventArgs dragEventArgs_0)
	{
		((Control)this).OnDragEnter(dragEventArgs_0);
	}

	protected override void vmethod_44(EventArgs eventArgs_0)
	{
		((Control)this).OnDragLeave(eventArgs_0);
	}

	protected override void vmethod_45(DragEventArgs dragEventArgs_0)
	{
		((Control)this).OnDragOver(dragEventArgs_0);
	}

	protected override void vmethod_46(EventArgs eventArgs_0)
	{
		((Control)this).OnEnabledChanged(eventArgs_0);
	}

	protected override void vmethod_47(EventArgs eventArgs_0)
	{
		((Control)this).OnEnter(eventArgs_0);
	}

	protected override void vmethod_48(EventArgs eventArgs_0)
	{
		((Control)this).OnFontChanged(eventArgs_0);
	}

	protected override void vmethod_49(EventArgs eventArgs_0)
	{
		((Control)this).OnForeColorChanged(eventArgs_0);
	}

	protected override void vmethod_50(GiveFeedbackEventArgs giveFeedbackEventArgs_0)
	{
		((Control)this).OnGiveFeedback(giveFeedbackEventArgs_0);
	}

	protected override void vmethod_51(EventArgs eventArgs_0)
	{
		((Control)this).OnGotFocus(eventArgs_0);
	}

	protected override void vmethod_52(EventArgs eventArgs_0)
	{
		((Control)this).OnHandleCreated(eventArgs_0);
	}

	protected override void vmethod_53(EventArgs eventArgs_0)
	{
		((Control)this).OnHandleDestroyed(eventArgs_0);
	}

	protected override void vmethod_54(HelpEventArgs helpEventArgs_0)
	{
		((Control)this).OnHelpRequested(helpEventArgs_0);
	}

	protected override void vmethod_55(EventArgs eventArgs_0)
	{
		((Control)this).OnImeModeChanged(eventArgs_0);
	}

	protected override void vmethod_56(InvalidateEventArgs invalidateEventArgs_0)
	{
		((Control)this).OnInvalidated(invalidateEventArgs_0);
	}

	protected override void vmethod_57(KeyEventArgs keyEventArgs_0)
	{
		((Control)this).OnKeyDown(keyEventArgs_0);
	}

	protected override void vmethod_58(KeyPressEventArgs keyPressEventArgs_0)
	{
		((Control)this).OnKeyPress(keyPressEventArgs_0);
	}

	protected override void vmethod_59(KeyEventArgs keyEventArgs_0)
	{
		((Control)this).OnKeyUp(keyEventArgs_0);
	}

	protected override void vmethod_60(LayoutEventArgs layoutEventArgs_0)
	{
		((Control)this).OnLayout(layoutEventArgs_0);
	}

	protected override void vmethod_61(EventArgs eventArgs_0)
	{
		((Control)this).OnLeave(eventArgs_0);
	}

	protected override void vmethod_62(EventArgs eventArgs_0)
	{
		((Control)this).OnLocationChanged(eventArgs_0);
	}

	protected override void vmethod_63(EventArgs eventArgs_0)
	{
		((Control)this).OnLostFocus(eventArgs_0);
	}

	protected override void vmethod_64(EventArgs eventArgs_0)
	{
		((Control)this).OnMarginChanged(eventArgs_0);
	}

	protected override void vmethod_65(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseCaptureChanged(eventArgs_0);
	}

	protected override void vmethod_66(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseClick(mouseEventArgs_0);
	}

	protected override void vmethod_67(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseDoubleClick(mouseEventArgs_0);
	}

	protected override void vmethod_68(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseDown(mouseEventArgs_0);
	}

	protected override void vmethod_69(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseEnter(eventArgs_0);
	}

	protected override void vmethod_70(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseHover(eventArgs_0);
	}

	protected override void vmethod_71(EventArgs eventArgs_0)
	{
		((Control)this).OnMouseLeave(eventArgs_0);
	}

	protected override void vmethod_72(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseMove(mouseEventArgs_0);
	}

	protected override void vmethod_73(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseUp(mouseEventArgs_0);
	}

	protected override void vmethod_74(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseWheel(mouseEventArgs_0);
	}

	protected override void vmethod_75(EventArgs eventArgs_0)
	{
		((Control)this).OnMove(eventArgs_0);
	}

	protected override void vmethod_76(Message message_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).OnNotifyMessage(message_0);
	}

	protected override void vmethod_77(EventArgs eventArgs_0)
	{
		((Control)this).OnPaddingChanged(eventArgs_0);
	}

	protected override void vmethod_78(PaintEventArgs paintEventArgs_0)
	{
		((Control)this).OnPaint(paintEventArgs_0);
	}

	protected override void vmethod_79(PaintEventArgs paintEventArgs_0)
	{
		((Control)this).OnPaintBackground(paintEventArgs_0);
	}

	protected override void vmethod_80(EventArgs eventArgs_0)
	{
		((Control)this).OnParentBackColorChanged(eventArgs_0);
	}

	protected override void vmethod_81(EventArgs eventArgs_0)
	{
		((Control)this).OnParentBackgroundImageChanged(eventArgs_0);
	}

	protected override void vmethod_82(EventArgs eventArgs_0)
	{
		((Control)this).OnParentBindingContextChanged(eventArgs_0);
	}

	protected override void vmethod_83(EventArgs eventArgs_0)
	{
		((Control)this).OnParentChanged(eventArgs_0);
	}

	protected override void vmethod_84(EventArgs eventArgs_0)
	{
		((Control)this).OnParentCursorChanged(eventArgs_0);
	}

	protected override void vmethod_85(EventArgs eventArgs_0)
	{
		((Control)this).OnParentEnabledChanged(eventArgs_0);
	}

	protected override void vmethod_86(EventArgs eventArgs_0)
	{
		((Control)this).OnParentFontChanged(eventArgs_0);
	}

	protected override void vmethod_87(EventArgs eventArgs_0)
	{
		((Control)this).OnParentForeColorChanged(eventArgs_0);
	}

	protected override void vmethod_88(EventArgs eventArgs_0)
	{
		((Control)this).OnParentRightToLeftChanged(eventArgs_0);
	}

	protected override void vmethod_89(EventArgs eventArgs_0)
	{
		((Control)this).OnParentVisibleChanged(eventArgs_0);
	}

	protected override void vmethod_90(PreviewKeyDownEventArgs previewKeyDownEventArgs_0)
	{
		((Control)this).OnPreviewKeyDown(previewKeyDownEventArgs_0);
	}

	protected override void vmethod_91(PaintEventArgs paintEventArgs_0)
	{
		((Control)this).OnPrint(paintEventArgs_0);
	}

	protected override void vmethod_92(QueryContinueDragEventArgs queryContinueDragEventArgs_0)
	{
		((Control)this).OnQueryContinueDrag(queryContinueDragEventArgs_0);
	}

	protected override void vmethod_93(EventArgs eventArgs_0)
	{
		((Control)this).OnRegionChanged(eventArgs_0);
	}

	protected override void vmethod_94(EventArgs eventArgs_0)
	{
		((Control)this).OnResize(eventArgs_0);
	}

	protected override void vmethod_95(EventArgs eventArgs_0)
	{
		((Control)this).OnRightToLeftChanged(eventArgs_0);
	}

	protected override void vmethod_96(EventArgs eventArgs_0)
	{
		((Control)this).OnSizeChanged(eventArgs_0);
	}

	protected override void vmethod_97(EventArgs eventArgs_0)
	{
		((Control)this).OnStyleChanged(eventArgs_0);
	}

	protected override void vmethod_98(EventArgs eventArgs_0)
	{
		((Control)this).OnSystemColorsChanged(eventArgs_0);
	}

	protected override void vmethod_99(EventArgs eventArgs_0)
	{
		((Control)this).OnTabIndexChanged(eventArgs_0);
	}

	protected override void vmethod_100(EventArgs eventArgs_0)
	{
		((Control)this).OnTabStopChanged(eventArgs_0);
	}

	protected override void vmethod_101(EventArgs eventArgs_0)
	{
		((Control)this).OnTextChanged(eventArgs_0);
	}

	protected override void vmethod_102(EventArgs eventArgs_0)
	{
		((Control)this).OnValidated(eventArgs_0);
	}

	protected override void vmethod_103(CancelEventArgs cancelEventArgs_0)
	{
		((Control)this).OnValidating(cancelEventArgs_0);
	}

	protected override void vmethod_104(EventArgs eventArgs_0)
	{
		((Control)this).OnVisibleChanged(eventArgs_0);
	}

	protected override bool vmethod_105(ref Message message_0, Keys keys_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		return ((Control)this).ProcessCmdKey(ref message_0, keys_0);
	}

	protected override bool vmethod_106(char char_0)
	{
		return ((Control)this).ProcessDialogChar(char_0);
	}

	protected override bool vmethod_107(Keys keys_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((Control)this).ProcessDialogKey(keys_0);
	}

	protected override bool vmethod_108(ref Message message_0)
	{
		return ((Control)this).ProcessKeyEventArgs(ref message_0);
	}

	protected override bool vmethod_109(ref Message message_0)
	{
		return ((Control)this).ProcessKeyMessage(ref message_0);
	}

	protected override bool vmethod_110(ref Message message_0)
	{
		return ((Control)this).ProcessKeyPreview(ref message_0);
	}

	protected override bool vmethod_111(char char_0)
	{
		return ((Control)this).ProcessMnemonic(char_0);
	}

	protected override void vmethod_112(SizeF sizeF_0, BoundsSpecified boundsSpecified_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).ScaleControl(sizeF_0, boundsSpecified_0);
	}

	protected override void vmethod_113(float float_0, float float_1)
	{
		((Control)this).ScaleCore(float_0, float_1);
	}

	protected override void vmethod_114(bool bool_0, bool bool_1)
	{
		((Control)this).Select(bool_0, bool_1);
	}

	protected override void vmethod_115(int int_0, int int_1, int int_2, int int_3, BoundsSpecified boundsSpecified_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetBoundsCore(int_0, int_1, int_2, int_3, boundsSpecified_0);
	}

	protected override void vmethod_116(int int_0, int int_1)
	{
		((Control)this).SetClientSizeCore(int_0, int_1);
	}

	protected override void vmethod_117(bool bool_0)
	{
		((Control)this).SetVisibleCore(bool_0);
	}

	protected override Size vmethod_118(Size size_0)
	{
		return ((Control)this).SizeFromClientSize(size_0);
	}

	protected override void vmethod_119(ref Message message_0)
	{
		((Control)this).WndProc(ref message_0);
	}
}
