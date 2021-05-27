using System;
using System.Collections.Generic;
using System.Text;

namespace AlbumMiniProjectShared.Contracts
{
    public interface IPhoto
    {
        int Id { get; set; }
        int AlbumId { get; set; }
        string Title { get; set; }
        string Url { get; set; }
        string ThumbnailUrl { get; set; }
    }

}
