using Services.Interfaces;

namespace Adapters
{
    public class ImageAdapter : IImageAdapter
    {
        public string GenerateDog()
        {
            return "https://images.dog.ceo/breeds/hound-ibizan/n02091244_596.jpg";
        }
    }
}
