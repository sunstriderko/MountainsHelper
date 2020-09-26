using MountainHelperLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace MountainHelperLibrary
{
    public class DataAccess
    {
        public MountainModel CreateMountain(MountainModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Mountains")))
            // connection, using statement is destroyed after the code inside is done so we dont leave out anything to be seen 
            {
                var m = new DynamicParameters();
                m.Add("MountainName", model.MountainName);
                m.Add("MountainHeight", model.MountainHeight);
                m.Add("MountainDifficulty", model.MountainDifficulty);
                m.Add("MountainTourStart", model.MountainTimeOfTour);
                m.Add("MountainTimeOfTour", model.MountainTimeOfTour);
                m.Add("MountainCountryName", model.MountainCountryName);
                m.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spMountains_Insert", m, commandType: CommandType.StoredProcedure);

                model.Id = m.Get<int>("@id");

                return model;
            }
        }

        public CountryModel CreateCountry(CountryModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Mountains")))
            {
                var c = new DynamicParameters();
                c.Add("CountryName", model.CountryName);
                c.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCountries_Insert", c, commandType: CommandType.StoredProcedure);

                model.Id = c.Get<int>("@id");

                return model;
            }
        }


        public List<MountainModel> GetMountains()
        {
            List<MountainModel> mountains = new List<MountainModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Mountains")))
            {
                mountains = connection.Query<MountainModel>("dbo.spMountains_GetAll").ToList();
            }

            return mountains;
        }

        public List<CountryModel> GetCountries()
        {
            List<CountryModel> countries = new List<CountryModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Mountains")))
            {
                countries = connection.Query<CountryModel>("dbo.spCountries_GetAll").ToList();
            }

            return countries;
        }

        public void UpdateStatus(MountainModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Mountains")))
            {
                var m = new DynamicParameters();
                m.Add("@id", model.Id);
                m.Add("MountainFinished", model.MountainFinished);
                    
                connection.Execute("dbo.spMountains_Update", m, commandType: CommandType.StoredProcedure);
            }
        }

        public List<MountainModel> GetMountainsFinished()
        {
            List<MountainModel> mountains = new List<MountainModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Mountains")))
            {
                mountains = connection.Query<MountainModel>("dbo.spMountains_GetByFinished").ToList();
            }

            return mountains;
        }

        public List<MountainModel> GetMountainsUnfinished()
        {
            List<MountainModel> mountains = new List<MountainModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Mountains")))
            {
                mountains = connection.Query<MountainModel>("dbo.spMountains_GetByUnfinished").ToList();
            }

            return mountains;
        }

        public void RemoveMountain(MountainModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Mountains")))
            {
                if (model != null)
                {
                    var m = new DynamicParameters();

                    m.Add("@MountainName", model.MountainName);

                    connection.Execute("dbo.spMountains_Remove", m, commandType: CommandType.StoredProcedure);
                }
            }
        }

        public void RemoveCountry(CountryModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("Mountains")))
            {
                if (model != null)
                {
                    var c = new DynamicParameters();

                    c.Add("@CountryName", model.CountryName);

                    connection.Execute("dbo.spCountry_Remove", c, commandType: CommandType.StoredProcedure);
                }
            }
        }
    }
}

