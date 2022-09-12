using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hospital_Management_System.My;
using Hospital_Management_System.My.Resources;
using Microsoft.VisualBasic.CompilerServices;

namespace Hospital_Management_System;

[DesignerGenerated]
public class SearchReciever_Admin : UserControl
{
	private IContainer components;

	private OleDbConnection myconnection;

	private string name_search;

	private string mobile_search;

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button SearchBtn
	{
		[CompilerGenerated]
		get
		{
			return _SearchBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = SearchBtn_Click;
			Button searchBtn = _SearchBtn;
			if (searchBtn != null)
			{
				((Control)searchBtn).remove_Click(eventHandler);
			}
			_SearchBtn = value;
			searchBtn = _SearchBtn;
			if (searchBtn != null)
			{
				((Control)searchBtn).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MobileSTxt")]
	internal virtual TextBox MobileSTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NameSTxt")]
	internal virtual TextBox NameSTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView SearchResultGrid
	{
		[CompilerGenerated]
		get
		{
			return _SearchResultGrid;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			DataGridViewCellMouseEventHandler val = new DataGridViewCellMouseEventHandler(SearchResultGrid_CellMouseClick);
			DataGridView searchResultGrid = _SearchResultGrid;
			if (searchResultGrid != null)
			{
				searchResultGrid.remove_CellMouseClick(val);
			}
			_SearchResultGrid = value;
			searchResultGrid = _SearchResultGrid;
			if (searchResultGrid != null)
			{
				searchResultGrid.add_CellMouseClick(val);
			}
		}
	}

	[field: AccessedThroughProperty("RecieverInfoBox")]
	internal virtual GroupBox RecieverInfoBox
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("QuantityTxt")]
	internal virtual TextBox QuantityTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label12")]
	internal virtual Label Label12
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IDTxt")]
	internal virtual TextBox IDTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label11")]
	internal virtual Label Label11
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MobileTxt")]
	internal virtual TextBox MobileTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateRecievedTxt")]
	internal virtual TextBox DateRecievedTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DOBTxt")]
	internal virtual TextBox DOBTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NameTxt")]
	internal virtual TextBox NameTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label10")]
	internal virtual Label Label10
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button DeleteBtn
	{
		[CompilerGenerated]
		get
		{
			return _DeleteBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = DeleteBtn_Click;
			Button deleteBtn = _DeleteBtn;
			if (deleteBtn != null)
			{
				((Control)deleteBtn).remove_Click(eventHandler);
			}
			_DeleteBtn = value;
			deleteBtn = _DeleteBtn;
			if (deleteBtn != null)
			{
				((Control)deleteBtn).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button ClearBtn
	{
		[CompilerGenerated]
		get
		{
			return _ClearBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ClearBtn_Click;
			Button clearBtn = _ClearBtn;
			if (clearBtn != null)
			{
				((Control)clearBtn).remove_Click(eventHandler);
			}
			_ClearBtn = value;
			clearBtn = _ClearBtn;
			if (clearBtn != null)
			{
				((Control)clearBtn).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button UpdateBtn
	{
		[CompilerGenerated]
		get
		{
			return _UpdateBtn;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = UpdateBtn_Click;
			Button updateBtn = _UpdateBtn;
			if (updateBtn != null)
			{
				((Control)updateBtn).remove_Click(eventHandler);
			}
			_UpdateBtn = value;
			updateBtn = _UpdateBtn;
			if (updateBtn != null)
			{
				((Control)updateBtn).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("GenderTxt")]
	internal virtual ComboBox GenderTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BloodGroupTxt")]
	internal virtual ComboBox BloodGroupTxt
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public SearchReciever_Admin()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((UserControl)this).add_Load((EventHandler)SearchDonor_Admin_Load);
		myconnection = new OleDbConnection();
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
			((ContainerControl)this).Dispose(disposing);
		}
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_0415: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_0791: Expected O, but got Unknown
		//IL_09b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bf: Expected O, but got Unknown
		//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8b: Expected O, but got Unknown
		//IL_0af3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afd: Expected O, but got Unknown
		//IL_0bc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcd: Expected O, but got Unknown
		//IL_0c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca6: Expected O, but got Unknown
		//IL_0dac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db6: Expected O, but got Unknown
		//IL_0e23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e2d: Expected O, but got Unknown
		//IL_0e97: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea1: Expected O, but got Unknown
		//IL_0f1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f28: Expected O, but got Unknown
		//IL_0fc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fcc: Expected O, but got Unknown
		//IL_1066: Unknown result type (might be due to invalid IL or missing references)
		//IL_1070: Expected O, but got Unknown
		PictureBox1 = new PictureBox();
		Label1 = new Label();
		GroupBox1 = new GroupBox();
		SearchBtn = new Button();
		Label3 = new Label();
		MobileSTxt = new TextBox();
		NameSTxt = new TextBox();
		Label2 = new Label();
		SearchResultGrid = new DataGridView();
		RecieverInfoBox = new GroupBox();
		BloodGroupTxt = new ComboBox();
		GenderTxt = new ComboBox();
		QuantityTxt = new TextBox();
		Label12 = new Label();
		IDTxt = new TextBox();
		Label11 = new Label();
		Label4 = new Label();
		MobileTxt = new TextBox();
		Label9 = new Label();
		DateRecievedTxt = new TextBox();
		Label8 = new Label();
		DOBTxt = new TextBox();
		NameTxt = new TextBox();
		Label6 = new Label();
		Label5 = new Label();
		Label10 = new Label();
		DeleteBtn = new Button();
		ClearBtn = new Button();
		UpdateBtn = new Button();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)GroupBox1).SuspendLayout();
		((ISupportInitialize)SearchResultGrid).BeginInit();
		((Control)RecieverInfoBox).SuspendLayout();
		((Control)this).SuspendLayout();
		PictureBox1.set_Image((Image)(object)Resources.images);
		((Control)PictureBox1).set_Location(new Point(203, 18));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(197, 126));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(7);
		PictureBox1.set_TabStop(false);
		((Control)Label1).set_Font(new Font("MS Reference Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(392, 63));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(330, 47));
		((Control)Label1).set_TabIndex(8);
		Label1.set_Text("Search Reciever");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)GroupBox1).get_Controls().Add((Control)(object)SearchBtn);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)MobileSTxt);
		((Control)GroupBox1).get_Controls().Add((Control)(object)NameSTxt);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_Location(new Point(155, 150));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(623, 128));
		((Control)GroupBox1).set_TabIndex(12);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Search Patient");
		((ButtonBase)SearchBtn).set_BackColor(Color.MidnightBlue);
		((Control)SearchBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)SearchBtn).set_ForeColor(Color.White);
		((Control)SearchBtn).set_Location(new Point(468, 82));
		((Control)SearchBtn).set_Name("SearchBtn");
		((Control)SearchBtn).set_Size(new Size(133, 37));
		((Control)SearchBtn).set_TabIndex(4);
		((ButtonBase)SearchBtn).set_Text("Search");
		((ButtonBase)SearchBtn).set_UseVisualStyleBackColor(false);
		((Control)Label3).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(37, 87));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(77, 28));
		((Control)Label3).set_TabIndex(3);
		Label3.set_Text("Mobile : ");
		Label3.set_TextAlign((ContentAlignment)32);
		((Control)MobileSTxt).set_Location(new Point(120, 86));
		((Control)MobileSTxt).set_Name("MobileSTxt");
		((Control)MobileSTxt).set_Size(new Size(237, 28));
		((Control)MobileSTxt).set_TabIndex(2);
		((Control)NameSTxt).set_Location(new Point(120, 44));
		((Control)NameSTxt).set_Name("NameSTxt");
		((Control)NameSTxt).set_Size(new Size(237, 28));
		((Control)NameSTxt).set_TabIndex(1);
		((Control)Label2).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(37, 44));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(77, 28));
		((Control)Label2).set_TabIndex(0);
		Label2.set_Text("Name : ");
		Label2.set_TextAlign((ContentAlignment)32);
		SearchResultGrid.set_BackgroundColor(Color.White);
		SearchResultGrid.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)SearchResultGrid).set_Location(new Point(59, 295));
		((Control)SearchResultGrid).set_Name("SearchResultGrid");
		SearchResultGrid.set_ReadOnly(true);
		SearchResultGrid.get_RowTemplate().set_Height(24);
		((Control)SearchResultGrid).set_Size(new Size(853, 169));
		((Control)SearchResultGrid).set_TabIndex(13);
		((Control)RecieverInfoBox).get_Controls().Add((Control)(object)BloodGroupTxt);
		((Control)RecieverInfoBox).get_Controls().Add((Control)(object)GenderTxt);
		((Control)RecieverInfoBox).get_Controls().Add((Control)(object)QuantityTxt);
		((Control)RecieverInfoBox).get_Controls().Add((Control)(object)Label12);
		((Control)RecieverInfoBox).get_Controls().Add((Control)(object)IDTxt);
		((Control)RecieverInfoBox).get_Controls().Add((Control)(object)Label11);
		((Control)RecieverInfoBox).get_Controls().Add((Control)(object)Label4);
		((Control)RecieverInfoBox).get_Controls().Add((Control)(object)MobileTxt);
		((Control)RecieverInfoBox).get_Controls().Add((Control)(object)Label9);
		((Control)RecieverInfoBox).get_Controls().Add((Control)(object)DateRecievedTxt);
		((Control)RecieverInfoBox).get_Controls().Add((Control)(object)Label8);
		((Control)RecieverInfoBox).get_Controls().Add((Control)(object)DOBTxt);
		((Control)RecieverInfoBox).get_Controls().Add((Control)(object)NameTxt);
		((Control)RecieverInfoBox).get_Controls().Add((Control)(object)Label6);
		((Control)RecieverInfoBox).get_Controls().Add((Control)(object)Label5);
		((Control)RecieverInfoBox).get_Controls().Add((Control)(object)Label10);
		((Control)RecieverInfoBox).set_Font(new Font("MS Reference Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)RecieverInfoBox).set_Location(new Point(79, 470));
		((Control)RecieverInfoBox).set_Name("RecieverInfoBox");
		((Control)RecieverInfoBox).set_Size(new Size(699, 259));
		((Control)RecieverInfoBox).set_TabIndex(14);
		RecieverInfoBox.set_TabStop(false);
		RecieverInfoBox.set_Text("Reciever Information");
		BloodGroupTxt.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)BloodGroupTxt).set_FormattingEnabled(true);
		BloodGroupTxt.get_Items().AddRange(new object[8] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
		((Control)BloodGroupTxt).set_Location(new Point(531, 164));
		((Control)BloodGroupTxt).set_Name("BloodGroupTxt");
		((Control)BloodGroupTxt).set_Size(new Size(146, 30));
		((Control)BloodGroupTxt).set_TabIndex(21);
		GenderTxt.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)GenderTxt).set_FormattingEnabled(true);
		GenderTxt.get_Items().AddRange(new object[3] { "Male", "Female", "Others" });
		((Control)GenderTxt).set_Location(new Point(530, 117));
		((Control)GenderTxt).set_Name("GenderTxt");
		((Control)GenderTxt).set_Size(new Size(146, 30));
		((Control)GenderTxt).set_TabIndex(20);
		((Control)QuantityTxt).set_Location(new Point(507, 215));
		((Control)QuantityTxt).set_Name("QuantityTxt");
		((TextBoxBase)QuantityTxt).set_ReadOnly(true);
		((Control)QuantityTxt).set_Size(new Size(169, 28));
		((Control)QuantityTxt).set_TabIndex(19);
		((Control)Label12).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label12).set_Location(new Point(401, 217));
		((Control)Label12).set_Name("Label12");
		((Control)Label12).set_Size(new Size(100, 26));
		((Control)Label12).set_TabIndex(18);
		Label12.set_Text("Quantity : ");
		((Control)IDTxt).set_Location(new Point(117, 36));
		((Control)IDTxt).set_Name("IDTxt");
		((TextBoxBase)IDTxt).set_ReadOnly(true);
		((Control)IDTxt).set_Size(new Size(204, 28));
		((Control)IDTxt).set_TabIndex(17);
		((Control)Label11).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label11).set_Location(new Point(16, 36));
		((Control)Label11).set_Name("Label11");
		((Control)Label11).set_Size(new Size(68, 25));
		((Control)Label11).set_TabIndex(16);
		Label11.set_Text("ID :");
		((Control)Label4).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(388, 164));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(134, 28));
		((Control)Label4).set_TabIndex(13);
		Label4.set_Text("Blood Group : ");
		Label4.set_TextAlign((ContentAlignment)32);
		((Control)MobileTxt).set_Location(new Point(117, 124));
		((Control)MobileTxt).set_Name("MobileTxt");
		((Control)MobileTxt).set_Size(new Size(271, 28));
		((Control)MobileTxt).set_TabIndex(12);
		((Control)Label9).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label9).set_Location(new Point(16, 124));
		((Control)Label9).set_Name("Label9");
		((Control)Label9).set_Size(new Size(77, 28));
		((Control)Label9).set_TabIndex(11);
		Label9.set_Text("Phone : ");
		Label9.set_TextAlign((ContentAlignment)32);
		((Control)DateRecievedTxt).set_Location(new Point(166, 215));
		((Control)DateRecievedTxt).set_Name("DateRecievedTxt");
		((TextBoxBase)DateRecievedTxt).set_ReadOnly(true);
		((Control)DateRecievedTxt).set_Size(new Size(222, 28));
		((Control)DateRecievedTxt).set_TabIndex(10);
		((Control)Label8).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label8).set_Location(new Point(16, 78));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(77, 28));
		((Control)Label8).set_TabIndex(9);
		Label8.set_Text("Name : ");
		Label8.set_TextAlign((ContentAlignment)32);
		((Control)DOBTxt).set_Location(new Point(117, 167));
		((Control)DOBTxt).set_Name("DOBTxt");
		((Control)DOBTxt).set_Size(new Size(169, 28));
		((Control)DOBTxt).set_TabIndex(5);
		((Control)NameTxt).set_Location(new Point(117, 77));
		((Control)NameTxt).set_Name("NameTxt");
		((Control)NameTxt).set_Size(new Size(271, 28));
		((Control)NameTxt).set_TabIndex(4);
		((Control)Label6).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(401, 129));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(84, 26));
		((Control)Label6).set_TabIndex(2);
		Label6.set_Text("Gender : ");
		((Control)Label5).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(16, 169));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(84, 26));
		((Control)Label5).set_TabIndex(1);
		Label5.set_Text("Age :");
		((Control)Label10).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label10).set_Location(new Point(16, 221));
		((Control)Label10).set_Name("Label10");
		((Control)Label10).set_Size(new Size(174, 25));
		((Control)Label10).set_TabIndex(0);
		Label10.set_Text("Date Recieved :");
		((ButtonBase)DeleteBtn).set_BackColor(Color.MidnightBlue);
		((Control)DeleteBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)DeleteBtn).set_ForeColor(Color.White);
		((Control)DeleteBtn).set_Location(new Point(808, 584));
		((Control)DeleteBtn).set_Name("DeleteBtn");
		((Control)DeleteBtn).set_Size(new Size(104, 37));
		((Control)DeleteBtn).set_TabIndex(15);
		((ButtonBase)DeleteBtn).set_Text("Delete");
		((ButtonBase)DeleteBtn).set_UseVisualStyleBackColor(false);
		((ButtonBase)ClearBtn).set_BackColor(Color.MidnightBlue);
		((Control)ClearBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)ClearBtn).set_ForeColor(Color.White);
		((Control)ClearBtn).set_Location(new Point(808, 649));
		((Control)ClearBtn).set_Name("ClearBtn");
		((Control)ClearBtn).set_Size(new Size(104, 37));
		((Control)ClearBtn).set_TabIndex(16);
		((ButtonBase)ClearBtn).set_Text("Clear");
		((ButtonBase)ClearBtn).set_UseVisualStyleBackColor(false);
		((ButtonBase)UpdateBtn).set_BackColor(Color.MidnightBlue);
		((Control)UpdateBtn).set_Font(new Font("MS Reference Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)UpdateBtn).set_ForeColor(Color.White);
		((Control)UpdateBtn).set_Location(new Point(808, 517));
		((Control)UpdateBtn).set_Name("UpdateBtn");
		((Control)UpdateBtn).set_Size(new Size(104, 37));
		((Control)UpdateBtn).set_TabIndex(17);
		((ButtonBase)UpdateBtn).set_Text("Update");
		((ButtonBase)UpdateBtn).set_UseVisualStyleBackColor(false);
		((Control)UpdateBtn).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.White);
		((Control)this).get_Controls().Add((Control)(object)UpdateBtn);
		((Control)this).get_Controls().Add((Control)(object)ClearBtn);
		((Control)this).get_Controls().Add((Control)(object)DeleteBtn);
		((Control)this).get_Controls().Add((Control)(object)RecieverInfoBox);
		((Control)this).get_Controls().Add((Control)(object)SearchResultGrid);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).set_Name("SearchReciever_Admin");
		((Control)this).set_Size(new Size(977, 804));
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((ISupportInitialize)SearchResultGrid).EndInit();
		((Control)RecieverInfoBox).ResumeLayout(false);
		((Control)RecieverInfoBox).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void SearchDonor_Admin_Load(object sender, EventArgs e)
	{
		myconnection.set_ConnectionString(MyProject.Forms.Form1.provider + MyProject.Forms.Form1.datafile);
		HideItemsOnForm();
	}

	private bool HideItemsOnForm()
	{
		((Control)SearchResultGrid).set_Visible(false);
		((Control)RecieverInfoBox).set_Visible(false);
		((Control)ClearBtn).set_Visible(false);
		((Control)DeleteBtn).set_Visible(false);
		((Control)UpdateBtn).set_Visible(false);
		return true;
	}

	private void SearchBtn_Click(object sender, EventArgs e)
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		if (!MyProject.Forms.Form1.Name_Validation(NameSTxt.get_Text().ToLower()) | !MyProject.Forms.Form1.Mobile_Validator(MobileSTxt.get_Text().ToLower()))
		{
			MessageBox.Show("No Results Found");
			return;
		}
		HideItemsOnForm();
		new OleDbCommand();
		name_search = NameSTxt.get_Text().ToLower();
		mobile_search = MobileSTxt.get_Text().ToLower();
		string text = "Select * From [Recievers] Where [Name] Like '%" + NameSTxt.get_Text().ToLower() + "%' And [Contact Number] Like '%" + MobileSTxt.get_Text() + "%';";
		DataTable dataTable = new DataTable();
		myconnection.Open();
		try
		{
			OleDbDataAdapter val = new OleDbDataAdapter(text, myconnection);
			((DbDataAdapter)(object)val).Fill(dataTable);
			SearchResultGrid.set_DataSource((object)dataTable);
			if (SearchResultGrid.get_RowCount() == 1)
			{
				MessageBox.Show("No Result Found");
				myconnection.Close();
			}
			else
			{
				((Control)SearchResultGrid).set_Visible(true);
				myconnection.Close();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
	}

	private void UpdateBtn_Click(object sender, EventArgs e)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(NameTxt.get_Text(), "", false) == 0) | (Operators.CompareString(MobileTxt.get_Text(), "", false) == 0) | (Operators.CompareString(GenderTxt.get_Text(), "", false) == 0) | (Operators.CompareString(DOBTxt.get_Text(), "", false) == 0) | (Operators.CompareString(BloodGroupTxt.get_Text(), "", false) == 0))
		{
			MessageBox.Show("Fields Cannot be empty");
			return;
		}
		if (!(MyProject.Forms.Form1.Name_Validation(NameTxt.get_Text().ToLower()) & MyProject.Forms.Form1.Mobile_Validator(MobileTxt.get_Text()) & MyProject.Forms.Form1.age_validator(DOBTxt.get_Text())))
		{
			MessageBox.Show("Invalid Credentitals");
			return;
		}
		OleDbCommand val = new OleDbCommand();
		string text = "Update [Recievers] Set [Name] = '" + NameTxt.get_Text() + "', [Contact Number] = '" + MobileTxt.get_Text() + "', [Age] = " + DOBTxt.get_Text() + ", [Gender] = '" + GenderTxt.get_Text() + "', [Blood Group] = '" + BloodGroupTxt.get_Text() + "' Where [ID] = " + IDTxt.get_Text() + ";";
		myconnection.Open();
		try
		{
			val = new OleDbCommand(text, myconnection);
			val.ExecuteNonQuery();
			((Component)(object)val).Dispose();
			myconnection.Close();
			UpdateTable();
			MessageBox.Show("Successfully Updated Details");
			ClearDonorInfoBox();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
	}

	private void DeleteBtn_Click(object sender, EventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(IDTxt.get_Text(), "", false) == 0)
		{
			MessageBox.Show("Nothing To Delete");
			return;
		}
		OleDbCommand val = new OleDbCommand();
		string text = "Delete From [Recievers] Where [ID] = " + IDTxt.get_Text() + ";";
		myconnection.Open();
		try
		{
			val = new OleDbCommand(text, myconnection);
			val.ExecuteNonQuery();
			((Component)(object)val).Dispose();
			myconnection.Close();
			UpdateTable();
			ClearDonorInfoBox();
			MessageBox.Show("Successfully Deleted Entry");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
	}

	private void SearchResultGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
	{
		try
		{
			IDTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(0)
				.get_Value()));
			NameTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(1)
				.get_Value()));
			GenderTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(2)
				.get_Value()));
			DOBTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(3)
				.get_Value()));
			BloodGroupTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(4)
				.get_Value()));
			MobileTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(5)
				.get_Value()));
			DateRecievedTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(7)
				.get_Value()));
			QuantityTxt.set_Text(Conversions.ToString(SearchResultGrid.get_Rows().get_Item(e.get_RowIndex()).get_Cells()
				.get_Item(6)
				.get_Value()));
			((Control)RecieverInfoBox).set_Visible(true);
			((Control)ClearBtn).set_Visible(true);
			((Control)UpdateBtn).set_Visible(true);
			((Control)DeleteBtn).set_Visible(true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void ClearBtn_Click(object sender, EventArgs e)
	{
		ClearDonorInfoBox();
	}

	private bool ClearDonorInfoBox()
	{
		((TextBoxBase)IDTxt).Clear();
		((TextBoxBase)NameTxt).Clear();
		((TextBoxBase)MobileTxt).Clear();
		((TextBoxBase)DOBTxt).Clear();
		((TextBoxBase)DateRecievedTxt).Clear();
		GenderTxt.set_SelectedIndex(-1);
		BloodGroupTxt.set_SelectedIndex(-1);
		((TextBoxBase)QuantityTxt).Clear();
		return true;
	}

	private bool UpdateTable()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		new OleDbCommand();
		string text = "Select * From [Recievers] Where [Name] Like '%" + name_search + "%' And [Contact Number] Like '%" + mobile_search + "%';";
		DataTable dataTable = new DataTable();
		myconnection.Open();
		try
		{
			OleDbDataAdapter val = new OleDbDataAdapter(text, myconnection);
			((DbDataAdapter)(object)val).Fill(dataTable);
			SearchResultGrid.set_DataSource((object)dataTable);
			((Control)SearchResultGrid).set_Visible(true);
			myconnection.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			myconnection.Close();
			ProjectData.ClearProjectError();
		}
		return true;
	}
}
