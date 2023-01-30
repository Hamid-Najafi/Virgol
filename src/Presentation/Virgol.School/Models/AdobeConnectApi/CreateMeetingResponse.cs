using System;
using System.Xml.Serialization;
using Models.AdobeConnectApi;


[XmlRoot("results")]
public class MeetingInfoResponse
{
    public Status status {get;set;}
    [XmlElement("sco")]
    public SCO scoInfo {get;set;}
}
