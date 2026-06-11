using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using University.Data;
using University.Dto;
using University.Models;
using University.ServiceInterface;
using University.ViewModel.CoursesVM;

namespace University.Services
{
    public class FileServices : IFileServices
    {
        private readonly IHostEnvironment _webhost;
        private readonly UniversityContext _context;

        public FileServices
            (
               IHostEnvironment webhost,
              UniversityContext context
            )
        {
            _webhost = webhost;
            _context = context;
        }

        public void FilesToApi(CourseDto dto, Course domain)
        {
            //if'iga tuloeb tingimus, kui File ei ole null või on vähemalt rohkemlt,
            // kui 0 faili
            if (dto.Files != null && dto.Files.Count > 0)
            {
                if(!Directory.Exists(_webhost.ContentRootPath + "\\wwwroot\\multipleFileUpload\\"))
                {
                    Directory.CreateDirectory("\\wwwroot\\multipleFileUpload\\");
                }

                foreach (var file in dto.Files)
                {
                    string uploadsFolder = Path.Combine(_webhost.ContentRootPath, "wwwroot", "multipleFileUpload");
                    string uniqueFileName = Guid.NewGuid().ToString() + " - " + file.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(fileStream);

                        FileToApi path = new FileToApi
                        {
                            Id = Guid.NewGuid(),
                            ExistingFilePath = uniqueFileName,
                            CourseId = domain.CourseId
                        };

                        _context.FileToApis.Add(path);

                    }
                }

            }
        }

        public async Task<FileToApi?> RemoveImageFolder(FileToApiDto dto)
        {
            //kui soovin kustudata, siis pean läbi Id pildi ülesse otsima
            var imageId = await _context.FileToApis
                .FirstOrDefaultAsync(x => x.Id == dto.Id);

            //nüüd otsib faili ülesse apis ja see kustutatakse ära
            var filePath = _webhost.ContentRootPath + "\\wwwroot\\multipleFileUpload\\"
                + imageId.ExistingFilePath;

            if(File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            _context.FileToApis.Remove(imageId);
            await _context.SaveChangesAsync();

            return null;
        }
    }
}
