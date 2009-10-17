using System.Data;

public interface IDataAccessLayer
{

    /// <summary>
    /// Get data for me
    /// </summary>
    /// <returns>A lotta data</returns>
    DataSet GetData();

}