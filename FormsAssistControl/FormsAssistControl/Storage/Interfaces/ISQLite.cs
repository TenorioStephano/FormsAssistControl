using SQLite;

namespace FormsAssistControl.Storage.Interfaces
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
