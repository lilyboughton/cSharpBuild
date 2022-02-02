using System;
using Microsoft.Data.SqlClient;

namespace harryPotter.src.Classes;

public class CharacterDisplay
{
	public static List<Character> getAllCharacters(SqlConnection connection)
	{
		List<Character> allCharacters = new List<Character>();

        using (SqlCommand command = new SqlCommand("SELECT * FROM harry_potter_top_trumps", connection))
        {
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Character c = new Character();

                        c.Id = reader.GetInt32(0);
                        c.Name = reader.GetString(reader.GetOrdinal("name"));
                        c.ImgUrl = reader.GetString(reader.GetOrdinal("img_url"));

                        allCharacters.Add(c);
                    }
                }
            }
        }
        return allCharacters;  
	}

    public static Character getCharacterDetails(SqlConnection connection, int id)
    {
        int charId = id;
        string sql = "SELECT * FROM harry_potter_top_trumps WHERE id = " + charId;

        using (SqlCommand command = new SqlCommand(sql, connection))
        {
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Character c = new Character();

                        c.Id = reader.GetInt32(0);
                        c.Name = reader.GetString(reader.GetOrdinal("name"));
                        c.Magic = reader.GetInt32(reader.GetOrdinal("magic"));
                        c.Cunning = reader.GetInt32(reader.GetOrdinal("cunning"));
                        c.Courage = reader.GetInt32(reader.GetOrdinal("courage"));
                        c.Wisdom = reader.GetInt32(reader.GetOrdinal("wisdom"));
                        c.Temper = reader.GetInt32(reader.GetOrdinal("temper"));
                        c.ImgUrl = reader.GetString(reader.GetOrdinal("img_url"));

                        return c;
                    }
                } 
            }
        }
        return null;
    }

    public static List<Character> searchCharacters (SqlConnection connection, string searchString)
    {
        string search = searchString;
        string sql = "SELECT * FROM harry_potter_top_trumps WHERE name LIKE '%" + search + "%'";
        List<Character> characters = new List<Character>();

        using (SqlCommand command = new SqlCommand(sql, connection))
        {
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Character c = new Character();

                        c.Id = reader.GetInt32(0);
                        c.Name = reader.GetString(reader.GetOrdinal("name"));
                        c.ImgUrl = reader.GetString(reader.GetOrdinal("img_url"));

                        characters.Add(c);
                    }
                }
            }
        }
        return characters;

    }
}
