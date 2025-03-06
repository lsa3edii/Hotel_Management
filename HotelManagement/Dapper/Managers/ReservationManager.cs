using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab15.Context;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;
using Lab15.Dapper.Entities;
using Dapper;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Lab15.Entities;

namespace HotelManagement.Dapper.Managers
{
    class ReservationManager : IManager<ReservationDapper>
    {
        DbConnection connection;
        ReservationContext context;



        public ReservationManager()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["FRONTEND_RESERVATION2"].ConnectionString);

            //using (context = new())
            //    connection = context.Database.GetDbConnection();
        }


        public bool Insert(ReservationDapper reservation)
            => connection.Execute("InsertReservation", GetParameters(reservation), commandType: CommandType.StoredProcedure) > 0;



        public bool Update(ReservationDapper reservation)
            => connection.Execute("UpdateReservation", GetParameters(reservation, 1), commandType: CommandType.StoredProcedure) > 0;


        public bool Delete(long ID)
            => connection.Execute("DeleteReservation", new { Id = ID },
                commandType: CommandType.StoredProcedure) > 0;


        public List<ReservationDapper> GetAll()
            => connection.Query<ReservationDapper>("select * from reservation")?.AsList() ?? [];


        public ReservationDapper GetByID(long ID)
            => connection.QueryFirstOrDefault<ReservationDapper>("select * from reservation where Id = @Id",
                new { Id = ID }) ?? new();


        private DynamicParameters GetParameters(ReservationDapper reservation, int flag = 0) {
            var parameters = new DynamicParameters();

            if (flag == 1)
                parameters.Add("@id", reservation.Id);

            parameters.Add("@first_name", reservation.First_Name);
            parameters.Add("@last_name", reservation.Last_Name);
            parameters.Add("@birth_day", reservation.Birth_Day);
            parameters.Add("@gender", reservation.Gender);
            parameters.Add("@phone_number", reservation.Phone_Number);
            parameters.Add("@email_address", reservation.Email_Address);
            parameters.Add("@number_guest", reservation.Number_Guest);
            parameters.Add("@street_address", reservation.Street_Address);
            parameters.Add("@apt_suite", reservation.Apt_Suite);
            parameters.Add("@city", reservation.City);
            parameters.Add("@state", reservation.State);
            parameters.Add("@zip_code", reservation.Zip_Code);
            parameters.Add("@room_type", reservation.Room_Type);
            parameters.Add("@room_floor", reservation.Room_Floor);
            parameters.Add("@room_number", reservation.Room_Number);
            parameters.Add("@total_bill", reservation.Total_Bill);
            parameters.Add("@payment_type", reservation.Payment_Type);
            parameters.Add("@card_type", reservation.Card_Type);
            parameters.Add("@card_number", reservation.Card_Number);
            parameters.Add("@card_exp", reservation.Card_Exp);
            parameters.Add("@card_cvc", reservation.Card_Cvc);
            parameters.Add("@arrival_time", reservation.Arrival_Time);
            parameters.Add("@leaving_time", reservation.Leaving_Time);
            parameters.Add("@check_in", reservation.Check_In);
            parameters.Add("@break_fast", reservation.Break_Fast);
            parameters.Add("@lunch", reservation.Lunch);
            parameters.Add("@dinner", reservation.Dinner);
            parameters.Add("@cleaning", reservation.Cleaning);
            parameters.Add("@towel", reservation.Towel);
            parameters.Add("@s_surprise", reservation.S_Surprise);
            parameters.Add("@supply_status", reservation.Supply_Status);
            parameters.Add("@food_bill", reservation.Food_Bill);

            return parameters;
        }

    }
}
