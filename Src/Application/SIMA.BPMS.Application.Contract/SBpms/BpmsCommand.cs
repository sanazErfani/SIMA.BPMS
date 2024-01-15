

using Sima.Framework.Core.Mediator;
using SIMA.Framework.Common.Response;

namespace SIMA.BPMS.Application.Contract.SBpms;

public class BpmsCommand : ICommand<Result<long>>
{
    public string Data { get; set; }
}
