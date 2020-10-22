using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shared.Models.Abstract
{
    public abstract class ImportDocument
    {
        public string ContentType { get; set; }
        public long Size { get; set; }
        public string FileName { get; set; }
    }
}
