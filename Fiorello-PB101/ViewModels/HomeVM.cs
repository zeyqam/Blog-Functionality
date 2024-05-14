using Fiorello_PB101.Models;

namespace Fiorello_PB101.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public SliderInfo SliderInfo { get; set; }
    }
}
