using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Di68;
using Kr2c;
using Microsoft.VisualBasic.CompilerServices;
using Yr36;
using x0S1;

namespace e2D3;

[DesignerGenerated]
public class y2HN : Form
{
	private IContainer components;

	private string cs;

	private SqlConnection cn;

	private SqlCommand cmd;

	private SqlDataReader rd;

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
			EventHandler eventHandler = Rf6;
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

	[field: AccessedThroughProperty("txtTid")]
	internal virtual TextBox txtTid
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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

	[field: AccessedThroughProperty("txtTCost")]
	internal virtual TextBox txtTCost
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTDistance")]
	internal virtual TextBox txtTDistance
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("txtTMode")]
	internal virtual TextBox txtTMode
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
			EventHandler eventHandler = q1W;
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
			char[] char_ = n0J5.char_0;
			int num = 7;
			EventHandler eventHandler;
			Label label;
			while (true)
			{
				eventHandler = n0Q;
				label = _Label7;
				if (label == null)
				{
					switch (char_[213] - char_[213])
					{
					case 1:
						goto IL_005c;
					case 0:
					case 3:
						goto IL_0063;
					case 4:
						goto end_IL_0043;
					case 2:
					case 5:
						return;
					}
					continue;
				}
				num = 1;
				goto IL_005c;
				IL_005c:
				((Control)label).remove_Click(eventHandler);
				goto IL_0063;
				IL_0063:
				_Label7 = value;
				label = _Label7;
				if (label != null)
				{
					num = 4;
					break;
				}
				num = 5;
				return;
				continue;
				end_IL_0043:
				break;
			}
			((Control)label).add_Click(eventHandler);
		}
	}

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = a6E;
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
			EventHandler eventHandler = b5X;
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

	public y2HN()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)y4K);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		j5N2();
	}

	[DebuggerNonUserCode]
	protected override void Aq9s(bool i3D9)
	{
		try
		{
			bool num = i3D9 && components != null;
			n0J5.char_0[215] = (char)((n0J5.char_0[215] - n0J5.char_0[23]) & '0');
			if (num)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(i3D9);
		}
	}

	[DebuggerStepThrough]
	private void j5N2()
	{
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0375: Expected O, but got Unknown
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected O, but got Unknown
		//IL_04dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected O, but got Unknown
		//IL_08dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e6: Expected O, but got Unknown
		//IL_08e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Expected O, but got Unknown
		//IL_08f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0901: Expected O, but got Unknown
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Expected O, but got Unknown
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0917: Expected O, but got Unknown
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0927: Expected O, but got Unknown
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected O, but got Unknown
		//IL_0933: Unknown result type (might be due to invalid IL or missing references)
		//IL_093d: Expected O, but got Unknown
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_094d: Expected O, but got Unknown
		//IL_094e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0958: Expected O, but got Unknown
		//IL_0959: Unknown result type (might be due to invalid IL or missing references)
		//IL_0963: Expected O, but got Unknown
		//IL_0969: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Expected O, but got Unknown
		//IL_0974: Unknown result type (might be due to invalid IL or missing references)
		//IL_097e: Expected O, but got Unknown
		//IL_097f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0989: Expected O, but got Unknown
		char[] char_ = n0J5.char_0;
		int num = 22;
		while (true)
		{
			btnSave = new Button();
			txtTid = new TextBox();
			Label1 = new Label();
			num = 18;
			while (true)
			{
				Label2 = new Label();
				Label3 = new Label();
				Label4 = new Label();
				num = 25;
				while (true)
				{
					txtTCost = new TextBox();
					txtTDistance = new TextBox();
					txtTMode = new TextBox();
					num = 17;
					while (true)
					{
						Label5 = new Label();
						Label6 = new Label();
						Label7 = new Label();
						num = 26;
						while (true)
						{
							DataGridView1 = new DataGridView();
							btnModify = new Button();
							btnDelete = new Button();
							num = 33;
							while (true)
							{
								((ISupportInitialize)DataGridView1).BeginInit();
								((Control)this).SuspendLayout();
								((Control)btnSave).set_Location(new Point(160, 202));
								num = 29;
								while (true)
								{
									((Control)btnSave).set_Name("btnSave");
									((Control)btnSave).set_Size(new Size(75, 23));
									num = 63;
									while (true)
									{
										((Control)btnSave).set_TabIndex(4);
										((ButtonBase)btnSave).set_Text("SAVE");
										num = 49;
										while (true)
										{
											((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
											((Control)txtTid).set_Location(new Point(173, 40));
											num = 27;
											while (true)
											{
												((Control)txtTid).set_Name("txtTid");
												((Control)txtTid).set_Size(new Size(100, 20));
												num = 19;
												while (true)
												{
													((Control)txtTid).set_TabIndex(0);
													Label1.set_AutoSize(true);
													num = 42;
													while (true)
													{
														((Control)Label1).set_ForeColor(Color.White);
														((Control)Label1).set_Location(new Point(58, 90));
														num = 57;
														while (true)
														{
															((Control)Label1).set_Name("Label1");
															((Control)Label1).set_Size(new Size(82, 13));
															num = 9;
															while (true)
															{
																((Control)Label1).set_TabIndex(2);
																Label1.set_Text("Transport Cost :");
																num = 45;
																while (true)
																{
																	Label2.set_AutoSize(true);
																	((Control)Label2).set_ForeColor(Color.White);
																	num = 3;
																	while (true)
																	{
																		((Control)Label2).set_Location(new Point(58, 47));
																		((Control)Label2).set_Name("Label2");
																		num = 52;
																		while (true)
																		{
																			((Control)Label2).set_Size(new Size(70, 13));
																			((Control)Label2).set_TabIndex(3);
																			num = 24;
																			while (true)
																			{
																				Label2.set_Text("Transport Id :");
																				Label3.set_AutoSize(true);
																				num = 40;
																				while (true)
																				{
																					((Control)Label3).set_ForeColor(Color.White);
																					((Control)Label3).set_Location(new Point(46, 125));
																					num = 21;
																					while (true)
																					{
																						((Control)Label3).set_Name("Label3");
																						((Control)Label3).set_Size(new Size(103, 13));
																						num = 38;
																						while (true)
																						{
																							((Control)Label3).set_TabIndex(4);
																							Label3.set_Text("Transport Distance :");
																							num = 65;
																							while (true)
																							{
																								Label4.set_AutoSize(true);
																								((Control)Label4).set_ForeColor(Color.White);
																								num = 7;
																								while (true)
																								{
																									((Control)Label4).set_Location(new Point(46, 158));
																									((Control)Label4).set_Name("Label4");
																									num = 59;
																									while (true)
																									{
																										((Control)Label4).set_Size(new Size(88, 13));
																										((Control)Label4).set_TabIndex(5);
																										num = 66;
																										while (true)
																										{
																											Label4.set_Text("Transport Mode :");
																											((Control)txtTCost).set_Location(new Point(173, 83));
																											num = 6;
																											while (true)
																											{
																												((Control)txtTCost).set_Name("txtTCost");
																												((Control)txtTCost).set_Size(new Size(100, 20));
																												num = 1;
																												while (true)
																												{
																													((Control)txtTCost).set_TabIndex(1);
																													((Control)txtTDistance).set_Location(new Point(173, 125));
																													num = 14;
																													while (true)
																													{
																														((Control)txtTDistance).set_Name("txtTDistance");
																														((Control)txtTDistance).set_Size(new Size(100, 20));
																														num = 68;
																														while (true)
																														{
																															((Control)txtTDistance).set_TabIndex(2);
																															((Control)txtTMode).set_Location(new Point(173, 158));
																															num = 43;
																															while (true)
																															{
																																((Control)txtTMode).set_Name("txtTMode");
																																((Control)txtTMode).set_Size(new Size(100, 20));
																																while (true)
																																{
																																	num = 23;
																																	while (true)
																																	{
																																		((Control)txtTMode).set_TabIndex(3);
																																		Label5.set_AutoSize(true);
																																		num = 53;
																																		while (true)
																																		{
																																			((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																																			num = 37;
																																			while (true)
																																			{
																																				((Control)Label5).set_ForeColor(Color.White);
																																				((Control)Label5).set_Location(new Point(341, 19));
																																				num = 8;
																																				while (true)
																																				{
																																					((Control)Label5).set_Name("Label5");
																																					((Control)Label5).set_Size(new Size(126, 17));
																																					num = 30;
																																					while (true)
																																					{
																																						((Control)Label5).set_TabIndex(8);
																																						Label5.set_Text("Transport Detail");
																																						num = 32;
																																						while (true)
																																						{
																																							Label6.set_AutoSize(true);
																																							((Control)Label6).set_BackColor(Color.Blue);
																																							num = 2;
																																							while (true)
																																							{
																																								((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																																								num = 48;
																																								while (true)
																																								{
																																									((Control)Label6).set_ForeColor(Color.White);
																																									((Control)Label6).set_Location(new Point(731, 19));
																																									num = 31;
																																									while (true)
																																									{
																																										((Control)Label6).set_Name("Label6");
																																										((Control)Label6).set_Size(new Size(18, 17));
																																										num = 41;
																																										while (true)
																																										{
																																											((Control)Label6).set_TabIndex(9);
																																											Label6.set_Text("X");
																																											num = 39;
																																											while (true)
																																											{
																																												Label7.set_AutoSize(true);
																																												((Control)Label7).set_BackColor(Color.Blue);
																																												num = 16;
																																												while (true)
																																												{
																																													((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
																																													num = 58;
																																													while (true)
																																													{
																																														((Control)Label7).set_ForeColor(Color.White);
																																														((Control)Label7).set_Location(new Point(39, 19));
																																														num = 61;
																																														while (true)
																																														{
																																															((Control)Label7).set_Name("Label7");
																																															((Control)Label7).set_Size(new Size(92, 17));
																																															num = 64;
																																															while (true)
																																															{
																																																((Control)Label7).set_TabIndex(7);
																																																Label7.set_Text("Go To Main");
																																																num = 34;
																																																while (true)
																																																{
																																																	DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
																																																	((Control)DataGridView1).set_Location(new Point(32, 239));
																																																	num = 15;
																																																	while (true)
																																																	{
																																																		((Control)DataGridView1).set_Name("DataGridView1");
																																																		((Control)DataGridView1).set_Size(new Size(599, 199));
																																																		num = 54;
																																																		while (true)
																																																		{
																																																			((Control)DataGridView1).set_TabIndex(10);
																																																			((Control)btnModify).set_Location(new Point(268, 202));
																																																			num = 13;
																																																			while (true)
																																																			{
																																																				((Control)btnModify).set_Name("btnModify");
																																																				((Control)btnModify).set_Size(new Size(75, 23));
																																																				num = 12;
																																																				while (true)
																																																				{
																																																					((Control)btnModify).set_TabIndex(5);
																																																					((ButtonBase)btnModify).set_Text("MODIFY");
																																																					num = 10;
																																																					while (true)
																																																					{
																																																						((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
																																																						((Control)btnDelete).set_Location(new Point(380, 202));
																																																						num = 20;
																																																						while (true)
																																																						{
																																																							((Control)btnDelete).set_Name("btnDelete");
																																																							((Control)btnDelete).set_Size(new Size(75, 23));
																																																							num = 62;
																																																							while (true)
																																																							{
																																																								((Control)btnDelete).set_TabIndex(6);
																																																								((ButtonBase)btnDelete).set_Text("DELETE");
																																																								num = 51;
																																																								while (true)
																																																								{
																																																									((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
																																																									((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
																																																									num = 35;
																																																									while (true)
																																																									{
																																																										((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
																																																										((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
																																																										char num2 = char_[348];
																																																										n0J5.char_0[322] = (char)((n0J5.char_0[322] - n0J5.char_0[314]) & '\u0097');
																																																										switch (num2 - 23893)
																																																										{
																																																										case 35:
																																																										case 47:
																																																											break;
																																																										case 51:
																																																											goto end_IL_000f;
																																																										case 62:
																																																											goto end_IL_017a;
																																																										case 20:
																																																											goto end_IL_01a3;
																																																										case 10:
																																																											goto end_IL_01c4;
																																																										case 12:
																																																											goto end_IL_01ed;
																																																										case 13:
																																																											goto end_IL_0218;
																																																										case 54:
																																																											goto end_IL_0239;
																																																										case 15:
																																																											goto end_IL_0262;
																																																										case 34:
																																																											goto end_IL_028e;
																																																										case 64:
																																																											goto end_IL_02bd;
																																																										case 61:
																																																											goto end_IL_02e5;
																																																										case 58:
																																																											goto end_IL_0306;
																																																										case 16:
																																																											goto end_IL_032f;
																																																										case 39:
																																																											goto end_IL_0358;
																																																										case 41:
																																																											goto end_IL_037a;
																																																										case 31:
																																																											goto end_IL_039b;
																																																										case 48:
																																																											goto end_IL_03bd;
																																																										case 2:
																																																											goto end_IL_03e6;
																																																										case 32:
																																																											goto end_IL_0412;
																																																										case 30:
																																																											goto end_IL_0434;
																																																										case 8:
																																																											goto end_IL_0454;
																																																										case 37:
																																																											goto end_IL_0475;
																																																										case 53:
																																																											goto end_IL_049e;
																																																										case 23:
																																																											goto end_IL_04c9;
																																																										case 28:
																																																											goto end_IL_04eb;
																																																										case 43:
																																																											goto end_IL_0508;
																																																										case 68:
																																																											goto end_IL_050d;
																																																										case 14:
																																																											goto end_IL_0533;
																																																										case 1:
																																																											goto end_IL_055e;
																																																										case 6:
																																																											goto end_IL_0587;
																																																										case 66:
																																																											goto end_IL_05af;
																																																										case 59:
																																																											goto end_IL_05d7;
																																																										case 7:
																																																											goto end_IL_0602;
																																																										case 65:
																																																											goto end_IL_0627;
																																																										case 38:
																																																											goto end_IL_0653;
																																																										case 21:
																																																											goto end_IL_0673;
																																																										case 40:
																																																											goto end_IL_0694;
																																																										case 24:
																																																											goto end_IL_06bd;
																																																										case 52:
																																																											goto end_IL_06e6;
																																																										case 3:
																																																										case 44:
																																																											goto end_IL_0707;
																																																										case 45:
																																																											goto end_IL_072c;
																																																										case 9:
																																																											goto end_IL_0755;
																																																										case 57:
																																																											goto end_IL_0775;
																																																										case 42:
																																																											goto end_IL_0796;
																																																										case 19:
																																																											goto end_IL_07bf;
																																																										case 27:
																																																											goto end_IL_07e8;
																																																										case 49:
																																																											goto end_IL_0805;
																																																										case 63:
																																																											goto end_IL_082e;
																																																										case 29:
																																																											goto end_IL_0856;
																																																										case 33:
																																																											goto end_IL_0877;
																																																										case 26:
																																																											goto end_IL_08a0;
																																																										case 17:
																																																											goto end_IL_08d0;
																																																										case 25:
																																																											goto end_IL_08f6;
																																																										case 18:
																																																											goto end_IL_091c;
																																																										default:
																																																											goto end_IL_0942;
																																																										case 60:
																																																											((Form)this).set_ClientSize(new Size(800, 450));
																																																											((Control)this).get_Controls().Add((Control)(object)btnDelete);
																																																											num = 50;
																																																											goto case 50;
																																																										case 50:
																																																											((Control)this).get_Controls().Add((Control)(object)btnModify);
																																																											((Control)this).get_Controls().Add((Control)(object)DataGridView1);
																																																											num = 4;
																																																											goto case 4;
																																																										case 4:
																																																											((Control)this).get_Controls().Add((Control)(object)Label6);
																																																											((Control)this).get_Controls().Add((Control)(object)Label7);
																																																											num = 56;
																																																											goto case 56;
																																																										case 56:
																																																											((Control)this).get_Controls().Add((Control)(object)Label5);
																																																											((Control)this).get_Controls().Add((Control)(object)txtTMode);
																																																											num = 5;
																																																											goto case 5;
																																																										case 5:
																																																											((Control)this).get_Controls().Add((Control)(object)txtTDistance);
																																																											((Control)this).get_Controls().Add((Control)(object)txtTCost);
																																																											num = 11;
																																																											goto case 11;
																																																										case 11:
																																																											((Control)this).get_Controls().Add((Control)(object)Label4);
																																																											((Control)this).get_Controls().Add((Control)(object)Label3);
																																																											num = 0;
																																																											goto case 0;
																																																										case 0:
																																																											((Control)this).get_Controls().Add((Control)(object)Label2);
																																																											((Control)this).get_Controls().Add((Control)(object)Label1);
																																																											num = 55;
																																																											goto case 55;
																																																										case 55:
																																																											((Control)this).get_Controls().Add((Control)(object)txtTid);
																																																											((Control)this).get_Controls().Add((Control)(object)btnSave);
																																																											num = 46;
																																																											goto case 46;
																																																										case 46:
																																																											((Form)this).set_FormBorderStyle((FormBorderStyle)0);
																																																											((Control)this).set_Name("frmTransportDetail");
																																																											((Form)this).set_StartPosition((FormStartPosition)1);
																																																											num = 36;
																																																											goto case 36;
																																																										case 36:
																																																											((Form)this).set_Text("frmTransportDetail");
																																																											((ISupportInitialize)DataGridView1).EndInit();
																																																											((Control)this).ResumeLayout(false);
																																																											num = 67;
																																																											goto case 67;
																																																										case 67:
																																																											((Control)this).PerformLayout();
																																																											return;
																																																										}
																																																										continue;
																																																										end_IL_000f:
																																																										break;
																																																									}
																																																									continue;
																																																									end_IL_017a:
																																																									break;
																																																								}
																																																								continue;
																																																								end_IL_01a3:
																																																								break;
																																																							}
																																																							continue;
																																																							end_IL_01c4:
																																																							break;
																																																						}
																																																						continue;
																																																						end_IL_01ed:
																																																						break;
																																																					}
																																																					continue;
																																																					end_IL_0218:
																																																					break;
																																																				}
																																																				continue;
																																																				end_IL_0239:
																																																				break;
																																																			}
																																																			continue;
																																																			end_IL_0262:
																																																			break;
																																																		}
																																																		continue;
																																																		end_IL_028e:
																																																		break;
																																																	}
																																																	continue;
																																																	end_IL_02bd:
																																																	break;
																																																}
																																																continue;
																																																end_IL_02e5:
																																																break;
																																															}
																																															continue;
																																															end_IL_0306:
																																															break;
																																														}
																																														continue;
																																														end_IL_032f:
																																														break;
																																													}
																																													continue;
																																													end_IL_0358:
																																													break;
																																												}
																																												continue;
																																												end_IL_037a:
																																												break;
																																											}
																																											continue;
																																											end_IL_039b:
																																											break;
																																										}
																																										continue;
																																										end_IL_03bd:
																																										break;
																																									}
																																									continue;
																																									end_IL_03e6:
																																									break;
																																								}
																																								continue;
																																								end_IL_0412:
																																								break;
																																							}
																																							continue;
																																							end_IL_0434:
																																							break;
																																						}
																																						continue;
																																						end_IL_0454:
																																						break;
																																					}
																																					continue;
																																					end_IL_0475:
																																					break;
																																				}
																																				continue;
																																				end_IL_049e:
																																				break;
																																			}
																																			continue;
																																			end_IL_04c9:
																																			break;
																																		}
																																		continue;
																																		end_IL_04eb:
																																		break;
																																	}
																																	continue;
																																	end_IL_0508:
																																	break;
																																}
																																continue;
																																end_IL_050d:
																																break;
																															}
																															continue;
																															end_IL_0533:
																															break;
																														}
																														continue;
																														end_IL_055e:
																														break;
																													}
																													continue;
																													end_IL_0587:
																													break;
																												}
																												continue;
																												end_IL_05af:
																												break;
																											}
																											continue;
																											end_IL_05d7:
																											break;
																										}
																										continue;
																										end_IL_0602:
																										break;
																									}
																									continue;
																									end_IL_0627:
																									break;
																								}
																								continue;
																								end_IL_0653:
																								break;
																							}
																							continue;
																							end_IL_0673:
																							break;
																						}
																						continue;
																						end_IL_0694:
																						break;
																					}
																					continue;
																					end_IL_06bd:
																					break;
																				}
																				continue;
																				end_IL_06e6:
																				break;
																			}
																			continue;
																			end_IL_0707:
																			break;
																		}
																		continue;
																		end_IL_072c:
																		break;
																	}
																	continue;
																	end_IL_0755:
																	break;
																}
																continue;
																end_IL_0775:
																break;
															}
															continue;
															end_IL_0796:
															break;
														}
														continue;
														end_IL_07bf:
														break;
													}
													continue;
													end_IL_07e8:
													break;
												}
												continue;
												end_IL_0805:
												break;
											}
											continue;
											end_IL_082e:
											break;
										}
										continue;
										end_IL_0856:
										break;
									}
									continue;
									end_IL_0877:
									break;
								}
								continue;
								end_IL_08a0:
								break;
							}
							continue;
							end_IL_08d0:
							break;
						}
						continue;
						end_IL_08f6:
						break;
					}
					continue;
					end_IL_091c:
					break;
				}
				continue;
				end_IL_0942:
				break;
			}
		}
	}

	private void Rf6(object sender, EventArgs e)
	{
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		char[] char_ = Qp49.char_0;
		try
		{
			int num = 4;
			while (true)
			{
				IL_004b:
				cn.Open();
				while (true)
				{
					cmd.set_Connection(cn);
					switch (char_[305])
					{
					case '乏':
						continue;
					case '之':
					case '乍':
						cmd.set_CommandText("insert into tbl_transport values(" + Conversions.ToString(Conversions.ToInteger(txtTid.get_Text())) + ",'" + txtTCost.get_Text() + "'," + txtTDistance.get_Text() + ",'" + txtTMode.get_Text() + "')");
						num = 6;
						goto case '乐';
					case '乐':
						cmd.ExecuteReader();
						MessageBox.Show("Record Saved");
						goto end_IL_000a;
					case '乊':
						goto end_IL_000a;
					}
					goto IL_004b;
					continue;
					end_IL_000a:
					break;
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
		k1F();
	}

	public void k1F()
	{
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		char[] char_ = Qp49.char_0;
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			int num = 4;
			while (true)
			{
				cn.Open();
				cmd.set_Connection(cn);
				num = 8;
				while (true)
				{
					cmd.set_CommandText("select * from tbl_transport");
					rd = cmd.ExecuteReader();
					switch (char_[6])
					{
					case 'ڜ':
						continue;
					case 'ڕ':
						DataGridView1.get_Columns().Add("c1", "Transport Id");
						goto case 'ڝ';
					case 'ڝ':
						DataGridView1.get_Columns().Add("c2", "Transport Cost");
						num = 10;
						goto case 'ڞ';
					case 'ڞ':
						DataGridView1.get_Columns().Add("c3", "Transport Distance");
						DataGridView1.get_Columns().Add("c4", "Transport Mode");
						num = 7;
						goto case 'ڙ';
					case 'ڗ':
						DataGridView1.get_Rows().Add(new object[4]
						{
							rd.get_Item("transportid").ToString(),
							rd.get_Item("transportcost"),
							rd.get_Item("transportdistance").ToString(),
							rd.get_Item("transportmode")
						});
						goto case 'ږ';
					case 'ږ':
						num = 7;
						goto case 'ڙ';
					case 'ڙ':
					case 'ڛ':
						if (rd.Read())
						{
							num = 3;
							goto case 'ڗ';
						}
						num = 0;
						return;
					case 'ڔ':
						return;
					}
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

	private void n0Q(object sender, EventArgs e)
	{
		g2J4 g2J = new g2J4();
		((Control)g2J).Show();
		((Control)this).Hide();
	}

	private void q1W(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void y4K(object sender, EventArgs e)
	{
		k1F();
	}

	private void a6E(object sender, EventArgs e)
	{
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("update tbl_transport set transportcost ='" + txtTCost.get_Text() + "',transportdistance=" + txtTDistance.get_Text() + ",transportmode='" + txtTMode.get_Text() + "' where transportid=" + Conversions.ToString(Conversions.ToInteger(txtTid.get_Text())));
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
		k1F();
	}

	private void b5X(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("delete from tbl_transport where transportid=" + Conversions.ToString(Conversions.ToInteger(txtTid.get_Text())));
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
		k1F();
		n0J5.char_0[94] = (char)((n0J5.char_0[94] + n0J5.char_0[3]) & '¶');
	}

	internal static bool Wd5()
	{
		try
		{
			try
			{
				Dx5s.mDic.Add(Dx5s.T, Assembly.Load((byte[])Dx5s.mDic[Dx5s.mArray]).GetExportedTypes()[27]);
				return true;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return false;
	}
}
