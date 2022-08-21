using API.Notes;
using Microsoft.EntityFrameworkCore;

namespace API.EntityFramework;

public class NotesContext : DbContext
{
    /// <summary>
    /// TODO: 7. Create DbContext. 
    /// My side, write at EntityFramework/NotesContext.cs.
    /// </summary>
    public DbSet<Note> Notes { get; set; }

    public NotesContext(DbContextOptions options) : base(options)
    {
        
    }
}
