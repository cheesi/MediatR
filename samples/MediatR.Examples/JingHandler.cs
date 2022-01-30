using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Examples;

public class JingHandler : AsyncRequestHandler<Jing>
{
    private readonly TextWriter _writer;

    public JingHandler(TextWriter writer)
    {
        _writer = writer;
    }

    public override Task Handle(Jing request, CancellationToken cancellationToken)
    {
        return _writer.WriteLineAsync($"--- Handled Jing: {request.Message}, no Jong");
    }
}