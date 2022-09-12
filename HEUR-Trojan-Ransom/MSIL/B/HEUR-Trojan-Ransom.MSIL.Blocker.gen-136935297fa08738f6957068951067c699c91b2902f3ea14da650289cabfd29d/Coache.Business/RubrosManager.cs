using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Coache.Common;
using Data;

namespace Coache.Business;

public class RubrosManager
{
	public List<Rubro> GetAll()
	{
		List<Rubro> list = new List<Rubro>();
		DataTable dataTable = SqlDataAccess.ExecuteDataTableQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetRubros");
		if (dataTable != null)
		{
			foreach (DataRow row in dataTable.Rows)
			{
				list.Add(new Rubro
				{
					ID = int.Parse(row["ID"].ToString()),
					Name = row["Descripcion"].ToString()
				});
			}
			return list;
		}
		return list;
	}
}
