using DBLayer;
using GymVertical.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymVertical.Repositories
{
    public class MemberRepository
    {
        public static Member GetMember(int id)
        {
            Member member = null;
            string sql = $"SELECT * FROM MembersCard WHERE BrojKartice = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                member = CreateObject(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return member;
        }

        public static List<Member> GetMembers()
        {
            List<Member> members = new List<Member>();
            string sql = "SELECT * FROM MembersCard";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Member member = CreateObject(reader);
                members.Add(member);
            }
            reader.Close();
            DB.CloseConnection();
            return members;
        }

        private static Member CreateObject(SqlDataReader reader)
        {
            int brojKartice = int.Parse(reader["BrojKartice"].ToString());
            string firstName = reader["Ime"].ToString();
            string lastName = reader["Prezime"].ToString();
            string mjestoStanovanja = reader["MjestoStanovanja"].ToString();
            string brojMobitela = reader["BrojMobitela"].ToString();
            string statusZlatniClan = reader["StatusZlatniClan"].ToString();
            string pogodnosti = reader["Pogodnost"].ToString();

            var member = new Member
            {
                BrojKartice = brojKartice,
                Ime = firstName,
                Prezime = lastName,
                MjestoStanovanja = mjestoStanovanja,
                BrojMobitela = brojMobitela,
                StatusZlatniClan = statusZlatniClan,
                Pogodnost = pogodnosti
            };
            return member;
        }

        public static void InsertMember(string firstName, string lastName, string livingPlace, string phoneNumber, string statusGoldMember, string benefit)
        {
            string sql = $"INSERT INTO MembersCard (Ime, Prezime, MjestoStanovanja, BrojMobitela, StatusZlatniClan, Pogodnost) VALUES('{firstName}', '{lastName}','{livingPlace}', '{phoneNumber}', '{statusGoldMember}', '{benefit}')";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateStatus(string statusGoldMember, int cardNumber)
        {
            string sql = $"UPDATE MembersCard SET StatusZlatniClan = '{statusGoldMember}' WHERE BrojKartice = '{cardNumber}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateBenefit(string benefit, int cardNumber)
        {
            string sql = $"UPDATE MembersCard SET Pogodnost = '{benefit}' WHERE BrojKartice = '{cardNumber}'";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void DeleteMember(int cardNumber)
        {
            string sql = $"DELETE FROM MembersCard WHERE BrojKartice = {cardNumber};";
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
