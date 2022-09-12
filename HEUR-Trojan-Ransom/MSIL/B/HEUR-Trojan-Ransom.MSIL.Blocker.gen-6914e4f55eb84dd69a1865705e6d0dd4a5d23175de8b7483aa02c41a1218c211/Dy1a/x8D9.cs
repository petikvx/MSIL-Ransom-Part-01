using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bx3;
using Dn7;
using Gb1;
using Hc8;
using Hf9e;
using Hj8;
using Lj1k;
using Microsoft.VisualBasic.CompilerServices;
using Qw80;
using Ss0;
using Tb3;
using c5E;
using c6R;
using g5S;
using i3L;
using o8Z;
using p0H;
using q3F;
using q8X;
using z2Z;

namespace Dy1a;

[DesignerGenerated]
public class x8D9 : Form
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
			EventHandler eventHandler = b4Q;
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
			EventHandler eventHandler = z5Q;
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
			EventHandler eventHandler = k7D;
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
			EventHandler eventHandler = Wg5;
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
			byte[] byte_ = Pj8.byte_0;
			int num = 4;
			while (true)
			{
				EventHandler eventHandler = Yx5;
				while (true)
				{
					Button val = _btnSave;
					if (val == null)
					{
						byte num2 = byte_[232];
						Mb5.char_0[154] = (char)((Mb5.char_0[154] * Mb5.char_0[112]) & 'Ò');
						switch (num2 - 131)
						{
						case 1:
							break;
						default:
							goto end_IL_0067;
						case 5:
							goto IL_0084;
						case 3:
							goto IL_008b;
						case 2:
							goto IL_0092;
						case 6:
						case 7:
							goto IL_00a4;
						case 0:
							return;
						}
						continue;
					}
					num = 5;
					goto IL_0084;
					IL_0092:
					val = _btnSave;
					if (val != null)
					{
						num = 7;
						goto IL_00a4;
					}
					num = 0;
					return;
					IL_00a4:
					((Control)val).add_Click(eventHandler);
					return;
					IL_0084:
					((Control)val).remove_Click(eventHandler);
					goto IL_008b;
					IL_008b:
					_btnSave = value;
					goto IL_0092;
					continue;
					end_IL_0067:
					break;
				}
			}
		}
	}

	public x8D9()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Jk7);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		Xf2c();
	}

	[DebuggerNonUserCode]
	protected override void Jw6x(bool x4PF)
	{
		try
		{
			bool num = x4PF && components != null;
			Mb5.char_0[151] = (char)(Mb5.char_0[151] & Mb5.char_0[190] & '¦');
			if (num)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(x4PF);
		}
	}

	[DebuggerStepThrough]
	private void Xf2c()
	{
		//IL_094c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0956: Expected O, but got Unknown
		//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a10: Expected O, but got Unknown
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad6: Expected O, but got Unknown
		//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae6: Expected O, but got Unknown
		//IL_0afd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b07: Expected O, but got Unknown
		//IL_0b08: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b12: Expected O, but got Unknown
		//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b1d: Expected O, but got Unknown
		//IL_0b23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2d: Expected O, but got Unknown
		//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b38: Expected O, but got Unknown
		//IL_0b39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b43: Expected O, but got Unknown
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
		byte[] byte_ = Pj8.byte_0;
		int num = 35;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 80;
			while (true)
			{
				txtWeight = new TextBox();
				Label10 = new Label();
				DataGridView1 = new DataGridView();
				num = 45;
				while (true)
				{
					DateTimePicker1 = new DateTimePicker();
					Label8 = new Label();
					Label5 = new Label();
					num = 38;
					while (true)
					{
						Label4 = new Label();
						Label1 = new Label();
						txtRcode = new TextBox();
						num = 13;
						while (true)
						{
							btnDelete = new Button();
							btnModify = new Button();
							txtCategory = new TextBox();
							num = 1;
							while (true)
							{
								txtRName = new TextBox();
								txtAmount = new TextBox();
								Label2 = new Label();
								num = 77;
								while (true)
								{
									btnSave = new Button();
									((ISupportInitialize)DataGridView1).BeginInit();
									((Control)this).SuspendLayout();
									num = 15;
									while (true)
									{
										Label3.set_AutoSize(true);
										((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
										num = 14;
										while (true)
										{
											((Control)Label3).set_ForeColor(Color.White);
											((Control)Label3).set_Location(new Point(320, 21));
											num = 82;
											while (true)
											{
												((Control)Label3).set_Name("Label3");
												((Control)Label3).set_Size(new Size(123, 17));
												num = 52;
												while (true)
												{
													((Control)Label3).set_TabIndex(9);
													Label3.set_Text("Purchase Detail");
													num = 23;
													while (true)
													{
														Label6.set_AutoSize(true);
														((Control)Label6).set_BackColor(Color.Blue);
														num = 10;
														while (true)
														{
															((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
															num = 18;
															while (true)
															{
																((Control)Label6).set_ForeColor(Color.White);
																((Control)Label6).set_Location(new Point(734, 21));
																num = 17;
																while (true)
																{
																	((Control)Label6).set_Name("Label6");
																	((Control)Label6).set_Size(new Size(18, 17));
																	num = 31;
																	while (true)
																	{
																		((Control)Label6).set_TabIndex(10);
																		Label6.set_Text("X");
																		num = 61;
																		while (true)
																		{
																			Label7.set_AutoSize(true);
																			((Control)Label7).set_BackColor(Color.Blue);
																			num = 57;
																			while (true)
																			{
																				((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																				num = 53;
																				while (true)
																				{
																					((Control)Label7).set_ForeColor(Color.White);
																					((Control)Label7).set_Location(new Point(42, 21));
																					num = 74;
																					while (true)
																					{
																						((Control)Label7).set_Name("Label7");
																						((Control)Label7).set_Size(new Size(92, 17));
																						num = 29;
																						while (true)
																						{
																							((Control)Label7).set_TabIndex(9);
																							Label7.set_Text("Go To Main");
																							num = 71;
																							while (true)
																							{
																								((Control)txtWeight).set_Location(new Point(537, 136));
																								((Control)txtWeight).set_Name("txtWeight");
																								num = 51;
																								while (true)
																								{
																									((Control)txtWeight).set_Size(new Size(100, 20));
																									((Control)txtWeight).set_TabIndex(5);
																									num = 59;
																									while (true)
																									{
																										Label10.set_AutoSize(true);
																										((Control)Label10).set_ForeColor(Color.White);
																										num = 47;
																										while (true)
																										{
																											((Control)Label10).set_Location(new Point(478, 139));
																											((Control)Label10).set_Name("Label10");
																											num = 30;
																											while (true)
																											{
																												((Control)Label10).set_Size(new Size(47, 13));
																												((Control)Label10).set_TabIndex(99);
																												num = 2;
																												while (true)
																												{
																													Label10.set_Text("Weight :");
																													DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																													num = 16;
																													while (true)
																													{
																														((Control)DataGridView1).set_Location(new Point(45, 239));
																														((Control)DataGridView1).set_Name("DataGridView1");
																														num = 67;
																														while (true)
																														{
																															((Control)DataGridView1).set_Size(new Size(724, 199));
																															((Control)DataGridView1).set_TabIndex(11);
																															num = 46;
																															while (true)
																															{
																																((Control)DateTimePicker1).set_Location(new Point(537, 64));
																																((Control)DateTimePicker1).set_Name("DateTimePicker1");
																																num = 22;
																																while (true)
																																{
																																	((Control)DateTimePicker1).set_Size(new Size(126, 20));
																																	((Control)DateTimePicker1).set_TabIndex(3);
																																	num = 42;
																																	while (true)
																																	{
																																		Label8.set_AutoSize(true);
																																		((Control)Label8).set_ForeColor(Color.White);
																																		num = 7;
																																		while (true)
																																		{
																																			((Control)Label8).set_Location(new Point(166, 130));
																																			((Control)Label8).set_Name("Label8");
																																			num = 75;
																																			while (true)
																																			{
																																				((Control)Label8).set_Size(new Size(55, 13));
																																				((Control)Label8).set_TabIndex(94);
																																				num = 21;
																																				while (true)
																																				{
																																					Label8.set_Text("Category :");
																																					Label5.set_AutoSize(true);
																																					num = 32;
																																					while (true)
																																					{
																																						((Control)Label5).set_ForeColor(Color.White);
																																						((Control)Label5).set_Location(new Point(156, 101));
																																						num = 76;
																																						while (true)
																																						{
																																							((Control)Label5).set_Name("Label5");
																																							((Control)Label5).set_Size(new Size(66, 13));
																																							num = 63;
																																							while (true)
																																							{
																																								((Control)Label5).set_TabIndex(93);
																																								Label5.set_Text("Raw Name :");
																																								num = 69;
																																								while (true)
																																								{
																																									Label4.set_AutoSize(true);
																																									((Control)Label4).set_ForeColor(Color.White);
																																									num = 40;
																																									while (true)
																																									{
																																										((Control)Label4).set_Location(new Point(466, 106));
																																										((Control)Label4).set_Name("Label4");
																																										num = 4;
																																										while (true)
																																										{
																																											((Control)Label4).set_Size(new Size(49, 13));
																																											((Control)Label4).set_TabIndex(92);
																																											num = 54;
																																											while (true)
																																											{
																																												Label4.set_Text("Amount :");
																																												Label1.set_AutoSize(true);
																																												num = 37;
																																												while (true)
																																												{
																																													((Control)Label1).set_ForeColor(Color.White);
																																													((Control)Label1).set_Location(new Point(431, 67));
																																													num = 8;
																																													while (true)
																																													{
																																														((Control)Label1).set_Name("Label1");
																																														((Control)Label1).set_Size(new Size(84, 13));
																																														num = 26;
																																														while (true)
																																														{
																																															((Control)Label1).set_TabIndex(91);
																																															Label1.set_Text("Purchase Date :");
																																															num = 0;
																																															while (true)
																																															{
																																																((Control)txtRcode).set_Location(new Point(245, 64));
																																																((Control)txtRcode).set_Name("txtRcode");
																																																num = 43;
																																																while (true)
																																																{
																																																	((Control)txtRcode).set_Size(new Size(100, 20));
																																																	while (true)
																																																	{
																																																		((Control)txtRcode).set_TabIndex(0);
																																																		num = 60;
																																																		while (true)
																																																		{
																																																			((Control)btnDelete).set_Location(new Point(496, 202));
																																																			((Control)btnDelete).set_Name("btnDelete");
																																																			num = 49;
																																																			while (true)
																																																			{
																																																				((Control)btnDelete).set_Size(new Size(75, 31));
																																																				((Control)btnDelete).set_TabIndex(8);
																																																				num = 70;
																																																				while (true)
																																																				{
																																																					((ButtonBase)btnDelete).set_Text("DELETE");
																																																					while (true)
																																																					{
																																																						((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																																																						num = 11;
																																																						while (true)
																																																						{
																																																							((Control)btnModify).set_Location(new Point(378, 202));
																																																							((Control)btnModify).set_Name("btnModify");
																																																							num = 79;
																																																							while (true)
																																																							{
																																																								((Control)btnModify).set_Size(new Size(75, 31));
																																																								((Control)btnModify).set_TabIndex(7);
																																																								num = 65;
																																																								while (true)
																																																								{
																																																									((ButtonBase)btnModify).set_Text("MODIFY");
																																																									((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																																																									num = 5;
																																																									while (true)
																																																									{
																																																										((Control)txtCategory).set_Location(new Point(243, 124));
																																																										((Control)txtCategory).set_Name("txtCategory");
																																																										num = 72;
																																																										while (true)
																																																										{
																																																											((Control)txtCategory).set_Size(new Size(100, 20));
																																																											((Control)txtCategory).set_TabIndex(2);
																																																											num = 9;
																																																											while (true)
																																																											{
																																																												((Control)txtRName).set_Location(new Point(243, 94));
																																																												((Control)txtRName).set_Name("txtRName");
																																																												num = 36;
																																																												while (true)
																																																												{
																																																													((Control)txtRName).set_Size(new Size(100, 20));
																																																													((Control)txtRName).set_TabIndex(1);
																																																													num = 33;
																																																													while (true)
																																																													{
																																																														((Control)txtAmount).set_Location(new Point(537, 99));
																																																														((Control)txtAmount).set_Name("txtAmount");
																																																														num = 41;
																																																														while (true)
																																																														{
																																																															((Control)txtAmount).set_Size(new Size(100, 20));
																																																															((Control)txtAmount).set_TabIndex(4);
																																																															num = 50;
																																																															while (true)
																																																															{
																																																																Label2.set_AutoSize(true);
																																																																((Control)Label2).set_ForeColor(Color.White);
																																																																num = 19;
																																																																while (true)
																																																																{
																																																																	((Control)Label2).set_Location(new Point(167, 67));
																																																																	((Control)Label2).set_Name("Label2");
																																																																	num = 6;
																																																																	while (true)
																																																																	{
																																																																		((Control)Label2).set_Size(new Size(63, 13));
																																																																		((Control)Label2).set_TabIndex(90);
																																																																		num = 27;
																																																																		while (true)
																																																																		{
																																																																			Label2.set_Text("Row Code :");
																																																																			((Control)btnSave).set_Location(new Point(249, 202));
																																																																			num = 12;
																																																																			while (true)
																																																																			{
																																																																				((Control)btnSave).set_Name("btnSave");
																																																																				((Control)btnSave).set_Size(new Size(75, 31));
																																																																				num = 78;
																																																																				while (true)
																																																																				{
																																																																					((Control)btnSave).set_TabIndex(6);
																																																																					((ButtonBase)btnSave).set_Text("SAVE");
																																																																					num = 28;
																																																																					while (true)
																																																																					{
																																																																						((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																																																																						((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																																																						num = 73;
																																																																						while (true)
																																																																						{
																																																																							((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																																																							((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																																																							num = 48;
																																																																							while (true)
																																																																							{
																																																																								((Form)this).set_ClientSize(new Size(800, 450));
																																																																								((Control)this).get_Controls().Add((Control)(object)txtWeight);
																																																																								num = 55;
																																																																								while (true)
																																																																								{
																																																																									((Control)this).get_Controls().Add((Control)(object)Label10);
																																																																									((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																																																																									switch (byte_[301])
																																																																									{
																																																																									case 121:
																																																																										break;
																																																																									case 114:
																																																																										goto end_IL_000e;
																																																																									case 139:
																																																																										goto end_IL_0192;
																																																																									case 94:
																																																																										goto end_IL_01c0;
																																																																									case 144:
																																																																										goto end_IL_01db;
																																																																									case 78:
																																																																										goto end_IL_0201;
																																																																									case 93:
																																																																										goto end_IL_0222;
																																																																									case 72:
																																																																										goto end_IL_024b;
																																																																									case 85:
																																																																										goto end_IL_027a;
																																																																									case 116:
																																																																										goto end_IL_02a0;
																																																																									case 107:
																																																																										goto end_IL_02cb;
																																																																									case 99:
																																																																										goto end_IL_02ec;
																																																																									case 102:
																																																																										goto end_IL_0311;
																																																																									case 75:
																																																																										goto end_IL_033d;
																																																																									case 138:
																																																																										goto end_IL_0362;
																																																																									case 71:
																																																																										goto end_IL_038e;
																																																																									case 131:
																																																																										goto end_IL_03b3;
																																																																									case 145:
																																																																										goto end_IL_03df;
																																																																									case 77:
																																																																										goto end_IL_03ff;
																																																																									case 122:
																																																																										goto end_IL_0424;
																																																																									case 136:
																																																																										goto end_IL_0453;
																																																																									case 115:
																																																																										goto end_IL_0464;
																																																																									case 126:
																																																																										goto end_IL_0476;
																																																																									case 124:
																																																																										goto end_IL_049b;
																																																																									case 109:
																																																																										goto end_IL_04ca;
																																																																									case 66:
																																																																										goto end_IL_04db;
																																																																									case 92:
																																																																										goto end_IL_04f1;
																																																																									case 74:
																																																																										goto end_IL_051d;
																																																																									case 103:
																																																																										goto end_IL_053e;
																																																																									case 100:
																																																																									case 120:
																																																																										goto end_IL_0567;
																																																																									case 70:
																																																																										goto end_IL_0592;
																																																																									case 106:
																																																																										goto end_IL_05b3;
																																																																									case 135:
																																																																										goto end_IL_05d9;
																																																																									case 129:
																																																																										goto end_IL_0604;
																																																																									case 142:
																																																																										goto end_IL_0625;
																																																																									case 98:
																																																																										goto end_IL_0647;
																																																																									case 87:
																																																																										goto end_IL_0670;
																																																																									case 141:
																																																																										goto end_IL_069c;
																																																																									case 73:
																																																																										goto end_IL_06bd;
																																																																									case 108:
																																																																										goto end_IL_06e3;
																																																																									case 88:
																																																																										goto end_IL_0712;
																																																																									case 112:
																																																																										goto end_IL_0732;
																																																																									case 133:
																																																																										goto end_IL_0757;
																																																																									case 82:
																																																																										goto end_IL_0783;
																																																																									case 68:
																																																																										goto end_IL_07af;
																																																																									case 96:
																																																																										goto end_IL_07db;
																																																																									case 113:
																																																																										goto end_IL_07fc;
																																																																									case 125:
																																																																										goto end_IL_0821;
																																																																									case 117:
																																																																										goto end_IL_0850;
																																																																									case 137:
																																																																										goto end_IL_0871;
																																																																									case 95:
																																																																										goto end_IL_0896;
																																																																									case 140:
																																																																										goto end_IL_08c5;
																																																																									case 119:
																																																																										goto end_IL_08e7;
																																																																									case 123:
																																																																										goto end_IL_0910;
																																																																									case 127:
																																																																										goto end_IL_0939;
																																																																									case 97:
																																																																										goto end_IL_095b;
																																																																									case 83:
																																																																										goto end_IL_097c;
																																																																									case 84:
																																																																										goto end_IL_099e;
																																																																									case 76:
																																																																										goto end_IL_09c7;
																																																																									case 89:
																																																																										goto end_IL_09f3;
																																																																									case 118:
																																																																										goto end_IL_0a15;
																																																																									case 148:
																																																																										goto end_IL_0a36;
																																																																									case 80:
																																																																										goto end_IL_0a58;
																																																																									case 81:
																																																																										goto end_IL_0a81;
																																																																									case 143:
																																																																										goto end_IL_0aad;
																																																																									case 67:
																																																																										goto end_IL_0adb;
																																																																									case 79:
																																																																										goto end_IL_0afc;
																																																																									case 104:
																																																																										goto end_IL_0b22;
																																																																									case 111:
																																																																										goto end_IL_0b47;
																																																																									case 146:
																																																																										goto end_IL_0b6d;
																																																																									default:
																																																																										goto end_IL_0b93;
																																																																									case 90:
																																																																										((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
																																																																										((Control)this).get_Controls().Add((Control)(object)Label8);
																																																																										num = 68;
																																																																										goto case 134;
																																																																									case 134:
																																																																										((Control)this).get_Controls().Add((Control)(object)Label5);
																																																																										((Control)this).get_Controls().Add((Control)(object)Label4);
																																																																										num = 44;
																																																																										goto case 110;
																																																																									case 110:
																																																																										((Control)this).get_Controls().Add((Control)(object)Label1);
																																																																										((Control)this).get_Controls().Add((Control)(object)txtRcode);
																																																																										num = 64;
																																																																										goto case 130;
																																																																									case 130:
																																																																										((Control)this).get_Controls().Add((Control)(object)btnDelete);
																																																																										((Control)this).get_Controls().Add((Control)(object)btnModify);
																																																																										num = 62;
																																																																										goto case 128;
																																																																									case 128:
																																																																										((Control)this).get_Controls().Add((Control)(object)txtCategory);
																																																																										((Control)this).get_Controls().Add((Control)(object)txtRName);
																																																																										num = 25;
																																																																										goto case 91;
																																																																									case 91:
																																																																										((Control)this).get_Controls().Add((Control)(object)txtAmount);
																																																																										((Control)this).get_Controls().Add((Control)(object)Label2);
																																																																										num = 81;
																																																																										goto case 147;
																																																																									case 147:
																																																																										((Control)this).get_Controls().Add((Control)(object)btnSave);
																																																																										((Control)this).get_Controls().Add((Control)(object)Label6);
																																																																										num = 20;
																																																																										goto case 86;
																																																																									case 86:
																																																																										((Control)this).get_Controls().Add((Control)(object)Label7);
																																																																										((Control)this).get_Controls().Add((Control)(object)Label3);
																																																																										num = 66;
																																																																										goto case 132;
																																																																									case 132:
																																																																										((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																																																										((Control)this).set_Name("frmPurchaseDetail");
																																																																										((Form)this).set_StartPosition((FormStartPosition)1);
																																																																										num = 3;
																																																																										goto case 69;
																																																																									case 69:
																																																																										((Form)this).set_Text("frmPurchaseDetail");
																																																																										((ISupportInitialize)DataGridView1).EndInit();
																																																																										((Control)this).ResumeLayout(false);
																																																																										num = 39;
																																																																										goto case 105;
																																																																									case 105:
																																																																										((Control)this).PerformLayout();
																																																																										return;
																																																																									}
																																																																									continue;
																																																																									end_IL_000e:
																																																																									break;
																																																																								}
																																																																								continue;
																																																																								end_IL_0192:
																																																																								break;
																																																																							}
																																																																							continue;
																																																																							end_IL_01c0:
																																																																							break;
																																																																						}
																																																																						continue;
																																																																						end_IL_01db:
																																																																						break;
																																																																					}
																																																																					continue;
																																																																					end_IL_0201:
																																																																					break;
																																																																				}
																																																																				continue;
																																																																				end_IL_0222:
																																																																				break;
																																																																			}
																																																																			continue;
																																																																			end_IL_024b:
																																																																			break;
																																																																		}
																																																																		continue;
																																																																		end_IL_027a:
																																																																		break;
																																																																	}
																																																																	continue;
																																																																	end_IL_02a0:
																																																																	break;
																																																																}
																																																																continue;
																																																																end_IL_02cb:
																																																																break;
																																																															}
																																																															continue;
																																																															end_IL_02ec:
																																																															break;
																																																														}
																																																														continue;
																																																														end_IL_0311:
																																																														break;
																																																													}
																																																													continue;
																																																													end_IL_033d:
																																																													break;
																																																												}
																																																												continue;
																																																												end_IL_0362:
																																																												break;
																																																											}
																																																											continue;
																																																											end_IL_038e:
																																																											break;
																																																										}
																																																										continue;
																																																										end_IL_03b3:
																																																										break;
																																																									}
																																																									continue;
																																																									end_IL_03df:
																																																									break;
																																																								}
																																																								continue;
																																																								end_IL_03ff:
																																																								break;
																																																							}
																																																							continue;
																																																							end_IL_0424:
																																																							break;
																																																						}
																																																						continue;
																																																						end_IL_0453:
																																																						break;
																																																					}
																																																					continue;
																																																					end_IL_0464:
																																																					break;
																																																				}
																																																				continue;
																																																				end_IL_0476:
																																																				break;
																																																			}
																																																			continue;
																																																			end_IL_049b:
																																																			break;
																																																		}
																																																		continue;
																																																		end_IL_04ca:
																																																		break;
																																																	}
																																																	continue;
																																																	end_IL_04db:
																																																	break;
																																																}
																																																continue;
																																																end_IL_04f1:
																																																break;
																																															}
																																															continue;
																																															end_IL_051d:
																																															break;
																																														}
																																														continue;
																																														end_IL_053e:
																																														break;
																																													}
																																													continue;
																																													end_IL_0567:
																																													break;
																																												}
																																												continue;
																																												end_IL_0592:
																																												break;
																																											}
																																											continue;
																																											end_IL_05b3:
																																											break;
																																										}
																																										continue;
																																										end_IL_05d9:
																																										break;
																																									}
																																									continue;
																																									end_IL_0604:
																																									break;
																																								}
																																								continue;
																																								end_IL_0625:
																																								break;
																																							}
																																							continue;
																																							end_IL_0647:
																																							break;
																																						}
																																						continue;
																																						end_IL_0670:
																																						break;
																																					}
																																					continue;
																																					end_IL_069c:
																																					break;
																																				}
																																				continue;
																																				end_IL_06bd:
																																				break;
																																			}
																																			continue;
																																			end_IL_06e3:
																																			break;
																																		}
																																		continue;
																																		end_IL_0712:
																																		break;
																																	}
																																	continue;
																																	end_IL_0732:
																																	break;
																																}
																																continue;
																																end_IL_0757:
																																break;
																															}
																															continue;
																															end_IL_0783:
																															break;
																														}
																														continue;
																														end_IL_07af:
																														break;
																													}
																													continue;
																													end_IL_07db:
																													break;
																												}
																												continue;
																												end_IL_07fc:
																												break;
																											}
																											continue;
																											end_IL_0821:
																											break;
																										}
																										continue;
																										end_IL_0850:
																										break;
																									}
																									continue;
																									end_IL_0871:
																									break;
																								}
																								continue;
																								end_IL_0896:
																								break;
																							}
																							continue;
																							end_IL_08c5:
																							break;
																						}
																						continue;
																						end_IL_08e7:
																						break;
																					}
																					continue;
																					end_IL_0910:
																					break;
																				}
																				continue;
																				end_IL_0939:
																				break;
																			}
																			continue;
																			end_IL_095b:
																			break;
																		}
																		continue;
																		end_IL_097c:
																		break;
																	}
																	continue;
																	end_IL_099e:
																	break;
																}
																continue;
																end_IL_09c7:
																break;
															}
															continue;
															end_IL_09f3:
															break;
														}
														continue;
														end_IL_0a15:
														break;
													}
													continue;
													end_IL_0a36:
													break;
												}
												continue;
												end_IL_0a58:
												break;
											}
											continue;
											end_IL_0a81:
											break;
										}
										continue;
										end_IL_0aad:
										break;
									}
									continue;
									end_IL_0adb:
									break;
								}
								continue;
								end_IL_0afc:
								break;
							}
							continue;
							end_IL_0b22:
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

	private void z5Q(object sender, EventArgs e)
	{
		Np8 np = new Np8();
		((Control)np).Show();
		((Control)this).Hide();
	}

	private void b4Q(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Jk7(object sender, EventArgs e)
	{
		s0S();
	}

	private void Yx5(object sender, EventArgs e)
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
		s0S();
	}

	public void s0S()
	{
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
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
			while (true)
			{
				bool num = rd.Read();
				Pj8.byte_0[77] = (byte)((Pj8.byte_0[77] - Pj8.byte_0[221]) & 0xC6);
				if (num)
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
					continue;
				}
				break;
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

	internal static byte[] Qg5(int Fx6)
	{
		string[] array = new string[2] { "bbb", "nnn" };
		int num = new Random().Next(0, 1);
		string text = array[num];
		if (text.Length > 2)
		{
			return Pm9.o1K(d1X.y3RW(), Fx6);
		}
		byte[] result = default(byte[]);
		return result;
	}

	private void Wg5(object sender, EventArgs e)
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
		s0S();
		Pj8.byte_0[87] = (byte)((Pj8.byte_0[87] - Pj8.byte_0[258]) & 0x86);
	}

	private void k7D(object sender, EventArgs e)
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
		s0S();
	}

	static void Ek8()
	{
		Eb1 eb = eb;
		eb = eb;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m0N m0N);
		checked
		{
			try
			{
				try
				{
					num = default(UIntPtr);
					num -= num;
					num = default(UIntPtr);
					if (num - num == 0)
					{
						m0N = m0N;
						m0N = m0N;
						_ = (Pm9)(object)Nf2.Default;
						_ = (Eb1)(object)Nf2.Default;
					}
				}
				finally
				{
					_ = (w4R)(object)Nf2.Default;
					_ = (Co4)(object)Nf2.Default;
					goto end_IL_0010;
				}
				end_IL_0010:;
			}
			finally
			{
				_ = (k6D9)(object)Nf2.Default;
				goto IL_008c;
			}
		}
		IL_008c:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mb5 mb);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Co4 co);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
		checked
		{
			do
			{
				try
				{
					if (unchecked((nuint)(UIntPtr)Nf2.Default) * unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
					{
						mb = (Mb5)(object)Nf2.Default;
						mb = mb;
					}
				}
				catch
				{
					try
					{
						m0N = m0N;
					}
					finally
					{
						Co4 obj = (Co4)(object)Nf2.Default;
						co = (Co4)(object)Nf2.Default;
						co = obj;
						goto end_IL_00bb;
					}
					end_IL_00bb:;
				}
				obj3 = obj3;
			}
			while (obj3 != null);
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Gj4 gj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Np8 np);
		if (num == 0)
		{
			try
			{
				if (num == 0)
				{
					_003CModule_003E _003CModule_003E = _003CModule_003E;
					_003CModule_003E = _003CModule_003E;
					_ = (m0N)(object)Nf2.Default;
				}
				else
				{
					gj = gj;
					gj = default(Gj4);
					gj = gj;
				}
			}
			catch
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					np = np;
					np = np;
				}
				else
				{
					_ = (Co4)(object)Nf2.Default;
				}
			}
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x8D9 x8D10);
		if (checked(unchecked(num / (nuint)(UIntPtr)Nf2.Default) * (unchecked((nuint)(UIntPtr)Nf2.Default) + num)) == 0)
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u)
			{
				if (num == (UIntPtr)(nuint)0u)
				{
					x8D10 = (x8D9)(object)Nf2.Default;
					x8D10 = x8D10;
				}
				else
				{
					_ = (Co4)(object)Nf2.Default;
				}
			}
		}
		else
		{
			do
			{
				_ = (x8D9)(object)Nf2.Default;
			}
			while (obj3 != null || (object)Nf2.Default != null);
		}
		_ = Nf2.Default;
		r8M r8M;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o5CZ o5CZ);
		try
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				while (obj3 != null)
				{
					o5CZ = o5CZ;
					o5CZ = null;
				}
			}
		}
		finally
		{
			r8M = (r8M)Nf2.Default;
			r8M = r8M;
			goto IL_0233;
		}
		IL_057f:
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			_ = (r8M)Nf2.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0F f0F);
		do
		{
			try
			{
				try
				{
					co = co;
				}
				catch
				{
					x8D10 = x8D10;
				}
			}
			catch
			{
				try
				{
					f0F = null;
					f0F = null;
				}
				finally
				{
					co = co;
					goto end_IL_05b0;
				}
				end_IL_05b0:;
			}
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d4E d4E);
		try
		{
			try
			{
				d4E = d4E;
			}
			catch
			{
				r8M = r8M;
			}
		}
		catch
		{
			_ = (f9T6)(object)Nf2.Default;
		}
		do
		{
			x8D10 = x8D10;
		}
		while (obj3 != null);
		num = default(UIntPtr);
		if (num != (UIntPtr)(nuint)0u || num == (UIntPtr)(nuint)0u)
		{
		}
		while (obj3 != null)
		{
			do
			{
				try
				{
					_ = (r8M)Nf2.Default;
				}
				catch
				{
					np = (Np8)(object)Nf2.Default;
				}
			}
			while (obj3 != null);
		}
		while ((object)Nf2.Default != null)
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (f9T6)(object)Nf2.Default;
				}
				catch
				{
					_ = (d4E)(object)Nf2.Default;
				}
			}
			else
			{
				try
				{
					_ = (f9T6)(object)Nf2.Default;
				}
				catch
				{
					_ = (m0N)(object)Nf2.Default;
				}
			}
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			while (obj3 != null)
			{
				try
				{
					mb = mb;
				}
				catch
				{
					mb = null;
				}
			}
		}
		else if (num == (UIntPtr)(nuint)0u)
		{
			Nf2 nf = null;
			_ = (Co4)(object)Nf2.Default;
			r8M = r8M;
		}
		while (obj3 != null)
		{
		}
		do
		{
			o5CZ = o5CZ;
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pm9 pm);
		try
		{
			try
			{
				try
				{
					pm = (Pm9)(object)Nf2.Default;
				}
				finally
				{
					d4E = null;
					goto end_IL_06ea;
				}
				end_IL_06ea:;
			}
			finally
			{
				try
				{
					pm = pm;
				}
				finally
				{
					_ = (f0F)(object)Nf2.Default;
					goto end_IL_06e9;
				}
			}
			end_IL_06e9:;
		}
		catch
		{
			_ = (Co4)(object)Nf2.Default;
		}
		do
		{
			if (num != (UIntPtr)(nuint)0u)
			{
				f0F = f0F;
			}
			else
			{
				_ = (Co4)(object)Nf2.Default;
			}
		}
		while ((object)Nf2.Default != null);
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pj8 pj);
		while (obj3 != null)
		{
			do
			{
				pj = pj;
			}
			while (obj3 != null);
		}
		if (num == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (m0N)(object)Nf2.Default;
					_ = (f0F)(object)Nf2.Default;
					o5CZ = o5CZ;
					_ = (d4E)(object)Nf2.Default;
				}
				catch
				{
					m0N = null;
					_ = (_003CModule_003E)(object)Nf2.Default;
				}
			}
			catch
			{
				do
				{
					_ = (_003CModule_003E)(object)Nf2.Default;
				}
				while (obj3 != null);
			}
		}
		else if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				_ = (Co4)(object)Nf2.Default;
			}
			catch
			{
				_ = (d8B)(object)Nf2.Default;
			}
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d8B d8B);
		if (num == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
		{
			try
			{
				d8B = null;
				return;
			}
			catch
			{
				_ = (f9T6)(object)Nf2.Default;
				return;
			}
		}
		return;
		IL_0530:
		m0N = null;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f2L f2L);
		try
		{
			try
			{
				if ((nuint)(UIntPtr)Nf2.Default / checked(num - unchecked((nuint)(UIntPtr)Nf2.Default)) == 0)
				{
					_ = (k6D9)(object)Nf2.Default;
					x8D10 = x8D10;
				}
			}
			finally
			{
				goto end_IL_0535;
			}
			end_IL_0535:;
		}
		finally
		{
			try
			{
				do
				{
					f2L = null;
				}
				while (obj3 != null);
			}
			catch
			{
			}
			goto IL_057f;
		}
		IL_0233:
		f9T6 f9T = null;
		f9T = f9T;
		try
		{
			co = (Co4)(object)Nf2.Default;
		}
		catch
		{
			while (obj3 != null)
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					m0N = null;
				}
			}
		}
		d8B obj20 = (d8B)(object)Nf2.Default;
		d8B = d8B;
		d8B = obj20;
		try
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				_ = (m0N)(object)Nf2.Default;
			}
		}
		catch
		{
			try
			{
				try
				{
					np = (Np8)(object)Nf2.Default;
				}
				finally
				{
					_ = (d4E)(object)Nf2.Default;
					goto end_IL_02a0;
				}
				end_IL_02a0:;
			}
			finally
			{
				do
				{
					f2L obj21 = (f2L)(object)Nf2.Default;
					f2L = null;
					f2L = obj21;
				}
				while ((object)Nf2.Default != null);
				goto end_IL_029f;
			}
			end_IL_029f:;
		}
		try
		{
			try
			{
				pm = pm;
				pm = pm;
				_ = (Pj8)(object)Nf2.Default;
				_ = (Co4)(object)Nf2.Default;
			}
			finally
			{
				_ = (Co4)(object)Nf2.Default;
				goto end_IL_02e5;
			}
			end_IL_02e5:;
		}
		finally
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Pm9)(object)Nf2.Default;
				_ = (r8M)Nf2.Default;
			}
			goto IL_0345;
		}
		IL_0345:
		try
		{
			num = default(UIntPtr);
			if (num == 0)
			{
				d4E = d4E;
				d4E = null;
			}
		}
		catch
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out d1X d1X);
			do
			{
				d1X = d1X;
				d1X = d1X;
			}
			while (obj3 != null);
		}
		do
		{
			try
			{
				try
				{
					f2L = f2L;
					eb = eb;
				}
				catch
				{
					np = np;
				}
			}
			catch
			{
				do
				{
					eb = (Eb1)(object)Nf2.Default;
				}
				while ((object)Nf2.Default != null);
			}
		}
		while (obj3 != null);
		while (true)
		{
			if (obj3 != null)
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					m0N = null;
				}
				else
				{
					gj = gj;
				}
			}
			else if ((object)Nf2.Default == null)
			{
				break;
			}
		}
		try
		{
			while (true)
			{
				if (obj3 != null)
				{
					np = (Np8)(object)Nf2.Default;
				}
				else if ((object)Nf2.Default == null)
				{
					break;
				}
			}
		}
		catch
		{
			d4E = (d4E)(object)Nf2.Default;
			_ = (Np8)(object)Nf2.Default;
			eb = (Eb1)(object)Nf2.Default;
			_ = (x8D9)(object)Nf2.Default;
		}
		try
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out Nf2 nf);
				while ((object)Nf2.Default != null)
				{
					nf = nf;
					nf = null;
				}
			}
			catch
			{
				while (obj3 != null)
				{
					_ = (r8M)Nf2.Default;
					_ = (Mb5)(object)Nf2.Default;
					np = np;
					co = null;
				}
			}
		}
		catch
		{
			do
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					d1X d1X = (d1X)(object)Nf2.Default;
				}
			}
			while (obj3 != null);
		}
		while ((object)Nf2.Default != null)
		{
			if (num == 0)
			{
				_ = (m0N)(object)Nf2.Default;
			}
		}
		if (num == 0)
		{
			try
			{
				try
				{
					_ = Nf2.Default;
				}
				finally
				{
					eb = (Eb1)(object)Nf2.Default;
					goto end_IL_04f5;
				}
				end_IL_04f5:;
			}
			finally
			{
				_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)Nf2.Default;
				_ = (d8B)(object)Nf2.Default;
				goto IL_0530;
			}
		}
		goto IL_0530;
	}
}
