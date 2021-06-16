﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class DataManager
{
    public static string DBFilePath = "E:\\valea\\UNIV\\KULIAH\\YEAR 1\\SEMESTER 2\\IOOP\\Assignment\\Code\\IOOP-Project\\LibraryReservation\\LibraryDatabase.mdf";
    
    #region Connection String
    public static string constr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" + DBFilePath + ";Integrated Security=True";
    #endregion



    #region Disconnected
    public static DataSet GetDataSet(string stored_name, string table_name, params SqlParameter[] prmarr)
    {
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand(stored_name, con);
        cmd.CommandType = CommandType.StoredProcedure;
        foreach (SqlParameter prm in prmarr)
        {
            cmd.Parameters.Add(prm);
        }
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        da.Fill(ds, table_name);
        return ds;
    }
    #endregion



    #region Connected

    public static SqlDataReader GetDataReader(string stored_name, out SqlConnection conout, params SqlParameter[] prmarr)
    {
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand(stored_name, con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        foreach (SqlParameter prm in prmarr)
        {
            cmd.Parameters.Add(prm);
        }
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        conout = con;
        return dr;

    }

    public static int ExecuteNonQuery(string stored_name, params SqlParameter[] prmarr)
    {
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand(stored_name, con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        foreach (SqlParameter prm in prmarr)
        {
            cmd.Parameters.Add(prm);
        }
        con.Open();
        int x = cmd.ExecuteNonQuery();
        con.Close();
        return x;
    }

    public static object ExecuteScalar(string stored_name, params SqlParameter[] prmarr)
    {
        SqlConnection con = new SqlConnection(constr);
        SqlCommand cmd = new SqlCommand(stored_name, con);
        cmd.CommandType = System.Data.CommandType.StoredProcedure;
        foreach (SqlParameter prm in prmarr)
        {
            cmd.Parameters.Add(prm);
        }
        con.Open();
        object o = cmd.ExecuteScalar();
        con.Close();
        return o;
    }


    #endregion

}

