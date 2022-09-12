using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Coache.Business;
using Coache.Common;
using Coache.Core;

namespace Coache.ComprarCupon;

[PermissionRequired(new Functionalities[] { Functionalities.ComprarCupones })]
public class ComprarCuponForm : Form
{
	private CuponManager _manager = new CuponManager();

	private IContainer components;

	private DataGridView dataGridView;

	private Button btnComprar;

	private Panel panel1;

	private DataGridViewTextBoxColumn Descripcion;

	private DataGridViewTextBoxColumn Precio;

	private DataGridViewTextBoxColumn PrecioOriginal;

	private Button btnActualizar;

	private Label lblResults;

	private Label label5;

	public ComprarCuponForm()
	{
		InitializeComponent();
	}

	private void ComprarCuponForm_Load(object sender, EventArgs e)
	{
		dataGridView.set_AutoGenerateColumns(false);
		dataGridView.add_DataSourceChanged((EventHandler)dataGridView_DataSourceChanged);
		dataGridView.set_DataSource((object)_manager.GetAll(new Cliente
		{
			UserID = Session.User.UserID
		}));
	}

	private void dataGridView_DataSourceChanged(object sender, EventArgs e)
	{
		IList list = dataGridView.get_DataSource() as IList;
		((Control)lblResults).set_Text(list.Count.ToString());
	}

	private void btnComprar_Click(object sender, EventArgs e)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Invalid comparison between Unknown and I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		if (dataGridView.get_SelectedRows() != null && ((BaseCollection)dataGridView.get_SelectedRows()).get_Count() != 0)
		{
			Cupon cupon = dataGridView.get_SelectedRows().get_Item(0).get_DataBoundItem() as Cupon;
			if ((int)MessageBox.Show($"Desea comprar la oferta '{cupon.Descripcion}'?", "Confirmar compra", (MessageBoxButtons)1) == 1)
			{
				int num = _manager.ComprarCupon(cupon, new Cliente
				{
					UserID = Session.User.UserID
				});
				MessageBox.Show($"Ha comprado la oferta! el código es '{cupon.Codigo}{num}'");
			}
		}
	}

	private void btnActualizar_Click(object sender, EventArgs e)
	{
		dataGridView.set_DataSource((object)_manager.GetAll(new Cliente
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
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_047f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0489: Expected O, but got Unknown
		dataGridView = new DataGridView();
		Descripcion = new DataGridViewTextBoxColumn();
		Precio = new DataGridViewTextBoxColumn();
		PrecioOriginal = new DataGridViewTextBoxColumn();
		btnComprar = new Button();
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
		dataGridView.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[3]
		{
			(DataGridViewColumn)Descripcion,
			(DataGridViewColumn)Precio,
			(DataGridViewColumn)PrecioOriginal
		});
		((Control)dataGridView).set_Dock((DockStyle)5);
		((Control)dataGridView).set_Location(new Point(0, 39));
		dataGridView.set_MultiSelect(false);
		((Control)dataGridView).set_Name("dataGridView");
		dataGridView.set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)dataGridView).set_Size(new Size(1077, 475));
		((Control)dataGridView).set_TabIndex(4);
		((DataGridViewColumn)Descripcion).set_DataPropertyName("Descripcion");
		((DataGridViewColumn)Descripcion).set_HeaderText("Descripción");
		((DataGridViewColumn)Descripcion).set_Name("Descripcion");
		((DataGridViewBand)Descripcion).set_ReadOnly(true);
		((DataGridViewColumn)Precio).set_DataPropertyName("Precio");
		((DataGridViewColumn)Precio).set_HeaderText("Precio");
		((DataGridViewColumn)Precio).set_Name("Precio");
		((DataGridViewBand)Precio).set_ReadOnly(true);
		((DataGridViewColumn)PrecioOriginal).set_DataPropertyName("PrecioOriginal");
		((DataGridViewColumn)PrecioOriginal).set_HeaderText("Precio Original");
		((DataGridViewColumn)PrecioOriginal).set_Name("PrecioOriginal");
		((DataGridViewBand)PrecioOriginal).set_ReadOnly(true);
		((Control)btnComprar).set_Location(new Point(12, 10));
		((Control)btnComprar).set_Name("btnComprar");
		((Control)btnComprar).set_Size(new Size(75, 23));
		((Control)btnComprar).set_TabIndex(0);
		((Control)btnComprar).set_Text("Comprar");
		((ButtonBase)btnComprar).set_UseVisualStyleBackColor(true);
		((Control)btnComprar).add_Click((EventHandler)btnComprar_Click);
		((Control)panel1).set_BackColor(SystemColors.ControlDark);
		((Control)panel1).get_Controls().Add((Control)(object)lblResults);
		((Control)panel1).get_Controls().Add((Control)(object)btnActualizar);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)btnComprar);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(1077, 39));
		((Control)panel1).set_TabIndex(5);
		((Control)btnActualizar).set_Location(new Point(93, 10));
		((Control)btnActualizar).set_Name("btnActualizar");
		((Control)btnActualizar).set_Size(new Size(75, 23));
		((Control)btnActualizar).set_TabIndex(1);
		((Control)btnActualizar).set_Text("Actualizar");
		((ButtonBase)btnActualizar).set_UseVisualStyleBackColor(true);
		((Control)btnActualizar).add_Click((EventHandler)btnActualizar_Click);
		((Control)lblResults).set_Anchor((AnchorStyles)9);
		((Control)lblResults).set_AutoSize(true);
		((Control)lblResults).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblResults).set_ForeColor(SystemColors.ControlLightLight);
		((Control)lblResults).set_Location(new Point(980, 20));
		((Control)lblResults).set_Name("lblResults");
		((Control)lblResults).set_Size(new Size(14, 13));
		((Control)lblResults).set_TabIndex(17);
		((Control)lblResults).set_Text("0");
		((Control)label5).set_Anchor((AnchorStyles)9);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label5).set_Location(new Point(1000, 20));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(65, 13));
		((Control)label5).set_TabIndex(16);
		((Control)label5).set_Text("resultados");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1077, 514));
		((Control)this).get_Controls().Add((Control)(object)dataGridView);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("ComprarCuponForm");
		((Control)this).set_Text("Comprar Cupon");
		((Form)this).add_Load((EventHandler)ComprarCuponForm_Load);
		((ISupportInitialize)dataGridView).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
