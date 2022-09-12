using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Coache.Business;
using Coache.Common;
using Coache.Core;

namespace Coache.ArmarCupon;

[PermissionRequired(new Functionalities[] { Functionalities.CrearCupon })]
public class ArmarCuponesForm : Form
{
	private CuponManager _manager = new CuponManager();

	private IContainer components;

	private DataGridView dataGridView;

	private Button btnAgregar;

	private Panel panel1;

	private DataGridViewTextBoxColumn ID;

	private DataGridViewTextBoxColumn Codigo;

	private DataGridViewTextBoxColumn FechaPublicacion;

	private DataGridViewTextBoxColumn FechaVencimiento;

	private DataGridViewTextBoxColumn Descripcion;

	private DataGridViewTextBoxColumn Precio;

	private DataGridViewTextBoxColumn Cantidad;

	private Label lblResults;

	private Label label5;

	public ArmarCuponesForm()
	{
		InitializeComponent();
	}

	private void btnAgregar_Click(object sender, EventArgs e)
	{
		NuevoCupon nuevoCupon = new NuevoCupon();
		nuevoCupon.OnCuponSaved += form_OnCuponSaved;
		ViewsManager.LoadModal((Form)(object)nuevoCupon);
	}

	private void form_OnCuponSaved(object sender, CuponSavedEventArgs e)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		e.Cupon.ID = _manager.Add(e.Cupon);
		((BindingList<Cupon>)dataGridView.get_DataSource()).Add(e.Cupon);
		((Control)dataGridView).Refresh();
		((Form)(NuevoCupon)sender).Close();
		MessageBox.Show("Se ha creado un nuevo Cupón");
	}

	private void ArmarCuponesForm_Load(object sender, EventArgs e)
	{
		dataGridView.set_AutoGenerateColumns(false);
		dataGridView.add_DataSourceChanged((EventHandler)dataGridView_DataSourceChanged);
		dataGridView.set_DataSource((object)_manager.GetAll(new Proveedor
		{
			UserID = Session.User.UserID
		}));
	}

	private void dataGridView_DataSourceChanged(object sender, EventArgs e)
	{
		IList list = dataGridView.get_DataSource() as IList;
		((Control)lblResults).set_Text(list.Count.ToString());
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

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
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected O, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Expected O, but got Unknown
		dataGridView = new DataGridView();
		ID = new DataGridViewTextBoxColumn();
		Codigo = new DataGridViewTextBoxColumn();
		FechaPublicacion = new DataGridViewTextBoxColumn();
		FechaVencimiento = new DataGridViewTextBoxColumn();
		Descripcion = new DataGridViewTextBoxColumn();
		Precio = new DataGridViewTextBoxColumn();
		Cantidad = new DataGridViewTextBoxColumn();
		btnAgregar = new Button();
		panel1 = new Panel();
		lblResults = new Label();
		label5 = new Label();
		((ISupportInitialize)dataGridView).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		dataGridView.set_AllowUserToAddRows(false);
		dataGridView.set_AllowUserToDeleteRows(false);
		dataGridView.set_AllowUserToOrderColumns(true);
		dataGridView.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dataGridView.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dataGridView.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[7]
		{
			(DataGridViewColumn)ID,
			(DataGridViewColumn)Codigo,
			(DataGridViewColumn)FechaPublicacion,
			(DataGridViewColumn)FechaVencimiento,
			(DataGridViewColumn)Descripcion,
			(DataGridViewColumn)Precio,
			(DataGridViewColumn)Cantidad
		});
		((Control)dataGridView).set_Dock((DockStyle)5);
		((Control)dataGridView).set_Location(new Point(0, 39));
		dataGridView.set_MultiSelect(false);
		((Control)dataGridView).set_Name("dataGridView");
		dataGridView.set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)dataGridView).set_Size(new Size(784, 385));
		((Control)dataGridView).set_TabIndex(2);
		((DataGridViewColumn)ID).set_DataPropertyName("ID");
		((DataGridViewColumn)ID).set_FillWeight(20.30457f);
		((DataGridViewColumn)ID).set_HeaderText("ID");
		((DataGridViewColumn)ID).set_Name("ID");
		((DataGridViewBand)ID).set_ReadOnly(true);
		((DataGridViewColumn)Codigo).set_DataPropertyName("Codigo");
		((DataGridViewColumn)Codigo).set_FillWeight(179.6954f);
		((DataGridViewColumn)Codigo).set_HeaderText("Código");
		((DataGridViewColumn)Codigo).set_Name("Codigo");
		((DataGridViewBand)Codigo).set_ReadOnly(true);
		((DataGridViewColumn)FechaPublicacion).set_DataPropertyName("FechaPublicacion");
		((DataGridViewColumn)FechaPublicacion).set_HeaderText("Fecha de Publicación");
		((DataGridViewColumn)FechaPublicacion).set_Name("FechaPublicacion");
		((DataGridViewBand)FechaPublicacion).set_ReadOnly(true);
		((DataGridViewColumn)FechaVencimiento).set_DataPropertyName("FechaVencimientoOferta");
		((DataGridViewColumn)FechaVencimiento).set_HeaderText("Fecha de Vencimiento");
		((DataGridViewColumn)FechaVencimiento).set_Name("FechaVencimiento");
		((DataGridViewBand)FechaVencimiento).set_ReadOnly(true);
		((DataGridViewColumn)Descripcion).set_DataPropertyName("Descripcion");
		((DataGridViewColumn)Descripcion).set_HeaderText("Descripción");
		((DataGridViewColumn)Descripcion).set_Name("Descripcion");
		((DataGridViewBand)Descripcion).set_ReadOnly(true);
		((DataGridViewColumn)Precio).set_DataPropertyName("Precio");
		((DataGridViewColumn)Precio).set_HeaderText("Precio");
		((DataGridViewColumn)Precio).set_Name("Precio");
		((DataGridViewBand)Precio).set_ReadOnly(true);
		((DataGridViewColumn)Cantidad).set_DataPropertyName("Cantidad");
		((DataGridViewColumn)Cantidad).set_HeaderText("Cantidad");
		((DataGridViewColumn)Cantidad).set_Name("Cantidad");
		((DataGridViewBand)Cantidad).set_ReadOnly(true);
		((Control)btnAgregar).set_Location(new Point(12, 10));
		((Control)btnAgregar).set_Name("btnAgregar");
		((Control)btnAgregar).set_Size(new Size(75, 23));
		((Control)btnAgregar).set_TabIndex(0);
		((Control)btnAgregar).set_Text("Nuevo");
		((ButtonBase)btnAgregar).set_UseVisualStyleBackColor(true);
		((Control)btnAgregar).add_Click((EventHandler)btnAgregar_Click);
		((Control)panel1).set_BackColor(SystemColors.ControlDark);
		((Control)panel1).get_Controls().Add((Control)(object)lblResults);
		((Control)panel1).get_Controls().Add((Control)(object)btnAgregar);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(784, 39));
		((Control)panel1).set_TabIndex(3);
		((Control)lblResults).set_Anchor((AnchorStyles)9);
		((Control)lblResults).set_AutoSize(true);
		((Control)lblResults).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblResults).set_ForeColor(SystemColors.ControlLightLight);
		((Control)lblResults).set_Location(new Point(687, 20));
		((Control)lblResults).set_Name("lblResults");
		((Control)lblResults).set_Size(new Size(14, 13));
		((Control)lblResults).set_TabIndex(13);
		((Control)lblResults).set_Text("0");
		((Control)label5).set_Anchor((AnchorStyles)9);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label5).set_Location(new Point(707, 20));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(65, 13));
		((Control)label5).set_TabIndex(12);
		((Control)label5).set_Text("resultados");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(784, 424));
		((Control)this).get_Controls().Add((Control)(object)dataGridView);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("ArmarCuponesForm");
		((Control)this).set_Text("Armar Cupon");
		((Form)this).add_Load((EventHandler)ArmarCuponesForm_Load);
		((ISupportInitialize)dataGridView).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
