using Microsoft.Data.SqlClient;
using System.Data.Common;
using System.Data;
using Benchmark.Dapper.Entities;
using System.Configuration;
using Dapper;


namespace Benchmark.Dapper.Managers
{
    class ReservationManager : IManager<ReservationDapper>
    {
        DbConnection connection;


        public ReservationManager()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FRONTEND_RESERVATION2"].ConnectionString);
        }


        public List<ReservationDapper> GetAll()
            => connection.Query<ReservationDapper>("select * from reservation")?.AsList() ?? [];


        public ReservationDapper GetByID(long ID)
            => connection.QueryFirstOrDefault<ReservationDapper>("select * from reservation where Id = @Id",
                new { Id = ID }) ?? new();


        public List<ReservationDapper> GetAllReservations()
        {
            var reservations = connection.Query<ReservationDapper>("SelectAllReservation",
                commandType: CommandType.StoredProcedure)
                .ToList();

            return reservations;
        }

    }
}
