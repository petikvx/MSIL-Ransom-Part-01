using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bz7;
using Di68;
using Gn3;
using Hx0;
using Jz9;
using Kd1q;
using Kr2c;
using Microsoft.VisualBasic.CompilerServices;
using Yr36;
using a2A;
using b9YC;
using e2D3;
using i4B6;
using j3S2;
using n2X;
using o5FP;
using q0GA;
using q4G1;
using w1R;
using x0S1;

namespace x9B;

[DesignerGenerated]
public class z8Y : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Label6
	{
		[CompilerGenerated]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Fe3;
			Label label = _Label6;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label6 = value;
			label = _Label6;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual Label Label7
	{
		[CompilerGenerated]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Mf1;
			Label label = _Label7;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label7 = value;
			label = _Label7;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("txtWeight")]
	internal virtual TextBox txtWeight
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

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRcode")]
	internal virtual TextBox txtRcode
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button btnDelete
	{
		[CompilerGenerated]
		get
		{
			return _btnDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = d2B6;
			Button val = _btnDelete;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnDelete = value;
			val = _btnDelete;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button btnModify
	{
		[CompilerGenerated]
		get
		{
			return _btnModify;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = i1Q8;
			Button val = _btnModify;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnModify = value;
			val = _btnModify;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("txtCategory")]
	internal virtual TextBox txtCategory
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtRName")]
	internal virtual TextBox txtRName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtAmount")]
	internal virtual TextBox txtAmount
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

	internal virtual Button btnSave
	{
		[CompilerGenerated]
		get
		{
			return _btnSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = k2K;
			Button val = _btnSave;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_btnSave = value;
			val = _btnSave;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public z8Y()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)s6N);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Bq4();
	}

	[DebuggerNonUserCode]
	protected override void Pr2(bool Gr9)
	{
		try
		{
			if (Gr9 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Gr9);
		}
	}

	[DebuggerStepThrough]
	private void Bq4()
	{
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d7: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0302: Expected O, but got Unknown
		//IL_0303: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_0350: Unknown result type (might be due to invalid IL or missing references)
		//IL_035a: Expected O, but got Unknown
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_0390: Expected O, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Expected O, but got Unknown
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b6: Expected O, but got Unknown
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected O, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_040c: Expected O, but got Unknown
		char[] char_ = Qp49.char_0;
		int num = 13;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 75;
			while (true)
			{
				txtWeight = new TextBox();
				Label10 = new Label();
				DataGridView1 = new DataGridView();
				num = 18;
				while (true)
				{
					DateTimePicker1 = new DateTimePicker();
					Label8 = new Label();
					Label5 = new Label();
					num = 42;
					while (true)
					{
						Label4 = new Label();
						Label1 = new Label();
						txtRcode = new TextBox();
						num = 81;
						while (true)
						{
							btnDelete = new Button();
							while (true)
							{
								btnModify = new Button();
								txtCategory = new TextBox();
								num = 4;
								while (true)
								{
									txtRName = new TextBox();
									txtAmount = new TextBox();
									Label2 = new Label();
									num = 79;
									while (true)
									{
										btnSave = new Button();
										((ISupportInitialize)DataGridView1).BeginInit();
										((Control)this).SuspendLayout();
										num = 1;
										while (true)
										{
											Label3.set_AutoSize(true);
											((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
											num = 2;
											while (true)
											{
												((Control)Label3).set_ForeColor(Color.White);
												((Control)Label3).set_Location(new Point(320, 21));
												num = 45;
												while (true)
												{
													((Control)Label3).set_Name("Label3");
													((Control)Label3).set_Size(new Size(123, 17));
													num = 26;
													while (true)
													{
														((Control)Label3).set_TabIndex(9);
														Label3.set_Text("Purchase Detail");
														num = 59;
														while (true)
														{
															Label6.set_AutoSize(true);
															((Control)Label6).set_BackColor(Color.Blue);
															num = 57;
															while (true)
															{
																((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																num = 73;
																while (true)
																{
																	((Control)Label6).set_ForeColor(Color.White);
																	((Control)Label6).set_Location(new Point(734, 21));
																	num = 55;
																	while (true)
																	{
																		((Control)Label6).set_Name("Label6");
																		((Control)Label6).set_Size(new Size(18, 17));
																		num = 36;
																		while (true)
																		{
																			((Control)Label6).set_TabIndex(10);
																			Label6.set_Text("X");
																			switch (char_[10])
																			{
																			case '㐼':
																				break;
																			case '㑏':
																				goto end_IL_000e;
																			case '㑡':
																				goto end_IL_018d;
																			case '㑑':
																				goto end_IL_01b9;
																			case '㑓':
																				goto end_IL_01e5;
																			case '㐲':
																				goto end_IL_0207;
																			case '㑅':
																				goto end_IL_0228;
																			case '㐚':
																				goto end_IL_024a;
																			case '㐙':
																			case '㑢':
																				goto end_IL_0273;
																			case '㑧':
																				goto end_IL_029f;
																			case '㐜':
																				goto end_IL_02cc;
																			case '㐬':
																				goto end_IL_02ec;
																			case '㑩':
																				goto end_IL_0312;
																			case '㑂':
																				goto end_IL_032c;
																			case '㐪':
																				goto end_IL_0339;
																			case '㑣':
																				goto end_IL_035f;
																			default:
																				goto end_IL_0385;
																			case '㐧':
																				Label7.set_AutoSize(true);
																				((Control)Label7).set_BackColor(Color.Blue);
																				num = 3;
																				goto case '㐛';
																			case '㐛':
																				((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																				num = 43;
																				goto case '㑃';
																			case '㑃':
																				((Control)Label7).set_ForeColor(Color.White);
																				((Control)Label7).set_Location(new Point(42, 21));
																				num = 19;
																				goto case '㐫';
																			case '㐫':
																				((Control)Label7).set_Name("Label7");
																				((Control)Label7).set_Size(new Size(92, 17));
																				num = 64;
																				goto case '㑘';
																			case '㑘':
																				((Control)Label7).set_TabIndex(9);
																				Label7.set_Text("Go To Main");
																				num = 37;
																				goto case '㐽';
																			case '㐽':
																				((Control)txtWeight).set_Location(new Point(537, 136));
																				((Control)txtWeight).set_Name("txtWeight");
																				num = 31;
																				goto case '㐷';
																			case '㐷':
																				((Control)txtWeight).set_Size(new Size(100, 20));
																				((Control)txtWeight).set_TabIndex(5);
																				num = 29;
																				goto case '㐵';
																			case '㐵':
																				Label10.set_AutoSize(true);
																				((Control)Label10).set_ForeColor(Color.White);
																				num = 53;
																				goto case '㑍';
																			case '㑍':
																				((Control)Label10).set_Location(new Point(478, 139));
																				((Control)Label10).set_Name("Label10");
																				num = 34;
																				goto case '㐺';
																			case '㐺':
																				((Control)Label10).set_Size(new Size(47, 13));
																				((Control)Label10).set_TabIndex(99);
																				num = 82;
																				goto case '㑪';
																			case '㑪':
																				Label10.set_Text("Weight :");
																				DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																				num = 30;
																				goto case '㐶';
																			case '㐶':
																				((Control)DataGridView1).set_Location(new Point(45, 239));
																				((Control)DataGridView1).set_Name("DataGridView1");
																				num = 46;
																				goto case '㑆';
																			case '㑆':
																				((Control)DataGridView1).set_Size(new Size(724, 199));
																				((Control)DataGridView1).set_TabIndex(11);
																				num = 58;
																				goto case '㑒';
																			case '㑒':
																				((Control)DateTimePicker1).set_Location(new Point(537, 64));
																				((Control)DateTimePicker1).set_Name("DateTimePicker1");
																				num = 41;
																				goto case '㑁';
																			case '㑁':
																				((Control)DateTimePicker1).set_Size(new Size(126, 20));
																				((Control)DateTimePicker1).set_TabIndex(3);
																				num = 27;
																				goto case '㐳';
																			case '㐳':
																				Label8.set_AutoSize(true);
																				((Control)Label8).set_ForeColor(Color.White);
																				num = 24;
																				goto case '㐰';
																			case '㐰':
																				((Control)Label8).set_Location(new Point(166, 130));
																				((Control)Label8).set_Name("Label8");
																				num = 7;
																				goto case '㐟';
																			case '㐟':
																				((Control)Label8).set_Size(new Size(55, 13));
																				((Control)Label8).set_TabIndex(94);
																				num = 33;
																				goto case '㐹';
																			case '㐹':
																				Label8.set_Text("Category :");
																				Label5.set_AutoSize(true);
																				num = 72;
																				goto case '㑠';
																			case '㑠':
																				((Control)Label5).set_ForeColor(Color.White);
																				((Control)Label5).set_Location(new Point(156, 101));
																				num = 23;
																				goto case '㐯';
																			case '㐯':
																				((Control)Label5).set_Name("Label5");
																				((Control)Label5).set_Size(new Size(66, 13));
																				num = 62;
																				goto case '㑖';
																			case '㑖':
																				((Control)Label5).set_TabIndex(93);
																				Label5.set_Text("Raw Name :");
																				num = 0;
																				goto case '㐘';
																			case '㐘':
																				Label4.set_AutoSize(true);
																				((Control)Label4).set_ForeColor(Color.White);
																				num = 14;
																				goto case '㐦';
																			case '㐦':
																				((Control)Label4).set_Location(new Point(466, 106));
																				((Control)Label4).set_Name("Label4");
																				num = 50;
																				goto case '㑊';
																			case '㑊':
																				((Control)Label4).set_Size(new Size(49, 13));
																				((Control)Label4).set_TabIndex(92);
																				num = 28;
																				goto case '㐴';
																			case '㐴':
																				Label4.set_Text("Amount :");
																				Label1.set_AutoSize(true);
																				num = 22;
																				goto case '㐮';
																			case '㐮':
																				((Control)Label1).set_ForeColor(Color.White);
																				((Control)Label1).set_Location(new Point(431, 67));
																				num = 32;
																				goto case '㐸';
																			case '㐸':
																				((Control)Label1).set_Name("Label1");
																				((Control)Label1).set_Size(new Size(84, 13));
																				num = 8;
																				goto case '㐠';
																			case '㐠':
																				((Control)Label1).set_TabIndex(91);
																				Label1.set_Text("Purchase Date :");
																				num = 47;
																				goto case '㑇';
																			case '㑇':
																				((Control)txtRcode).set_Location(new Point(245, 64));
																				((Control)txtRcode).set_Name("txtRcode");
																				num = 54;
																				goto case '㑎';
																			case '㑎':
																				((Control)txtRcode).set_Size(new Size(100, 20));
																				((Control)txtRcode).set_TabIndex(0);
																				num = 67;
																				goto case '㑛';
																			case '㑛':
																				((Control)btnDelete).set_Location(new Point(496, 202));
																				((Control)btnDelete).set_Name("btnDelete");
																				num = 11;
																				goto case '㐣';
																			case '㐣':
																				((Control)btnDelete).set_Size(new Size(75, 31));
																				((Control)btnDelete).set_TabIndex(8);
																				num = 66;
																				goto case '㑚';
																			case '㑚':
																				((ButtonBase)btnDelete).set_Text("DELETE");
																				((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																				num = 71;
																				goto case '㑟';
																			case '㑟':
																				((Control)btnModify).set_Location(new Point(378, 202));
																				((Control)btnModify).set_Name("btnModify");
																				num = 56;
																				goto case '㑐';
																			case '㑐':
																				((Control)btnModify).set_Size(new Size(75, 31));
																				((Control)btnModify).set_TabIndex(7);
																				num = 10;
																				goto case '㐢';
																			case '㐢':
																				((ButtonBase)btnModify).set_Text("MODIFY");
																				((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																				num = 69;
																				goto case '㑝';
																			case '㑝':
																				((Control)txtCategory).set_Location(new Point(243, 124));
																				((Control)txtCategory).set_Name("txtCategory");
																				num = 77;
																				goto case '㑥';
																			case '㑥':
																				((Control)txtCategory).set_Size(new Size(100, 20));
																				((Control)txtCategory).set_TabIndex(2);
																				num = 9;
																				goto case '㐡';
																			case '㐡':
																				((Control)txtRName).set_Location(new Point(243, 94));
																				((Control)txtRName).set_Name("txtRName");
																				num = 6;
																				goto case '㐞';
																			case '㐞':
																				((Control)txtRName).set_Size(new Size(100, 20));
																				((Control)txtRName).set_TabIndex(1);
																				num = 44;
																				goto case '㑄';
																			case '㑄':
																				((Control)txtAmount).set_Location(new Point(537, 99));
																				((Control)txtAmount).set_Name("txtAmount");
																				num = 17;
																				goto case '㐩';
																			case '㐩':
																				((Control)txtAmount).set_Size(new Size(100, 20));
																				((Control)txtAmount).set_TabIndex(4);
																				num = 38;
																				goto case '㐾';
																			case '㐾':
																				Label2.set_AutoSize(true);
																				((Control)Label2).set_ForeColor(Color.White);
																				num = 80;
																				goto case '㑨';
																			case '㑨':
																				((Control)Label2).set_Location(new Point(167, 67));
																				((Control)Label2).set_Name("Label2");
																				num = 68;
																				goto case '㑜';
																			case '㑜':
																				((Control)Label2).set_Size(new Size(63, 13));
																				((Control)Label2).set_TabIndex(90);
																				num = 65;
																				goto case '㑙';
																			case '㑙':
																				Label2.set_Text("Row Code :");
																				((Control)btnSave).set_Location(new Point(249, 202));
																				num = 49;
																				goto case '㑉';
																			case '㑉':
																				((Control)btnSave).set_Name("btnSave");
																				((Control)btnSave).set_Size(new Size(75, 31));
																				num = 21;
																				goto case '㐭';
																			case '㐭':
																				((Control)btnSave).set_TabIndex(6);
																				((ButtonBase)btnSave).set_Text("SAVE");
																				num = 51;
																				goto case '㑋';
																			case '㑋':
																				((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																				((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																				num = 16;
																				goto case '㐨';
																			case '㐨':
																				((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																				((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																				num = 61;
																				goto case '㑕';
																			case '㑕':
																			case '㑞':
																				((Form)this).set_ClientSize(new Size(800, 450));
																				((Control)this).get_Controls().Add((Control)(object)txtWeight);
																				num = 52;
																				goto case '㑌';
																			case '㑌':
																				((Control)this).get_Controls().Add((Control)(object)Label10);
																				((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																				num = 60;
																				goto case '㑔';
																			case '㑔':
																				((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
																				((Control)this).get_Controls().Add((Control)(object)Label8);
																				num = 78;
																				goto case '㑦';
																			case '㑦':
																				((Control)this).get_Controls().Add((Control)(object)Label5);
																				((Control)this).get_Controls().Add((Control)(object)Label4);
																				num = 63;
																				goto case '㑗';
																			case '㑗':
																				((Control)this).get_Controls().Add((Control)(object)Label1);
																				((Control)this).get_Controls().Add((Control)(object)txtRcode);
																				num = 25;
																				goto case '㐱';
																			case '㐱':
																				((Control)this).get_Controls().Add((Control)(object)btnDelete);
																				((Control)this).get_Controls().Add((Control)(object)btnModify);
																				num = 76;
																				goto case '㑤';
																			case '㑤':
																				((Control)this).get_Controls().Add((Control)(object)txtCategory);
																				((Control)this).get_Controls().Add((Control)(object)txtRName);
																				num = 5;
																				goto case '㐝';
																			case '㐝':
																				((Control)this).get_Controls().Add((Control)(object)txtAmount);
																				((Control)this).get_Controls().Add((Control)(object)Label2);
																				num = 12;
																				goto case '㐤';
																			case '㐤':
																				((Control)this).get_Controls().Add((Control)(object)btnSave);
																				((Control)this).get_Controls().Add((Control)(object)Label6);
																				num = 35;
																				goto case '㐻';
																			case '㐻':
																				((Control)this).get_Controls().Add((Control)(object)Label7);
																				((Control)this).get_Controls().Add((Control)(object)Label3);
																				num = 48;
																				goto case '㑈';
																			case '㑈':
																				((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																				((Control)this).set_Name("frmPurchaseDetail");
																				((Form)this).set_StartPosition((FormStartPosition)1);
																				num = 39;
																				goto case '㐿';
																			case '㐿':
																				((Form)this).set_Text("frmPurchaseDetail");
																				((ISupportInitialize)DataGridView1).EndInit();
																				((Control)this).ResumeLayout(false);
																				num = 40;
																				goto case '㑀';
																			case '㑀':
																				((Control)this).PerformLayout();
																				return;
																			}
																			continue;
																			end_IL_000e:
																			break;
																		}
																		continue;
																		end_IL_018d:
																		break;
																	}
																	continue;
																	end_IL_01b9:
																	break;
																}
																continue;
																end_IL_01e5:
																break;
															}
															continue;
															end_IL_0207:
															break;
														}
														continue;
														end_IL_0228:
														break;
													}
													continue;
													end_IL_024a:
													break;
												}
												continue;
												end_IL_0273:
												break;
											}
											continue;
											end_IL_029f:
											break;
										}
										continue;
										end_IL_02cc:
										break;
									}
									continue;
									end_IL_02ec:
									break;
								}
								continue;
								end_IL_0312:
								break;
							}
							continue;
							end_IL_032c:
							break;
						}
						continue;
						end_IL_0339:
						break;
					}
					continue;
					end_IL_035f:
					break;
				}
				continue;
				end_IL_0385:
				break;
			}
		}
	}

	private void Mf1(object sender, EventArgs e)
	{
		g2J4 g2J = new g2J4();
		((Control)g2J).Show();
		((Control)this).Hide();
	}

	private void Fe3(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void s6N(object sender, EventArgs e)
	{
		o9S();
	}

	private void k2K(object sender, EventArgs e)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_purchase_detail values(" + Conversions.ToString(Conversions.ToInteger(txtRcode.get_Text())) + ",'" + txtRName.get_Text() + "','" + txtCategory.get_Text() + "','" + DateTimePicker1.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtAmount.get_Text())) + ", " + Conversions.ToString(Conversions.ToInteger(txtWeight.get_Text())) + " )");
			cmd.ExecuteReader();
			MessageBox.Show("Record Saved");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			cn.Close();
		}
		o9S();
	}

	public void o9S()
	{
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_purchase_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Raw Code");
			DataGridView1.get_Columns().Add("c2", "Raw Name");
			DataGridView1.get_Columns().Add("c3", "Category");
			DataGridView1.get_Columns().Add("c4", "Purchase Date");
			DataGridView1.get_Columns().Add("c5", "Amount");
			DataGridView1.get_Columns().Add("c6", "Weight");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[6]
				{
					rd.get_Item("rowcode").ToString(),
					rd.get_Item("rowname"),
					rd.get_Item("category"),
					rd.get_Item("purdate"),
					rd.get_Item("amount"),
					rd.get_Item("weight")
				});
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			cn.Close();
		}
	}

	internal static byte[] d3L4(int n1YJ)
	{
		string[] array = new string[2] { "bbb", "nnn" };
		int num = new Random().Next(0, 1);
		string text = array[num];
		if (text.Length > 2)
		{
			return b7KC.Jn29(o2T.o7L(), n1YJ);
		}
		byte[] result = default(byte[]);
		return result;
	}

	private void i1Q8(object sender, EventArgs e)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_purchase_detail set rowname ='" + txtRName.get_Text() + "',category='" + txtCategory.get_Text() + "',purdate='" + DateTimePicker1.get_Text() + "',amount=" + Conversions.ToString(Conversions.ToInteger(txtAmount.get_Text())) + ", weight=" + Conversions.ToString(Conversions.ToInteger(txtWeight.get_Text())) + " where rowcode=" + Conversions.ToString(Conversions.ToInteger(txtRcode.get_Text())));
			cmd.ExecuteReader();
			MessageBox.Show("Record Modified");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			cn.Close();
		}
		o9S();
	}

	private void d2B6(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_purchase_detail where rowcode=" + Conversions.ToString(Conversions.ToInteger(txtRcode.get_Text())));
			cmd.ExecuteReader();
			MessageBox.Show("Record Deleted");
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.ToString());
			ProjectData.ClearProjectError();
		}
		finally
		{
			cn.Close();
		}
		o9S();
		n0J5.char_0[321] = (char)((n0J5.char_0[321] ^ n0J5.char_0[82]) & '\u0012');
	}

	static void w3D2()
	{
		checked
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Pw9k pw9k);
			System.Runtime.CompilerServices.Unsafe.SkipInit(out Fz0 fz);
			while ((object)e7WK.Default != null)
			{
				if (unchecked((nuint)(UIntPtr)e7WK.Default) * unchecked((nuint)(UIntPtr)e7WK.Default / checked(unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)e7WK.Default))) == 0)
				{
					while ((object)e7WK.Default != null)
					{
						pw9k = pw9k;
						pw9k = pw9k;
					}
					continue;
				}
				try
				{
					_ = (z0R3)(object)e7WK.Default;
				}
				catch
				{
					Fz0 obj = (Fz0)e7WK.Default;
					fz = fz;
					fz = obj;
				}
			}
			do
			{
				g2J4 g2J = (g2J4)(object)e7WK.Default;
				g2J = g2J;
			}
			while ((object)e7WK.Default != null);
			if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
			{
				_ = (Pw9k)(object)e7WK.Default;
			}
			else
			{
				o2T o2T = o2T;
				o2T = o2T;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		do
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					g2J4 g2J = null;
				}
				while ((object)e7WK.Default != null);
			}
			obj3 = obj3;
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6G b6G);
		nuint num;
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (So3)(object)e7WK.Default;
				}
				finally
				{
					b6G = (b6G)e7WK.Default;
					b6G = b6G;
					goto IL_01d6;
				}
			}
			num = default(UIntPtr);
			checked
			{
				if (unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)default(UIntPtr)) + num) + num * unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
				{
					_ = (Yo50)(object)e7WK.Default;
					_ = (So3)(object)e7WK.Default;
					_ = (Cx7)(object)e7WK.Default;
					Fz0 fz = (Fz0)e7WK.Default;
				}
			}
		}
		goto IL_01d6;
		IL_04e5:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out So3 so);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qp49 qp);
		checked
		{
			if (num == 0)
			{
				if (num == 0)
				{
					_ = (c8CP)(object)e7WK.Default;
				}
				else
				{
					num = default(UIntPtr);
					if ((num + unchecked((nuint)(UIntPtr)e7WK.Default) - unchecked((nuint)(UIntPtr)e7WK.Default)) * unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
					{
						_ = (z0R3)(object)e7WK.Default;
						qp = qp;
					}
				}
			}
			else
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					try
					{
						so = null;
					}
					finally
					{
						_003CModule_003E _003CModule_003E = null;
						goto IL_0562;
					}
				}
			}
			goto IL_0562;
		}
		IL_03f3:
		try
		{
		}
		catch
		{
			try
			{
				Yo50 yo = (Yo50)(object)e7WK.Default;
				yo = yo;
			}
			catch
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out q1M q1M);
				while (true)
				{
					if (obj3 != null)
					{
						q1M = q1M;
						q1M = null;
						continue;
					}
					goto end_IL_040f;
				}
				end_IL_040f:;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c8CP c8CP);
		try
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				c8CP = c8CP;
				c8CP = c8CP;
			}
		}
		catch
		{
			try
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					qp = qp;
					qp = null;
				}
			}
			catch
			{
				while (true)
				{
					if (obj3 != null)
					{
						_ = (z8Y)(object)e7WK.Default;
						continue;
					}
					goto end_IL_0464;
				}
				end_IL_0464:;
			}
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z0R3 z0R);
		if (num == 0)
		{
			try
			{
				_ = (Pw9k)(object)e7WK.Default;
			}
			catch
			{
				_003CModule_003E obj8 = (_003CModule_003E)(object)e7WK.Default;
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = obj8;
			}
			finally
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					_ = (y2HN)(object)e7WK.Default;
				}
				else
				{
					z0R = z0R;
				}
				goto IL_04e5;
			}
		}
		while ((object)e7WK.Default != null)
		{
		}
		goto IL_04e5;
		IL_0688:
		if (checked(num - num) == 0)
		{
			_ = (q1M)(object)e7WK.Default;
			goto IL_06db;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z8Y z8Y2);
		try
		{
			if (num == 0)
			{
				_ = (z0R3)(object)e7WK.Default;
			}
			else
			{
				z8Y2 = z8Y2;
			}
		}
		finally
		{
			try
			{
				_ = (Yo50)(object)e7WK.Default;
			}
			finally
			{
				_ = (z0R3)(object)e7WK.Default;
				goto IL_06db;
			}
		}
		IL_01fc:
		do
		{
			_ = (_003CModule_003E)(object)e7WK.Default;
		}
		while (obj3 != null);
		num = default(UIntPtr);
		checked
		{
			nuint num2 = unchecked((nuint)default(UIntPtr)) * unchecked(unchecked((nuint)default(UIntPtr)) / checked(unchecked(checked(num + num) / unchecked((nuint)default(UIntPtr))) + unchecked((nuint)default(UIntPtr))));
			num = default(UIntPtr);
			if (num2 + num == 0 && (num + num) * (unchecked((nuint)(UIntPtr)e7WK.Default) + unchecked((nuint)(UIntPtr)e7WK.Default)) == 0 && unchecked((nuint)(UIntPtr)e7WK.Default) - num == 0)
			{
				e7WK e7WK = e7WK;
				e7WK = e7WK;
			}
			try
			{
				try
				{
					_ = (z0R3)(object)e7WK.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)e7WK.Default;
					goto end_IL_02b0;
				}
				end_IL_02b0:;
			}
			catch
			{
				try
				{
				}
				catch
				{
					so = so;
					so = null;
				}
			}
			try
			{
				_ = (o2T)(object)e7WK.Default;
				_ = (Dx5s)(object)e7WK.Default;
				_ = (Qe07)(object)e7WK.Default;
			}
			finally
			{
				try
				{
					do
					{
						_ = (Yo50)(object)e7WK.Default;
						b7KC b7KC = null;
						b7KC = b7KC;
					}
					while ((object)e7WK.Default != null);
				}
				catch
				{
					Pw9k pw9k = null;
				}
				goto IL_0338;
			}
		}
		IL_0338:
		checked
		{
			if (num - num * num * unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
			{
				_ = (z8Y)(object)e7WK.Default;
			}
			else
			{
				_ = (o2T)(object)e7WK.Default;
			}
		}
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				b6G = b6G;
			}
			finally
			{
				_ = (g2J4)(object)e7WK.Default;
				goto IL_03cc;
			}
		}
		try
		{
			b6G = b6G;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				so = null;
			}
			else
			{
				_ = e7WK.Default;
			}
			goto IL_03cc;
		}
		IL_01d6:
		try
		{
			_ = (b6G)e7WK.Default;
		}
		finally
		{
			n0J5 n0J = (n0J5)(object)e7WK.Default;
			n0J = n0J;
			goto IL_01fc;
		}
		IL_08e4:
		while ((object)e7WK.Default != null)
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					o2T o2T = null;
				}
				continue;
			}
			try
			{
				_ = (n0J5)(object)e7WK.Default;
			}
			catch
			{
				z8Y2 = z8Y2;
			}
		}
		qp = (Qp49)(object)e7WK.Default;
		c8CP = c8CP;
		checked
		{
			try
			{
				qp = qp;
				return;
			}
			catch
			{
				if (num + unchecked((nuint)default(UIntPtr)) == 0)
				{
					_ = (o2T)(object)e7WK.Default;
				}
				return;
			}
		}
		IL_06db:
		_ = (z8Y)(object)e7WK.Default;
		try
		{
			try
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					b6G = default(b6G);
					b6G = b6G;
				}
			}
			catch
			{
				Pw9k pw9k = (Pw9k)(object)e7WK.Default;
			}
		}
		catch
		{
			_ = (y2HN)(object)e7WK.Default;
		}
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			while (obj3 != null)
			{
				try
				{
					_ = (c8CP)(object)e7WK.Default;
					b6G = b6G;
				}
				finally
				{
					_ = e7WK.Default;
					_ = (Cx7)(object)e7WK.Default;
					_ = (Cx7)(object)e7WK.Default;
					_ = (Qt2)(object)e7WK.Default;
					_ = (Pw9k)(object)e7WK.Default;
					continue;
				}
			}
		}
		else
		{
			do
			{
				try
				{
					_ = (Qp49)(object)e7WK.Default;
				}
				catch
				{
					_ = (_003CModule_003E)(object)e7WK.Default;
					_ = (y2HN)(object)e7WK.Default;
					e7WK e7WK = e7WK.Default;
				}
			}
			while (obj3 != null);
		}
		while (obj3 != null)
		{
			while (obj3 != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					so = so;
				}
			}
		}
		z0R = z0R;
		while (obj3 != null)
		{
			do
			{
				_ = (b6G)e7WK.Default;
			}
			while (obj3 != null);
		}
		num = default(UIntPtr);
		if (num == 0)
		{
			try
			{
				while (obj3 != null)
				{
					_ = (y2HN)(object)e7WK.Default;
				}
			}
			catch
			{
				Qe07 qe = (Qe07)(object)e7WK.Default;
				qe = qe;
			}
		}
		else
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Qt2)(object)e7WK.Default;
				}
				finally
				{
					_ = (b7KC)(object)e7WK.Default;
					goto IL_08e4;
				}
			}
			try
			{
				_ = (Qt2)(object)e7WK.Default;
			}
			catch
			{
				_ = (z0R3)(object)e7WK.Default;
				_ = (Qp49)(object)e7WK.Default;
				_ = (Cx7)(object)e7WK.Default;
			}
		}
		goto IL_08e4;
		IL_0562:
		try
		{
			while (obj3 != null)
			{
			}
		}
		catch
		{
			nuint num3 = num;
			num = default(UIntPtr);
			if (num3 / num == 0)
			{
				do
				{
					Fz0 fz = (Fz0)e7WK.Default;
					_ = (Qe07)(object)e7WK.Default;
					e7WK e7WK = e7WK.Default;
				}
				while (obj3 != null);
			}
		}
		while (obj3 != null)
		{
		}
		_ = (c8CP)(object)e7WK.Default;
		try
		{
			_ = (_003CModule_003E)(object)e7WK.Default;
		}
		catch
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Qt2)(object)e7WK.Default;
				}
				finally
				{
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)e7WK.Default;
					so = so;
					_ = (o2T)(object)e7WK.Default;
					b6G = default(b6G);
					goto end_IL_05cf;
				}
			}
			do
			{
				c8CP = (c8CP)(object)e7WK.Default;
				z0R = z0R;
			}
			while (obj3 != null);
			end_IL_05cf:;
		}
		try
		{
			try
			{
				do
				{
					_ = (Qp49)(object)e7WK.Default;
				}
				while (obj3 != null);
			}
			finally
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Qt2 qt);
				while (obj3 != null)
				{
					qt = qt;
					qt = qt;
				}
				goto end_IL_063d;
			}
			end_IL_063d:;
		}
		finally
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Fz0)e7WK.Default;
			}
			goto IL_0688;
		}
		IL_03cc:
		try
		{
			do
			{
				_ = (b6G)e7WK.Default;
			}
			while (obj3 != null);
		}
		finally
		{
			z0R = z0R;
			z0R = z0R;
			goto IL_03f3;
		}
	}

	static void Yi47()
	{
		object obj;
		do
		{
			_ = (Qt2)(object)e7WK.Default;
			obj = e7WK.Default;
		}
		while (obj != null);
		o2T o2T = null;
		o2T = o2T;
		do
		{
			_ = (q1M)(object)e7WK.Default;
		}
		while ((object)e7WK.Default != null);
		while (obj != null)
		{
			_ = (Pw9k)(object)e7WK.Default;
		}
		nuint uIntPtr = default(UIntPtr);
		uIntPtr = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Dx5s dx5s);
		if (unchecked((nuint)default(UIntPtr)) / checked(uIntPtr * unchecked((nuint)(UIntPtr)e7WK.Default)) == 0)
		{
			try
			{
				o2T = null;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = e7WK.Default;
				}
				else
				{
					dx5s = dx5s;
					dx5s = dx5s;
				}
				goto IL_00be;
			}
		}
		goto IL_00be;
		IL_041b:
		Fz0 fz;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cx7 cx);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z8Y z8Y2);
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					cx = (Cx7)(object)e7WK.Default;
					cx = cx;
				}
				finally
				{
					z8Y2 = z8Y2;
					_ = (Qt2)(object)e7WK.Default;
					fz = (Fz0)e7WK.Default;
					fz = fz;
					goto end_IL_0427;
				}
				end_IL_0427:;
			}
			catch
			{
				_ = (c8CP)(object)e7WK.Default;
				_ = (Dx5s)(object)e7WK.Default;
				_ = (z0R3)(object)e7WK.Default;
			}
		}
		_ = e7WK.Default;
		_ = (q1M)(object)e7WK.Default;
		Pw9k pw9k = pw9k;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out z0R3 z0R);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n0J5 n0J);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6G b6G);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b7KC b7KC);
		try
		{
			b7KC = b7KC;
		}
		finally
		{
			try
			{
				try
				{
					b6G obj3 = (b6G)e7WK.Default;
					b6G = b6G;
					b6G = obj3;
				}
				finally
				{
					_ = (y2HN)(object)e7WK.Default;
					goto end_IL_04ba;
				}
				end_IL_04ba:;
			}
			finally
			{
				z0R = null;
				o2T = null;
				n0J = n0J;
				goto IL_04f8;
			}
		}
		IL_01ce:
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				b7KC obj4 = (b7KC)(object)e7WK.Default;
				b7KC = (b7KC)(object)e7WK.Default;
				b7KC = obj4;
			}
			while ((object)e7WK.Default != null);
		}
		_ = (Yo50)(object)e7WK.Default;
		while ((object)e7WK.Default != null)
		{
		}
		_ = (g2J4)(object)e7WK.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qt2 qt);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					qt = null;
					qt = qt;
				}
				else
				{
					c8CP c8CP = c8CP;
					c8CP = c8CP;
				}
			}
			finally
			{
				try
				{
					qt = qt;
				}
				finally
				{
					g2J4 obj5 = (g2J4)(object)e7WK.Default;
					g2J4 g2J = g2J;
					g2J = obj5;
					goto IL_028a;
				}
			}
		}
		goto IL_028a;
		IL_028a:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qe07 qe);
		do
		{
			Qe07 obj6 = (Qe07)(object)e7WK.Default;
			qe = qe;
			qe = obj6;
		}
		while (obj != null);
		b7KC = b7KC;
		_ = (Qe07)(object)e7WK.Default;
		nuint num;
		checked
		{
			num = unchecked((nuint)default(UIntPtr)) - (unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)(UIntPtr)e7WK.Default / unchecked((nuint)default(UIntPtr))) + unchecked((nuint)(UIntPtr)e7WK.Default)));
			uIntPtr = default(UIntPtr);
		}
		if (num / uIntPtr == 0)
		{
			do
			{
				_ = (Qp49)(object)e7WK.Default;
			}
			while (obj != null || (object)e7WK.Default != null);
		}
		_ = (Dx5s)(object)e7WK.Default;
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			while (obj != null)
			{
				do
				{
					o2T = o2T;
				}
				while (obj != null);
			}
		}
		try
		{
			o2T = null;
		}
		catch
		{
			while (obj != null)
			{
				z8Y2 = z8Y2;
				z8Y2 = z8Y2;
			}
		}
		finally
		{
			z8Y2 = (z8Y)(object)e7WK.Default;
			goto IL_0390;
		}
		IL_04f8:
		_ = (z0R3)(object)e7WK.Default;
		fz = default(Fz0);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				try
				{
					g2J4 g2J = null;
					z8Y2 = (z8Y)(object)e7WK.Default;
					_ = (o2T)(object)e7WK.Default;
					_ = (Pw9k)(object)e7WK.Default;
				}
				finally
				{
					_ = (Pw9k)(object)e7WK.Default;
					Qp49 qp = qp;
					qp = qp;
					e7WK obj8 = e7WK.Default;
					e7WK e7WK = e7WK;
					e7WK = obj8;
					pw9k = (Pw9k)(object)e7WK.Default;
					goto end_IL_0515;
				}
			}
			end_IL_0515:;
		}
		finally
		{
			b6G = b6G;
			goto IL_059d;
		}
		IL_0390:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1M q1M);
		try
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0)
			{
				if (uIntPtr == 0)
				{
					z0R = z0R;
					z0R = null;
				}
				else
				{
					Pw9k obj9 = (Pw9k)(object)e7WK.Default;
					pw9k = null;
					pw9k = obj9;
				}
			}
		}
		finally
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				if (uIntPtr == 0)
				{
					_ = (o2T)(object)e7WK.Default;
					pw9k = null;
					z0R = z0R;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					q1M = null;
				}
				else
				{
					_ = (Yo50)(object)e7WK.Default;
				}
			}
			goto IL_041b;
		}
		IL_00be:
		n0J = n0J;
		n0J = n0J;
		try
		{
			_ = (_003CModule_003E)(object)e7WK.Default;
			_ = (Yo50)(object)e7WK.Default;
			_ = (g2J4)(object)e7WK.Default;
		}
		catch
		{
			q1M = (q1M)(object)e7WK.Default;
			q1M = q1M;
		}
		if (uIntPtr == 0)
		{
			_ = e7WK.Default;
		}
		else if (uIntPtr == 0)
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)e7WK.Default;
				_003CModule_003E = _003CModule_003E;
			}
			else
			{
				_ = (b7KC)(object)e7WK.Default;
			}
		}
		do
		{
			if (uIntPtr == 0)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (b7KC)(object)e7WK.Default;
				}
				else
				{
					_ = (b7KC)(object)e7WK.Default;
				}
			}
		}
		while ((object)e7WK.Default != null);
		if (default(UIntPtr) == (UIntPtr)(nuint)0u && default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (c8CP)(object)e7WK.Default;
			}
			finally
			{
				_ = e7WK.Default;
				goto IL_01ce;
			}
		}
		goto IL_01ce;
		IL_05d0:
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (b7KC)(object)e7WK.Default;
				dx5s = null;
				b6G = b6G;
			}
			catch
			{
				g2J4 g2J = (g2J4)(object)e7WK.Default;
			}
		}
		else
		{
			cx = cx;
		}
		z8Y2 = z8Y2;
		if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			if (uIntPtr == 0)
			{
				q1M = q1M;
				b7KC = null;
			}
		}
		else
		{
			try
			{
				_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)e7WK.Default;
			}
			catch
			{
				if ((nuint)(UIntPtr)e7WK.Default / (nuint)(UIntPtr)e7WK.Default == 0)
				{
					_ = (q1M)(object)e7WK.Default;
				}
			}
		}
		dx5s = dx5s;
		_ = (Pw9k)(object)e7WK.Default;
		pw9k = null;
		_ = (g2J4)(object)e7WK.Default;
		return;
		IL_059d:
		try
		{
			do
			{
				try
				{
					q1M = q1M;
				}
				catch
				{
					b6G = (b6G)e7WK.Default;
				}
			}
			while (obj != null);
		}
		finally
		{
			_ = (Qt2)(object)e7WK.Default;
			goto IL_05d0;
		}
	}
}
