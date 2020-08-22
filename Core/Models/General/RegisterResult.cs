using System.Collections.Generic;

namespace AgrixemBackend
{
    public class RegisterResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}
