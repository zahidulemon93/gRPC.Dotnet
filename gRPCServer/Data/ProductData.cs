using gRPCServer.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gRPCServer.Data
{
    public static class CatagoryData
    {
        public static List<CatagoryModel> CatagoryModels = new List<CatagoryModel>
    {
        new CatagoryModel
        {
            Name = "Shirt",
           
        },
        new CatagoryModel
        {
            Name = "Pant",
        }
    };
    }
}
