using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HOAProject.My;
using Microsoft.VisualBasic.CompilerServices;

namespace HOAProject;

[DesignerGenerated]
public class WelcomePage : Form
{
	private IContainer components;

	internal virtual Button ExitButton
	{
		[CompilerGenerated]
		get
		{
			return _ExitButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ExitButton_Click;
			Button exitButton = _ExitButton;
			if (exitButton != null)
			{
				((Control)exitButton).remove_Click(eventHandler);
			}
			_ExitButton = value;
			exitButton = _ExitButton;
			if (exitButton != null)
			{
				((Control)exitButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button AvailableLotButton
	{
		[CompilerGenerated]
		get
		{
			return _AvailableLotButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = AvailableLotButton_Click;
			Button availableLotButton = _AvailableLotButton;
			if (availableLotButton != null)
			{
				((Control)availableLotButton).remove_Click(eventHandler);
			}
			_AvailableLotButton = value;
			availableLotButton = _AvailableLotButton;
			if (availableLotButton != null)
			{
				((Control)availableLotButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button PurchaselotButton
	{
		[CompilerGenerated]
		get
		{
			return _PurchaselotButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = PurchaselotButton_Click;
			Button purchaselotButton = _PurchaselotButton;
			if (purchaselotButton != null)
			{
				((Control)purchaselotButton).remove_Click(eventHandler);
			}
			_PurchaselotButton = value;
			purchaselotButton = _PurchaselotButton;
			if (purchaselotButton != null)
			{
				((Control)purchaselotButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Customer_Purchase_Record
	{
		[CompilerGenerated]
		get
		{
			return _Customer_Purchase_Record;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Customer_Prurchase_Record_Click;
			Button customer_Purchase_Record = _Customer_Purchase_Record;
			if (customer_Purchase_Record != null)
			{
				((Control)customer_Purchase_Record).remove_Click(eventHandler);
			}
			_Customer_Purchase_Record = value;
			customer_Purchase_Record = _Customer_Purchase_Record;
			if (customer_Purchase_Record != null)
			{
				((Control)customer_Purchase_Record).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Available_Lot_Detail
	{
		[CompilerGenerated]
		get
		{
			return _Available_Lot_Detail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Available_lot_Detail_Click;
			Button available_Lot_Detail = _Available_Lot_Detail;
			if (available_Lot_Detail != null)
			{
				((Control)available_Lot_Detail).remove_Click(eventHandler);
			}
			_Available_Lot_Detail = value;
			available_Lot_Detail = _Available_Lot_Detail;
			if (available_Lot_Detail != null)
			{
				((Control)available_Lot_Detail).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("MenuStrip1")]
	internal virtual MenuStrip MenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem SalespersonReviewsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _SalespersonReviewsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = SalespersonReviewsToolStripMenuItem_Click;
			ToolStripMenuItem salespersonReviewsToolStripMenuItem = _SalespersonReviewsToolStripMenuItem;
			if (salespersonReviewsToolStripMenuItem != null)
			{
				((ToolStripItem)salespersonReviewsToolStripMenuItem).remove_Click(eventHandler);
			}
			_SalespersonReviewsToolStripMenuItem = value;
			salespersonReviewsToolStripMenuItem = _SalespersonReviewsToolStripMenuItem;
			if (salespersonReviewsToolStripMenuItem != null)
			{
				((ToolStripItem)salespersonReviewsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ContextMenuStrip1")]
	internal virtual ContextMenuStrip ContextMenuStrip1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripMenuItem ShowReviewsToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ShowReviewsToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ShowReviewsToolStripMenuItem_Click;
			ToolStripMenuItem showReviewsToolStripMenuItem = _ShowReviewsToolStripMenuItem;
			if (showReviewsToolStripMenuItem != null)
			{
				((ToolStripItem)showReviewsToolStripMenuItem).remove_Click(eventHandler);
			}
			_ShowReviewsToolStripMenuItem = value;
			showReviewsToolStripMenuItem = _ShowReviewsToolStripMenuItem;
			if (showReviewsToolStripMenuItem != null)
			{
				((ToolStripItem)showReviewsToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ToolStripMenuItem1
	{
		[CompilerGenerated]
		get
		{
			return _ToolStripMenuItem1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ToolStripMenuItem1_Click;
			ToolStripMenuItem toolStripMenuItem = _ToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				((ToolStripItem)toolStripMenuItem).remove_Click(eventHandler);
			}
			_ToolStripMenuItem1 = value;
			toolStripMenuItem = _ToolStripMenuItem1;
			if (toolStripMenuItem != null)
			{
				((ToolStripItem)toolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem ByLowestRatingToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _ByLowestRatingToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ByLowestRatingToolStripMenuItem_Click;
			ToolStripMenuItem byLowestRatingToolStripMenuItem = _ByLowestRatingToolStripMenuItem;
			if (byLowestRatingToolStripMenuItem != null)
			{
				((ToolStripItem)byLowestRatingToolStripMenuItem).remove_Click(eventHandler);
			}
			_ByLowestRatingToolStripMenuItem = value;
			byLowestRatingToolStripMenuItem = _ByLowestRatingToolStripMenuItem;
			if (byLowestRatingToolStripMenuItem != null)
			{
				((ToolStripItem)byLowestRatingToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual ToolStripMenuItem NewestToolStripMenuItem
	{
		[CompilerGenerated]
		get
		{
			return _NewestToolStripMenuItem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = NewestToolStripMenuItem_Click;
			ToolStripMenuItem newestToolStripMenuItem = _NewestToolStripMenuItem;
			if (newestToolStripMenuItem != null)
			{
				((ToolStripItem)newestToolStripMenuItem).remove_Click(eventHandler);
			}
			_NewestToolStripMenuItem = value;
			newestToolStripMenuItem = _NewestToolStripMenuItem;
			if (newestToolStripMenuItem != null)
			{
				((ToolStripItem)newestToolStripMenuItem).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button ModelsButton
	{
		[CompilerGenerated]
		get
		{
			return _ModelsButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ModelsButton_Click;
			Button modelsButton = _ModelsButton;
			if (modelsButton != null)
			{
				((Control)modelsButton).remove_Click(eventHandler);
			}
			_ModelsButton = value;
			modelsButton = _ModelsButton;
			if (modelsButton != null)
			{
				((Control)modelsButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button PurchasedLotsButton
	{
		[CompilerGenerated]
		get
		{
			return _PurchasedLotsButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = PurchasedLotsButton_Click;
			Button purchasedLotsButton = _PurchasedLotsButton;
			if (purchasedLotsButton != null)
			{
				((Control)purchasedLotsButton).remove_Click(eventHandler);
			}
			_PurchasedLotsButton = value;
			purchasedLotsButton = _PurchasedLotsButton;
			if (purchasedLotsButton != null)
			{
				((Control)purchasedLotsButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button SubdivisionButton
	{
		[CompilerGenerated]
		get
		{
			return _SubdivisionButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button subdivisionButton = _SubdivisionButton;
			if (subdivisionButton != null)
			{
				((Control)subdivisionButton).remove_Click(eventHandler);
			}
			_SubdivisionButton = value;
			subdivisionButton = _SubdivisionButton;
			if (subdivisionButton != null)
			{
				((Control)subdivisionButton).add_Click(eventHandler);
			}
		}
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
			EventHandler eventHandler = Button1_Click_1;
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

	internal virtual Button CustomersButton
	{
		[CompilerGenerated]
		get
		{
			return _CustomersButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button2_Click;
			Button customersButton = _CustomersButton;
			if (customersButton != null)
			{
				((Control)customersButton).remove_Click(eventHandler);
			}
			_CustomersButton = value;
			customersButton = _CustomersButton;
			if (customersButton != null)
			{
				((Control)customersButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button SalespersonDetailsButton
	{
		[CompilerGenerated]
		get
		{
			return _SalespersonDetailsButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = SalespersonDetailsButton_Click;
			Button salespersonDetailsButton = _SalespersonDetailsButton;
			if (salespersonDetailsButton != null)
			{
				((Control)salespersonDetailsButton).remove_Click(eventHandler);
			}
			_SalespersonDetailsButton = value;
			salespersonDetailsButton = _SalespersonDetailsButton;
			if (salespersonDetailsButton != null)
			{
				((Control)salespersonDetailsButton).add_Click(eventHandler);
			}
		}
	}

	public WelcomePage()
	{
		((Form)this).add_Load((EventHandler)WelcomePage_Load);
		InitializeComponent();
	}

	private void ExitButton_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void AvailableLotButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.AvailableLotform).Show();
	}

	private void PurchaselotButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.PurchaseLotform).Show();
	}

	private void Customer_Prurchase_Record_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.CustomerPurchaseRecordForm).Show();
	}

	private void Available_lot_Detail_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.Availablelotdetailform).Show();
	}

	private void WelcomePage_Load(object sender, EventArgs e)
	{
	}

	private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void ShowReviewsToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.Salesperson_Ratings).Show();
	}

	private void SalespersonReviewsToolStripMenuItem_Click(object sender, EventArgs e)
	{
	}

	private void ToolStripMenuItem1_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.Highest_Salesperson_Rating).Show();
	}

	private void ByLowestRatingToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)MyProject.Forms.Lowest_Salesperson_Rating).Show();
	}

	private void NewestToolStripMenuItem_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.Newest_Salesperson_Rating).Show();
	}

	private void PurchasedLotsButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.Availablelotdetailform).Show();
	}

	private void ModelsButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.Models).Show();
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.Subdivisions).Show();
	}

	private void Button1_Click_1(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.Salespersons).Show();
	}

	private void Button2_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.Customers).Show();
	}

	private void SalespersonDetailsButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.Salesperson_DetailForm).Show();
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Unknown result type (might be due to invalid IL or missing references)
		//IL_071d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0839: Unknown result type (might be due to invalid IL or missing references)
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5e: Unknown result type (might be due to invalid IL or missing references)
		components = new Container();
		ExitButton = new Button();
		AvailableLotButton = new Button();
		PurchaselotButton = new Button();
		Customer_Purchase_Record = new Button();
		Available_Lot_Detail = new Button();
		MenuStrip1 = new MenuStrip();
		SalespersonReviewsToolStripMenuItem = new ToolStripMenuItem();
		ShowReviewsToolStripMenuItem = new ToolStripMenuItem();
		ToolStripMenuItem1 = new ToolStripMenuItem();
		ByLowestRatingToolStripMenuItem = new ToolStripMenuItem();
		NewestToolStripMenuItem = new ToolStripMenuItem();
		ContextMenuStrip1 = new ContextMenuStrip(components);
		ModelsButton = new Button();
		PurchasedLotsButton = new Button();
		SubdivisionButton = new Button();
		Button1 = new Button();
		CustomersButton = new Button();
		SalespersonDetailsButton = new Button();
		((Control)MenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)ExitButton).set_BackColor(Color.Yellow);
		((Control)ExitButton).set_Location(new Point(403, 482));
		((Control)ExitButton).set_Margin(new Padding(3, 2, 3, 2));
		((Control)ExitButton).set_Name("ExitButton");
		((Control)ExitButton).set_Size(new Size(75, 23));
		((Control)ExitButton).set_TabIndex(0);
		((ButtonBase)ExitButton).set_Text("E&xit");
		((ButtonBase)ExitButton).set_UseVisualStyleBackColor(false);
		((ButtonBase)AvailableLotButton).set_BackColor(Color.Lime);
		((Control)AvailableLotButton).set_Location(new Point(708, 49));
		((Control)AvailableLotButton).set_Margin(new Padding(3, 2, 3, 2));
		((Control)AvailableLotButton).set_Name("AvailableLotButton");
		((Control)AvailableLotButton).set_Size(new Size(125, 42));
		((Control)AvailableLotButton).set_TabIndex(2);
		((ButtonBase)AvailableLotButton).set_Text("Available Lots");
		((ButtonBase)AvailableLotButton).set_UseVisualStyleBackColor(false);
		((ButtonBase)PurchaselotButton).set_BackColor(Color.Red);
		((Control)PurchaselotButton).set_Location(new Point(708, 162));
		((Control)PurchaselotButton).set_Margin(new Padding(3, 2, 3, 2));
		((Control)PurchaselotButton).set_Name("PurchaselotButton");
		((Control)PurchaselotButton).set_Size(new Size(125, 42));
		((Control)PurchaselotButton).set_TabIndex(1);
		((ButtonBase)PurchaselotButton).set_Text("Purchased Lots");
		((ButtonBase)PurchaselotButton).set_UseVisualStyleBackColor(false);
		((ButtonBase)Customer_Purchase_Record).set_BackColor(Color.Aqua);
		((Control)Customer_Purchase_Record).set_Location(new Point(15, 463));
		((Control)Customer_Purchase_Record).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Customer_Purchase_Record).set_Name("Customer_Purchase_Record");
		((Control)Customer_Purchase_Record).set_Size(new Size(160, 42));
		((Control)Customer_Purchase_Record).set_TabIndex(3);
		((ButtonBase)Customer_Purchase_Record).set_Text("Customer Records");
		((ButtonBase)Customer_Purchase_Record).set_UseVisualStyleBackColor(false);
		((ButtonBase)Available_Lot_Detail).set_BackColor(Color.FromArgb(255, 128, 0));
		((Control)Available_Lot_Detail).set_Location(new Point(500, 50));
		((Control)Available_Lot_Detail).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Available_Lot_Detail).set_Name("Available_Lot_Detail");
		((Control)Available_Lot_Detail).set_Size(new Size(181, 43));
		((Control)Available_Lot_Detail).set_TabIndex(4);
		((ButtonBase)Available_Lot_Detail).set_Text("Details of Available Lots");
		((ButtonBase)Available_Lot_Detail).set_UseVisualStyleBackColor(false);
		((ToolStrip)MenuStrip1).set_ImageScalingSize(new Size(20, 20));
		((ToolStrip)MenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)SalespersonReviewsToolStripMenuItem });
		((Control)MenuStrip1).set_Location(new Point(0, 0));
		((Control)MenuStrip1).set_Name("MenuStrip1");
		((Control)MenuStrip1).set_Size(new Size(848, 28));
		((Control)MenuStrip1).set_TabIndex(6);
		((Control)MenuStrip1).set_Text("MenuStrip1");
		((ToolStripDropDownItem)SalespersonReviewsToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)ShowReviewsToolStripMenuItem });
		((ToolStripItem)SalespersonReviewsToolStripMenuItem).set_Name("SalespersonReviewsToolStripMenuItem");
		((ToolStripItem)SalespersonReviewsToolStripMenuItem).set_Size(new Size(159, 24));
		((ToolStripItem)SalespersonReviewsToolStripMenuItem).set_Text("Salesperson Reviews");
		((ToolStripDropDownItem)ShowReviewsToolStripMenuItem).get_DropDownItems().AddRange((ToolStripItem[])(object)new ToolStripItem[3]
		{
			(ToolStripItem)ToolStripMenuItem1,
			(ToolStripItem)ByLowestRatingToolStripMenuItem,
			(ToolStripItem)NewestToolStripMenuItem
		});
		((ToolStripItem)ShowReviewsToolStripMenuItem).set_Name("ShowReviewsToolStripMenuItem");
		((ToolStripItem)ShowReviewsToolStripMenuItem).set_Size(new Size(185, 26));
		((ToolStripItem)ShowReviewsToolStripMenuItem).set_Text("Show Reviews");
		((ToolStripItem)ToolStripMenuItem1).set_Name("ToolStripMenuItem1");
		((ToolStripItem)ToolStripMenuItem1).set_Size(new Size(210, 26));
		((ToolStripItem)ToolStripMenuItem1).set_Text("By Highest Rating");
		((ToolStripItem)ByLowestRatingToolStripMenuItem).set_Name("ByLowestRatingToolStripMenuItem");
		((ToolStripItem)ByLowestRatingToolStripMenuItem).set_Size(new Size(210, 26));
		((ToolStripItem)ByLowestRatingToolStripMenuItem).set_Text("By Lowest Rating");
		((ToolStripItem)NewestToolStripMenuItem).set_Name("NewestToolStripMenuItem");
		((ToolStripItem)NewestToolStripMenuItem).set_Size(new Size(210, 26));
		((ToolStripItem)NewestToolStripMenuItem).set_Text("Newest");
		((ToolStrip)ContextMenuStrip1).set_ImageScalingSize(new Size(20, 20));
		((Control)ContextMenuStrip1).set_Name("ContextMenuStrip1");
		((Control)ContextMenuStrip1).set_Size(new Size(61, 4));
		((ButtonBase)ModelsButton).set_BackColor(Color.FromArgb(192, 0, 192));
		((Control)ModelsButton).set_Location(new Point(672, 386));
		((Control)ModelsButton).set_Margin(new Padding(4, 4, 4, 4));
		((Control)ModelsButton).set_Name("ModelsButton");
		((Control)ModelsButton).set_Size(new Size(160, 42));
		((Control)ModelsButton).set_TabIndex(7);
		((ButtonBase)ModelsButton).set_Text("Models");
		((ButtonBase)ModelsButton).set_UseVisualStyleBackColor(false);
		((ButtonBase)PurchasedLotsButton).set_BackColor(Color.MediumSlateBlue);
		((Control)PurchasedLotsButton).set_Location(new Point(500, 161));
		((Control)PurchasedLotsButton).set_Margin(new Padding(3, 2, 3, 2));
		((Control)PurchasedLotsButton).set_Name("PurchasedLotsButton");
		((Control)PurchasedLotsButton).set_Size(new Size(181, 43));
		((Control)PurchasedLotsButton).set_TabIndex(8);
		((ButtonBase)PurchasedLotsButton).set_Text("Details of Purchased Lots");
		((ButtonBase)PurchasedLotsButton).set_UseVisualStyleBackColor(false);
		((ButtonBase)SubdivisionButton).set_BackColor(Color.DimGray);
		((Control)SubdivisionButton).set_Location(new Point(673, 463));
		((Control)SubdivisionButton).set_Margin(new Padding(4, 4, 4, 4));
		((Control)SubdivisionButton).set_Name("SubdivisionButton");
		((Control)SubdivisionButton).set_Size(new Size(160, 42));
		((Control)SubdivisionButton).set_TabIndex(9);
		((ButtonBase)SubdivisionButton).set_Text("Subdivisions");
		((ButtonBase)SubdivisionButton).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button1).set_BackColor(Color.White);
		((Control)Button1).set_Location(new Point(15, 63));
		((Control)Button1).set_Margin(new Padding(3, 2, 3, 2));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(160, 42));
		((Control)Button1).set_TabIndex(10);
		((ButtonBase)Button1).set_Text("Salespersons ");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ButtonBase)CustomersButton).set_BackColor(Color.FromArgb(128, 64, 64));
		((Control)CustomersButton).set_Location(new Point(15, 399));
		((Control)CustomersButton).set_Margin(new Padding(3, 2, 3, 2));
		((Control)CustomersButton).set_Name("CustomersButton");
		((Control)CustomersButton).set_Size(new Size(160, 42));
		((Control)CustomersButton).set_TabIndex(11);
		((ButtonBase)CustomersButton).set_Text("Customers");
		((ButtonBase)CustomersButton).set_UseVisualStyleBackColor(false);
		((ButtonBase)SalespersonDetailsButton).set_AutoEllipsis(true);
		((ButtonBase)SalespersonDetailsButton).set_AutoSize(true);
		((ButtonBase)SalespersonDetailsButton).set_BackColor(Color.White);
		((Control)SalespersonDetailsButton).set_Location(new Point(15, 162));
		((Control)SalespersonDetailsButton).set_Margin(new Padding(3, 2, 3, 2));
		((Control)SalespersonDetailsButton).set_Name("SalespersonDetailsButton");
		((Control)SalespersonDetailsButton).set_Size(new Size(160, 42));
		((Control)SalespersonDetailsButton).set_TabIndex(12);
		((ButtonBase)SalespersonDetailsButton).set_Text("SalespersonsDetails");
		((ButtonBase)SalespersonDetailsButton).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.FromArgb(255, 255, 128));
		((Form)this).set_ClientSize(new Size(848, 519));
		((Control)this).get_Controls().Add((Control)(object)SalespersonDetailsButton);
		((Control)this).get_Controls().Add((Control)(object)CustomersButton);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)SubdivisionButton);
		((Control)this).get_Controls().Add((Control)(object)PurchasedLotsButton);
		((Control)this).get_Controls().Add((Control)(object)ModelsButton);
		((Control)this).get_Controls().Add((Control)(object)Available_Lot_Detail);
		((Control)this).get_Controls().Add((Control)(object)Customer_Purchase_Record);
		((Control)this).get_Controls().Add((Control)(object)PurchaselotButton);
		((Control)this).get_Controls().Add((Control)(object)AvailableLotButton);
		((Control)this).get_Controls().Add((Control)(object)ExitButton);
		((Control)this).get_Controls().Add((Control)(object)MenuStrip1);
		((Form)this).set_MainMenuStrip(MenuStrip1);
		((Form)this).set_Margin(new Padding(3, 2, 3, 2));
		((Control)this).set_Name("WelcomePage");
		((Form)this).set_Text("ANANTH & GUPTA CO.");
		((Control)MenuStrip1).ResumeLayout(false);
		((Control)MenuStrip1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
