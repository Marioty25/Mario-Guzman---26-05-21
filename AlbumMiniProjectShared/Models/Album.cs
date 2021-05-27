using Newtonsoft.Json;
using AlbumMiniProjectShared.Contracts;

namespace AlbumMiniProjectShared.Models
{
    public class Album : IAlbum
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("userId")]
        public int UserId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
