using System.Configuration;
using System.Data.SqlClient;
using Coache.Common;
using Data;

namespace Coache.Business;

public class DetalleEntidadManager
{
	public int AddDetalleEntidad(User user)
	{
		SqlTransaction val = (SessionData.Contains("Transaction") ? SessionData.Get<SqlTransaction>("Transaction") : null);
		if (val != null)
		{
			return SqlDataAccess.ExecuteScalarQuery<int>("GRUPO_N.InsertDetalleEntidad", SqlDataAccessArgs.CreateWith("@Telefono", user.DetalleEntidad.Telefono).And("@Email", user.DetalleEntidad.Email).And("@ID_Usuario", user.UserID)
				.And("@Direccion", user.DetalleEntidad.Direccion)
				.And("@ID_Ciudad", user.DetalleEntidad.Ciudad.ID)
				.And("@CP", user.DetalleEntidad.CP)
				.Arguments, val);
			}
			return SqlDataAccess.ExecuteScalarQuery<int>(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.InsertDetalleEntidad", SqlDataAccessArgs.CreateWith("@Telefono", user.DetalleEntidad.Telefono).And("@Email", user.DetalleEntidad.Email).And("@ID_Usuario", user.UserID)
				.And("@Direccion", user.DetalleEntidad.Direccion)
				.And("@ID_Ciudad", user.DetalleEntidad.Ciudad.ID)
				.And("@CP", user.DetalleEntidad.CP)
				.Arguments);
			}

			internal void UpdateDetalleEntidad(User user)
			{
				SqlDataAccess.ExecuteNonQuery(((object)ConfigurationManager.get_ConnectionStrings().get_Item("GrouponConnectionString")).ToString(), "GRUPO_N.UpdateDetalleEntidad", SqlDataAccessArgs.CreateWith("@Telefono", user.DetalleEntidad.Telefono).And("@Email", user.DetalleEntidad.Email).And("@ID_Usuario", user.UserID)
					.And("@Direccion", user.DetalleEntidad.Direccion)
					.And("@ID_Ciudad", user.DetalleEntidad.Ciudad.ID)
					.And("@CP", user.DetalleEntidad.CP)
					.Arguments);
				}
			}
