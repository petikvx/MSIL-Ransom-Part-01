using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using HOAProject.My;
using Microsoft.VisualBasic.CompilerServices;

namespace HOAProject;

[DesignerGenerated]
public class Models : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MODELBindingSource")]
	internal virtual BindingSource MODELBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MODELIDDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn MODELIDDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MODELNAMEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn MODELNAMEDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BEDROOMNUMDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn BEDROOMNUMDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FULLBATHNUMDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn FULLBATHNUMDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("HALFBATHNUMDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn HALFBATHNUMDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SQUAREFOOTAGEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SQUAREFOOTAGEDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GARAGENUMDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn GARAGENUMDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("STORIESNUMDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn STORIESNUMDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BASEPRICEDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn BASEPRICEDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button BackButton
	{
		[CompilerGenerated]
		get
		{
			return _BackButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = BackButton_Click;
			Button backButton = _BackButton;
			if (backButton != null)
			{
				((Control)backButton).remove_Click(eventHandler);
			}
			_BackButton = value;
			backButton = _BackButton;
			if (backButton != null)
			{
				((Control)backButton).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button AllTwoStoriesButton
	{
		[CompilerGenerated]
		get
		{
			return _AllTwoStoriesButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = AllTwoStoriesButton_Click;
			Button allTwoStoriesButton = _AllTwoStoriesButton;
			if (allTwoStoriesButton != null)
			{
				((Control)allTwoStoriesButton).remove_Click(eventHandler);
			}
			_AllTwoStoriesButton = value;
			allTwoStoriesButton = _AllTwoStoriesButton;
			if (allTwoStoriesButton != null)
			{
				((Control)allTwoStoriesButton).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("OutputTotal")]
	internal virtual Label OutputTotal
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label OutputResult
	{
		[CompilerGenerated]
		get
		{
			return _OutputResult;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = OutputResult_Click;
			Label outputResult = _OutputResult;
			if (outputResult != null)
			{
				((Control)outputResult).remove_Click(eventHandler);
			}
			_OutputResult = value;
			outputResult = _OutputResult;
			if (outputResult != null)
			{
				((Control)outputResult).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button AllModels
	{
		[CompilerGenerated]
		get
		{
			return _AllModels;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = AllModels_Click;
			Button allModels = _AllModels;
			if (allModels != null)
			{
				((Control)allModels).remove_Click(eventHandler);
			}
			_AllModels = value;
			allModels = _AllModels;
			if (allModels != null)
			{
				((Control)allModels).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button ShowModelPricing
	{
		[CompilerGenerated]
		get
		{
			return _ShowModelPricing;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = ShowModelPricing_Click;
			Button showModelPricing = _ShowModelPricing;
			if (showModelPricing != null)
			{
				((Control)showModelPricing).remove_Click(eventHandler);
			}
			_ShowModelPricing = value;
			showModelPricing = _ShowModelPricing;
			if (showModelPricing != null)
			{
				((Control)showModelPricing).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox StartingPrice
	{
		[CompilerGenerated]
		get
		{
			return _StartingPrice;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = StartingPrice_TextChanged;
			TextBox startingPrice = _StartingPrice;
			if (startingPrice != null)
			{
				((Control)startingPrice).remove_TextChanged(eventHandler);
			}
			_StartingPrice = value;
			startingPrice = _StartingPrice;
			if (startingPrice != null)
			{
				((Control)startingPrice).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual TextBox StartingSize
	{
		[CompilerGenerated]
		get
		{
			return _StartingSize;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = TextBox2_TextChanged;
			TextBox startingSize = _StartingSize;
			if (startingSize != null)
			{
				((Control)startingSize).remove_TextChanged(eventHandler);
			}
			_StartingSize = value;
			startingSize = _StartingSize;
			if (startingSize != null)
			{
				((Control)startingSize).add_TextChanged(eventHandler);
			}
		}
	}

	internal virtual Button ModelsonSizeInput
	{
		[CompilerGenerated]
		get
		{
			return _ModelsonSizeInput;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button modelsonSizeInput = _ModelsonSizeInput;
			if (modelsonSizeInput != null)
			{
				((Control)modelsonSizeInput).remove_Click(eventHandler);
			}
			_ModelsonSizeInput = value;
			modelsonSizeInput = _ModelsonSizeInput;
			if (modelsonSizeInput != null)
			{
				((Control)modelsonSizeInput).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button DoubleInputButton
	{
		[CompilerGenerated]
		get
		{
			return _DoubleInputButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = DoubleInputButton_Click_1;
			Button doubleInputButton = _DoubleInputButton;
			if (doubleInputButton != null)
			{
				((Control)doubleInputButton).remove_Click(eventHandler);
			}
			_DoubleInputButton = value;
			doubleInputButton = _DoubleInputButton;
			if (doubleInputButton != null)
			{
				((Control)doubleInputButton).add_Click(eventHandler);
			}
		}
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	private NumberStyles Parse
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public Models()
	{
		((Form)this).add_Load((EventHandler)Models_Load);
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
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Models));
		DataGridView1 = new DataGridView();
		BackButton = new Button();
		AllTwoStoriesButton = new Button();
		OutputTotal = new Label();
		OutputResult = new Label();
		AllModels = new Button();
		ShowModelPricing = new Button();
		StartingPrice = new TextBox();
		StartingSize = new TextBox();
		ModelsonSizeInput = new Button();
		DoubleInputButton = new Button();
		Label1 = new Label();
		Label2 = new Label();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		MODELBindingSource = new BindingSource(components);
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)MODELBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		DataGridView1.set_AllowUserToAddRows(false);
		DataGridView1.set_AutoGenerateColumns(false);
		DataGridView1.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)6);
		DataGridView1.set_AutoSizeRowsMode((DataGridViewAutoSizeRowsMode)7);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView1.set_DataSource((object)MODELBindingSource);
		((Control)DataGridView1).set_Location(new Point(5, 11));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.set_RowHeadersVisible(false);
		DataGridView1.set_RowHeadersWidth(51);
		((Control)DataGridView1).set_Size(new Size(931, 261));
		((Control)DataGridView1).set_TabIndex(0);
		((Control)BackButton).set_Location(new Point(441, 458));
		((Control)BackButton).set_Margin(new Padding(2, 2, 2, 2));
		((Control)BackButton).set_Name("BackButton");
		((Control)BackButton).set_Size(new Size(68, 19));
		((Control)BackButton).set_TabIndex(3);
		((ButtonBase)BackButton).set_Text("&Back");
		((ButtonBase)BackButton).set_UseVisualStyleBackColor(true);
		((Control)AllTwoStoriesButton).set_Location(new Point(25, 289));
		((Control)AllTwoStoriesButton).set_Name("AllTwoStoriesButton");
		((Control)AllTwoStoriesButton).set_Size(new Size(122, 23));
		((Control)AllTwoStoriesButton).set_TabIndex(4);
		((ButtonBase)AllTwoStoriesButton).set_Text("Two Stories");
		((ButtonBase)AllTwoStoriesButton).set_UseVisualStyleBackColor(true);
		OutputTotal.set_AutoSize(true);
		((Control)OutputTotal).set_Location(new Point(861, 289));
		((Control)OutputTotal).set_Name("OutputTotal");
		((Control)OutputTotal).set_Size(new Size(37, 13));
		((Control)OutputTotal).set_TabIndex(5);
		OutputTotal.set_Text("Total: ");
		OutputResult.set_AutoSize(true);
		((Control)OutputResult).set_BackColor(Color.Lime);
		((Control)OutputResult).set_ForeColor(Color.Black);
		((Control)OutputResult).set_Location(new Point(904, 289));
		((Control)OutputResult).set_Name("OutputResult");
		((Control)OutputResult).set_Size(new Size(13, 13));
		((Control)OutputResult).set_TabIndex(6);
		OutputResult.set_Text("0");
		((Control)AllModels).set_Location(new Point(775, 454));
		((Control)AllModels).set_Name("AllModels");
		((Control)AllModels).set_Size(new Size(122, 23));
		((Control)AllModels).set_TabIndex(7);
		((ButtonBase)AllModels).set_Text("All Models");
		((ButtonBase)AllModels).set_UseVisualStyleBackColor(true);
		((Control)ShowModelPricing).set_Location(new Point(25, 348));
		((Control)ShowModelPricing).set_Name("ShowModelPricing");
		((Control)ShowModelPricing).set_Size(new Size(135, 23));
		((Control)ShowModelPricing).set_TabIndex(8);
		((ButtonBase)ShowModelPricing).set_Text("Show Models starting at: ");
		((ButtonBase)ShowModelPricing).set_UseVisualStyleBackColor(true);
		((Control)StartingPrice).set_Location(new Point(166, 350));
		StartingPrice.set_Multiline(true);
		((Control)StartingPrice).set_Name("StartingPrice");
		((Control)StartingPrice).set_Size(new Size(100, 17));
		((Control)StartingPrice).set_TabIndex(9);
		((Control)StartingSize).set_Location(new Point(166, 400));
		((Control)StartingSize).set_Name("StartingSize");
		((Control)StartingSize).set_Size(new Size(100, 20));
		((Control)StartingSize).set_TabIndex(11);
		((Control)ModelsonSizeInput).set_Location(new Point(25, 400));
		((Control)ModelsonSizeInput).set_Name("ModelsonSizeInput");
		((Control)ModelsonSizeInput).set_Size(new Size(135, 23));
		((Control)ModelsonSizeInput).set_TabIndex(10);
		((ButtonBase)ModelsonSizeInput).set_Text("Show Models larger than: ");
		((ButtonBase)ModelsonSizeInput).set_UseVisualStyleBackColor(true);
		((Control)DoubleInputButton).set_Location(new Point(25, 437));
		((Control)DoubleInputButton).set_Name("DoubleInputButton");
		((Control)DoubleInputButton).set_Size(new Size(197, 23));
		((Control)DoubleInputButton).set_TabIndex(13);
		((ButtonBase)DoubleInputButton).set_Text("Show Models Starting at Price and Size");
		((ButtonBase)DoubleInputButton).set_UseVisualStyleBackColor(true);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(31, 473));
		((Control)Label1).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(70, 13));
		((Control)Label1).set_TabIndex(16);
		Label1.set_Text("Starting Price");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(141, 473));
		((Control)Label2).set_Margin(new Padding(2, 0, 2, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(27, 13));
		((Control)Label2).set_TabIndex(17);
		Label2.set_Text("Size");
		((Control)TextBox1).set_Location(new Point(12, 491));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(100, 20));
		((Control)TextBox1).set_TabIndex(18);
		((Control)TextBox2).set_Location(new Point(123, 490));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(100, 20));
		((Control)TextBox2).set_TabIndex(19);
		MODELBindingSource.set_DataMember("MODEL");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(948, 519));
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)DoubleInputButton);
		((Control)this).get_Controls().Add((Control)(object)StartingSize);
		((Control)this).get_Controls().Add((Control)(object)ModelsonSizeInput);
		((Control)this).get_Controls().Add((Control)(object)StartingPrice);
		((Control)this).get_Controls().Add((Control)(object)ShowModelPricing);
		((Control)this).get_Controls().Add((Control)(object)AllModels);
		((Control)this).get_Controls().Add((Control)(object)OutputResult);
		((Control)this).get_Controls().Add((Control)(object)OutputTotal);
		((Control)this).get_Controls().Add((Control)(object)AllTwoStoriesButton);
		((Control)this).get_Controls().Add((Control)(object)BackButton);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Models");
		((Form)this).set_Text("Models");
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)MODELBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Models_Load(object sender, EventArgs e)
	{
	}

	private void BackButton_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)MyProject.Forms.WelcomePage).Show();
	}

	private void OutputResult_Click(object sender, EventArgs e)
	{
	}

	private void AllTwoStoriesButton_Click(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		try
		{
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void AllModels_Click(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		try
		{
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void ShowModelPricing_Click(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			MessageBox.Show("Please enter a valid model price.");
			OutputResult.set_Text("");
			ProjectData.ClearProjectError();
		}
	}

	private void StartingPrice_TextChanged(object sender, EventArgs e)
	{
	}

	private void TextBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MessageBox.Show("Please enter a valid model size.");
			OutputResult.set_Text("");
			ProjectData.ClearProjectError();
		}
	}

	private void DoubleInputButton_Click_1(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			MessageBox.Show("Please enter a valid model Price or Size.");
			OutputResult.set_Text("");
			ProjectData.ClearProjectError();
		}
	}
}
