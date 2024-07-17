using Carsi.Shared.HELPERS.Abstract;
using Carsi.Shared.Response;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carsi.Shared.HELPERS.Concrete
{
    public class ImageHelper : IImageHelper

    {

        private string _imagesFolder;

        private readonly string [] permittedExtensions = {".png", ".jpg" , ".jpeg"};

        private readonly string [] permittedTypes  = {"image/png", "image/jpg" ,"image/jpeg" };
        public ImageHelper(IWebHostEnvironment   environment)
        {
            _imagesFolder = Path.Combine(environment.WebRootPath, "images");
        }


        public async Task<Response< string>> Upload(IFormFile file , string location)
        {
            if (file == null || file.Length==0)
            {
                return Response<string>.Failure("resim dosyasinda sorun var", 400);
            }
            var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
           
           
           
           
           
             if(String.IsNullOrEmpty(extension)  ||  !permittedExtensions.Contains(extension))
             {
                 return Response<string>.Failure("resim formati gecerli degil", 401);
             }
            if(!permittedTypes.Contains(file.ContentType))
            {
                return Response<string>.Failure("resim icerigini kontrol edin",401);
            }
            //asagidaki satiri ekleyerek wwwroot icindeki images klasorundeki farkli foto klasorlerine erisebilcez
            _imagesFolder = Path.Combine(_imagesFolder, location);
            if(Directory.Exists(_imagesFolder ))
            {
                Directory.CreateDirectory(_imagesFolder);
            }

            var FileName= $"{Guid.NewGuid()}{extension}";
            var fulpath = Path.Combine(_imagesFolder, FileName);
            await using ( var stream = new FileStream(fulpath, FileMode.Create))
            {
                 await file.CopyToAsync(stream); 
            };

            return Response<string>.Success($"/images/{FileName}" , 201);
        }
    }
}