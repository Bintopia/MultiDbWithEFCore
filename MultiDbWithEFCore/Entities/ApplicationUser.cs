using System;
using Newtonsoft.Json;

namespace BinZone.Sample.EF.MultiDB.Entities
{
    public class ApplicationUser
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        [JsonIgnore]
        public string Password { get; set; }

        public string NickName { get; set; }

        public DateTime Created { get; set; }
    }
}
