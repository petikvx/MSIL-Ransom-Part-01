using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Coache.AbmRol;
using Coache.Business;
using Coache.Common;
using Coache.Core;

namespace Coache;

[NonNavigable]
public class AddEditRoleForm : Form
{
	private IContainer components;

	private Label label1;

	private Label label2;

	private TextBox txtNombre;

	private CheckedListBox lstFuncionalidades;

	private Button btnGuardar;

	private Button btnClose;

	private Rol Rol { get; set; }

	public event EventHandler<RoleUpdatedEventArgs> OnRoleUpdated;

	public AddEditRoleForm()
		: this(new Rol())
	{
	}

	public AddEditRoleForm(Rol rol)
	{
		InitializeComponent();
		Rol = rol;
	}

	private void AddEditRoleForm_Load(object sender, EventArgs e)
	{
		ProcessForm();
	}

	private void ProcessForm()
	{
		foreach (Functionalities allFunctionality in new FunctionalitiesManager().GetAllFunctionalities())
		{
			lstFuncionalidades.get_Items().Add((object)allFunctionality, RoleHasFunctionality(allFunctionality));
		}
		((Control)txtNombre).set_Text(Rol.Nombre);
	}

	private bool RoleHasFunctionality(Functionalities functionality)
	{
		if (Rol != null && Rol.Functionalities != null)
		{
			return Rol.Functionalities.Contains(functionality);
		}
		return false;
	}

	private void btnGuardar_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrEmpty(((Control)txtNombre).get_Text().Trim()))
		{
			MessageBox.Show("El nombre del Rol no puede ser nulo");
			return;
		}
		Rol.Functionalities = new List<Functionalities>();
		foreach (Functionalities checkedItem in lstFuncionalidades.get_CheckedItems())
		{
			Rol.Functionalities.Add(checkedItem);
		}
		Rol.Nombre = ((Control)txtNombre).get_Text();
		if (this.OnRoleUpdated != null)
		{
			this.OnRoleUpdated(this, new RoleUpdatedEventArgs
			{
				Rol = Rol
			});
		}
	}

	private void btnClose_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
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
		label1 = new Label();
		label2 = new Label();
		txtNombre = new TextBox();
		lstFuncionalidades = new CheckedListBox();
		btnGuardar = new Button();
		btnClose = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(12, 33));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(44, 13));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Nombre");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(12, 61));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(84, 13));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Funcionalidades");
		((Control)txtNombre).set_Location(new Point(116, 30));
		((TextBoxBase)txtNombre).set_MaxLength(100);
		((Control)txtNombre).set_Name("txtNombre");
		((Control)txtNombre).set_Size(new Size(156, 20));
		((Control)txtNombre).set_TabIndex(2);
		((ListControl)lstFuncionalidades).set_FormattingEnabled(true);
		((Control)lstFuncionalidades).set_Location(new Point(116, 56));
		((Control)lstFuncionalidades).set_Name("lstFuncionalidades");
		((Control)lstFuncionalidades).set_Size(new Size(156, 139));
		((Control)lstFuncionalidades).set_TabIndex(3);
		((Control)btnGuardar).set_Location(new Point(197, 201));
		((Control)btnGuardar).set_Name("btnGuardar");
		((Control)btnGuardar).set_Size(new Size(75, 23));
		((Control)btnGuardar).set_TabIndex(4);
		((Control)btnGuardar).set_Text("Guardar");
		((ButtonBase)btnGuardar).set_UseVisualStyleBackColor(true);
		((Control)btnGuardar).add_Click((EventHandler)btnGuardar_Click);
		btnClose.set_DialogResult((DialogResult)2);
		((Control)btnClose).set_Location(new Point(13, 200));
		((Control)btnClose).set_Name("btnClose");
		((Control)btnClose).set_Size(new Size(75, 23));
		((Control)btnClose).set_TabIndex(5);
		((Control)btnClose).set_Text("Cancelar");
		((ButtonBase)btnClose).set_UseVisualStyleBackColor(true);
		((Control)btnClose).add_Click((EventHandler)btnClose_Click);
		((Form)this).set_AcceptButton((IButtonControl)(object)btnGuardar);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_CancelButton((IButtonControl)(object)btnClose);
		((Form)this).set_ClientSize(new Size(284, 231));
		((Control)this).get_Controls().Add((Control)(object)btnClose);
		((Control)this).get_Controls().Add((Control)(object)btnGuardar);
		((Control)this).get_Controls().Add((Control)(object)lstFuncionalidades);
		((Control)this).get_Controls().Add((Control)(object)txtNombre);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("AddEditRoleForm");
		((Form)this).set_ShowIcon(false);
		((Form)this).add_Load((EventHandler)AddEditRoleForm_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
