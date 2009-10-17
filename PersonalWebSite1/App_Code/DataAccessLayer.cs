using System.Data;

public class DataAccessLayer : IDataAccessLayer
{
    #region Implementation of IDataAccessLayer

    /// <summary>
    /// Get data for me
    /// </summary>
    /// <returns>A lotta data</returns>
    public DataSet GetData()
    {
        return new DataSet();
    }

    #endregion
}