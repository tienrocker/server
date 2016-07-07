﻿#if !UNITY_5_3_OR_NEWER
namespace Photon.LoadBalancing.Custom.Server.Operations.Responses
{
    using System.Collections.Generic;
    using Photon.SocketServer;
    using Photon.SocketServer.Rpc;
    using Custom.Common;
    using Interfaces;

    public class AnwserTextResponse : BaseResponse, IOperations
    {
        public AnwserTextResponse()
        {
        }

        public AnwserTextResponse(IRpcProtocol protocol, IDictionary<byte, object> parameter) : base(protocol, parameter)
        {
        }

        [DataMember(Code = Const.Data1, IsOptional = false)]
        public int Id { get; set; }

        [DataMember(Code = Const.Data2, IsOptional = false)]
        public string Text { get; set; }

        [DataMember(Code = MessageTag.KINGPLAY_OPERATION_TAG, IsOptional = false)]
        public int SubCode { get { return MessageTag.G_ANWSER_BUZZ; } }
    }
}
#endif