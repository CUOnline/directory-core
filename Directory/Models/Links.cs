using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Directory.Models
{
    public class Links
    {
        public IEnumerable<Link> StandaloneWebApps { get; set; }
        public IEnumerable<Link> LtiConfigs { get; set; }
        public IEnumerable<Link> Other { get; set; }
    }

    public class Link
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
