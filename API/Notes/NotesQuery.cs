using GraphQL.Types;

namespace API.Notes;

public class NotesQuery : ObjectGraphType
{
    /// <summary>
    /// TODO: 3. Create the query for GraphQL. 
    /// I write the code at GraphQLNetExample/Notes/NotesQuery.cs. 
    /// This class is for you define your query definition. 
    /// You need to define the resolver, in this case we just use in-memory list.
    /// </summary>
    public NotesQuery()
    {
        Field<ListGraphType<NoteType>>("notes", resolve: context => new List<Note>() {
            new Note { Id = Guid.NewGuid(), Message = "Hello World!" },
            new Note { Id = Guid.NewGuid(), Message = "Hello World! How are you?" }
        });
    }
}