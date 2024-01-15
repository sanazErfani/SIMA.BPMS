using SIMA.BPMS.Application.Contract.SBpms;
using SIMA.Framework.Common.Response;
using SIMA.Framework.Core.Mediator;
using System.Xml;

//using System.Xml;
using System.Xml.Linq;
namespace SIMA.BPMS.Application.SBpms;

public class BpmsCommandHandler : ICommandHandler<BpmsCommand, Result<long>>
{
    public Task<Result<long>> Handle(BpmsCommand request, CancellationToken cancellationToken)
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(request.Data);
        XDocument ff = new XDocument();
        ///todo 
        
        //Dictionary<string, Func<object>> elementToInstanceMapping = new Dictionary<string, Func<object>>
        //{
        //    {"bpmn:participant", () => new Participant()},
        //    {"bpmn:process", () => new Process()},
        //    {"bpmn:lane", () => new Lane()},
        //    {"bpmn:userTask", () => new UserTask()},
        //    {"bpmn:serviceTask", () => new ServiceTask()},
        //    {"bpmn:exclusiveGateway", () => new ExclusiveGateway()},
        //    {"bpmn:startEvent", () => new StartEvent()},
        //    {"bpmn:endEvent", () => new EndEvent()}
        //};

        //using (XmlReader reader = xmlDoc.creater)
        //{

        //}


        return null;
    }
}
