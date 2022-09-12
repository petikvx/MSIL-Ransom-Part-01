using System.Collections.Generic;
using System.Configuration;
using System.Data;
using Coache.Common;
using Data;

namespace Coache.Business;

public class CiudadesManager
{
	public List<City> GetAll()
	{
		if (SessionData.Contains("Cities"))
		{
			return SessionData.Get<List<City>>("Cities");
		}
		List<City> list = new List<City>();
		DataTable dataTable = SqlDataAccess.ExecuteDataTableQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.GetCiudades");
		if (dataTable != null)
		{
			foreach (DataRow row in dataTable.Rows)
			{
				list.Add(new City
				{
					ID = int.Parse(row["ID"].ToString()),
					Name = row["Descripcion"].ToString()
				});
			}
		}
		SessionData.Set("Cities", list);
		return list;
	}
}
