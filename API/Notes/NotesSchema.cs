using GraphQL.Types;

namespace API.Notes;

public class NotesSchema : Schema
{
    /// <summary>
    /// TODO: 4. Create the schema for our Notes. 
    /// I write the code at GraphQLNetExample/Notes/NotesSchema.cs. 
    /// I use this class to register my query and define my schema.
    /// 
    /// TODO: 11. Register our Mutation to Schema. 
    /// Update Notes/NotesSchema.cs.
    /// </summary>
    /// <param name="serviceProvider"></param>
    public NotesSchema(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        Query = serviceProvider.GetRequiredService<NotesQuery>();
        Mutation = serviceProvider.GetRequiredService<NotesMutation>();
    }
        
}
