using Grpc.Core;
using gRPCServer.Data;
using gRPCServer.Protos;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gRPCServer.Services
{
    public class CatagoryService : Catagory.CatagoryBase
    {
        private readonly ILogger<CatagoryService> _logger;
        public CatagoryService(ILogger<CatagoryService> logger)
        {
            _logger = logger;
        }

        public override async Task GetAllCatagory(GetAllCatagoryRequest request, IServerStreamWriter<CatagoryModel> responseStream, ServerCallContext context)
        {
            var allCatagory = CatagoryData.CatagoryModels.ToList();
            foreach (var Catagory in allCatagory)
            {
                await responseStream.WriteAsync(Catagory);
            }
        }
    }
}
