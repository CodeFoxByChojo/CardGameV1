using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text;

namespace MySqlLite {
    //public class sqlcontroller {

    //    private SqliteConnection sqlite;

    //    slave slave = new slave();

    //    public string _databaseurl;

    //    public void DataClass() {
    //        sqlite = new SqliteConnection("Data Source=" + _databaseurl);
    //    }

    //    public void writedatabase(int field_x_variable, int field_y_variable, int team, int cardid) {

    //        _databaseurl = slave.generatefolderpath();

    //        IDbConnection _connection = new SqliteConnection(_databaseurl);
    //        IDbCommand _command = _connection.CreateCommand();
    //        string sql;

    //        sql = "INSERT INTO fielddata (field_x, field_y, team, cardid) VALUES (@field_x, @field_y, @team, @cardid)";

    //        _command.Parameters.Add(new SqliteParameter("@field_x", field_x_variable));
    //        _command.Parameters.Add(new SqliteParameter("@field_y", field_y_variable));
    //        _command.Parameters.Add(new SqliteParameter("@team", team));
    //        _command.Parameters.Add(new SqliteParameter("@cardid", cardid));

    //        _command.CommandText = sql;
    //        _command.ExecuteNonQuery();
    //        _command.Dispose();
    //    }

    //    public void createtable() {

    //        _databaseurl = slave.generatefolderpath();

    //        IDbConnection _connection = new SqliteConnection(_databaseurl);
    //        IDbCommand _command = _connection.CreateCommand();
    //        string sql;

    //        sql = "CREATE TABLE fielddata (field_x INT, field_y INT, team INT, cardid INT)";

    //        _command.CommandText = sql;
    //        _command.ExecuteNonQuery();
    //        _command.Dispose();
    //    }

    //    public void dropandclose() {

    //        _databaseurl = slave.generatefolderpath();

    //        IDbConnection _connection = new SqliteConnection(_databaseurl);
    //        IDbCommand _command = _connection.CreateCommand();
    //        string sql;

    //        sql = "DROP Table 'fieldata'";

    //        _command.CommandText = sql;
    //        _connection.Close();
    //        _command.ExecuteNonQuery();
    //    }

    //    public void connectionClose() {

    //        _databaseurl = slave.generatefolderpath();

    //        IDbConnection _connection = new SqliteConnection(_databaseurl);
    //        IDbCommand _command = _connection.CreateCommand();

    //        _connection.Close();
    //    }

    //    public void connectionOpen() {

    //        _databaseurl = slave.generatefolderpath();


    //        IDbConnection _connection = new SqliteConnection(_databaseurl);
    //        IDbCommand _command = _connection.CreateCommand();
    //        Debug.Log("Der Datenbankpfad lautet: " + _databaseurl);

    //        _connection.Open();
    //    }

    //    public string databasepath() {

    //        _databaseurl = slave.generatefolderpath();

    //        string path = _databaseurl;

    //        return path;
    //    }
    //}
}

