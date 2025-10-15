namespace SimpleAPI.Extensions
{
    public static class MinimalAPI
    {
        public static void MapEndpoints(this WebApplication app)
        {
            var group = app.MapGroup("api");
            group.MapGet("/names", () =>
            {
                
                return Results.Ok(new string[] {
                    "Jeff",
                    "james",
                    "John",
                    "Jeff",
                    "Ashton"
                });

            });

        }
    }
}