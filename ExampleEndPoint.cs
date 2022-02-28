using FastEndpoints;

namespace ApiMinima;
public class ExampleEndPoint : EndpointWithoutRequest
{
    public override void Configure()
    {
        Verbs(Http.GET);
        Routes("exaple");
        AllowAnonymous();
    }


//public override async  HandleAsync
    public override async Task HandleAsync( CancellationToken ct)
    {
        await SendAsync(new 
        {message= "Hello RB"
         }, cancellation:ct);
    }
}

