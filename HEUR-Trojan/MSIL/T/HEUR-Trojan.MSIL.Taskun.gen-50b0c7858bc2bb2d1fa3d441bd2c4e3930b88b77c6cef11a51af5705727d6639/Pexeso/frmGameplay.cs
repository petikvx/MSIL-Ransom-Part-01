using System;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Pexeso.My;
using Pexeso.My.Resources;

namespace Pexeso;

[DesignerGenerated]
public class frmGameplay : Form
{
	private IContainer components;

	private object numberOfCardsX;

	private object numberOfCardsY;

	private const int cardWidth = 71;

	private const int cardHeight = 96;

	private const int spaceBetweenCards = 10;

	private const int spaceAroundCards = 20;

	private byte numberOfSelectedCards;

	public ClassPictures[,] Card;

	private object[,,] cardArray;

	private bool firtRun;

	private object oldNumberOfCardsX;

	private object oldNumberOfCardsY;

	private float border;

	private object cardPositionX1;

	private object cardPositionY1;

	private object cardPositionX2;

	private object cardPositionY2;

	private bool cheats;

	private int gameplayTimeSeconds;

	private int gameplayTimeMinutes;

	private string zeroForSeconds;

	private string zeroForMinutes;

	[field: AccessedThroughProperty("lblSelectedCardBorder1")]
	internal virtual Label lblSelectedCardBorder1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblSelectedCardBorder2")]
	internal virtual Label lblSelectedCardBorder2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button cmdBack
	{
		[CompilerGenerated]
		get
		{
			return _cmdBack;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = cmdBack_Click;
			Button val = _cmdBack;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_cmdBack = value;
			val = _cmdBack;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("panBottom")]
	internal virtual Panel panBottom
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTimer")]
	internal virtual Label lblTimer
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("lblTime")]
	internal virtual Label lblTime
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Timer Timer1
	{
		[CompilerGenerated]
		get
		{
			return _Timer1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Timer1_Tick;
			Timer timer = _Timer1;
			if (timer != null)
			{
				timer.remove_Tick(eventHandler);
			}
			_Timer1 = value;
			timer = _Timer1;
			if (timer != null)
			{
				timer.add_Tick(eventHandler);
			}
		}
	}

	public frmGameplay()
	{
		((Form)this).add_Load((EventHandler)frmGame_Load);
		numberOfCardsX = 4;
		numberOfCardsY = 4;
		numberOfSelectedCards = 0;
		cardArray = checked(new object[Conversions.ToInteger(Operators.SubtractObject(numberOfCardsX, (object)1)) + 1, Conversions.ToInteger(Operators.SubtractObject(numberOfCardsY, (object)1)) + 1, 3]);
		border = 4f;
		cheats = false;
		gameplayTimeSeconds = 0;
		gameplayTimeMinutes = 0;
		zeroForSeconds = "0";
		zeroForMinutes = "0";
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected O, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected O, but got Unknown
		//IL_04b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Expected O, but got Unknown
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmGameplay));
		lblSelectedCardBorder1 = new Label();
		lblSelectedCardBorder2 = new Label();
		Button1 = new Button();
		cmdBack = new Button();
		panBottom = new Panel();
		lblTimer = new Label();
		lblTime = new Label();
		Timer1 = new Timer(components);
		((Control)panBottom).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)lblSelectedCardBorder1).set_BackColor(Color.Black);
		lblSelectedCardBorder1.set_BorderStyle((BorderStyle)1);
		((Control)lblSelectedCardBorder1).set_ForeColor(Color.Transparent);
		((Control)lblSelectedCardBorder1).set_Location(new Point(101, 172));
		((Control)lblSelectedCardBorder1).set_Margin(new Padding(8, 0, 8, 0));
		((Control)lblSelectedCardBorder1).set_Name("lblSelectedCardBorder1");
		((Control)lblSelectedCardBorder1).set_Size(new Size(77, 71));
		((Control)lblSelectedCardBorder1).set_TabIndex(1);
		((Control)lblSelectedCardBorder2).set_BackColor(Color.Black);
		lblSelectedCardBorder2.set_BorderStyle((BorderStyle)1);
		((Control)lblSelectedCardBorder2).set_ForeColor(Color.Transparent);
		((Control)lblSelectedCardBorder2).set_Location(new Point(197, 172));
		((Control)lblSelectedCardBorder2).set_Margin(new Padding(8, 0, 8, 0));
		((Control)lblSelectedCardBorder2).set_Name("lblSelectedCardBorder2");
		((Control)lblSelectedCardBorder2).set_Size(new Size(77, 71));
		((Control)lblSelectedCardBorder2).set_TabIndex(2);
		((Control)Button1).set_Location(new Point(-3, -2));
		((Control)Button1).set_Margin(new Padding(8, 7, 8, 7));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(125, 55));
		((Control)Button1).set_TabIndex(3);
		((ButtonBase)Button1).set_Text("cheats");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Visible(false);
		((Control)cmdBack).set_Anchor((AnchorStyles)6);
		cmdBack.set_DialogResult((DialogResult)2);
		((Control)cmdBack).set_Font(new Font("Cambria", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)cmdBack).set_Location(new Point(32, 29));
		((Control)cmdBack).set_Margin(new Padding(8, 7, 8, 7));
		((Control)cmdBack).set_Name("cmdBack");
		((Control)cmdBack).set_Size(new Size(427, 95));
		((Control)cmdBack).set_TabIndex(5);
		((ButtonBase)cmdBack).set_Text("Back to menu");
		((ButtonBase)cmdBack).set_UseVisualStyleBackColor(true);
		((Control)panBottom).set_BackColor(Color.LightBlue);
		((Control)panBottom).set_BackgroundImageLayout((ImageLayout)0);
		((Control)panBottom).get_Controls().Add((Control)(object)lblTimer);
		((Control)panBottom).get_Controls().Add((Control)(object)lblTime);
		((Control)panBottom).get_Controls().Add((Control)(object)cmdBack);
		((Control)panBottom).set_Dock((DockStyle)2);
		((Control)panBottom).set_Location(new Point(0, 513));
		((Control)panBottom).set_Margin(new Padding(8, 7, 8, 7));
		((Control)panBottom).set_Name("panBottom");
		((Control)panBottom).set_Size(new Size(1005, 155));
		((Control)panBottom).set_TabIndex(6);
		((Control)lblTimer).set_Anchor((AnchorStyles)10);
		lblTimer.set_AutoSize(true);
		lblTimer.set_BorderStyle((BorderStyle)1);
		((Control)lblTimer).set_Font(new Font("Cambria", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lblTimer).set_Location(new Point(755, 33));
		((Control)lblTimer).set_Margin(new Padding(8, 0, 8, 0));
		((Control)lblTimer).set_Name("lblTimer");
		((Control)lblTimer).set_Size(new Size(206, 82));
		((Control)lblTimer).set_TabIndex(9);
		lblTimer.set_Text("00:00");
		lblTimer.set_TextAlign((ContentAlignment)64);
		((Control)lblTime).set_Anchor((AnchorStyles)10);
		lblTime.set_AutoSize(true);
		((Control)lblTime).set_Font(new Font("Cambria", 20.25f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)lblTime).set_Location(new Point(541, 33));
		((Control)lblTime).set_Margin(new Padding(8, 0, 8, 0));
		((Control)lblTime).set_Name("lblTime");
		((Control)lblTime).set_Size(new Size(183, 80));
		((Control)lblTime).set_TabIndex(8);
		lblTime.set_Text("Time");
		Timer1.set_Interval(1000);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(16f, 31f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.Control);
		((Form)this).set_CancelButton((IButtonControl)(object)cmdBack);
		((Form)this).set_ClientSize(new Size(1005, 668));
		((Control)this).get_Controls().Add((Control)(object)panBottom);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)lblSelectedCardBorder2);
		((Control)this).get_Controls().Add((Control)(object)lblSelectedCardBorder1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(8, 7, 8, 7));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("frmGameplay");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("frmGame");
		((Control)panBottom).ResumeLayout(false);
		((Control)panBottom).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	public void frmGame_Load(object sender, EventArgs e)
	{
		VBMath.Randomize();
		InitializeCardBoard();
	}

	public void InitializeCardBoard()
	{
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		ClearCardBoard(firtRun, RuntimeHelpers.GetObjectValue(numberOfCardsX), RuntimeHelpers.GetObjectValue(numberOfCardsY));
		PrepareLblSelectedCardBorder();
		checked
		{
			cardArray = new object[Conversions.ToInteger(Operators.SubtractObject(numberOfCardsX, (object)1)) + 1, Conversions.ToInteger(Operators.SubtractObject(numberOfCardsY, (object)1)) + 1, 4];
			Card = new ClassPictures[Conversions.ToInteger(Operators.SubtractObject(numberOfCardsX, (object)1)) + 1, Conversions.ToInteger(Operators.SubtractObject(numberOfCardsY, (object)1)) + 1];
			string text = "s";
			int num = 1;
			bool flag = false;
			bool[,] array = new bool[4, 13];
			object obj = default(object);
			object obj2 = default(object);
			if (ForLoopControl.ForLoopInitObj(obj, (object)0, Operators.SubtractObject(numberOfCardsX, (object)1), (object)1, ref obj2, ref obj))
			{
				object obj3 = default(object);
				object obj4 = default(object);
				_Closure_0024__R47_002D0 closure_0024__R47_002D = default(_Closure_0024__R47_002D0);
				do
				{
					if (!ForLoopControl.ForLoopInitObj(obj3, (object)0, Operators.SubtractObject(numberOfCardsY, (object)1), (object)1, ref obj4, ref obj3))
					{
						continue;
					}
					do
					{
						if (flag)
						{
							flag = false;
						}
						else
						{
							float num2;
							do
							{
								num2 = Conversion.Int(VBMath.Rnd() * 4f);
								float num3 = num2;
								if (num3 != 0f)
								{
									if (num3 == 1f)
									{
										text = "d";
									}
									else if (num3 == 2f)
									{
										text = "c";
									}
									else if (num3 == 3f)
									{
										text = "h";
									}
								}
								else
								{
									text = "s";
								}
								num = (int)Math.Round(Conversion.Int(VBMath.Rnd() * 13f) + 1f);
							}
							while (array[(int)Math.Round(num2), num - 1]);
							array[(int)Math.Round(num2), num - 1] = true;
							flag = true;
						}
						PictureBox val = new PictureBox();
						PictureBox val2 = val;
						((Control)val2).set_Width(71);
						((Control)val2).set_Height(96);
						((Control)val2).set_Left(Conversions.ToInteger(Operators.AddObject(Operators.MultiplyObject((object)81, obj), (object)20)));
						((Control)val2).set_Top(Conversions.ToInteger(Operators.AddObject(Operators.MultiplyObject((object)106, obj3), (object)20)));
						val2.set_SizeMode((PictureBoxSizeMode)1);
						((Control)val2).set_Visible(true);
						((Control)val2).set_BackColor(Color.Red);
						val2.set_Image((Image)(Bitmap)Resources.ResourceManager.GetObject(text + Conversions.ToString(num)));
						val2 = null;
						ClassPictures classPictures = new ClassPictures(Conversions.ToInteger(obj), Conversions.ToInteger(obj3), val);
						Card[Conversions.ToInteger(obj), Conversions.ToInteger(obj3)] = classPictures;
						((Control)this).get_Controls().Add((Control)(object)Card[Conversions.ToInteger(obj), Conversions.ToInteger(obj3)].PictureBoxCard);
						PictureBox pictureBoxCard = Card[Conversions.ToInteger(obj), Conversions.ToInteger(obj3)].PictureBoxCard;
						closure_0024__R47_002D = new _Closure_0024__R47_002D0(closure_0024__R47_002D);
						closure_0024__R47_002D._0024VB_0024NonLocal_2 = Card[Conversions.ToInteger(obj), Conversions.ToInteger(obj3)];
						((Control)pictureBoxCard).add_Click((EventHandler)closure_0024__R47_002D._Lambda_0024__R2);
						((Control)Card[Conversions.ToInteger(obj), Conversions.ToInteger(obj3)].PictureBoxCard).BringToFront();
						cardArray[Conversions.ToInteger(obj), Conversions.ToInteger(obj3), 0] = text + Conversions.ToString(num);
						cardArray[Conversions.ToInteger(obj), Conversions.ToInteger(obj3), 1] = Card[Conversions.ToInteger(obj), Conversions.ToInteger(obj3)].PictureBoxCard.get_Image();
						cardArray[Conversions.ToInteger(obj), Conversions.ToInteger(obj3), 2] = false;
					}
					while (ForLoopControl.ForNextCheckObj(obj3, obj4, ref obj3));
				}
				while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
			}
			ResizeWindow(71, 96, RuntimeHelpers.GetObjectValue(numberOfCardsX), RuntimeHelpers.GetObjectValue(numberOfCardsY), 10, 20, this);
			CenterWindow(this);
			ShuffleCards();
			HideAllCards();
			numberOfSelectedCards = 0;
			ClearTimer();
			Timer1.set_Enabled(true);
		}
	}

	public void ClearCardBoard(object firtRun, object numberOfCardsX, object numberOfCardsY)
	{
		if (Operators.ConditionalCompareObjectEqual(firtRun, (object)true, false))
		{
			SetFirstRun(booleanValue: false);
			oldNumberOfCardsX = RuntimeHelpers.GetObjectValue(numberOfCardsX);
			oldNumberOfCardsY = RuntimeHelpers.GetObjectValue(numberOfCardsY);
			return;
		}
		object obj = default(object);
		object obj2 = default(object);
		if (ForLoopControl.ForLoopInitObj(obj, (object)0, Operators.SubtractObject(oldNumberOfCardsX, (object)1), (object)1, ref obj2, ref obj))
		{
			object obj3 = default(object);
			object obj4 = default(object);
			do
			{
				if (ForLoopControl.ForLoopInitObj(obj3, (object)0, Operators.SubtractObject(oldNumberOfCardsY, (object)1), (object)1, ref obj4, ref obj3))
				{
					do
					{
						((Control)this).get_Controls().Remove((Control)(object)Card[Conversions.ToInteger(obj), Conversions.ToInteger(obj3)].PictureBoxCard);
					}
					while (ForLoopControl.ForNextCheckObj(obj3, obj4, ref obj3));
				}
			}
			while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
		}
		oldNumberOfCardsX = RuntimeHelpers.GetObjectValue(numberOfCardsX);
		oldNumberOfCardsY = RuntimeHelpers.GetObjectValue(numberOfCardsY);
	}

	public void PrepareLblSelectedCardBorder()
	{
		checked
		{
			((Control)lblSelectedCardBorder1).set_Width((int)Math.Round(71f + 2f * border));
			((Control)lblSelectedCardBorder1).set_Height((int)Math.Round(96f + 2f * border));
			((Control)lblSelectedCardBorder1).set_Visible(false);
			((Control)lblSelectedCardBorder2).set_Width((int)Math.Round(71f + 2f * border));
			((Control)lblSelectedCardBorder2).set_Height((int)Math.Round(96f + 2f * border));
			((Control)lblSelectedCardBorder2).set_Visible(false);
		}
	}

	public void setBorderPosition(byte X, byte Y, byte lblNumber)
	{
		checked
		{
			float num = (float)(unchecked((int)X) * 71 + unchecked((int)X) * 10 + 20) - border;
			float num2 = (float)(unchecked((int)Y) * 96 + unchecked((int)Y) * 10 + 20) - border;
			if (lblNumber == 1)
			{
				((Control)lblSelectedCardBorder1).set_Left((int)Math.Round(num));
				((Control)lblSelectedCardBorder1).set_Top((int)Math.Round(num2));
				((Control)lblSelectedCardBorder1).set_Visible(true);
			}
			else
			{
				((Control)lblSelectedCardBorder2).set_Left((int)Math.Round(num));
				((Control)lblSelectedCardBorder2).set_Top((int)Math.Round(num2));
				((Control)lblSelectedCardBorder2).set_Visible(true);
			}
		}
	}

	public void CardHandler(object X, object Y)
	{
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		if (IsRevealed(RuntimeHelpers.GetObjectValue(X), RuntimeHelpers.GetObjectValue(Y)) & (numberOfSelectedCards < 2))
		{
			return;
		}
		checked
		{
			if (numberOfSelectedCards == 0)
			{
				cardPositionX1 = RuntimeHelpers.GetObjectValue(X);
				cardPositionY1 = RuntimeHelpers.GetObjectValue(Y);
				RevealCard(RuntimeHelpers.GetObjectValue(cardPositionX1), RuntimeHelpers.GetObjectValue(cardPositionY1));
				setBorderPosition(Conversions.ToByte(X), Conversions.ToByte(Y), 1);
				numberOfSelectedCards++;
			}
			else if (numberOfSelectedCards == 1)
			{
				cardPositionX2 = RuntimeHelpers.GetObjectValue(X);
				cardPositionY2 = RuntimeHelpers.GetObjectValue(Y);
				RevealCard(RuntimeHelpers.GetObjectValue(cardPositionX2), RuntimeHelpers.GetObjectValue(cardPositionY2));
				if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(cardPositionX1, cardPositionX2, false), Operators.CompareObjectEqual(cardPositionY1, cardPositionY2, false))))
				{
					return;
				}
				if (Operators.ConditionalCompareObjectEqual(GetCardValue(RuntimeHelpers.GetObjectValue(cardPositionX1), RuntimeHelpers.GetObjectValue(cardPositionY1)), GetCardValue(RuntimeHelpers.GetObjectValue(cardPositionX2), RuntimeHelpers.GetObjectValue(cardPositionY2)), false))
				{
					SetRevealed(RuntimeHelpers.GetObjectValue(cardPositionX1), RuntimeHelpers.GetObjectValue(cardPositionY1));
					SetRevealed(RuntimeHelpers.GetObjectValue(cardPositionX2), RuntimeHelpers.GetObjectValue(cardPositionY2));
					numberOfSelectedCards = 0;
					((Control)lblSelectedCardBorder1).set_Visible(false);
					if (IsGameFinished())
					{
						Timer1.set_Enabled(false);
						Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Cogratulations, you have finished the game on ", MyProject.Forms.frmGameSelect.GetDifficulty(convertToUppercase: true)), (object)" difficulty in "), (object)lblTimer.get_Text()), (MsgBoxStyle)64, (object)"Game completed");
						HandleLeaderboards();
					}
				}
				else
				{
					numberOfSelectedCards++;
					setBorderPosition(Conversions.ToByte(X), Conversions.ToByte(Y), 2);
				}
			}
			else
			{
				HideCard(RuntimeHelpers.GetObjectValue(cardPositionX1), RuntimeHelpers.GetObjectValue(cardPositionY1));
				HideCard(RuntimeHelpers.GetObjectValue(cardPositionX2), RuntimeHelpers.GetObjectValue(cardPositionY2));
				numberOfSelectedCards = 0;
				((Control)lblSelectedCardBorder1).set_Visible(false);
				((Control)lblSelectedCardBorder2).set_Visible(false);
			}
		}
	}

	public void ResizeWindow(object objectWidth, object objectHeight, object numberOfObjectsX, object numberOfObjectsY, object spaceBetween, object spaceAround, object frm)
	{
		NewLateBinding.LateSet(frm, (Type)null, "Width", new object[1] { Operators.AddObject(Operators.AddObject(Operators.MultiplyObject(objectWidth, numberOfObjectsX), Operators.MultiplyObject(spaceBetween, Operators.SubtractObject(numberOfObjectsX, (object)1))), Operators.MultiplyObject(Operators.AddObject(spaceAround, (object)8), (object)2)) }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(frm, (Type)null, "Height", new object[1] { Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.AddObject(Operators.MultiplyObject(objectHeight, numberOfObjectsY), Operators.MultiplyObject(spaceBetween, Operators.SubtractObject(numberOfObjectsY, (object)1))), Operators.MultiplyObject(spaceAround, (object)2)), (object)8), (object)30), (object)((Control)panBottom).get_Height()) }, (string[])null, (Type[])null);
	}

	public void CenterWindow(object window)
	{
		NewLateBinding.LateSet(window, (Type)null, "Left", new object[1] { Operators.SubtractObject((object)((double)((Computer)MyProject.Computer).get_Screen().get_WorkingArea().Width / 2.0), Operators.DivideObject(NewLateBinding.LateGet(window, (Type)null, "Width", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2)) }, (string[])null, (Type[])null);
		NewLateBinding.LateSet(window, (Type)null, "Top", new object[1] { Operators.SubtractObject((object)((double)((Computer)MyProject.Computer).get_Screen().get_WorkingArea().Height / 2.0), Operators.DivideObject(NewLateBinding.LateGet(window, (Type)null, "Height", new object[0], (string[])null, (Type[])null, (bool[])null), (object)2)) }, (string[])null, (Type[])null);
	}

	private void ShuffleCards()
	{
		object obj = default(object);
		object obj2 = default(object);
		if (ForLoopControl.ForLoopInitObj(obj, (object)1, Operators.MultiplyObject(numberOfCardsX, numberOfCardsY), (object)1, ref obj2, ref obj))
		{
			do
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Conversion.Int(Operators.MultiplyObject((object)VBMath.Rnd(), numberOfCardsX)));
				object objectValue2 = RuntimeHelpers.GetObjectValue(Conversion.Int(Operators.MultiplyObject((object)VBMath.Rnd(), numberOfCardsY)));
				object objectValue3 = RuntimeHelpers.GetObjectValue(Conversion.Int(Operators.MultiplyObject((object)VBMath.Rnd(), numberOfCardsX)));
				object objectValue4 = RuntimeHelpers.GetObjectValue(Conversion.Int(Operators.MultiplyObject((object)VBMath.Rnd(), numberOfCardsY)));
				int num = 0;
				do
				{
					object objectValue5 = RuntimeHelpers.GetObjectValue(cardArray[Conversions.ToInteger(objectValue), Conversions.ToInteger(objectValue2), num]);
					cardArray[Conversions.ToInteger(objectValue), Conversions.ToInteger(objectValue2), num] = RuntimeHelpers.GetObjectValue(cardArray[Conversions.ToInteger(objectValue3), Conversions.ToInteger(objectValue4), num]);
					cardArray[Conversions.ToInteger(objectValue3), Conversions.ToInteger(objectValue4), num] = RuntimeHelpers.GetObjectValue(objectValue5);
					num = checked(num + 1);
				}
				while (num <= 1);
			}
			while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
		}
		RedrawCardPictures();
	}

	public void HideCard(object X, object Y)
	{
		Card[Conversions.ToInteger(X), Conversions.ToInteger(Y)].PictureBoxCard.set_Image((Image)(object)Resources.backblue);
	}

	public void HideAllCards()
	{
		object obj = default(object);
		object obj2 = default(object);
		if (!ForLoopControl.ForLoopInitObj(obj, (object)0, Operators.SubtractObject(numberOfCardsX, (object)1), (object)1, ref obj2, ref obj))
		{
			return;
		}
		object obj3 = default(object);
		object obj4 = default(object);
		do
		{
			if (!ForLoopControl.ForLoopInitObj(obj3, (object)0, Operators.SubtractObject(numberOfCardsY, (object)1), (object)1, ref obj4, ref obj3))
			{
				continue;
			}
			do
			{
				if (!IsRevealed(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj3)))
				{
					HideCard(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj3));
				}
			}
			while (ForLoopControl.ForNextCheckObj(obj3, obj4, ref obj3));
		}
		while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
	}

	public void RevealCard(object X, object Y)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		Card[Conversions.ToInteger(X), Conversions.ToInteger(Y)].PictureBoxCard.set_Image((Image)cardArray[Conversions.ToInteger(X), Conversions.ToInteger(Y), 1]);
	}

	public void RedrawCardPictures()
	{
		object obj = default(object);
		object obj2 = default(object);
		if (!ForLoopControl.ForLoopInitObj(obj, (object)0, Operators.SubtractObject(numberOfCardsX, (object)1), (object)1, ref obj2, ref obj))
		{
			return;
		}
		object obj3 = default(object);
		object obj4 = default(object);
		do
		{
			if (ForLoopControl.ForLoopInitObj(obj3, (object)0, Operators.SubtractObject(numberOfCardsY, (object)1), (object)1, ref obj4, ref obj3))
			{
				do
				{
					RevealCard(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj3));
				}
				while (ForLoopControl.ForNextCheckObj(obj3, obj4, ref obj3));
			}
		}
		while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
	}

	public bool IsRevealed(object X, object Y)
	{
		if (Operators.ConditionalCompareObjectEqual(cardArray[Conversions.ToInteger(X), Conversions.ToInteger(Y), 2], (object)true, false))
		{
			return true;
		}
		return false;
	}

	public bool IsGameFinished()
	{
		object obj = default(object);
		object obj2 = default(object);
		if (ForLoopControl.ForLoopInitObj(obj, (object)0, Operators.SubtractObject(numberOfCardsX, (object)1), (object)1, ref obj2, ref obj))
		{
			object obj3 = default(object);
			object obj4 = default(object);
			do
			{
				if (!ForLoopControl.ForLoopInitObj(obj3, (object)0, Operators.SubtractObject(numberOfCardsY, (object)1), (object)1, ref obj4, ref obj3))
				{
					continue;
				}
				do
				{
					if (!IsRevealed(RuntimeHelpers.GetObjectValue(obj), RuntimeHelpers.GetObjectValue(obj3)))
					{
						return false;
					}
				}
				while (ForLoopControl.ForNextCheckObj(obj3, obj4, ref obj3));
			}
			while (ForLoopControl.ForNextCheckObj(obj, obj2, ref obj));
		}
		return true;
	}

	public void SetRevealed(object X, object Y)
	{
		cardArray[Conversions.ToInteger(X), Conversions.ToInteger(Y), 2] = true;
	}

	public object GetCardValue(object X, object Y)
	{
		return cardArray[Conversions.ToInteger(X), Conversions.ToInteger(Y), 0];
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (!cheats)
		{
			RedrawCardPictures();
			cheats = true;
		}
		else
		{
			HideAllCards();
			cheats = false;
		}
	}

	public void SetNumberOfCards(object X, object Y)
	{
		numberOfCardsX = RuntimeHelpers.GetObjectValue(X);
		numberOfCardsY = RuntimeHelpers.GetObjectValue(Y);
	}

	public bool IsFirstRun()
	{
		if (firtRun)
		{
			return true;
		}
		return false;
	}

	public void SetFirstRun(bool booleanValue)
	{
		firtRun = booleanValue;
	}

	private void cmdBack_Click(object sender, EventArgs e)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Invalid comparison between Unknown and I4
		if (IsGameFinished() || (int)Interaction.MsgBox((object)"Do you really want to go back to menu?", (MsgBoxStyle)292, (object)"Back to main menu?") != 7)
		{
			((Control)this).Hide();
			((Control)MyProject.Forms.frmMainMenu).Show();
		}
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		checked
		{
			gameplayTimeSeconds++;
			if (gameplayTimeSeconds == 60)
			{
				gameplayTimeMinutes++;
				gameplayTimeSeconds = 0;
				if (gameplayTimeMinutes < 10)
				{
					zeroForMinutes = "0";
				}
				else
				{
					zeroForMinutes = "";
				}
			}
			if (gameplayTimeSeconds < 10)
			{
				zeroForSeconds = "0";
			}
			else
			{
				zeroForSeconds = "";
			}
			lblTimer.set_Text(zeroForMinutes + Conversions.ToString(gameplayTimeMinutes) + ":" + zeroForSeconds + Conversions.ToString(gameplayTimeSeconds));
		}
	}

	private void ClearTimer()
	{
		Timer1.set_Enabled(false);
		gameplayTimeSeconds = 0;
		gameplayTimeMinutes = 0;
		zeroForSeconds = "0";
		zeroForMinutes = "0";
		lblTimer.set_Text("00:00");
	}

	private string GetPlayTime()
	{
		return lblTimer.get_Text();
	}

	private void HandleLeaderboards()
	{
		checked
		{
			byte b = (byte)MyProject.Forms.frmGameSelect.GetDifficultyID();
			if (b == 0)
			{
				return;
			}
			string[] array = Strings.Split(Conversions.ToString(((ApplicationSettingsBase)MySettingsProperty.Settings).get_Item("L" + Conversions.ToString(unchecked((int)b) + 1))), ";", -1, (CompareMethod)0);
			string playTime = GetPlayTime();
			if (Operators.CompareString(playTime, array.Last(), false) > 0)
			{
				return;
			}
			byte b2 = (byte)array.Count();
			int num = array.Count() - 2;
			for (int i = num; i >= 0; i += -1)
			{
				if (Operators.CompareString(playTime, array[i], false) < 0)
				{
					b2 = (byte)(unchecked((int)b2) - 1);
				}
			}
			string text = b2 switch
			{
				1 => "st", 
				2 => "nd", 
				3 => "rd", 
				_ => "th", 
			};
			string text2 = "";
			bool flag = false;
			while (!unchecked(((Strings.Len(text2) <= 12) & (Strings.Len(text2) > 0)) && flag))
			{
				text2 = Interaction.InputBox(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("Cogratulations, You have finished at " + Conversions.ToString(b2) + text + " place in "), MyProject.Forms.frmGameSelect.GetDifficulty(convertToUppercase: true)), (object)" difficulty leaderboard with time "), (object)playTime), (object)"."), (object)"\r\n"), (object)"\r\n"), (object)"Enter your name, it must be between 1 and 12 characters.")), Conversions.ToString(Operators.ConcatenateObject(MyProject.Forms.frmGameSelect.GetDifficulty(convertToUppercase: true), (object)" leader board")), "Player Name", -1, -1);
				flag = true;
				int num2 = Strings.Len(text2);
				for (int j = 1; j <= num2; j++)
				{
					if (((Strings.Asc(Strings.LCase(Strings.Mid(text2, j, 1))) < 97) & (Strings.Asc(Strings.LCase(Strings.Mid(text2, j, 1))) != 32)) | (Strings.Asc(Strings.LCase(Strings.Mid(text2, j, 1))) > 122))
					{
						flag = false;
					}
				}
			}
			int num3 = 0;
			do
			{
				string[] array2 = Strings.Split(Conversions.ToString(((ApplicationSettingsBase)MySettingsProperty.Settings).get_Item("L" + Conversions.ToString(unchecked((int)b) + num3))), ";", -1, (CompareMethod)0);
				string text3 = "";
				string text4 = text2;
				if (num3 == 1)
				{
					text4 = playTime;
				}
				int num4 = unchecked((int)b2) - 1;
				int num5 = array2.Count() - 1;
				for (int k = num4; k <= num5; k++)
				{
					int num6 = k;
					if (num6 == unchecked((int)b2) - 1)
					{
						text3 = array2[k];
						array2[k] = text4;
					}
					else if (num6 == array2.Count() - 1)
					{
						array2[k] = text3;
					}
					else
					{
						text4 = array2[k];
						array2[k] = text3;
						text3 = text4;
					}
				}
				SaveLeaderboard(array2, b, num3);
				num3++;
			}
			while (num3 <= 1);
		}
	}

	private void SaveLeaderboard(object[] array, object difficulty, object type)
	{
		string text = "";
		checked
		{
			int num = array.Count() - 1;
			for (int i = 0; i <= num; i++)
			{
				object obj = ((i != array.Count() - 1) ? ";" : null);
				text = Conversions.ToString(Operators.AddObject((object)text, Operators.ConcatenateObject(array[i], obj)));
			}
			((ApplicationSettingsBase)MySettingsProperty.Settings).set_Item("L" + Conversions.ToString(Operators.AddObject(difficulty, type)), (object)text);
			((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
		}
	}
}
