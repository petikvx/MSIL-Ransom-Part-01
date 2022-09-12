using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Coache.Business;
using Coache.Common;
using Coache.Core;

namespace Coache.ListadoEstadistico;

[PermissionRequired(new Functionalities[] { Functionalities.ListarEstadisticas })]
public class ListadoEstadisticoForm : Form
{
	private ReportManager _reportManager = new ReportManager();

	private IContainer components;

	private DataGridView dataGridView;

	private GroupBox groupBox;

	private DateTimePicker dtpHasta;

	private DateTimePicker dtpDesde;

	private Label label4;

	private Button btnFiltrar;

	private Label label3;

	private Panel searchPanel;

	private Panel panel1;

	private Label label1;

	private ComboBox cbxReportType;

	public ListadoEstadisticoForm()
	{
		InitializeComponent();
	}

	private void ListadoEstadisticoForm_Load(object sender, EventArgs e)
	{
		cbxReportType.set_DataSource((object)_reportManager.GetReportTypes());
		((ListControl)cbxReportType).set_SelectedIndex(0);
		dtpHasta.set_Value(DateTime.Now);
		dtpDesde.set_Value(DateTime.Now.Subtract(TimeSpan.FromDays(180.0)));
	}

	private void btnFiltrar_Click(object sender, EventArgs e)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		if (dtpDesde.get_Value() > dtpHasta.get_Value())
		{
			MessageBox.Show("La fecha desde debe ser menor o igual que la fecha hasta");
		}
		dataGridView.set_DataSource((object)_reportManager.GetReport(cbxReportType.get_SelectedItem() as ReportType, dtpDesde.get_Value(), dtpHasta.get_Value()));
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
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected O, but got Unknown
		dataGridView = new DataGridView();
		groupBox = new GroupBox();
		dtpHasta = new DateTimePicker();
		dtpDesde = new DateTimePicker();
		label4 = new Label();
		btnFiltrar = new Button();
		label3 = new Label();
		searchPanel = new Panel();
		panel1 = new Panel();
		label1 = new Label();
		cbxReportType = new ComboBox();
		((ISupportInitialize)dataGridView).BeginInit();
		((Control)groupBox).SuspendLayout();
		((Control)searchPanel).SuspendLayout();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		dataGridView.set_AllowUserToAddRows(false);
		dataGridView.set_AllowUserToDeleteRows(false);
		dataGridView.set_AllowUserToOrderColumns(true);
		dataGridView.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		dataGridView.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)dataGridView).set_Dock((DockStyle)5);
		((Control)dataGridView).set_Location(new Point(0, 132));
		dataGridView.set_MultiSelect(false);
		((Control)dataGridView).set_Name("dataGridView");
		dataGridView.set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)dataGridView).set_Size(new Size(894, 415));
		((Control)dataGridView).set_TabIndex(9);
		((Control)groupBox).set_Anchor((AnchorStyles)13);
		((Control)groupBox).get_Controls().Add((Control)(object)dtpHasta);
		((Control)groupBox).get_Controls().Add((Control)(object)dtpDesde);
		((Control)groupBox).get_Controls().Add((Control)(object)label4);
		((Control)groupBox).get_Controls().Add((Control)(object)btnFiltrar);
		((Control)groupBox).get_Controls().Add((Control)(object)label3);
		((Control)groupBox).set_Location(new Point(12, 6));
		((Control)groupBox).set_Name("groupBox");
		((Control)groupBox).set_Size(new Size(870, 76));
		((Control)groupBox).set_TabIndex(2);
		groupBox.set_TabStop(false);
		((Control)groupBox).set_Text("Filtro");
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
		((Control)searchPanel).get_Controls().Add((Control)(object)groupBox);
		((Control)searchPanel).set_Dock((DockStyle)1);
		((Control)searchPanel).set_Location(new Point(0, 39));
		((Control)searchPanel).set_Name("searchPanel");
		((Control)searchPanel).set_Size(new Size(894, 93));
		((Control)searchPanel).set_TabIndex(11);
		((Control)panel1).set_BackColor(SystemColors.ControlDark);
		((Control)panel1).get_Controls().Add((Control)(object)label1);
		((Control)panel1).get_Controls().Add((Control)(object)cbxReportType);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(894, 39));
		((Control)panel1).set_TabIndex(10);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)label1).set_Location(new Point(12, 15));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(99, 13));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Tipo de Reporte");
		cbxReportType.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)cbxReportType).set_FormattingEnabled(true);
		((Control)cbxReportType).set_Location(new Point(117, 12));
		((Control)cbxReportType).set_Name("cbxReportType");
		((Control)cbxReportType).set_Size(new Size(400, 21));
		((Control)cbxReportType).set_TabIndex(0);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(894, 547));
		((Control)this).get_Controls().Add((Control)(object)dataGridView);
		((Control)this).get_Controls().Add((Control)(object)searchPanel);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("ListadoEstadisticoForm");
		((Control)this).set_Text("Listado estadístico");
		((Form)this).add_Load((EventHandler)ListadoEstadisticoForm_Load);
		((ISupportInitialize)dataGridView).EndInit();
		((Control)groupBox).ResumeLayout(false);
		((Control)groupBox).PerformLayout();
		((Control)searchPanel).ResumeLayout(false);
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
