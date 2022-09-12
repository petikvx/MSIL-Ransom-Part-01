using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Coache.Business;
using Coache.Common;
using Coache.Core;

namespace Coache.RegistroConsumoCupon;

[PermissionRequired(new Functionalities[] { Functionalities.RegistrarConsumoCupones })]
public class RegistroConsumoCuponForm : Form
{
	private CompraCuponManager _manager = new CompraCuponManager();

	private IContainer components;

	private DataGridView dataGridView;

	private Button btnRegistrarConsumo;

	private Panel panel1;

	private DataGridViewTextBoxColumn FechaCompra;

	private DataGridViewTextBoxColumn Descripcion;

	private DataGridViewTextBoxColumn Codigo;

	private DataGridViewTextBoxColumn Precio;

	private DataGridViewTextBoxColumn Cliente;

	private Button btnActualizar;

	private Label lblResults;

	private Label label5;

	public RegistroConsumoCuponForm()
	{
		InitializeComponent();
	}

	private void RegistroConsumoCuponForm_Load(object sender, EventArgs e)
	{
		dataGridView.add_DataSourceChanged((EventHandler)dataGridView_DataSourceChanged);
		dataGridView.set_AutoGenerateColumns(false);
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

	private void btnRegistrarConsumo_Click(object sender, EventArgs e)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (dataGridView.get_SelectedRows() != null && ((BaseCollection)dataGridView.get_SelectedRows()).get_Count() != 0)
		{
			CompraCupon compraCupon = dataGridView.get_SelectedRows().get_Item(0).get_DataBoundItem() as CompraCupon;
			if ((int)MessageBox.Show($"Confirma que desea registrar el consumo de la compra '{compraCupon.Codigo}'?", "Confirmar consumo", (MessageBoxButtons)1) == 1)
			{
				_manager.ConsumirCompra(compraCupon);
				MessageBox.Show($"Se ha registrado el consumo de la compra '{compraCupon.Codigo}'");
				((BindingList<CompraCupon>)dataGridView.get_DataSource()).Remove(compraCupon);
				((Control)dataGridView).Refresh();
			}
		}
	}

	private void btnActualizar_Click(object sender, EventArgs e)
	{
		dataGridView.set_DataSource((object)_manager.GetAll(new Proveedor
		{
			UserID = Session.User.UserID
		}));
		((Control)dataGridView).Refresh();
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
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Expected O, but got Unknown
		//IL_0521: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		dataGridView = new DataGridView();
		FechaCompra = new DataGridViewTextBoxColumn();
		Descripcion = new DataGridViewTextBoxColumn();
		Codigo = new DataGridViewTextBoxColumn();
		Precio = new DataGridViewTextBoxColumn();
		Cliente = new DataGridViewTextBoxColumn();
		btnRegistrarConsumo = new Button();
		panel1 = new Panel();
		btnActualizar = new Button();
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
		dataGridView.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)FechaCompra,
			(DataGridViewColumn)Descripcion,
			(DataGridViewColumn)Codigo,
			(DataGridViewColumn)Precio,
			(DataGridViewColumn)Cliente
		});
		((Control)dataGridView).set_Dock((DockStyle)5);
		((Control)dataGridView).set_Location(new Point(0, 39));
		dataGridView.set_MultiSelect(false);
		((Control)dataGridView).set_Name("dataGridView");
		dataGridView.set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)dataGridView).set_Size(new Size(1128, 448));
		((Control)dataGridView).set_TabIndex(9);
		((DataGridViewColumn)FechaCompra).set_DataPropertyName("Fecha");
		((DataGridViewColumn)FechaCompra).set_HeaderText("Fecha de Compra");
		((DataGridViewColumn)FechaCompra).set_Name("FechaCompra");
		((DataGridViewBand)FechaCompra).set_ReadOnly(true);
		((DataGridViewColumn)Descripcion).set_DataPropertyName("Descripcion");
		((DataGridViewColumn)Descripcion).set_HeaderText("Descripción");
		((DataGridViewColumn)Descripcion).set_Name("Descripcion");
		((DataGridViewBand)Descripcion).set_ReadOnly(true);
		((DataGridViewColumn)Codigo).set_DataPropertyName("Codigo");
		((DataGridViewColumn)Codigo).set_HeaderText("Código");
		((DataGridViewColumn)Codigo).set_Name("Codigo");
		((DataGridViewBand)Codigo).set_ReadOnly(true);
		((DataGridViewColumn)Precio).set_DataPropertyName("Precio");
		((DataGridViewColumn)Precio).set_HeaderText("Precio");
		((DataGridViewColumn)Precio).set_Name("Precio");
		((DataGridViewBand)Precio).set_ReadOnly(true);
		((DataGridViewColumn)Cliente).set_DataPropertyName("Cliente");
		((DataGridViewColumn)Cliente).set_HeaderText("Cliente");
		((DataGridViewColumn)Cliente).set_Name("Cliente");
		((DataGridViewBand)Cliente).set_ReadOnly(true);
		((Control)btnRegistrarConsumo).set_Location(new Point(12, 10));
		((Control)btnRegistrarConsumo).set_Name("btnRegistrarConsumo");
		((Control)btnRegistrarConsumo).set_Size(new Size(106, 23));
		((Control)btnRegistrarConsumo).set_TabIndex(0);
		((Control)btnRegistrarConsumo).set_Text("Registrar Consumo");
		((ButtonBase)btnRegistrarConsumo).set_UseVisualStyleBackColor(true);
		((Control)btnRegistrarConsumo).add_Click((EventHandler)btnRegistrarConsumo_Click);
		((Control)panel1).set_BackColor(SystemColors.ControlDark);
		((Control)panel1).get_Controls().Add((Control)(object)lblResults);
		((Control)panel1).get_Controls().Add((Control)(object)btnActualizar);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)btnRegistrarConsumo);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(1128, 39));
		((Control)panel1).set_TabIndex(10);
		((Control)btnActualizar).set_Location(new Point(124, 10));
		((Control)btnActualizar).set_Name("btnActualizar");
		((Control)btnActualizar).set_Size(new Size(106, 23));
		((Control)btnActualizar).set_TabIndex(1);
		((Control)btnActualizar).set_Text("Actualizar");
		((ButtonBase)btnActualizar).set_UseVisualStyleBackColor(true);
		((Control)btnActualizar).add_Click((EventHandler)btnActualizar_Click);
		((Control)lblResults).set_Anchor((AnchorStyles)9);
		((Control)lblResults).set_AutoSize(true);
		((Control)lblResults).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblResults).set_ForeColor(SystemColors.ControlLightLight);
		((Control)lblResults).set_Location(new Point(1031, 20));
		((Control)lblResults).set_Name("lblResults");
		((Control)lblResults).set_Size(new Size(14, 13));
		((Control)lblResults).set_TabIndex(27);
		((Control)lblResults).set_Text("0");
		((Control)label5).set_Anchor((AnchorStyles)9);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label5).set_Location(new Point(1051, 20));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(65, 13));
		((Control)label5).set_TabIndex(26);
		((Control)label5).set_Text("resultados");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1128, 487));
		((Control)this).get_Controls().Add((Control)(object)dataGridView);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("RegistroConsumoCuponForm");
		((Control)this).set_Text("Registrar Consumos de Cupones");
		((Form)this).add_Load((EventHandler)RegistroConsumoCuponForm_Load);
		((ISupportInitialize)dataGridView).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
