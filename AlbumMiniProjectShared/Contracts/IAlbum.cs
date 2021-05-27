using System;
using System.Collections.Generic;
using System.Text;

namespace AlbumMiniProjectShared.Contracts
{
    interface IAlbum
    {
         int Id { get; set; }
         int UserId { get; set; }
         string Title { get; set; }
    }

}
