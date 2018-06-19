using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
  class DataConn
  {
    #region Fields
    private static SqlDataAdapter adapter;
    private static SqlCommandBuilder cmd;
    private static DataSet ds;
    private static SqlConnection conn;
    private string connStr;
    #endregion

    #region Constructor
    public DataConn()
    {
      connStr = @"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=SEN_Exam;Integrated Security=True";
      connStr = @"Data Source=TRACKDS1G014723;Initial Catalog=ExamDB;Integrated Security=True";

      ds = new DataSet();
    }
    #endregion

    #region Methods
    public DataSet Read(string table)
    {
      using (conn = new SqlConnection(connStr))
      {
        using (adapter = new SqlDataAdapter("SELECT * FROM " + table, conn))
        {
          using (cmd = new SqlCommandBuilder(adapter))
          {
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(ds, table);
          }
        }
      }
      return ds;
    }

    public bool Write(DataSet UpdDS, string table)
    {
      using (conn = new SqlConnection(connStr))
      {
        using (adapter = new SqlDataAdapter("SELECT * FROM " + table, conn))
        {
          using (cmd = new SqlCommandBuilder(adapter))
          {
            adapter.Update(UpdDS, table);
            return true;
          }
        }
      }
    }
    #endregion
  }
}
