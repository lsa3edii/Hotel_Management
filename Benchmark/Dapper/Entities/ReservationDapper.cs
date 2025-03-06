#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Benchmark.Dapper.Entities;

/*
Dapper:
Uses case-sensitive column-to-property mapping by default.
Does not use[Column] attributes for mapping(unlike EF).
Needs explicit aliasing in SQL or a custom mapper to work.
*/
public partial class ReservationDapper
{
    public int Id { get; set; }

    public string First_Name { get; set; }

    public string Last_Name { get; set; }

    [NotMapped]
    //[IgnoreDataMember]
    public string FullName => $"{First_Name} {Last_Name}";


    public string Birth_Day { get; set; }


    [NotMapped]
    public string Day => Birth_Day.Split("-")[1];

    [NotMapped]
    public string Month => Birth_Day.Split("-")[0];

    [NotMapped]
    public string Year => Birth_Day.Split("-")[2];

    
    public string Gender { get; set; }

    public string Phone_Number { get; set; }

    public string Email_Address { get; set; }

    public int Number_Guest { get; set; }

    public string Street_Address { get; set; }

    public string Apt_Suite { get; set; }

    public string City { get; set; }

    public string State { get; set; }

    public string Zip_Code { get; set; }

    public string Room_Type { get; set; }

    public string Room_Floor { get; set; }

    public string Room_Number { get; set; }

    public double Total_Bill { get; set; }

    public string Payment_Type { get; set; }

    public string Card_Type { get; set; }

    public string Card_Number { get; set; }


    public string Card_Exp { get; set; }


    [NotMapped]
    public string CardExpMonth
    {
        get => !string.IsNullOrEmpty(Card_Exp) && Card_Exp.Contains("/") ? Card_Exp.Split('/')[0] : "";
        set
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(Card_Exp) && Card_Exp.Contains("/"))
                Card_Exp = value + "/" + Card_Exp.Split('/')[1];
        }
    }


    [NotMapped]
    public string CardExpYear
    {
        get => !string.IsNullOrEmpty(Card_Exp) && Card_Exp.Contains("/") ? Card_Exp.Split('/')[1] : "";
        set
        {
            if (!string.IsNullOrEmpty(value) && !string.IsNullOrEmpty(Card_Exp) && Card_Exp.Contains("/"))
                Card_Exp = Card_Exp.Split('/')[0] + "/" + value;
        }
    }


    public string Card_Cvc { get; set; }

    public DateTime Arrival_Time { get; set; }

    public DateTime Leaving_Time { get; set; }

    public bool Check_In { get; set; }

    public int Break_Fast { get; set; }

    public int Lunch { get; set; }

    public int Dinner { get; set; }

    public bool Cleaning { get; set; }

    public bool Towel { get; set; }

    public bool S_Surprise { get; set; }

    public bool Supply_Status { get; set; }

    public int Food_Bill { get; set; }

    public override string ToString()
            => $"{Id} | {FullName} | {Phone_Number}";
}
