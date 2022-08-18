using System;
using System.ComponentModel.DataAnnotations;

namespace SearchEngine.Models
{
    internal class FileEntity
    {
        public Guid Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(5)]
        public string Extension { get; set; }
        [StringLength(500)]
        public string FullPath { get; set; }
        public long SizeInKb { get; set; }
    }
}
