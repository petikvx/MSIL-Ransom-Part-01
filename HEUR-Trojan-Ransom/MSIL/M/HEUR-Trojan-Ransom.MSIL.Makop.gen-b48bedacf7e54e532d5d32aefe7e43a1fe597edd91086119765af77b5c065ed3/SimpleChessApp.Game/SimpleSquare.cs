using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace SimpleChessApp.Game;

public class SimpleSquare : UserControl
{
	private Color DefaultColor;

	private ChessPiece piece;

	private bool isBlackSquare;

	private IContainer components = null;

	public Panel panel1;

	public ChessPiece Piece
	{
		get
		{
			return piece;
		}
		set
		{
			piece = value;
			if (piece == null)
			{
				piece = null;
				SimpleSquare.smethod_2((Control)(object)this, (Image)null);
			}
			else
			{
				SimpleSquare.smethod_2((Control)(object)this, repo.GetPiece(piece.Kind, piece.Color));
			}
		}
	}

	public Pieces Kind
	{
		set
		{
			Piece.Kind = value;
			Piece = Piece;
		}
	}

	public bool IsBlackSquare
	{
		get
		{
			return isBlackSquare;
		}
		set
		{
			isBlackSquare = value;
			colorSquare();
		}
	}

	public Repository repo => ChessContext.repo;

	public bool IsEmpty => Piece == null;

	public event EventHandler<MouseEventArgs> Click
	{
		[CompilerGenerated]
		add
		{
			EventHandler<MouseEventArgs> eventHandler = this.Click;
			EventHandler<MouseEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<MouseEventArgs> value2 = (EventHandler<MouseEventArgs>)SimpleSquare.smethod_0((Delegate)eventHandler2, (Delegate)value);
				eventHandler = Interlocked.CompareExchange(ref this.Click, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			EventHandler<MouseEventArgs> eventHandler = this.Click;
			EventHandler<MouseEventArgs> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<MouseEventArgs> value2 = (EventHandler<MouseEventArgs>)SimpleSquare.smethod_1((Delegate)eventHandler2, (Delegate)value);
				eventHandler = Interlocked.CompareExchange(ref this.Click, value2, eventHandler2);
			}
			while ((object)eventHandler != eventHandler2);
		}
	}

	public void colorSquare()
	{
		DefaultColor = (IsBlackSquare ? Color.CornflowerBlue : Color.WhiteSmoke);
		SimpleSquare.smethod_3((Control)(object)this, DefaultColor);
	}

	public SimpleSquare()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		InitializeComponent();
		SimpleSquare.smethod_4((Control)(object)this, new MouseEventHandler(Square_MouseClick));
		SimpleSquare.smethod_5((Control)(object)panel1, new MouseEventHandler(Square_MouseClick));
	}

	private void Square_MouseClick(object sender, MouseEventArgs e)
	{
		this.Click?.Invoke(this, e);
	}

	public void HighLight()
	{
		SimpleSquare.smethod_3((Control)(object)this, Color.ForestGreen);
	}

	public void ClearHighLight()
	{
		SimpleSquare.smethod_3((Control)(object)this, DefaultColor);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			SimpleSquare.smethod_6((IDisposable)components);
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		panel1 = SimpleSquare.smethod_7();
		SimpleSquare.smethod_8((Control)(object)this);
		SimpleSquare.smethod_3((Control)(object)panel1, Color.Transparent);
		SimpleSquare.smethod_9((Control)(object)panel1, (ImageLayout)2);
		SimpleSquare.smethod_10((Control)(object)panel1, (DockStyle)5);
		SimpleSquare.smethod_11((Control)(object)panel1, new Point(0, 0));
		SimpleSquare.smethod_12((Control)(object)panel1, "panel1");
		SimpleSquare.smethod_13((Control)(object)panel1, new Size(137, 132));
		SimpleSquare.smethod_14((Control)(object)panel1, 0);
		SimpleSquare.smethod_15((ContainerControl)(object)this, new SizeF(6f, 13f));
		SimpleSquare.smethod_16((ContainerControl)(object)this, (AutoScaleMode)1);
		SimpleSquare.smethod_9((Control)(object)this, (ImageLayout)2);
		SimpleSquare.smethod_18(SimpleSquare.smethod_17((Control)(object)this), (Control)(object)panel1);
		SimpleSquare.smethod_19((Control)(object)this, new Padding(0));
		SimpleSquare.smethod_20((Control)(object)this, "SimpleSquare");
		SimpleSquare.smethod_21((Control)(object)this, new Size(137, 132));
		SimpleSquare.smethod_22((Control)(object)this, bool_0: false);
	}

	static Delegate smethod_0(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Combine(delegate_0, delegate_1);
	}

	static Delegate smethod_1(Delegate delegate_0, Delegate delegate_1)
	{
		return Delegate.Remove(delegate_0, delegate_1);
	}

	static void smethod_2(Control control_0, Image image_0)
	{
		control_0.set_BackgroundImage(image_0);
	}

	static void smethod_3(Control control_0, Color color_0)
	{
		control_0.set_BackColor(color_0);
	}

	static void smethod_4(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.add_MouseClick(mouseEventHandler_0);
	}

	static void smethod_5(Control control_0, MouseEventHandler mouseEventHandler_0)
	{
		control_0.add_MouseClick(mouseEventHandler_0);
	}

	static void smethod_6(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Panel smethod_7()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Panel();
	}

	static void smethod_8(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_9(Control control_0, ImageLayout imageLayout_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_BackgroundImageLayout(imageLayout_0);
	}

	static void smethod_10(Control control_0, DockStyle dockStyle_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Dock(dockStyle_0);
	}

	static void smethod_11(Control control_0, Point point_0)
	{
		control_0.set_Location(point_0);
	}

	static void smethod_12(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_13(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_14(Control control_0, int int_0)
	{
		control_0.set_TabIndex(int_0);
	}

	static void smethod_15(ContainerControl containerControl_0, SizeF sizeF_0)
	{
		containerControl_0.set_AutoScaleDimensions(sizeF_0);
	}

	static void smethod_16(ContainerControl containerControl_0, AutoScaleMode autoScaleMode_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		containerControl_0.set_AutoScaleMode(autoScaleMode_0);
	}

	static ControlCollection smethod_17(Control control_0)
	{
		return control_0.get_Controls();
	}

	static void smethod_18(ControlCollection controlCollection_0, Control control_0)
	{
		controlCollection_0.Add(control_0);
	}

	static void smethod_19(Control control_0, Padding padding_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		control_0.set_Margin(padding_0);
	}

	static void smethod_20(Control control_0, string string_0)
	{
		control_0.set_Name(string_0);
	}

	static void smethod_21(Control control_0, Size size_0)
	{
		control_0.set_Size(size_0);
	}

	static void smethod_22(Control control_0, bool bool_0)
	{
		control_0.ResumeLayout(bool_0);
	}
}
