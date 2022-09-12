using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Coache.Business;
using Coache.Common;
using Coache.Core;

namespace Coache.PublicarCupon;

[PermissionRequired(new Functionalities[] { Functionalities.PublicarCupones })]
public class PublicarCuponForm : Form
{
	private CuponManager _manager = new CuponManager();

	private IContainer components;

	private DataGridView dataGridView;

	private Button btnPublicar;

	private Panel panel1;

	private DataGridViewCheckBoxColumn Publicar;

	private DataGridViewTextBoxColumn ID;

	private DataGridViewTextBoxColumn Codigo;

	private DataGridViewTextBoxColumn FechaVigencia;

	private DataGridViewTextBoxColumn Descripcion;

	private DataGridViewTextBoxColumn Proveedor;

	private Button btnActualizar;

	private Label lblResults;

	private Label label5;

	public PublicarCuponForm()
	{
		InitializeComponent();
	}

	private void PublicarCuponForm_Load(object sender, EventArgs e)
	{
		dataGridView.add_DataSourceChanged((EventHandler)dataGridView_DataSourceChanged);
		dataGridView.set_AutoGenerateColumns(false);
		dataGridView.set_DataSource((object)_manager.GetAllToPublish());
	}

	private void dataGridView_DataSourceChanged(object sender, EventArgs e)
	{
		UpdateDataSource();
	}

	private void btnPublicar_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("Confirma que desea publicar los cupones seleccionados?", "Confirmar publicación", (MessageBoxButtons)1) != 1 || dataGridView.get_Rows() == null || dataGridView.get_Rows().get_Count() <= 0)
		{
			return;
		}
		BindingList<Cupon> bindingList = (BindingList<Cupon>)dataGridView.get_DataSource();
		foreach (DataGridViewRow item in (IEnumerable)dataGridView.get_Rows())
		{
			DataGridViewRow val = item;
			DataGridViewCell obj = val.get_Cells().get_Item(((DataGridViewColumn)Publicar).get_Name());
			DataGridViewCell obj2 = ((obj is DataGridViewCheckBoxCell) ? obj : null);
			Cupon cupon = null;
			if (Convert.ToBoolean(obj2.get_Value()))
			{
				cupon = val.get_DataBoundItem() as Cupon;
				_manager.Publish(cupon);
				bindingList.Remove(cupon);
			}
		}
		dataGridView.set_DataSource((object)_manager.GetAllToPublish());
		((Control)dataGridView).Refresh();
		MessageBox.Show("Se han publicado los cupones seleccionados");
	}

	private void UpdateDataSource()
	{
		IList list = dataGridView.get_DataSource() as IList;
		((Control)lblResults).set_Text(list.Count.ToString());
	}

	private void btnActualizar_Click(object sender, EventArgs e)
	{
		dataGridView.set_DataSource((object)_manager.GetAllToPublish());
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Expected O, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Expected O, but got Unknown
		dataGridView = new DataGridView();
		Publicar = new DataGridViewCheckBoxColumn();
		ID = new DataGridViewTextBoxColumn();
		Codigo = new DataGridViewTextBoxColumn();
		FechaVigencia = new DataGridViewTextBoxColumn();
		Descripcion = new DataGridViewTextBoxColumn();
		Proveedor = new DataGridViewTextBoxColumn();
		btnPublicar = new Button();
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
		dataGridView.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)Publicar,
			(DataGridViewColumn)ID,
			(DataGridViewColumn)Codigo,
			(DataGridViewColumn)FechaVigencia,
			(DataGridViewColumn)Descripcion,
			(DataGridViewColumn)Proveedor
		});
		((Control)dataGridView).set_Dock((DockStyle)5);
		((Control)dataGridView).set_Location(new Point(0, 39));
		dataGridView.set_MultiSelect(false);
		((Control)dataGridView).set_Name("dataGridView");
		dataGridView.set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)dataGridView).set_Size(new Size(740, 308));
		((Control)dataGridView).set_TabIndex(4);
		((DataGridViewColumn)Publicar).set_HeaderText("Publicar");
		((DataGridViewColumn)Publicar).set_Name("Publicar");
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
		((DataGridViewColumn)FechaVigencia).set_DataPropertyName("FechaVencimientoOferta");
		((DataGridViewColumn)FechaVigencia).set_HeaderText("Fecha de vencimiento de la oferta");
		((DataGridViewColumn)FechaVigencia).set_Name("FechaVigencia");
		((DataGridViewBand)FechaVigencia).set_ReadOnly(true);
		((DataGridViewColumn)Descripcion).set_DataPropertyName("Descripcion");
		((DataGridViewColumn)Descripcion).set_HeaderText("Descripción");
		((DataGridViewColumn)Descripcion).set_Name("Descripcion");
		((DataGridViewBand)Descripcion).set_ReadOnly(true);
		((DataGridViewColumn)Proveedor).set_DataPropertyName("Proveedor");
		((DataGridViewColumn)Proveedor).set_HeaderText("Proveedor");
		((DataGridViewColumn)Proveedor).set_Name("Proveedor");
		((DataGridViewBand)Proveedor).set_ReadOnly(true);
		((Control)btnPublicar).set_Location(new Point(12, 10));
		((Control)btnPublicar).set_Name("btnPublicar");
		((Control)btnPublicar).set_Size(new Size(75, 23));
		((Control)btnPublicar).set_TabIndex(0);
		((Control)btnPublicar).set_Text("Publicar");
		((ButtonBase)btnPublicar).set_UseVisualStyleBackColor(true);
		((Control)btnPublicar).add_Click((EventHandler)btnPublicar_Click);
		((Control)panel1).set_BackColor(SystemColors.ControlDark);
		((Control)panel1).get_Controls().Add((Control)(object)lblResults);
		((Control)panel1).get_Controls().Add((Control)(object)btnActualizar);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)btnPublicar);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(740, 39));
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
		((Control)lblResults).set_Location(new Point(643, 20));
		((Control)lblResults).set_Name("lblResults");
		((Control)lblResults).set_Size(new Size(14, 13));
		((Control)lblResults).set_TabIndex(25);
		((Control)lblResults).set_Text("0");
		((Control)label5).set_Anchor((AnchorStyles)9);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label5).set_Location(new Point(663, 20));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(65, 13));
		((Control)label5).set_TabIndex(24);
		((Control)label5).set_Text("resultados");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(740, 347));
		((Control)this).get_Controls().Add((Control)(object)dataGridView);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("PublicarCuponForm");
		((Control)this).set_Text("Publicar Cupones");
		((Form)this).add_Load((EventHandler)PublicarCuponForm_Load);
		((ISupportInitialize)dataGridView).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
