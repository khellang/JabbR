namespace Chat.Models.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class RoomOwners : IDbMigrationMetadata
    {
        string IDbMigrationMetadata.Id
        {
            get { return "201111250044435_RoomOwners"; }
        }
        
        string IDbMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IDbMigrationMetadata.Target
        {
            get { return "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"; }
        }
    }
}
