namespace OurCommunityMediaColourFinder.Models;

public class ImageWithColour
{
    public string Path { get; set; }
    public string Brightest { get; set; }
    public string Average { get; set; }
    public string Opposite { get; set; }

    public string BrightestContrast { get; set; }
}
