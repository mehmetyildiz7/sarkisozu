using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvernote.Entities
{
    [Table("Songs")]
    public class Song
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SongId { get; set; }
        public string Name { get; set; }
        public string AlbumId { get; set; }
        public string ProducerName { get; set; }
        public string Lyrics { get; set; }
        public virtual Album Album { get; set; }

    }
}
