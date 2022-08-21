using API.EntityFramework;
using GraphQL;
using GraphQL.Types;

namespace API.Notes;

/// <summary>
/// TODO: 9. Create a Mutation file, Notes/NotesMutation.cs. 
/// We use string type because we only have 1 field only, 
/// but if we have larger columns, I suggest to write our input type.
/// </summary>
public class NotesMutation : ObjectGraphType
{
    public NotesMutation()
    {
        Field<NoteType>("createNote", arguments: new QueryArguments(
                new QueryArgument<NonNullGraphType<StringGraphType>> { Name = "message" }
            ),
            resolve: context =>
            {
                var message = context.GetArgument<string>("message");
                var notesContext = context.RequestServices.GetRequiredService<NotesContext>();
                var note = new Note
                {
                    Message = message,
                };
                notesContext.Notes.Add(note);
                notesContext.SaveChanges();
                return note;
            });
    }
}
