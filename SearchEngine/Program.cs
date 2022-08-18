using SearchEngine.Context;
using System;

namespace SearchEngine
{
    class Program
    {
        private static readonly FileService _fileService = new FileService();
        private static readonly FileEntityContext _fileEntityContext = new FileEntityContext();
        private const string FILE_PATH = @"C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\Backup";
        
       /* public static Program()
        {
            _fileService = new FileService();
        }*/
        /*public Program(FileService fileService)
        {
            _fileService = fileService;
        }*/
        static void Main(string[] args)
        {
           var fileEntities = _fileService.GetFilesFromPath(FILE_PATH);
            _fileEntityContext.FileEntities.AddRange(fileEntities);

            _fileEntityContext.SaveChanges();
        }
    }
}
