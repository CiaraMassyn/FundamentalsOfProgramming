using Services.Interfaces;

namespace Services.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageAdapter _imageAdapter;

        public ImageService(IImageAdapter imageAdapter) 
        { 
            _imageAdapter = imageAdapter;
        }

        public string GenerateDog()
        {
            return _imageAdapter.GenerateDog();
        }
    }
}
