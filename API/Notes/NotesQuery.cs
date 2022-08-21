using API.EntityFramework;
using GraphQL.Types;

namespace API.Notes;

public class NotesQuery : ObjectGraphType
{
    /// <summary>
    /// TODO: 3. Create the query for GraphQL. 
    /// I write the code at GraphQLNetExample/Notes/NotesQuery.cs. 
    /// This class is for you define your query definition. 
    /// You need to define the resolver, in this case we just use in-memory list.
    /// 
    /// TODO: 10. Update our query: Notes/NotesQuery.cs. 
    /// Our final query will looks like this:
    /// </summary>
    public NotesQuery()
    {
        Field<ListGraphType<NoteType>>("notes", resolve: context => new List<Note>() {
            new Note { Id = Guid.NewGuid(), Message = "Hello World!" },
            new Note { Id = Guid.NewGuid(), Message = "Hello World! How are you?" }
        });

        Field<ListGraphType<NoteType>>("notesFromEF", resolve: context =>
        {
            var notesContext = context.RequestServices.GetRequiredService<NotesContext>();
            return notesContext.Notes.ToList();
        });
    }
}