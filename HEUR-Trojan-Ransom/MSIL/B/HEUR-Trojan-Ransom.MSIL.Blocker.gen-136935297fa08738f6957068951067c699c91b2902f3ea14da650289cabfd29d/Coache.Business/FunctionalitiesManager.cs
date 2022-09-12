using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using Coache.Common;
using Data;

namespace Coache.Business;

public class FunctionalitiesManager
{
	public List<Functionalities> GetAllFunctionalities()
	{
		return Enum.GetValues(typeof(Functionalities)).Cast<Functionalities>().ToList();
	}

	public void DeleteRoleFunctionalities(Rol rol)
	{
		SqlDataAccess.ExecuteNonQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.DeleteRoleFunctionalities", SqlDataAccessArgs.CreateWith("@Rol_ID", rol.ID).Arguments);
	}

	public void InsertRoleFunctionality(Rol rol, Functionalities functionality)
	{
		SqlDataAccess.ExecuteNonQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.InsertRoleFunctionality", SqlDataAccessArgs.CreateWith("@Rol_ID", rol.ID).And("@Funcionalidad", functionality.ToString()).Arguments);
	}

	public List<Functionalities> GetRoleFunctionalities(int roleId)
	{
		List<Functionalities> list = new List<Functionalities>();
		DataTable dataTable = SqlDataAccess.ExecuteDataTableQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetRoleFunctionalities", SqlDataAccessArgs.CreateWith("@Rol_ID", roleId).Arguments);
		if (dataTable != null)
		{
			foreach (DataRow row in dataTable.Rows)
			{
				string value = row["Descripcion"].ToString();
				Functionalities item = (Functionalities)Enum.Parse(typeof(Functionalities), value);
				list.Add(item);
			}
			return list;
		}
		return list;
	}
}
