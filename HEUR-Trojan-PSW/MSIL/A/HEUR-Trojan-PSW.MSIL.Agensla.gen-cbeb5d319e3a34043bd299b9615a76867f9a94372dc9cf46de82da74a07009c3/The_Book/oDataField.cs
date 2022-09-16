using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace The_Book;

[DesignerGenerated]
public class oDataField : UserControl
{
	public delegate void FieldSelectEventHandler(object sender, EventArgs e);

	private IContainer components;

	public static string CCCCCCC01 = "HhctKxW";

	public static string DDDDD01 = "waOLx";

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private FieldSelectEventHandler FieldSelectEvent;

	private eFieldMode _FieldMode;

	private int _TabPageIndex;

	private oDataField _next;

	private oDataField _Previous;

	private Form _Parent;

	[field: AccessedThroughProperty("top")]
	internal virtual Panel top
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Bottom")]
	internal virtual Panel Bottom
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Right")]
	internal virtual Panel Right
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Left")]
	internal virtual Panel Left
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MainPanel")]
	internal virtual Panel MainPanel
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MiddleSpace")]
	internal virtual Panel MiddleSpace
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnl_Right")]
	internal virtual Panel pnl_Right
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FieldText")]
	internal virtual Label FieldText
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pnl_Left")]
	internal virtual Panel pnl_Left
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual LinkLabel FieldSelector
	{
		[CompilerGenerated]
		get
		{
			return _FieldSelector;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = FieldSelector_Click;
			LinkLabel fieldSelector = _FieldSelector;
			if (fieldSelector != null)
			{
				((Control)fieldSelector).remove_Click(eventHandler);
			}
			_FieldSelector = value;
			fieldSelector = _FieldSelector;
			if (fieldSelector != null)
			{
				((Control)fieldSelector).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("FieldEdit")]
	internal virtual Label FieldEdit
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public eFieldMode FieldMode
	{
		get
		{
			return _FieldMode;
		}
		set
		{
			_FieldMode = value;
			switch (_FieldMode)
			{
			case eFieldMode.Edit:
				((Control)FieldEdit).set_Visible(true);
				FieldEdit.set_Text("");
				((Control)FieldText).set_Visible(false);
				break;
			case eFieldMode.View:
				((Control)FieldEdit).set_Visible(false);
				((Control)FieldText).set_Visible(true);
				break;
			}
		}
	}

	public int TabPageIndex
	{
		get
		{
			return _TabPageIndex;
		}
		set
		{
			_TabPageIndex = value;
		}
	}

	public oDataField NextControl => _next;

	public oDataField PreviousControl => _Previous;

	public string FieldName
	{
		get
		{
			string result = default(string);
			return result;
		}
	}

	public string DisplayName
	{
		get
		{
			string result = default(string);
			return result;
		}
	}

	public bool Mandatory => false;

	public bool ReadOnly => false;

	public event FieldSelectEventHandler FieldSelect
	{
		[CompilerGenerated]
		add
		{
			FieldSelectEventHandler fieldSelectEventHandler = FieldSelectEvent;
			FieldSelectEventHandler fieldSelectEventHandler2;
			do
			{
				fieldSelectEventHandler2 = fieldSelectEventHandler;
				FieldSelectEventHandler value2 = (FieldSelectEventHandler)Delegate.Combine(fieldSelectEventHandler2, value);
				fieldSelectEventHandler = Interlocked.CompareExchange(ref FieldSelectEvent, value2, fieldSelectEventHandler2);
			}
			while ((object)fieldSelectEventHandler != fieldSelectEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			FieldSelectEventHandler fieldSelectEventHandler = FieldSelectEvent;
			FieldSelectEventHandler fieldSelectEventHandler2;
			do
			{
				fieldSelectEventHandler2 = fieldSelectEventHandler;
				FieldSelectEventHandler value2 = (FieldSelectEventHandler)Delegate.Remove(fieldSelectEventHandler2, value);
				fieldSelectEventHandler = Interlocked.CompareExchange(ref FieldSelectEvent, value2, fieldSelectEventHandler2);
			}
			while ((object)fieldSelectEventHandler != fieldSelectEventHandler2);
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		top = new Panel();
		Bottom = new Panel();
		Right = new Panel();
		Left = new Panel();
		MainPanel = new Panel();
		MiddleSpace = new Panel();
		pnl_Right = new Panel();
		FieldText = new Label();
		pnl_Left = new Panel();
		FieldSelector = new LinkLabel();
		FieldEdit = new Label();
		((Control)MainPanel).SuspendLayout();
		((Control)pnl_Right).SuspendLayout();
		((Control)pnl_Left).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)top).set_Dock((DockStyle)1);
		((Control)top).set_Location(new Point(0, 0));
		((Control)top).set_Name("top");
		((Control)top).set_Size(new Size(332, 1));
		((Control)Bottom).set_Dock((DockStyle)2);
		((Control)Bottom).set_Location(new Point(0, 20));
		((Control)Bottom).set_Name("Bottom");
		((Control)Bottom).set_Size(new Size(332, 1));
		((Control)Right).set_Dock((DockStyle)4);
		((Control)Right).set_Location(new Point(331, 1));
		((Control)Right).set_Name("Right");
		((Control)Right).set_Size(new Size(1, 19));
		((Control)Left).set_Dock((DockStyle)3);
		((Control)Left).set_Location(new Point(0, 1));
		((Control)Left).set_Name("Left");
		((Control)Left).set_Size(new Size(1, 19));
		((Control)MainPanel).get_Controls().Add((Control)(object)MiddleSpace);
		((Control)MainPanel).get_Controls().Add((Control)(object)pnl_Right);
		((Control)MainPanel).get_Controls().Add((Control)(object)pnl_Left);
		((Control)MainPanel).set_Dock((DockStyle)5);
		((Control)MainPanel).set_Location(new Point(0, 0));
		((Control)MainPanel).set_Name("MainPanel");
		((Control)MainPanel).set_Size(new Size(332, 21));
		((Control)MiddleSpace).set_Dock((DockStyle)5);
		((Control)MiddleSpace).set_Location(new Point(90, 0));
		((Control)MiddleSpace).set_Name("MiddleSpace");
		((Control)MiddleSpace).set_Size(new Size(11, 21));
		((Control)pnl_Right).get_Controls().Add((Control)(object)FieldEdit);
		((Control)pnl_Right).get_Controls().Add((Control)(object)FieldText);
		((Control)pnl_Right).set_Dock((DockStyle)4);
		((Control)pnl_Right).set_Location(new Point(101, 0));
		((Control)pnl_Right).set_Name("pnl_Right");
		((Control)pnl_Right).set_Size(new Size(231, 21));
		((Control)FieldText).set_BackColor(Color.White);
		((Control)FieldText).set_Dock((DockStyle)5);
		((Control)FieldText).set_Location(new Point(0, 0));
		((Control)FieldText).set_Name("FieldText");
		((Control)FieldText).set_Size(new Size(231, 21));
		((Control)pnl_Left).get_Controls().Add((Control)(object)FieldSelector);
		((Control)pnl_Left).set_Dock((DockStyle)3);
		((Control)pnl_Left).set_Location(new Point(0, 0));
		((Control)pnl_Left).set_Name("pnl_Left");
		((Control)pnl_Left).set_Size(new Size(90, 21));
		((Control)FieldSelector).set_Location(new Point(4, 0));
		((Control)FieldSelector).set_Name("FieldSelector");
		((Control)FieldSelector).set_Size(new Size(86, 21));
		((Control)FieldSelector).set_TabIndex(1);
		FieldSelector.set_Text("LinkLabel1");
		((Label)FieldSelector).set_TextAlign((ContentAlignment)4);
		((Control)FieldEdit).set_BackColor(Color.Red);
		((Control)FieldEdit).set_Dock((DockStyle)5);
		((Control)FieldEdit).set_Location(new Point(0, 0));
		((Control)FieldEdit).set_Name("FieldEdit");
		((Control)FieldEdit).set_Size(new Size(231, 21));
		((Control)FieldEdit).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(96f, 96f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)2);
		((Control)this).get_Controls().Add((Control)(object)Left);
		((Control)this).get_Controls().Add((Control)(object)Right);
		((Control)this).get_Controls().Add((Control)(object)Bottom);
		((Control)this).get_Controls().Add((Control)(object)top);
		((Control)this).get_Controls().Add((Control)(object)MainPanel);
		((Control)this).set_Name("oDataField");
		((Control)this).set_Size(new Size(332, 21));
		((Control)MainPanel).ResumeLayout(false);
		((Control)pnl_Right).ResumeLayout(false);
		((Control)pnl_Left).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public void SetNext(ref oDataField oDataField)
	{
		_next = oDataField;
	}

	public void SetPrevious(ref oDataField oDataField)
	{
		_Previous = oDataField;
	}

	public oDataField(ref Form oForm, object prop)
	{
		_FieldMode = eFieldMode.View;
		InitializeComponent();
		_Parent = oForm;
		LinkLabel fieldSelector = FieldSelector;
		fieldSelector.set_Text(DisplayName);
		if (!Mandatory)
		{
			((Control)fieldSelector).set_ForeColor(Color.Blue);
		}
		else
		{
			((Control)fieldSelector).set_ForeColor(Color.Red);
		}
		if (!ReadOnly)
		{
			((Control)FieldSelector).set_Enabled(true);
			Label fieldText = FieldText;
			((Control)fieldText).set_ForeColor(Color.Black);
			((Control)fieldText).set_BackColor(Color.White);
			fieldText = null;
		}
		else
		{
			((Control)FieldSelector).set_Enabled(false);
			Label fieldText2 = FieldText;
			((Control)fieldText2).set_ForeColor(Color.Gray);
			((Control)fieldText2).set_BackColor(Color.LightGray);
			fieldText2 = null;
		}
		fieldSelector = null;
	}

	private void FieldSelector_Click(object sender, EventArgs e)
	{
		FieldSelectEvent?.Invoke(this, e);
	}
}
