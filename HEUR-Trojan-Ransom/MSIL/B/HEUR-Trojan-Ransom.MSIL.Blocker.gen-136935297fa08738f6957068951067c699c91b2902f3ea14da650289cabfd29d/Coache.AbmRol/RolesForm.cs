using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Coache.Business;
using Coache.Common;
using Coache.Core;

namespace Coache.AbmRol;

[PermissionRequired(new Functionalities[] { Functionalities.AdministrarRoles })]
public class RolesForm : Form
{
	private RolesManager rolesManager = new RolesManager();

	private IContainer components;

	private DataGridView rolesDataGridView;

	private Panel panel1;

	private Button btnAgregar;

	private Button btnEliminar;

	private Button btnModificar;

	private DataGridViewTextBoxColumn ID;

	private DataGridViewTextBoxColumn Nombre;

	private Label lblResults;

	private Label label5;

	public RolesForm()
	{
		InitializeComponent();
	}

	private void RolesForm_Load(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		new BindingSource();
		BindingList<Rol> roles = rolesManager.GetRoles();
		rolesDataGridView.add_DataSourceChanged((EventHandler)rolesDataGridView_DataSourceChanged);
		rolesDataGridView.set_AutoGenerateColumns(false);
		rolesDataGridView.set_DataSource((object)roles);
	}

	private void rolesDataGridView_DataSourceChanged(object sender, EventArgs e)
	{
		IList list = rolesDataGridView.get_DataSource() as IList;
		((Control)lblResults).set_Text(list.Count.ToString());
	}

	private void btnAgregar_Click(object sender, EventArgs e)
	{
		AddEditRoleForm addEditRoleForm = new AddEditRoleForm();
		addEditRoleForm.OnRoleUpdated += addEditForm_OnRoleUpdated;
		ViewsManager.LoadModal((Form)(object)addEditRoleForm);
	}

	private void addEditForm_OnRoleUpdated(object sender, RoleUpdatedEventArgs e)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			BindingList<Rol> bindingList = rolesDataGridView.get_DataSource() as BindingList<Rol>;
			if (e.Rol.ID == 0 && bindingList.Where((Rol x) => x.Nombre.Trim().ToUpperInvariant() == e.Rol.Nombre.Trim().ToUpperInvariant()).Count() >= 1)
			{
				MessageBox.Show("Ya hay un rol con ese nombre, ingrese uno nuevo");
				return;
			}
			new RolesManager().SaveRole(e.Rol);
			MessageBox.Show($"Rol {e.Rol.Nombre} guardado correctamente");
			if (bindingList.Contains(e.Rol))
			{
				bindingList.Remove(e.Rol);
			}
			bindingList.Add(e.Rol);
			((Control)rolesDataGridView).Refresh();
		}
		catch
		{
			MessageBox.Show("Error al guardar el rol");
		}
	}

	private void btnEliminar_Click(object sender, EventArgs e)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Invalid comparison between Unknown and I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		if (rolesDataGridView.get_SelectedRows() == null || ((BaseCollection)rolesDataGridView.get_SelectedRows()).get_Count() == 0)
		{
			return;
		}
		Rol rol = rolesDataGridView.get_SelectedRows().get_Item(0).get_DataBoundItem() as Rol;
		if (rol.ID == Session.DefaultRoleID)
		{
			MessageBox.Show("Rol no editable");
		}
		else if ((int)MessageBox.Show($"Confirma que desea eliminar el rol {rol.Nombre}?", "Eliminar rol", (MessageBoxButtons)1) == 1)
		{
			try
			{
				rolesManager.DeleteRole(rol);
				(rolesDataGridView.get_DataSource() as BindingList<Rol>).Remove(rol);
				((Control)rolesDataGridView).Refresh();
				MessageBox.Show($"Rol {rol.Nombre} eliminado");
			}
			catch
			{
				MessageBox.Show("Error al eliminar el rol");
			}
		}
	}

	private void btnModificar_Click(object sender, EventArgs e)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		if (rolesDataGridView.get_SelectedRows() != null && ((BaseCollection)rolesDataGridView.get_SelectedRows()).get_Count() != 0)
		{
			Rol rol = rolesDataGridView.get_SelectedRows().get_Item(0).get_DataBoundItem() as Rol;
			if (rol.ID == Session.DefaultRoleID)
			{
				MessageBox.Show("Rol no editable");
				return;
			}
			AddEditRoleForm addEditRoleForm = new AddEditRoleForm(rol);
			addEditRoleForm.OnRoleUpdated += addEditForm_OnRoleUpdated;
			ViewsManager.LoadModal((Form)(object)addEditRoleForm);
		}
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
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Expected O, but got Unknown
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		rolesDataGridView = new DataGridView();
		ID = new DataGridViewTextBoxColumn();
		Nombre = new DataGridViewTextBoxColumn();
		panel1 = new Panel();
		btnEliminar = new Button();
		btnModificar = new Button();
		btnAgregar = new Button();
		lblResults = new Label();
		label5 = new Label();
		((ISupportInitialize)rolesDataGridView).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		rolesDataGridView.set_AllowUserToAddRows(false);
		rolesDataGridView.set_AllowUserToDeleteRows(false);
		rolesDataGridView.set_AllowUserToOrderColumns(true);
		rolesDataGridView.set_AutoSizeColumnsMode((DataGridViewAutoSizeColumnsMode)16);
		rolesDataGridView.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		rolesDataGridView.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[2]
		{
			(DataGridViewColumn)ID,
			(DataGridViewColumn)Nombre
		});
		((Control)rolesDataGridView).set_Dock((DockStyle)5);
		((Control)rolesDataGridView).set_Location(new Point(0, 39));
		rolesDataGridView.set_MultiSelect(false);
		((Control)rolesDataGridView).set_Name("rolesDataGridView");
		rolesDataGridView.set_SelectionMode((DataGridViewSelectionMode)1);
		((Control)rolesDataGridView).set_Size(new Size(1072, 540));
		((Control)rolesDataGridView).set_TabIndex(0);
		((DataGridViewColumn)ID).set_DataPropertyName("ID");
		((DataGridViewColumn)ID).set_FillWeight(20.30457f);
		((DataGridViewColumn)ID).set_HeaderText("ID");
		((DataGridViewColumn)ID).set_Name("ID");
		((DataGridViewBand)ID).set_ReadOnly(true);
		((DataGridViewColumn)Nombre).set_DataPropertyName("Nombre");
		((DataGridViewColumn)Nombre).set_FillWeight(179.6954f);
		((DataGridViewColumn)Nombre).set_HeaderText("Nombre");
		((DataGridViewColumn)Nombre).set_Name("Nombre");
		((DataGridViewBand)Nombre).set_ReadOnly(true);
		((Control)panel1).set_BackColor(SystemColors.ControlDark);
		((Control)panel1).get_Controls().Add((Control)(object)lblResults);
		((Control)panel1).get_Controls().Add((Control)(object)btnEliminar);
		((Control)panel1).get_Controls().Add((Control)(object)label5);
		((Control)panel1).get_Controls().Add((Control)(object)btnModificar);
		((Control)panel1).get_Controls().Add((Control)(object)btnAgregar);
		((Control)panel1).set_Dock((DockStyle)1);
		((Control)panel1).set_Location(new Point(0, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(1072, 39));
		((Control)panel1).set_TabIndex(1);
		((Control)btnEliminar).set_Location(new Point(174, 10));
		((Control)btnEliminar).set_Name("btnEliminar");
		((Control)btnEliminar).set_Size(new Size(75, 23));
		((Control)btnEliminar).set_TabIndex(2);
		((Control)btnEliminar).set_Text("Eliminar");
		((ButtonBase)btnEliminar).set_UseVisualStyleBackColor(true);
		((Control)btnEliminar).add_Click((EventHandler)btnEliminar_Click);
		((Control)btnModificar).set_Location(new Point(93, 10));
		((Control)btnModificar).set_Name("btnModificar");
		((Control)btnModificar).set_Size(new Size(75, 23));
		((Control)btnModificar).set_TabIndex(1);
		((Control)btnModificar).set_Text("Modificar");
		((ButtonBase)btnModificar).set_UseVisualStyleBackColor(true);
		((Control)btnModificar).add_Click((EventHandler)btnModificar_Click);
		((Control)btnAgregar).set_Location(new Point(12, 10));
		((Control)btnAgregar).set_Name("btnAgregar");
		((Control)btnAgregar).set_Size(new Size(75, 23));
		((Control)btnAgregar).set_TabIndex(0);
		((Control)btnAgregar).set_Text("Nuevo");
		((ButtonBase)btnAgregar).set_UseVisualStyleBackColor(true);
		((Control)btnAgregar).add_Click((EventHandler)btnAgregar_Click);
		((Control)lblResults).set_Anchor((AnchorStyles)9);
		((Control)lblResults).set_AutoSize(true);
		((Control)lblResults).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblResults).set_ForeColor(SystemColors.ControlLightLight);
		((Control)lblResults).set_Location(new Point(975, 15));
		((Control)lblResults).set_Name("lblResults");
		((Control)lblResults).set_Size(new Size(14, 13));
		((Control)lblResults).set_TabIndex(11);
		((Control)lblResults).set_Text("0");
		((Control)label5).set_Anchor((AnchorStyles)9);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label5).set_Location(new Point(995, 15));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(65, 13));
		((Control)label5).set_TabIndex(10);
		((Control)label5).set_Text("resultados");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1072, 579));
		((Control)this).get_Controls().Add((Control)(object)rolesDataGridView);
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).set_Name("RolesForm");
		((Control)this).set_Text("Roles");
		((Form)this).add_Load((EventHandler)RolesForm_Load);
		((ISupportInitialize)rolesDataGridView).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
