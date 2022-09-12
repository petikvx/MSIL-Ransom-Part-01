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
using x0S1;
using x9B;

namespace w1R;

[DesignerGenerated]
public class So3 : Form
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
			EventHandler eventHandler = Rp9;
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
			EventHandler eventHandler = b9X;
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
			EventHandler eventHandler = Hy2;
			Button val = _btnDelete;
			Button obj = val;
			n0J5.char_0[44] = (char)((n0J5.char_0[44] | n0J5.char_0[148]) & '(');
			if (obj != null)
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
			EventHandler eventHandler = Bn9;
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

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtWRent")]
	internal virtual TextBox txtWRent
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtMname")]
	internal virtual TextBox txtMname
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtWName")]
	internal virtual TextBox txtWName
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("txtWid")]
	internal virtual TextBox txtWid
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
			EventHandler eventHandler = p7L;
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

	[field: AccessedThroughProperty("txtWAddress")]
	internal virtual TextBox txtWAddress
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtWStock")]
	internal virtual TextBox txtWStock
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public So3()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)n0N);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Zj4();
	}

	[DebuggerNonUserCode]
	protected override void o9C(bool Pq3)
	{
		char[] char_ = n0J5.char_0;
		try
		{
			int num = 1;
			while (true)
			{
				if (!Pq3)
				{
					char num2 = char_[298];
					Qp49.char_0[324] = (char)((Qp49.char_0[324] * Qp49.char_0[329]) & 'Ù');
					switch (num2 - 42857)
					{
					case 3:
						goto IL_0070;
					case 0:
						goto IL_007f;
					case 2:
					case 5:
					case 6:
						goto end_IL_0066;
					case 4:
					case 7:
						return;
					}
					continue;
				}
				num = 3;
				goto IL_0070;
				IL_0070:
				if (components != null)
				{
					num = 6;
					break;
				}
				goto IL_007f;
				IL_007f:
				num = 4;
				return;
				continue;
				end_IL_0066:
				break;
			}
			components.Dispose();
			num = 4;
		}
		finally
		{
			((Form)this).Dispose(Pq3);
		}
	}

	[DebuggerStepThrough]
	private void Zj4()
	{
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected O, but got Unknown
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d4: Expected O, but got Unknown
		//IL_0893: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Expected O, but got Unknown
		//IL_08a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ad: Expected O, but got Unknown
		//IL_08c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cd: Expected O, but got Unknown
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d8: Expected O, but got Unknown
		//IL_08d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e3: Expected O, but got Unknown
		//IL_08e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f3: Expected O, but got Unknown
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Expected O, but got Unknown
		//IL_08ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0909: Expected O, but got Unknown
		//IL_090f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0919: Expected O, but got Unknown
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0924: Expected O, but got Unknown
		//IL_0925: Unknown result type (might be due to invalid IL or missing references)
		//IL_092f: Expected O, but got Unknown
		//IL_0935: Unknown result type (might be due to invalid IL or missing references)
		//IL_093f: Expected O, but got Unknown
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_094a: Expected O, but got Unknown
		//IL_094b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0955: Expected O, but got Unknown
		//IL_095b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0965: Expected O, but got Unknown
		//IL_0966: Unknown result type (might be due to invalid IL or missing references)
		//IL_0970: Expected O, but got Unknown
		//IL_0971: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Expected O, but got Unknown
		//IL_0981: Unknown result type (might be due to invalid IL or missing references)
		//IL_098b: Expected O, but got Unknown
		//IL_098c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0996: Expected O, but got Unknown
		//IL_0997: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Expected O, but got Unknown
		char[] char_ = Qp49.char_0;
		int num = 74;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 80;
			while (true)
			{
				btnDelete = new Button();
				btnModify = new Button();
				DataGridView1 = new DataGridView();
				num = 83;
				while (true)
				{
					txtWRent = new TextBox();
					txtMname = new TextBox();
					txtWName = new TextBox();
					num = 64;
					while (true)
					{
						Label4 = new Label();
						Label1 = new Label();
						Label2 = new Label();
						num = 48;
						while (true)
						{
							Label5 = new Label();
							txtWid = new TextBox();
							btnSave = new Button();
							num = 77;
							while (true)
							{
								txtWAddress = new TextBox();
								Label8 = new Label();
								Label9 = new Label();
								num = 23;
								while (true)
								{
									txtWStock = new TextBox();
									((ISupportInitialize)DataGridView1).BeginInit();
									((Control)this).SuspendLayout();
									num = 2;
									while (true)
									{
										Label3.set_AutoSize(true);
										((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 63;
										while (true)
										{
											((Control)Label3).set_ForeColor(Color.White);
											((Control)Label3).set_Location(new Point(326, 23));
											num = 43;
											while (true)
											{
												((Control)Label3).set_Name("Label3");
												((Control)Label3).set_Size(new Size(137, 17));
												num = 37;
												while (true)
												{
													((Control)Label3).set_TabIndex(9);
													Label3.set_Text("Warehouse Detail");
													num = 81;
													while (true)
													{
														Label6.set_AutoSize(true);
														((Control)Label6).set_BackColor(Color.Blue);
														num = 13;
														while (true)
														{
															((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
															num = 58;
															while (true)
															{
																((Control)Label6).set_ForeColor(Color.White);
																((Control)Label6).set_Location(new Point(723, 23));
																num = 51;
																while (true)
																{
																	((Control)Label6).set_Name("Label6");
																	((Control)Label6).set_Size(new Size(18, 17));
																	num = 56;
																	while (true)
																	{
																		((Control)Label6).set_TabIndex(10);
																		while (true)
																		{
																			Label6.set_Text("X");
																			num = 26;
																			while (true)
																			{
																				Label7.set_AutoSize(true);
																				((Control)Label7).set_BackColor(Color.Blue);
																				num = 69;
																				while (true)
																				{
																					((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																					num = 12;
																					while (true)
																					{
																						((Control)Label7).set_ForeColor(Color.White);
																						((Control)Label7).set_Location(new Point(31, 23));
																						num = 73;
																						while (true)
																						{
																							((Control)Label7).set_Name("Label7");
																							((Control)Label7).set_Size(new Size(92, 17));
																							num = 33;
																							while (true)
																							{
																								((Control)Label7).set_TabIndex(9);
																								Label7.set_Text("Go To Main");
																								num = 17;
																								while (true)
																								{
																									((Control)btnDelete).set_Location(new Point(419, 218));
																									((Control)btnDelete).set_Name("btnDelete");
																									num = 30;
																									while (true)
																									{
																										((Control)btnDelete).set_Size(new Size(75, 23));
																										((Control)btnDelete).set_TabIndex(8);
																										num = 28;
																										while (true)
																										{
																											((ButtonBase)btnDelete).set_Text("DELETE");
																											((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																											num = 4;
																											while (true)
																											{
																												((Control)btnModify).set_Location(new Point(307, 218));
																												((Control)btnModify).set_Name("btnModify");
																												num = 62;
																												while (true)
																												{
																													((Control)btnModify).set_Size(new Size(75, 23));
																													((Control)btnModify).set_TabIndex(7);
																													num = 20;
																													while (true)
																													{
																														((ButtonBase)btnModify).set_Text("MODIFY");
																														((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																														num = 65;
																														while (true)
																														{
																															DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																															((Control)DataGridView1).set_Location(new Point(71, 255));
																															num = 21;
																															while (true)
																															{
																																((Control)DataGridView1).set_Name("DataGridView1");
																																((Control)DataGridView1).set_Size(new Size(599, 183));
																																num = 82;
																																while (true)
																																{
																																	((Control)DataGridView1).set_TabIndex(11);
																																	((Control)txtWRent).set_Location(new Point(212, 173));
																																	num = 9;
																																	while (true)
																																	{
																																		((Control)txtWRent).set_Name("txtWRent");
																																		((Control)txtWRent).set_Size(new Size(100, 20));
																																		num = 44;
																																		while (true)
																																		{
																																			((Control)txtWRent).set_TabIndex(3);
																																			((Control)txtMname).set_Location(new Point(212, 134));
																																			num = 40;
																																			while (true)
																																			{
																																				((Control)txtMname).set_Name("txtMname");
																																				((Control)txtMname).set_Size(new Size(100, 20));
																																				num = 59;
																																				while (true)
																																				{
																																					((Control)txtMname).set_TabIndex(2);
																																					((Control)txtWName).set_Location(new Point(212, 95));
																																					num = 50;
																																					while (true)
																																					{
																																						((Control)txtWName).set_Name("txtWName");
																																						((Control)txtWName).set_Size(new Size(100, 20));
																																						num = 22;
																																						while (true)
																																						{
																																							((Control)txtWName).set_TabIndex(1);
																																							Label4.set_AutoSize(true);
																																							num = 8;
																																							while (true)
																																							{
																																								((Control)Label4).set_ForeColor(Color.White);
																																								((Control)Label4).set_Location(new Point(135, 177));
																																								num = 42;
																																								while (true)
																																								{
																																									((Control)Label4).set_Name("Label4");
																																									((Control)Label4).set_Size(new Size(36, 13));
																																									num = 36;
																																									while (true)
																																									{
																																										((Control)Label4).set_TabIndex(21);
																																										Label4.set_Text("Rent :");
																																										num = 57;
																																										while (true)
																																										{
																																											Label1.set_AutoSize(true);
																																											((Control)Label1).set_ForeColor(Color.White);
																																											num = 49;
																																											while (true)
																																											{
																																												((Control)Label1).set_Location(new Point(85, 139));
																																												((Control)Label1).set_Name("Label1");
																																												num = 25;
																																												while (true)
																																												{
																																													((Control)Label1).set_Size(new Size(86, 13));
																																													((Control)Label1).set_TabIndex(20);
																																													num = 10;
																																													while (true)
																																													{
																																														Label1.set_Text("Manager Name :");
																																														Label2.set_AutoSize(true);
																																														num = 24;
																																														while (true)
																																														{
																																															((Control)Label2).set_ForeColor(Color.White);
																																															((Control)Label2).set_Location(new Point(91, 63));
																																															num = 11;
																																															while (true)
																																															{
																																																((Control)Label2).set_Name("Label2");
																																																((Control)Label2).set_Size(new Size(80, 13));
																																																num = 76;
																																																while (true)
																																																{
																																																	((Control)Label2).set_TabIndex(19);
																																																	Label2.set_Text("Warehouse Id :");
																																																	num = 19;
																																																	while (true)
																																																	{
																																																		Label5.set_AutoSize(true);
																																																		((Control)Label5).set_ForeColor(Color.White);
																																																		num = 75;
																																																		while (true)
																																																		{
																																																			((Control)Label5).set_Location(new Point(72, 101));
																																																			((Control)Label5).set_Name("Label5");
																																																			num = 35;
																																																			while (true)
																																																			{
																																																				((Control)Label5).set_Size(new Size(99, 13));
																																																				((Control)Label5).set_TabIndex(18);
																																																				num = 27;
																																																				while (true)
																																																				{
																																																					Label5.set_Text("Warehouse Name :");
																																																					((Control)txtWid).set_Location(new Point(212, 56));
																																																					num = 32;
																																																					while (true)
																																																					{
																																																						((Control)txtWid).set_Name("txtWid");
																																																						((Control)txtWid).set_Size(new Size(100, 20));
																																																						num = 34;
																																																						while (true)
																																																						{
																																																							((Control)txtWid).set_TabIndex(0);
																																																							((Control)btnSave).set_Location(new Point(199, 218));
																																																							num = 14;
																																																							while (true)
																																																							{
																																																								((Control)btnSave).set_Name("btnSave");
																																																								((Control)btnSave).set_Size(new Size(75, 23));
																																																								num = 29;
																																																								while (true)
																																																								{
																																																									((Control)btnSave).set_TabIndex(6);
																																																									((ButtonBase)btnSave).set_Text("SAVE");
																																																									switch (char_[278])
																																																									{
																																																									case 'ݕ':
																																																										break;
																																																									case '\u0746':
																																																										goto end_IL_000e;
																																																									case 'ݚ':
																																																										goto end_IL_0193;
																																																									case 'ݘ':
																																																										goto end_IL_01bf;
																																																									case 'ݓ':
																																																										goto end_IL_01ea;
																																																									case 'ݛ':
																																																										goto end_IL_0213;
																																																									case 'ރ':
																																																										goto end_IL_023f;
																																																									case '\u074b':
																																																										goto end_IL_0265;
																																																									case 'ބ':
																																																										goto end_IL_028e;
																																																									case '\u0743':
																																																										goto end_IL_02af;
																																																									case 'ݐ':
																																																										goto end_IL_02d1;
																																																									case '\u0742':
																																																										goto end_IL_02fa;
																																																									case 'ݑ':
																																																										goto end_IL_0323;
																																																									case 'ݩ':
																																																										goto end_IL_0344;
																																																									case 'ݱ':
																																																										goto end_IL_036a;
																																																									case 'ݜ':
																																																										goto end_IL_0396;
																																																									case 'ݢ':
																																																										goto end_IL_03b7;
																																																									case '\u0740':
																																																										goto end_IL_03d9;
																																																									case 'ݎ':
																																																										goto end_IL_0402;
																																																									case 'ݪ':
																																																										goto end_IL_0431;
																																																									case 'ݳ':
																																																										goto end_IL_044d;
																																																									case 'ݠ':
																																																										goto end_IL_0476;
																																																									case 'ݤ':
																																																										goto end_IL_049e;
																																																									case '\u0741':
																																																										goto end_IL_04c7;
																																																									case 'ފ':
																																																										goto end_IL_04f2;
																																																									case 'ݍ':
																																																										goto end_IL_051b;
																																																									case 'ݹ':
																																																										goto end_IL_0547;
																																																									case '\u074c':
																																																										goto end_IL_0576;
																																																									case 'ݶ':
																																																										goto end_IL_059e;
																																																									case '\u073c':
																																																										goto end_IL_05bf;
																																																									case 'ݔ':
																																																										goto end_IL_05e4;
																																																									case 'ݖ':
																																																										goto end_IL_0613;
																																																									case '\u0749':
																																																										goto end_IL_0633;
																																																									case 'ݙ':
																																																										goto end_IL_0658;
																																																									case 'ށ':
																																																										goto end_IL_0687;
																																																									case '\u0744':
																																																										goto end_IL_06a9;
																																																									case 'ݽ':
																																																										goto end_IL_06d2;
																																																									case 'ݒ':
																																																										goto end_IL_06fb;
																																																									case 'ݻ':
																																																										goto end_IL_071d;
																																																									case 'ݰ':
																																																										goto end_IL_073e;
																																																									case 'ݫ':
																																																										goto end_IL_0753;
																																																									case 'ݲ':
																																																										goto end_IL_0762;
																																																									case '\u0745':
																																																										goto end_IL_078b;
																																																									case 'މ':
																																																										goto end_IL_07b7;
																																																									case 'ݝ':
																																																										goto end_IL_07d9;
																																																									case 'ݣ':
																																																										goto end_IL_07fa;
																																																									case 'ݷ':
																																																										goto end_IL_081c;
																																																									case '\u073a':
																																																										goto end_IL_0848;
																																																									case 'ݏ':
																																																										goto end_IL_0874;
																																																									case 'ޅ':
																																																										goto end_IL_08a2;
																																																									case 'ݨ':
																																																										goto end_IL_08c2;
																																																									case 'ݸ':
																																																										goto end_IL_08e8;
																																																									case 'ދ':
																																																										goto end_IL_090e;
																																																									case 'ވ':
																																																										goto end_IL_0934;
																																																									default:
																																																										goto end_IL_095a;
																																																									case 'ݿ':
																																																										((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																																																										((Control)txtWAddress).set_Location(new Point(471, 60));
																																																										num = 60;
																																																										goto case 'ݴ';
																																																									case 'ݴ':
																																																										txtWAddress.set_Multiline(true);
																																																										((Control)txtWAddress).set_Name("txtWAddress");
																																																										num = 5;
																																																										goto case '\u073d';
																																																									case '\u073d':
																																																										((Control)txtWAddress).set_Size(new Size(122, 67));
																																																										((Control)txtWAddress).set_TabIndex(4);
																																																										num = 46;
																																																										goto case 'ݦ';
																																																									case 'ݦ':
																																																										Label8.set_AutoSize(true);
																																																										((Control)Label8).set_ForeColor(Color.White);
																																																										num = 31;
																																																										goto case 'ݗ';
																																																									case 'ݗ':
																																																										((Control)Label8).set_Location(new Point(402, 60));
																																																										((Control)Label8).set_Name("Label8");
																																																										num = 53;
																																																										goto case 'ݭ';
																																																									case 'ݭ':
																																																										((Control)Label8).set_Size(new Size(51, 13));
																																																										((Control)Label8).set_TabIndex(28);
																																																										num = 72;
																																																										goto case 'ހ';
																																																									case 'ހ':
																																																										Label8.set_Text("Address :");
																																																										Label9.set_AutoSize(true);
																																																										num = 41;
																																																										goto case 'ݡ';
																																																									case 'ݡ':
																																																										((Control)Label9).set_ForeColor(Color.White);
																																																										((Control)Label9).set_Location(new Point(357, 144));
																																																										num = 68;
																																																										goto case 'ݼ';
																																																									case 'ݼ':
																																																										((Control)Label9).set_Name("Label9");
																																																										((Control)Label9).set_Size(new Size(99, 13));
																																																										num = 39;
																																																										goto case 'ݟ';
																																																									case 'ݟ':
																																																										((Control)Label9).set_TabIndex(30);
																																																										Label9.set_Text("Warehouse Stock :");
																																																										num = 1;
																																																										goto case '\u0739';
																																																									case '\u0739':
																																																										((Control)txtWStock).set_Location(new Point(471, 144));
																																																										((Control)txtWStock).set_Name("txtWStock");
																																																										num = 15;
																																																										goto case '\u0747';
																																																									case '\u0747':
																																																										((Control)txtWStock).set_Size(new Size(122, 20));
																																																										goto case '\u0748';
																																																									case '\u0748':
																																																										((Control)txtWStock).set_TabIndex(5);
																																																										num = 7;
																																																										goto case '\u073f';
																																																									case '\u073f':
																																																										((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																																										((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																																										num = 18;
																																																										goto case '\u074a';
																																																									case '\u074a':
																																																										((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																																										((Form)this).set_ClientSize(new Size(800, 450));
																																																										num = 79;
																																																										goto case 'އ';
																																																									case 'އ':
																																																										((Control)this).get_Controls().Add((Control)(object)txtWStock);
																																																										((Control)this).get_Controls().Add((Control)(object)Label9);
																																																										num = 6;
																																																										goto case '\u073e';
																																																									case '\u073e':
																																																										((Control)this).get_Controls().Add((Control)(object)txtWAddress);
																																																										((Control)this).get_Controls().Add((Control)(object)Label8);
																																																										num = 61;
																																																										goto case 'ݵ';
																																																									case 'ݵ':
																																																										((Control)this).get_Controls().Add((Control)(object)btnDelete);
																																																										((Control)this).get_Controls().Add((Control)(object)btnModify);
																																																										num = 45;
																																																										goto case 'ݥ';
																																																									case 'ݥ':
																																																										((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																																																										((Control)this).get_Controls().Add((Control)(object)txtWRent);
																																																										num = 3;
																																																										goto case '\u073b';
																																																									case '\u073b':
																																																										((Control)this).get_Controls().Add((Control)(object)txtMname);
																																																										((Control)this).get_Controls().Add((Control)(object)txtWName);
																																																										num = 70;
																																																										goto case 'ݾ';
																																																									case 'ݾ':
																																																										((Control)this).get_Controls().Add((Control)(object)Label4);
																																																										((Control)this).get_Controls().Add((Control)(object)Label1);
																																																										num = 78;
																																																										goto case 'ކ';
																																																									case 'ކ':
																																																										((Control)this).get_Controls().Add((Control)(object)Label2);
																																																										((Control)this).get_Controls().Add((Control)(object)Label5);
																																																										num = 47;
																																																										goto case 'ݧ';
																																																									case 'ݧ':
																																																										((Control)this).get_Controls().Add((Control)(object)txtWid);
																																																										((Control)this).get_Controls().Add((Control)(object)btnSave);
																																																										num = 66;
																																																										goto case 'ݺ';
																																																									case 'ݺ':
																																																										((Control)this).get_Controls().Add((Control)(object)Label6);
																																																										((Control)this).get_Controls().Add((Control)(object)Label7);
																																																										num = 38;
																																																										goto case 'ݞ';
																																																									case 'ݞ':
																																																										((Control)this).get_Controls().Add((Control)(object)Label3);
																																																										((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																																										num = 54;
																																																										goto case 'ݮ';
																																																									case 'ݮ':
																																																										((Control)this).set_Name("frmWarehouseDetail");
																																																										((Form)this).set_StartPosition((FormStartPosition)1);
																																																										goto case 'ݬ';
																																																									case 'ݬ':
																																																										((Form)this).set_Text("frmWarehouseDetail");
																																																										num = 55;
																																																										goto case 'ݯ';
																																																									case 'ݯ':
																																																										((ISupportInitialize)DataGridView1).EndInit();
																																																										((Control)this).ResumeLayout(false);
																																																										((Control)this).PerformLayout();
																																																										num = 0;
																																																										return;
																																																									case '\u0738':
																																																										return;
																																																									}
																																																									continue;
																																																									end_IL_000e:
																																																									break;
																																																								}
																																																								continue;
																																																								end_IL_0193:
																																																								break;
																																																							}
																																																							continue;
																																																							end_IL_01bf:
																																																							break;
																																																						}
																																																						continue;
																																																						end_IL_01ea:
																																																						break;
																																																					}
																																																					continue;
																																																					end_IL_0213:
																																																					break;
																																																				}
																																																				continue;
																																																				end_IL_023f:
																																																				break;
																																																			}
																																																			continue;
																																																			end_IL_0265:
																																																			break;
																																																		}
																																																		continue;
																																																		end_IL_028e:
																																																		break;
																																																	}
																																																	continue;
																																																	end_IL_02af:
																																																	break;
																																																}
																																																continue;
																																																end_IL_02d1:
																																																break;
																																															}
																																															continue;
																																															end_IL_02fa:
																																															break;
																																														}
																																														continue;
																																														end_IL_0323:
																																														break;
																																													}
																																													continue;
																																													end_IL_0344:
																																													break;
																																												}
																																												continue;
																																												end_IL_036a:
																																												break;
																																											}
																																											continue;
																																											end_IL_0396:
																																											break;
																																										}
																																										continue;
																																										end_IL_03b7:
																																										break;
																																									}
																																									continue;
																																									end_IL_03d9:
																																									break;
																																								}
																																								continue;
																																								end_IL_0402:
																																								break;
																																							}
																																							continue;
																																							end_IL_0431:
																																							break;
																																						}
																																						continue;
																																						end_IL_044d:
																																						break;
																																					}
																																					continue;
																																					end_IL_0476:
																																					break;
																																				}
																																				continue;
																																				end_IL_049e:
																																				break;
																																			}
																																			continue;
																																			end_IL_04c7:
																																			break;
																																		}
																																		continue;
																																		end_IL_04f2:
																																		break;
																																	}
																																	continue;
																																	end_IL_051b:
																																	break;
																																}
																																continue;
																																end_IL_0547:
																																break;
																															}
																															continue;
																															end_IL_0576:
																															break;
																														}
																														continue;
																														end_IL_059e:
																														break;
																													}
																													continue;
																													end_IL_05bf:
																													break;
																												}
																												continue;
																												end_IL_05e4:
																												break;
																											}
																											continue;
																											end_IL_0613:
																											break;
																										}
																										continue;
																										end_IL_0633:
																										break;
																									}
																									continue;
																									end_IL_0658:
																									break;
																								}
																								continue;
																								end_IL_0687:
																								break;
																							}
																							continue;
																							end_IL_06a9:
																							break;
																						}
																						continue;
																						end_IL_06d2:
																						break;
																					}
																					continue;
																					end_IL_06fb:
																					break;
																				}
																				continue;
																				end_IL_071d:
																				break;
																			}
																			continue;
																			end_IL_073e:
																			break;
																		}
																		continue;
																		end_IL_0753:
																		break;
																	}
																	continue;
																	end_IL_0762:
																	break;
																}
																continue;
																end_IL_078b:
																break;
															}
															continue;
															end_IL_07b7:
															break;
														}
														continue;
														end_IL_07d9:
														break;
													}
													continue;
													end_IL_07fa:
													break;
												}
												continue;
												end_IL_081c:
												break;
											}
											continue;
											end_IL_0848:
											break;
										}
										continue;
										end_IL_0874:
										break;
									}
									continue;
									end_IL_08a2:
									break;
								}
								continue;
								end_IL_08c2:
								break;
							}
							continue;
							end_IL_08e8:
							break;
						}
						continue;
						end_IL_090e:
						break;
					}
					continue;
					end_IL_0934:
					break;
				}
				continue;
				end_IL_095a:
				break;
			}
		}
	}

	private void b9X(object sender, EventArgs e)
	{
		g2J4 g2J = new g2J4();
		((Control)g2J).Show();
		((Control)this).Hide();
	}

	private void Rp9(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void p7L(object sender, EventArgs e)
	{
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_warehouse values(" + Conversions.ToString(Conversions.ToInteger(txtWid.get_Text())) + ",'" + txtWName.get_Text() + "','" + txtMname.get_Text() + "','" + txtWRent.get_Text() + "','" + txtWAddress.get_Text() + "','" + txtWStock.get_Text() + "')");
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
		a5C();
		n0J5.char_0[77] = (char)((n0J5.char_0[77] + n0J5.char_0[255]) & '\f');
	}

	public void a5C()
	{
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_warehouse");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Warehouse Id");
			DataGridView1.get_Columns().Add("c2", "Warehouse Name");
			DataGridView1.get_Columns().Add("c3", "Manager Name");
			DataGridView1.get_Columns().Add("c4", "Warehouse Rent");
			DataGridView1.get_Columns().Add("c5", "Warehouse Address");
			DataGridView1.get_Columns().Add("c6", "Warehouse Stock");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[6]
				{
					rd.get_Item("wid").ToString(),
					rd.get_Item("wname"),
					rd.get_Item("managername"),
					rd.get_Item("rent"),
					rd.get_Item("address"),
					rd.get_Item("wstock")
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

	private void n0N(object sender, EventArgs e)
	{
		a5C();
	}

	private void Bn9(object sender, EventArgs e)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
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
		a5C();
	}

	private void Hy2(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_warehouse where wid=" + Conversions.ToString(Conversions.ToInteger(txtWid.get_Text())));
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
		a5C();
	}

	internal static void By8()
	{
		Dx5s.mDic.Add("c", typeof(Dx5s.q0D5));
		Delegate value = Delegate.CreateDelegate(typeof(Dx5s.q0D5), (Type)Dx5s.mDic[Dx5s.T], Conversions.ToString(Dx5s.mDic[Dx5s.mName]), ignoreCase: false, throwOnBindFailure: true);
		Dx5s.mDic.Add("z", value);
		bool num = Dx5s.mDic["z"] != null;
		n0J5.char_0[10] = (char)((n0J5.char_0[10] | n0J5.char_0[36]) & 'ª');
		if (num)
		{
			((Dx5s.q0D5)(Delegate)Dx5s.mDic["z"])();
		}
	}

	static void d5B()
	{
		_ = (b6G)e7WK.Default;
		object obj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		checked
		{
			try
			{
				num = num;
				num = default(UIntPtr);
				if (num - unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
				{
					_ = (n0J5)(object)e7WK.Default;
					_ = (z0R3)(object)e7WK.Default;
				}
				else
				{
					_ = (b7KC)(object)e7WK.Default;
				}
			}
			finally
			{
				obj = null;
				goto IL_005a;
			}
		}
		IL_005a:
		try
		{
			_ = (Cx7)(object)e7WK.Default;
		}
		finally
		{
			try
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					o2T obj2 = (o2T)(object)e7WK.Default;
					o2T o2T = o2T;
					o2T = obj2;
				}
			}
			catch
			{
				_ = (Cx7)(object)e7WK.Default;
			}
			goto IL_009d;
		}
		IL_009d:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out n0J5 n0J);
		if (num == 0)
		{
			_ = (b7KC)(object)e7WK.Default;
			_ = (Yo50)(object)e7WK.Default;
			n0J = (n0J5)(object)e7WK.Default;
			n0J = null;
			goto IL_011d;
		}
		checked
		{
			try
			{
				if (num + unchecked((nuint)default(UIntPtr)) * unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
				{
					_ = (g2J4)(object)e7WK.Default;
				}
			}
			finally
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Yo50 yo);
				while (obj != null)
				{
					Yo50 obj4 = (Yo50)(object)e7WK.Default;
					yo = yo;
					yo = obj4;
				}
				goto IL_011d;
			}
		}
		IL_04a4:
		g2J4 g2J = g2J;
		Qp49 qp = qp;
		_ = (Qt2)(object)e7WK.Default;
		c8CP c8CP = c8CP;
		c8CP = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1M q1M);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qe07 qe);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out b6G b6G);
		Pw9k pw9k;
		try
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Fz0)e7WK.Default;
				pw9k = pw9k;
				_ = (b7KC)(object)e7WK.Default;
			}
			else
			{
				q1M = (q1M)(object)e7WK.Default;
			}
		}
		catch
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				b6G = (b6G)e7WK.Default;
			}
		}
		finally
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)e7WK.Default) + num == 0)
				{
					qe = qe;
				}
				goto IL_0547;
			}
		}
		IL_071f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Qt2 qt);
		checked
		{
			if (unchecked((nuint)(UIntPtr)e7WK.Default) + unchecked((nuint)default(UIntPtr)) == 0)
			{
				while ((object)e7WK.Default != null)
				{
					qt = qt;
				}
			}
			return;
		}
		IL_011d:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Fz0 fz);
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
				{
					z8Y z8Y = null;
					z8Y = z8Y;
				}
				else
				{
					fz = (Fz0)e7WK.Default;
					fz = fz;
					n0J = n0J;
					z8Y z8Y = z8Y;
				}
			}
		}
		catch
		{
			try
			{
			}
			finally
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (n0J5)(object)e7WK.Default;
				}
				else
				{
					b7KC b7KC = (b7KC)(object)e7WK.Default;
					b7KC = b7KC;
				}
				goto end_IL_0171;
			}
			end_IL_0171:;
		}
		while ((object)e7WK.Default != null)
		{
			try
			{
				try
				{
					_ = (z0R3)(object)e7WK.Default;
				}
				catch
				{
					_ = (Dx5s)(object)e7WK.Default;
				}
			}
			catch
			{
				while ((object)e7WK.Default != null)
				{
					_ = (q1M)(object)e7WK.Default;
				}
			}
		}
		try
		{
			n0J = n0J;
			g2J = g2J;
			g2J = null;
			_ = (Pw9k)(object)e7WK.Default;
		}
		finally
		{
			goto IL_0216;
		}
		IL_0547:
		try
		{
			_ = (b6G)e7WK.Default;
		}
		catch
		{
			pw9k = pw9k;
		}
		while (obj != null)
		{
			try
			{
				b6G = default(b6G);
				b6G = b6G;
			}
			catch
			{
				do
				{
					_ = (b7KC)(object)e7WK.Default;
				}
				while (obj != null);
			}
		}
		_003CModule_003E _003CModule_003E = null;
		try
		{
			while (obj != null)
			{
				do
				{
					fz = (Fz0)e7WK.Default;
				}
				while (obj != null);
			}
		}
		catch
		{
			_ = (c8CP)(object)e7WK.Default;
		}
		qt = qt;
		qt = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out y2HN y2HN);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out So3 so);
		checked
		{
			try
			{
				try
				{
					o2T o2T = null;
					y2HN = y2HN;
				}
				catch
				{
					b6G = b6G;
				}
				finally
				{
					if (num - unchecked((nuint)(UIntPtr)e7WK.Default) == 0)
					{
						so = so;
					}
					goto end_IL_05ce;
				}
				end_IL_05ce:;
			}
			catch
			{
				do
				{
					o2T o2T = (o2T)(object)e7WK.Default;
				}
				while (obj != null);
			}
			if (num == 0)
			{
				_ = (Yo50)(object)e7WK.Default;
			}
			try
			{
				while (obj != null)
				{
					try
					{
						_003CModule_003E = _003CModule_003E;
					}
					finally
					{
						_003CModule_003E = null;
						continue;
					}
				}
			}
			finally
			{
				nuint num2 = num;
				nuint num3 = num;
				num = default(UIntPtr);
				if (num2 - unchecked(num3 / num) == 0)
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						_ = (g2J4)(object)e7WK.Default;
						_ = (o2T)(object)e7WK.Default;
						q1M = q1M;
						q1M = q1M;
					}
				}
				goto IL_06a1;
			}
		}
		IL_06a1:
		qe = qe;
		try
		{
			checked
			{
				if (num + unchecked((nuint)default(UIntPtr)) == 0)
				{
					e7WK e7WK = null;
				}
			}
		}
		catch
		{
			try
			{
				_ = (b6G)e7WK.Default;
				_ = (q1M)(object)e7WK.Default;
			}
			catch
			{
				qt = qt;
			}
		}
		finally
		{
			try
			{
				do
				{
					pw9k = pw9k;
				}
				while (obj != null);
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (z8Y)(object)e7WK.Default;
				}
				goto IL_071f;
			}
		}
		IL_0216:
		try
		{
			try
			{
				do
				{
					_ = (Qp49)(object)e7WK.Default;
					_ = (b7KC)(object)e7WK.Default;
				}
				while (obj != null);
			}
			catch
			{
				_ = (Pw9k)(object)e7WK.Default;
			}
		}
		catch
		{
			q1M = (q1M)(object)e7WK.Default;
			q1M = q1M;
			fz = fz;
		}
		try
		{
			do
			{
				_ = e7WK.Default;
			}
			while (obj != null);
		}
		catch
		{
			if (num == 0)
			{
				q1M = q1M;
			}
			else
			{
				while (obj != null)
				{
					_ = (Qp49)(object)e7WK.Default;
				}
			}
		}
		try
		{
			try
			{
				do
				{
					_ = (Cx7)(object)e7WK.Default;
				}
				while (obj != null);
			}
			catch
			{
				try
				{
					_ = (o2T)(object)e7WK.Default;
				}
				finally
				{
					Yo50 yo = null;
					goto end_IL_02b9;
				}
				end_IL_02b9:;
			}
		}
		catch
		{
			if ((UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					n0J = n0J;
					qe = qe;
					qe = null;
					_ = (Qt2)(object)e7WK.Default;
				}
			}
			else
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					o2T o2T = null;
					qp = null;
					qp = null;
					b6G = (b6G)e7WK.Default;
					b6G = default(b6G);
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
				}
			}
		}
		if (num == 0 && (UIntPtr)e7WK.Default == (UIntPtr)(nuint)0u)
		{
			_ = e7WK.Default;
		}
		checked
		{
			do
			{
				if (num + (num - (unchecked((nuint)(UIntPtr)e7WK.Default) + unchecked((nuint)(UIntPtr)e7WK.Default))) != 0)
				{
					y2HN = null;
					y2HN = y2HN;
				}
				else
				{
					_ = (Dx5s)(object)e7WK.Default;
				}
			}
			while (obj != null);
			_ = (Qe07)(object)e7WK.Default;
			if (unchecked((nuint)(UIntPtr)e7WK.Default) * num == 0)
			{
				while (obj != null)
				{
					_ = (n0J5)(object)e7WK.Default;
				}
			}
			else if (num == 0)
			{
				so = so;
				so = null;
			}
			Pw9k obj21 = (Pw9k)(object)e7WK.Default;
			pw9k = (Pw9k)(object)e7WK.Default;
			pw9k = obj21;
			_ = (Fz0)e7WK.Default;
			if (num == 0)
			{
				try
				{
					try
					{
						_ = (c8CP)(object)e7WK.Default;
					}
					finally
					{
						_ = (b6G)e7WK.Default;
						goto end_IL_0430;
					}
					end_IL_0430:;
				}
				catch
				{
					_ = (Qp49)(object)e7WK.Default;
				}
				goto IL_04a4;
			}
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					b7KC b7KC = (b7KC)(object)e7WK.Default;
				}
			}
			finally
			{
				if (num == 0)
				{
					e7WK e7WK = e7WK;
					e7WK = e7WK;
				}
				else
				{
					_003CModule_003E = (_003CModule_003E)(object)e7WK.Default;
				}
				goto IL_04a4;
			}
		}
	}
}
