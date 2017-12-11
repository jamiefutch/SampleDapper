using System;
using System.Data.SqlClient;



namespace SampleDapper.BaseClasses
{
    public abstract class RepoBase : IDisposable 
    {
        
        protected readonly SqlConnection _conn;
        private string _dbConnectionString;

        protected RepoBase(string dbConnectionString)
        {
            _dbConnectionString = dbConnectionString;
            _conn = new SqlConnection(_dbConnectionString);

            try
            {
                _conn.Open();
            }
            catch (Exception ex)
            {
                // log error here 
            }
        }
        
        
        #region destructor
        /// <summary>
        /// Destructor
        /// </summary>        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // free managed resources  
                try
                {
                    _conn.Close();
                    _dbConnectionString = string.Empty;
                }
                catch (Exception ex)
                {
                    // log error here
                }
            }
        }
        #endregion
        
    }
}