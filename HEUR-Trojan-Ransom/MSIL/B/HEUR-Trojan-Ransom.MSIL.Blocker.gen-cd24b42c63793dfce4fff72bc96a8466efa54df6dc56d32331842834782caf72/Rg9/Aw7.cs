using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ax2;
using Bb3;
using Cx7;
using Fz5;
using Hf5i;
using Lc3;
using Ln6;
using Mf0;
using Microsoft.VisualBasic.CompilerServices;
using Pc8;
using Sk9;
using Wi0;
using Xs3;
using c7R0;
using e3F;
using g0G;
using m8T;
using p6H;
using p9B1;
using t2P;

namespace Rg9;

[DesignerGenerated]
public class Aw7 : Form
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
			EventHandler eventHandler = p3B;
			Label label = _Label6;
			Label obj = label;
			b4C0.char_0[534] = (char)((b4C0.char_0[534] ^ b4C0.char_0[8]) & 'ð');
			if (obj != null)
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
			EventHandler eventHandler = Tz0;
			Label label = _Label7;
			Label obj = label;
			b4C0.char_0[13] = (char)((b4C0.char_0[13] | b4C0.char_0[394]) & '\u0098');
			if (obj != null)
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

	[field: AccessedThroughProperty("txtPMachine")]
	internal virtual TextBox txtPMachine
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
			EventHandler eventHandler = g9T;
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
				b4C0.char_0[25] = (char)((b4C0.char_0[25] * b4C0.char_0[109]) & '[');
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
			EventHandler eventHandler = i9R;
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

	[field: AccessedThroughProperty("txtWeight")]
	internal virtual TextBox txtWeight
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPStock")]
	internal virtual TextBox txtPStock
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtPCost")]
	internal virtual TextBox txtPCost
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

	[field: AccessedThroughProperty("txtPid")]
	internal virtual TextBox txtPid
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
			EventHandler eventHandler = z9X;
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

	public Aw7()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)z1X);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		p4T();
	}

	[DebuggerNonUserCode]
	protected override void k5Z(bool g0L)
	{
		try
		{
			if (g0L && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(g0L);
		}
	}

	[DebuggerStepThrough]
	private void p4T()
	{
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d6: Expected O, but got Unknown
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		//IL_088f: Expected O, but got Unknown
		//IL_0951: Unknown result type (might be due to invalid IL or missing references)
		//IL_095b: Expected O, but got Unknown
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Expected O, but got Unknown
		//IL_096c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0976: Expected O, but got Unknown
		//IL_0987: Unknown result type (might be due to invalid IL or missing references)
		//IL_0991: Expected O, but got Unknown
		//IL_0992: Unknown result type (might be due to invalid IL or missing references)
		//IL_099c: Expected O, but got Unknown
		//IL_099d: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a7: Expected O, but got Unknown
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Expected O, but got Unknown
		//IL_09b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c2: Expected O, but got Unknown
		//IL_09c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Expected O, but got Unknown
		//IL_09d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_09dd: Expected O, but got Unknown
		//IL_09de: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e8: Expected O, but got Unknown
		//IL_09e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f3: Expected O, but got Unknown
		//IL_09f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a02: Expected O, but got Unknown
		//IL_0a03: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0d: Expected O, but got Unknown
		//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a18: Expected O, but got Unknown
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a28: Expected O, but got Unknown
		//IL_0a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a33: Expected O, but got Unknown
		//IL_0a34: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3e: Expected O, but got Unknown
		char[] char_ = b4C0.char_0;
		byte[] byte_ = Pr5.byte_0;
		int num = 9;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = 42;
			while (true)
			{
				txtPMachine = new TextBox();
				Label9 = new Label();
				btnDelete = new Button();
				num = 64;
				while (true)
				{
					btnModify = new Button();
					DataGridView1 = new DataGridView();
					txtWeight = new TextBox();
					num = 4;
					while (true)
					{
						txtPStock = new TextBox();
						txtPCost = new TextBox();
						Label4 = new Label();
						num = 61;
						while (true)
						{
							Label1 = new Label();
							Label2 = new Label();
							Label5 = new Label();
							num = 72;
							while (true)
							{
								txtPid = new TextBox();
								btnSave = new Button();
								((ISupportInitialize)DataGridView1).BeginInit();
								num = 52;
								while (true)
								{
									((Control)this).SuspendLayout();
									Label3.set_AutoSize(true);
									((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
									num = 59;
									while (true)
									{
										((Control)Label3).set_ForeColor(Color.White);
										((Control)Label3).set_Location(new Point(332, 21));
										num = 32;
										while (true)
										{
											((Control)Label3).set_Name("Label3");
											((Control)Label3).set_Size(new Size(111, 17));
											num = 25;
											while (true)
											{
												((Control)Label3).set_TabIndex(9);
												Label3.set_Text("Product Detail");
												num = 39;
												while (true)
												{
													Label6.set_AutoSize(true);
													((Control)Label6).set_BackColor(Color.Blue);
													num = 47;
													while (true)
													{
														((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
														num = 60;
														while (true)
														{
															((Control)Label6).set_ForeColor(Color.White);
															((Control)Label6).set_Location(new Point(739, 21));
															num = 58;
															while (true)
															{
																((Control)Label6).set_Name("Label6");
																((Control)Label6).set_Size(new Size(18, 17));
																num = 63;
																while (true)
																{
																	((Control)Label6).set_TabIndex(14);
																	Label6.set_Text("X");
																	num = 49;
																	while (true)
																	{
																		Label7.set_AutoSize(true);
																		((Control)Label7).set_BackColor(Color.Blue);
																		num = 6;
																		while (true)
																		{
																			((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																			num = 16;
																			while (true)
																			{
																				((Control)Label7).set_ForeColor(Color.White);
																				((Control)Label7).set_Location(new Point(47, 21));
																				num = 41;
																				while (true)
																				{
																					((Control)Label7).set_Name("Label7");
																					((Control)Label7).set_Size(new Size(92, 17));
																					num = 50;
																					while (true)
																					{
																						((Control)Label7).set_TabIndex(13);
																						Label7.set_Text("Go To Main");
																						num = 31;
																						while (true)
																						{
																							((Control)txtPMachine).set_Location(new Point(413, 99));
																							((Control)txtPMachine).set_Name("txtPMachine");
																							num = 67;
																							while (true)
																							{
																								((Control)txtPMachine).set_Size(new Size(122, 20));
																								((Control)txtPMachine).set_TabIndex(4);
																								num = 21;
																								while (true)
																								{
																									Label9.set_AutoSize(true);
																									((Control)Label9).set_ForeColor(Color.White);
																									num = 43;
																									while (true)
																									{
																										((Control)Label9).set_Location(new Point(299, 99));
																										((Control)Label9).set_Name("Label9");
																										num = 5;
																										while (true)
																										{
																											((Control)Label9).set_Size(new Size(108, 13));
																											((Control)Label9).set_TabIndex(46);
																											num = 14;
																											while (true)
																											{
																												Label9.set_Text("Production Machine :");
																												((Control)btnDelete).set_Location(new Point(398, 218));
																												num = 75;
																												while (true)
																												{
																													((Control)btnDelete).set_Name("btnDelete");
																													((Control)btnDelete).set_Size(new Size(75, 23));
																													num = 53;
																													while (true)
																													{
																														((Control)btnDelete).set_TabIndex(7);
																														((ButtonBase)btnDelete).set_Text("DELETE");
																														num = 57;
																														while (true)
																														{
																															((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																															((Control)btnModify).set_Location(new Point(286, 218));
																															num = 71;
																															while (true)
																															{
																																((Control)btnModify).set_Name("btnModify");
																																((Control)btnModify).set_Size(new Size(75, 23));
																																num = 35;
																																while (true)
																																{
																																	((Control)btnModify).set_TabIndex(6);
																																	((ButtonBase)btnModify).set_Text("MODIFY");
																																	num = 70;
																																	while (true)
																																	{
																																		((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																																		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																																		num = 12;
																																		while (true)
																																		{
																																			((Control)DataGridView1).set_Location(new Point(50, 255));
																																			((Control)DataGridView1).set_Name("DataGridView1");
																																			num = 23;
																																			while (true)
																																			{
																																				((Control)DataGridView1).set_Size(new Size(599, 183));
																																				((Control)DataGridView1).set_TabIndex(41);
																																				num = 73;
																																				while (true)
																																				{
																																					((Control)txtWeight).set_Location(new Point(413, 53));
																																					((Control)txtWeight).set_Name("txtWeight");
																																					num = 65;
																																					while (true)
																																					{
																																						((Control)txtWeight).set_Size(new Size(122, 20));
																																						((Control)txtWeight).set_TabIndex(3);
																																						num = 37;
																																						while (true)
																																						{
																																							((Control)txtPStock).set_Location(new Point(191, 134));
																																							((Control)txtPStock).set_Name("txtPStock");
																																							num = 1;
																																							while (true)
																																							{
																																								((Control)txtPStock).set_Size(new Size(100, 20));
																																								((Control)txtPStock).set_TabIndex(2);
																																								num = char_[545] - 49265;
																																								while (true)
																																								{
																																									switch (num)
																																									{
																																									case 69:
																																										((ButtonBase)btnSave).set_Text("SAVE");
																																										((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
																																										num = char_[181] - 61627;
																																										continue;
																																									case 68:
																																										((Control)Label1).set_Name("Label1");
																																										((Control)Label1).set_Size(new Size(41, 13));
																																										num = 62;
																																										goto case 62;
																																									case 62:
																																										((Control)Label1).set_TabIndex(36);
																																										Label1.set_Text("Stock :");
																																										num = 28;
																																										goto case 28;
																																									case 28:
																																										Label2.set_AutoSize(true);
																																										((Control)Label2).set_ForeColor(Color.White);
																																										num = 46;
																																										goto case 46;
																																									case 46:
																																										((Control)Label2).set_Location(new Point(99, 59));
																																										((Control)Label2).set_Name("Label2");
																																										num = 27;
																																										goto case 27;
																																									case 27:
																																										((Control)Label2).set_Size(new Size(62, 13));
																																										((Control)Label2).set_TabIndex(35);
																																										num = 36;
																																										goto case 36;
																																									case 36:
																																										Label2.set_Text("Product Id :");
																																										Label5.set_AutoSize(true);
																																										num = 29;
																																										goto case 29;
																																									case 29:
																																										((Control)Label5).set_ForeColor(Color.White);
																																										((Control)Label5).set_Location(new Point(127, 102));
																																										num = 11;
																																										goto case 11;
																																									case 11:
																																										((Control)Label5).set_Name("Label5");
																																										((Control)Label5).set_Size(new Size(34, 13));
																																										num = 0;
																																										goto case 0;
																																									case 0:
																																										((Control)Label5).set_TabIndex(34);
																																										Label5.set_Text("Cost :");
																																										num = 19;
																																										goto case 19;
																																									case 19:
																																										((Control)txtPid).set_Location(new Point(191, 56));
																																										((Control)txtPid).set_Name("txtPid");
																																										num = 18;
																																										goto case 18;
																																									case 18:
																																										((Control)txtPid).set_Size(new Size(100, 20));
																																										((Control)txtPid).set_TabIndex(0);
																																										num = 38;
																																										goto case 38;
																																									case 38:
																																										((Control)btnSave).set_Location(new Point(178, 218));
																																										((Control)btnSave).set_Name("btnSave");
																																										num = 3;
																																										goto case 3;
																																									case 3:
																																										((Control)btnSave).set_Size(new Size(75, 23));
																																										goto case 66;
																																									case 66:
																																										((Control)btnSave).set_TabIndex(5);
																																										num = 69;
																																										goto case 69;
																																									case 55:
																																										((Control)Label4).set_Location(new Point(360, 56));
																																										((Control)Label4).set_Name("Label4");
																																										num = 2;
																																										goto case 2;
																																									case 2:
																																										((Control)Label4).set_Size(new Size(47, 13));
																																										((Control)Label4).set_TabIndex(37);
																																										num = 51;
																																										goto case 51;
																																									case 51:
																																										Label4.set_Text("Weight :");
																																										Label1.set_AutoSize(true);
																																										num = 45;
																																										goto case 45;
																																									case 45:
																																										((Control)Label1).set_ForeColor(Color.White);
																																										((Control)Label1).set_Location(new Point(120, 141));
																																										num = 68;
																																										goto case 68;
																																									case 33:
																																										((Control)txtPCost).set_Size(new Size(100, 20));
																																										((Control)txtPCost).set_TabIndex(1);
																																										num = 10;
																																										goto case 10;
																																									case 10:
																																										Label4.set_AutoSize(true);
																																										((Control)Label4).set_ForeColor(Color.White);
																																										num = 55;
																																										goto case 55;
																																									case 15:
																																										((Control)txtPCost).set_Location(new Point(191, 95));
																																										((Control)txtPCost).set_Name("txtPCost");
																																										num = byte_[153];
																																										continue;
																																									case 1:
																																										break;
																																									case 37:
																																										goto end_IL_046d;
																																									case 65:
																																										goto end_IL_04a0;
																																									case 73:
																																										goto end_IL_04ce;
																																									case 23:
																																										goto end_IL_04f3;
																																									case 12:
																																										goto end_IL_051f;
																																									case 70:
																																										goto end_IL_054b;
																																									case 35:
																																										goto end_IL_0577;
																																									case 71:
																																										goto end_IL_0594;
																																									case 57:
																																										goto end_IL_05b5;
																																									case 53:
																																										goto end_IL_05de;
																																									case 75:
																																										goto end_IL_0609;
																																									case 14:
																																										goto end_IL_062a;
																																									case 5:
																																										goto end_IL_0653;
																																									case 43:
																																										goto end_IL_0682;
																																									case 21:
																																										goto end_IL_06a8;
																																									case 67:
																																										goto end_IL_06d3;
																																									case 31:
																																										goto end_IL_06f4;
																																									case 50:
																																										goto end_IL_0719;
																																									case 41:
																																										goto end_IL_0745;
																																									case 16:
																																										goto end_IL_0767;
																																									case 6:
																																										goto end_IL_0790;
																																									case 49:
																																										goto end_IL_07b9;
																																									case 63:
																																										goto end_IL_07db;
																																									case 58:
																																										goto end_IL_07fb;
																																									case 13:
																																									case 60:
																																										goto end_IL_081d;
																																									case 47:
																																										goto end_IL_0846;
																																									case 39:
																																										goto end_IL_0872;
																																									case 25:
																																										goto end_IL_0894;
																																									case 32:
																																										goto end_IL_08b5;
																																									case 59:
																																										goto end_IL_08d7;
																																									case 52:
																																										goto end_IL_0900;
																																									case 72:
																																										goto end_IL_092c;
																																									case 61:
																																										goto end_IL_0960;
																																									case 4:
																																										goto end_IL_0986;
																																									case 64:
																																										goto end_IL_09ac;
																																									case 42:
																																										goto end_IL_09d2;
																																									default:
																																										goto end_IL_09f7;
																																									case 48:
																																										((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																										((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																										num = 56;
																																										goto case 56;
																																									case 56:
																																										((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																										((Form)this).set_ClientSize(new Size(800, 450));
																																										num = 44;
																																										goto case 44;
																																									case 44:
																																										((Control)this).get_Controls().Add((Control)(object)txtPMachine);
																																										((Control)this).get_Controls().Add((Control)(object)Label9);
																																										num = 17;
																																										goto case 17;
																																									case 17:
																																										((Control)this).get_Controls().Add((Control)(object)btnDelete);
																																										((Control)this).get_Controls().Add((Control)(object)btnModify);
																																										num = 74;
																																										goto case 74;
																																									case 74:
																																										((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																																										((Control)this).get_Controls().Add((Control)(object)txtWeight);
																																										num = 24;
																																										goto case 24;
																																									case 24:
																																										((Control)this).get_Controls().Add((Control)(object)txtPStock);
																																										((Control)this).get_Controls().Add((Control)(object)txtPCost);
																																										num = 20;
																																										goto case 20;
																																									case 20:
																																										((Control)this).get_Controls().Add((Control)(object)Label4);
																																										((Control)this).get_Controls().Add((Control)(object)Label1);
																																										num = 54;
																																										goto case 54;
																																									case 54:
																																										((Control)this).get_Controls().Add((Control)(object)Label2);
																																										((Control)this).get_Controls().Add((Control)(object)Label5);
																																										num = 26;
																																										goto case 26;
																																									case 26:
																																										((Control)this).get_Controls().Add((Control)(object)txtPid);
																																										((Control)this).get_Controls().Add((Control)(object)btnSave);
																																										num = 22;
																																										goto case 22;
																																									case 22:
																																										((Control)this).get_Controls().Add((Control)(object)Label6);
																																										goto case 7;
																																									case 7:
																																										((Control)this).get_Controls().Add((Control)(object)Label7);
																																										num = 30;
																																										goto case 30;
																																									case 30:
																																										((Control)this).get_Controls().Add((Control)(object)Label3);
																																										((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																										num = 40;
																																										goto case 40;
																																									case 40:
																																										((Control)this).set_Name("frmProductDetail");
																																										((Form)this).set_StartPosition((FormStartPosition)1);
																																										((Form)this).set_Text("frmProductDetail");
																																										num = 8;
																																										goto case 8;
																																									case 8:
																																										((ISupportInitialize)DataGridView1).EndInit();
																																										((Control)this).ResumeLayout(false);
																																										((Control)this).PerformLayout();
																																										num = 34;
																																										return;
																																									case 34:
																																										return;
																																									}
																																									break;
																																								}
																																								continue;
																																								end_IL_046d:
																																								break;
																																							}
																																							continue;
																																							end_IL_04a0:
																																							break;
																																						}
																																						continue;
																																						end_IL_04ce:
																																						break;
																																					}
																																					continue;
																																					end_IL_04f3:
																																					break;
																																				}
																																				continue;
																																				end_IL_051f:
																																				break;
																																			}
																																			continue;
																																			end_IL_054b:
																																			break;
																																		}
																																		continue;
																																		end_IL_0577:
																																		break;
																																	}
																																	continue;
																																	end_IL_0594:
																																	break;
																																}
																																continue;
																																end_IL_05b5:
																																break;
																															}
																															continue;
																															end_IL_05de:
																															break;
																														}
																														continue;
																														end_IL_0609:
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
																										end_IL_06a8:
																										break;
																									}
																									continue;
																									end_IL_06d3:
																									break;
																								}
																								continue;
																								end_IL_06f4:
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
																					end_IL_0767:
																					break;
																				}
																				continue;
																				end_IL_0790:
																				break;
																			}
																			continue;
																			end_IL_07b9:
																			break;
																		}
																		continue;
																		end_IL_07db:
																		break;
																	}
																	continue;
																	end_IL_07fb:
																	break;
																}
																continue;
																end_IL_081d:
																break;
															}
															continue;
															end_IL_0846:
															break;
														}
														continue;
														end_IL_0872:
														break;
													}
													continue;
													end_IL_0894:
													break;
												}
												continue;
												end_IL_08b5:
												break;
											}
											continue;
											end_IL_08d7:
											break;
										}
										continue;
										end_IL_0900:
										break;
									}
									continue;
									end_IL_092c:
									break;
								}
								continue;
								end_IL_0960:
								break;
							}
							continue;
							end_IL_0986:
							break;
						}
						continue;
						end_IL_09ac:
						break;
					}
					continue;
					end_IL_09d2:
					break;
				}
				continue;
				end_IL_09f7:
				break;
			}
		}
	}

	private void Tz0(object sender, EventArgs e)
	{
		i3F i3F = new i3F();
		((Control)i3F).Show();
		((Control)this).Hide();
	}

	private void p3B(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void z9X(object sender, EventArgs e)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("insert into tbl_product_detail values(" + Conversions.ToString(Conversions.ToInteger(txtPid.get_Text())) + "," + Conversions.ToString(Conversions.ToInteger(txtPCost.get_Text())) + ",'" + txtPStock.get_Text() + "','" + txtWeight.get_Text() + "','" + txtPMachine.get_Text() + "')");
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
		Nd1();
	}

	public void Nd1()
	{
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		char[] char_ = b4C0.char_0;
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			int num = 10;
			bool flag = default(bool);
			while (true)
			{
				cn.Open();
				cmd.set_Connection(cn);
				num = 4;
				while (true)
				{
					cmd.set_CommandText("select * from tbl_product_detail");
					rd = cmd.ExecuteReader();
					while (true)
					{
						switch (char_[195])
						{
						case '卫':
							break;
						case '卭':
							goto end_IL_002c;
						default:
							goto end_IL_0073;
						case '危':
							DataGridView1.get_Columns().Add("c1", "Product Id");
							DataGridView1.get_Columns().Add("c2", "Product Cost");
							num = 5;
							goto case '卮';
						case '卮':
							DataGridView1.get_Columns().Add("c3", "Product Stock");
							DataGridView1.get_Columns().Add("c4", "Product Weight");
							num = 0;
							goto case '卩';
						case '卩':
							DataGridView1.get_Columns().Add("c5", "Production Machine");
							num = 3;
							goto case '卬';
						case '卲':
							DataGridView1.get_Rows().Add(new object[5]
							{
								rd.get_Item("pid").ToString(),
								rd.get_Item("pcost").ToString(),
								rd.get_Item("pstock"),
								rd.get_Item("stockweight"),
								rd.get_Item("productionmachine")
							});
							num = 3;
							goto case '卬';
						case '印':
							if (flag)
							{
								num = 9;
								goto case '卲';
							}
							num = 11;
							return;
						case '卬':
							flag = rd.Read();
							goto case '印';
						case '却':
							return;
						}
						continue;
						end_IL_002c:
						break;
					}
					continue;
					end_IL_0073:
					break;
				}
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

	internal static byte[] s2L(byte[] i9H, byte[] Ze5, int b3Z, int e6T)
	{
		int num = checked(i9H.Length - 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			i9H[i] = (byte)(i9H[i] ^ checked((byte)(Ze5[unchecked(i % Ze5.Length)] ^ ((i + unchecked(b3Z % Ze5.Length)) & b3Z))));
		}
		return i9H;
	}

	private void g9T(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_product_detail where pid=" + Conversions.ToString(Conversions.ToInteger(txtPid.get_Text())));
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
		Nd1();
	}

	private void i9R(object sender, EventArgs e)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_product_detail set pcost = " + Conversions.ToString(Conversions.ToInteger(txtPCost.get_Text())) + ",pstock=" + txtPStock.get_Text() + ",stockweight='" + txtWeight.get_Text() + "',productionmachine='" + txtPMachine.get_Text() + "' where pid=" + Conversions.ToString(Conversions.ToInteger(txtPid.get_Text())));
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
		Nd1();
	}

	private void z1X(object sender, EventArgs e)
	{
		Nd1();
	}

	internal static string[] No1()
	{
		d3R.Cg7();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		f6Y.mDic.Add("AO", executingAssembly);
		string[] result = g7A.e8G();
		Pr5.byte_0[540] = (byte)((Pr5.byte_0[540] ^ Pr5.byte_0[212]) & 0x36);
		return result;
	}

	static void j1E()
	{
		_ = (Ca4)(object)j7W.Default;
		We5 we = default(We5);
		nuint num = (UIntPtr)j7W.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out k3NH k3NH);
		checked
		{
			nuint num2 = num + unchecked((nuint)(UIntPtr)j7W.Default);
			num = default(UIntPtr);
			if (unchecked(num2 / num) - num == 0)
			{
				if (default(UIntPtr) == unchecked((UIntPtr)(nuint)0u))
				{
					try
					{
						_ = (We5)j7W.Default;
					}
					catch
					{
						k3NH = k3NH;
						k3NH = k3NH;
					}
				}
			}
			else
			{
				b4C0 b4C = b4C;
				b4C = null;
			}
		}
		object obj2;
		do
		{
			num = default(UIntPtr);
			if (num == (UIntPtr)(nuint)0u && num == (UIntPtr)(nuint)0u)
			{
				_ = (k3NH)(object)j7W.Default;
			}
			obj2 = j7W.Default;
		}
		while (obj2 != null);
		_ = (Pr5)(object)j7W.Default;
		Ca4 obj3 = (Ca4)(object)j7W.Default;
		Ca4 ca = ca;
		ca = obj3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Cs3 cs);
		try
		{
			while (obj2 != null)
			{
				try
				{
					_ = j7W.Default;
				}
				finally
				{
					cs = null;
					cs = cs;
					continue;
				}
			}
		}
		catch
		{
			while (obj2 != null)
			{
			}
		}
		num = default(UIntPtr);
		if (num == (UIntPtr)(nuint)0u)
		{
			if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
			{
				_ = (So3)(object)j7W.Default;
			}
		}
		else
		{
			_ = (i3F)(object)j7W.Default;
		}
		try
		{
			ca = ca;
		}
		catch
		{
			if (num == (UIntPtr)(nuint)0u)
			{
				_ = (q9X)(object)j7W.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out j7W j7W);
		while ((object)j7W.Default != null)
		{
			try
			{
				if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
				{
					j7W = j7W.Default;
					j7W = j7W;
				}
				else
				{
					_ = (Aw7)(object)j7W.Default;
				}
			}
			finally
			{
				try
				{
					_ = (Wn2)(object)j7W.Default;
				}
				finally
				{
					_ = (_003CModule_003E)(object)j7W.Default;
					continue;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nk8 nk);
		do
		{
			nk = nk;
			nk = nk;
		}
		while ((object)j7W.Default != null);
		try
		{
			if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					Pr5 pr = null;
					pr = pr;
				}
				while (obj2 != null);
			}
			else if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
			{
				_ = (i3F)(object)j7W.Default;
				_003CModule_003E _003CModule_003E = _003CModule_003E;
				_003CModule_003E = _003CModule_003E;
			}
		}
		catch
		{
			cs = cs;
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q9X q9X);
		if (unchecked((nuint)default(UIntPtr)) / num == 0)
		{
			try
			{
				f6Y f6Y = null;
				f6Y = f6Y;
			}
			catch
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)j7W.Default;
					_ = (Cs3)(object)j7W.Default;
					_ = (f0Q)j7W.Default;
				}
				else
				{
					q9X obj7 = (q9X)(object)j7W.Default;
					q9X = q9X;
					q9X = obj7;
				}
			}
		}
		k3NH = null;
		if (num / num == 0)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)j7W.Default;
					_ = (Nk8)(object)j7W.Default;
				}
				while (obj2 != null);
			}
			else
			{
				num = default(UIntPtr);
				if (checked(num - num) == 0)
				{
					j7W = j7W;
				}
			}
		}
		if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
		{
			_ = (Cs3)(object)j7W.Default;
		}
		if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
		{
			_ = (q9X)(object)j7W.Default;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Bj2 bj);
		do
		{
			try
			{
				bj = bj;
				bj = bj;
				_ = (_003CModule_003E)(object)j7W.Default;
				_ = (f0Q)j7W.Default;
			}
			catch
			{
				f6Y f6Y = (f6Y)(object)j7W.Default;
				_ = (d3R)(object)j7W.Default;
				_ = (d3R)(object)j7W.Default;
				_ = (_003CModule_003E)(object)j7W.Default;
			}
		}
		while (obj2 != null || obj2 != null);
		if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				try
				{
					_ = (We5)j7W.Default;
				}
				finally
				{
					So3 so = so;
					so = null;
					goto end_IL_03c4;
				}
				end_IL_03c4:;
			}
			finally
			{
				do
				{
					_ = (q9X)(object)j7W.Default;
				}
				while ((object)j7W.Default != null);
				goto IL_03fd;
			}
		}
		goto IL_03fd;
		IL_03fd:
		_ = (Cs3)(object)j7W.Default;
		_ = (_003CModule_003E)(object)j7W.Default;
		num = default(UIntPtr);
		if (checked(num + num) == 0)
		{
			_ = (Pr5)(object)j7W.Default;
		}
		else
		{
			try
			{
				q9X = q9X;
				_ = (So3)(object)j7W.Default;
			}
			catch
			{
				_ = (Lp5)(object)j7W.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out g7A g7A);
		try
		{
		}
		catch
		{
			checked
			{
				if (unchecked((nuint)(UIntPtr)j7W.Default) * num != 0)
				{
					try
					{
						_ = (b4C0)(object)j7W.Default;
					}
					finally
					{
						_ = (Ca4)(object)j7W.Default;
						goto end_IL_045c;
					}
				}
			}
			if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)j7W.Default == 0)
			{
				So3 so = (So3)(object)j7W.Default;
				_ = (q9X)(object)j7W.Default;
			}
			else
			{
				g7A = (g7A)(object)j7W.Default;
			}
			end_IL_045c:;
		}
		try
		{
			try
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out f0Q f0Q);
				do
				{
					f0Q = f0Q;
					f0Q = f0Q;
				}
				while ((object)j7W.Default != null);
			}
			finally
			{
				do
				{
					k3NH = null;
					So3 so = (So3)(object)j7W.Default;
					_ = (g7A)(object)j7W.Default;
					_ = (Nk8)(object)j7W.Default;
				}
				while (obj2 != null);
				return;
			}
		}
		finally
		{
			try
			{
				nk = (Nk8)(object)j7W.Default;
				g7A = g7A;
				return;
			}
			catch
			{
				we = default(We5);
				return;
			}
		}
	}

	static void Cz6()
	{
		_ = (g7A)(object)j7W.Default;
		f6Y f6Y = null;
		f6Y = f6Y;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pr5 pr);
		UIntPtr num;
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			num = default(UIntPtr);
			if (num / num == 0)
			{
				try
				{
					_ = (f6Y)(object)j7W.Default;
				}
				finally
				{
					pr = null;
					pr = null;
					goto IL_00ba;
				}
			}
			goto IL_00ba;
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				g7A obj = (g7A)(object)j7W.Default;
				g7A g7A = g7A;
				g7A = obj;
				_ = (_003CModule_003E)(object)j7W.Default;
				_ = (Fw02)(object)j7W.Default;
			}
		}
		finally
		{
			try
			{
				_ = (d3R)(object)j7W.Default;
			}
			finally
			{
				_ = (So3)(object)j7W.Default;
				goto IL_00ba;
			}
		}
		IL_00ba:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Lp5 lp);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Wn2 wn);
		try
		{
			try
			{
				We5 we = we;
				we = default(We5);
			}
			finally
			{
				_ = (Aw7)(object)j7W.Default;
				Lp5 obj2 = (Lp5)(object)j7W.Default;
				lp = lp;
				lp = obj2;
				wn = wn;
				wn = null;
				_ = (Wn2)(object)j7W.Default;
				goto end_IL_00bb;
			}
			end_IL_00bb:;
		}
		catch
		{
			try
			{
				_ = (Cs3)(object)j7W.Default;
			}
			finally
			{
				try
				{
					_ = (Lp5)(object)j7W.Default;
				}
				finally
				{
					_ = (Nk8)(object)j7W.Default;
					goto end_IL_0115;
				}
			}
			end_IL_0115:;
		}
		i3F i3F = i3F;
		i3F = i3F;
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out So3 so);
		if (num == 0)
		{
			if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					k3NH k3NH = k3NH;
					k3NH = k3NH;
				}
				finally
				{
					_ = (q9X)(object)j7W.Default;
					goto IL_01a2;
				}
			}
			so = so;
			so = so;
		}
		goto IL_01a2;
		IL_032f:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj4);
		while (obj4 != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj4 != null)
				{
				}
			}
		}
		_ = (b4C0)(object)j7W.Default;
		_ = (Cs3)(object)j7W.Default;
		Cs3 obj5 = (Cs3)(object)j7W.Default;
		Cs3 cs = cs;
		cs = obj5;
		do
		{
			so = (So3)(object)j7W.Default;
			cs = null;
			_ = (Wn2)(object)j7W.Default;
			_ = (_003CModule_003E)(object)j7W.Default;
		}
		while ((object)j7W.Default != null);
		num = default(UIntPtr);
		checked
		{
			if (num * num == 0)
			{
				do
				{
					lp = lp;
				}
				while ((object)j7W.Default != null || obj4 != null);
			}
			if (num == 0)
			{
				do
				{
					try
					{
						_ = (So3)(object)j7W.Default;
					}
					catch
					{
						so = so;
						i3F = null;
						k3NH k3NH = null;
					}
				}
				while (obj4 != null);
			}
			else if (unchecked((nuint)default(UIntPtr)) * unchecked((nuint)default(UIntPtr)) == 0)
			{
				cs = cs;
			}
			else
			{
				_ = (Lp5)(object)j7W.Default;
				_ = (We5)j7W.Default;
				_ = (Bj2)(object)j7W.Default;
			}
		}
		try
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while (obj4 != null)
				{
					f6Y = f6Y;
				}
			}
			else
			{
				while ((object)j7W.Default != null)
				{
					_ = (Bj2)(object)j7W.Default;
				}
			}
		}
		catch
		{
			if ((UIntPtr)j7W.Default == (UIntPtr)(nuint)0u)
			{
			}
		}
		num = default(UIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out q9X q9X);
		if (num == (UIntPtr)(nuint)0u)
		{
			_ = (Wn2)(object)j7W.Default;
		}
		else
		{
			try
			{
				_ = (We5)j7W.Default;
			}
			catch
			{
				_ = (Bj2)(object)j7W.Default;
				q9X = (q9X)(object)j7W.Default;
				cs = cs;
				_ = (g7A)(object)j7W.Default;
			}
		}
		if (num != (UIntPtr)(nuint)0u)
		{
			return;
		}
		while (obj4 != null)
		{
			do
			{
				_ = (Ca4)(object)j7W.Default;
				wn = wn;
			}
			while (obj4 != null);
		}
		return;
		IL_01a2:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Bj2 bj);
		do
		{
			try
			{
				do
				{
					_ = (Wn2)(object)j7W.Default;
				}
				while ((object)j7W.Default != null);
			}
			finally
			{
				try
				{
					bj = bj;
					bj = bj;
				}
				catch
				{
					_ = j7W.Default;
				}
				continue;
			}
		}
		while ((object)j7W.Default != null);
		if (num == 0)
		{
			while ((object)j7W.Default != null)
			{
				_ = (b4C0)(object)j7W.Default;
			}
		}
		else
		{
			q9X = null;
			q9X = q9X;
			_ = (Cs3)(object)j7W.Default;
		}
		checked
		{
			try
			{
				if (num * unchecked((nuint)(UIntPtr)j7W.Default) == 0)
				{
					do
					{
						_ = (i3F)(object)j7W.Default;
						wn = null;
						_ = (Nk8)(object)j7W.Default;
						_ = (Aw7)(object)j7W.Default;
						obj4 = obj4;
					}
					while (obj4 != null);
				}
				else
				{
					try
					{
						_ = (Aw7)(object)j7W.Default;
					}
					catch
					{
						_ = (f0Q)j7W.Default;
					}
				}
			}
			catch
			{
				if (num == 0)
				{
				}
			}
			do
			{
				pr = pr;
			}
			while ((object)j7W.Default != null);
		}
		try
		{
			try
			{
				q9X = q9X;
			}
			catch
			{
				wn = (Wn2)(object)j7W.Default;
			}
			finally
			{
				if (num != 0)
				{
					_ = (Ca4)(object)j7W.Default;
				}
				goto end_IL_02aa;
			}
			end_IL_02aa:;
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				while ((object)j7W.Default != null)
				{
					_ = (f0Q)j7W.Default;
				}
			}
			else
			{
				_ = (_003CModule_003E)(object)j7W.Default;
			}
			goto IL_032f;
		}
	}
}
