using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SIMA.BPMS.Application.Contract.SBpms;
using SIMA.Framework.Common.Response;

namespace SIMA.BPMS.WebApi.Controllers.UploadFile
{
    [Route("api/[controller]")]
    [ApiController]
    public class BPMSCommandController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BPMSCommandController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<Result> Post([FromBody] BpmsCommand command)
        {
            return await _mediator.Send(command);
        }
    }
}
