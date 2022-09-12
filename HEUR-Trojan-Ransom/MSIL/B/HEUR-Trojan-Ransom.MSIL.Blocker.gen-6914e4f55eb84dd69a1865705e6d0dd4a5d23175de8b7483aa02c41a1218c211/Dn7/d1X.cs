using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Bx3;
using Dy1a;
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

namespace Dn7;

[DesignerGenerated]
public class d1X : Form
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
			char[] char_ = Mb5.char_0;
			int num = 7;
			EventHandler eventHandler;
			Label label;
			while (true)
			{
				eventHandler = Gr86;
				label = _Label6;
				if (label == null)
				{
					num = 4;
					goto IL_004a;
				}
				num = char_[197] - 48216;
				goto IL_001b;
				IL_004a:
				_Label6 = value;
				label = _Label6;
				Label obj = label;
				Pj8.byte_0[36] = (byte)(Pj8.byte_0[36] & Mb5.char_0[62] & 0x6F);
				if (obj == null)
				{
					num = char_[45] - 15029;
					goto IL_001b;
				}
				num = 0;
				break;
				IL_001b:
				switch (num)
				{
				case 5:
					((Control)label).remove_Click(eventHandler);
					break;
				case 4:
					break;
				default:
					continue;
				case 0:
				case 3:
					goto end_IL_008a;
				case 2:
				case 6:
					return;
				}
				goto IL_004a;
				continue;
				end_IL_008a:
				break;
			}
			((Control)label).add_Click(eventHandler);
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
			char[] char_ = Mb5.char_0;
			int num = 6;
			while (true)
			{
				EventHandler eventHandler = p5A7;
				while (true)
				{
					Label label = _Label7;
					if (label != null)
					{
						switch (char_[124] - char_[124])
						{
						case 2:
						case 5:
							break;
						default:
							goto end_IL_003f;
						case 0:
							((Control)label).remove_Click(eventHandler);
							goto IL_0065;
						case 7:
							goto IL_0065;
						case 3:
							goto IL_0078;
						case 4:
							return;
						}
						continue;
					}
					num = 7;
					goto IL_0065;
					IL_0065:
					_Label7 = value;
					label = _Label7;
					if (label != null)
					{
						num = 3;
						goto IL_0078;
					}
					num = 4;
					return;
					IL_0078:
					((Control)label).add_Click(eventHandler);
					return;
					continue;
					end_IL_003f:
					break;
				}
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
			EventHandler eventHandler = Es71;
			Button val = _btnDelete;
			Button obj = val;
			Mb5.char_0[119] = (char)((Mb5.char_0[119] * Mb5.char_0[129]) & '\u0093');
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
			EventHandler eventHandler = Aq74;
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
			char[] char_ = Mb5.char_0;
			int num = 1;
			while (true)
			{
				IL_0066:
				EventHandler eventHandler = Qx6c;
				Button val = _btnSave;
				if (val == null)
				{
					num = 3;
					goto IL_0052;
				}
				num = 2;
				goto IL_004b;
				IL_0052:
				while (true)
				{
					IL_0052_2:
					_btnSave = value;
					val = _btnSave;
					while (true)
					{
						if (val == null)
						{
							switch (char_[185])
							{
							case '읡':
								break;
							case '읟':
								goto end_IL_0046;
							case '읠':
							case '읣':
								goto IL_0052_2;
							default:
								goto IL_0066;
							case '읤':
								goto IL_0081;
							case '읝':
							case '읢':
								return;
							}
							continue;
						}
						num = 7;
						goto IL_0081;
						IL_0081:
						((Control)val).add_Click(eventHandler);
						return;
						continue;
						end_IL_0046:
						break;
					}
					break;
				}
				goto IL_004b;
				IL_004b:
				((Control)val).remove_Click(eventHandler);
				goto IL_0052;
			}
		}
	}

	public d1X()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)f1CY);
		cs = "Data Source=DESKTOP-1L8UME0\\SQLEXPRESS;Initial Catalog=db_fabric;Integrated Security=True";
		cn = new SqlConnection(cs);
		cmd = new SqlCommand();
		t9R();
	}

	[DebuggerNonUserCode]
	protected override void Wy6(bool Mo4)
	{
		try
		{
			if (Mo4 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Mo4);
		}
	}

	[DebuggerStepThrough]
	private void t9R()
	{
		//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bb: Expected O, but got Unknown
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected O, but got Unknown
		//IL_0807: Unknown result type (might be due to invalid IL or missing references)
		//IL_0811: Expected O, but got Unknown
		//IL_0812: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Expected O, but got Unknown
		//IL_081d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0827: Expected O, but got Unknown
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0835: Expected O, but got Unknown
		//IL_0836: Unknown result type (might be due to invalid IL or missing references)
		//IL_0840: Expected O, but got Unknown
		//IL_0841: Unknown result type (might be due to invalid IL or missing references)
		//IL_084b: Expected O, but got Unknown
		//IL_084f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected O, but got Unknown
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Expected O, but got Unknown
		//IL_0865: Unknown result type (might be due to invalid IL or missing references)
		//IL_086f: Expected O, but got Unknown
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_087d: Expected O, but got Unknown
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Expected O, but got Unknown
		//IL_08bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c5: Expected O, but got Unknown
		//IL_09c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cc: Expected O, but got Unknown
		//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Expected O, but got Unknown
		//IL_09d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e2: Expected O, but got Unknown
		//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2b: Expected O, but got Unknown
		//IL_0b2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b36: Expected O, but got Unknown
		//IL_0b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b41: Expected O, but got Unknown
		char[] char_ = Mb5.char_0;
		byte[] byte_ = Pj8.byte_0;
		int num = 34;
		while (true)
		{
			Label3 = new Label();
			Label6 = new Label();
			Label7 = new Label();
			num = char_[71] - 22425;
			while (true)
			{
				switch (num)
				{
				case 75:
					Label2.set_AutoSize(true);
					((Control)Label2).set_ForeColor(Color.White);
					num = 61;
					goto case 61;
				case 61:
					((Control)Label2).set_Location(new Point(99, 59));
					((Control)Label2).set_Name("Label2");
					num = 59;
					goto case 59;
				case 59:
					((Control)Label2).set_Size(new Size(62, 13));
					((Control)Label2).set_TabIndex(35);
					num = 45;
					goto case 45;
				case 45:
					Label2.set_Text("Product Id :");
					Label5.set_AutoSize(true);
					num = 57;
					goto case 57;
				case 57:
					((Control)Label5).set_ForeColor(Color.White);
					((Control)Label5).set_Location(new Point(127, 102));
					num = 2;
					goto case 2;
				case 2:
					((Control)Label5).set_Name("Label5");
					((Control)Label5).set_Size(new Size(34, 13));
					num = 12;
					goto case 12;
				case 12:
					((Control)Label5).set_TabIndex(34);
					Label5.set_Text("Cost :");
					num = 27;
					goto case 27;
				case 27:
					((Control)txtPid).set_Location(new Point(191, 56));
					((Control)txtPid).set_Name("txtPid");
					num = 3;
					goto case 3;
				case 3:
					((Control)txtPid).set_Size(new Size(100, 20));
					((Control)txtPid).set_TabIndex(0);
					num = 64;
					goto case 64;
				case 64:
					((Control)btnSave).set_Location(new Point(178, 218));
					((Control)btnSave).set_Name("btnSave");
					num = 73;
					goto case 73;
				case 73:
					((Control)btnSave).set_Size(new Size(75, 23));
					((Control)btnSave).set_TabIndex(5);
					num = 31;
					goto case 31;
				case 31:
					((ButtonBase)btnSave).set_Text("SAVE");
					((ButtonBase)btnSave).set_UseVisualStyleBackColor(true);
					num = 22;
					goto case 22;
				case 22:
					((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
					((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
					num = 36;
					goto case 36;
				case 36:
					((Form)this).set_BackColor(Color.FromArgb(0, 0, 64));
					((Form)this).set_ClientSize(new Size(800, 450));
					num = 55;
					goto case 55;
				case 55:
					((Control)this).get_Controls().Add((Control)(object)txtPMachine);
					((Control)this).get_Controls().Add((Control)(object)Label9);
					num = char_[42] - 1377;
					continue;
				case 72:
					((Control)Label7).set_ForeColor(Color.White);
					((Control)Label7).set_Location(new Point(47, 21));
					num = 54;
					goto case 54;
				case 54:
					((Control)Label7).set_Name("Label7");
					((Control)Label7).set_Size(new Size(92, 17));
					num = 11;
					goto case 11;
				case 11:
					((Control)Label7).set_TabIndex(13);
					Label7.set_Text("Go To Main");
					num = 29;
					goto case 29;
				case 29:
					((Control)txtPMachine).set_Location(new Point(413, 99));
					((Control)txtPMachine).set_Name("txtPMachine");
					num = 18;
					goto case 18;
				case 18:
					((Control)txtPMachine).set_Size(new Size(122, 20));
					((Control)txtPMachine).set_TabIndex(4);
					num = 32;
					goto case 32;
				case 32:
					Label9.set_AutoSize(true);
					((Control)Label9).set_ForeColor(Color.White);
					num = 37;
					goto case 37;
				case 37:
					((Control)Label9).set_Location(new Point(299, 99));
					((Control)Label9).set_Name("Label9");
					num = 38;
					goto case 38;
				case 38:
					((Control)Label9).set_Size(new Size(108, 13));
					((Control)Label9).set_TabIndex(46);
					num = 68;
					goto case 68;
				case 68:
					Label9.set_Text("Production Machine :");
					((Control)btnDelete).set_Location(new Point(398, 218));
					num = 6;
					goto case 6;
				case 6:
					((Control)btnDelete).set_Name("btnDelete");
					((Control)btnDelete).set_Size(new Size(75, 23));
					num = 62;
					goto case 62;
				case 62:
					((Control)btnDelete).set_TabIndex(7);
					((ButtonBase)btnDelete).set_Text("DELETE");
					num = 47;
					goto case 47;
				case 47:
					((ButtonBase)btnDelete).set_UseVisualStyleBackColor(true);
					((Control)btnModify).set_Location(new Point(286, 218));
					num = 19;
					goto case 19;
				case 19:
					((Control)btnModify).set_Name("btnModify");
					((Control)btnModify).set_Size(new Size(75, 23));
					num = 21;
					goto case 21;
				case 21:
					((Control)btnModify).set_TabIndex(6);
					((ButtonBase)btnModify).set_Text("MODIFY");
					num = 66;
					goto case 66;
				case 66:
					((ButtonBase)btnModify).set_UseVisualStyleBackColor(true);
					DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
					num = 46;
					goto case 46;
				case 46:
					((Control)DataGridView1).set_Location(new Point(50, 255));
					((Control)DataGridView1).set_Name("DataGridView1");
					num = 43;
					goto case 43;
				case 43:
					((Control)DataGridView1).set_Size(new Size(599, 183));
					((Control)DataGridView1).set_TabIndex(41);
					num = 10;
					goto case 10;
				case 10:
					((Control)txtWeight).set_Location(new Point(413, 53));
					((Control)txtWeight).set_Name("txtWeight");
					num = 4;
					goto case 4;
				case 4:
					((Control)txtWeight).set_Size(new Size(122, 20));
					((Control)txtWeight).set_TabIndex(3);
					num = 25;
					goto case 25;
				case 25:
					((Control)txtPStock).set_Location(new Point(191, 134));
					((Control)txtPStock).set_Name("txtPStock");
					num = 1;
					goto case 1;
				case 1:
					((Control)txtPStock).set_Size(new Size(100, 20));
					((Control)txtPStock).set_TabIndex(2);
					num = 60;
					goto case 60;
				case 60:
					((Control)txtPCost).set_Location(new Point(191, 95));
					((Control)txtPCost).set_Name("txtPCost");
					num = 20;
					goto case 20;
				case 20:
					((Control)txtPCost).set_Size(new Size(100, 20));
					((Control)txtPCost).set_TabIndex(1);
					num = 39;
					goto case 39;
				case 39:
					Label4.set_AutoSize(true);
					((Control)Label4).set_ForeColor(Color.White);
					num = 9;
					goto case 9;
				case 9:
					((Control)Label4).set_Location(new Point(360, 56));
					((Control)Label4).set_Name("Label4");
					num = 42;
					goto case 42;
				case 42:
					((Control)Label4).set_Size(new Size(47, 13));
					((Control)Label4).set_TabIndex(37);
					num = 67;
					goto case 67;
				case 67:
					Label4.set_Text("Weight :");
					Label1.set_AutoSize(true);
					num = 44;
					goto case 44;
				case 44:
					((Control)Label1).set_ForeColor(Color.White);
					((Control)Label1).set_Location(new Point(120, 141));
					num = 5;
					goto case 5;
				case 5:
					((Control)Label1).set_Name("Label1");
					((Control)Label1).set_Size(new Size(41, 13));
					num = 65;
					goto case 65;
				case 65:
					((Control)Label1).set_TabIndex(36);
					Label1.set_Text("Stock :");
					num = 75;
					goto case 75;
				case 71:
					((Control)Label7).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = 72;
					goto case 72;
				case 70:
					((Control)Label3).set_ForeColor(Color.White);
					((Control)Label3).set_Location(new Point(332, 21));
					num = 7;
					goto case 7;
				case 7:
					((Control)Label3).set_Name("Label3");
					((Control)Label3).set_Size(new Size(111, 17));
					num = 14;
					goto case 13;
				case 13:
				case 14:
					((Control)Label3).set_TabIndex(9);
					Label3.set_Text("Product Detail");
					num = 56;
					goto case 56;
				case 56:
					Label6.set_AutoSize(true);
					((Control)Label6).set_BackColor(Color.Blue);
					num = 15;
					goto case 15;
				case 15:
					((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = 63;
					goto case 63;
				case 63:
					((Control)Label6).set_ForeColor(Color.White);
					((Control)Label6).set_Location(new Point(739, 21));
					num = 0;
					goto case 0;
				case 0:
					((Control)Label6).set_Name("Label6");
					((Control)Label6).set_Size(new Size(18, 17));
					num = 35;
					goto case 35;
				case 35:
					((Control)Label6).set_TabIndex(14);
					Label6.set_Text("X");
					num = 53;
					goto case 53;
				case 53:
				case 58:
					Label7.set_AutoSize(true);
					((Control)Label7).set_BackColor(Color.Blue);
					num = 71;
					goto case 71;
				case 69:
					btnModify = new Button();
					DataGridView1 = new DataGridView();
					txtWeight = new TextBox();
					num = 23;
					goto case 23;
				case 23:
					txtPStock = new TextBox();
					txtPCost = new TextBox();
					goto case 33;
				case 33:
					Label4 = new Label();
					num = 28;
					goto case 28;
				case 28:
					Label1 = new Label();
					Label2 = new Label();
					Label5 = new Label();
					num = 16;
					goto case 16;
				case 16:
					txtPid = new TextBox();
					btnSave = new Button();
					((ISupportInitialize)DataGridView1).BeginInit();
					num = 26;
					goto case 26;
				case 26:
					((Control)this).SuspendLayout();
					Label3.set_AutoSize(true);
					((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
					num = 70;
					goto case 70;
				case 52:
					((Control)this).get_Controls().Add((Control)(object)Label4);
					((Control)this).get_Controls().Add((Control)(object)Label1);
					num = 41;
					goto case 41;
				case 41:
					((Control)this).get_Controls().Add((Control)(object)Label2);
					((Control)this).get_Controls().Add((Control)(object)Label5);
					num = 30;
					goto case 30;
				case 30:
					((Control)this).get_Controls().Add((Control)(object)txtPid);
					((Control)this).get_Controls().Add((Control)(object)btnSave);
					num = byte_[396] - 194;
					continue;
				case 50:
					((Control)this).get_Controls().Add((Control)(object)DataGridView1);
					((Control)this).get_Controls().Add((Control)(object)txtWeight);
					num = 8;
					goto case 8;
				case 8:
					((Control)this).get_Controls().Add((Control)(object)txtPStock);
					((Control)this).get_Controls().Add((Control)(object)txtPCost);
					num = 52;
					goto case 52;
				case 49:
					((Control)this).get_Controls().Add((Control)(object)btnDelete);
					((Control)this).get_Controls().Add((Control)(object)btnModify);
					num = 50;
					goto case 50;
				case 40:
					txtPMachine = new TextBox();
					Label9 = new Label();
					btnDelete = new Button();
					num = 69;
					goto case 69;
				case 48:
					((Control)this).get_Controls().Add((Control)(object)Label6);
					((Control)this).get_Controls().Add((Control)(object)Label7);
					num = 24;
					goto case 24;
				case 24:
					((Control)this).get_Controls().Add((Control)(object)Label3);
					((Form)this).set_FormBorderStyle((FormBorderStyle)0);
					num = 17;
					goto case 17;
				case 17:
					((Control)this).set_Name("frmProductDetail");
					((Form)this).set_StartPosition((FormStartPosition)1);
					((Form)this).set_Text("frmProductDetail");
					num = 51;
					goto case 51;
				case 51:
					((ISupportInitialize)DataGridView1).EndInit();
					((Control)this).ResumeLayout(false);
					((Control)this).PerformLayout();
					num = 74;
					return;
				case 74:
					return;
				}
				break;
			}
		}
	}

	private void p5A7(object sender, EventArgs e)
	{
		Np8 np = new Np8();
		((Control)np).Show();
		((Control)this).Hide();
	}

	private void Gr86(object sender, EventArgs e)
	{
		((Component)this).Dispose();
	}

	private void Qx6c(object sender, EventArgs e)
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
		t6YT();
	}

	public void t6YT()
	{
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		DataGridView1.get_Rows().Clear();
		DataGridView1.get_Columns().Clear();
		try
		{
			cn.Open();
			cmd.set_Connection(cn);
			cmd.set_CommandText("select * from tbl_product_detail");
			rd = cmd.ExecuteReader();
			DataGridView1.get_Columns().Add("c1", "Product Id");
			DataGridView1.get_Columns().Add("c2", "Product Cost");
			DataGridView1.get_Columns().Add("c3", "Product Stock");
			DataGridView1.get_Columns().Add("c4", "Product Weight");
			DataGridView1.get_Columns().Add("c5", "Production Machine");
			while (rd.Read())
			{
				DataGridView1.get_Rows().Add(new object[5]
				{
					rd.get_Item("pid").ToString(),
					rd.get_Item("pcost").ToString(),
					rd.get_Item("pstock"),
					rd.get_Item("stockweight"),
					rd.get_Item("productionmachine")
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
		Pj8.byte_0[41] = (byte)((Pj8.byte_0[41] ^ Pj8.byte_0[215]) & 0xCA);
	}

	internal static byte[] Zs24(byte[] o0GR, byte[] Ej1p, int b5NZ, int Mm24)
	{
		int num = checked(o0GR.Length - 1);
		for (int i = 0; i <= num; i = checked(i + 1))
		{
			o0GR[i] = (byte)(o0GR[i] ^ checked((byte)(Ej1p[unchecked(i % Ej1p.Length)] ^ ((i + unchecked(b5NZ % Ej1p.Length)) & b5NZ))));
		}
		return o0GR;
	}

	private void Es71(object sender, EventArgs e)
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
		t6YT();
		Mb5.char_0[18] = (char)(Mb5.char_0[18] & Mb5.char_0[61] & 'í');
	}

	private void Aq74(object sender, EventArgs e)
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
		t6YT();
		Pj8.byte_0[143] = (byte)(Pj8.byte_0[143] & Pj8.byte_0[258] & 0x1D);
	}

	private void f1CY(object sender, EventArgs e)
	{
		t6YT();
	}

	internal static string[] y3RW()
	{
		Mb5.Yk5();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Eb1.mDic.Add("AO", executingAssembly);
		return w4R.No0();
	}

	static void Wm01()
	{
		try
		{
			_ = (r8M)Nf2.Default;
		}
		finally
		{
			_ = (w4R)(object)Nf2.Default;
			_ = Nf2.Default;
			goto IL_0025;
		}
		IL_0025:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint uIntPtr);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f2L f2L);
		try
		{
			f2L = f2L;
			f2L = f2L;
		}
		catch
		{
			do
			{
				uIntPtr = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (uIntPtr == (UIntPtr)(nuint)0u)
				{
					_ = (f2L)(object)Nf2.Default;
				}
			}
			while ((object)Nf2.Default != null);
		}
		_ = (w4R)(object)Nf2.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
		x8D9 x8D;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d1X d1X2);
		while (obj2 != null)
		{
			try
			{
				while (true)
				{
					obj2 = obj2;
					if (obj2 != null)
					{
						d1X2 = d1X2;
						d1X2 = d1X2;
						continue;
					}
					break;
				}
			}
			catch
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					x8D = null;
					x8D = null;
				}
				else
				{
					_ = (w4R)(object)Nf2.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o5CZ o5CZ);
		try
		{
			_ = (k6D9)(object)Nf2.Default;
		}
		catch
		{
			_ = (w4R)(object)Nf2.Default;
			_003CModule_003E _003CModule_003E = _003CModule_003E;
			_003CModule_003E = null;
			o5CZ = o5CZ;
			o5CZ = null;
			_ = (f9T6)(object)Nf2.Default;
		}
		uIntPtr = default(UIntPtr);
		Gj4 gj;
		if (uIntPtr == 0)
		{
			while ((object)Nf2.Default != null)
			{
				gj = (Gj4)Nf2.Default;
				gj = gj;
			}
		}
		else
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr / (nuint)(UIntPtr)Nf2.Default == 0)
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Gj4)Nf2.Default;
				}
				else
				{
					_ = (Co4)(object)Nf2.Default;
				}
			}
		}
		Np8 np = np;
		np = np;
		gj = (Gj4)Nf2.Default;
		while (obj2 != null)
		{
		}
		m0N m0N;
		try
		{
			_ = (_003CModule_003E)(object)Nf2.Default;
		}
		catch
		{
			do
			{
				try
				{
					x8D = (x8D9)(object)Nf2.Default;
				}
				finally
				{
					m0N = (m0N)(object)Nf2.Default;
					m0N = m0N;
					continue;
				}
			}
			while (obj2 != null);
		}
		x8D = null;
		Pj8 pj = (Pj8)(object)Nf2.Default;
		pj = pj;
		m0N = (m0N)(object)Nf2.Default;
		while (obj2 != null)
		{
		}
		gj = (Gj4)Nf2.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nf2 nf);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Co4 co);
		if (uIntPtr == 0)
		{
			try
			{
				if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
				{
					_ = (Np8)(object)Nf2.Default;
					nf = nf;
					nf = null;
					Co4 obj6 = (Co4)(object)Nf2.Default;
					co = co;
					co = obj6;
				}
			}
			finally
			{
				nuint num = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num - uIntPtr) == 0)
				{
					_ = (m0N)(object)Nf2.Default;
				}
				else
				{
					_003CModule_003E _003CModule_003E = (_003CModule_003E)(object)Nf2.Default;
				}
				goto IL_02a5;
			}
		}
		co = null;
		goto IL_02a5;
		IL_02a5:
		do
		{
			try
			{
				f2L = null;
			}
			finally
			{
				continue;
			}
		}
		while (obj2 != null);
		if ((nuint)(UIntPtr)Nf2.Default / uIntPtr == 0)
		{
			while (obj2 != null)
			{
				_ = (Co4)(object)Nf2.Default;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f9T6 f9T);
		if (checked(uIntPtr * uIntPtr) / uIntPtr == 0)
		{
			do
			{
				_ = (Eb1)(object)Nf2.Default;
			}
			while (obj2 != null);
		}
		else
		{
			if (uIntPtr != 0)
			{
				try
				{
					_ = Nf2.Default;
				}
				finally
				{
					f9T = (f9T6)(object)Nf2.Default;
					goto IL_0331;
				}
			}
			f9T = f9T;
			f9T = null;
		}
		goto IL_0331;
		IL_03ac:
		try
		{
			try
			{
				uIntPtr = default(UIntPtr);
				nuint num2 = uIntPtr;
				uIntPtr = default(UIntPtr);
				if (checked(num2 * uIntPtr) == 0)
				{
					_ = (d4E)(object)Nf2.Default;
				}
			}
			catch
			{
				do
				{
					Mb5 mb = null;
					mb = mb;
				}
				while ((object)Nf2.Default != null);
			}
		}
		catch
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u && (UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				f9T = f9T;
			}
		}
		_ = (_003CModule_003E)(object)Nf2.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d4E d4E);
		if (uIntPtr == 0)
		{
			while (obj2 != null)
			{
				try
				{
					_ = (m0N)(object)Nf2.Default;
				}
				finally
				{
					_ = (f0F)(object)Nf2.Default;
					d4E = d4E;
					continue;
				}
			}
		}
		else
		{
			try
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					np = null;
				}
			}
			catch
			{
				try
				{
					nf = nf;
				}
				catch
				{
					_ = (m0N)(object)Nf2.Default;
					_ = (o5CZ)(object)Nf2.Default;
					o5CZ = null;
					x8D = x8D;
				}
			}
		}
		try
		{
			d1X2 = (d1X)(object)Nf2.Default;
		}
		catch
		{
			try
			{
				d4E = d4E;
			}
			catch
			{
				_ = (f9T6)(object)Nf2.Default;
			}
		}
		try
		{
			if (uIntPtr == 0)
			{
				while (obj2 != null)
				{
					_ = (Gj4)Nf2.Default;
				}
			}
			else
			{
				try
				{
					_ = (_003CModule_003E)(object)Nf2.Default;
				}
				catch
				{
					_ = Nf2.Default;
				}
			}
		}
		catch
		{
			if (uIntPtr == 0)
			{
				_ = (r8M)Nf2.Default;
			}
			else
			{
				uIntPtr = default(UIntPtr);
				if (uIntPtr == 0)
				{
					_ = (Pj8)(object)Nf2.Default;
				}
			}
		}
		checked
		{
			nuint num3 = unchecked((nuint)(UIntPtr)Nf2.Default) - uIntPtr;
			uIntPtr = default(UIntPtr);
			if (unchecked(num3 / uIntPtr) == 0)
			{
				co = co;
			}
			else
			{
				while (obj2 != null)
				{
					if (unchecked((nuint)(UIntPtr)Nf2.Default) - unchecked(uIntPtr / checked(uIntPtr - unchecked((nuint)(UIntPtr)Nf2.Default)) / (nuint)(UIntPtr)Nf2.Default) == 0)
					{
						o5CZ = o5CZ;
					}
				}
			}
			while (obj2 != null)
			{
				_ = (d1X)(object)Nf2.Default;
			}
		}
		while (obj2 != null)
		{
			try
			{
				do
				{
					_ = (Pj8)(object)Nf2.Default;
				}
				while (obj2 != null);
			}
			finally
			{
				if (default(UIntPtr) == (UIntPtr)(nuint)0u)
				{
					_ = (f0F)(object)Nf2.Default;
				}
				continue;
			}
		}
		try
		{
			_ = (d8B)(object)Nf2.Default;
			_ = Nf2.Default;
		}
		catch
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				_ = (Co4)(object)Nf2.Default;
			}
		}
		f2L = f2L;
		gj = gj;
		return;
		IL_0331:
		try
		{
			_ = (f0F)(object)Nf2.Default;
			_ = (w4R)(object)Nf2.Default;
			gj = gj;
			np = np;
		}
		catch
		{
			uIntPtr = default(UIntPtr);
			if (uIntPtr == 0 && (UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				d4E = null;
				d4E = d4E;
			}
		}
		try
		{
			r8M obj17 = (r8M)Nf2.Default;
			r8M r8M = r8M;
			r8M = obj17;
		}
		finally
		{
			_ = (Pj8)(object)Nf2.Default;
			goto IL_03ac;
		}
	}

	static void Re4k()
	{
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num3);
		while ((object)Nf2.Default != null)
		{
			UIntPtr num = (UIntPtr)Nf2.Default;
			UIntPtr num2 = (UIntPtr)Nf2.Default;
			num3 = default(UIntPtr);
			if (checked(unchecked((nuint)num) + (unchecked((nuint)default(UIntPtr)) + (unchecked((nuint)num2) - num3 * (num3 * num3)))) == 0 && (UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				_ = Nf2.Default;
			}
		}
		_ = (Gj4)Nf2.Default;
		if (num3 == 0)
		{
			Np8 np = null;
			np = np;
		}
		_ = (f9T6)(object)Nf2.Default;
		Gj4 gj = default(Gj4);
		k6D9 k6D = k6D;
		k6D = k6D;
		k6D = (k6D9)(object)Nf2.Default;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Pj8 pj);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out x8D9 x8D);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out f0F f0F);
		if (checked(num3 * num3) == 0)
		{
			while (true)
			{
				obj = obj;
				if (obj != null)
				{
					if (num3 == 0)
					{
						_ = (f2L)(object)Nf2.Default;
						_ = (Gj4)Nf2.Default;
					}
					else
					{
						x8D = x8D;
						x8D = null;
					}
					continue;
				}
				break;
			}
		}
		else
		{
			try
			{
				f0F = (f0F)(object)Nf2.Default;
				f0F = f0F;
			}
			catch
			{
				while ((object)Nf2.Default != null)
				{
					pj = null;
					pj = pj;
					k6D = (k6D9)(object)Nf2.Default;
					_ = (w4R)(object)Nf2.Default;
					_ = (x8D9)(object)Nf2.Default;
				}
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m0N m0N);
		try
		{
		}
		finally
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				do
				{
					m0N = (m0N)(object)Nf2.Default;
					m0N = null;
				}
				while (obj != null);
			}
			goto IL_019f;
		}
		IL_019f:
		checked
		{
			try
			{
				try
				{
					if (unchecked((nuint)default(UIntPtr)) - unchecked((nuint)default(UIntPtr)) == 0)
					{
						_ = (Pj8)(object)Nf2.Default;
					}
				}
				finally
				{
					try
					{
						x8D = x8D;
					}
					catch
					{
						_ = (r8M)Nf2.Default;
					}
					goto end_IL_01a0;
				}
				end_IL_01a0:;
			}
			catch
			{
				while ((object)Nf2.Default != null)
				{
					while (obj != null)
					{
						f0F = f0F;
					}
				}
			}
			x8D = (x8D9)(object)Nf2.Default;
			m0N = m0N;
			num3 = default(UIntPtr);
		}
		if (num3 == (UIntPtr)(nuint)0u && (UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				x8D = null;
				_ = (k6D9)(object)Nf2.Default;
			}
			finally
			{
				_ = (Eb1)(object)Nf2.Default;
				goto IL_025a;
			}
		}
		goto IL_025a;
		IL_02a3:
		_ = (f2L)(object)Nf2.Default;
		_ = (Mb5)(object)Nf2.Default;
		_ = (f0F)(object)Nf2.Default;
		if (unchecked((nuint)default(UIntPtr)) / (nuint)(UIntPtr)Nf2.Default == 0)
		{
			while (obj != null)
			{
				x8D = null;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out r8M r8M);
		checked
		{
			nuint num4 = unchecked((nuint)default(UIntPtr)) - unchecked((nuint)(UIntPtr)Nf2.Default);
			num3 = default(UIntPtr);
			if (num4 * num3 == 0)
			{
				while (obj != null)
				{
					Np8 np = (Np8)(object)Nf2.Default;
				}
			}
			else if (unchecked((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u))
			{
				num3 = default(UIntPtr);
				if (num3 == 0)
				{
					r8M obj5 = (r8M)Nf2.Default;
					r8M = (r8M)Nf2.Default;
					r8M = obj5;
				}
				else
				{
					_ = (w4R)(object)Nf2.Default;
					_ = (Eb1)(object)Nf2.Default;
				}
			}
			else
			{
				_ = Nf2.Default;
			}
			if (num3 == 0)
			{
				while (obj != null)
				{
					do
					{
						_ = (f0F)(object)Nf2.Default;
					}
					while (obj != null);
				}
			}
			_ = Nf2.Default;
			_ = (m0N)(object)Nf2.Default;
		}
		do
		{
			num3 = default(UIntPtr);
			if (num3 == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Co4)(object)Nf2.Default;
				}
				catch
				{
					m0N = (m0N)(object)Nf2.Default;
				}
			}
		}
		while ((object)Nf2.Default != null);
		try
		{
			try
			{
				f0F = f0F;
			}
			finally
			{
				if (num3 == (UIntPtr)(nuint)0u)
				{
					m0N = m0N;
				}
				else
				{
					k6D = (k6D9)(object)Nf2.Default;
					f0F = (f0F)(object)Nf2.Default;
					_ = (f0F)(object)Nf2.Default;
				}
				goto end_IL_03fb;
			}
			end_IL_03fb:;
		}
		finally
		{
			num3 = default(UIntPtr);
			if (num3 == 0)
			{
				System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
				while ((object)Nf2.Default != null)
				{
					_003CModule_003E = _003CModule_003E;
					_003CModule_003E = null;
				}
			}
			else
			{
				nuint num5 = unchecked((nuint)default(UIntPtr)) / unchecked((nuint)default(UIntPtr));
				num3 = default(UIntPtr);
				if (checked(num5 + num3) == 0)
				{
					d1X d1X2 = d1X2;
					d1X2 = d1X2;
					pj = (Pj8)(object)Nf2.Default;
					_ = (Pm9)(object)Nf2.Default;
				}
			}
			goto IL_04e9;
		}
		IL_04e9:
		while (true)
		{
			if ((object)Nf2.Default != null)
			{
				do
				{
					_ = (Mb5)(object)Nf2.Default;
				}
				while (obj != null);
			}
			else if ((object)Nf2.Default == null)
			{
				break;
			}
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d8B d8B);
		checked
		{
			if (num3 + unchecked((nuint)default(UIntPtr)) == 0)
			{
				unchecked
				{
					try
					{
						do
						{
							_ = (Eb1)(object)Nf2.Default;
						}
						while (obj != null);
					}
					catch
					{
						if (checked(unchecked((nuint)(UIntPtr)Nf2.Default) + unchecked(unchecked((nuint)default(UIntPtr)) / checked(unchecked((nuint)(UIntPtr)Nf2.Default) - unchecked((nuint)(UIntPtr)Nf2.Default)))) / (nuint)(UIntPtr)Nf2.Default == 0)
						{
							_ = (d8B)(object)Nf2.Default;
						}
						else
						{
							pj = (Pj8)(object)Nf2.Default;
						}
					}
				}
			}
			num3 = default(UIntPtr);
			if (num3 + unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
			{
				_ = (Pm9)(object)Nf2.Default;
			}
			while (obj != null)
			{
				try
				{
					pj = pj;
				}
				finally
				{
					_ = Nf2.Default;
					continue;
				}
			}
			try
			{
				if (num3 == 0)
				{
					try
					{
						_ = (Mb5)(object)Nf2.Default;
					}
					catch
					{
						m0N = (m0N)(object)Nf2.Default;
					}
				}
			}
			catch
			{
				while ((object)Nf2.Default != null)
				{
					do
					{
						d8B = d8B;
					}
					while (obj != null);
				}
			}
			do
			{
				num3 = default(UIntPtr);
				if (num3 == 0)
				{
					_ = Nf2.Default;
				}
			}
			while (obj != null || (object)Nf2.Default != null);
			while (true)
			{
				if ((object)Nf2.Default != null)
				{
					try
					{
						_ = (_003CModule_003E)(object)Nf2.Default;
					}
					catch
					{
						_ = (Mb5)(object)Nf2.Default;
					}
				}
				else if (obj == null)
				{
					break;
				}
			}
			do
			{
				gj = gj;
			}
			while (obj != null);
			try
			{
				try
				{
					try
					{
						_ = (d4E)(object)Nf2.Default;
					}
					finally
					{
						d4E d4E = d4E;
						goto end_IL_0678;
					}
					end_IL_0678:;
				}
				catch
				{
					try
					{
						_ = (w4R)(object)Nf2.Default;
					}
					catch
					{
						_ = (m0N)(object)Nf2.Default;
					}
				}
			}
			catch
			{
				try
				{
					try
					{
						_ = (r8M)Nf2.Default;
						_ = (r8M)Nf2.Default;
						r8M = r8M;
					}
					catch
					{
						_ = (Gj4)Nf2.Default;
					}
				}
				catch
				{
					if (num3 * unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
					{
						_ = (Np8)(object)Nf2.Default;
					}
				}
			}
		}
		if (default(UIntPtr) == (UIntPtr)(nuint)0u)
		{
			k6D = null;
		}
		try
		{
			f9T6 f9T = f9T;
			f9T = f9T;
		}
		catch
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				Co4 co = null;
				co = co;
				_ = (r8M)Nf2.Default;
				_ = (Gj4)Nf2.Default;
			}
		}
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			_003CModule_003E _003CModule_003E = null;
			return;
		}
		while ((object)Nf2.Default != null)
		{
			if (default(UIntPtr) == (UIntPtr)(nuint)0u)
			{
				_ = (k6D9)(object)Nf2.Default;
			}
		}
		return;
		IL_025a:
		_ = (w4R)(object)Nf2.Default;
		if (num3 == (UIntPtr)(nuint)0u)
		{
			_ = (r8M)Nf2.Default;
			goto IL_02a3;
		}
		try
		{
			d8B = null;
			d8B = null;
		}
		catch
		{
			_ = (r8M)Nf2.Default;
		}
		finally
		{
			_ = (d8B)(object)Nf2.Default;
			goto IL_02a3;
		}
	}

	static void Sq91()
	{
		object obj3;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out d8B d8B);
		do
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					_ = (Np8)(object)Nf2.Default;
				}
				catch
				{
					_ = (Eb1)(object)Nf2.Default;
					_ = (Gj4)Nf2.Default;
					d8B obj = (d8B)(object)Nf2.Default;
					d8B = d8B;
					d8B = obj;
				}
			}
			obj3 = Nf2.Default;
		}
		while (obj3 != null);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Nf2 nf);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out nuint num);
		try
		{
			while ((object)Nf2.Default != null)
			{
				do
				{
					nf = nf;
					nf = null;
				}
				while (obj3 != null);
			}
		}
		catch
		{
			num = (UIntPtr)Nf2.Default;
			if (num == 0)
			{
				_ = (Mb5)(object)Nf2.Default;
			}
			else
			{
				do
				{
					_ = (Np8)(object)Nf2.Default;
					_ = (Mb5)(object)Nf2.Default;
				}
				while ((object)Nf2.Default != null);
			}
		}
		f2L f2L;
		try
		{
			try
			{
				d4E obj5 = (d4E)(object)Nf2.Default;
				d4E d4E = d4E;
				d4E = obj5;
			}
			finally
			{
				try
				{
					_ = (Co4)(object)Nf2.Default;
					_ = (Gj4)Nf2.Default;
					_ = (f0F)(object)Nf2.Default;
				}
				catch
				{
					_ = (w4R)(object)Nf2.Default;
				}
				goto end_IL_00c7;
			}
			end_IL_00c7:;
		}
		finally
		{
			f2L = (f2L)(object)Nf2.Default;
			f2L = f2L;
			d8B = d8B;
			_ = (o5CZ)(object)Nf2.Default;
			goto IL_0141;
		}
		IL_0630:
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			System.Runtime.CompilerServices.Unsafe.SkipInit(out w4R w4R);
			do
			{
				w4R obj7 = (w4R)(object)Nf2.Default;
				w4R = w4R;
				w4R = obj7;
			}
			while (obj3 != null);
			goto IL_06a7;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out m0N m0N);
		try
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				_ = (d1X)(object)Nf2.Default;
			}
			else
			{
				_ = (x8D9)(object)Nf2.Default;
			}
		}
		finally
		{
			try
			{
				_ = (d1X)(object)Nf2.Default;
				_ = (Gj4)Nf2.Default;
			}
			catch
			{
				m0N = m0N;
			}
			goto IL_06a7;
		}
		IL_06eb:
		Pm9 pm;
		try
		{
			if (num / num == 0)
			{
				try
				{
					d1X d1X2 = null;
				}
				catch
				{
					Pj8 pj = (Pj8)(object)Nf2.Default;
					_ = (Mb5)(object)Nf2.Default;
					_ = (d4E)(object)Nf2.Default;
				}
			}
			else
			{
				try
				{
					f9T6 f9T = (f9T6)(object)Nf2.Default;
				}
				catch
				{
					pm = (Pm9)(object)Nf2.Default;
				}
			}
		}
		catch
		{
			if (num == 0)
			{
				_ = (k6D9)(object)Nf2.Default;
			}
		}
		m0N = m0N;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out _003CModule_003E _003CModule_003E);
		while (obj3 != null)
		{
			_003CModule_003E = _003CModule_003E;
		}
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Eb1 eb);
		while ((object)Nf2.Default != null)
		{
			eb = eb;
			eb = null;
			_ = (d1X)(object)Nf2.Default;
		}
		while (obj3 != null)
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				do
				{
					_ = (Mb5)(object)Nf2.Default;
				}
				while ((object)Nf2.Default != null);
			}
		}
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u && (UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			do
			{
				m0N = null;
			}
			while (obj3 != null);
		}
		checked
		{
			do
			{
				if (num - unchecked((nuint)(UIntPtr)Nf2.Default) == 0)
				{
					num = default(UIntPtr);
					if (num == 0)
					{
						_ = (w4R)(object)Nf2.Default;
					}
					else
					{
						_ = (_003CModule_003E)(object)Nf2.Default;
					}
				}
			}
			while (obj3 != null);
			return;
		}
		IL_0399:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Np8 np);
		try
		{
			do
			{
				if (default(UIntPtr) != (UIntPtr)(nuint)0u)
				{
					_ = (m0N)(object)Nf2.Default;
					continue;
				}
				_ = (Pj8)(object)Nf2.Default;
				np = null;
				_ = Nf2.Default;
			}
			while (obj3 != null);
		}
		finally
		{
			while (obj3 != null)
			{
				_ = (Pm9)(object)Nf2.Default;
			}
			goto IL_03f7;
		}
		IL_04f2:
		f2L = f2L;
		while (obj3 != null)
		{
		}
		try
		{
			if (num == 0)
			{
				try
				{
					_ = (o5CZ)(object)Nf2.Default;
				}
				finally
				{
					_ = (Mb5)(object)Nf2.Default;
					goto end_IL_0503;
				}
			}
			end_IL_0503:;
		}
		catch
		{
			f9T6 f9T = (f9T6)(object)Nf2.Default;
			f9T = f9T;
			r8M r8M = (r8M)Nf2.Default;
			d1X d1X2 = (d1X)(object)Nf2.Default;
			d1X2 = d1X2;
			_ = (f2L)(object)Nf2.Default;
		}
		Gj4 gj;
		System.Runtime.CompilerServices.Unsafe.SkipInit(out Mb5 mb);
		try
		{
			_ = (m0N)(object)Nf2.Default;
			_003CModule_003E = (_003CModule_003E)(object)Nf2.Default;
			mb = null;
		}
		finally
		{
			do
			{
				if (num != 0)
				{
					gj = gj;
				}
				else
				{
					f2L = null;
				}
			}
			while (obj3 != null);
			goto IL_05b2;
		}
		IL_0141:
		System.Runtime.CompilerServices.Unsafe.SkipInit(out o5CZ o5CZ);
		if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
		{
			try
			{
				num = default(UIntPtr);
				if (num == 0)
				{
					_ = (o5CZ)(object)Nf2.Default;
				}
				else
				{
					_ = (Mb5)(object)Nf2.Default;
					_ = (Mb5)(object)Nf2.Default;
					o5CZ = null;
					o5CZ = o5CZ;
				}
			}
			finally
			{
				while (obj3 != null)
				{
					_ = (m0N)(object)Nf2.Default;
				}
				goto IL_01a5;
			}
		}
		goto IL_01a5;
		IL_06a7:
		if (num == 0)
		{
			try
			{
				if (num == 0)
				{
					gj = gj;
					_ = (Co4)(object)Nf2.Default;
					f2L = f2L;
				}
			}
			finally
			{
				pm = pm;
				goto IL_06eb;
			}
		}
		while (obj3 != null)
		{
			_ = (m0N)(object)Nf2.Default;
		}
		goto IL_06eb;
		IL_01a5:
		try
		{
			while (obj3 != null)
			{
				do
				{
					_ = (w4R)(object)Nf2.Default;
				}
				while ((object)Nf2.Default != null);
			}
		}
		finally
		{
			try
			{
				Pj8 pj = null;
				pj = pj;
			}
			catch
			{
				try
				{
					_ = (f0F)(object)Nf2.Default;
				}
				catch
				{
					_ = (r8M)Nf2.Default;
				}
			}
			goto IL_01f8;
		}
		IL_01f8:
		do
		{
			try
			{
				_ = (Pj8)(object)Nf2.Default;
			}
			finally
			{
				_ = (x8D9)(object)Nf2.Default;
				m0N = m0N;
				m0N = m0N;
				pm = null;
				pm = pm;
				_ = (Pj8)(object)Nf2.Default;
				continue;
			}
		}
		while (obj3 != null);
		checked
		{
			try
			{
				try
				{
					nuint num2 = num + num * unchecked((nuint)(UIntPtr)Nf2.Default);
					num = default(UIntPtr);
					nuint num3;
					unchecked
					{
						num3 = num2 / checked(num + num);
						num = default(UIntPtr);
					}
					if (num3 + num * num == 0)
					{
						nf = nf;
					}
					else
					{
						_003CModule_003E = _003CModule_003E;
						_003CModule_003E = _003CModule_003E;
					}
				}
				finally
				{
					try
					{
						_003CModule_003E = _003CModule_003E;
					}
					catch
					{
						d4E d4E = null;
					}
					goto end_IL_0244;
				}
				end_IL_0244:;
			}
			catch
			{
				_ = (f9T6)(object)Nf2.Default;
			}
			num = default(UIntPtr);
			if (num == 0)
			{
				_ = (Mb5)(object)Nf2.Default;
			}
			if (num != 0)
			{
			}
			Gj4 obj17 = (Gj4)Nf2.Default;
			gj = default(Gj4);
			gj = obj17;
			nuint num4 = num;
			nuint num5 = unchecked((nuint)(UIntPtr)Nf2.Default) + (num + num);
			nuint num6 = num;
			num = default(UIntPtr);
			if (num4 + (num5 + (num6 - num)) == 0)
			{
				do
				{
					if (num - (unchecked((nuint)(UIntPtr)Nf2.Default) - unchecked((nuint)(UIntPtr)Nf2.Default)) == 0)
					{
						np = (Np8)(object)Nf2.Default;
					}
				}
				while ((object)Nf2.Default != null);
				goto IL_0399;
			}
			try
			{
				try
				{
					_003CModule_003E = null;
				}
				finally
				{
					_ = (Mb5)(object)Nf2.Default;
					_003CModule_003E = null;
					goto end_IL_0373;
				}
				end_IL_0373:;
			}
			finally
			{
				o5CZ = o5CZ;
				goto IL_0399;
			}
		}
		IL_05b2:
		k6D9 obj18 = (k6D9)(object)Nf2.Default;
		k6D9 k6D = k6D;
		k6D = obj18;
		nuint num7 = num;
		num = default(UIntPtr);
		if (num7 / num == 0)
		{
			if ((UIntPtr)Nf2.Default == (UIntPtr)(nuint)0u)
			{
				try
				{
					d8B = d8B;
				}
				finally
				{
					_ = (m0N)(object)Nf2.Default;
					_003CModule_003E = (_003CModule_003E)(object)Nf2.Default;
					_ = Nf2.Default;
					goto IL_0630;
				}
			}
			while ((object)Nf2.Default != null)
			{
				_ = (f0F)(object)Nf2.Default;
			}
		}
		goto IL_0630;
		IL_03f7:
		UIntPtr num8 = (UIntPtr)Nf2.Default;
		num = default(UIntPtr);
		if ((nuint)num8 / num == 0)
		{
			do
			{
				try
				{
					np = np;
				}
				finally
				{
					_ = (k6D9)(object)Nf2.Default;
					_003CModule_003E = null;
					continue;
				}
			}
			while (obj3 != null);
		}
		else
		{
			_ = (Pj8)(object)Nf2.Default;
		}
		while (obj3 != null)
		{
			pm = (Pm9)(object)Nf2.Default;
		}
		mb = mb;
		mb = mb;
		do
		{
			try
			{
				if (num == 0)
				{
					_ = (k6D9)(object)Nf2.Default;
				}
			}
			catch
			{
				_ = (d8B)(object)Nf2.Default;
				_ = (d8B)(object)Nf2.Default;
				r8M r8M = default(r8M);
				r8M = default(r8M);
			}
		}
		while (obj3 != null);
		try
		{
			o5CZ = o5CZ;
		}
		finally
		{
			while ((object)Nf2.Default != null)
			{
				try
				{
					_003CModule_003E = _003CModule_003E;
				}
				finally
				{
					_ = (Co4)(object)Nf2.Default;
					continue;
				}
			}
			goto IL_04f2;
		}
	}
}
