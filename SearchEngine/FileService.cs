using SearchEngine.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchEngine
{
    internal class FileService
    {
        public List<FileEntity> GetFilesFromPath(string path)
        {
            var files = Directory.GetFiles(path);
            var fileEntities = new List<FileEntity>();
            foreach (var file in files)
            {
                if (file == null) continue;
                fileEntities.Add(GetFileEntityFromPath(file));

            }
            return fileEntities;
        }
        private FileEntity GetFileEntityFromPath(string path)
        {
            var entity = new FileEntity();
            var fileInfo = new FileInfo(path);
            entity.Id = Guid.NewGuid();
            entity.Name = Path.GetFileNameWithoutExtension(path);
            entity.SizeInKb = fileInfo.Length / 1024;
            entity.Extension = fileInfo.Extension;
            entity.FullPath = fileInfo.FullName;
            return entity;
        }
    }
}
