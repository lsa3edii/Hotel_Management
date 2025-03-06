using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benchmark.Context;
using Benchmark.Dapper.Entities;
using Benchmark.Dapper.Managers;
using Benchmark.Entities;
using BenchmarkDotNet.Attributes;
using Microsoft.EntityFrameworkCore;


namespace Benchmark
{
    public class TestBenchmark
    {
        ReservationContext context;
        ReservationManager manager;

        public TestBenchmark() 
        {
            manager = new();
        }


        [Benchmark]
        public List<Reservation> SearchWithEF()
        {
            try
            {
                using (context = new())
                {
                    var reservations = context.Reservations
                           .Where(R => R.FirstName.ToLower().Contains("Muhammed".ToLower()))
                           .ToList();

                    return reservations;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return [];
        }


        [Benchmark]
        public List<ReservationDapper> SearchWithDapper()
        {
            try
            {
                var reservations = manager.GetAll()
                           .Where(R => R.First_Name.ToLower().Contains("Muhammed".ToLower()))
                           .ToList();

                return reservations;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return [];
        }



        [Benchmark]
        public List<Reservation> SearchWithEF_SP()
        {
            try
            {
                using (context = new())
                {
                    var reservations = context.Reservations
                            .FromSqlRaw($"EXEC SelectAllReservation")  
                            //.AsEnumerable()
                            .Where(R => R.FirstName.Contains("Muhammed".ToLower()))
                            .ToList();

                    return reservations;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new();
        }


        [Benchmark]
        public List<ReservationDapper> SearchWithDapper_SP()
        {
            try
            {
                var reservations = manager.GetAllReservations()
                           .Where(R => R.First_Name.ToLower().Contains("Muhammed".ToLower()))
                           .ToList();

                return reservations;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new();
        }



        [Benchmark]
        public Reservation GetFirstWithEF()
        {
            try
            {
                using (context = new())
                {
                    var reservation = context.Reservations
                           .FirstOrDefault(R => R.BirthDay == "01-16-1987");

                    return reservation ?? new();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new();
        }


        [Benchmark]
        public ReservationDapper GetFirstWithDapper()
        {
            try
            {
                var reservation = manager.GetAll()
                       .FirstOrDefault(R => R.Birth_Day == "01-16-1987");

                return reservation ?? new();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return new();
        }

    }
}
