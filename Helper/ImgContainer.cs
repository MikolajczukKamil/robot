using System.Drawing;

namespace Helpers
{
    public class ImgContainer
    {
        Image[] imgs = new Image[4];

        public ImgContainer(Image img, int offset)
        {
            imgs[0] = Utils.RotateImage(img, offset - 0);
            imgs[1] = Utils.RotateImage(img, offset - 90);
            imgs[2] = Utils.RotateImage(img, offset - 180);
            imgs[3] = Utils.RotateImage(img, offset - 270);
        }

        public Image GetImageByAngle(int angle)
        {
            int part = Utils.To360Deg(angle) / 90;

            return imgs[part];
        }
    }
}
