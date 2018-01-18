using FileGenerator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileGenerator.Serializer
{
    public interface ISerializer
    {
        string Serialize(Puid puid, PuidTestData data);
    }
}
