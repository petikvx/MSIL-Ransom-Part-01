using System.ComponentModel;
using System.Configuration;
using System.Data;
using Coache.Common;
using Data;

namespace Coache.Business;

public class RolesManager
{
	public BindingList<Rol> GetRoles()
	{
		DataTable dataTable = SqlDataAccess.ExecuteDataTableQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetRoles");
		BindingList<Rol> bindingList = new BindingList<Rol>();
		FunctionalitiesManager functionalitiesManager = new FunctionalitiesManager();
		foreach (DataRow row in dataTable.Rows)
		{
			Rol item = new Rol
			{
				ID = int.Parse(row["ID"].ToString()),
				Nombre = row["Descripcion"].ToString(),
				Functionalities = functionalitiesManager.GetRoleFunctionalities(int.Parse(row["ID"].ToString()))
			};
			bindingList.Add(item);
		}
		return bindingList;
	}

	public void DeleteRole(Rol rol)
	{
		SqlDataAccess.ExecuteNonQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.DeleteRole", SqlDataAccessArgs.CreateWith("@Rol_ID", rol.ID).Arguments);
	}

	public void SaveRole(Rol rol)
	{
		if (rol.ID > 0)
		{
			UpdateRole(rol);
		}
		else
		{
			InsertRole(rol);
		}
	}

	private void InsertRole(Rol rol)
	{
		int num2 = (rol.ID = SqlDataAccess.ExecuteScalarQuery<int>(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.InsertRole", SqlDataAccessArgs.CreateWith("@Description", rol.Nombre).Arguments));
		UpdateRoleFunctionalities(rol);
	}

	private void UpdateRole(Rol rol)
	{
		SqlDataAccess.ExecuteNonQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.UpdateRole", SqlDataAccessArgs.CreateWith("@Description", rol.Nombre).And("@ID", rol.ID).Arguments);
		UpdateRoleFunctionalities(rol);
	}

	private void UpdateRoleFunctionalities(Rol rol)
	{
		FunctionalitiesManager functionalitiesManager = new FunctionalitiesManager();
		if (rol.ID > 0)
		{
			functionalitiesManager.DeleteRoleFunctionalities(rol);
		}
		foreach (Functionalities functionality in rol.Functionalities)
		{
			functionalitiesManager.InsertRoleFunctionality(rol, functionality);
		}
	}

	public int GetDefaultRoleID()
	{
		return SqlDataAccess.ExecuteScalarQuery<int>(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetDefaultRoleID");
	}
}
