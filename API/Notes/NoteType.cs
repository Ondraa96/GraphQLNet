using GraphQL.Types;

namespace API.Notes;

public class NoteType : ObjectGraphType<Note>
{
    /// <summary>
    /// TODO: 2. Create NoteType.cs in GraphQLNetExample/Notes.
    /// This class is the type definition for GraphQL.
    /// </summary>
    public NoteType()
    {
        Name = "Note";
        Description = "Note Type";
        Field(d => d.Id, nullable: false).Description("Note Id");
        Field(d => d.Message, nullable: true).Description("Note Message");
    }
}
