using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Coache.Business;
using Coache.Common;
using Coache.Core;
using Coache.PedirDevolucion;

namespace Coache.HistorialCupones;

[PermissionRequired(new Functionalities[] { Functionalities.VerHistorialCupones })]
public class HistorialCuponesForm : Form
{
	private CompraCuponManager _manager = new CompraCuponManager();

	private IContainer components;

	private DataGridView dataGridView;

	private Button btnPedirDevolucion;

	private Panel panel1;

	private DataGridViewTextBoxColumn Fecha;

	private DataGridViewTextBoxColumn Descripcion;

	private DataGridViewTextBoxColumn Codigo;

	private DataGridViewTextBoxColumn Precio;

	private DataGridViewTextBoxColumn Estado;

	private Panel searchPanel;

	private Button btnFiltrar;

	private GroupBox groupBox;

	private Label label4;

	private Label label3;

	private Button btnRestablecer;

	private DateTimePicker dtpHasta;

	private DateTimePicker dtpDesde;

	private Label lblResults;

	private Label label5;

	public HistorialCuponesForm()
	{
		InitializeComponent();
	}

	private void HistorialCuponesForm_Load(object sender, EventArgs e)
	{
		dtpDesde.set_Value(DateTime.Now.Subtract(TimeSpan.FromDays(7.0)));
		dtpHasta.set_Value(DateTime.Now);
		dataGridView.add_DataSourceChanged((EventHandler)dataGridView_DataSourceChanged);
		dataGridView.set_AutoGenerateColumns(false);
		GetList();
	}

	private void dataGridView_DataSourceChanged(object sender, EventArgs e)
	{
		IList list = dataGridView.get_DataSource() as IList;
		((Control)lblResults).set_Text(list.Count.ToString());
	}

	private void btnRestablecer_Click(object sender, EventArgs e)
	{
		GetList();
	}

	private void GetList()
	{
		dataGridView.set_DataSource((object)_manager.GetAll(new Cliente
		{
			UserID = Session.User.UserID
		}, Convert.ToDateTime("2000-01-01"), DateTime.Now));
		((Control)dataGridView).Refresh();
	}

	private void btnFiltrar_Click(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (dtpDesde.get_Value() > dtpHasta.get_Value())
		{
			MessageBox.Show("La fecha desde debe ser menor o igual que la fecha hasta");
			return;
		}
		dataGridView.set_DataSource((object)_manager.GetAll(new Cliente
		{
			UserID = Session.User.UserID
		}, dtpDesde.get_Value(), dtpHasta.get_Value()));
		((Control)dataGridView).Refresh();
	}

	private void btnPedirDevolucion_Click(object sender, EventArgs e)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		if (dataGridView.get_SelectedRows() != null && ((BaseCollection)dataGridView.get_SelectedRows()).get_Count() != 0)
		{
			CompraCupon compraCupon = dataGridView.get_SelectedRows().get_Item(0).get_DataBoundItem() as CompraCupon;
			if (compraCupon.Estado == "Consumido")
			{
				MessageBox.Show("No se puede devolver una compra ya consumida");
				return;
			}
			if (compraCupon.Estado == "Devuelto")
			{
				MessageBox.Show("No se puede devolver una compra ya devuelta");
				return;
			}
			if (new DateTime(compraCupon.FechaVencimiento.Year, compraCupon.FechaVencimiento.Month, compraCupon.FechaVencimiento.Day, 23, 59, 59) < DateTime.Now)
			{
				MessageBox.Show("La fecha límite de devolución de la compra ha expirado");
				return;
			}
			PedirDevolucionForm pedirDevolucionForm = new PedirDevolucionForm(compraCupon);
			pedirDevolucionForm.OnCuponDevuelto += frm_OnCuponDevuelto;
			ViewsManager.LoadModal((Form)(object)pedirDevolucionForm);
		}
	}

	private void frm_OnCuponDevuelto(object sender, CuponDevueltoEventArgs e)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		CompraCupon compraCupon = e.CompraCupon;
		_manager.DevolverCompra(new Cliente
		{
			UserID = Session.User.UserID
		}, compraCupon, e.Mensaje);
		int index = ((BindingList<CompraCupon>)dataGridView.get_DataSource()).IndexOf(compraCupon);
		compraCupon.Estado = "Devuelto";
		((BindingList<CompraCupon>)dataGridView.get_DataSource())[index] = compraCupon;
		((Control)dataGridView).Refresh();
		((Form)(PedirDevolucionForm)sender).Close();
		MessageBox.Show("Se ha devuelto la compra");
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
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_080a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Expected O, but got Unknown
		//IL_08a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected O, but got Unknown
		dataGridView = new DataGridView();
		Fecha = new DataGridViewTextBoxColumn();
		Descripcion = new DataGridViewTextBoxColumn();
		Codigo = new DataGridViewTextBoxColumn();
		Precio = new DataGridViewTextBoxColumn();
		Estado = new DataGridViewTextBoxColumn();
		btnPedirDevolucion = new Button();
		panel1 = new Panel();
		searchPanel = new Panel();
		groupBox = new GroupBox();
		btnRestablecer = new Button();
		dtpHasta = new DateTimePicker();
		dtpDesde = new DateTimePicker();
		label4 = new Label();
		btnFiltrar = new Button();
		label3 = new Label();
		lblResults = new Label();
		label5 = new Label();
		((ISupportInitialize)dataGridView).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)searchPanel).SuspendLayout();
		((Control)groupBox).SuspendLayout();
		((Control)this).SuspendLayout();
		dataGridView.set_AllowUserToAddRows(false);
		dataGridView.set_AllowUserToDeleteRows(false);
		dataGridView.set_AllowUserToOrderColumns(true);
		dataGridView.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dataGridView.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		dataGridView.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)Fecha,
			(DataGridViewColumn)Descripcion,
			(DataGridViewColumn)Codigo,
			(DataGridViewColumn)Precio,
			(DataGridViewColumn)Estado
		});
		((Control)dataGridView).set_Dock((DockStyle)5);
		((Control)dataGridView).set_Location(new Point(0, 132));
		dataGridView.set_MultiSelect(false);
		((Control)dataGridView).set_Name("dataGridView");
		dataGridView.set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)dataGridView).set_Size(new Size(1018, 384));
		((Control)dataGridView).set_TabIndex(6);
		((DataGridViewColumn)Fecha).set_DataPropertyName("Fecha");
		((DataGridViewColumn)Fecha).set_HeaderText("Fecha");
		((DataGridViewColumn)Fecha).set_Name("Fecha");
		((DataGridViewBand)Fecha).set_ReadOnly(true);
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
		((DataGridViewColumn)Estado).set_DataPropertyName("Estado");
		((DataGridViewColumn)Estado).set_HeaderText("Estado");
		((DataGridViewColumn)Estado).set_Name("Estado");
		((DataGridViewBand)Estado).set_ReadOnly(true);
		((Control)btnPedirDevolucion).set_Location(new Point(12, 10));
		((Control)btnPedirDevolucion).set_Name("btnPedirDevolucion");
		((Control)btnPedirDevolucion).set_Size(new Size(106, 23));
		((Control)btnPedirDevolucion).set_TabIndex(0);
		((Control)btnPedirDevolucion).set_Text("Pedir Devolución");
		((ButtonBase)btnPedirDevolucion).set_UseVisualStyleBackColor(true);
		((Control)btnPedirDevolucion).add_Click((EventHandler)btnPedirDevolucion_Click);
		((Control)panel1).set_BackColor(SystemColors.ControlDark);
		((Control)panel1).get_Controls().Add((Control)(object)lblResults);
		((Control)panel1).get_Controls().Add((Control)(object)btnPedirDevolucion);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(1018, 39));
		((Control)panel1).set_TabIndex(7);
		((Control)searchPanel).get_Controls().Add((Control)(object)groupBox);
		((Control)searchPanel).set_Dock((DockStyle)1);
		((Control)searchPanel).set_Location(new Point(0, 39));
		((Control)searchPanel).set_Name("searchPanel");
		((Control)searchPanel).set_Size(new Size(1018, 93));
		((Control)searchPanel).set_TabIndex(8);
		((Control)groupBox).set_Anchor((AnchorStyles)13);
		((Control)groupBox).get_Controls().Add((Control)(object)btnRestablecer);
		((Control)groupBox).get_Controls().Add((Control)(object)dtpHasta);
		((Control)groupBox).get_Controls().Add((Control)(object)dtpDesde);
		((Control)groupBox).get_Controls().Add((Control)(object)label4);
		((Control)groupBox).get_Controls().Add((Control)(object)btnFiltrar);
		((Control)groupBox).get_Controls().Add((Control)(object)label3);
		((Control)groupBox).set_Location(new Point(12, 6));
		((Control)groupBox).set_Name("groupBox");
		((Control)groupBox).set_Size(new Size(994, 76));
		((Control)groupBox).set_TabIndex(2);
		groupBox.set_TabStop(false);
		((Control)groupBox).set_Text("Filtro");
		((Control)btnRestablecer).set_Location(new Point(282, 43));
		((Control)btnRestablecer).set_Name("btnRestablecer");
		((Control)btnRestablecer).set_Size(new Size(75, 23));
		((Control)btnRestablecer).set_TabIndex(1);
		((Control)btnRestablecer).set_Text("Restablecer");
		((ButtonBase)btnRestablecer).set_UseVisualStyleBackColor(true);
		((Control)btnRestablecer).add_Click((EventHandler)btnRestablecer_Click);
		dtpHasta.set_Format((DateTimePickerFormat)2);
		((Control)dtpHasta).set_Location(new Point(95, 45));
		((Control)dtpHasta).set_Name("dtpHasta");
		((Control)dtpHasta).set_Size(new Size(100, 20));
		((Control)dtpHasta).set_TabIndex(9);
		dtpDesde.set_Format((DateTimePickerFormat)2);
		((Control)dtpDesde).set_Location(new Point(95, 19));
		((Control)dtpDesde).set_Name("dtpDesde");
		((Control)dtpDesde).set_Size(new Size(100, 20));
		((Control)dtpDesde).set_TabIndex(8);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(21, 48));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(68, 13));
		((Control)label4).set_TabIndex(7);
		((Control)label4).set_Text("Fecha Hasta");
		((Control)btnFiltrar).set_Location(new Point(201, 43));
		((Control)btnFiltrar).set_Name("btnFiltrar");
		((Control)btnFiltrar).set_Size(new Size(75, 23));
		((Control)btnFiltrar).set_TabIndex(0);
		((Control)btnFiltrar).set_Text("Filtrar");
		((ButtonBase)btnFiltrar).set_UseVisualStyleBackColor(true);
		((Control)btnFiltrar).add_Click((EventHandler)btnFiltrar_Click);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Location(new Point(18, 22));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(71, 13));
		((Control)label3).set_TabIndex(6);
		((Control)label3).set_Text("Fecha Desde");
		((Control)lblResults).set_Anchor((AnchorStyles)9);
		((Control)lblResults).set_AutoSize(true);
		((Control)lblResults).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblResults).set_ForeColor(SystemColors.ControlLightLight);
		((Control)lblResults).set_Location(new Point(921, 15));
		((Control)lblResults).set_Name("lblResults");
		((Control)lblResults).set_Size(new Size(14, 13));
		((Control)lblResults).set_TabIndex(23);
		((Control)lblResults).set_Text("0");
		((Control)label5).set_Anchor((AnchorStyles)9);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label5).set_Location(new Point(941, 15));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(65, 13));
		((Control)label5).set_TabIndex(22);
		((Control)label5).set_Text("resultados");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1018, 516));
		((Control)this).get_Controls().Add((Control)(object)dataGridView);
		((Control)this).get_Controls().Add((Control)(object)searchPanel);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("HistorialCuponesForm");
		((Control)this).set_Text("Historial de Cupones");
		((Form)this).add_Load((EventHandler)HistorialCuponesForm_Load);
		((ISupportInitialize)dataGridView).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)searchPanel).ResumeLayout(false);
		((Control)groupBox).ResumeLayout(false);
		((Control)groupBox).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
