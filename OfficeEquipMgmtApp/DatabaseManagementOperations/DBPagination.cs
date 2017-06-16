using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseManagementOperationsLibrary
{
    public class DBPagination
    {
        //DB Pagination
        protected SqlConnection sqlPage;
        public int totalRecords, pageSize, pageCount;
        public int currPage = 1;

        // Form Controls
        DatabaseOperations db;
        DataGridView datagrid;
        NumericUpDown itemPerPageUpDown, pageSelector;

        public DBPagination(DatabaseOperations db, DataGridView datagrid, NumericUpDown itemPerPageUpDown, NumericUpDown pageSelector)
        {
            this.db = db;
            this.datagrid = datagrid;
            this.itemPerPageUpDown = itemPerPageUpDown;
            this.pageSelector = pageSelector;
        }

        public void ReCount()
        {
            //DB Pagination Initalizers
            // For Page view.
            pageSize = int.Parse(itemPerPageUpDown.Text);
            totalRecords = getResultCount();
            pageCount = totalRecords / pageSize;

            // Adjust page count if the last page contains partial page.
            if (totalRecords % pageSize > 0)
                this.pageCount++;

            if (getResultCount() == 0)
                pageSelector.Maximum = 1;
            else
                pageSelector.Maximum = pageCount;

            loadPage();
        }

        /// <summary>
        /// Fills the DS with the user-specifide parameters
        /// </summary>
        public void loadPage()
        {
            string strSql;
            int intSkip = 0;

            intSkip = (currPage * pageSize);

            // Select only the n records.
            strSql = "SELECT TOP " + pageSize +
                " * FROM Equipment WHERE ID NOT IN " +
                "(SELECT TOP " + intSkip + " ID FROM Equipment)";

            sqlPage = new SqlConnection(db.StrConn);

            var cmd = new SqlCommand(strSql, sqlPage);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Equipment");

            // Populate Data Grid
            datagrid.DataMember = "Equipment";
            datagrid.DataSource = ds;
            //// Show Status
            //this.lblStatus.Text = (currPage + 1).ToString() +
            //  " / " + pageCount.ToString();

            cmd.Dispose();
            da.Dispose();
            ds.Dispose();
            SqlConnection.ClearAllPools();
        }

        public int getResultCount()
        {
            // This select statement is very fast compared to SELECT COUNT(*)
            string strSql = "SELECT rows FROM sys.sysindexes " +
                            "WHERE id = OBJECT_ID('Equipment') AND indid < 2";
            int intCount = 0;

            sqlPage = new SqlConnection(db.StrConn);

            var cmd = new SqlCommand(strSql, sqlPage);

            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                sqlPage.Open();
                intCount = (int)cmd.ExecuteScalar();
                cmd.Dispose();
                sqlPage.Close();
            }

            SqlConnection.ClearAllPools();
            return intCount;
        }

        public void goFirst()
        {
            if (getResultCount() == 0)
                return;

            currPage = 0;

            pageSelector.Value = currPage + 1;
        }

        public void goPrevious()
        {
            if (getResultCount() == 0)
                return;

            if (currPage == pageCount)
                currPage = pageCount - 1;

            currPage--;

            if (currPage < 1)
                currPage = 0;

            pageSelector.Value = currPage + 1;
        }

        public void goNext()
        {
            if (getResultCount() == 0)
                return;

            currPage++;

            if (currPage > (pageCount - 1))
                currPage = (pageCount - 1);

            pageSelector.Value = currPage + 1;
        }

        public void goLast()
        {
            if (getResultCount() == 0)
                return;

            currPage = pageCount - 1;

            pageSelector.Value = currPage + 1;
        }

    }
}
