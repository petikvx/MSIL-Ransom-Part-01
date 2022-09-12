using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bm4r;
using Cr4;
using Ds3;
using Jo7k;
using Kc9;
using Lo03;
using Microsoft.VisualBasic.CompilerServices;
using Na4o;
using Sd9;
using Ti18;
using Wf0t;
using Yf06;
using Yn19;
using Yn6o;
using b3YP;
using c9S;
using i1QX;
using i9XQ;
using k2CM;
using k3R;

namespace q9Z2;

[DesignerGenerated]
public class q1C3 : Form
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
			EventHandler eventHandler = r8P1;
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
			EventHandler eventHandler = Aw7n;
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

	[field: AccessedThroughProperty("txtSRcode")]
	internal virtual TextBox txtSRcode
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

	[field: AccessedThroughProperty("Label9")]
	internal virtual Label Label9
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSRName")]
	internal virtual TextBox txtSRName
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

	[field: AccessedThroughProperty("txtSCode")]
	internal virtual TextBox txtSCode
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
			char[] char_ = o1W.char_0;
			int num = 2;
			while (true)
			{
				EventHandler eventHandler = Wq1y;
				Button val = _btnDelete;
				while (true)
				{
					if (val != null)
					{
						char num2 = char_[387];
						o1W.char_0[268] = (char)((o1W.char_0[268] ^ s5C.int_0[136]) & '²');
						switch (num2 - 5040)
						{
						case 3:
							break;
						default:
							goto end_IL_006a;
						case 4:
						case 5:
							((Control)val).remove_Click(eventHandler);
							goto IL_0090;
						case 7:
							goto IL_0090;
						case 1:
							goto IL_00a3;
						case 6:
							return;
						}
						continue;
					}
					num = 7;
					goto IL_0090;
					IL_0090:
					_btnDelete = value;
					val = _btnDelete;
					if (val != null)
					{
						num = 1;
						goto IL_00a3;
					}
					num = 6;
					return;
					IL_00a3:
					((Control)val).add_Click(eventHandler);
					return;
					continue;
					end_IL_006a:
					break;
				}
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
			EventHandler eventHandler = Kg4r;
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

	[field: AccessedThroughProperty("txtSEmail")]
	internal virtual TextBox txtSEmail
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSName")]
	internal virtual TextBox txtSName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtSRAmount")]
	internal virtual TextBox txtSRAmount
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
			EventHandler eventHandler = Pb91;
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

	[field: AccessedThroughProperty("txtSphoneno")]
	internal virtual TextBox txtSphoneno
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

	public q1C3()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)x3S7);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Fz13();
	}

	[DebuggerNonUserCode]
	protected override void Jz21(bool Jt0k)
	{
		try
		{
			if (Jt0k && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Jt0k);
		}
	}

	[DebuggerStepThrough]
	private void Fz13()
	{
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0939: Expected O, but got Unknown
		//IL_09e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f2: Expected O, but got Unknown
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aac: Expected O, but got Unknown
		//IL_0ad6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae0: Expected O, but got Unknown
		//IL_0ae1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aeb: Expected O, but got Unknown
		//IL_0aec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af6: Expected O, but got Unknown
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b06: Expected O, but got Unknown
		//IL_0b07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b11: Expected O, but got Unknown
		//IL_0b12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1c: Expected O, but got Unknown
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2c: Expected O, but got Unknown
		//IL_0b2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b37: Expected O, but got Unknown
		//IL_0b38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b42: Expected O, but got Unknown
		//IL_0b48: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b52: Expected O, but got Unknown
		//IL_0b53: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5d: Expected O, but got Unknown
		//IL_0b5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b68: Expected O, but got Unknown
		//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b78: Expected O, but got Unknown
		//IL_0b79: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b83: Expected O, but got Unknown
		//IL_0b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8e: Expected O, but got Unknown
		//IL_0b94: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9e: Expected O, but got Unknown
		//IL_0b9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba9: Expected O, but got Unknown
		//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb4: Expected O, but got Unknown
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc4: Expected O, but got Unknown
		//IL_0bc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcf: Expected O, but got Unknown
		//IL_0bd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bda: Expected O, but got Unknown
		char[] char_ = o1W.char_0;
		int num = 23;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 21;
			while (true)
			{
				txtSRcode = new TextBox();
				Label10 = new Label();
				DataGridView1 = new DataGridView();
				num = 35;
				while (true)
				{
					Label9 = new Label();
					txtSRName = new TextBox();
					Label8 = new Label();
					num = 27;
					while (true)
					{
						Label5 = new Label();
						Label4 = new Label();
						txtSCode = new TextBox();
						num = 79;
						while (true)
						{
							btnDelete = new Button();
							btnModify = new Button();
							txtSEmail = new TextBox();
							num = 44;
							while (true)
							{
								txtSName = new TextBox();
								txtSRAmount = new TextBox();
								Label2 = new Label();
								num = 86;
								while (true)
								{
									btnSave = new Button();
									txtSphoneno = new TextBox();
									Label1 = new Label();
									num = 83;
									while (true)
									{
										((ISupportInitialize)DataGridView1).BeginInit();
										while (true)
										{
											((Control)this).SuspendLayout();
											Label3.set_AutoSize(true);
											num = 65;
											while (true)
											{
												((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
												num = 33;
												while (true)
												{
													((Control)Label3).set_ForeColor(Color.White);
													((Control)Label3).set_Location(new Point(336, 29));
													num = 48;
													while (true)
													{
														((Control)Label3).set_Name("Label3");
														((Control)Label3).set_Size(new Size(115, 17));
														num = 30;
														while (true)
														{
															((Control)Label3).set_TabIndex(9);
															Label3.set_Text("Supplier Detail");
															num = 55;
															while (true)
															{
																Label6.set_AutoSize(true);
																((Control)Label6).set_BackColor(Color.Blue);
																num = 24;
																while (true)
																{
																	((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																	num = 59;
																	while (true)
																	{
																		((Control)Label6).set_ForeColor(Color.White);
																		((Control)Label6).set_Location(new Point(721, 29));
																		num = 12;
																		while (true)
																		{
																			((Control)Label6).set_Name("Label6");
																			((Control)Label6).set_Size(new Size(18, 17));
																			num = 74;
																			while (true)
																			{
																				((Control)Label6).set_TabIndex(11);
																				Label6.set_Text("X");
																				num = 29;
																				while (true)
																				{
																					Label7.set_AutoSize(true);
																					((Control)Label7).set_BackColor(Color.Blue);
																					num = 66;
																					while (true)
																					{
																						((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																						num = 6;
																						while (true)
																						{
																							((Control)Label7).set_ForeColor(Color.White);
																							((Control)Label7).set_Location(new Point(29, 29));
																							num = 88;
																							while (true)
																							{
																								((Control)Label7).set_Name("Label7");
																								((Control)Label7).set_Size(new Size(92, 17));
																								num = 73;
																								while (true)
																								{
																									((Control)Label7).set_TabIndex(10);
																									Label7.set_Text("Go To Main");
																									num = 54;
																									while (true)
																									{
																										((Control)txtSRcode).set_Location(new Point(504, 151));
																										((Control)txtSRcode).set_Name("txtSRcode");
																										num = 34;
																										while (true)
																										{
																											((Control)txtSRcode).set_Size(new Size(100, 20));
																											((Control)txtSRcode).set_TabIndex(6);
																											num = 13;
																											while (true)
																											{
																												Label10.set_AutoSize(true);
																												((Control)Label10).set_ForeColor(Color.White);
																												num = 68;
																												while (true)
																												{
																													((Control)Label10).set_Location(new Point(428, 157));
																													((Control)Label10).set_Name("Label10");
																													num = 22;
																													while (true)
																													{
																														((Control)Label10).set_Size(new Size(60, 13));
																														((Control)Label10).set_TabIndex(99);
																														num = 1;
																														while (true)
																														{
																															Label10.set_Text("Raw Code:");
																															DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																															num = 41;
																															while (true)
																															{
																																((Control)DataGridView1).set_Location(new Point(32, 239));
																																((Control)DataGridView1).set_Name("DataGridView1");
																																num = 51;
																																while (true)
																																{
																																	((Control)DataGridView1).set_Size(new Size(724, 199));
																																	((Control)DataGridView1).set_TabIndex(11);
																																	num = 62;
																																	while (true)
																																	{
																																		Label9.set_AutoSize(true);
																																		((Control)Label9).set_ForeColor(Color.White);
																																		num = 38;
																																		while (true)
																																		{
																																			((Control)Label9).set_Location(new Point(422, 95));
																																			((Control)Label9).set_Name("Label9");
																																			num = 69;
																																			while (true)
																																			{
																																				((Control)Label9).set_Size(new Size(66, 13));
																																				((Control)Label9).set_TabIndex(96);
																																				num = 10;
																																				while (true)
																																				{
																																					Label9.set_Text("Raw Name :");
																																					((Control)txtSRName).set_Location(new Point(504, 88));
																																					num = 28;
																																					while (true)
																																					{
																																						((Control)txtSRName).set_Name("txtSRName");
																																						((Control)txtSRName).set_Size(new Size(100, 20));
																																						num = 87;
																																						while (true)
																																						{
																																							((Control)txtSRName).set_TabIndex(4);
																																							Label8.set_AutoSize(true);
																																							num = 4;
																																							while (true)
																																							{
																																								((Control)Label8).set_ForeColor(Color.White);
																																								((Control)Label8).set_Location(new Point(164, 182));
																																								num = 84;
																																								while (true)
																																								{
																																									((Control)Label8).set_Name("Label8");
																																									((Control)Label8).set_Size(new Size(50, 13));
																																									num = 64;
																																									while (true)
																																									{
																																										((Control)Label8).set_TabIndex(94);
																																										Label8.set_Text("Email Id :");
																																										num = 43;
																																										while (true)
																																										{
																																											Label5.set_AutoSize(true);
																																											((Control)Label5).set_ForeColor(Color.White);
																																											num = 8;
																																											while (true)
																																											{
																																												((Control)Label5).set_Location(new Point(134, 122));
																																												((Control)Label5).set_Name("Label5");
																																												while (true)
																																												{
																																													num = 71;
																																													while (true)
																																													{
																																														((Control)Label5).set_Size(new Size(82, 13));
																																														((Control)Label5).set_TabIndex(93);
																																														num = 82;
																																														while (true)
																																														{
																																															Label5.set_Text("Supplier Name :");
																																															Label4.set_AutoSize(true);
																																															num = 85;
																																															while (true)
																																															{
																																																((Control)Label4).set_ForeColor(Color.White);
																																																((Control)Label4).set_Location(new Point(414, 127));
																																																num = 11;
																																																while (true)
																																																{
																																																	((Control)Label4).set_Name("Label4");
																																																	((Control)Label4).set_Size(new Size(74, 13));
																																																	num = 26;
																																																	while (true)
																																																	{
																																																		((Control)Label4).set_TabIndex(92);
																																																		Label4.set_Text("Raw Amount :");
																																																		num = 17;
																																																		while (true)
																																																		{
																																																			((Control)txtSCode).set_Location(new Point(241, 85));
																																																			((Control)txtSCode).set_Name("txtSCode");
																																																			num = 76;
																																																			while (true)
																																																			{
																																																				((Control)txtSCode).set_Size(new Size(100, 20));
																																																				((Control)txtSCode).set_TabIndex(0);
																																																				num = 72;
																																																				while (true)
																																																				{
																																																					((Control)btnDelete).set_Location(new Point(483, 202));
																																																					((Control)btnDelete).set_Name("btnDelete");
																																																					num = 60;
																																																					while (true)
																																																					{
																																																						((Control)btnDelete).set_Size(new Size(75, 31));
																																																						((Control)btnDelete).set_TabIndex(9);
																																																						num = 37;
																																																						while (true)
																																																						{
																																																							((ButtonBase)btnDelete).set_Text("DELETE");
																																																							((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																																																							num = 45;
																																																							while (true)
																																																							{
																																																								((Control)btnModify).set_Location(new Point(365, 202));
																																																								((Control)btnModify).set_Name("btnModify");
																																																								num = 81;
																																																								while (true)
																																																								{
																																																									((Control)btnModify).set_Size(new Size(75, 31));
																																																									((Control)btnModify).set_TabIndex(8);
																																																									num = 63;
																																																									while (true)
																																																									{
																																																										((ButtonBase)btnModify).set_Text("MODIFY");
																																																										((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																																																										num = 32;
																																																										while (true)
																																																										{
																																																											((Control)txtSEmail).set_Location(new Point(241, 176));
																																																											((Control)txtSEmail).set_Name("txtSEmail");
																																																											num = 2;
																																																											while (true)
																																																											{
																																																												((Control)txtSEmail).set_Size(new Size(100, 20));
																																																												((Control)txtSEmail).set_TabIndex(3);
																																																												num = 50;
																																																												while (true)
																																																												{
																																																													((Control)txtSName).set_Location(new Point(239, 115));
																																																													((Control)txtSName).set_Name("txtSName");
																																																													num = 70;
																																																													while (true)
																																																													{
																																																														((Control)txtSName).set_Size(new Size(100, 20));
																																																														((Control)txtSName).set_TabIndex(1);
																																																														num = 53;
																																																														while (true)
																																																														{
																																																															((Control)txtSRAmount).set_Location(new Point(504, 122));
																																																															((Control)txtSRAmount).set_Name("txtSRAmount");
																																																															num = 5;
																																																															while (true)
																																																															{
																																																																((Control)txtSRAmount).set_Size(new Size(100, 20));
																																																																((Control)txtSRAmount).set_TabIndex(5);
																																																																num = 25;
																																																																while (true)
																																																																{
																																																																	Label2.set_AutoSize(true);
																																																																	((Control)Label2).set_ForeColor(Color.White);
																																																																	num = 47;
																																																																	while (true)
																																																																	{
																																																																		((Control)Label2).set_Location(new Point(138, 88));
																																																																		((Control)Label2).set_Name("Label2");
																																																																		num = 0;
																																																																		while (true)
																																																																		{
																																																																			((Control)Label2).set_Size(new Size(79, 13));
																																																																			((Control)Label2).set_TabIndex(90);
																																																																			num = 20;
																																																																			while (true)
																																																																			{
																																																																				Label2.set_Text("Supplier Code :");
																																																																				((Control)btnSave).set_Location(new Point(236, 202));
																																																																				num = 9;
																																																																				while (true)
																																																																				{
																																																																					((Control)btnSave).set_Name("btnSave");
																																																																					((Control)btnSave).set_Size(new Size(75, 31));
																																																																					num = 3;
																																																																					while (true)
																																																																					{
																																																																						((Control)btnSave).set_TabIndex(7);
																																																																						((ButtonBase)btnSave).set_Text("SAVE");
																																																																						num = 42;
																																																																						while (true)
																																																																						{
																																																																							((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																																																																							((Control)txtSphoneno).set_Location(new Point(239, 150));
																																																																							num = 78;
																																																																							while (true)
																																																																							{
																																																																								((Control)txtSphoneno).set_Name("txtSphoneno");
																																																																								((Control)txtSphoneno).set_Size(new Size(100, 20));
																																																																								switch (char_[36])
																																																																								{
																																																																								case '\uf4cf':
																																																																									break;
																																																																								case '\uf4ab':
																																																																									goto end_IL_000e;
																																																																								case '\uf484':
																																																																									goto end_IL_01b4;
																																																																								case '\uf48a':
																																																																									goto end_IL_01e2;
																																																																								case '\uf495':
																																																																									goto end_IL_0203;
																																																																								case '\uf481':
																																																																									goto end_IL_022b;
																																																																								case '\uf4b0':
																																																																									goto end_IL_025a;
																																																																								case '\uf49a':
																																																																									goto end_IL_0280;
																																																																								case '\uf486':
																																																																									goto end_IL_02ab;
																																																																								case '\uf4b6':
																																																																									goto end_IL_02cc;
																																																																								case '\uf4c7':
																																																																									goto end_IL_02f1;
																																																																								case '\uf4b3':
																																																																									goto end_IL_031c;
																																																																								case '\uf483':
																																																																									goto end_IL_0341;
																																																																								case '\uf4a1':
																																																																									goto end_IL_036d;
																																																																								case '\uf4c0':
																																																																									goto end_IL_0392;
																																																																								case '\uf4d2':
																																																																									goto end_IL_03c0;
																																																																								case '\uf4ae':
																																																																									goto end_IL_03e1;
																																																																								case '\uf4a6':
																																																																									goto end_IL_0406;
																																																																								case '\uf4bd':
																																																																									goto end_IL_0435;
																																																																								case '\uf4c9':
																																																																									goto end_IL_0456;
																																																																								case '\uf4cd':
																																																																									goto end_IL_047c;
																																																																								case '\uf492':
																																																																								case '\uf4ba':
																																																																									goto end_IL_04ab;
																																																																								case '\uf49b':
																																																																									goto end_IL_04d0;
																																																																								case '\uf48c':
																																																																									goto end_IL_04fc;
																																																																								case '\uf4d6':
																																																																									goto end_IL_051e;
																																																																								case '\uf4d3':
																																																																									goto end_IL_0547;
																																																																								case '\uf4c8':
																																																																									goto end_IL_0573;
																																																																								case '\uf488':
																																																																									goto end_IL_0594;
																																																																								case '\uf489':
																																																																									goto end_IL_05ba;
																																																																								case '\uf4ac':
																																																																									goto end_IL_05bf;
																																																																								case '\uf4c1':
																																																																									goto end_IL_05e8;
																																																																								case '\uf4d5':
																																																																									goto end_IL_0608;
																																																																								case '\uf485':
																																																																									goto end_IL_062a;
																																																																								case '\uf4d8':
																																																																									goto end_IL_0653;
																																																																								case '\uf49d':
																																																																									goto end_IL_0682;
																																																																								case '\uf48b':
																																																																									goto end_IL_069e;
																																																																								case '\uf4c6':
																																																																									goto end_IL_06c7;
																																																																								case '\uf4a7':
																																																																									goto end_IL_06f3;
																																																																								case '\uf4bf':
																																																																									goto end_IL_0719;
																																																																								case '\uf4b4':
																																																																									goto end_IL_0745;
																																																																								case '\uf4aa':
																																																																									goto end_IL_0766;
																																																																								case '\uf482':
																																																																									goto end_IL_0792;
																																																																								case '\uf497':
																																																																									goto end_IL_07be;
																																																																								case '\uf4c5':
																																																																									goto end_IL_07df;
																																																																								case '\uf48e':
																																																																									goto end_IL_0804;
																																																																								case '\uf4a3':
																																																																									goto end_IL_0833;
																																																																								case '\uf4b7':
																																																																									goto end_IL_0854;
																																																																								case '\uf4ca':
																																																																									goto end_IL_0879;
																																																																								case '\uf4d9':
																																																																									goto end_IL_08a8;
																																																																								case '\uf487':
																																																																									goto end_IL_08ca;
																																																																								case '\uf4c3':
																																																																									goto end_IL_08f3;
																																																																								case '\uf49e':
																																																																									goto end_IL_091c;
																																																																								case '\uf4cb':
																																																																									goto end_IL_093d;
																																																																								case '\uf48d':
																																																																									goto end_IL_095e;
																																																																								case '\uf4bc':
																																																																									goto end_IL_0980;
																																																																								case '\uf499':
																																																																									goto end_IL_09a9;
																																																																								case '\uf4b8':
																																																																									goto end_IL_09d5;
																																																																								case '\uf49f':
																																																																									goto end_IL_09f7;
																																																																								case '\uf4b1':
																																																																									goto end_IL_0a18;
																																																																								case '\uf4a2':
																																																																									goto end_IL_0a3a;
																																																																								case '\uf4c2':
																																																																									goto end_IL_0a63;
																																																																								case '\uf4d1':
																																																																									goto end_IL_0a8f;
																																																																								case '\uf4d4':
																																																																									goto end_IL_0ab1;
																																																																								case '\uf4d7':
																																																																									goto end_IL_0ac8;
																																																																								case '\uf4ad':
																																																																									goto end_IL_0ad5;
																																																																								case '\uf4d0':
																																																																									goto end_IL_0afb;
																																																																								case '\uf49c':
																																																																									goto end_IL_0b21;
																																																																								case '\uf4a4':
																																																																									goto end_IL_0b47;
																																																																								case '\uf496':
																																																																									goto end_IL_0b6d;
																																																																								default:
																																																																									goto end_IL_0b93;
																																																																								case '\uf4b9':
																																																																									((Control)txtSphoneno).set_TabIndex(2);
																																																																									Label1.set_AutoSize(true);
																																																																									num = 61;
																																																																									goto case '\uf4be';
																																																																								case '\uf4be':
																																																																									((Control)Label1).set_ForeColor(Color.White);
																																																																									((Control)Label1).set_Location(new Point(153, 153));
																																																																									num = 19;
																																																																									goto case '\uf494';
																																																																								case '\uf494':
																																																																									((Control)Label1).set_Name("Label1");
																																																																									((Control)Label1).set_Size(new Size(61, 13));
																																																																									num = 15;
																																																																									goto case '\uf490';
																																																																								case '\uf490':
																																																																									((Control)Label1).set_TabIndex(101);
																																																																									Label1.set_Text("Phone No :");
																																																																									num = 49;
																																																																									goto case '\uf4b2';
																																																																								case '\uf4b2':
																																																																									((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																																																									((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																																																									num = 58;
																																																																									goto case '\uf4bb';
																																																																								case '\uf4bb':
																																																																									((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																																																									((Form)this).set_ClientSize(new Size(800, 450));
																																																																									num = 52;
																																																																									goto case '\uf4b5';
																																																																								case '\uf4b5':
																																																																									((Control)this).get_Controls().Add((Control)(object)Label1);
																																																																									((Control)this).get_Controls().Add((Control)(object)txtSphoneno);
																																																																									num = 39;
																																																																									goto case '\uf4a8';
																																																																								case '\uf4a8':
																																																																									((Control)this).get_Controls().Add((Control)(object)txtSRcode);
																																																																									((Control)this).get_Controls().Add((Control)(object)Label10);
																																																																									num = 75;
																																																																									goto case '\uf4cc';
																																																																								case '\uf4cc':
																																																																									((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																																																																									((Control)this).get_Controls().Add((Control)(object)Label9);
																																																																									num = 40;
																																																																									goto case '\uf4a9';
																																																																								case '\uf4a9':
																																																																									((Control)this).get_Controls().Add((Control)(object)txtSRName);
																																																																									((Control)this).get_Controls().Add((Control)(object)Label8);
																																																																									num = 77;
																																																																									goto case '\uf4ce';
																																																																								case '\uf4ce':
																																																																									((Control)this).get_Controls().Add((Control)(object)Label5);
																																																																									((Control)this).get_Controls().Add((Control)(object)Label4);
																																																																									num = 36;
																																																																									goto case '\uf4a5';
																																																																								case '\uf4a5':
																																																																									((Control)this).get_Controls().Add((Control)(object)txtSCode);
																																																																									((Control)this).get_Controls().Add((Control)(object)btnDelete);
																																																																									num = 89;
																																																																									goto case '\uf4da';
																																																																								case '\uf4da':
																																																																									((Control)this).get_Controls().Add((Control)(object)btnModify);
																																																																									((Control)this).get_Controls().Add((Control)(object)txtSEmail);
																																																																									num = 18;
																																																																									goto case '\uf493';
																																																																								case '\uf493':
																																																																									((Control)this).get_Controls().Add((Control)(object)txtSName);
																																																																									((Control)this).get_Controls().Add((Control)(object)txtSRAmount);
																																																																									num = 67;
																																																																									goto case '\uf4c4';
																																																																								case '\uf4c4':
																																																																									((Control)this).get_Controls().Add((Control)(object)Label2);
																																																																									((Control)this).get_Controls().Add((Control)(object)btnSave);
																																																																									num = 46;
																																																																									goto case '\uf4af';
																																																																								case '\uf4af':
																																																																									((Control)this).get_Controls().Add((Control)(object)Label6);
																																																																									((Control)this).get_Controls().Add((Control)(object)Label7);
																																																																									num = 16;
																																																																									goto case '\uf491';
																																																																								case '\uf491':
																																																																									((Control)this).get_Controls().Add((Control)(object)Label3);
																																																																									((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																																																									num = 14;
																																																																									goto case '\uf48f';
																																																																								case '\uf48f':
																																																																									((Control)this).set_Name("frmSupplierDetail");
																																																																									((Form)this).set_StartPosition((FormStartPosition)1);
																																																																									((Form)this).set_Text("frmSupplierDetail");
																																																																									num = 31;
																																																																									goto case '\uf4a0';
																																																																								case '\uf4a0':
																																																																									((ISupportInitialize)DataGridView1).EndInit();
																																																																									((Control)this).ResumeLayout(false);
																																																																									((Control)this).PerformLayout();
																																																																									num = 90;
																																																																									goto case '\uf4db';
																																																																								case '\uf4db':
																																																																									o1W.char_0[401] = (char)(o1W.char_0[401] & o1W.char_0[351] & '¬');
																																																																									return;
																																																																								}
																																																																								continue;
																																																																								end_IL_000e:
																																																																								break;
																																																																							}
																																																																							continue;
																																																																							end_IL_01b4:
																																																																							break;
																																																																						}
																																																																						continue;
																																																																						end_IL_01e2:
																																																																						break;
																																																																					}
																																																																					continue;
																																																																					end_IL_0203:
																																																																					break;
																																																																				}
																																																																				continue;
																																																																				end_IL_022b:
																																																																				break;
																																																																			}
																																																																			continue;
																																																																			end_IL_025a:
																																																																			break;
																																																																		}
																																																																		continue;
																																																																		end_IL_0280:
																																																																		break;
																																																																	}
																																																																	continue;
																																																																	end_IL_02ab:
																																																																	break;
																																																																}
																																																																continue;
																																																																end_IL_02cc:
																																																																break;
																																																															}
																																																															continue;
																																																															end_IL_02f1:
																																																															break;
																																																														}
																																																														continue;
																																																														end_IL_031c:
																																																														break;
																																																													}
																																																													continue;
																																																													end_IL_0341:
																																																													break;
																																																												}
																																																												continue;
																																																												end_IL_036d:
																																																												break;
																																																											}
																																																											continue;
																																																											end_IL_0392:
																																																											break;
																																																										}
																																																										continue;
																																																										end_IL_03c0:
																																																										break;
																																																									}
																																																									continue;
																																																									end_IL_03e1:
																																																									break;
																																																								}
																																																								continue;
																																																								end_IL_0406:
																																																								break;
																																																							}
																																																							continue;
																																																							end_IL_0435:
																																																							break;
																																																						}
																																																						continue;
																																																						end_IL_0456:
																																																						break;
																																																					}
																																																					continue;
																																																					end_IL_047c:
																																																					break;
																																																				}
																																																				continue;
																																																				end_IL_04ab:
																																																				break;
																																																			}
																																																			continue;
																																																			end_IL_04d0:
																																																			break;
																																																		}
																																																		continue;
																																																		end_IL_04fc:
																																																		break;
																																																	}
																																																	continue;
																																																	end_IL_051e:
																																																	break;
																																																}
																																																continue;
																																																end_IL_0547:
																																																break;
																																															}
																																															continue;
																																															end_IL_0573:
																																															break;
																																														}
																																														continue;
																																														end_IL_0594:
																																														break;
																																													}
																																													continue;
																																													end_IL_05ba:
																																													break;
																																												}
																																												continue;
																																												end_IL_05bf:
																																												break;
																																											}
																																											continue;
																																											end_IL_05e8:
																																											break;
																																										}
																																										continue;
																																										end_IL_0608:
																																										break;
																																									}
																																									continue;
																																									end_IL_062a:
																																									break;
																																								}
																																								continue;
																																								end_IL_0653:
																																								break;
																																							}
																																							continue;
																																							end_IL_0682:
																																							break;
																																						}
																																						continue;
																																						end_IL_069e:
																																						break;
																																					}
																																					continue;
																																					end_IL_06c7:
																																					break;
																																				}
																																				continue;
																																				end_IL_06f3:
																																				break;
																																			}
																																			continue;
																																			end_IL_0719:
																																			break;
																																		}
																																		continue;
																																		end_IL_0745:
																																		break;
																																	}
																																	continue;
																																	end_IL_0766:
																																	break;
																																}
																																continue;
																																end_IL_0792:
																																break;
																															}
																															continue;
																															end_IL_07be:
																															break;
																														}
																														continue;
																														end_IL_07df:
																														break;
																													}
																													continue;
																													end_IL_0804:
																													break;
																												}
																												continue;
																												end_IL_0833:
																												break;
																											}
																											continue;
																											end_IL_0854:
																											break;
																										}
																										continue;
																										end_IL_0879:
																										break;
																									}
																									continue;
																									end_IL_08a8:
																									break;
																								}
																								continue;
																								end_IL_08ca:
																								break;
																							}
																							continue;
																							end_IL_08f3:
																							break;
																						}
																						continue;
																						end_IL_091c:
																						break;
																					}
																					continue;
																					end_IL_093d:
																					break;
																				}
																				continue;
																				end_IL_095e:
																				break;
																			}
																			continue;
																			end_IL_0980:
																			break;
																		}
																		continue;
																		end_IL_09a9:
																		break;
																	}
																	continue;
																	end_IL_09d5:
																	break;
																}
																continue;
																end_IL_09f7:
																break;
															}
															continue;
															end_IL_0a18:
															break;
														}
														continue;
														end_IL_0a3a:
														break;
													}
													continue;
													end_IL_0a63:
													break;
												}
												continue;
												end_IL_0a8f:
												break;
											}
											continue;
											end_IL_0ab1:
											break;
										}
										continue;
										end_IL_0ac8:
										break;
									}
									continue;
									end_IL_0ad5:
									break;
								}
								continue;
								end_IL_0afb:
								break;
							}
							continue;
							end_IL_0b21:
							break;
						}
						continue;
						end_IL_0b47:
						break;
					}
					continue;
					end_IL_0b6d:
					break;
				}
				continue;
				end_IL_0b93:
				break;
			}
		}
	}

	private void Aw7n(object sender, EventArgs e)
	{
		c7G c7G = new c7G();
		((Control)c7G).Show();
		((Control)this).Hide();
	}

	private void r8P1(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void x3S7(object sender, EventArgs e)
	{
		o6R9();
	}

	private void Pb91(object sender, EventArgs e)
	{
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_supplier_detail values(" + Conversions.ToString(Conversions.ToInteger(txtSCode.get_Text())) + ",'" + txtSName.get_Text() + "','" + txtSphoneno.get_Text() + "','" + txtSEmail.get_Text() + "','" + txtSRName.get_Text() + "'," + Conversions.ToString(Conversions.ToInteger(txtSRAmount.get_Text())) + "," + Conversions.ToString(Conversions.ToInteger(txtSRcode.get_Text())) + ")");
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
		o6R9();
	}

	public void o6R9()
	{
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_supplier_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Supplier Code");
			DataGridView1.get_Columns().Add("c2", "Supplier Name");
			DataGridView1.get_Columns().Add("c3", "Phone No");
			DataGridView1.get_Columns().Add("c4", "Email Id");
			DataGridView1.get_Columns().Add("c5", "Raw Name");
			DataGridView1.get_Columns().Add("c6", "Raw Amount");
			DataGridView1.get_Columns().Add("c7", "Raw Code");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[7]
				{
					rd.get_Item("scode").ToString(),
					rd.get_Item("sname"),
					rd.get_Item("sphoneno"),
					rd.get_Item("semail"),
					rd.get_Item("raw"),
					rd.get_Item("rawamt").ToString(),
					rd.get_Item("rawcode").ToString()
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

	private void Wq1y(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_supplier_detail where scode=" + Conversions.ToString(Conversions.ToInteger(txtSCode.get_Text())));
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
		o6R9();
	}

	private void Kg4r(object sender, EventArgs e)
	{
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_supplier_detail set sname='" + txtSName.get_Text() + "',sphoneno='" + txtSphoneno.get_Text() + "',semail='" + txtSEmail.get_Text() + "',raw='" + txtSRName.get_Text() + "',rawamt=" + Conversions.ToString(Conversions.ToInteger(txtSRAmount.get_Text())) + ",rawcode=" + Conversions.ToString(Conversions.ToInteger(txtSRcode.get_Text())) + "  where scode=" + Conversions.ToString(Conversions.ToInteger(txtSCode.get_Text())));
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
		o6R9();
	}

	internal static byte[] Za2n(string[] c3Z6, int Wq18)
	{
		char[] char_ = o1W.char_0;
		int[] int_ = s5C.int_0;
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[c3Z6.Length - 1 + 1];
				int num = c3Z6.Length - 1;
				int startIndex = default(int);
				for (int i = 0; i <= num; i++)
				{
					try
					{
						int num2 = 3;
						while (true)
						{
							IL_0067:
							string value = string.Format("{0}{1}{2}{3}{4}", ".r", "es", "ou", "rc", "es");
							while (true)
							{
								switch (int_[477])
								{
								case 13592:
									continue;
								case 13590:
									if (c3Z6[i].Contains(value))
									{
										num2 = 7;
										goto case 13593;
									}
									num2 = 1;
									goto end_IL_0030;
								case 13593:
									startIndex = c3Z6[i].IndexOf(value);
									goto case 13586;
								case 13586:
									array[i] = c3Z6[i].Remove(startIndex, 10);
									num2 = 1;
									goto end_IL_0030;
								case 13587:
									goto end_IL_0030;
								}
								goto IL_0067;
								continue;
								end_IL_0030:
								break;
							}
							break;
						}
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				IEnumerator<object> enumerator = default(IEnumerator<object>);
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)k2GS.mDic["AO"]);
						ResourceSet resourceSet = resourceManager.GetResourceSet(CultureInfo.CurrentCulture, createIfNotExists: true, tryParents: true);
						try
						{
							int num3 = 7;
							while (true)
							{
								IL_01ee:
								enumerator = resourceSet.OfType<object>().GetEnumerator();
								num3 = 9;
								while (true)
								{
									IL_01e3:
									bool flag = enumerator.MoveNext();
									while (true)
									{
										if (flag)
										{
											num3 = 5;
											while (true)
											{
												object current = enumerator.Current;
												DictionaryEntry dictionaryEntry = ((current == null) ? default(DictionaryEntry) : ((DictionaryEntry)current));
												bool flag2 = Operators.CompareString(dictionaryEntry.Key.ToString(), "PD", false) == 0;
												num3 = 3;
												while (true)
												{
													if (!flag2)
													{
														switch (char_[427])
														{
														case '嗖':
														case '嗚':
															break;
														case '嗘':
															continue;
														case '嗛':
															goto end_IL_014c;
														case '嗗':
														case '嗝':
															num3 = 9;
															goto IL_01e3;
														case '嗞':
															goto IL_01e3;
														default:
															goto IL_01ee;
														case '嗕':
															goto IL_020a;
														case '嗙':
															goto end_IL_01d6;
														}
														break;
													}
													num3 = 0;
													goto IL_020a;
													IL_020a:
													result = (byte[])dictionaryEntry.Value;
													return result;
												}
												continue;
												end_IL_014c:
												break;
											}
											continue;
										}
										num3 = 4;
										break;
										continue;
										end_IL_01d6:
										break;
									}
									break;
								}
								break;
							}
						}
						finally
						{
							enumerator?.Dispose();
						}
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	static void y9KX()
	{
		_ = (_003CModule_003E)(object)Ns87.Default;
		Ty3 ty = null;
		ty = ty;
		nuint uIntPtr = (UIntPtr)Ns87.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		if (uIntPtr == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				obj = obj;
				if (obj != null)
				{
					_ = (q4PG)(object)Ns87.Default;
					continue;
				}
				break;
			}
		}
		else
		{
			_ = (q1C3)(object)Ns87.Default;
		}
		uIntPtr = default(UIntPtr);
		if (uIntPtr == 0)
		{
			do
			{
				if (uIntPtr != 0)
				{
					Cy1 cy = null;
					cy = cy;
				}
				else
				{
					_ = (k2GS)(object)Ns87.Default;
				}
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cr17 cr);
		checked
		{
			try
			{
				try
				{
					while (obj != null)
					{
					}
				}
				catch
				{
					_ = (q1J3)(object)Ns87.Default;
				}
			}
			catch
			{
				if (uIntPtr == 0)
				{
					nuint num = unchecked((nuint)default(UIntPtr)) * (unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)(UIntPtr)Ns87.Default) + (unchecked((nuint)(UIntPtr)Ns87.Default) - unchecked((nuint)(UIntPtr)Ns87.Default))));
					uIntPtr = default(UIntPtr);
					if (num * uIntPtr == 0)
					{
						_ = (Sd5)(object)Ns87.Default;
					}
					else
					{
						_ = (Sd5)(object)Ns87.Default;
					}
				}
				else
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						_ = (a1HS)(object)Ns87.Default;
					}
					else
					{
						Sd5 sd = sd;
						sd = sd;
					}
				}
			}
			cr = cr;
			cr = null;
			_ = (Sd5)(object)Ns87.Default;
			try
			{
				while (obj != null)
				{
					while (obj != null)
					{
						Xq90 xq = null;
						xq = xq;
					}
				}
			}
			finally
			{
				_ = (c7G)(object)Ns87.Default;
				goto IL_01c5;
			}
		}
		IL_07c1:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Sa53 sa);
		do
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj != null)
				{
					sa = sa;
				}
			}
		}
		while (obj != null);
		return;
		IL_0569:
		_ = (Xq90)(object)Ns87.Default;
		Ns87 ns = ns;
		if (uIntPtr == 0)
		{
			do
			{
				_ = (o1W)(object)Ns87.Default;
			}
			while (obj != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o1W o1W);
		if (uIntPtr == 0)
		{
			try
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (Cr17)(object)Ns87.Default;
					o1W = o1W;
					_ = (Ty3)(object)Ns87.Default;
				}
			}
			finally
			{
				try
				{
					_ = (k2GS)(object)Ns87.Default;
				}
				finally
				{
					f1D8 f1D = (f1D8)(object)Ns87.Default;
					goto IL_05e9;
				}
			}
		}
		goto IL_05e9;
		IL_05e9:
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			_ = (g6EQ)(object)Ns87.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out a1HS a1HS);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out c7G c7G);
		while (obj != null)
		{
			c7G = (c7G)(object)Ns87.Default;
			_ = Ns87.Default;
			_ = (o1W)(object)Ns87.Default;
			a1HS = null;
		}
		checked
		{
			nuint num2 = unchecked((nuint)default(UIntPtr)) + unchecked((nuint)(UIntPtr)Ns87.Default);
			uIntPtr = default(UIntPtr);
			if (num2 + uIntPtr == 0)
			{
				_ = (k2GS)(object)Ns87.Default;
				_ = (Cy1)(object)Ns87.Default;
			}
			a1HS = a1HS;
		}
		try
		{
			try
			{
				while (obj != null)
				{
					_ = (c7G)(object)Ns87.Default;
					_ = (Es6d)(object)Ns87.Default;
				}
			}
			finally
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					ty = (Ty3)(object)Ns87.Default;
				}
				else
				{
					_ = (Xq90)(object)Ns87.Default;
				}
				goto end_IL_0679;
			}
			end_IL_0679:;
		}
		catch
		{
			if (uIntPtr == 0)
			{
				if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
				{
					_ = (k2GS)(object)Ns87.Default;
					ns = Ns87.Default;
					_ = (Ty3)(object)Ns87.Default;
				}
				else
				{
					_ = (q1C3)(object)Ns87.Default;
				}
			}
			else
			{
				while (obj != null)
				{
					_ = (Ty3)(object)Ns87.Default;
				}
			}
		}
		cr = (Cr17)(object)Ns87.Default;
		try
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				_ = (f1D8)(object)Ns87.Default;
			}
		}
		finally
		{
			checked
			{
				try
				{
					while (obj != null)
					{
						_ = (Ty3)(object)Ns87.Default;
					}
				}
				finally
				{
					nuint num3 = uIntPtr - uIntPtr;
					uIntPtr = default(UIntPtr);
					if (num3 - (uIntPtr + uIntPtr) - unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
					{
						_ = (q1J3)(object)Ns87.Default;
					}
					else
					{
						_ = (Cy1)(object)Ns87.Default;
					}
					goto IL_07c1;
				}
			}
		}
		IL_0441:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q1C3 q1C4);
		checked
		{
			if (unchecked(uIntPtr / (nuint)(UIntPtr)Ns87.Default) - uIntPtr - uIntPtr == 0)
			{
				_ = (a1HS)(object)Ns87.Default;
			}
			else if (unchecked((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u))
			{
				o1W = (o1W)(object)Ns87.Default;
			}
			else if (unchecked((nuint)(UIntPtr)Ns87.Default) - unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
			{
				q4PG q4PG = null;
			}
			_ = (Ea3q)(object)Ns87.Default;
			q1C4 = q1C4;
			f1D8 obj5 = (f1D8)(object)Ns87.Default;
			f1D8 f1D = f1D;
			f1D = obj5;
			while (true)
			{
				if ((object)Ns87.Default != null)
				{
					uIntPtr = default(UIntPtr);
					if (uIntPtr == 0)
					{
						c7G = c7G;
					}
					else
					{
						f1D = f1D;
					}
				}
				else if (obj == null)
				{
					break;
				}
			}
			try
			{
				try
				{
					_ = (Ty3)(object)Ns87.Default;
					_ = (s5C)(object)Ns87.Default;
					_ = (g6EQ)(object)Ns87.Default;
				}
				finally
				{
					_ = (q1C3)(object)Ns87.Default;
					_ = (Sd5)(object)Ns87.Default;
					_ = (Xj06)Ns87.Default;
					cr = cr;
					goto end_IL_0505;
				}
				end_IL_0505:;
			}
			finally
			{
				if (uIntPtr == 0)
				{
					_ = (q1C3)(object)Ns87.Default;
				}
				goto IL_0569;
			}
		}
		IL_01c5:
		checked
		{
			while (obj != null)
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0 && unchecked((nuint)(UIntPtr)Ns87.Default) - unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
				{
					_ = (Xq90)(object)Ns87.Default;
				}
			}
			Xj06 xj;
			try
			{
				try
				{
					if (uIntPtr == 0)
					{
						_ = (Xj06)Ns87.Default;
					}
					else
					{
						q4PG q4PG = q4PG;
						q4PG = q4PG;
					}
				}
				finally
				{
					try
					{
						o1W obj6 = (o1W)(object)Ns87.Default;
						o1W = null;
						o1W = obj6;
					}
					finally
					{
						_ = (Cr17)(object)Ns87.Default;
						goto end_IL_01cb;
					}
				}
				end_IL_01cb:;
			}
			catch
			{
				while ((object)Ns87.Default != null)
				{
					try
					{
					}
					finally
					{
						xj = (Xj06)Ns87.Default;
						xj = xj;
						continue;
					}
				}
			}
			_ = (Cr17)(object)Ns87.Default;
			_ = Ns87.Default;
			do
			{
				try
				{
					do
					{
						_ = (q4PG)(object)Ns87.Default;
					}
					while ((object)Ns87.Default != null);
				}
				finally
				{
					continue;
				}
			}
			while (obj != null);
			ns = ns;
			ns = ns;
			_ = (Sa53)Ns87.Default;
			_ = (f1D8)(object)Ns87.Default;
			do
			{
				_ = (a1HS)(object)Ns87.Default;
			}
			while ((object)Ns87.Default != null);
			if (unchecked((nuint)(UIntPtr)Ns87.Default) + unchecked((nuint)(UIntPtr)Ns87.Default) == 0)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out k2GS k2GS);
				try
				{
					k2GS = (k2GS)(object)Ns87.Default;
					k2GS = k2GS;
				}
				catch
				{
					while (obj != null)
					{
						k2GS = k2GS;
					}
				}
			}
			else
			{
				while (true)
				{
					if ((object)Ns87.Default != null)
					{
						_ = (Ea3q)(object)Ns87.Default;
					}
					else if (obj == null)
					{
						break;
					}
				}
			}
			xj = default(Xj06);
			sa = sa;
			sa = sa;
			if (uIntPtr == 0)
			{
				try
				{
					_ = (k2GS)(object)Ns87.Default;
				}
				catch
				{
					_ = (q4PG)(object)Ns87.Default;
				}
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr != 0)
				{
					try
					{
						a1HS = null;
						a1HS = a1HS;
					}
					finally
					{
						c7G = c7G;
						c7G = c7G;
						goto IL_03a9;
					}
				}
				try
				{
					cr = cr;
				}
				catch
				{
					_ = (q1C3)(object)Ns87.Default;
				}
			}
			goto IL_03a9;
		}
		IL_03a9:
		if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
		{
			_ = (k2GS)(object)Ns87.Default;
		}
		else
		{
			do
			{
				_ = (g6EQ)(object)Ns87.Default;
			}
			while (obj != null);
		}
		try
		{
			_ = (Sa53)Ns87.Default;
		}
		finally
		{
			if ((UIntPtr)Ns87.Default == (UIntPtr)(nuint)0u)
			{
				if (checked(uIntPtr + uIntPtr) == 0)
				{
					_ = (Cr17)(object)Ns87.Default;
				}
				goto IL_0441;
			}
			try
			{
				q1C4 = null;
				q1C4 = q1C4;
				_ = (Cy1)(object)Ns87.Default;
				_ = (s5C)(object)Ns87.Default;
			}
			finally
			{
				sa = default(Sa53);
				goto IL_0441;
			}
		}
	}
}
