using System.Collections;
using System.Collections.Generic;
//https://learn.microsoft.com/en-us/dotnet/standard/data/sqlite/?tabs=net-cli
using UnityEngine;
using Mono.Data.Sqlite;
public class SimpleDB : MonoBehaviour
{


    private string dbName = "URI = file:Inventory.db";
    // Start is called before the first frame update
    void Start()
    {
        CreateDB();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //TODO: Create Method for CreateDB()
    
    //Create the Method
    private void CreateDB()
    {
        using (var connection = new SqliteConnection (dbName))
        {
            connection.Open ();
            using(var command = connection.CreateCommand())
            {
                command.CommandText = "CREATE TABLE IF NOT EXISTS weapons (name VARCHAR (20), qte INT)";
                command.ExecuteNonQuery ();
            }
            connection.Close();
        }
    }
}
